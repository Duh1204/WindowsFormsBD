using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsDB
{
    internal class ProdutoDB
    {
        public string Salvar(Produto produto)
        {
            try
            {
                Connection.DB.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Produtos(cod_ean, nome, preco, quantidade) VALUES (@cod_ean, @nome, @preco, @quantidade);", Connection.DB);                                
                command.Parameters.Add("@cod_ean", SqlDbType.Int);
                command.Parameters.Add("@nome", SqlDbType.NVarChar);
                command.Parameters.Add("@preco", SqlDbType.Decimal);
                command.Parameters.Add("@quantidade", SqlDbType.Int);
                command.Parameters["@cod_ean"].Value = produto.Cod_ean;
                command.Parameters["@nome"].Value = produto.Nome;
                command.Parameters["@preco"].Value = produto.Preco;
                command.Parameters["@quantidade"].Value = produto.Quantidade;
                if (command.ExecuteNonQuery() == 0)
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

        public List<Produto> ListarProdutos()
        {
            try
            {
                Connection.DB.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Produtos;", Connection.DB);
                SqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Id", typeof(int));
                dt.Columns.Add("Cod_ean", typeof(int));
                dt.Columns.Add("Nome", typeof(string));
                dt.Columns.Add("Preco", typeof(decimal));
                dt.Columns.Add("Quantidade", typeof(int));
                dt.Load(reader);                

                List<Produto> produtos = new List<Produto>();

                if (dt.Rows.Count > 0)
                {
                    Produto produto;
                    foreach (DataRow dr in dt.Rows)
                    {
                        produto = new Produto();
                        produto.Id = int.Parse(dr["Id"].ToString());
                        produto.Cod_ean = int.Parse(dr["Cod_ean"].ToString());
                        produto.Nome = dr["Nome"].ToString();
                        produto.Preco = decimal.Parse(dr["Preco"].ToString());
                        produto.Quantidade = int.Parse(dr["Quantidade"].ToString());
                        produtos.Add(produto);
                    }
                }
                return produtos;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

                return null;
            }
            finally
            {
                Connection.DB.Close();
            }
        }

        public Produto ProcurarPorId(int produto_id)
        {
            try
            {
                Connection.DB.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Produtos WHERE ID=@id", Connection.DB);
                command.Parameters.Add("@id", SqlDbType.Int);
                command.Parameters["@id"].Value = produto_id;

                SqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Id", typeof(int));
                dt.Columns.Add("Cod_ean", typeof(int));
                dt.Columns.Add("Nome", typeof(string));
                dt.Columns.Add("Preco", typeof(decimal));
                dt.Columns.Add("Quantidade", typeof(int));
                dt.Load(reader);
                Produto produto = new Produto();

                if (dt.Rows.Count > 0)
                {
                    
                    foreach (DataRow dr in dt.Rows)
                    {                        
                        produto.Id = int.Parse(dr["Id"].ToString());
                        produto.Cod_ean = int.Parse(dr["Cod_ean"].ToString());
                        produto.Nome = dr["Nome"].ToString();
                        produto.Preco = decimal.Parse(dr["Preco"].ToString());
                        produto.Quantidade = int.Parse(dr["Quantidade"].ToString());
                        
                    }                
                }
                return produto;
            }
            catch
            {
                return null;
            }
            finally
            {
                Connection.DB.Close();
            }
        }
    }
}
