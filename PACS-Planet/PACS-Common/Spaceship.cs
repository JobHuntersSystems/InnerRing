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

        public static void Reset()
        {
            CurrentStage = 0;
            Status = ProcessStatus.InProgress;
        }
    }

    public enum ProcessStatus
    {
        InProgress,
        Completed,
        Failed
    }
}
