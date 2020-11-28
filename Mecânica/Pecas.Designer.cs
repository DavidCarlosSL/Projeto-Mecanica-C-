namespace Mecânica
{
    partial class Pecas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pecas));
            this.btnMecanicos = new System.Windows.Forms.Button();
            this.btnVeiculos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPesquisaPeca = new System.Windows.Forms.TextBox();
            this.dgvPecas = new System.Windows.Forms.DataGridView();
            this.btnAlterarPeca = new System.Windows.Forms.Button();
            this.btnPecas = new System.Windows.Forms.Button();
            this.btnOrcamentos = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPecas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMecanicos
            // 
            this.btnMecanicos.BackColor = System.Drawing.Color.Transparent;
            this.btnMecanicos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMecanicos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMecanicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMecanicos.ForeColor = System.Drawing.Color.White;
            this.btnMecanicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMecanicos.Location = new System.Drawing.Point(0, 229);
            this.btnMecanicos.Name = "btnMecanicos";
            this.btnMecanicos.Size = new System.Drawing.Size(148, 47);
            this.btnMecanicos.TabIndex = 57;
            this.btnMecanicos.Text = "Mecânicos";
            this.btnMecanicos.UseVisualStyleBackColor = false;
            this.btnMecanicos.Click += new System.EventHandler(this.BtnMecanicos_Click);
            // 
            // btnVeiculos
            // 
            this.btnVeiculos.BackColor = System.Drawing.Color.Transparent;
            this.btnVeiculos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeiculos.ForeColor = System.Drawing.Color.Transparent;
            this.btnVeiculos.Image = ((System.Drawing.Image)(resources.GetObject("btnVeiculos.Image")));
            this.btnVeiculos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVeiculos.Location = new System.Drawing.Point(0, 176);
            this.btnVeiculos.Name = "btnVeiculos";
            this.btnVeiculos.Size = new System.Drawing.Size(148, 47);
            this.btnVeiculos.TabIndex = 56;
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
            this.btnClientes.Location = new System.Drawing.Point(0, 123);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(148, 47);
            this.btnClientes.TabIndex = 55;
            this.btnClientes.Text = "  Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(162, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Location = new System.Drawing.Point(192, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 1);
            this.panel1.TabIndex = 53;
            // 
            // txtPesquisaPeca
            // 
            this.txtPesquisaPeca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisaPeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaPeca.ForeColor = System.Drawing.Color.Silver;
            this.txtPesquisaPeca.Location = new System.Drawing.Point(192, 1);
            this.txtPesquisaPeca.Name = "txtPesquisaPeca";
            this.txtPesquisaPeca.Size = new System.Drawing.Size(580, 17);
            this.txtPesquisaPeca.TabIndex = 52;
            this.txtPesquisaPeca.Text = "Pesquise por Nome...";
            this.txtPesquisaPeca.TextChanged += new System.EventHandler(this.TxtPesquisaPeca_TextChanged);
            this.txtPesquisaPeca.Enter += new System.EventHandler(this.TxtPesquisaPeca_Enter);
            this.txtPesquisaPeca.Leave += new System.EventHandler(this.TxtPesquisaPeca_Leave);
            // 
            // dgvPecas
            // 
            this.dgvPecas.AllowUserToAddRows = false;
            this.dgvPecas.AllowUserToDeleteRows = false;
            this.dgvPecas.AllowUserToResizeColumns = false;
            this.dgvPecas.AllowUserToResizeRows = false;
            this.dgvPecas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPecas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPecas.Location = new System.Drawing.Point(158, 38);
            this.dgvPecas.Name = "dgvPecas";
            this.dgvPecas.ReadOnly = true;
            this.dgvPecas.Size = new System.Drawing.Size(617, 358);
            this.dgvPecas.TabIndex = 51;
            this.dgvPecas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPecas_CellClick);
            // 
            // btnAlterarPeca
            // 
            this.btnAlterarPeca.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterarPeca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarPeca.Enabled = false;
            this.btnAlterarPeca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarPeca.ForeColor = System.Drawing.Color.Transparent;
            this.btnAlterarPeca.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarPeca.Image")));
            this.btnAlterarPeca.Location = new System.Drawing.Point(613, 402);
            this.btnAlterarPeca.Name = "btnAlterarPeca";
            this.btnAlterarPeca.Size = new System.Drawing.Size(162, 49);
            this.btnAlterarPeca.TabIndex = 50;
            this.btnAlterarPeca.UseVisualStyleBackColor = false;
            this.btnAlterarPeca.Click += new System.EventHandler(this.BtnAlterarPeca_Click);
            // 
            // btnPecas
            // 
            this.btnPecas.BackColor = System.Drawing.Color.Transparent;
            this.btnPecas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPecas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPecas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPecas.ForeColor = System.Drawing.Color.White;
            this.btnPecas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPecas.Location = new System.Drawing.Point(0, 282);
            this.btnPecas.Name = "btnPecas";
            this.btnPecas.Size = new System.Drawing.Size(148, 47);
            this.btnPecas.TabIndex = 58;
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
            this.btnOrcamentos.Location = new System.Drawing.Point(0, 335);
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
            this.btnRelatorios.Location = new System.Drawing.Point(0, 388);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(148, 47);
            this.btnRelatorios.TabIndex = 233;
            this.btnRelatorios.Text = "Relatórios";
            this.btnRelatorios.UseVisualStyleBackColor = false;
            this.btnRelatorios.Click += new System.EventHandler(this.BtnRelatorios_Click);
            // 
            // Pecas
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
            this.Controls.Add(this.txtPesquisaPeca);
            this.Controls.Add(this.dgvPecas);
            this.Controls.Add(this.btnAlterarPeca);
            this.Name = "Pecas";
            this.Text = "Pecas";
            this.Load += new System.EventHandler(this.Pecas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPecas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMecanicos;
        private System.Windows.Forms.Button btnVeiculos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPesquisaPeca;
        private System.Windows.Forms.DataGridView dgvPecas;
        private System.Windows.Forms.Button btnAlterarPeca;
        private System.Windows.Forms.Button btnPecas;
        private System.Windows.Forms.Button btnOrcamentos;
        private System.Windows.Forms.Button btnRelatorios;
    }
}