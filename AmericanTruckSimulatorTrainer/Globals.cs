using AmericanTruckSimulatorTrainer.StylingFramework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmericanTruckSimulatorTrainer
{
    class Globals
    {
        #region Trainer
        public static bool foundgame = false;
        public static string procname = "amtrucks.exe";
        public static string windowname = "American Truck Simulator";
        public static Process proc = null;
        public static bool enabled = false;
        #endregion

        #region Gif
        public static GIF gifImage = null;
        public static string gifPath = @"C:\Users\gamec\Pictures\giphy.gif";
        #endregion
    }
}
