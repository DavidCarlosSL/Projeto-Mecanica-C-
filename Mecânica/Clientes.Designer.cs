namespace Mecânica
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.btnRegistrarCliente = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.txtPesquisaCliente = new System.Windows.Forms.TextBox();
            this.btnRemoverCliente = new System.Windows.Forms.Button();
            this.btnAlterarRegistro = new System.Windows.Forms.Button();
            this.btnVincularVeiculo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnVeiculos = new System.Windows.Forms.Button();
            this.btnMecanicos = new System.Windows.Forms.Button();
            this.btnPecas = new System.Windows.Forms.Button();
            this.btnOrcamentos = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCliente.ForeColor = System.Drawing.Color.Transparent;
            this.btnRegistrarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarCliente.Image")));
            this.btnRegistrarCliente.Location = new System.Drawing.Point(613, 409);
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.Size = new System.Drawing.Size(162, 49);
            this.btnRegistrarCliente.TabIndex = 0;
            this.btnRegistrarCliente.UseVisualStyleBackColor = false;
            this.btnRegistrarCliente.Click += new System.EventHandler(this.BtnRegistrarCliente_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(158, 45);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(617, 358);
            this.dgvClientes.TabIndex = 28;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClientes_CellClick);
            this.dgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClientes_CellDoubleClick);
            // 
            // txtPesquisaCliente
            // 
            this.txtPesquisaCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaCliente.ForeColor = System.Drawing.Color.Silver;
            this.txtPesquisaCliente.Location = new System.Drawing.Point(192, 8);
            this.txtPesquisaCliente.Name = "txtPesquisaCliente";
            this.txtPesquisaCliente.Size = new System.Drawing.Size(580, 17);
            this.txtPesquisaCliente.TabIndex = 31;
            this.txtPesquisaCliente.Text = "Pesquise por CPF, Nome...";
            this.txtPesquisaCliente.TextChanged += new System.EventHandler(this.TxtPesquisaCliente_TextChanged);
            this.txtPesquisaCliente.Enter += new System.EventHandler(this.TxtPesquisaCliente_Enter);
            this.txtPesquisaCliente.Leave += new System.EventHandler(this.TxtPesquisaCliente_Leave);
            // 
            // btnRemoverCliente
            // 
            this.btnRemoverCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoverCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoverCliente.Enabled = false;
            this.btnRemoverCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverCliente.ForeColor = System.Drawing.Color.Transparent;
            this.btnRemoverCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverCliente.Image")));
            this.btnRemoverCliente.Location = new System.Drawing.Point(158, 413);
            this.btnRemoverCliente.Name = "btnRemoverCliente";
            this.btnRemoverCliente.Size = new System.Drawing.Size(131, 40);
            this.btnRemoverCliente.TabIndex = 32;
            this.btnRemoverCliente.UseVisualStyleBackColor = false;
            this.btnRemoverCliente.Click += new System.EventHandler(this.BtnRemoverCliente_Click);
            // 
            // btnAlterarRegistro
            // 
            this.btnAlterarRegistro.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterarRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarRegistro.Enabled = false;
            this.btnAlterarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarRegistro.ForeColor = System.Drawing.Color.Transparent;
            this.btnAlterarRegistro.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarRegistro.Image")));
            this.btnAlterarRegistro.Location = new System.Drawing.Point(295, 409);
            this.btnAlterarRegistro.Name = "btnAlterarRegistro";
            this.btnAlterarRegistro.Size = new System.Drawing.Size(162, 49);
            this.btnAlterarRegistro.TabIndex = 33;
            this.btnAlterarRegistro.UseVisualStyleBackColor = false;
            this.btnAlterarRegistro.Click += new System.EventHandler(this.BtnAlterarRegistro_Click);
            // 
            // btnVincularVeiculo
            // 
            this.btnVincularVeiculo.BackColor = System.Drawing.Color.Transparent;
            this.btnVincularVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVincularVeiculo.Enabled = false;
            this.btnVincularVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVincularVeiculo.ForeColor = System.Drawing.Color.Transparent;
            this.btnVincularVeiculo.Image = ((System.Drawing.Image)(resources.GetObject("btnVincularVeiculo.Image")));
            this.btnVincularVeiculo.Location = new System.Drawing.Point(454, 409);
            this.btnVincularVeiculo.Name = "btnVincularVeiculo";
            this.btnVincularVeiculo.Size = new System.Drawing.Size(162, 49);
            this.btnVincularVeiculo.TabIndex = 34;
            this.btnVincularVeiculo.UseVisualStyleBackColor = false;
            this.btnVincularVeiculo.Click += new System.EventHandler(this.BtnVincularVeiculo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Location = new System.Drawing.Point(192, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 1);
            this.panel1.TabIndex = 35;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(162, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.Transparent;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 130);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(148, 47);
            this.btnClientes.TabIndex = 37;
            this.btnClientes.Text = "  Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // btnVeiculos
            // 
            this.btnVeiculos.BackColor = System.Drawing.Color.Transparent;
            this.btnVeiculos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeiculos.ForeColor = System.Drawing.Color.Transparent;
            this.btnVeiculos.Image = ((System.Drawing.Image)(resources.GetObject("btnVeiculos.Image")));
            this.btnVeiculos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVeiculos.Location = new System.Drawing.Point(0, 183);
            this.btnVeiculos.Name = "btnVeiculos";
            this.btnVeiculos.Size = new System.Drawing.Size(148, 47);
            this.btnVeiculos.TabIndex = 38;
            this.btnVeiculos.Text = "  Veículos";
            this.btnVeiculos.UseVisualStyleBackColor = false;
            this.btnVeiculos.Click += new System.EventHandler(this.BtnVeiculos_Click);
            // 
            // btnMecanicos
            // 
            this.btnMecanicos.BackColor = System.Drawing.Color.Transparent;
            this.btnMecanicos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMecanicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMecanicos.ForeColor = System.Drawing.Color.White;
            this.btnMecanicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMecanicos.Location = new System.Drawing.Point(0, 236);
            this.btnMecanicos.Name = "btnMecanicos";
            this.btnMecanicos.Size = new System.Drawing.Size(148, 47);
            this.btnMecanicos.TabIndex = 50;
            this.btnMecanicos.Text = "Mecânicos";
            this.btnMecanicos.UseVisualStyleBackColor = false;
            this.btnMecanicos.Click += new System.EventHandler(this.BtnMecanicos_Click);
            // 
            // btnPecas
            // 
            this.btnPecas.BackColor = System.Drawing.Color.Transparent;
            this.btnPecas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPecas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPecas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPecas.ForeColor = System.Drawing.Color.White;
            this.btnPecas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPecas.Location = new System.Drawing.Point(0, 289);
            this.btnPecas.Name = "btnPecas";
            this.btnPecas.Size = new System.Drawing.Size(148, 47);
            this.btnPecas.TabIndex = 200;
            this.btnPecas.Text = "Peças";
            this.btnPecas.UseVisualStyleBackColor = false;
            this.btnPecas.Click += new System.EventHandler(this.BtnPecas_Click);
            // 
            // btnOrcamentos
            // 
            this.btnOrcamentos.BackColor = System.Drawing.Color.Transparent;
            this.btnOrcamentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOrcamentos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrcamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrcamentos.ForeColor = System.Drawing.Color.White;
            this.btnOrcamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrcamentos.Location = new System.Drawing.Point(0, 342);
            this.btnOrcamentos.Name = "btnOrcamentos";
            this.btnOrcamentos.Size = new System.Drawing.Size(148, 47);
            this.btnOrcamentos.TabIndex = 208;
            this.btnOrcamentos.Text = "Orçamentos";
            this.btnOrcamentos.UseVisualStyleBackColor = false;
            this.btnOrcamentos.Click += new System.EventHandler(this.BtnOrcamento_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.BackColor = System.Drawing.Color.Transparent;
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.ForeColor = System.Drawing.Color.White;
            this.btnRelatorios.Location = new System.Drawing.Point(0, 395);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(148, 47);
            this.btnRelatorios.TabIndex = 233;
            this.btnRelatorios.Text = "Relatórios";
            this.btnRelatorios.UseVisualStyleBackColor = false;
            this.btnRelatorios.Click += new System.EventHandler(this.BtnRelatorios_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnRelatorios);
            this.Controls.Add(this.btnOrcamentos);
            this.Controls.Add(this.btnPecas);
            this.Controls.Add(this.btnMecanicos);
            this.Controls.Add(this.btnVeiculos);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVincularVeiculo);
            this.Controls.Add(this.btnAlterarRegistro);
            this.Controls.Add(this.btnRemoverCliente);
            this.Controls.Add(this.txtPesquisaCliente);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnRegistrarCliente);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox txtPesquisaCliente;
        private System.Windows.Forms.Button btnRemoverCliente;
        private System.Windows.Forms.Button btnAlterarRegistro;
        private System.Windows.Forms.Button btnVincularVeiculo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnVeiculos;
        private System.Windows.Forms.Button btnMecanicos;
        private System.Windows.Forms.Button btnPecas;
        private System.Windows.Forms.Button btnOrcamentos;
        private System.Windows.Forms.Button btnRelatorios;
    }
}