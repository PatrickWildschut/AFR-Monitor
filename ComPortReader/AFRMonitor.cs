using System;
using System.Speech.Recognition;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Threading;
using System.IO;
using System.Timers;
using System.Speech.Synthesis;
using System.Diagnostics;

namespace AFRMonitor
{
    public partial class AFRMonitor : Form
    {
        //Thread ReaderThread = new Thread(Reader);
        //BackgroundWorker bgw;

        // For voice control only

        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        int CountDownCount = 3;
        List<double> Values = new List<double>();
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
            if (Helper.LongScanMode)
            {
                ChartView.ChartAreas[0].AxisX.Maximum = 200;
            }
            #region Setup UI
            ChartView.ChartAreas[0].AxisY.Minimum = 10;
            ChartView.ChartAreas[0].AxisY.Maximum = 20;
            CurValLab.Visible = false;
            FourteenSaveLab.Visible = false;
            FourteenLab.Visible = false;
            ElevenSaveLab.Visible = false;
            ElevenLab.Visible = false;
            TenSaveLab.Visible = false;
            TenLab.Visible = false;
            CurLab.Visible = false;
            RichOrLean.Visible = false;
            Lean.Visible = false;
            Rich.Visible = false;
            ReBut_Click(null, null);
            if (ComSelector.Items.Count > 0)
            {
                ComSelector.SelectedIndex = 0;
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
            if (ComSelector.Items.Count > 0)
            {
                STFB.Enabled = true;
                RTB.Enabled = true;
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
        private void StBut_Click(object sender, EventArgs e)
        {
            
            if (StBut.Text == "Start")
            {
                if(ComSelector.Items.Count > 0)
                if (Helper.CountDown)
                {
                    CountDown();
                }
                else
                {
                    StartBetween();
                }
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
        }

        private void Start()
        {
            if(stop)
            {
                StBut.Text = "Stop";
                SelectLab.Location = new Point(SelectLab.Location.X + 25, SelectLab.Location.Y);
                SelectLab.Font = new Font("Arial", 15, FontStyle.Bold);
                stop = false;
                ComSelector.Visible = false;
                ReBut.Visible = false;
                CurValLab.Visible = true;
                FourteenSaveLab.Visible = true;
                FourteenLab.Visible = true;
                ElevenSaveLab.Visible = true;
                ElevenLab.Visible = true;
                TenSaveLab.Visible = true;
                TenLab.Visible = true;
                CurLab.Visible = true;
                RichOrLean.Visible = true;
                Lean.Visible = true;
                Rich.Visible = true;
                try
                {
                    SerialP.PortName = ComSelector.Text;
                    SerialP.Open();
                }
                catch { }
                UpdateAsync();
                TimerAsync(100);
                Task.Delay(15);
            }
        }
        double SampleLength = 0;
        async Task TimerAsync(int Delay)
        {
            //Stopwatch stopwatch = Stopwatch.StartNew();
            while (!stop)
            {
                await Task.Delay(Delay);
                SampleLength += Delay / 100;
                SelectLab.Text = "Time elapsed:\n\t" + (SampleLength / 10) + " sec";
                //SelectLab.Text = "Time elapsed:\n\t" + stopwatch.Elapsed.TotalSeconds;
            }
            SelectLab.Text = "Select:";
            //SelectLab.Text = "Select:";
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
                CurValLab.Visible = false;
                FourteenSaveLab.Visible = false;
                FourteenLab.Visible = false;
                ElevenSaveLab.Visible = false;
                ElevenLab.Visible = false;
                TenSaveLab.Visible = false;
                TenLab.Visible = false;
                CurLab.Visible = false;
                RichOrLean.Visible = false;
                Lean.Visible = false;
                Rich.Visible = false;
                StBut.Text = "Start";
                
            }
            
        }

        bool stop = true;
        int i = 0;
        private async Task UpdateAsync()
        {
            await Task.Run(() =>
            {
            while (!stop)
            {
                try
                {
                    string PortOutput = SerialP.ReadLine().ToString();//"14.8";
                    double PortOutputDouble = Convert.ToDouble(SerialP.ReadLine().ToString());
                    if (CurLab.InvokeRequired)
                    {
                        CurLab.Invoke(new Action(() => CurLab.Text = PortOutput));
                    }
                    else
                    {
                        CurLab.Text = PortOutput;
                    }

                        if (RichOrLean.InvokeRequired)
                        {
                            RichOrLean.Invoke(new Action(() => RichOrLean.Value = 300 - (int)PortOutputDouble));
                        }
                        else
                        {
                            RichOrLean.Value = 300 - (int)PortOutputDouble;
                        }

                        if (ChartView.InvokeRequired)
                        {
                            ChartView.Invoke(new Action(() => ChartView.Series["Value"].Points.AddY(PortOutputDouble / 10)));
                            i++;
                            if (i >= 200 & Helper.LongScanMode)
                            {
                                ChartView.Series[0].Points.RemoveAt(0);
                            }
                        }
                        else
                        {
                            ChartView.Series["Value"].Points.AddY((300 - (int)PortOutputDouble));
                        }

                    LowestValue(Convert.ToDouble(PortOutput) / 10);
                    Values.Add(Convert.ToDouble(PortOutput) / 10);
                        
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
                    LowValueValue.Invoke(new Action(() => LowValueValue.Text = Value.ToString()));
                }
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

        private void STFB_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }
        public int DifZeroFive = -1;
        public int Scans = 0;
        private async Task SaveToFile()
        {
            STFB.Invoke(new Action(() => STFB.Text = "Wait"));
            string returns = "";
            int Number = 2;
            double LastValue = 0;
            foreach (double d in Values)
            {
                returns += d.ToString() + "\n";
                if((LastValue - d) > 1 | (d - LastValue) > 1)
                {
                    DifZeroFive++;
                }
                LastValue = d;
                Scans++;
            }
            string[] Date = DateTime.Now.Date.ToString().Split(' ');
            Date = Date[0].Split('/');
            string Name = "AFR Results";/* + Date[0] + "." + Date[1] + "." + Date[2];*/
        Check:
            if (File.Exists(Application.StartupPath + "\\" + Name + ".txt"))
            {
                if(File.Exists(Application.StartupPath + "\\" + Name + " " + Number + ".txt"))
                {
                    Number++;
                    goto Check;
                }
            }
            
            if(!File.Exists(Application.StartupPath + "\\" + Name + ".txt"))
            {
                File.WriteAllText(Application.StartupPath + "\\" + Name + ".txt", "Lowest Value: " + Helper.LowestValue + "\nScans: " + Scans.ToString() + "\nDifference 1 or more: " + DifZeroFive.ToString() + "\nTotal Runtime: " + (SampleLength / 10) + " sec" + "\n\nValues\n" + returns);
            }
            else
            {
                File.WriteAllText(Application.StartupPath + "\\" + Name + " " + Number + ".txt", "Lowest Value: " + Helper.LowestValue + "\nScans: " + Scans.ToString() + "\nDifference 1 or more: " + DifZeroFive.ToString() + "\nTotal Runtime: "+ (SampleLength / 10) + " sec" + "\n\nValues\n" + returns);
            }
            STFB.Invoke(new Action(() => STFB.Text = "Done"));
            await Task.Delay(1000);
            STFB.Invoke(new Action(() => STFB.Text = "Save To File"));
        }

        private void RTB_Click(object sender, EventArgs e)
        {
            if(!stop)
            {
                STFB.Enabled = true;
                RTB.Enabled = true;
            }
            else
            {
                STFB.Enabled = false;
                RTB.Enabled = false;
            }
            Values.Clear();
            ChartView.Series["Value"].Points.Clear();
            Helper.LowestValue = int.MaxValue;
            LowValueValue.Text = "--,-";
            SampleLength = 0;
            i = 0;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private async void CountDown()
        {
            while(CountDownCount > 0)
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
                    CurValLab.Invoke(new Action(() => CurValLab.Font = new Font("Arial", 20, FontStyle.Bold)));
                    CurValLab.Invoke(new Action(() => CurValLab.Location = new Point(CurValLab.Location.X - 200, CurValLab.Location.Y)));
                    CurLab.Invoke(new Action(() => CurLab.Font = new Font("Arial", 60)));
                    CurLab.Invoke(new Action(() => CurLab.Location = new Point(CurLab.Location.X - 202, CurLab.Location.Y)));
                    LowValueValue.Invoke(new Action(() => LowValueValue.Font = new Font("Arial", 30, FontStyle.Bold)));
                }
                else
                {
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
    }
}
