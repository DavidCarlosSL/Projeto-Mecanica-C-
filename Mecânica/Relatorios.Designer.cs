namespace Mecânica
{
    partial class Relatorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatorios));
            this.btnGerarRelatorio1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mskDataInicialFaturamento = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskDataFinalFaturamento = new System.Windows.Forms.MaskedTextBox();
            this.btnOrcamentos = new System.Windows.Forms.Button();
            this.btnPecas = new System.Windows.Forms.Button();
            this.btnMecanicos = new System.Windows.Forms.Button();
            this.btnVeiculos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblAvisoDataInicialFaturamento = new System.Windows.Forms.Label();
            this.lblAvisoDataFinalFaturamento = new System.Windows.Forms.Label();
            this.lblAvisoDataFinalOrcamento = new System.Windows.Forms.Label();
            this.lblAvisoDataInicialOrcamento = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mskDataFinalOrcamento = new System.Windows.Forms.MaskedTextBox();
            this.label234 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.mskDataInicialOrcamento = new System.Windows.Forms.MaskedTextBox();
            this.btnGerarRelatorio2 = new System.Windows.Forms.Button();
            this.tmVerificaAvisos = new System.Windows.Forms.Timer(this.components);
            this.lblAvisoMes = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnGerarRelatorio3 = new System.Windows.Forms.Button();
            this.lblAvisoAno = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGerarRelatorio1
            // 
            this.btnGerarRelatorio1.Enabled = false;
            this.btnGerarRelatorio1.Location = new System.Drawing.Point(173, 404);
            this.btnGerarRelatorio1.Name = "btnGerarRelatorio1";
            this.btnGerarRelatorio1.Size = new System.Drawing.Size(179, 45);
            this.btnGerarRelatorio1.TabIndex = 2;
            this.btnGerarRelatorio1.Text = "Gerar Relatório";
            this.btnGerarRelatorio1.UseVisualStyleBackColor = true;
            this.btnGerarRelatorio1.Click += new System.EventHandler(this.BtnGerarRelatorio1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(169, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Relatório de Faturamento";
            // 
            // mskDataInicialFaturamento
            // 
            this.mskDataInicialFaturamento.Location = new System.Drawing.Point(237, 145);
            this.mskDataInicialFaturamento.Mask = "00/00/0000";
            this.mskDataInicialFaturamento.Name = "mskDataInicialFaturamento";
            this.mskDataInicialFaturamento.Size = new System.Drawing.Size(100, 20);
            this.mskDataInicialFaturamento.TabIndex = 4;
            this.mskDataInicialFaturamento.ValidatingType = typeof(System.DateTime);
            this.mskDataInicialFaturamento.TextChanged += new System.EventHandler(this.MskDataInicialFaturamento_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(176, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data Inicial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(176, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data Final";
            // 
            // mskDataFinalFaturamento
            // 
            this.mskDataFinalFaturamento.Location = new System.Drawing.Point(237, 233);
            this.mskDataFinalFaturamento.Mask = "00/00/0000";
            this.mskDataFinalFaturamento.Name = "mskDataFinalFaturamento";
            this.mskDataFinalFaturamento.Size = new System.Drawing.Size(100, 20);
            this.mskDataFinalFaturamento.TabIndex = 20;
            this.mskDataFinalFaturamento.ValidatingType = typeof(System.DateTime);
            this.mskDataFinalFaturamento.TextChanged += new System.EventHandler(this.MskDataFinalFaturamento_TextChanged);
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
            this.btnOrcamentos.TabIndex = 231;
            this.btnOrcamentos.Text = "Orçamentos";
            this.btnOrcamentos.UseVisualStyleBackColor = false;
            this.btnOrcamentos.Click += new System.EventHandler(this.BtnOrcamento_Click);
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
            this.btnPecas.TabIndex = 230;
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
            this.btnMecanicos.TabIndex = 229;
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
            this.btnVeiculos.Location = new System.Drawing.Point(0, 180);
            this.btnVeiculos.Name = "btnVeiculos";
            this.btnVeiculos.Size = new System.Drawing.Size(148, 47);
            this.btnVeiculos.TabIndex = 227;
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
            this.btnClientes.TabIndex = 226;
            this.btnClientes.Text = "  Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
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
            this.btnRelatorios.TabIndex = 232;
            this.btnRelatorios.Text = "Relatórios";
            this.btnRelatorios.UseVisualStyleBackColor = false;
            this.btnRelatorios.Click += new System.EventHandler(this.BtnRelatorios_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.ForeColor = System.Drawing.Color.Gray;
            this.label15.Location = new System.Drawing.Point(241, 168);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 13);
            this.label15.TabIndex = 233;
            this.label15.Text = "*Campo obrigatório";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(241, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 234;
            this.label10.Text = "*Campo obrigatório";
            // 
            // lblAvisoDataInicialFaturamento
            // 
            this.lblAvisoDataInicialFaturamento.AutoSize = true;
            this.lblAvisoDataInicialFaturamento.BackColor = System.Drawing.Color.White;
            this.lblAvisoDataInicialFaturamento.ForeColor = System.Drawing.Color.Maroon;
            this.lblAvisoDataInicialFaturamento.Location = new System.Drawing.Point(264, 129);
            this.lblAvisoDataInicialFaturamento.Name = "lblAvisoDataInicialFaturamento";
            this.lblAvisoDataInicialFaturamento.Size = new System.Drawing.Size(73, 13);
            this.lblAvisoDataInicialFaturamento.TabIndex = 235;
            this.lblAvisoDataInicialFaturamento.Text = "*Data inválida";
            this.lblAvisoDataInicialFaturamento.Visible = false;
            // 
            // lblAvisoDataFinalFaturamento
            // 
            this.lblAvisoDataFinalFaturamento.AutoSize = true;
            this.lblAvisoDataFinalFaturamento.BackColor = System.Drawing.Color.White;
            this.lblAvisoDataFinalFaturamento.ForeColor = System.Drawing.Color.Maroon;
            this.lblAvisoDataFinalFaturamento.Location = new System.Drawing.Point(264, 217);
            this.lblAvisoDataFinalFaturamento.Name = "lblAvisoDataFinalFaturamento";
            this.lblAvisoDataFinalFaturamento.Size = new System.Drawing.Size(73, 13);
            this.lblAvisoDataFinalFaturamento.TabIndex = 236;
            this.lblAvisoDataFinalFaturamento.Text = "*Data inválida";
            this.lblAvisoDataFinalFaturamento.Visible = false;
            // 
            // lblAvisoDataFinalOrcamento
            // 
            this.lblAvisoDataFinalOrcamento.AutoSize = true;
            this.lblAvisoDataFinalOrcamento.BackColor = System.Drawing.Color.White;
            this.lblAvisoDataFinalOrcamento.ForeColor = System.Drawing.Color.Maroon;
            this.lblAvisoDataFinalOrcamento.Location = new System.Drawing.Point(483, 214);
            this.lblAvisoDataFinalOrcamento.Name = "lblAvisoDataFinalOrcamento";
            this.lblAvisoDataFinalOrcamento.Size = new System.Drawing.Size(73, 13);
            this.lblAvisoDataFinalOrcamento.TabIndex = 246;
            this.lblAvisoDataFinalOrcamento.Text = "*Data inválida";
            this.lblAvisoDataFinalOrcamento.Visible = false;
            // 
            // lblAvisoDataInicialOrcamento
            // 
            this.lblAvisoDataInicialOrcamento.AutoSize = true;
            this.lblAvisoDataInicialOrcamento.BackColor = System.Drawing.Color.White;
            this.lblAvisoDataInicialOrcamento.ForeColor = System.Drawing.Color.Maroon;
            this.lblAvisoDataInicialOrcamento.Location = new System.Drawing.Point(483, 129);
            this.lblAvisoDataInicialOrcamento.Name = "lblAvisoDataInicialOrcamento";
            this.lblAvisoDataInicialOrcamento.Size = new System.Drawing.Size(73, 13);
            this.lblAvisoDataInicialOrcamento.TabIndex = 245;
            this.lblAvisoDataInicialOrcamento.Text = "*Data inválida";
            this.lblAvisoDataInicialOrcamento.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(460, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 244;
            this.label7.Text = "*Campo obrigatório";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(460, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 243;
            this.label8.Text = "*Campo obrigatório";
            // 
            // mskDataFinalOrcamento
            // 
            this.mskDataFinalOrcamento.Location = new System.Drawing.Point(456, 230);
            this.mskDataFinalOrcamento.Mask = "00/00/0000";
            this.mskDataFinalOrcamento.Name = "mskDataFinalOrcamento";
            this.mskDataFinalOrcamento.Size = new System.Drawing.Size(100, 20);
            this.mskDataFinalOrcamento.TabIndex = 242;
            this.mskDataFinalOrcamento.ValidatingType = typeof(System.DateTime);
            this.mskDataFinalOrcamento.TextChanged += new System.EventHandler(this.MskDataFinalOrcamento_TextChanged);
            // 
            // label234
            // 
            this.label234.AutoSize = true;
            this.label234.BackColor = System.Drawing.Color.White;
            this.label234.ForeColor = System.Drawing.Color.Black;
            this.label234.Location = new System.Drawing.Point(395, 233);
            this.label234.Name = "label234";
            this.label234.Size = new System.Drawing.Size(55, 13);
            this.label234.TabIndex = 241;
            this.label234.Text = "Data Final";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(395, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 240;
            this.label11.Text = "Data Inicial";
            // 
            // mskDataInicialOrcamento
            // 
            this.mskDataInicialOrcamento.Location = new System.Drawing.Point(456, 145);
            this.mskDataInicialOrcamento.Mask = "00/00/0000";
            this.mskDataInicialOrcamento.Name = "mskDataInicialOrcamento";
            this.mskDataInicialOrcamento.Size = new System.Drawing.Size(100, 20);
            this.mskDataInicialOrcamento.TabIndex = 239;
            this.mskDataInicialOrcamento.ValidatingType = typeof(System.DateTime);
            this.mskDataInicialOrcamento.TextChanged += new System.EventHandler(this.MskDataInicialOrcamento_TextChanged);
            // 
            // btnGerarRelatorio2
            // 
            this.btnGerarRelatorio2.Enabled = false;
            this.btnGerarRelatorio2.Location = new System.Drawing.Point(391, 404);
            this.btnGerarRelatorio2.Name = "btnGerarRelatorio2";
            this.btnGerarRelatorio2.Size = new System.Drawing.Size(168, 45);
            this.btnGerarRelatorio2.TabIndex = 237;
            this.btnGerarRelatorio2.Text = "Gerar Relatório";
            this.btnGerarRelatorio2.UseVisualStyleBackColor = true;
            this.btnGerarRelatorio2.Click += new System.EventHandler(this.BtnGerarRelatorio2_Click);
            // 
            // tmVerificaAvisos
            // 
            this.tmVerificaAvisos.Enabled = true;
            this.tmVerificaAvisos.Interval = 70;
            this.tmVerificaAvisos.Tick += new System.EventHandler(this.TmVerificaAvisos_Tick);
            // 
            // lblAvisoMes
            // 
            this.lblAvisoMes.AutoSize = true;
            this.lblAvisoMes.BackColor = System.Drawing.Color.White;
            this.lblAvisoMes.ForeColor = System.Drawing.Color.Maroon;
            this.lblAvisoMes.Location = new System.Drawing.Point(631, 129);
            this.lblAvisoMes.Name = "lblAvisoMes";
            this.lblAvisoMes.Size = new System.Drawing.Size(147, 13);
            this.lblAvisoMes.TabIndex = 255;
            this.lblAvisoMes.Text = "* É permitido apenas numeros";
            this.lblAvisoMes.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(638, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 254;
            this.label6.Text = "*Campo obrigatório";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(638, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 253;
            this.label9.Text = "*Campo obrigatório";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(601, 233);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 251;
            this.label13.Text = "Ano";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(601, 148);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 250;
            this.label14.Text = "Mês";
            // 
            // btnGerarRelatorio3
            // 
            this.btnGerarRelatorio3.Location = new System.Drawing.Point(598, 404);
            this.btnGerarRelatorio3.Name = "btnGerarRelatorio3";
            this.btnGerarRelatorio3.Size = new System.Drawing.Size(165, 45);
            this.btnGerarRelatorio3.TabIndex = 247;
            this.btnGerarRelatorio3.Text = "Gerar Relatório";
            this.btnGerarRelatorio3.UseVisualStyleBackColor = true;
            this.btnGerarRelatorio3.Click += new System.EventHandler(this.BtnGerarRelatorio3_Click);
            // 
            // lblAvisoAno
            // 
            this.lblAvisoAno.AutoSize = true;
            this.lblAvisoAno.BackColor = System.Drawing.Color.White;
            this.lblAvisoAno.ForeColor = System.Drawing.Color.Maroon;
            this.lblAvisoAno.Location = new System.Drawing.Point(631, 214);
            this.lblAvisoAno.Name = "lblAvisoAno";
            this.lblAvisoAno.Size = new System.Drawing.Size(147, 13);
            this.lblAvisoAno.TabIndex = 256;
            this.lblAvisoAno.Text = "* É permitido apenas numeros";
            this.lblAvisoAno.Visible = false;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(634, 145);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(100, 20);
            this.txtMes.TabIndex = 257;
            this.txtMes.TextChanged += new System.EventHandler(this.TxtMes_TextChanged);
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(634, 230);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(100, 20);
            this.txtAno.TabIndex = 258;
            this.txtAno.TextChanged += new System.EventHandler(this.TxtAno_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(370, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 800);
            this.panel1.TabIndex = 259;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(387, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 21);
            this.label4.TabIndex = 260;
            this.label4.Text = "Relatório de Orçamento";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 800);
            this.panel2.TabIndex = 260;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(573, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 800);
            this.panel3.TabIndex = 261;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(600, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 21);
            this.label5.TabIndex = 262;
            this.label5.Text = "Relatório de Mecânico";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label12.Location = new System.Drawing.Point(193, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 13);
            this.label12.TabIndex = 200;
            this.label12.Text = "Mostra o faturamento em um ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label16.Location = new System.Drawing.Point(216, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 13);
            this.label16.TabIndex = 263;
            this.label16.Text = "intervalo de datas";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label17.Location = new System.Drawing.Point(410, 43);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(125, 13);
            this.label17.TabIndex = 265;
            this.label17.Text = "em um intervalo de datas";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label18.Location = new System.Drawing.Point(388, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(177, 13);
            this.label18.TabIndex = 264;
            this.label18.Text = "Mostra a quantidade de orçamentos";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label19.Location = new System.Drawing.Point(617, 43);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(125, 13);
            this.label19.TabIndex = 267;
            this.label19.Text = "em um intervalo de datas";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label20.Location = new System.Drawing.Point(595, 30);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(179, 13);
            this.label20.TabIndex = 266;
            this.label20.Text = "Mostra a mão de obra de mecânicos";
            // 
            // Relatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mecânica.Properties.Resources.backgroundreal;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.lblAvisoAno);
            this.Controls.Add(this.lblAvisoMes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnGerarRelatorio3);
            this.Controls.Add(this.lblAvisoDataFinalOrcamento);
            this.Controls.Add(this.lblAvisoDataInicialOrcamento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mskDataFinalOrcamento);
            this.Controls.Add(this.label234);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.mskDataInicialOrcamento);
            this.Controls.Add(this.btnGerarRelatorio2);
            this.Controls.Add(this.lblAvisoDataFinalFaturamento);
            this.Controls.Add(this.lblAvisoDataInicialFaturamento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnRelatorios);
            this.Controls.Add(this.btnOrcamentos);
            this.Controls.Add(this.btnPecas);
            this.Controls.Add(this.btnMecanicos);
            this.Controls.Add(this.btnVeiculos);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.mskDataFinalFaturamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mskDataInicialFaturamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGerarRelatorio1);
            this.Name = "Relatorios";
            this.Text = "Relatórios";
            this.Load += new System.EventHandler(this.Relatorios_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerarRelatorio1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskDataInicialFaturamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskDataFinalFaturamento;
        private System.Windows.Forms.Button btnOrcamentos;
        private System.Windows.Forms.Button btnPecas;
        private System.Windows.Forms.Button btnMecanicos;
        private System.Windows.Forms.Button btnVeiculos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAvisoDataInicialFaturamento;
        private System.Windows.Forms.Label lblAvisoDataFinalFaturamento;
        private System.Windows.Forms.Label lblAvisoDataFinalOrcamento;
        private System.Windows.Forms.Label lblAvisoDataInicialOrcamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskDataFinalOrcamento;
        private System.Windows.Forms.Label label234;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mskDataInicialOrcamento;
        private System.Windows.Forms.Button btnGerarRelatorio2;
        private System.Windows.Forms.Timer tmVerificaAvisos;
        private System.Windows.Forms.Label lblAvisoMes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnGerarRelatorio3;
        private System.Windows.Forms.Label lblAvisoAno;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}