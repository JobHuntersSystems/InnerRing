using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using PACS_Common;
using Inner_DB_Access;
using System.Data;
using System.Data.SqlClient;
using PACS_Center;


namespace ProtocolsManager
{
    public class ProtocolManager
    {
        private DB_CRUD dbManger = new DB_CRUD();
        private RSADecrypt rsaManager = new RSADecrypt();
        private DataSet db;
        public MessageProtocolType identifyProtocolType(string message)
        {
            MessageProtocolType type;

            if (Regex.IsMatch(message, @"^ER.{24}$"))
            {
                type = MessageProtocolType.ER;
            }
            else if (Regex.IsMatch(message, @"^VK"))
            {
                type = MessageProtocolType.VK;
            }
            else
            {
                type = MessageProtocolType.Message;
            }
            return type;
        }
        private List<string> decodeMessage(string message)
        {
            List<string> code_parts = new List<string>();
            string spaceship_code = message.Substring(2, 12);
            string delivery_code = message.Substring(14, 12);

            code_parts.Add(spaceship_code);
            code_parts.Add(delivery_code);

            return code_parts;
        }
        public void idenifySpaceship(string spaceship_code)
        {
            //Buscamos en la db la información de la nace
            string query = "SELECT *" +
                "FROM SpaceShips " +
                $"WHERE CodeSpaceShip = '{spaceship_code}';";

            db = dbManger.PortarPerConsulta(query);

            //Agregamos todos los datos de la nave
            if (db.Tables[0].Rows.Count > 0)
            {
                var table = db.Tables[0];
                Spaceship.id = int.Parse(table.Rows[0]["idSpaceShip"].ToString());
                Spaceship.code = table.Rows[0]["CodeSpaceShip"].ToString();
                Spaceship.dataPort = int.Parse(table.Rows[0]["PortSpaceShip"].ToString());
                Spaceship.filePort = int.Parse(table.Rows[0]["PortSpaceShip1"].ToString());
                Spaceship.imagePath = table.Rows[0]["SpaceshipImage"].ToString();
            }
        }
        public ProtocolResponse getDefaultDenegationResponse()
        {
            ProtocolResponse response;
            string message_response = "VR";
            message_response += Spaceship.CurrentStage
                + Spaceship.code
                + "AD";

            response = new ProtocolResponse()
            {
                result = ResultType.AD,
                protocolResponse = message_response
            };
            return response;
        }
        #region ER Protocol
        private ResultType validateDelivery(string spaceship_code, string delivery_code)
        {
            ResultType result = ResultType.AD;

            idenifySpaceship(spaceship_code);
            if (Spaceship.id != 0)
            {
                //Buscamos en la db si hay alguna entrega agendada con el DeliveryCode y SpaceShipCode recibidos 
                string query = "SELECT *" +
                    "FROM DeliveryData " +
                    $"WHERE idSpaceShip = '{Spaceship.id}'" +
                    $"AND CodeDelivery = '{delivery_code}';";

                db = dbManger.PortarPerConsulta(query);

                //Si se encuentra algun registro, devolvemos una respuesta afirmativa y avanzamos en el estado del protocolo
                if (db.Tables[0].Rows.Count > 0)
                {
                    result = ResultType.VP;
                    
                }
            }

            return result;
        }
        public ProtocolResponse excuteErProtocol(string code)
        {
            ProtocolResponse response;
            string message_response = "VR";
            Spaceship.CurrentStage += 1;
            List<string> messageDecoded = decodeMessage(code);
            string spaceship_code = messageDecoded[0];
            string delivery_code = messageDecoded[1];


            ResultType validation = validateDelivery(delivery_code, spaceship_code);

            message_response += Spaceship.CurrentStage
                  + Spaceship.code
                  + (validation == ResultType.VP ? "VP" : "AD");

            response = new ProtocolResponse()
            {
                result = validation,
                protocolResponse = message_response
            };

            return response;
        }
        #endregion
        #region VK Protocol
        private ResultType validateEncryptedCode(string code)
        {
            ResultType result = ResultType.AD;

            //Buscamos en la db la información de la nace
            string query = "SELECT *" +
                "FROM InnerEncryption " +
                $"WHERE ValidationCode = '{code}';";

            db = dbManger.PortarPerConsulta(query);
            //Si se encuentra alguna coincidendia, se da por valido el resultado y se desplaza el CurrentStage
            if (db.Tables[0].Rows.Count > 0)
            {
                result = ResultType.VP;

            }
            return result;
        }
        public ProtocolResponse excuteVkProtocol(string code)
        {
            ProtocolResponse response;
            string message_response = "VR";
            Spaceship.CurrentStage += 1;
            string code_decrypted = rsaManager.DecryptMessage(Planet.idPlanet, code);
            ResultType validation = validateEncryptedCode(code_decrypted);

            message_response += Spaceship.CurrentStage
                 + Spaceship.code
                 + (validation == ResultType.VP ? "VP" : "AD");

            response = new ProtocolResponse()
            {
                result = validation,
                protocolResponse = message_response
            };

            return response;
        }
        #endregion
    }
}
