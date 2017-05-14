using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace data
{
    public class Cliente
    {
        int idcliente;
        string nombre;
        string apellido;
        string direccion;
        string telefono;
        string email;
        bool is_active;

        public int Idcliente
        {
            get { return idcliente; }
            set { idcliente = value; }
        }
        
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        
        public bool Is_active
        {
            get { return is_active; }
            set { is_active = value; }
        }

        // Database Operations
        public int insertCliente(Cliente cliente)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = Database.connection_string;
                connection.Open();
                SqlCommand cmd = new SqlCommand("spInsertCliente", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", cliente.nombre);
                cmd.Parameters.AddWithValue("@apellido", cliente.apellido);
                cmd.Parameters.AddWithValue("@direccion", cliente.direccion);
                cmd.Parameters.AddWithValue("@telefono", cliente.telefono);
                cmd.Parameters.AddWithValue("@email", cliente.email);
                cmd.Parameters.AddWithValue("@is_active", cliente.is_active);
                return cmd.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public int updateCliente(Cliente cliente)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = Database.connection_string;
                connection.Open();
                SqlCommand cmd = new SqlCommand("spupdateCliente", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id", cliente.idcliente);
                cmd.Parameters.AddWithValue("@nombre", cliente.nombre);
                cmd.Parameters.AddWithValue("@apellido", cliente.apellido);
                cmd.Parameters.AddWithValue("@direccion", cliente.direccion);
                cmd.Parameters.AddWithValue("@telefono", cliente.telefono);
                cmd.Parameters.AddWithValue("@email", cliente.email);
                cmd.Parameters.AddWithValue("@is_active", cliente.is_active);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public int deleteCliente(int id)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = Database.connection_string;
                connection.Open();
                SqlCommand command = new SqlCommand("spDeleteCliente", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("id", id);
                return command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable getClientes()
        {
            SqlConnection connection = new SqlConnection();
            DataTable dt = new DataTable();
            try
            {
                connection.ConnectionString = Database.connection_string;
                connection.Open();
                SqlCommand command = new SqlCommand("spGetClientes", connection);
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public DataTable searchClientesByName(string nombre)
        {
            SqlConnection connection = new SqlConnection();
            DataTable dt = new DataTable();
            try
            {
                connection.ConnectionString = Database.connection_string;
                connection.Open();
                SqlCommand cmd = new SqlCommand("spSearchClientesByName", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
    }
}
