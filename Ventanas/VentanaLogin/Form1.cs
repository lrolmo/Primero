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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "LRM" && textBox2.Text == "1234")
            {
                //MessageBox.Show("..ACCESSO CORRECTO..");
                this.Hide();
                Principal nuevaventana = new Principal();
                //ventana2 nuevaventana = new ventana2();
                nuevaventana.Show();
            }
            else
            {
                MessageBox.Show("..ERROR..Usuario o contraseña incorrecta");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
