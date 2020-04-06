﻿using System.PW.Xml;
using System;
using System.Collections.Generic;
using System.IO;

namespace AFRMonitor
{
    abstract class Helper
    {
        public static string ActivationFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\AFR Monitor";
        public static string ActivationXmlLocation = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\AFR Monitor\\Activation.xml";
        public static string SettingsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\AFR Monitor";
        public static string SettingsXmlLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\AFR Monitor\\config\\cfg.xml";
        //public static string TempFolder = Path.GetTempPath() + "\\AFR Monitor";
        private static EasyXML xml = new EasyXML(ActivationXmlLocation);

        public static bool ForceQuit { get; private set; } = false;

        public static bool ToggleForceQuit(bool tof)
        {
            return ForceQuit = tof;
        }

        public static bool Restart = false;

        //public static RegistryKey AFRTrialKey = Registry.CurrentConfig.OpenSubKey("Software\\AFRMonitor", true);
        //public static RegistryKey AFRRegistryKey = Registry.CurrentUser.OpenSubKey("Software\\AFRMonitor", true);
        public static int UsageVariable = 0; // 1 = Voice Control, 2 = Button Control
        public static double LowestValue = int.MaxValue;
        public static bool CountDown = false;
        public static bool UnlimitedMode = false;
        public static string ReadFileLocation = string.Empty;
        public static double WarningSlider = 0;
        public static int LowBoostBHP = 0;
        public static int HighBoostBHP = 0;
        public static double InputInterval = 200;
        public static string Pass = "DjPatrick0302";
        public static string Version = string.Empty;
        public static bool IsActivated()
        {
                if (xml.Elements.GetInnerText("/Root/Activated") == "50470916") // true
                {
                    return true;
                }
                else if (xml.Elements.GetInnerText("/Root/Activated") == "50501750") // false
                {
                    return false;
                }
                else
                {
                    // Error 3, xml not working properly
                    return false;
                }

        }

        public static string VoiceControlManual()
        {
            return "\b1: \rCheck if a speech language is configured: Open settings\nClick Time & Language\nClick on the left: Language\nAnd add under preferred languages the language that you are going to use. (English if possible)\n" +
                "When created (or already was created): click on it and click on Options\nMake sure you've downloaded Speech.\nRestart AFR Monitor\n\n\b2: \rCheck if your selected default microphone is your microphone that you use\n" +
                "Right click on the speaker in the taskbar\nClick on Open sound settings\n(Open fullscreen) On the right click on Sound control panel\n(This opens up a sound control panel)\n" +
                 "At the top click on Recording\nAnd set your microphone that you're using as the default microphone.\nRestart AFR Monitor";
        }
            //public static void UpdateActivation(bool ToTrue)
            //{
            //    if(ToTrue)
            //    {
            //        Helper.AFRRegistryKey.SetValue("Activation", 0x03022004);
            //        Helper.AFRRegistryKey.Close();
            //    }
            //    else
            //    {
            //        Helper.AFRRegistryKey.SetValue("Activation", 0x03029876);
            //        Helper.AFRRegistryKey.Close();
            //    }
            //}

        //public static string GetTrialDaysLeft()
        //{
        //    return AFRTrialKey.GetValue("TrialOpen").ToString();
        //}

        //public static string GetSaveTrialDaysLeft()
        //{
        //    return AFRRegistryKey.GetValue("LastKnownTime").ToString();
        //}

        //public static void SubtractTrialDays(int value)
        //{
        //    int newValue = Convert.ToInt32(AFRTrialKey.GetValue("TrialOpen")) - value;

        //    AFRTrialKey.SetValue("TrialOpen", newValue);
        //    AFRRegistryKey.SetValue("LastKnownTime", newValue);
        //}

        //public static void SetTrialDaysLeft(int value)
        //{
        //    AFRTrialKey.SetValue("TrialOpen", value);
        //    AFRRegistryKey.SetValue("LastKnownTime", value);
        //}

        /* Errors
         *
         * Code 1: Voice Control Recognized unrecognizable word
         * Code 2: Voice Control No Default Audio Device
         * Code 3: Registry not working properly
         */
        }
}
