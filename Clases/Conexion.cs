using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Clases
{
    public class Conexion
    {
        public static SqlConnection generarConexion()
        {


            SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MyInstance;Initial Catalog=IT3;Integrated Security=True");

        
            return Con;



        }
    }
}
