using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clases
{
    public class validaciones
    {
        public void SoloLetras(KeyPressEventArgs e)
        //este codigo no permite ingresar numeros, solo letras, va en el evento keypress
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsSeparator(e.KeyChar)))
            {
                MessageBox.Show("Caracter invalido, Use solo letras!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }


        public void SoloNumeros(KeyPressEventArgs e)
        //este codigo no permite ingresar letras, solo numeros, va en el evento keypress
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsSeparator(e.KeyChar)))
            {
                MessageBox.Show("Caracter invalido, Use solo Numeros!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        public void ParaLoginSinEspacios(KeyPressEventArgs e)
        //este codigo no permite que los nombre usuario lleven espacios, , va en el evento keypress
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsNumber(e.KeyChar)))
            {
                MessageBox.Show("No se permiten espacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;

            }
        }


        public Boolean correo(string texto)
        //con esta validacion permitimos el ingreso correcto de un correo electronico, va en el evento validated
        {

            return Regex.IsMatch(texto, @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))"
              + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
        }


    }
}
