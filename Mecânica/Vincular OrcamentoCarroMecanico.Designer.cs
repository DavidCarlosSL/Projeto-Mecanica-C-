namespace Mecânica
{
    partial class Vincular_OrcamentoCarroMecanico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vincular_OrcamentoCarroMecanico));
            this.btnPecas = new System.Windows.Forms.Button();
            this.btnMecanicos = new System.Windows.Forms.Button();
            this.btnVeiculos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnVincular = new System.Windows.Forms.Button();
            this.dgvVincularVeiculo = new System.Windows.Forms.DataGridView();
            this.dgvVincularMecanicos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOrcamento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVincularVeiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVincularMecanicos)).BeginInit();
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
            this.btnPecas.Location = new System.Drawing.Point(0, 284);
            this.btnPecas.Name = "btnPecas";
            this.btnPecas.Size = new System.Drawing.Size(148, 47);
            this.btnPecas.TabIndex = 184;
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
            this.btnMecanicos.Location = new System.Drawing.Point(0, 231);
            this.btnMecanicos.Name = "btnMecanicos";
            this.btnMecanicos.Size = new System.Drawing.Size(148, 47);
            this.btnMecanicos.TabIndex = 183;
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
            this.btnVeiculos.TabIndex = 181;
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
            this.btnClientes.TabIndex = 180;
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
            this.btnVincular.Location = new System.Drawing.Point(618, 404);
            this.btnVincular.Name = "btnVincular";
            this.btnVincular.Size = new System.Drawing.Size(159, 49);
            this.btnVincular.TabIndex = 179;
            this.btnVincular.UseVisualStyleBackColor = false;
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
            this.dgvVincularVeiculo.Location = new System.Drawing.Point(163, 40);
            this.dgvVincularVeiculo.Name = "dgvVincularVeiculo";
            this.dgvVincularVeiculo.ReadOnly = true;
            this.dgvVincularVeiculo.Size = new System.Drawing.Size(617, 156);
            this.dgvVincularVeiculo.TabIndex = 176;
            // 
            // dgvVincularMecanicos
            // 
            this.dgvVincularMecanicos.AllowUserToAddRows = false;
            this.dgvVincularMecanicos.AllowUserToDeleteRows = false;
            this.dgvVincularMecanicos.AllowUserToResizeColumns = false;
            this.dgvVincularMecanicos.AllowUserToResizeRows = false;
            this.dgvVincularMecanicos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvVincularMecanicos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvVincularMecanicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVincularMecanicos.Location = new System.Drawing.Point(163, 231);
            this.dgvVincularMecanicos.Name = "dgvVincularMecanicos";
            this.dgvVincularMecanicos.ReadOnly = true;
            this.dgvVincularMecanicos.Size = new System.Drawing.Size(617, 154);
            this.dgvVincularMecanicos.TabIndex = 185;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 186;
            this.label1.Text = "Veículos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 187;
            this.label2.Text = "Mecânicos";
            // 
            // btnOrcamento
            // 
            this.btnOrcamento.BackColor = System.Drawing.Color.Transparent;
            this.btnOrcamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOrcamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrcamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrcamento.ForeColor = System.Drawing.Color.White;
            this.btnOrcamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrcamento.Location = new System.Drawing.Point(0, 337);
            this.btnOrcamento.Name = "btnOrcamento";
            this.btnOrcamento.Size = new System.Drawing.Size(148, 47);
            this.btnOrcamento.TabIndex = 201;
            this.btnOrcamento.Text = "Orçamento";
            this.btnOrcamento.UseVisualStyleBackColor = false;
            this.btnOrcamento.Click += new System.EventHandler(this.BtnOrcamento_Click);
            // 
            // Vincular_OrcamentoCarroMecanico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnOrcamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVincularMecanicos);
            this.Controls.Add(this.btnPecas);
            this.Controls.Add(this.btnMecanicos);
            this.Controls.Add(this.btnVeiculos);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnVincular);
            this.Controls.Add(this.dgvVincularVeiculo);
            this.Name = "Vincular_OrcamentoCarroMecanico";
            this.Text = "Vincular_OrcamentoCarroMecanico";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVincularVeiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVincularMecanicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPecas;
        private System.Windows.Forms.Button btnMecanicos;
        private System.Windows.Forms.Button btnVeiculos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnVincular;
        private System.Windows.Forms.DataGridView dgvVincularVeiculo;
        private System.Windows.Forms.DataGridView dgvVincularMecanicos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOrcamento;
    }
}