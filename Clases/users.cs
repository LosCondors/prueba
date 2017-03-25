using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Clases
{
    public class users : connect
    {
        private string usuario;
        private string contraseña;

        public users()
        {
            usuario = string.Empty;
            contraseña = string.Empty;
            this.sql = string.Empty;


        }

        public string Usuario
        {
            get { return this.usuario; }
            set { this.usuario = value; }

        }
        public string Contraseña
        {
            get { return this.contraseña; }
            set { this.contraseña = value; }

        }

        public bool Buscar()
        {
            bool Resultado = false;
            this.sql = string.Format(@"select a.ID_EMPLEADO  from USUARIO as a where a.USUARIO='{0}' AND a.CLAVE='{1}' ", this.usuario, this.contraseña);

            this.comandosql = new SqlCommand(this.sql, this.cnn);
            this.cnn.Open();
            SqlDataReader reg = null;
            reg = this.comandosql.ExecuteReader();
            if (reg.Read())
            {
                Resultado = true;
                this.mensaje = "INGRESO CORRECTO";

            }
            else
            {
                this.mensaje = "Usuario o Contraseña incorrecto";
            }
            this.cnn.Close();
            return Resultado;

        }
    }
}
