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
    public partial class Error : Form
    {
        public Error()
        {
            InitializeComponent();

        }

       protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g;

            g = e.Graphics;

            Pen myPen = new Pen(Color.Red);
            myPen.Width = 1;
            g.DrawLine(myPen, 0, 0, 0, 300);
            g.DrawLine(myPen, 437, 0, 437, 300);
            g.DrawLine(myPen, 0, 159, 437, 159);


        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmdOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Error_Load(object sender, EventArgs e)
        {
            LblText.Text = ErrorMessage.passingText;
            LblTitle.Text = ErrorMessage.passingTitle;

        }

        private void LblText_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
