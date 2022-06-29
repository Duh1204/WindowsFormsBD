using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsDB
{
    internal class ItemVendaDB
    {
        public void Salvar(ItemVenda itemVenda)
        {
            try
            {
                Connection.DB.Open();
                SqlCommand command = new SqlCommand("INSERT INTO ItemVenda(id_venda, id_produto, valor_unit, quantidade, valor_total) VALUES (@id_venda, @id_produto, @valor_unit, @quantidade, @valor_total);", Connection.DB);                
                command.Parameters.Add("@id_venda", SqlDbType.Int);
                command.Parameters.Add("@id_produto", SqlDbType.Int);
                command.Parameters.Add("@valor_unit", SqlDbType.Decimal);
                command.Parameters.Add("@quantidade", SqlDbType.Int);
                command.Parameters.Add("@valor_total", SqlDbType.Decimal);
                command.Parameters["@id_venda"].Value = itemVenda.Venda.Id;
                command.Parameters["@id_produto"].Value = itemVenda.Produto.Id;
                command.Parameters["@valor_unit"].Value = itemVenda.Valor_unit;
                command.Parameters["@quantidade"].Value = itemVenda.Quantidade;
                command.Parameters["@valor_total"].Value = itemVenda.Valor_total;
                command.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Connection.DB.Close();
            }
        }
    }
}
