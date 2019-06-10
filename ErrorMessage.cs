﻿using System;
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
    public partial class ErrorMessage : Form
    {
        public static string passingText;
        public static string passingTitle;

        public ErrorMessage()
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



        private void CmdStart_Click(object sender, EventArgs e)
        {
            try
            {         
                    Error er2 = new Error();
                    passingText = TxtErrorText.Text;
                    passingTitle = TxtErrorTitle.Text;
                    if (radioButton1.Checked)
                    {
                    LblError.Visible = false;
                    int amount = Convert.ToInt32(TxtWieOft.Text);
                        for (int i = 1; i <= amount; i++)
                        {
                            

                            System.Media.SystemSounds.Hand.Play();
                            Error er = new Error();
                            er.Location = new Point(this.Left, this.Top);
                            er.Show();
                        }
                    }
                    else if (radioButton2.Checked)
                    {
                    LblError.Visible = false;
                    DateTime start = DateTime.Now;
                        int amount = Convert.ToInt32(TxtWieLang.Text);
                        while (DateTime.Now.Subtract(start).Seconds < amount)
                        {
                            

                            System.Media.SystemSounds.Hand.Play();
                            Error er = new Error();
                            er.Location = new Point(this.Left, this.Top);
                            er.Show();
                        }
                    }
                    else if (radioButton3.Checked)
                    {
                    LblError.Visible = false;
                    while (true)
                        {
                            System.Media.SystemSounds.Hand.Play();
                            Error er = new Error();
                            er.Location = new Point(this.Left, this.Top);
                            er.Show();
                        }
                    }
                
            } catch(FormatException)
            {
                LblError.Visible = true;
                LblError.Text = ("Die Eingabe hat das falsche Format.\nBitte gib ausschließlich ganze Zahlen über 0 ein");
            }
        }
        
        private void TxtWieOft_TextChanged(object sender, EventArgs e)
        {

            if (TxtWieOft.Text == null)
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

            if (TxtWieLang.Text == null)
            {
                CmdStart.Enabled = false;
            }
            else
            {
                CmdStart.Enabled = true;
            }
        }

        private void TxtErrorText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}