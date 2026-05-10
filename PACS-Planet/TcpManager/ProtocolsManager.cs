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
using System.IO;

namespace TcpManager
{
    public class ProtocolsManager
    {
        private DB_CRUD dbManger;
        public MessageProtocolType identifyProtocolType(string message)
        {
            MessageProtocolType type;

            if (Regex.IsMatch(message, @"^ER.{24}$"))
            {
                type = MessageProtocolType.ER;
            }
            else if (Regex.IsMatch(message, @"^VR.{24}$"))
            {
                type = MessageProtocolType.VR;
            }
            else
            {
                type = MessageProtocolType.Message;
            }
            return type;
        }
        private List<string> decodeMessage(MessageProtocolType type, string message)
        {
            List<string> code_parts = new List<string>();
            switch (type)
            {
                case MessageProtocolType.ER:
                    string spaceship_code = message.Substring(2, 12);
                    string delivery_code = message.Substring(14, 12);

                    code_parts.Add(spaceship_code);
                    code_parts.Add(delivery_code);
                    break;
                case MessageProtocolType.VR:
                    break;
                case MessageProtocolType.Message:
                    break;
            }
         
            return code_parts;
        }
        #region ER Protocol
        private ResultType validateDelivery(string spaceship_code, string delivery_code)
        {
            ResultType result = ResultType.AD;
            DataSet db;

            //Creamos una instacia del manager
            if (dbManger == null)
                dbManger = new DB_CRUD();

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
            
                //Buscamos en la db si hay alguna entrega agendada con el DeliveryCode y SpaceShipCode recibidos 
                query = "SELECT *" +
                    "FROM DeliveryData " +
                    $"WHERE idSpaceShip = '{Spaceship.id}'" +
                    $"AND CodeDelivery = '{delivery_code}';";

                db = dbManger.PortarPerConsulta(query);
                //Si se encuentra algun registro, devolvemos una respuesta afirmativa
                if (db.Tables[0].Rows.Count > 0)
                    result = ResultType.VP;
            }
            return result;
        }
        int protocol_stage = 0;
        public ProtocolResponse excuteERProtocol(string code)
        {
            ProtocolResponse response = new ProtocolResponse();
            string message_response ="VR";
            protocol_stage += 1;

            MessageProtocolType type = MessageProtocolType.ER;
            List<string> messageDecoded = decodeMessage(type, code);
            string delivery_code = messageDecoded[0];
            string spaceship_code = messageDecoded[1];


            ResultType validation = validateDelivery(delivery_code, spaceship_code);

            message_response += protocol_stage
                  + spaceship_code
                  + (validation == ResultType.VP ? "VP" : "AD");

            response = new ProtocolResponse()
            {
                logLevel = (validation == ResultType.VP ? LogLevel.Success : LogLevel.Warn),
                protocolResponse = message_response
            };

            //En el caso de ser negativo, reiniciamos el numero de la fase del protocolo
            if (validation == ResultType.AD)
                protocol_stage = 0;

            return response;
        }
        #endregion
    }
    public class ProtocolResponse
    {
        public LogLevel logLevel { get; set; }
        public string protocolResponse { get; set; }
    }
}
