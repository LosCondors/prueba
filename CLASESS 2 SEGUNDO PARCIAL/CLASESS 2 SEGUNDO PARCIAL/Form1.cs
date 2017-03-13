using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLASESS_2_SEGUNDO_PARCIAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //mandamos a llamar a la clase validacion letra es una variable 
            Validacion letra = new Validacion();
            letra.soloLetras(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            Validacion numero = new Validacion();
            numero.soloNumeros(e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion numero = new Validacion();
            numero.soloNumeros(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
