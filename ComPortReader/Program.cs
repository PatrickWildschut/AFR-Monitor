﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFRMonitor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if(Registry.CurrentConfig.OpenSubKey("Software\\AFRMonitor") == null)
            {
                RegistryKey key = Registry.CurrentConfig.CreateSubKey("Software\\AFRMonitor");
                key.SetValue("TrialOpen", 31);
                key.Close();
            }

            if(Registry.CurrentUser.OpenSubKey("Software\\AFRMonitor") == null)
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\AFRMonitor");
                key.SetValue("Activation", 0x03029876);
                key.SetValue("LastKnownTime", 31);
                key.Close();
            }

            Helper.ValidActivationKeys[0] = "p1tr99234qnw";
            Helper.ValidActivationKeys[1] = "p2dz27273urw";
            Helper.ValidActivationKeys[2] = "p3nh58983ftw";
            Helper.ValidActivationKeys[3] = "p4we98043nnw";
            Helper.ValidActivationKeys[4] = "p5io69270mow";

            Application.Run(new Starter());
        }
    }
}
