using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CLASESS_2_SEGUNDO_PARCIAL
{
     public class Calculo
    {
        //recibir
     public double promedio(string nota1,string nota2,string nota3)//CONSTRUCTROR
        {
            double prom = ((Int32.Parse(nota1)+Int32.Parse(nota2)+Int32.Parse(nota3))/3);


            return prom;

        }
         

      //constructor de tipo string

        public List<string> Listado(string Articulo)
        {

            List<string> Articulos = new List<string>();

            if (Articulo.Equals("Tecnologia"))
            {

                Articulos.Add("computadoras de escritorio");
                Articulos.Add("computadoras de laptop");
                Articulos.Add("Apple TV");
                Articulos.Add("Routers");


            }


            else if(Articulo.Equals("Electrodomesticos"))

            {

                Articulos.Add("Refirgeradores");
                Articulos.Add("Estufas");
                Articulos.Add("Microondas");
                Articulos.Add("Lavadoras");


            }
            else
            {
                Articulos.Add("Maquina de caminar");
                Articulos.Add("Maquina multiuso");
                Articulos.Add("Par de pesas 500kg");
                Articulos.Add("Maquina de abdominales");


            }

            return Articulos;
        }




    }
}
