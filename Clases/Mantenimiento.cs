using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Clases
{
    public class Mantenimiento
    {
        public void llenarPuesto(ComboBox cb)
        {
            SqlDataReader Lect;

            using (SqlConnection Cone = Conexion.generarConexion())
            {
                SqlCommand comando = new SqlCommand("select DESC_PUESTO from PUESTO", Cone);

                Lect = comando.ExecuteReader();

                while (Lect.Read())
                {
                    cb.Items.Add(Lect["DESC_PUESTO"].ToString());
                }




            }

        }



        public static string consulta(string user, string clave)
        {
            using (SqlConnection Cone = Conexion.generarConexion())
            {
                string resultado;

                SqlCommand comando = new SqlCommand("select b.NOM_PUESTO from USUARIO as a inner join PUESTO as b on a.ID_Puesto = b.ID_PUESTO where a.USUARIO=@var1 AND a.CLAVE=@var2 ", Cone);
                comando.Parameters.AddWithValue("@var1", user);
                comando.Parameters.AddWithValue("@var2", clave);

                Cone.Open();
                resultado = comando.ExecuteScalar().ToString();
                Cone.Close();

                return resultado;
            }
        }

        public static string Estado(string user, string clave)
        {
            using (SqlConnection Cone = Conexion.generarConexion())
            {
                string resultado;

                SqlCommand comando = new SqlCommand("select b.Descripcion from USUARIO as a inner join [Estados/Entidad] as b on a.ESTADO = b.IDCol where a.USUARIO=@var1 AND a.CLAVE=@var2 ", Cone);
                comando.Parameters.AddWithValue("@var1", user);
                comando.Parameters.AddWithValue("@var2", clave);

                Cone.Open();
                resultado = comando.ExecuteScalar().ToString();
                Cone.Close();

                return resultado;
            }
        }
        
    }
}
