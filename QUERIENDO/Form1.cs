using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUERIENDO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox2;
            panel2.Hide();
            btnSI.TabStop = false;
            btnNO.TabStop = false;
        }
        public void MoverBoton()
        {
            Random R = new Random();
            int x = R.Next(0, this.Width - btnNO.Width);
            int y = R.Next(0, this.Height - btnNO.Height);
            btnNO.Location = new Point(x, y);
        }

        private void btnNO_MouseMove(object sender, MouseEventArgs e)
        {
            MoverBoton();
            if (btnNO.Location == btnSI.Location || btnNO.Location == label1.Location)
            {// si el boton NO se situa sobre el boton SI o el boton NO se situa sobre el texto "Quieres..." se ejecuta el metodo MoverBoton
                MoverBoton();
            }
        }

        private void btnSI_Click(object sender, EventArgs e)
        {
            // panel2.Show();
            MoverBoton();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
