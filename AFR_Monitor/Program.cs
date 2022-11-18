using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.PW.Xml;
using System.Drawing;
using System.Reflection;
using System.Threading;
using Tulpep.NotificationWindow;

namespace AFRMonitor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool HasToCreate = false;

            Start:
            // Activation XML
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\AFR Monitor"))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\AFR Monitor");
                HasToCreate = true;
            }
            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\AFR Monitor\\Activation.xml"))
            {
                HasToCreate = true;
                var elements = new Dictionary<string, string>
                {
                    {
                        "Keys", "ptr99234qnwpdz27273urwpnh58983ftwpqe98043nnwpio69270mow"
                    },
                    {
                        "LoggedIn", "false"
                    },
                    {
                        //"Activated", "50470916"
                        "Activated", "50501750"
                    },
                    {
                        "LicenseFullName", "NULL"
                    },
                    {
                        "TrialDays", "31"
                    },
                    {
                        "CarName", "NULL"
                    },
                    {
                        "LicensePlate", "NULL"
                    }
                };
                new EasyXML(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\AFR Monitor\\Activation.xml", elements);
                File.SetAttributes(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\AFR Monitor\\Activation.xml", FileAttributes.Hidden);
            }
            else
            {
                if (!EasyXML.TryLoad(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\AFR Monitor\\Activation.xml"))
                {
                    File.Delete(Helper.ActivationXmlLocation);
                    HasToCreate = true;
                    goto Start;
                }
            }

            // Settings XML
            // Create directories
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\AFR Monitor\\data"))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\AFR Monitor\\data");
                HasToCreate = true;
            }
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\AFR Monitor\\config"))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\AFR Monitor\\config");
                HasToCreate = true;
            }

            // Create XML's
            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\AFR Monitor\\config\\cfg.xml"))
            {
                HasToCreate = true;
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
                    },
                    {
                        "SaveLocation", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\AFR Monitor\\data"
                    },
                    {
                        "LowBoostBHP", "0"
                    },
                    {
                        "HighBoostBHP", "0"
                    }
                };

                new EasyXML(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\AFR Monitor\\config\\cfg.xml", elements);
            }
            else
            {
                if (!EasyXML.TryLoad(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\AFR Monitor\\config\\cfg.xml"))
                {
                    File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\AFR Monitor\\config\\cfg.xml");
                    HasToCreate = true;
                    goto Start;
                }
            }

            // If we have arguments, in other words, if this program has been opened using a afr file. 
            if (args.Length > 0)
            {
                Helper.ReadFileLocation = args[0];
                Application.Run(new ReadFFile());
            }
            // Not opened using afr file. Start program normally
            else if(!Helper.IsLoggedIn())
            {
                //Application.Run(new Login());
                Application.Run(new Setup());
            }
            else
            {
                Application.Run(new Starter());
            }
            
            
        }
    }
}
