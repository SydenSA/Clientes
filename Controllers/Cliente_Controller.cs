using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//
using System.Data;
using Clientes.Models;
namespace Clientes.Controllers
{
    class cliente_Controller
    {
        private cliente_Model ClienteModel = new cliente_Model();

        public List<cliente_Model> todos()
        {
            List<cliente_Model> listacliente = new List<cliente_Model>();
            listacliente = ClienteModel.Todos();
            return listacliente;
        }
        public string insertar(cliente_Model Cliente)
        {
            return ClienteModel.insertar(Cliente);
        }
        public string editar(cliente_Model Cliente)
        {
            return ClienteModel.editar(Cliente);
        }

        public string eliminar(cliente_Model Cliente)
        {
            return ClienteModel.eliminar(Cliente);
        }
    }
}
