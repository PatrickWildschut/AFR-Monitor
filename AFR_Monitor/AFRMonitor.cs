﻿using System;
using System.Speech.Recognition;
using System.IO.Ports;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Speech.Synthesis;
using System.PW.Encryption;
using System.PW.Xml;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;

namespace AFRMonitor
{
    public partial class AFRMonitor : Form
    {
       // Stopwatch stopwatch = new Stopwatch();

        // XML
        static EasyXML Settings = new EasyXML(Helper.SettingsXmlLocation);
        Color LineColor = ColorTranslator.FromHtml(Settings.Elements.GetInnerText("/Root/LineColor"));
        Color WarningLineColor = ColorTranslator.FromHtml(Settings.Elements.GetInnerText("/Root/WarningLineColor"));

        // Mark
        VerticalLineAnnotation VLA = new VerticalLineAnnotation();
        int VLACount = 0;

        // For voice control only
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        SaveFileDialog sfd = new SaveFileDialog()
        {
            DefaultExt = "txt", Filter = "Air Fuel Ratio File (*.afr)|*.afr|All files (*.*)|*.*"
        };
        int CountDownCount = 3;
        List<double> Values = new List<double>();
        List<VerticalLineAnnotation> Marks = new List<VerticalLineAnnotation>();
        bool IsSaved = true;
        public AFRMonitor()
        {
            InitializeComponent();
            synthesizer.Rate = 1;
            ChartView.ChartAreas[0].AxisY.Interval = 1;
            #region Voice Setup
            if (Helper.UsageVariable == 1)
            {
                Words.Visible = true;
                StBut.Visible = false;
                Choices commands = new Choices();
                commands.Add(new string[] { "start", "stop", "reset" });
                GrammarBuilder gBuild = new GrammarBuilder();
                gBuild.Append(commands);
                Grammar grammar = new Grammar(gBuild);

                try
                {
                    sre.LoadGrammarAsync(grammar);
                    sre.SetInputToDefaultAudioDevice();
                    sre.SpeechRecognized += Sre_SpeechRecognized;
                    sre.RecognizeAsync(RecognizeMode.Multiple);
                }
                catch(Exception e) { MessageBox.Show("Error Code 2, output: " + e); }
                Listening = true;
            }
            #endregion
            #region Setup UI
            ChartView.ChartAreas[0].AxisY.Minimum = 8;
            ChartView.ChartAreas[0].AxisY.Maximum = 20;
            ChartView.Series["Value"].Color = LineColor;

            // Mark
            VLA.AxisX = ChartView.ChartAreas[0].AxisX;
            VLA.IsInfinitive = true;
            VLA.LineWidth = 2;
            VLA.ClipToChartArea = ChartView.ChartAreas[0].Name;
            VLA.LineColor = Color.Red;

            ToggleUI(false);
            
            ReBut_Click(null, null);
            if (ComSelector.Items.Count > 0)
            {
                // Select last used comport from Settings File
                ComSelector.Text = Settings.Elements.GetInnerText("/Root/ComPort");
            }
            #endregion
        }

        private void ToggleUI(bool toggle)
        {
            #region OWO

            if (label3.InvokeRequired)
            {
                label3.Invoke(new Action(() => label3.Visible = toggle));
            }
            else
            {
                label3.Visible = toggle;
            }

            if (label4.InvokeRequired)
            {
                label4.Invoke(new Action(() => label4.Visible = toggle));
            }
            else
            {
                label4.Visible = toggle;
            }

            if (CurValLab.InvokeRequired)
            {
                CurValLab.Invoke(new Action(() => CurValLab.Visible = toggle));
            }
            else
            {
                CurValLab.Visible = toggle;
            }

            if (FourteenSaveLab.InvokeRequired)
            {
                FourteenSaveLab.Invoke(new Action(() => FourteenSaveLab.Visible = toggle));
            }
            else
            {
                FourteenSaveLab.Visible = toggle;
            }

            if (FourteenLab.InvokeRequired)
            {
                FourteenLab.Invoke(new Action(() => FourteenLab.Visible = toggle));
            }
            else
            {
                FourteenLab.Visible = toggle;
            }

            if (ElevenSaveLab.InvokeRequired)
            {
                ElevenSaveLab.Invoke(new Action(() => ElevenSaveLab.Visible = toggle));
            }
            else
            {
                ElevenSaveLab.Visible = toggle;
            }

            if (ElevenLab.InvokeRequired)
            {
                ElevenLab.Invoke(new Action(() => ElevenLab.Visible = toggle));
            }
            else
            {
                ElevenLab.Visible = toggle;
            }

            if (Rich.InvokeRequired)
            {
                Rich.Invoke(new Action(() => Rich.Visible = toggle));
            }
            else
            {
                Rich.Visible = toggle;
            }

            if (Lean.InvokeRequired)
            {
                Lean.Invoke(new Action(() => Lean.Visible = toggle));
            }
            else
            {
                Lean.Visible = toggle;
            }

            if (RichOrLean.InvokeRequired)
            {
                RichOrLean.Invoke(new Action(() => RichOrLean.Visible = toggle));
            }
            else
            {
                RichOrLean.Visible = toggle;
            }

            if (CurLab.InvokeRequired)
            {
                CurLab.Invoke(new Action(() => CurLab.Visible = toggle));
            }
            else
            {
                CurLab.Visible = toggle;
            }

            if (TenLab.InvokeRequired)
            {
                TenLab.Invoke(new Action(() => TenLab.Visible = toggle));
            }
            else
            {
                TenLab.Visible = toggle;
            }

            if (TenSaveLab.InvokeRequired)
            {
                TenSaveLab.Invoke(new Action(() => TenSaveLab.Visible = toggle));
            }
            else
            {
                TenSaveLab.Visible = toggle;
            }
            #endregion
        }

        private void Sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "start":
                    StartBetween();
                    break;
                case "stop":
                    Stop();
                    break;
                case "reset":
                    RTB_Click(null, null);
                    break;
                default:
                    MessageBox.Show("Error Code 1, output: " + e.Result.Text + ".", "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    break;
            }

        }

        private void StartBetween()
        {
            if(stop)
            {
                if (ComSelector.Items.Count > 0)
                {
                    if (Helper.CountDown)
                    {
                        CountDown();
                    }
                    else
                    {
                        Start();
                    }
                }
                else
                {
                    ReBut_Click(null, null);
                }
            }
            
        }
        private void StBut_Click(object sender, EventArgs e)
        {
            
            if (StBut.Text == "Start")
            {
                if (ComSelector.Items.Count > 0)
                    StartBetween();
            }
            else
            {
                Stop();
            }
            
            
        }
        bool Listening = false;
        void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            if (Listening)
            {
                sre.RecognizeAsyncStop();
            }
            synthesizer.Dispose();
            Stop();
            if(!IsSaved)
            {
                if(MessageBox.Show("Are you sure you want to exit without saving?", "Save or quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }

            // Save current selected comport as startup comport
            Settings.Elements.SetInnerText("/Root/ComPort", ComSelector.Text);
        }

        private void Start()
        {
            RTB.Enabled = true;
            STFLB.Text = "Save Low Boost";
            STFHB.Text = "Save High Boost";
            STFLB.Enabled = true;
            STFHB.Enabled = true;
            IsSaved = false;
            StBut.Text = "Stop";
            SelectLab.Location = new Point(SelectLab.Location.X + 25, SelectLab.Location.Y);
            SelectLab.Font = new Font("Arial", 15, FontStyle.Bold);
            stop = false;
            ComSelector.Visible = false;
            ReBut.Visible = false;
            ToggleUI(true);
            try
            {
                SerialP.PortName = ComSelector.Text;
                SerialP.Open();
            }
            catch { }
            UpdateAsync();
            TimerAsync();
            Task.Delay(15);

        }
        double SampleLength = 0;
        Stopwatch TotalTimer = new Stopwatch();
        async Task TimerAsync()
        {
            TotalTimer.Start();
            while (!stop)
            {
                await Task.Run(() =>
                {
                    SampleLength = TotalTimer.Elapsed.TotalSeconds;
                    SelectLab.Invoke(new Action(() => SelectLab.Text = "Time elapsed:\n\t" + SampleLength.ToString("0.0") + " sec"));
                });
            }
            TotalTimer.Stop();
            SelectLab.Text = "Select:";
        }



        private void Stop()
        {
            if(!stop)
            {
                //MessageBox.Show(SampleLength.ToString());
                stop = true;
                SerialP.Close();
                SelectLab.Location = new Point(SelectLab.Location.X - 25, SelectLab.Location.Y);
                SelectLab.Font = new Font("Arial", 9, FontStyle.Regular);
                ComSelector.Visible = true;
                ReBut.Visible = true;
                ToggleUI(false);
                StBut.Text = "Start";
                
            }
            
        }

        bool stop = true;
        private async Task UpdateAsync()
        {
            double LastValue = 0.0;
            await Task.Run(() =>
            {
            while (!stop)
            {
                try
                {

                        string PortOutput = SerialP.ReadLine().ToString();
                        double PortOutputDouble = Convert.ToDouble(SerialP.ReadLine().ToString());

                        if (PortOutputDouble > 100)
                        {
                            PortOutputDouble /= 10;
                        }

                        LowestValue(PortOutputDouble);
                        Values.Add(PortOutputDouble);

                        CurLab.Invoke(new Action(() => CurLab.Text = PortOutput));

                        if(PortOutputDouble > 20)
                        {
                            PortOutputDouble = 20;
                        }
                        else if(PortOutputDouble < 8)
                        {
                            PortOutputDouble = 8;
                        }

                        RichOrLean.Invoke(new Action(() => RichOrLean.Value = 300 - (int)(PortOutputDouble * 10)));
                        ChartView.Invoke(new Action(() => ChartView.Series["Value"].Points.AddY(PortOutputDouble)));
                        
                        if((PortOutputDouble) - LastValue < -(Helper.WarningSlider) || (PortOutputDouble) - LastValue > (Helper.WarningSlider))
                        {
                            ChartView.Invoke(new Action(() => ChartView.Series["Value"].Points[ChartView.Series["Value"].Points.Count - 1].Color = WarningLineColor));
                        }

                        LastValue = PortOutputDouble;
                        ChartView.Invoke(new Action(() => ChartView.Focus()));

                        // Limited mode
                        if (Values.Count >= 200 && !Helper.UnlimitedMode)
                        {
                            // Move marks to the left
                            ChartView.Invoke(new Action(() => ChartView.Annotations.Clear()));

                            foreach (VerticalLineAnnotation vla in Marks)
                            {
                                vla.X -= 1;
                                ChartView.Invoke(new Action(() => ChartView.Annotations.Add(vla)));
                            }

                            ChartView.Series[0].Points.RemoveAt(0);
                        }
                    }
                    catch { }

                }
            });
        }
        private async Task LowestValue(double Value)
        {
            await Task.Run(() =>
            {
                if(Value < Helper.LowestValue)
                {
                    Helper.LowestValue = Value;
                }

                LowValueValue.Invoke(new Action(() => LowValueValue.Text = Helper.LowestValue.ToString()));
            });
        }

        private void ReBut_Click(object sender, EventArgs e)
        {
            ComSelector.Items.Clear();
            ComSelector.Items.AddRange(SerialPort.GetPortNames());
            if(ComSelector.Items.Count > 0)
            {
                ComSelector.SelectedIndex = 0;
            }
        }

        // Low boost save click
        private void STFB_Click(object sender, EventArgs e)
        {
            SaveToFile(false);
            IsSaved = true;
        }


        // High boost save click
        private void STFHB_Click(object sender, EventArgs e)
        {
            SaveToFile(true);
            IsSaved = true;
        }

        private async Task SaveToFile(bool HighBoost, int ShowSavedTime = 5000)
        {
            string output = String.Empty;
            string ValuesString = String.Empty;
            string MarksString = String.Empty;

            // Save depending on highboost or lowboost
            if (HighBoost)
            {
                STFHB.Invoke(new Action(() => STFHB.Text = "Wait"));
                STFLB.Enabled = false;

                // Create directory if it doesn't exist
                if (!Directory.Exists(Settings.Elements.GetInnerText("/Root/SaveLocation") + "\\HighBoostResults"))
                {
                    Directory.CreateDirectory(Settings.Elements.GetInnerText("/Root/SaveLocation") + "\\HighBoostResults");
                }
            }
            else
            {
                STFLB.Invoke(new Action(() => STFLB.Text = "Wait"));
                STFHB.Enabled = false;

                // Create directory if it doesn't exist
                if(!Directory.Exists(Settings.Elements.GetInnerText("/Root/SaveLocation") + "\\LowBoostResults"))
                {
                    Directory.CreateDirectory(Settings.Elements.GetInnerText("/Root/SaveLocation") + "\\LowBoostResults");
                }
            }

            // Add Values
            foreach (double d in Values)
            {
                ValuesString += d.ToString() + "\n";
            }

            // Add Marks
            foreach (VerticalLineAnnotation vla in Marks)
            {
                MarksString += vla.X.ToString() + "\n";
            }

            output += "Lowest Value: " + Helper.LowestValue + "\n";
            output += "High Boost: " + HighBoost.ToString() + "\n";
            output += "Total Runtime: " + SampleLength.ToString("0.0") + " sec\n";
            output += "Sample Interval: " + (SampleLength * 1000 / Values.Count) + "\n";
            output += "Finished Time: " + DateTime.Now + "\n";
            output += "Values\n" + ValuesString;
            output += "Marks\n" + MarksString;

            // Encrypt the data
            string EncOutput = await EasyEncryption.Async.EncryptStringAsync(output, "File encrypted by AFR Monitor, version: " + Helper.Version + " - Patrick Wildschut");


            // Save
            if(HighBoost)
            {
                File.WriteAllText(Settings.Elements.GetInnerText("/Root/SaveLocation") + "\\HighBoostResults" + "\\" + (Directory.GetFiles(Settings.Elements.GetInnerText("/Root/SaveLocation") + "\\HighBoostResults").Length + 1) + ".afr", EncOutput);

                STFHB.Invoke(new Action(() => STFHB.Text = "Saved"));
                //await Task.Delay(ShowSavedTime);
                //STFLB.Invoke(new Action(() => STFLB.Text = "Save To File"));
            }
            else
            {
                File.WriteAllText(Settings.Elements.GetInnerText("/Root/SaveLocation") + "\\LowBoostResults" + "\\" + (Directory.GetFiles(Settings.Elements.GetInnerText("/Root/SaveLocation") + "\\LowBoostResults").Length + 1) + ".afr", EncOutput);
                
                STFLB.Invoke(new Action(() => STFLB.Text = "Saved"));
                //await Task.Delay(ShowSavedTime);
                //STFLB.Invoke(new Action(() => STFLB.Text = "Save To File"));
            }
        }

        private void RTB_Click(object sender, EventArgs e)
        {
            if(!stop)
            {
                STFLB.Enabled = true;
                STFHB.Enabled = true;
                RTB.Enabled = true;
            }
            else
            {
                STFLB.Enabled = false;
                STFHB.Enabled = false;
                RTB.Enabled = false;
            }
            STFLB.Text = "Save Low Boost";
            STFHB.Text = "Save High Boost";
            Values.Clear();
            Marks.Clear();
            ChartView.Series["Value"].Points.Clear();
            ChartView.Annotations.Clear();
            Helper.LowestValue = int.MaxValue;
            LowValueValue.Text = "--,-";
            SampleLength = 0;
            IsSaved = true;
            
            if(TotalTimer.IsRunning)
            {
                TotalTimer.Restart();
            }
            else
            {
                TotalTimer.Reset();
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private async void CountDown()
        {
            StBut.Text = "Stop";
            while (CountDownCount > 0)
            {
                CurLab.Visible = true;
                if (CurLab.InvokeRequired)
                {
                    CurLab.Invoke(new Action(() => CurLab.Text = CountDownCount.ToString()));
                }
                else
                {
                    CurLab.Text = CountDownCount.ToString();
                }
                try
                {
                    synthesizer.SpeakAsyncCancelAll();
                    synthesizer.SpeakAsync(CountDownCount.ToString());
                }
                catch { }
                await Task.Delay(1000);
                CountDownCount -= 1;
            }
            CountDownCount = 3;
            try
            {
                synthesizer.SpeakAsyncCancelAll();
                synthesizer.SpeakAsync("Go");
            }
            catch { }
            Start();


        }

        private void AFRMonitor_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                SetLocationsAsync(true);
            }
            else
            {
                SetLocationsAsync(false);
            }
        }

        private async Task SetLocationsAsync(bool fullscreen)
        {
            await Task.Run(() =>
            {
                if(fullscreen)
                {
                    TenLab.Invoke(new Action(() => TenLab.Visible = false));
                    TenSaveLab.Invoke(new Action(() => TenSaveLab.Visible = false));
                    ElevenLab.Invoke(new Action(() => ElevenLab.Visible = false));
                    ElevenSaveLab.Invoke(new Action(() => ElevenSaveLab.Visible = false));
                    FourteenLab.Invoke(new Action(() => FourteenLab.Visible = false));
                    FourteenSaveLab.Invoke(new Action(() => FourteenSaveLab.Visible = false));
                    label3.Invoke(new Action(() => label3.Visible = false));
                    label4.Invoke(new Action(() => label4.Visible = false));
                    CurValLab.Invoke(new Action(() => CurValLab.Font = new Font("Arial", 20, FontStyle.Bold)));
                    CurValLab.Invoke(new Action(() => CurValLab.Location = new Point(CurValLab.Location.X - 200, CurValLab.Location.Y)));
                    CurLab.Invoke(new Action(() => CurLab.Font = new Font("Arial", 60)));
                    CurLab.Invoke(new Action(() => CurLab.Location = new Point(CurLab.Location.X - 202, CurLab.Location.Y)));
                    LowValueValue.Invoke(new Action(() => LowValueValue.Font = new Font("Arial", 30, FontStyle.Bold)));
                }
                else
                {
                    label4.Invoke(new Action(() => label4.Visible = true));
                    label3.Invoke(new Action(() => label3.Visible = true));
                    TenLab.Invoke(new Action(() => TenLab.Visible = true));
                    TenSaveLab.Invoke(new Action(() => TenSaveLab.Visible = true));
                    ElevenLab.Invoke(new Action(() => ElevenLab.Visible = true));
                    ElevenSaveLab.Invoke(new Action(() => ElevenSaveLab.Visible = true));
                    FourteenLab.Invoke(new Action(() => FourteenLab.Visible = true));
                    FourteenSaveLab.Invoke(new Action(() => FourteenSaveLab.Visible = true));
                    CurValLab.Invoke(new Action(() => CurValLab.Font = new Font("Arial", 12, FontStyle.Bold)));
                    CurValLab.Invoke(new Action(() => CurValLab.Location = new Point(CurValLab.Location.X + 200, CurValLab.Location.Y)));
                    CurLab.Invoke(new Action(() => CurLab.Font = new Font("Arial", 36)));
                    CurLab.Invoke(new Action(() => CurLab.Location = new Point(CurLab.Location.X + 202, CurLab.Location.Y)));
                    LowValueValue.Invoke(new Action(() => LowValueValue.Font = new Font("Arial", 22, FontStyle.Bold)));
                }
            });
        }

        private void setupVLA()
        {
            VLA = new VerticalLineAnnotation();

            VLA.AxisX = ChartView.ChartAreas[0].AxisX;
            VLA.IsInfinitive = true;
            VLA.LineWidth = 2;
            VLA.ClipToChartArea = ChartView.ChartAreas[0].Name;
            VLA.LineColor = Color.Red;

            VLA.X = ChartView.Series["Value"].Points.Count;

            VLACount++;
            VLA.Name = "Mark" + VLACount.ToString();
        }
        private void AFRMonitor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                setupVLA();
                // Add annotation (VLA)
                ChartView.Annotations.Add(VLA);

                // Add mark with current latest X location to list to store in save file
                Marks.Add(VLA);
            }
        }
    }
}
