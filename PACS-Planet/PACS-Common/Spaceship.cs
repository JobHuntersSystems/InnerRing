using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACS_Common
{
    public static class Spaceship
    {
        public static int id { get; set; } = 0;
        public static string code { get; set; }
        public static string ip { get; set; }
        public static int dataPort { get; set; }
        public static int filePort { get; set; }
        public static string imagePath { get; set; }
        public static int CurrentStage { get; set; } = 0;
        public static ProcessStatus Status { get; set; } = ProcessStatus.InProgress;
        public static int CheckSum { get; set; }

        public static void Reset()
        {
            id = 0;
            code = null;
            ip = null;
            dataPort = 0;
            filePort = 0;
            imagePath = null;
            CurrentStage = 0;
            Status = ProcessStatus.InProgress;
            CheckSum = 0;
    }
    }

    public enum ProcessStatus
    {
        InProgress,
        Completed,
        Failed
    }
}
