using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.PW.Xml;
using System.Drawing;

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
            //if(Registry.CurrentConfig.OpenSubKey("Software\\AFRMonitor") == null)
            //{
            //    RegistryKey key = Registry.CurrentConfig.CreateSubKey("Software\\AFRMonitor");
            //    key.SetValue("TrialOpen", 31);
            //    key.Close();
            //}

            //if(Registry.CurrentUser.OpenSubKey("Software\\AFRMonitor") == null)
            //{
            //    RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\AFRMonitor");
            //    key.SetValue("Activation", 0x03029876);
            //    key.SetValue("LastKnownTime", 31);
            //    key.Close();
            //}
            Start:
            // Activation XML
            if(!Directory.Exists("C:\\ProgramData\\AFR Monitor"))
            {
                Directory.CreateDirectory("C:\\ProgramData\\AFR Monitor");
            }
            if (!File.Exists("C:\\ProgramData\\AFR Monitor" + "\\Activation.xml"))
            {
                var elements = new Dictionary<string, string>
                {
                    {
                        "Activated", "50501750"
                    },
                    {
                        "TrialDays", "31"
                    }
                };
                new EasyXML(Helper.ActivationXmlLocation, elements);
                File.SetAttributes(Helper.ActivationXmlLocation, FileAttributes.Hidden);
            }
            else
            {
                if(!EasyXML.TryLoad(Helper.ActivationXmlLocation))
                {
                    File.Delete(Helper.ActivationXmlLocation);
                    goto Start;
                }
            }

            // Settings XML
            if(!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\AFR Monitor"))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\AFR Monitor");
            }
            if(!File.Exists(Helper.SettingsXmlLocation))
            {
                var elements = new Dictionary<string, string>
                {
                    {
                        "LineColor", "#" + Color.Red.R.ToString("X2") + Color.Red.G.ToString("X2") + Color.Red.B.ToString("X2")
                    },
                    {
                        "WarningLineColor", "#" + Color.Black.R.ToString("X2") + Color.Black.G.ToString("X2") + Color.Black.B.ToString("X2")
                    }
                };

                new EasyXML(Helper.SettingsXmlLocation, elements);
            }
            else
            {
                if (!EasyXML.TryLoad(Helper.SettingsXmlLocation))
                {
                    File.Delete(Helper.SettingsXmlLocation);
                    goto Start;
                }
            }

            Helper.ValidActivationKeys[0] = "p1tr99234qnw";
            Helper.ValidActivationKeys[1] = "p2dz27273urw";
            Helper.ValidActivationKeys[2] = "p3nh58983ftw";
            Helper.ValidActivationKeys[3] = "p4we98043nnw";
            Helper.ValidActivationKeys[4] = "p5io69270mow";

            /*try { */Application.Run(new Starter()); //} catch { }
        }
    }
}
