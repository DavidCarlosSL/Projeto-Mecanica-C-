namespace Mecânica
{
    partial class Relatorio_Faturamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatorio_Faturamento));
            this.btnOrcamentos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPecas = new System.Windows.Forms.Button();
            this.btnMecanicos = new System.Windows.Forms.Button();
            this.btnVeiculos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPesquisaOrcamento = new System.Windows.Forms.TextBox();
            this.dgvRelatorioFaturamento = new System.Windows.Forms.DataGridView();
            this.lblFaturamento = new System.Windows.Forms.Label();
            this.txtFaturamento = new System.Windows.Forms.TextBox();
            this.btnRelatorios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorioFaturamento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrcamentos
            // 
            this.btnOrcamentos.BackColor = System.Drawing.Color.Transparent;
            this.btnOrcamentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOrcamentos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrcamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrcamentos.ForeColor = System.Drawing.Color.White;
            this.btnOrcamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrcamentos.Location = new System.Drawing.Point(0, 337);
            this.btnOrcamentos.Name = "btnOrcamentos";
            this.btnOrcamentos.Size = new System.Drawing.Size(148, 47);
            this.btnOrcamentos.TabIndex = 220;
            this.btnOrcamentos.Text = "Orçamentos";
            this.btnOrcamentos.UseVisualStyleBackColor = false;
            this.btnOrcamentos.Click += new System.EventHandler(this.BtnOrcamento_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Location = new System.Drawing.Point(195, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 1);
            this.panel1.TabIndex = 217;
            // 
            // btnPecas
            // 
            this.btnPecas.BackColor = System.Drawing.Color.Transparent;
            this.btnPecas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPecas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPecas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPecas.ForeColor = System.Drawing.Color.White;
            this.btnPecas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPecas.Location = new System.Drawing.Point(0, 284);
            this.btnPecas.Name = "btnPecas";
            this.btnPecas.Size = new System.Drawing.Size(148, 47);
            this.btnPecas.TabIndex = 216;
            this.btnPecas.Text = "Peças";
            this.btnPecas.UseVisualStyleBackColor = false;
            this.btnPecas.Click += new System.EventHandler(this.BtnPecas_Click);
            // 
            // btnMecanicos
            // 
            this.btnMecanicos.BackColor = System.Drawing.Color.Transparent;
            this.btnMecanicos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMecanicos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMecanicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMecanicos.ForeColor = System.Drawing.Color.White;
            this.btnMecanicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMecanicos.Location = new System.Drawing.Point(0, 231);
            this.btnMecanicos.Name = "btnMecanicos";
            this.btnMecanicos.Size = new System.Drawing.Size(148, 47);
            this.btnMecanicos.TabIndex = 215;
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
            this.btnVeiculos.Location = new System.Drawing.Point(0, 178);
            this.btnVeiculos.Name = "btnVeiculos";
            this.btnVeiculos.Size = new System.Drawing.Size(148, 47);
            this.btnVeiculos.TabIndex = 214;
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
            this.btnClientes.Location = new System.Drawing.Point(0, 125);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(148, 47);
            this.btnClientes.TabIndex = 213;
            this.btnClientes.Text = "  Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(162, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 212;
            this.pictureBox1.TabStop = false;
            // 
            // txtPesquisaOrcamento
            // 
            this.txtPesquisaOrcamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisaOrcamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaOrcamento.ForeColor = System.Drawing.Color.Silver;
            this.txtPesquisaOrcamento.Location = new System.Drawing.Point(192, 3);
            this.txtPesquisaOrcamento.Name = "txtPesquisaOrcamento";
            this.txtPesquisaOrcamento.Size = new System.Drawing.Size(580, 17);
            this.txtPesquisaOrcamento.TabIndex = 211;
            this.txtPesquisaOrcamento.Text = "Pesquise por Placa...";
            this.txtPesquisaOrcamento.TextChanged += new System.EventHandler(this.TxtPesquisaOrcamento_TextChanged);
            this.txtPesquisaOrcamento.Enter += new System.EventHandler(this.TxtPesquisaOrcamento_Enter);
            this.txtPesquisaOrcamento.Leave += new System.EventHandler(this.TxtPesquisaOrcamento_Leave);
            // 
            // dgvRelatorioFaturamento
            // 
            this.dgvRelatorioFaturamento.AllowUserToAddRows = false;
            this.dgvRelatorioFaturamento.AllowUserToDeleteRows = false;
            this.dgvRelatorioFaturamento.AllowUserToResizeColumns = false;
            this.dgvRelatorioFaturamento.AllowUserToResizeRows = false;
            this.dgvRelatorioFaturamento.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRelatorioFaturamento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRelatorioFaturamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorioFaturamento.Location = new System.Drawing.Point(158, 40);
            this.dgvRelatorioFaturamento.Name = "dgvRelatorioFaturamento";
            this.dgvRelatorioFaturamento.ReadOnly = true;
            this.dgvRelatorioFaturamento.Size = new System.Drawing.Size(617, 373);
            this.dgvRelatorioFaturamento.TabIndex = 210;
            // 
            // lblFaturamento
            // 
            this.lblFaturamento.AutoSize = true;
            this.lblFaturamento.BackColor = System.Drawing.Color.Transparent;
            this.lblFaturamento.Location = new System.Drawing.Point(165, 432);
            this.lblFaturamento.Name = "lblFaturamento";
            this.lblFaturamento.Size = new System.Drawing.Size(96, 13);
            this.lblFaturamento.TabIndex = 221;
            this.lblFaturamento.Text = "Faturamento Total:";
            // 
            // txtFaturamento
            // 
            this.txtFaturamento.Enabled = false;
            this.txtFaturamento.Location = new System.Drawing.Point(267, 429);
            this.txtFaturamento.Name = "txtFaturamento";
            this.txtFaturamento.Size = new System.Drawing.Size(100, 20);
            this.txtFaturamento.TabIndex = 223;
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.BackColor = System.Drawing.Color.Transparent;
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.ForeColor = System.Drawing.Color.White;
            this.btnRelatorios.Location = new System.Drawing.Point(0, 390);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(148, 47);
            this.btnRelatorios.TabIndex = 233;
            this.btnRelatorios.Text = "Relatórios";
            this.btnRelatorios.UseVisualStyleBackColor = false;
            this.btnRelatorios.Click += new System.EventHandler(this.BtnRelatorios_Click);
            // 
            // Relatorio_Faturamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mecânica.Properties.Resources.backgroundreal;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnRelatorios);
            this.Controls.Add(this.txtFaturamento);
            this.Controls.Add(this.lblFaturamento);
            this.Controls.Add(this.btnOrcamentos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPecas);
            this.Controls.Add(this.btnMecanicos);
            this.Controls.Add(this.btnVeiculos);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPesquisaOrcamento);
            this.Controls.Add(this.dgvRelatorioFaturamento);
            this.Name = "Relatorio_Faturamento";
            this.Text = "Relatorio_Faturamento";
            this.Load += new System.EventHandler(this.Relatorio_Faturamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorioFaturamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrcamentos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPecas;
        private System.Windows.Forms.Button btnMecanicos;
        private System.Windows.Forms.Button btnVeiculos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPesquisaOrcamento;
        private System.Windows.Forms.DataGridView dgvRelatorioFaturamento;
        private System.Windows.Forms.Label lblFaturamento;
        private System.Windows.Forms.TextBox txtFaturamento;
        private System.Windows.Forms.Button btnRelatorios;
    }
}