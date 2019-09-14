using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFRMonitor
{
    class Helper
    {
        public static int UsageVariable = 0; // 1 = Voice Control, 2 = Button Control
        public static double LowestValue = int.MaxValue;
        public static bool CountDown = false;
        public static bool LongScanMode = false;
        public static string ReadFileLocation = "";

        /* Errors
         *
         * Code 1: Voice Control Recognized unrecognizable word
         * Code 2: Voice Control No Default Audio Device
         */
    }
}
