namespace Mecânica
{
    partial class Vincular_OrcamentoMecanico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vincular_OrcamentoMecanico));
            this.btnPecas = new System.Windows.Forms.Button();
            this.btnMecanicos = new System.Windows.Forms.Button();
            this.txtPesquisaMecanico = new System.Windows.Forms.TextBox();
            this.btnVeiculos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnVincular = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvVincularMecanico = new System.Windows.Forms.DataGridView();
            this.btnOrcamentos = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVincularMecanico)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPecas
            // 
            this.btnPecas.BackColor = System.Drawing.Color.Transparent;
            this.btnPecas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPecas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPecas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPecas.ForeColor = System.Drawing.Color.White;
            this.btnPecas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPecas.Location = new System.Drawing.Point(0, 286);
            this.btnPecas.Name = "btnPecas";
            this.btnPecas.Size = new System.Drawing.Size(148, 47);
            this.btnPecas.TabIndex = 210;
            this.btnPecas.Text = "Peças";
            this.btnPecas.UseVisualStyleBackColor = false;
            this.btnPecas.Click += new System.EventHandler(this.BtnPecas_Click);
            // 
            // btnMecanicos
            // 
            this.btnMecanicos.BackColor = System.Drawing.Color.Transparent;
            this.btnMecanicos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMecanicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMecanicos.ForeColor = System.Drawing.Color.White;
            this.btnMecanicos.Location = new System.Drawing.Point(0, 233);
            this.btnMecanicos.Name = "btnMecanicos";
            this.btnMecanicos.Size = new System.Drawing.Size(148, 47);
            this.btnMecanicos.TabIndex = 209;
            this.btnMecanicos.Text = "Mecânicos";
            this.btnMecanicos.UseVisualStyleBackColor = false;
            this.btnMecanicos.Click += new System.EventHandler(this.BtnMecanicos_Click);
            // 
            // txtPesquisaMecanico
            // 
            this.txtPesquisaMecanico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisaMecanico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaMecanico.ForeColor = System.Drawing.Color.Silver;
            this.txtPesquisaMecanico.Location = new System.Drawing.Point(199, 5);
            this.txtPesquisaMecanico.Name = "txtPesquisaMecanico";
            this.txtPesquisaMecanico.Size = new System.Drawing.Size(580, 17);
            this.txtPesquisaMecanico.TabIndex = 208;
            this.txtPesquisaMecanico.Text = "Pesquise por CPF, Nome...";
            this.txtPesquisaMecanico.TextChanged += new System.EventHandler(this.TxtPesquisaMecanico_TextChanged);
            this.txtPesquisaMecanico.Enter += new System.EventHandler(this.TxtPesquisaMecanico_Enter);
            this.txtPesquisaMecanico.Leave += new System.EventHandler(this.TxtPesquisaMecanico_Leave);
            // 
            // btnVeiculos
            // 
            this.btnVeiculos.BackColor = System.Drawing.Color.Transparent;
            this.btnVeiculos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeiculos.ForeColor = System.Drawing.Color.Transparent;
            this.btnVeiculos.Image = ((System.Drawing.Image)(resources.GetObject("btnVeiculos.Image")));
            this.btnVeiculos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVeiculos.Location = new System.Drawing.Point(0, 180);
            this.btnVeiculos.Name = "btnVeiculos";
            this.btnVeiculos.Size = new System.Drawing.Size(148, 47);
            this.btnVeiculos.TabIndex = 207;
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
            this.btnClientes.Location = new System.Drawing.Point(0, 127);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(148, 47);
            this.btnClientes.TabIndex = 206;
            this.btnClientes.Text = "  Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // btnVincular
            // 
            this.btnVincular.BackColor = System.Drawing.Color.Transparent;
            this.btnVincular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVincular.Enabled = false;
            this.btnVincular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVincular.ForeColor = System.Drawing.Color.Transparent;
            this.btnVincular.Image = ((System.Drawing.Image)(resources.GetObject("btnVincular.Image")));
            this.btnVincular.Location = new System.Drawing.Point(620, 406);
            this.btnVincular.Name = "btnVincular";
            this.btnVincular.Size = new System.Drawing.Size(159, 49);
            this.btnVincular.TabIndex = 205;
            this.btnVincular.UseVisualStyleBackColor = false;
            this.btnVincular.Click += new System.EventHandler(this.BtnVincular_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(165, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 204;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Location = new System.Drawing.Point(195, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 1);
            this.panel1.TabIndex = 203;
            // 
            // dgvVincularMecanico
            // 
            this.dgvVincularMecanico.AllowUserToAddRows = false;
            this.dgvVincularMecanico.AllowUserToDeleteRows = false;
            this.dgvVincularMecanico.AllowUserToResizeColumns = false;
            this.dgvVincularMecanico.AllowUserToResizeRows = false;
            this.dgvVincularMecanico.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvVincularMecanico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvVincularMecanico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVincularMecanico.Location = new System.Drawing.Point(165, 42);
            this.dgvVincularMecanico.Name = "dgvVincularMecanico";
            this.dgvVincularMecanico.ReadOnly = true;
            this.dgvVincularMecanico.Size = new System.Drawing.Size(617, 358);
            this.dgvVincularMecanico.TabIndex = 202;
            this.dgvVincularMecanico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVincularMecanico_CellClick);
            // 
            // btnOrcamentos
            // 
            this.btnOrcamentos.BackColor = System.Drawing.Color.Transparent;
            this.btnOrcamentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOrcamentos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrcamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrcamentos.ForeColor = System.Drawing.Color.White;
            this.btnOrcamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrcamentos.Location = new System.Drawing.Point(0, 339);
            this.btnOrcamentos.Name = "btnOrcamentos";
            this.btnOrcamentos.Size = new System.Drawing.Size(148, 47);
            this.btnOrcamentos.TabIndex = 211;
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
            this.btnRelatorios.Location = new System.Drawing.Point(0, 392);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(148, 47);
            this.btnRelatorios.TabIndex = 233;
            this.btnRelatorios.Text = "Relatórios";
            this.btnRelatorios.UseVisualStyleBackColor = false;
            this.btnRelatorios.Click += new System.EventHandler(this.BtnRelatorios_Click);
            // 
            // Vincular_OrcamentoMecanico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mecânica.Properties.Resources.backgroundreal;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnRelatorios);
            this.Controls.Add(this.btnOrcamentos);
            this.Controls.Add(this.btnPecas);
            this.Controls.Add(this.btnMecanicos);
            this.Controls.Add(this.txtPesquisaMecanico);
            this.Controls.Add(this.btnVeiculos);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnVincular);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvVincularMecanico);
            this.Name = "Vincular_OrcamentoMecanico";
            this.Text = "Vincular_OrcamentoMecanico";
            this.Load += new System.EventHandler(this.Vincular_OrcamentoMecanico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVincularMecanico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPecas;
        private System.Windows.Forms.Button btnMecanicos;
        private System.Windows.Forms.TextBox txtPesquisaMecanico;
        private System.Windows.Forms.Button btnVeiculos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnVincular;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvVincularMecanico;
        private System.Windows.Forms.Button btnOrcamentos;
        private System.Windows.Forms.Button btnRelatorios;
    }
}