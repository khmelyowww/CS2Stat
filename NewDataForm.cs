using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS2Stat
{
    public partial class NewDataForm : Form
    {
        MainForm mainForm;

        public float allKillsInt;
        public float allDeadsInt;
        public float allAssistsInt;

        public int newArrayElement;

        public NewDataForm(MainForm owner)
        {
            InitializeComponent();
            mainForm = owner;
        }

        private void button_saveStat_Click(object sender, EventArgs e)
        {
            try
            {
                if (mainForm.mmIsActive) //MM
                {
                    allKillsInt = Convert.ToSingle(mainForm.allKillsMM) + Convert.ToSingle(textBox_kills.Text);
                    mainForm.allKillsMM = Convert.ToString(allKillsInt);

                    allDeadsInt = Convert.ToSingle(mainForm.allDeadsMM) + Convert.ToSingle(textBox_deads.Text);
                    mainForm.allDeadsMM = Convert.ToString(allDeadsInt);

                    allAssistsInt = Convert.ToSingle(mainForm.allAssistsMM) + Convert.ToSingle(textBox_assists.Text);
                    mainForm.allAssistsMM = Convert.ToString(allAssistsInt);

                    int sumMatches = Convert.ToInt32(mainForm.MatchesMM) + 1;
                    if (sumMatches > 20)
                    {
                        sumMatches = 20;
                        mainForm.MatchesMM = Convert.ToString(sumMatches);
                    }
                    else
                    {
                        mainForm.MatchesMM = Convert.ToString(sumMatches);
                    }

                    newArrayElement = int.Parse(textBox_kills.Text);
                    for (int i = 0; i < mainForm.arrayMM.Length - 1; i++)
                    {
                        mainForm.arrayMM[i] = mainForm.arrayMM[i + 1];
                    }
                    mainForm.arrayMM[mainForm.arrayMM.Length - 1] = newArrayElement;

                    mainForm.WriteLog();
                    mainForm.ReadLog();
                    this.Close();
                }
                else //Premier
                {
                    allKillsInt = Convert.ToSingle(mainForm.allKillsPremier) + Convert.ToSingle(textBox_kills.Text);
                    mainForm.allKillsPremier = Convert.ToString(allKillsInt);

                    allDeadsInt = Convert.ToSingle(mainForm.allDeadsPremier) + Convert.ToSingle(textBox_deads.Text);
                    mainForm.allDeadsPremier = Convert.ToString(allDeadsInt);

                    allAssistsInt = Convert.ToSingle(mainForm.allAssistsPremier) + Convert.ToSingle(textBox_assists.Text);
                    mainForm.allAssistsPremier = Convert.ToString(allAssistsInt);

                    int sumMatches = Convert.ToInt32(mainForm.MatchesPremier) + 1;
                    if (sumMatches > 20)
                    {
                        sumMatches = 20; mainForm.MatchesPremier = Convert.ToString(sumMatches);
                    }
                    else
                    {
                        mainForm.MatchesPremier = Convert.ToString(sumMatches);
                    }

                    newArrayElement = int.Parse(textBox_kills.Text);
                    for (int i = 0; i < mainForm.arrayPremier.Length - 1; i++)
                    {
                        mainForm.arrayPremier[i] = mainForm.arrayPremier[i + 1];
                    }
                    mainForm.arrayPremier[mainForm.arrayPremier.Length - 1] = newArrayElement;

                    mainForm.WriteLog();
                    mainForm.ReadLog();
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте все ли данные заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_kills_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void textBox_deads_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void textBox_assists_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void NewDataForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.button_newStat.Enabled = true;
            mainForm.button_MM.Enabled = true;
            mainForm.button_Premier.Enabled = true;
            mainForm.button_clearLog.Enabled = true;
        }
    }
}
