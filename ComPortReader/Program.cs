using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.PW.Xml;
using System.Drawing;
using System.Reflection;

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
            if(!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\AFR Monitor"))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\AFR Monitor");
            }
            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\AFR Monitor\\Activation.xml"))
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
                new EasyXML(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\AFR Monitor\\Activation.xml", elements);
                File.SetAttributes(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\AFR Monitor\\Activation.xml", FileAttributes.Hidden);
            }
            else
            {
                if(!EasyXML.TryLoad(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\AFR Monitor\\Activation.xml"))
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
            if(!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\AFR Monitor\\cfg.xml"))
            {
                var elements = new Dictionary<string, string>
                {
                    {
                        "LineColor", "#" + Color.Red.R.ToString("X2") + Color.Red.G.ToString("X2") + Color.Red.B.ToString("X2")
                    },
                    {
                        "WarningLineColor", "#" + Color.Black.R.ToString("X2") + Color.Black.G.ToString("X2") + Color.Black.B.ToString("X2")
                    },
                    {
                        "Difference", "5"
                    }
                };

                new EasyXML(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\AFR Monitor\\cfg.xml", elements);
            }
            else
            {
                if (!EasyXML.TryLoad(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\AFR Monitor\\cfg.xml"))
                {
                    File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\AFR Monitor\\cfg.xml");
                    goto Start;
                }
            }

            Helper.ValidActivationKeys.Add("p1tr99234qnw");
            Helper.ValidActivationKeys.Add("p2dz27273urw");
            Helper.ValidActivationKeys.Add("p3nh58983ftw");
            Helper.ValidActivationKeys.Add("p4we98043nnw");
            Helper.ValidActivationKeys.Add("p5io69270mow");

            /*try { */Application.Run(new Starter()); //} catch { }
        }
    }
}
