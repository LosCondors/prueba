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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("ejemplo");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //el combobox para limpiar . items
            comboBox1.Items.Clear();
            Calculo art = new Calculo();
            
            //HAY QUE CONVERTIRLO EN UN ARREGLO el radiobutton y se hace con  .ToArray<string>()
            comboBox1.Items.AddRange(art.Listado(radioButton1.Text).ToArray<string>());
         
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //el combobox para limpiar . items
            comboBox1.Items.Clear();
            Calculo art = new Calculo();

            //HAY QUE CONVERTIRLO EN UN ARREGLO el radiobutton y se hace con  .ToArray<string>()
            comboBox1.Items.AddRange(art.Listado(radioButton2.Text).ToArray<string>());
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //el combobox para limpiar . items
            comboBox1.Items.Clear();
            Calculo art = new Calculo();

            //HAY QUE CONVERTIRLO EN UN ARREGLO el radiobutton y se hace con  .ToArray<string>()
            comboBox1.Items.AddRange(art.Listado(radioButton3.Text).ToArray<string>());
        }
    }
}
