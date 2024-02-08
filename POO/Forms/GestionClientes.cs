using MySqlX.XDevAPI;
using POO.dao;
using POO.Modelos;
using System.ComponentModel;

namespace POO
{
    public partial class GestionClientes : Form
    {
        public GestionClientes()
        {
            InitializeComponent();
        }

        private void GestionClientes_Load(object sender, EventArgs e)
        {
            renderizarLista();
        }

        private void renderizarLista()
        {
            ClienteDAO baseDeDatos = new ClienteDAO();
            List<Cliente> listaDb = baseDeDatos.obtenerListadoClientes();

            //Limpiando
            listClientes.Items.Clear();

            //recorriendo para cargar
            for (int i = 0; i < listaDb.Count; i++)
            {
                Cliente cliente = listaDb[i];
                listClientes.Items.Add(cliente);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Cliente cliente = new Cliente();
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.TarjetaCredito = txtTarjetaCredito.Text;

            if (lblId.Text != "")
            {
                cliente.Id = lblId.Text;
            }

            ClienteDAO baseDeDatos = new ClienteDAO();
            baseDeDatos.Guardar(cliente);
            renderizarLista();
            limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Guardando indice seleccionado
            Cliente cliente = (Cliente)listClientes.SelectedItem;

            ClienteDAO baseDeDatos = new ClienteDAO();
            baseDeDatos.Eliminar(cliente);
            renderizarLista();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listClientes.SelectedItem;
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtTelefono.Text = cliente.Telefono;
            txtTarjetaCredito.Text = cliente.TarjetaCredito;
            lblId.Text = cliente.Id;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            lblId.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtTarjetaCredito.Text = "";
        }
    }
}