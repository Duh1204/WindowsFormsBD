using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsDB
{
    internal class VendaDB
    {
        public int Salvar(Venda venda)
        {
            try
            {
                Connection.DB.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Venda(cod_cliente, valor_total) VALUES (@cod_cliente, @valor_total); SELECT SCOPE_IDENTITY();", Connection.DB);
                command.Parameters.Add("@cod_cliente", SqlDbType.Int);
                command.Parameters.Add("@valor_total", SqlDbType.Decimal);
                command.Parameters["@cod_cliente"].Value = venda.Cliente_venda.Id;
                command.Parameters["@valor_total"].Value = venda.Valor_total;

                decimal ID = (decimal)command.ExecuteScalar();
                               
                return (int)ID;
            }
            catch (Exception e)
            {
                return 0;
            }
            finally
            {
                Connection.DB.Close();
            }
        }
    }
}
