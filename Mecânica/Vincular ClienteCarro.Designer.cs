namespace Mecânica
{
    partial class Vincular_ClienteCarro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vincular_ClienteCarro));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPesquisaVeiculo = new System.Windows.Forms.TextBox();
            this.dgvVincularVeiculo = new System.Windows.Forms.DataGridView();
            this.btnVincular = new System.Windows.Forms.Button();
            this.btnVeiculos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnMecanicos = new System.Windows.Forms.Button();
            this.btnPecas = new System.Windows.Forms.Button();
            this.btnOrcamentos = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVincularVeiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(158, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Location = new System.Drawing.Point(188, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 1);
            this.panel1.TabIndex = 49;
            // 
            // txtPesquisaVeiculo
            // 
            this.txtPesquisaVeiculo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisaVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaVeiculo.ForeColor = System.Drawing.Color.Silver;
            this.txtPesquisaVeiculo.Location = new System.Drawing.Point(188, 8);
            this.txtPesquisaVeiculo.Name = "txtPesquisaVeiculo";
            this.txtPesquisaVeiculo.Size = new System.Drawing.Size(580, 17);
            this.txtPesquisaVeiculo.TabIndex = 48;
            this.txtPesquisaVeiculo.Text = "Pesquise por placa, modelo...";
            this.txtPesquisaVeiculo.Click += new System.EventHandler(this.TxtPesquisaVeiculo_Click);
            this.txtPesquisaVeiculo.TextChanged += new System.EventHandler(this.TxtPesquisaVeiculo_TextChanged);
            this.txtPesquisaVeiculo.Leave += new System.EventHandler(this.TxtPesquisaVeiculo_Leave);
            // 
            // dgvVincularVeiculo
            // 
            this.dgvVincularVeiculo.AllowUserToAddRows = false;
            this.dgvVincularVeiculo.AllowUserToDeleteRows = false;
            this.dgvVincularVeiculo.AllowUserToResizeColumns = false;
            this.dgvVincularVeiculo.AllowUserToResizeRows = false;
            this.dgvVincularVeiculo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvVincularVeiculo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvVincularVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVincularVeiculo.Location = new System.Drawing.Point(158, 45);
            this.dgvVincularVeiculo.Name = "dgvVincularVeiculo";
            this.dgvVincularVeiculo.ReadOnly = true;
            this.dgvVincularVeiculo.Size = new System.Drawing.Size(617, 358);
            this.dgvVincularVeiculo.TabIndex = 47;
            this.dgvVincularVeiculo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVincularVeiculo_CellClick);
            // 
            // btnVincular
            // 
            this.btnVincular.BackColor = System.Drawing.Color.Transparent;
            this.btnVincular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVincular.Enabled = false;
            this.btnVincular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVincular.ForeColor = System.Drawing.Color.Transparent;
            this.btnVincular.Image = ((System.Drawing.Image)(resources.GetObject("btnVincular.Image")));
            this.btnVincular.Location = new System.Drawing.Point(613, 409);
            this.btnVincular.Name = "btnVincular";
            this.btnVincular.Size = new System.Drawing.Size(159, 49);
            this.btnVincular.TabIndex = 51;
            this.btnVincular.UseVisualStyleBackColor = false;
            this.btnVincular.Click += new System.EventHandler(this.BtnVincular_Click);
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
            this.btnVeiculos.TabIndex = 53;
            this.btnVeiculos.Text = "  Veículos";
            this.btnVeiculos.UseVisualStyleBackColor = false;
            this.btnVeiculos.Click += new System.EventHandler(this.btnVeiculos_Click);
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
            this.btnClientes.TabIndex = 52;
            this.btnClientes.Text = "  Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
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
            this.btnMecanicos.TabIndex = 146;
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
            // Vincular_ClienteCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnRelatorios);
            this.Controls.Add(this.btnOrcamentos);
            this.Controls.Add(this.btnPecas);
            this.Controls.Add(this.btnMecanicos);
            this.Controls.Add(this.btnVeiculos);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnVincular);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPesquisaVeiculo);
            this.Controls.Add(this.dgvVincularVeiculo);
            this.Name = "Vincular_ClienteCarro";
            this.Text = "Vincular_ClienteCarro";
            this.Load += new System.EventHandler(this.Vincular_ClienteCarro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVincularVeiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPesquisaVeiculo;
        private System.Windows.Forms.DataGridView dgvVincularVeiculo;
        private System.Windows.Forms.Button btnVincular;
        private System.Windows.Forms.Button btnVeiculos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnMecanicos;
        private System.Windows.Forms.Button btnPecas;
        private System.Windows.Forms.Button btnOrcamentos;
        private System.Windows.Forms.Button btnRelatorios;
    }
}