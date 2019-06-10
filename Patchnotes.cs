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
    public partial class Patchnotes : Form
    {
        public Patchnotes()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(50, 50);
        }

        private void Patchnotes_Load(object sender, EventArgs e)
        {

        }

        private void CmdBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            Auswahl aw = new Auswahl();
            aw.Location = new Point(this.Left, this.Top);
            aw.ShowDialog();
            this.Close();            
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DerTetrisTypAusDerSchule/Tetris3/tree/master");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.dropbox.com/sh/bxok0wqpvwc30yn/AAC_QQ5kcqxiJvccMZYJthPwa?dl=0");
        }
    }
}
