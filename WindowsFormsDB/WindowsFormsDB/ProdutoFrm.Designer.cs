namespace WindowsFormsDB
{
    partial class ProdutoFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.lblcodean = new System.Windows.Forms.Label();
            this.txtcodean = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblpreco = new System.Windows.Forms.Label();
            this.lblquantidade = new System.Windows.Forms.Label();
            this.txtquantidade = new System.Windows.Forms.TextBox();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.txtpreco = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(12, 26);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 0;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(9, 10);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(21, 13);
            this.lblid.TabIndex = 1;
            this.lblid.Text = "ID:";
            // 
            // lblcodean
            // 
            this.lblcodean.AutoSize = true;
            this.lblcodean.Location = new System.Drawing.Point(9, 53);
            this.lblcodean.Name = "lblcodean";
            this.lblcodean.Size = new System.Drawing.Size(57, 13);
            this.lblcodean.TabIndex = 3;
            this.lblcodean.Text = "Cód. EAN:";
            // 
            // txtcodean
            // 
            this.txtcodean.Location = new System.Drawing.Point(12, 69);
            this.txtcodean.Name = "txtcodean";
            this.txtcodean.Size = new System.Drawing.Size(100, 20);
            this.txtcodean.TabIndex = 2;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(9, 100);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(38, 13);
            this.lblnome.TabIndex = 5;
            this.lblnome.Text = "Nome:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(12, 116);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(160, 20);
            this.txtnome.TabIndex = 4;
            // 
            // lblpreco
            // 
            this.lblpreco.AutoSize = true;
            this.lblpreco.Location = new System.Drawing.Point(9, 147);
            this.lblpreco.Name = "lblpreco";
            this.lblpreco.Size = new System.Drawing.Size(38, 13);
            this.lblpreco.TabIndex = 7;
            this.lblpreco.Text = "Preço:";
            // 
            // lblquantidade
            // 
            this.lblquantidade.AutoSize = true;
            this.lblquantidade.Location = new System.Drawing.Point(9, 192);
            this.lblquantidade.Name = "lblquantidade";
            this.lblquantidade.Size = new System.Drawing.Size(65, 13);
            this.lblquantidade.TabIndex = 9;
            this.lblquantidade.Text = "Quantidade:";
            // 
            // txtquantidade
            // 
            this.txtquantidade.Location = new System.Drawing.Point(12, 208);
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(100, 20);
            this.txtquantidade.TabIndex = 8;
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(12, 247);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(100, 23);
            this.btnregistrar.TabIndex = 10;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(12, 163);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(100, 20);
            this.txtpreco.TabIndex = 11;
            // 
            // ProdutoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 369);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.lblquantidade);
            this.Controls.Add(this.txtquantidade);
            this.Controls.Add(this.lblpreco);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblcodean);
            this.Controls.Add(this.txtcodean);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtid);
            this.Name = "ProdutoFrm";
            this.Text = "Produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblcodean;
        private System.Windows.Forms.TextBox txtcodean;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblpreco;
        private System.Windows.Forms.Label lblquantidade;
        private System.Windows.Forms.TextBox txtquantidade;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.MaskedTextBox txtpreco;
    }
}