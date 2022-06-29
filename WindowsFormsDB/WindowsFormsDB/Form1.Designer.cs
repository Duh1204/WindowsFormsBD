namespace WindowsFormsDB
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.comboboxcliente = new System.Windows.Forms.ComboBox();
            this.lblcliente = new System.Windows.Forms.Label();
            this.lblproduto = new System.Windows.Forms.Label();
            this.comboboxproduto = new System.Windows.Forms.ComboBox();
            this.numericquantidade = new System.Windows.Forms.NumericUpDown();
            this.btnincluir = new System.Windows.Forms.Button();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.lblvalor = new System.Windows.Forms.Label();
            this.dgitemvenda = new System.Windows.Forms.DataGridView();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.txtvalortotal = new System.Windows.Forms.TextBox();
            this.lvlvalortotal = new System.Windows.Forms.Label();
            this.lblquantidade = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericquantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgitemvenda)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.produtoToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.produtoToolStripMenuItem.Text = "Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(9, 26);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(21, 13);
            this.lblid.TabIndex = 1;
            this.lblid.Text = "ID:";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(12, 43);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 2;
            // 
            // comboboxcliente
            // 
            this.comboboxcliente.FormattingEnabled = true;
            this.comboboxcliente.Location = new System.Drawing.Point(12, 84);
            this.comboboxcliente.Name = "comboboxcliente";
            this.comboboxcliente.Size = new System.Drawing.Size(144, 21);
            this.comboboxcliente.TabIndex = 3;
            this.comboboxcliente.SelectedIndexChanged += new System.EventHandler(this.comboboxcliente_SelectedIndexChanged);
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Location = new System.Drawing.Point(12, 68);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(42, 13);
            this.lblcliente.TabIndex = 4;
            this.lblcliente.Text = "Cliente:";
            // 
            // lblproduto
            // 
            this.lblproduto.AutoSize = true;
            this.lblproduto.Location = new System.Drawing.Point(12, 117);
            this.lblproduto.Name = "lblproduto";
            this.lblproduto.Size = new System.Drawing.Size(47, 13);
            this.lblproduto.TabIndex = 6;
            this.lblproduto.Text = "Produto:";
            // 
            // comboboxproduto
            // 
            this.comboboxproduto.FormattingEnabled = true;
            this.comboboxproduto.Location = new System.Drawing.Point(12, 133);
            this.comboboxproduto.Name = "comboboxproduto";
            this.comboboxproduto.Size = new System.Drawing.Size(144, 21);
            this.comboboxproduto.TabIndex = 5;
            this.comboboxproduto.SelectedIndexChanged += new System.EventHandler(this.comboboxproduto_SelectedIndexChanged);
            // 
            // numericquantidade
            // 
            this.numericquantidade.Location = new System.Drawing.Point(162, 133);
            this.numericquantidade.Name = "numericquantidade";
            this.numericquantidade.Size = new System.Drawing.Size(62, 20);
            this.numericquantidade.TabIndex = 7;
            this.numericquantidade.ValueChanged += new System.EventHandler(this.numericquantidade_ValueChanged);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(12, 176);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(99, 36);
            this.btnincluir.TabIndex = 8;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // txtvalor
            // 
            this.txtvalor.Enabled = false;
            this.txtvalor.Location = new System.Drawing.Point(241, 132);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 20);
            this.txtvalor.TabIndex = 9;
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Location = new System.Drawing.Point(238, 116);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(34, 13);
            this.lblvalor.TabIndex = 10;
            this.lblvalor.Text = "Valor:";
            // 
            // dgitemvenda
            // 
            this.dgitemvenda.AllowUserToAddRows = false;
            this.dgitemvenda.AllowUserToDeleteRows = false;
            this.dgitemvenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgitemvenda.Location = new System.Drawing.Point(13, 218);
            this.dgitemvenda.Name = "dgitemvenda";
            this.dgitemvenda.ReadOnly = true;
            this.dgitemvenda.Size = new System.Drawing.Size(531, 130);
            this.dgitemvenda.TabIndex = 11;
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(15, 399);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(97, 23);
            this.btnsalvar.TabIndex = 12;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // txtvalortotal
            // 
            this.txtvalortotal.Enabled = false;
            this.txtvalortotal.Location = new System.Drawing.Point(15, 373);
            this.txtvalortotal.Name = "txtvalortotal";
            this.txtvalortotal.Size = new System.Drawing.Size(100, 20);
            this.txtvalortotal.TabIndex = 13;
            // 
            // lvlvalortotal
            // 
            this.lvlvalortotal.AutoSize = true;
            this.lvlvalortotal.Location = new System.Drawing.Point(12, 354);
            this.lvlvalortotal.Name = "lvlvalortotal";
            this.lvlvalortotal.Size = new System.Drawing.Size(61, 13);
            this.lvlvalortotal.TabIndex = 14;
            this.lvlvalortotal.Text = "Valor Total:";
            // 
            // lblquantidade
            // 
            this.lblquantidade.AutoSize = true;
            this.lblquantidade.Location = new System.Drawing.Point(159, 116);
            this.lblquantidade.Name = "lblquantidade";
            this.lblquantidade.Size = new System.Drawing.Size(65, 13);
            this.lblquantidade.TabIndex = 15;
            this.lblquantidade.Text = "Quantidade:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblquantidade);
            this.Controls.Add(this.lvlvalortotal);
            this.Controls.Add(this.txtvalortotal);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.dgitemvenda);
            this.Controls.Add(this.lblvalor);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.btnincluir);
            this.Controls.Add(this.numericquantidade);
            this.Controls.Add(this.lblproduto);
            this.Controls.Add(this.comboboxproduto);
            this.Controls.Add(this.lblcliente);
            this.Controls.Add(this.comboboxcliente);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Venda";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericquantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgitemvenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.ComboBox comboboxcliente;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.Label lblproduto;
        private System.Windows.Forms.ComboBox comboboxproduto;
        private System.Windows.Forms.NumericUpDown numericquantidade;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.DataGridView dgitemvenda;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.TextBox txtvalortotal;
        private System.Windows.Forms.Label lvlvalortotal;
        private System.Windows.Forms.Label lblquantidade;
    }
}

