using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CS2Stat
{
    public partial class MainForm : Form
    {
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\LOGSTAT";
        static string filePathMM = path + @"\logMM.txt";
        static string filePathPremier = path + @"\logPremier.txt";

        static string filePathArrayMM = path + @"\logArrayMM.txt";
        static string filePathArrayPremier = path + @"\logArrayPremier.txt";
        public int[] arrayMM = new int[maxLength];
        public int[] arrayPremier = new int[maxLength];
        const int maxLength = 20;
        public int sumArrayElementsMM;
        public int sumArrayElementsPremier;

        public string allKills;
        public string allDeads;
        public string allAssists;

        public string allKillsMM;
        public string allDeadsMM;
        public string allAssistsMM;

        public string allKillsPremier;
        public string allDeadsPremier;
        public string allAssistsPremier;

        public string MatchesMM;
        public string MatchesPremier;

        public bool mmIsActive;

        private Color activeBackgroundColor = Color.FromArgb(52, 52, 52);
        private Color activeForegroundColor = Color.FromArgb(47, 180, 90);

        private Color defaultBackgroundColor = Color.FromArgb(46, 46, 50);
        private Color defaultForegroundColor = Color.FromArgb(200, 200, 200);
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                using (File.Create(filePathMM)) ;
                using (File.Create(filePathPremier)) ;
                using (File.Create(filePathArrayMM)) ;
                using (File.Create(filePathArrayPremier)) ;
                string logDataMM = "0" + "\n" + "0" + "\n" + "0" + "\n" + "0";
                string logDataPremier = "0" + "\n" + "0" + "\n" + "0" + "\n" + "0";
                string logDataMatchesMM = "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0";
                string logDataMatchesPremier = "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0";
                File.WriteAllText(filePathMM, logDataMM);
                File.WriteAllText(filePathPremier, logDataPremier);
                File.WriteAllText(filePathArrayMM, logDataMatchesMM);
                File.WriteAllText(filePathArrayPremier, logDataMatchesPremier);
            }
            else
            {
                if (!File.Exists(filePathMM))
                {
                    using (File.Create(filePathMM)) ;
                    string logDataMM = "0" + "\n" + "0" + "\n" + "0" + "\n" + "0";
                    File.WriteAllText(filePathMM, logDataMM);
                }
                if (!File.Exists(filePathPremier))
                {
                    using (File.Create(filePathPremier)) ;
                    string logDataPremier = "0" + "\n" + "0" + "\n" + "0" + "\n" + "0";
                    File.WriteAllText(filePathPremier, logDataPremier);
                }
                if (!File.Exists(filePathArrayMM))
                {
                    using (File.Create(filePathArrayMM)) ;
                    string logDataMatchesMM = "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0";
                    File.WriteAllText(filePathArrayMM, logDataMatchesMM);
                }
                if (!File.Exists(filePathArrayPremier))
                {
                    using (File.Create(filePathArrayPremier)) ;
                    string logDataMatchesPremier = "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0";
                    File.WriteAllText(filePathArrayPremier, logDataMatchesPremier);
                }
            }
            mmIsActive = true;
            ReadLog();

            SetButtonColors(button_MM, activeBackgroundColor, activeForegroundColor);
            SetButtonColors(button_Premier, defaultBackgroundColor, defaultForegroundColor);

            panel_activeMM.Visible = true;
            panel_activePremier.Visible = false;
        }

        public void WriteLog()
        {
            if (mmIsActive)
            {
                string logData = allKillsMM + "\n" + allDeadsMM + "\n" + allAssistsMM + "\n" + MatchesMM;
                File.WriteAllText(filePathMM, logData);
                using (StreamWriter writer = new StreamWriter(filePathArrayMM))
                {
                    foreach (int value in arrayMM)
                    {
                        writer.WriteLine(value);
                    }
                }
            }
            else
            {
                string logData = allKillsPremier + "\n" + allDeadsPremier + "\n" + allAssistsPremier + "\n" + MatchesPremier;
                File.WriteAllText(filePathPremier, logData);
                using (StreamWriter writer = new StreamWriter(filePathArrayPremier))
                {
                    foreach (int value in arrayPremier)
                    {
                        writer.WriteLine(value);
                    }
                }
            }
        }

        public void ReadLog()
        {
            if (mmIsActive) //MM
            {
                allKillsMM = File.ReadLines(filePathMM).FirstOrDefault();
                allDeadsMM = File.ReadLines(filePathMM).Skip(1).FirstOrDefault();
                allAssistsMM = File.ReadLines(filePathMM).Skip(2).FirstOrDefault();
                MatchesMM = File.ReadLines(filePathMM).Skip(3).FirstOrDefault();
                string[] lines = File.ReadAllLines(filePathArrayMM);
                arrayMM = lines.Select(int.Parse).ToArray();
                sumArrayElementsMM = arrayMM.Sum();

                if (allKillsMM != string.Empty && allDeadsMM != string.Empty)
                {
                    if (allDeadsMM == "0")
                    {
                        textBox_KD.Text = Convert.ToString(Math.Round(Convert.ToSingle(allKillsMM) / 1.0, 2));
                    }
                    else
                    {
                        textBox_KD.Text = Convert.ToString(Math.Round(Convert.ToSingle(allKillsMM) / Convert.ToSingle(allDeadsMM), 2));
                    }
                }

                if (allKillsMM != string.Empty && MatchesMM != string.Empty)
                {
                    if (MatchesMM == "0")
                    {
                        textBox_AVG.Text = Convert.ToString(Math.Round(Convert.ToSingle(sumArrayElementsMM /*Сумма элементов массива*/) / 1.0, 2));
                    }
                    else
                    {
                        textBox_AVG.Text = Convert.ToString(Math.Round(Convert.ToSingle(sumArrayElementsMM /*Сумма элементов массива*/) / Convert.ToSingle(MatchesMM /*Сыгранные игры (до 20)*/), 2));
                    }
                }
            }
            else //Premier
            {
                allKillsPremier = File.ReadLines(filePathPremier).FirstOrDefault();
                allDeadsPremier = File.ReadLines(filePathPremier).Skip(1).FirstOrDefault();
                allAssistsPremier = File.ReadLines(filePathPremier).Skip(2).FirstOrDefault();
                MatchesPremier = File.ReadLines(filePathPremier).Skip(3).FirstOrDefault();
                string[] lines = File.ReadAllLines(filePathArrayPremier);
                arrayPremier = lines.Select(int.Parse).ToArray();
                sumArrayElementsPremier = arrayPremier.Sum();

                if (allKillsPremier != string.Empty && allDeadsPremier != string.Empty)
                {
                    if (allDeadsPremier == "0")
                    {
                        textBox_KD.Text = Convert.ToString(Math.Round(Convert.ToSingle(allKillsPremier) / 1.0, 2));
                    }
                    else
                    {
                        textBox_KD.Text = Convert.ToString(Math.Round(Convert.ToSingle(allKillsPremier) / Convert.ToSingle(allDeadsPremier), 2));
                    }
                }

                if (allKillsPremier != string.Empty && MatchesPremier != string.Empty)
                {
                    if (MatchesPremier == "0")
                    {
                        textBox_AVG.Text = Convert.ToString(Math.Round(Convert.ToSingle(sumArrayElementsPremier) / 1.0, 2));
                    }
                    else
                    {
                        textBox_AVG.Text = Convert.ToString(Math.Round(Convert.ToSingle(sumArrayElementsPremier) / Convert.ToSingle(MatchesPremier), 2));
                    }
                }
            }
            if (allKills != string.Empty)
            {
                allKills = Convert.ToString(Convert.ToInt32(File.ReadLines(filePathMM).FirstOrDefault()) + Convert.ToInt32(File.ReadLines(filePathPremier).FirstOrDefault()));
                label_allKills.Text = "Общее количество убийств: " + allKills;
            }

            if (allDeads != string.Empty)
            {
                allDeads = Convert.ToString(Convert.ToInt32(File.ReadLines(filePathMM).Skip(1).FirstOrDefault()) + Convert.ToInt32(File.ReadLines(filePathPremier).Skip(1).FirstOrDefault()));
                label_allDeads.Text = "Общее количество смертей: " + allDeads;
            }

            if (allAssists != string.Empty)
            {
                allAssists = Convert.ToString(Convert.ToInt32(File.ReadLines(filePathMM).Skip(2).FirstOrDefault()) + Convert.ToInt32(File.ReadLines(filePathPremier).Skip(2).FirstOrDefault()));
                label_allAssists.Text = "Общее количество ассистов: " + allAssists;
            }
        }

        private void SetButtonColors(Button button, Color backColor, Color foreColor)
        {
            button.BackColor = backColor;
            button.ForeColor = foreColor;
        }

        private void button_MM_Click(object sender, EventArgs e)
        {
            SetButtonColors(button_MM, activeBackgroundColor, activeForegroundColor);
            SetButtonColors(button_Premier, defaultBackgroundColor, defaultForegroundColor);

            mmIsActive = true;

            panel_activeMM.Visible = true;
            panel_activePremier.Visible = false;

            ReadLog();
        }

        private void button_Premier_Click(object sender, EventArgs e)
        {
            SetButtonColors(button_Premier, activeBackgroundColor, activeForegroundColor);
            SetButtonColors(button_MM, defaultBackgroundColor, defaultForegroundColor);

            mmIsActive = false;

            panel_activeMM.Visible = false;
            panel_activePremier.Visible = true;

            ReadLog();
        }
        private void button_newStat_Click(object sender, EventArgs e)
        {
            NewDataForm newDataForm = new NewDataForm(this);
            newDataForm.Show();
            button_newStat.Enabled = false;
            button_MM.Enabled = false;
            button_Premier.Enabled = false;
            button_clearLog.Enabled = false;
        }

        private void button_clearLog_Click(object sender, EventArgs e)
        {
            if (mmIsActive)
            {
                DialogResult res = MessageBox.Show("Вы действительно хотите очистить историю Матчмейкинга?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    string logDataMM = "0" + "\n" + "0" + "\n" + "0" + "\n" + "0";
                    File.WriteAllText(filePathMM, logDataMM);
                    string logDataMatchesMM = "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0";
                    File.WriteAllText(filePathArrayMM, logDataMatchesMM);

                    ReadLog();
                }
            }
            else
            {
                DialogResult res = MessageBox.Show("Вы действительно хотите очистить историю Премьер режима?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    string logData = "0" + "\n" + "0" + "\n" + "0" + "\n" + "0";
                    File.WriteAllText(filePathPremier, logData);
                    string logDataMatchesPremier = "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0";
                    File.WriteAllText(filePathArrayPremier, logDataMatchesPremier);
                    ReadLog();
                }
            }
        }

        private void button_MM_MouseEnter(object sender, EventArgs e)
        {
            if (!mmIsActive)
            {
                button_MM.ForeColor = Color.FromArgb(47, 180, 90);
            }
        }

        private void button_MM_MouseLeave(object sender, EventArgs e)
        {
            if (!mmIsActive)
            {
                button_MM.ForeColor = Color.FromArgb(200, 200, 200);
            }
        }

        private void button_Premier_MouseEnter(object sender, EventArgs e)
        {
            if (mmIsActive)
            {
                button_Premier.ForeColor = Color.FromArgb(47, 180, 90);
            }
        }

        private void button_Premier_MouseLeave(object sender, EventArgs e)
        {
            if (mmIsActive)
            {
                button_Premier.ForeColor = Color.FromArgb(200, 200, 200);
            }
        }
    }
}
