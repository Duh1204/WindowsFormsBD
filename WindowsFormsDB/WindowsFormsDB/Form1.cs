using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDB
{
    public partial class Form1 : Form
    {
        Venda venda;
        ItemVenda itemVenda;
        Produto produto;
        DataTable dt;
        Cliente cliente;

        public Form1()
        {
            InitializeComponent();
            ClienteDB clienteDB = new ClienteDB();
            List<Cliente> clientes = clienteDB.ListarClientes();
            comboboxcliente.DataSource = clientes;
            comboboxcliente.DisplayMember = nameof(Cliente.Nome);
            ProdutoDB produtoDB = new ProdutoDB();
            List<Produto> produtos = produtoDB.ListarProdutos();
            comboboxproduto.DataSource = produtos;
            comboboxproduto.DisplayMember = nameof(Produto.Nome);       
            dt = new DataTable();
            dt.Columns.Add("ID_Produto", typeof(int));
            dt.Columns.Add("Nome_Produto", typeof(string));
            dt.Columns.Add("Valor_Unitario", typeof(decimal));
            dt.Columns.Add("Quantidade", typeof(int));
            dt.Columns.Add("Valor_Total", typeof(decimal));
            dgitemvenda.DataSource = dt;
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteFrm clientefrm = new ClienteFrm();
            clientefrm.Show();
            
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutoFrm produtofrm = new ProdutoFrm();
            produtofrm.Show();
        }

        private void comboboxproduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            produto = (Produto)comboboxproduto.SelectedItem;
            numericquantidade.Maximum = produto.Quantidade;
            txtvalor.Text = (produto.Preco * numericquantidade.Value).ToString();

        }

        private void numericquantidade_ValueChanged(object sender, EventArgs e)
        {
            txtvalor.Text = (produto.Preco * numericquantidade.Value).ToString();
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            dr["ID_Produto"] = produto.Id;
            dr["Nome_Produto"] = produto.Nome;
            dr["Valor_Unitario"] = produto.Preco;
            dr["Quantidade"] = numericquantidade.Value;
            dr["Valor_Total"] = txtvalor.Text;
            dt.Rows.Add(dr);

            txtvalortotal.Text = dt.Compute("SUM(Valor_Total)", string.Empty).ToString();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            Venda venda = new Venda();
            venda.Cliente_venda = cliente;
            List<ItemVenda> item_vendas = new List<ItemVenda>();
            venda.Valor_total = Convert.ToDecimal(txtvalortotal.Text);
            VendaDB vendadb = new VendaDB();
            int id_venda = vendadb.Salvar(venda);
            venda.Id = id_venda;            

            ProdutoDB produto_db = new ProdutoDB();

            foreach(DataRow dr in dt.Rows)
            {
                ItemVenda itemVenda = new ItemVenda();
                itemVenda.Venda = venda;
                itemVenda.Produto = produto_db.ProcurarPorId((int)dr["ID_Produto"]);
                itemVenda.Valor_unit = (decimal)dr["Valor_Unitario"];
                itemVenda.Quantidade = (int)dr["Quantidade"];
                itemVenda.Valor_total = (decimal)dr["Valor_Total"];
                item_vendas.Add(itemVenda);
            }

            ItemVendaDB item_vendaDB = new ItemVendaDB();

            foreach(ItemVenda item_venda in item_vendas)
            {
                item_vendaDB.Salvar(item_venda);
            }

            MessageBox.Show("Dados inseridos com sucesso");
            venda = new Venda();
            dt.Rows.Clear();
        }

        private void comboboxcliente_SelectedIndexChanged(object sender, EventArgs e)
        {                       
            cliente = (Cliente)comboboxcliente.SelectedItem;
        }
        
    }
}
