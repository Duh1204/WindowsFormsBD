using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsDB
{
    internal class ClienteDB
    {
        public string Salvar(Cliente cliente)
        {
            try
            {
                Connection.DB.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Clientes(nome, cpf) VALUES (@nome, @cpf);", Connection.DB);
                command.Parameters.Add("@nome", SqlDbType.NVarChar);
                command.Parameters.Add("@cpf", SqlDbType.Int);
                command.Parameters["@nome"].Value = cliente.Nome;
                command.Parameters["@cpf"].Value = cliente.Cpf;
                if (command.ExecuteNonQuery()==0)
                {
                    return "Houve um erro ao inserir no banco";
                }
                else
                {
                    return "Dados inseridos com sucesso";
                }               
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                Connection.DB.Close();
            }
        }

        public List<Cliente> ListarClientes()
        {
            try
            {
                Connection.DB.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Clientes;", Connection.DB);
                SqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Id", typeof(int));
                dt.Columns.Add("Cpf", typeof(int));
                dt.Columns.Add("Nome", typeof(string));
                dt.Load(reader);
                Connection.DB.Close();

                List<Cliente> clientes = new List<Cliente>();

                if (dt.Rows.Count>0)
                {
                    Cliente cliente;
                    foreach(DataRow dr in dt.Rows)
                    {
                        cliente = new Cliente();
                        cliente.Id = int.Parse(dr["Id"].ToString());
                        cliente.Cpf = int.Parse(dr["Cpf"].ToString());
                        cliente.Nome = dr["Nome"].ToString();
                        clientes.Add(cliente);
                    }
                }
                return clientes;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);

                return null;
            }
            finally
            {
                Connection.DB.Close();
            }
        }
    }
}
