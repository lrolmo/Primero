using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentanaLogin
{
    public partial class ventana2 : Form
    {
        public ventana2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int contador = 0;
            string elegido;

            if (checkBox1.Checked == true)
            {
                contador++;
            }
            if (checkBox2.Checked == true)
            {
                contador++;
            }
            if (radioButton1.Checked== true)
            {
                elegido = "Tarjeta de Crédito";
            }
            else
            {
                elegido = "PayPal";
            }
            MessageBox.Show("Ha seleccionado  "+contador+" y cancela con "+elegido);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ventanalogin = new Form1();
            ventanalogin.Show();
        }
    }
}
