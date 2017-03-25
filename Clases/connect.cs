using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using  System.Data;
using System.Data.Sql;

namespace Clases
{
    public class connect
    {
        public string cadenaconexion;
        public string sql;
        public int resultado;
        public SqlConnection cnn;
        public SqlCommand comandosql;
        public SqlDataReader dr;
        public string mensaje;
        public SqlDataAdapter da;
        public DataTable dt;



        public connect()
        {
            this.cadenaconexion = (@"Data Source=(localdb)\MyInstance;Initial Catalog=IT3;Integrated Security=True");
            this.cnn = new SqlConnection(this.cadenaconexion);


        }

        public string Mensaje
        {
            get { return this.mensaje; }


        }
    }
}
