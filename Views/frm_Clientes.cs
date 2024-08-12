using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clientes.Controllers;



//
using Clientes.Config;
using Clientes.Models;

namespace Clientes
{
    public partial class frm_Clientes : Form
    {

        cliente_Controller cliente_Controller = new cliente_Controller();
        public string IdCliente = null;

        public frm_Clientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


       




        private void btn_Grabar_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            cliente_Model Cliente = new cliente_Model
            {
                IdCliente = Convert.ToInt32(IdCliente),
                Detalle = txt_Detalle.Text
            };
            if (Convert.ToInt32(IdCliente) > 0)
            {

                //editar
                respuesta = cliente_Controller.editar(Cliente);

            }
            else
            {
                respuesta = cliente_Controller.insertar(Cliente);
            }
            if (respuesta == "ok")
            {
                IdCliente = null;
                cargaLista();
                MessageBox.Show("Se guardo con exito");
            }
            else
            {
                IdCliente = null;
                MessageBox.Show("Error al guardar");
            }


        }


        private void btn_modificar_Click_1(object sender, EventArgs e)
        {
            if (lst_Cliente.SelectedItem != null)
            {
                IdCliente = lst_Cliente.SelectedValue.ToString();
                txt_Detalle.Text = lst_Cliente.GetItemText(lst_Cliente.SelectedItem);
            }
            else
            {
                MessageBox.Show("Seleccione un Cliente de la lista");
            }
        }

        private void btn_eliminar_Click_1(object sender, EventArgs e)
        {
            cliente_Model Cliente = new cliente_Model
            {
                IdCliente = Convert.ToInt32(lst_Cliente.SelectedValue)

            };
            cliente_Controller.eliminar(Cliente);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

        }

        private void frm_Clientes_Load(object sender, EventArgs e)
        {
            cargaLista();
        }
        public void cargaLista()
        {

            lst_Cliente.DataSource = cliente_Controller.todos();
            lst_Cliente.DisplayMember = "Detalle";
            lst_Cliente.ValueMember = "IdPais";
        }
    }
}
