using System;

namespace PACS_SpaceShips_Common
{
    public static class ConnectionInfo
    {
        // --- CREDENCIALES DE LA NAVE ---
        public static string ShipID { get; set; } = string.Empty;
        public static string DeliveryID { get; set; } = string.Empty;

        // --- DATOS DEL PLANETA DESTINO ---
        public static string TargetPlanetIP { get; set; } = "127.0.0.1";

        // Según tu diseño anterior, sabemos que hay dos puertos separados
        public static int PlanetDataPort { get; set; } = 5050; // Puerto para mensajes TCP
        public static int PlanetFilePort { get; set; } = 5051; // Puerto para el ZIP

        // --- MÉTODOS DE UTILIDAD DEL PROTOCOLO ---

        /// <summary>
        /// Genera la cadena del mensaje inicial ER respetando la norma:
        /// ER + 12 caracteres de Ship + 12 caracteres de Delivery
        /// </summary>
        public static string GetERMessage()
        {
            // Nos aseguramos de que tengan exactamente 12 caracteres (rellenando con '0' si faltan)
            string sID = ShipID.PadRight(12, '0').Substring(0, 12);
            string dID = DeliveryID.PadRight(12, '0').Substring(0, 12);

            return $"ER{sID}{dID}";
        }
    }
}