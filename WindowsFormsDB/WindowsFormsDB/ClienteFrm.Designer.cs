namespace WindowsFormsDB
{
    partial class ClienteFrm
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
            this.lblnome = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblcpf = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.TextBox();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(15, 25);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(54, 20);
            this.txtid.TabIndex = 0;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(12, 9);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(21, 13);
            this.lblid.TabIndex = 1;
            this.lblid.Text = "ID:";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(12, 50);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(38, 13);
            this.lblnome.TabIndex = 3;
            this.lblnome.Text = "Nome:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(15, 66);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(159, 20);
            this.txtnome.TabIndex = 2;
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Location = new System.Drawing.Point(12, 93);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(26, 13);
            this.lblcpf.TabIndex = 5;
            this.lblcpf.Text = "Cpf:";
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(15, 109);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(116, 20);
            this.txtcpf.TabIndex = 4;
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(12, 151);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(119, 40);
            this.btnregistrar.TabIndex = 6;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // ClienteFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 317);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtid);
            this.Name = "ClienteFrm";
            this.Text = "Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.TextBox txtcpf;
        private System.Windows.Forms.Button btnregistrar;
    }
}