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
    public partial class ClienteFrm : Form
    {
        Cliente cliente;
        BindingSource bs;

        public ClienteFrm()
        {
            InitializeComponent();
            cliente = new Cliente();
            bs = new BindingSource();
            bs.DataSource = cliente;            
            txtid.DataBindings.Add(nameof(Text), bs, nameof(cliente.Id));
            txtcpf.DataBindings.Add(nameof(Text), bs, nameof(cliente.Cpf));
            txtnome.DataBindings.Add(nameof(Text), bs, nameof(cliente.Nome));
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            ClienteDB clienteDB = new ClienteDB();
            MessageBox.Show(clienteDB.Salvar(cliente));
            cliente = new Cliente();
            bs.DataSource = cliente;
        }
    }
}
