using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//librerias de la conexion
using System.Data.SqlClient;
using System.Data;
using Clientes.Config;
namespace Clientes.Models
{
    class cliente_Model
    {

        public int IdCliente { get; set; }
        public string Detalle { get; set; }

        private ConexionBDD conexionBDD = new ConexionBDD();


        //lector  Sqldatareader
        Sqldatareader lector;
     
        List<cliente_Model> listacliente = new List<cliente_Model>();
        SqlCommand cmd = new SqlCommand();
        public List<cliente_Model> Todos()
        {
            string cadena = "select* from clientes";
            SqlDataAdapter adapter = new SqlDataAdapter(cadena, conexionBDD.AbrirConexion());
            DataTable data = new DataTable();
            adapter.Fill(data);
            foreach (DataRow fila in data.Rows)
            {
                cliente_Model Cliente = new cliente_Model
                {
                    IdCliente = Convert.ToInt32(fila["IdCliente"]),
                    Detalle = fila["Detalle"].ToString()
                };
                listacliente.Add(Cliente);
            }
            conexionBDD.CerrarConexion();
            return listacliente;
        }



        public string insertar(cliente_Model Cliente)
        {
            try
            {
                cmd.Connection = conexionBDD.AbrirConexion();
                cmd.CommandText = "insert into Cliente(Detalle) values('" + Cliente.Detalle + "')";
                cmd.ExecuteNonQuery();
                return "ok";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                conexionBDD.CerrarConexion();
            }
        }
        public string editar(cliente_Model Cliente)
        {
            try
            {
                cmd.Connection = conexionBDD.AbrirConexion();
                cmd.CommandText = "insert into Cliente(Detalle) values('" + Cliente.Detalle + "')";// cambiar la cadena sql
                cmd.ExecuteNonQuery();
                return "ok";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                conexionBDD.CerrarConexion();
            }
        }
        public string eliminar(cliente_Model Cliente)
        {
            try
            {
                Console.WriteLine("delete from Cliente where IdCliente=" + Cliente.IdCliente);
                cmd.Connection = conexionBDD.AbrirConexion();
                cmd.CommandText = "delete from cliente where IdCliente=" + Cliente.IdCliente;// cambiar la cadena sql
                cmd.ExecuteNonQuery();
                return "ok";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                conexionBDD.CerrarConexion();
            }
        }

    }
}