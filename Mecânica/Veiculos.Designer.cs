namespace Mecânica
{
    partial class Veiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Veiculos));
            this.btnVeiculos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAlterarRegistro = new System.Windows.Forms.Button();
            this.btnRemoverVeiculo = new System.Windows.Forms.Button();
            this.txtPesquisaVeiculo = new System.Windows.Forms.TextBox();
            this.dgvVeiculos = new System.Windows.Forms.DataGridView();
            this.btnRegistrarVeiculo = new System.Windows.Forms.Button();
            this.btnVincularCliente = new System.Windows.Forms.Button();
            this.btnMecanicos = new System.Windows.Forms.Button();
            this.btnPecas = new System.Windows.Forms.Button();
            this.btnOrcamentos = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).BeginInit();
            this.SuspendLayout();
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
            this.btnVeiculos.TabIndex = 48;
            this.btnVeiculos.Text = "  Veículos";
            this.btnVeiculos.UseVisualStyleBackColor = false;
            this.btnVeiculos.Click += new System.EventHandler(this.BtnVeiculos_Click);
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
            this.btnClientes.TabIndex = 47;
            this.btnClientes.Text = "  Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(162, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Location = new System.Drawing.Point(192, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 1);
            this.panel1.TabIndex = 45;
            // 
            // btnAlterarRegistro
            // 
            this.btnAlterarRegistro.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterarRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarRegistro.Enabled = false;
            this.btnAlterarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarRegistro.ForeColor = System.Drawing.Color.Transparent;
            this.btnAlterarRegistro.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarRegistro.Image")));
            this.btnAlterarRegistro.Location = new System.Drawing.Point(454, 409);
            this.btnAlterarRegistro.Name = "btnAlterarRegistro";
            this.btnAlterarRegistro.Size = new System.Drawing.Size(162, 49);
            this.btnAlterarRegistro.TabIndex = 43;
            this.btnAlterarRegistro.UseVisualStyleBackColor = false;
            this.btnAlterarRegistro.Click += new System.EventHandler(this.BtnAlterarRegistro_Click);
            // 
            // btnRemoverVeiculo
            // 
            this.btnRemoverVeiculo.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoverVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoverVeiculo.Enabled = false;
            this.btnRemoverVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverVeiculo.ForeColor = System.Drawing.Color.Transparent;
            this.btnRemoverVeiculo.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverVeiculo.Image")));
            this.btnRemoverVeiculo.Location = new System.Drawing.Point(158, 413);
            this.btnRemoverVeiculo.Name = "btnRemoverVeiculo";
            this.btnRemoverVeiculo.Size = new System.Drawing.Size(131, 40);
            this.btnRemoverVeiculo.TabIndex = 42;
            this.btnRemoverVeiculo.UseVisualStyleBackColor = false;
            this.btnRemoverVeiculo.Click += new System.EventHandler(this.BtnRemoverVeiculo_Click);
            // 
            // txtPesquisaVeiculo
            // 
            this.txtPesquisaVeiculo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisaVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaVeiculo.ForeColor = System.Drawing.Color.Silver;
            this.txtPesquisaVeiculo.Location = new System.Drawing.Point(192, 8);
            this.txtPesquisaVeiculo.Name = "txtPesquisaVeiculo";
            this.txtPesquisaVeiculo.Size = new System.Drawing.Size(580, 17);
            this.txtPesquisaVeiculo.TabIndex = 41;
            this.txtPesquisaVeiculo.Text = "Pesquise por placa, modelo...";
            this.txtPesquisaVeiculo.TextChanged += new System.EventHandler(this.TxtPesquisaVeiculo_TextChanged);
            this.txtPesquisaVeiculo.Enter += new System.EventHandler(this.TxtPesquisaVeiculo_Enter);
            this.txtPesquisaVeiculo.Leave += new System.EventHandler(this.TxtPesquisaVeiculo_Leave);
            // 
            // dgvVeiculos
            // 
            this.dgvVeiculos.AllowUserToAddRows = false;
            this.dgvVeiculos.AllowUserToDeleteRows = false;
            this.dgvVeiculos.AllowUserToResizeColumns = false;
            this.dgvVeiculos.AllowUserToResizeRows = false;
            this.dgvVeiculos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvVeiculos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeiculos.Location = new System.Drawing.Point(158, 45);
            this.dgvVeiculos.Name = "dgvVeiculos";
            this.dgvVeiculos.ReadOnly = true;
            this.dgvVeiculos.Size = new System.Drawing.Size(617, 358);
            this.dgvVeiculos.TabIndex = 40;
            this.dgvVeiculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVeiculos_CellClick);
            this.dgvVeiculos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVeiculos_CellDoubleClick);
            // 
            // btnRegistrarVeiculo
            // 
            this.btnRegistrarVeiculo.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarVeiculo.ForeColor = System.Drawing.Color.Transparent;
            this.btnRegistrarVeiculo.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarVeiculo.Image")));
            this.btnRegistrarVeiculo.Location = new System.Drawing.Point(613, 409);
            this.btnRegistrarVeiculo.Name = "btnRegistrarVeiculo";
            this.btnRegistrarVeiculo.Size = new System.Drawing.Size(162, 49);
            this.btnRegistrarVeiculo.TabIndex = 39;
            this.btnRegistrarVeiculo.UseVisualStyleBackColor = false;
            this.btnRegistrarVeiculo.Click += new System.EventHandler(this.BtnRegistrarVeiculo_Click);
            // 
            // btnVincularCliente
            // 
            this.btnVincularCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnVincularCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVincularCliente.Enabled = false;
            this.btnVincularCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVincularCliente.ForeColor = System.Drawing.Color.Transparent;
            this.btnVincularCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnVincularCliente.Image")));
            this.btnVincularCliente.Location = new System.Drawing.Point(295, 409);
            this.btnVincularCliente.Name = "btnVincularCliente";
            this.btnVincularCliente.Size = new System.Drawing.Size(162, 49);
            this.btnVincularCliente.TabIndex = 49;
            this.btnVincularCliente.UseVisualStyleBackColor = false;
            this.btnVincularCliente.Click += new System.EventHandler(this.BtnVincularCliente_Click);
            // 
            // btnMecanicos
            // 
            this.btnMecanicos.BackColor = System.Drawing.Color.Transparent;
            this.btnMecanicos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMecanicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMecanicos.ForeColor = System.Drawing.Color.White;
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
            // Veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnRelatorios);
            this.Controls.Add(this.btnOrcamentos);
            this.Controls.Add(this.btnPecas);
            this.Controls.Add(this.btnMecanicos);
            this.Controls.Add(this.btnVincularCliente);
            this.Controls.Add(this.btnVeiculos);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAlterarRegistro);
            this.Controls.Add(this.btnRemoverVeiculo);
            this.Controls.Add(this.txtPesquisaVeiculo);
            this.Controls.Add(this.dgvVeiculos);
            this.Controls.Add(this.btnRegistrarVeiculo);
            this.Name = "Veiculos";
            this.Text = "Veiculos";
            this.Load += new System.EventHandler(this.Veiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVeiculos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAlterarRegistro;
        private System.Windows.Forms.Button btnRemoverVeiculo;
        private System.Windows.Forms.TextBox txtPesquisaVeiculo;
        private System.Windows.Forms.DataGridView dgvVeiculos;
        private System.Windows.Forms.Button btnRegistrarVeiculo;
        private System.Windows.Forms.Button btnVincularCliente;
        private System.Windows.Forms.Button btnMecanicos;
        private System.Windows.Forms.Button btnPecas;
        private System.Windows.Forms.Button btnOrcamentos;
        private System.Windows.Forms.Button btnRelatorios;
    }
}