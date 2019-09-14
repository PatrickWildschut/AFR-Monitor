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
using System.Speech.Synthesis;

namespace ComPortReader
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
            if(Helper.UsageVariable == 1)
            {
                StBut.Visible = false;
                Choices commands = new Choices();
                commands.Add(new string[] { "start", "stop" });
                GrammarBuilder gBuild = new GrammarBuilder();
                gBuild.Append(commands);
                Grammar grammar = new Grammar(gBuild);

                sre.LoadGrammarAsync(grammar);
                sre.SetInputToDefaultAudioDevice();
                sre.SpeechRecognized += Sre_SpeechRecognized;
                sre.RecognizeAsync(RecognizeMode.Multiple);
                Listening = true;
            }
            if(Helper.LongScanMode)
            {
                ChartView.ChartAreas[0].AxisX.Maximum = 200;
            }
            ChartView.ChartAreas[0].AxisY.Minimum = 10;
            ChartView.ChartAreas[0].AxisY.Maximum = 20;
            label2.Visible = false;
            CurLab.Visible = false;
            RichOrLean.Visible = false;
            Lean.Visible = false;
            Rich.Visible = false;
            ReBut_Click(null, null);
            if (ComSelector.Items.Count > 0)
            {
                ComSelector.SelectedIndex = 0;
            }
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
                default:
                    MessageBox.Show("Error Code 1, output: " + e.Result.Text + ".", "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    break;
            }

        }

        private void StartBetween()
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
        private void StBut_Click(object sender, EventArgs e)
        {
            if (ComSelector.Items.Count > 0)
            {
                if (StBut.Text == "Start")
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
                    Stop();
                }
            }
            
            
        }
        bool Listening = false;
        void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Listening)
            {
                sre.RecognizeAsyncStop();
            }
            synthesizer.Dispose();
            Stop();
        }

        private void Start()
        {
            StBut.Text = "Stop";
            stop = false;
            label2.Visible = true;
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
            
        }

        private void Stop()
        {
            stop = true;
            SerialP.Close();
            label2.Visible = false;
            CurLab.Visible = false;
            RichOrLean.Visible = false;
            Lean.Visible = false;
            Rich.Visible = false;
            StBut.Text = "Start";
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
                            ChartView.Invoke(new Action(() => ChartView.Series["Value"].Points.AddY((PortOutputDouble) / 10)));
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
                    if(LowValueValue.InvokeRequired)
                    {
                        LowValueValue.Invoke(new Action(() => LowValueValue.Text = Value.ToString()));
                    }
                    else
                    {
                        LowValueValue.Text = Value.ToString();
                    }
                }
            });
        }

        private void ReBut_Click(object sender, EventArgs e)
        {
            ComSelector.Items.Clear();
            ComSelector.Items.AddRange(SerialPort.GetPortNames());
        }

        private void STFB_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }
        public int DifZeroFive = -1;
        public int Scans = 0;
        private async Task SaveToFile()
        {
            string returns = "";
            double LastValue = 0;
            foreach (double d in Values)
            {
                returns += d.ToString() + "\n";
                if((LastValue - d) > 0.5 | (d - LastValue) > -0.5)
                {
                    DifZeroFive++;
                }
                LastValue = d;
                Scans++;
            }
            File.WriteAllText(Application.StartupPath + "\\Output.txt", "Lowest Value: " + Helper.LowestValue + "\nScans: " + Scans.ToString() + "\nDifference 0,5 or more: " + DifZeroFive.ToString() + "\n\n" + returns); ;

            STFB.Invoke(new Action(() => STFB.Text = "Done"));
            await Task.Delay(1000);
            STFB.Invoke(new Action(() => STFB.Text = "Save To File"));
        }

        private void RTB_Click(object sender, EventArgs e)
        {
            Values.Clear();
            ChartView.Series["Value"].Points.Clear();
            Helper.LowestValue = int.MaxValue;
            LowValueValue.Text = "--,-";
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
                synthesizer.SpeakAsyncCancelAll();
                synthesizer.SpeakAsync(CountDownCount.ToString());
                await Task.Delay(1000);
                CountDownCount -= 1;
            }
            CountDownCount = 3;
            synthesizer.SpeakAsyncCancelAll();
            synthesizer.SpeakAsync("Go");
            Start();

        }

    }
}
