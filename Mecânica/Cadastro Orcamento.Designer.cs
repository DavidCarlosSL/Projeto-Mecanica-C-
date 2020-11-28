namespace Mecânica
{
    partial class Cadastro_Orcamento
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_Orcamento));
            this.btnPecas = new System.Windows.Forms.Button();
            this.btnMecanicos = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtValorPecas = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVeiculos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.txtMaoDeObra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdicionarPeca = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.mskDataCadastro = new System.Windows.Forms.MaskedTextBox();
            this.lblAvisoMaoDeObra = new System.Windows.Forms.Label();
            this.lblAvisoData = new System.Windows.Forms.Label();
            this.tmVerificaAvisos = new System.Windows.Forms.Timer(this.components);
            this.btnOrcamentos = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
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
            this.btnPecas.Location = new System.Drawing.Point(-1, 288);
            this.btnPecas.Name = "btnPecas";
            this.btnPecas.Size = new System.Drawing.Size(148, 47);
            this.btnPecas.TabIndex = 191;
            this.btnPecas.Text = "Peças";
            this.btnPecas.UseVisualStyleBackColor = false;
            this.btnPecas.Click += new System.EventHandler(this.BtnPecas_Click);
            // 
            // btnMecanicos
            // 
            this.btnMecanicos.BackColor = System.Drawing.Color.Transparent;
            this.btnMecanicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMecanicos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMecanicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMecanicos.ForeColor = System.Drawing.Color.White;
            this.btnMecanicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMecanicos.Location = new System.Drawing.Point(-1, 235);
            this.btnMecanicos.Name = "btnMecanicos";
            this.btnMecanicos.Size = new System.Drawing.Size(148, 47);
            this.btnMecanicos.TabIndex = 190;
            this.btnMecanicos.Text = "Mecânicos";
            this.btnMecanicos.UseVisualStyleBackColor = false;
            this.btnMecanicos.Click += new System.EventHandler(this.BtnVeiculos_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(352, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 13);
            this.label14.TabIndex = 188;
            this.label14.Text = "*Campo obrigatório";
            // 
            // txtValorPecas
            // 
            this.txtValorPecas.Enabled = false;
            this.txtValorPecas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPecas.Location = new System.Drawing.Point(481, 43);
            this.txtValorPecas.MaxLength = 8;
            this.txtValorPecas.Name = "txtValorPecas";
            this.txtValorPecas.Size = new System.Drawing.Size(268, 24);
            this.txtValorPecas.TabIndex = 186;
            this.txtValorPecas.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(479, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 16);
            this.label12.TabIndex = 185;
            this.label12.Text = "Valor das Peças (R$):";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.ForeColor = System.Drawing.Color.Transparent;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(442, 408);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(162, 49);
            this.btnLimpar.TabIndex = 183;
            this.btnLimpar.Text = "\r\n";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnVeiculos
            // 
            this.btnVeiculos.BackColor = System.Drawing.Color.Transparent;
            this.btnVeiculos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeiculos.ForeColor = System.Drawing.Color.Transparent;
            this.btnVeiculos.Image = ((System.Drawing.Image)(resources.GetObject("btnVeiculos.Image")));
            this.btnVeiculos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVeiculos.Location = new System.Drawing.Point(-1, 182);
            this.btnVeiculos.Name = "btnVeiculos";
            this.btnVeiculos.Size = new System.Drawing.Size(148, 47);
            this.btnVeiculos.TabIndex = 182;
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
            this.btnClientes.Location = new System.Drawing.Point(-1, 129);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(148, 47);
            this.btnClientes.TabIndex = 181;
            this.btnClientes.Text = "  Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // txtMaoDeObra
            // 
            this.txtMaoDeObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaoDeObra.Location = new System.Drawing.Point(179, 43);
            this.txtMaoDeObra.MaxLength = 60;
            this.txtMaoDeObra.Name = "txtMaoDeObra";
            this.txtMaoDeObra.Size = new System.Drawing.Size(269, 24);
            this.txtMaoDeObra.TabIndex = 180;
            this.txtMaoDeObra.Text = "0";
            this.txtMaoDeObra.TextChanged += new System.EventHandler(this.TxtMaoDeObra_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 178;
            this.label2.Text = "Mão de Obra (R$):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(352, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 195;
            this.label4.Text = "*Campo obrigatório";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(179, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 193;
            this.label5.Text = "Data:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(179, 196);
            this.txtDescricao.MaxLength = 60;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(569, 102);
            this.txtDescricao.TabIndex = 197;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(179, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 196;
            this.label7.Text = "Descrição:";
            // 
            // btnAdicionarPeca
            // 
            this.btnAdicionarPeca.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionarPeca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarPeca.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdicionarPeca.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarPeca.Image")));
            this.btnAdicionarPeca.Location = new System.Drawing.Point(590, 70);
            this.btnAdicionarPeca.Name = "btnAdicionarPeca";
            this.btnAdicionarPeca.Size = new System.Drawing.Size(162, 49);
            this.btnAdicionarPeca.TabIndex = 198;
            this.btnAdicionarPeca.Text = "\r\n";
            this.btnAdicionarPeca.UseVisualStyleBackColor = false;
            this.btnAdicionarPeca.Click += new System.EventHandler(this.BtnAdicionarPeca_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(610, 408);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(162, 49);
            this.btnCadastrar.TabIndex = 200;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // mskDataCadastro
            // 
            this.mskDataCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDataCadastro.Location = new System.Drawing.Point(179, 111);
            this.mskDataCadastro.Mask = "00/00/0000";
            this.mskDataCadastro.Name = "mskDataCadastro";
            this.mskDataCadastro.Size = new System.Drawing.Size(269, 22);
            this.mskDataCadastro.TabIndex = 201;
            this.mskDataCadastro.ValidatingType = typeof(System.DateTime);
            this.mskDataCadastro.TextChanged += new System.EventHandler(this.MskDataCadastro_TextChanged);
            // 
            // lblAvisoMaoDeObra
            // 
            this.lblAvisoMaoDeObra.AutoSize = true;
            this.lblAvisoMaoDeObra.BackColor = System.Drawing.Color.White;
            this.lblAvisoMaoDeObra.ForeColor = System.Drawing.Color.Maroon;
            this.lblAvisoMaoDeObra.Location = new System.Drawing.Point(303, 21);
            this.lblAvisoMaoDeObra.Name = "lblAvisoMaoDeObra";
            this.lblAvisoMaoDeObra.Size = new System.Drawing.Size(145, 13);
            this.lblAvisoMaoDeObra.TabIndex = 202;
            this.lblAvisoMaoDeObra.Text = "*É Permitido apenas números";
            this.lblAvisoMaoDeObra.Visible = false;
            // 
            // lblAvisoData
            // 
            this.lblAvisoData.AutoSize = true;
            this.lblAvisoData.BackColor = System.Drawing.Color.White;
            this.lblAvisoData.ForeColor = System.Drawing.Color.Maroon;
            this.lblAvisoData.Location = new System.Drawing.Point(375, 94);
            this.lblAvisoData.Name = "lblAvisoData";
            this.lblAvisoData.Size = new System.Drawing.Size(73, 13);
            this.lblAvisoData.TabIndex = 203;
            this.lblAvisoData.Text = "*Data inválida";
            this.lblAvisoData.Visible = false;
            // 
            // tmVerificaAvisos
            // 
            this.tmVerificaAvisos.Enabled = true;
            this.tmVerificaAvisos.Interval = 70;
            this.tmVerificaAvisos.Tick += new System.EventHandler(this.TmVerificaAvisos_Tick);
            // 
            // btnOrcamentos
            // 
            this.btnOrcamentos.BackColor = System.Drawing.Color.Transparent;
            this.btnOrcamentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOrcamentos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrcamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrcamentos.ForeColor = System.Drawing.Color.White;
            this.btnOrcamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrcamentos.Location = new System.Drawing.Point(-1, 341);
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
            this.btnRelatorios.Location = new System.Drawing.Point(-1, 394);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(148, 47);
            this.btnRelatorios.TabIndex = 233;
            this.btnRelatorios.Text = "Relatórios";
            this.btnRelatorios.UseVisualStyleBackColor = false;
            this.btnRelatorios.Click += new System.EventHandler(this.BtnRelatorios_Click);
            // 
            // Cadastro_Orcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnRelatorios);
            this.Controls.Add(this.btnOrcamentos);
            this.Controls.Add(this.lblAvisoData);
            this.Controls.Add(this.lblAvisoMaoDeObra);
            this.Controls.Add(this.mskDataCadastro);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnAdicionarPeca);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPecas);
            this.Controls.Add(this.btnMecanicos);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtValorPecas);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVeiculos);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.txtMaoDeObra);
            this.Controls.Add(this.label2);
            this.Name = "Cadastro_Orcamento";
            this.Text = "Cadastro_Orcamento";
            this.Load += new System.EventHandler(this.Cadastro_Orcamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPecas;
        private System.Windows.Forms.Button btnMecanicos;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtValorPecas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVeiculos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.TextBox txtMaoDeObra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdicionarPeca;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.MaskedTextBox mskDataCadastro;
        private System.Windows.Forms.Label lblAvisoMaoDeObra;
        private System.Windows.Forms.Label lblAvisoData;
        private System.Windows.Forms.Timer tmVerificaAvisos;
        private System.Windows.Forms.Button btnOrcamentos;
        private System.Windows.Forms.Button btnRelatorios;
    }
}