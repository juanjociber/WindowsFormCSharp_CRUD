using MySql.Data.MySqlClient;
using POO.Modelos;
using System.Data;

namespace POO.dao
{
    class ClienteDAO
    {
        public MySqlConnection Conectar()
        {
            string servidor = "localhost";
            string usuario  = "root";
            string password = "130877";
            string db       = "clientes";

            string cadenaConexion = "  Database     =" + db 
                                  + "; Data Source  =" + servidor 
                                  + "; User Id      =" + usuario 
                                  + "; Password     =" + password;

            MySqlConnection conexionDb = new MySqlConnection(cadenaConexion);
            conexionDb.Open();


            return conexionDb;
        }

        public List<Cliente> obtenerListadoClientes()
        {
            List<Cliente> lista = new List<Cliente>();

            string consulta = "listClientes";

            MySqlCommand comando    = new MySqlCommand(consulta);
            comando.CommandType = CommandType.StoredProcedure;
            //Lamando a la función Conectar
            comando.Connection      = Conectar();
            MySqlDataReader lectura = comando.ExecuteReader();

            while (lectura.Read())
            {
                Cliente cliente = new Cliente();
                cliente.Id              = lectura.GetInt32("id").ToString();
                cliente.Nombre          = lectura.GetString("nombre");
                cliente.Apellido        = lectura.GetString("apellido");
                cliente.Telefono        = lectura.GetString("telefono");
                cliente.TarjetaCredito  = lectura.GetString("tarjeta_credito");
                lista.Add(cliente);
            }
            //Cerrando conexión
            comando.Connection.Close();
            return lista;
        }

        public void Guardar(Cliente cliente)
        {
            if( cliente.Id == null)
            {
                insert(cliente);
            }
            else
            {
                update(cliente);
            }
        }

        private void insert(Cliente cliente)
        {
            string consulta = "INSERT INTO clientes(id,nombre,apellido,telefono,tarjeta_credito)VALUES(NULL,'"
                + cliente.Nombre + "','" + cliente.Apellido + "','" + cliente.Telefono + "','" + cliente.TarjetaCredito + "')";

            MySqlCommand comando = new MySqlCommand(consulta);
            //Lamando a la función Conectar
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();

            //Cerrando conexión
            comando.Connection.Close();
        }

        private void update(Cliente cliente)
        {
            string consulta = "UPDATE clientes SET nombre ='"
                +cliente.Nombre+"',apellido='"+cliente.Apellido+"',telefono='"+cliente.Telefono+"',tarjeta_credito='"+cliente.TarjetaCredito+"' WHERE clientes.id="+cliente.Id+";";

            MySqlCommand comando = new MySqlCommand(consulta);
            //Lamando a la función Conectar
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();

            //Cerrando conexión
            comando.Connection.Close();
        }

        public void Eliminar(Cliente cliente)
        {
            string consulta = "DELETE FROM clientes WHERE clientes.id= " + cliente.Id + ";";

            MySqlCommand comando = new MySqlCommand(consulta);
            //Lamando a la función Conectar
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();

            //Cerrando conexión
            comando.Connection.Close();
        }
    }
}
