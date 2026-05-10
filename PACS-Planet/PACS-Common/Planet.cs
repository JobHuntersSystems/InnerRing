using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACS_Common
{
    public static class Planet
    {
        //Tatooine default
        public static int idPlanet { get; set; } = 7;
        public static string CodePlanet { get; set; } = "TATO";
        public static string DescPlanet { get; set; } = "Tatooine";
        public static string PlanetPicture { get; set; } = "Imagenes/Tatooine.png";
        public static string IPPlanet { get; set; } = "127.0.0.1";
        public static string PortPlanet { get; set; } = "3007";
        public static string PortPlanet1 { get; set; } = "4007";
    }
}
