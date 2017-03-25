using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Clases;

using System.Windows.Forms;
using System.Data;
using System.Data.Sql;



namespace Clases
{
   public class contactos:connect
    {
       public static bool resul = false;
       public static void insetarCon(string query)
       {
           using (SqlConnection cnn = Conexion.generarConexion())
           {
               cnn.Open();
               SqlCommand comando = new SqlCommand(query, cnn);
               comando.ExecuteNonQuery();
               cnn.Close();
               MessageBox.Show("Contacto ingresado!");
           }
       }


       public static int codigoCont()
       {
           int resultado;
           using (SqlConnection cone = Conexion.generarConexion())
           {
               cone.Open();
               SqlCommand comando = new SqlCommand("select top 1 [Idcontacto] +1 from [dbo].[Contactos] order by [Idcontacto] desc", cone);

               resultado = Convert.ToInt32(comando.ExecuteScalar().ToString());
               cone.Close();

           }

           return resultado;

       }


       public static void buscarcontactos(DataGridView dgv, string query)
       {
           using (SqlConnection cone = Conexion.generarConexion())
           {
               cone.Open();

               DataSet dt = new DataSet();
               SqlDataAdapter da = new SqlDataAdapter(query, cone);

               da.Fill(dt, "IT2");
               dgv.DataSource = dt;
               dgv.DataMember = "IT2";
               cone.Close();

           }
       }


       public bool Buscar(string sql)
       {

           using (SqlConnection cone = Conexion.generarConexion())
           {
               bool resultado = false;
               cone.Open();
               SqlCommand comando = new SqlCommand(sql, cone);

               SqlDataReader reg = (null);
               reg = comando.ExecuteReader();
               if (reg.Read())
               {
                   resultado = true;

               }
               cone.Close();
               resul = resultado;
               return resultado;
           }


       }


       public static void actualizar(string query)
       {
           using (SqlConnection cone = Conexion.generarConexion())
           {
               cone.Open();
               SqlCommand comando = new SqlCommand(query, cone);

               comando.ExecuteNonQuery();
               cone.Close();
               MessageBox.Show("Modificacion realizada!");
           }
       }


       public string edit(int rtn, string name, string ape, string tel, int t, int cli)
       {
           string salida = "Se actualizaron los datos";
           try
           {
               cnn.Open();
               //comandosql = new SqlCommand("Update Contactos set Rtn= " + rtn + ", Nombre= '" + name + "', Apellido= '" + ape + "', Telefono = '" + tel + "', Estado = " + t + "  , Idcliente = " + cli + " where Rtn = " + rtn + " ", cnn);
               comandosql = new SqlCommand("Update Contactos set Rtn= " + rtn + ", Nombre= '" + name + "', Apellido= '" + ape + "', Telefono = '" + tel + "', Estado = " + 16 + "  , Idcliente = " + cli + " where Rtn = " + rtn + " ", cnn);
               comandosql.ExecuteNonQuery();
               cnn.Close();
           }
           catch (Exception ex)
           {
               salida = "No se actualizo: " + ex.ToString();
           }
           return salida;
       }



       public void cargarContacto(DataGridView dgv)
       {
           //DataTable dt = new DataTable();
           //SqlDataAdapter da = new SqlDataAdapter(); 

           try
           {
               da = new SqlDataAdapter("Select Contactos.Rtn, Contactos.Nombre, Contactos.Apellido, Contactos.Telefono , Contactos.Idcliente, CLIENTE.[NOMBRE COMPLETO] from [dbo].[Contactos] inner join [dbo].[CLIENTE] on Contactos.Idcliente=CLIENTE.IDCliente", cnn);
               dt = new DataTable();
               da.Fill(dt);
               dgv.DataSource = dt;
           }
           catch (Exception ex)
           {
               MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
           }
       } 




    }
}
