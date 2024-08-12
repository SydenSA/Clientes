using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// librerias de sql   libreria de Data
using System.Data.SqlClient;
using System.Data;

namespace Clientes.Config
{

    class ConexionBDD
    {

        string cadena = "Server=SANTY\\SQLEXPRESS; Database=Cuarto; Integrated Security=true";
        private SqlConnection con = new SqlConnection("Server=SANTY\\SQLEXPRESS; Database=Cuarto; Integrated Security=true");


        public SqlConnection AbrirConexion()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            return con;
        }

        public SqlConnection CerrarConexion()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            return con;
        }

    }
}
