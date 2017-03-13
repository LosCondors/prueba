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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttoncalcular_Click(object sender, EventArgs e)
        {
            Calculo prome = new Calculo();

           textBox5.Text=prome.promedio(textBox2.Text,textBox3.Text,textBox4.Text).ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion letra = new Validacion();
            letra.soloLetras(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion numero = new Validacion();
            numero.soloNumeros(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion numero = new Validacion();
            numero.soloNumeros(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion numero = new Validacion();
            numero.soloNumeros(e);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)

        { 
           
            
        }
    }
}
