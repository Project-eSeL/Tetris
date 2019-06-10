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
    public partial class Auswahl : Form
    {
        public Auswahl()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(50, 50);
        }

        private void CmdPatchnotes_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 mm = new Form1();
            mm.Location = new Point(this.Left, this.Top);
            mm.ShowDialog();
            this.Close();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Patchnotes pn = new Patchnotes();
            pn.Location = new Point(this.Left, this.Top);
            pn.ShowDialog();
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            ErrorMessage em = new ErrorMessage();
            em.Location = new Point(this.Left, this.Top);
            em.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Chrome ch = new Chrome();
            ch.Location = new Point(this.Left, this.Top);
            ch.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Tabs ta = new Tabs();
            ta.Location = new Point(this.Left, this.Top);
            ta.ShowDialog();
            this.Close();
        }
    }
}
