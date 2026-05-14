using System;

namespace PACS_SpaceShips_Common
{
    public static class ConnectionInfo
    {
        //CREDENCIALES DE LA NAVE
        public static string ShipID { get; set; } = string.Empty;
        public static string DeliveryID { get; set; } = string.Empty;
        public static int SpaceShipPort { get; set; }
        public static int SpaceShipPort1 { get; set; }

        // DATOS DEL PLANETA
        public static string TargetPlanetIP { get; set; } = "127.0.0.1";
        public static int PlanetDataPort { get; set; } = 5050; 
        public static int PlanetFilePort { get; set; } = 5051;
        public static string EncryptedValidationCode { get; set; } = string.Empty;
        public static string PlanetKey { get; set; } = string.Empty;


        public static string GetERMessage()
        {
            // Nos aseguramos de que tengan exactamente 12 caracteres (rellenando con '0' si faltan)
            string sID = ShipID.PadRight(12, '0').Substring(0, 12);
            string dID = DeliveryID.PadRight(12, '0').Substring(0, 12);

            return $"ER{sID}{dID}";
        }
    }
}