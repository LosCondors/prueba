using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //SE AGREGA PARA VALIDAR



namespace CLASESS_2_SEGUNDO_PARCIAL
{
    public class Validacion
    {
        public void soloLetras(KeyPressEventArgs e)
        {
            //isseparator separa 
            if(char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || char.IsControl(e.KeyChar))
                {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            //ahora mandar a llamar el evento
        }

        public void soloNumeros(KeyPressEventArgs e)
        {

            if(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
        } 

    }
}
