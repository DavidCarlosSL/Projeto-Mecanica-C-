namespace Mecânica
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnOrçamentos = new System.Windows.Forms.Button();
            this.btnPeças = new System.Windows.Forms.Button();
            this.btnMecanicos = new System.Windows.Forms.Button();
            this.btnVeiculos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrçamentos
            // 
            this.btnOrçamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnOrçamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrçamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrçamentos.Image = ((System.Drawing.Image)(resources.GetObject("btnOrçamentos.Image")));
            this.btnOrçamentos.Location = new System.Drawing.Point(486, 233);
            this.btnOrçamentos.Name = "btnOrçamentos";
            this.btnOrçamentos.Size = new System.Drawing.Size(110, 110);
            this.btnOrçamentos.TabIndex = 153;
            this.btnOrçamentos.UseVisualStyleBackColor = false;
            this.btnOrçamentos.Click += new System.EventHandler(this.BtnOrçamentos_Click);
            // 
            // btnPeças
            // 
            this.btnPeças.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnPeças.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPeças.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeças.Image = ((System.Drawing.Image)(resources.GetObject("btnPeças.Image")));
            this.btnPeças.Location = new System.Drawing.Point(341, 233);
            this.btnPeças.Name = "btnPeças";
            this.btnPeças.Size = new System.Drawing.Size(110, 110);
            this.btnPeças.TabIndex = 152;
            this.btnPeças.UseVisualStyleBackColor = false;
            this.btnPeças.Click += new System.EventHandler(this.BtnPeças_Click);
            // 
            // btnMecanicos
            // 
            this.btnMecanicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnMecanicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMecanicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMecanicos.Image = ((System.Drawing.Image)(resources.GetObject("btnMecanicos.Image")));
            this.btnMecanicos.Location = new System.Drawing.Point(189, 233);
            this.btnMecanicos.Name = "btnMecanicos";
            this.btnMecanicos.Size = new System.Drawing.Size(110, 110);
            this.btnMecanicos.TabIndex = 151;
            this.btnMecanicos.UseVisualStyleBackColor = false;
            this.btnMecanicos.Click += new System.EventHandler(this.BtnMecanicos_Click);
            // 
            // btnVeiculos
            // 
            this.btnVeiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnVeiculos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVeiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVeiculos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnVeiculos.Image = ((System.Drawing.Image)(resources.GetObject("btnVeiculos.Image")));
            this.btnVeiculos.Location = new System.Drawing.Point(403, 117);
            this.btnVeiculos.Name = "btnVeiculos";
            this.btnVeiculos.Size = new System.Drawing.Size(110, 110);
            this.btnVeiculos.TabIndex = 150;
            this.btnVeiculos.UseVisualStyleBackColor = false;
            this.btnVeiculos.Click += new System.EventHandler(this.BtnVeiculos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.Location = new System.Drawing.Point(268, 117);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(110, 110);
            this.btnClientes.TabIndex = 149;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnOrçamentos);
            this.Controls.Add(this.btnPeças);
            this.Controls.Add(this.btnMecanicos);
            this.Controls.Add(this.btnVeiculos);
            this.Controls.Add(this.btnClientes);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrçamentos;
        private System.Windows.Forms.Button btnPeças;
        private System.Windows.Forms.Button btnMecanicos;
        private System.Windows.Forms.Button btnVeiculos;
        private System.Windows.Forms.Button btnClientes;
    }
}