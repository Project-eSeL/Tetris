using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Tabs : Form
    {
        public Tabs()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(50, 50);
        }

        private void CmdBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            Auswahl aw = new Auswahl();
            aw.Location = new Point(this.Left, this.Top);
            aw.ShowDialog();
            this.Close();
        }

        private void OptJa_CheckedChanged(object sender, EventArgs e)
        {
            PanWebsite.Visible = true;
        }

        private void OptNein_CheckedChanged(object sender, EventArgs e)
        {
            PanWebsite.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            LblWieOft.Visible = true;
            TxtWieOft.Visible = true;
            LblWieLang.Visible = false;
            TxtWieLang.Visible = false;
            CmdStart.Enabled = false;
            LblInSek.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            LblWieLang.Visible = true;
            TxtWieLang.Visible = true;
            LblInSek.Visible = true;
            LblWieOft.Visible = false;
            TxtWieOft.Visible = false;
            CmdStart.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            LblWieOft.Visible = false;
            TxtWieOft.Visible = false;
            LblWieLang.Visible = false;
            TxtWieLang.Visible = false;
            CmdStart.Enabled = true;
            LblInSek.Visible = false;
        }

        private void TxtWieOft_TextChanged(object sender, EventArgs e)
        {
            if (TxtWieOft.Text == null && comboBox1.Text == null)
            {
                CmdStart.Enabled = false;
            }
            else
            {
                CmdStart.Enabled = true;
            }
        }

        private void TxtWieLang_TextChanged(object sender, EventArgs e)
        {
            if (TxtWieLang.Text == null && comboBox1.Text == null)
            {
                CmdStart.Enabled = false;
            }
            else
            {
                CmdStart.Enabled = true;
            }
        }

        private void CmdStart_Click(object sender, EventArgs e)
        {
            string Page = comboBox1.Text;

            if (radioButton1.Checked)
            {
                LblError.Visible = false;
                int amount = Convert.ToInt32(TxtWieOft.Text);
                if (OptJa.Checked)
                {
                    for (int i = 1; i <= amount; i++)
                    {
                        System.Diagnostics.Process.Start("www." + Page);
                    }
                }
                else
                {
                    for (int i = 1; i <= amount; i++)
                    {
                        System.Diagnostics.Process.Start("www.Google.com");
                    }
                }
            }
            else if (radioButton2.Checked)
            {
                LblError.Visible = false;
                DateTime start = DateTime.Now;
                int Amount = Convert.ToInt32(TxtWieLang.Text);
                if (OptJa.Checked)
                {

                    while (DateTime.Now.Subtract(start).Seconds < Amount)
                    {
                        System.Diagnostics.Process.Start("www." + Page);
                    }
                }
                else
                {
                    while (DateTime.Now.Subtract(start).Seconds < Amount)
                    {
                        System.Diagnostics.Process.Start("www.Google.com");
                    }
                }
            }
            else if (radioButton3.Checked)
            {
                LblError.Visible = false;
                if (OptJa.Checked)
                {
                    while (true)
                    {
                        System.Diagnostics.Process.Start("www." + Page);
                    }
                }
                else
                {
                    while (true)
                    {
                        System.Diagnostics.Process.Start("www.Google.com");
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
