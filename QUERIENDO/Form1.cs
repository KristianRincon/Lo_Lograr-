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
            label1.Parent = pictureBox1; //se configura el pictureBox1 como el control padre de la etiqueta para que se aplique
                                         //la propiedad transparente a la etiqueta "label1"
            label2.Parent = pictureBox2; //igual a la anterior
            panel2.Hide();               //el metodo .Hide() oculta el primer formulario
            btnSI.TabStop = false;       // es para que no se puede utilizar el Tabulador con los botones   
            btnNO.TabStop = false;
        }
        public void MoverBoton()
        {
            Random R = new Random(); //con el metodo random creamos numeros aleatorios
            int x = R.Next(0, this.Width - btnNO.Width); //se ajustan la propiedades del boton NO para que cambie la ubicacion
                                                         //a un lugar aleatorio el el ancho del panel
            int y = R.Next(0, this.Height - btnNO.Height); //igual al anterior pero con el alto del panel
            btnNO.Location = new Point(x, y); //Inicializa una nueva instancia de la estructura Point con las coordenadas especificadas.
        }

        private void btnNO_MouseMove(object sender, MouseEventArgs e)//Object Sender es un parámetro llamado Sender que contiene una referencia al control / objeto que provoca el evento.
        {                                                            //btnNO_MouseMove ocurre cuando el puntero del mouse se mueve sobre el boton
            MoverBoton();//se ejecuta este metodo
            if (btnNO.Location == btnSI.Location || btnNO.Location == label1.Location)
            {// si el boton NO se situa sobre el boton SI o el boton NO se situa sobre el texto "Quieres..." se ejecuta el metodo MoverBoton
                MoverBoton();
            }
        }

        private void btnSI_Click(object sender, EventArgs e)
        {
           // se muestra el segundo panel que hemos creado cuando hacemos click sobre el boton SI
            panel2.Show();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //se cierra la aplicacion con el boton1 "Boton de aceptar"
            Application.Exit();
        }
    }
}
