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
    public partial class ProdutoFrm : Form
    {

        Produto produto;
        BindingSource bs;

        public ProdutoFrm()
        {
            InitializeComponent();
            produto = new Produto();
            bs = new BindingSource();
            bs.DataSource = produto;
            txtid.DataBindings.Add(nameof(Text), bs, nameof(produto.Id));
            txtcodean.DataBindings.Add(nameof(Text), bs, nameof(produto.Cod_ean));
            txtnome.DataBindings.Add(nameof(Text), bs, nameof(produto.Nome));
            txtpreco.DataBindings.Add(nameof(Text), bs, nameof(produto.Preco));
            txtquantidade.DataBindings.Add(nameof(Text), bs, nameof(produto.Quantidade));
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            ProdutoDB produtoDB = new ProdutoDB();
            MessageBox.Show(produtoDB.Salvar(produto));
            produto = new Produto();
            bs.DataSource = produto;
        }
    }
}
