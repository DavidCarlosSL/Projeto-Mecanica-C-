namespace Mecânica
{
    partial class Cliente_Vinculado
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
            this.dgvClienteVinculado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteVinculado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClienteVinculado
            // 
            this.dgvClienteVinculado.AllowUserToAddRows = false;
            this.dgvClienteVinculado.AllowUserToDeleteRows = false;
            this.dgvClienteVinculado.AllowUserToResizeColumns = false;
            this.dgvClienteVinculado.AllowUserToResizeRows = false;
            this.dgvClienteVinculado.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvClienteVinculado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvClienteVinculado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClienteVinculado.Location = new System.Drawing.Point(12, 12);
            this.dgvClienteVinculado.Name = "dgvClienteVinculado";
            this.dgvClienteVinculado.ReadOnly = true;
            this.dgvClienteVinculado.Size = new System.Drawing.Size(760, 82);
            this.dgvClienteVinculado.TabIndex = 29;
            // 
            // Cliente_Vinculado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 106);
            this.Controls.Add(this.dgvClienteVinculado);
            this.Name = "Cliente_Vinculado";
            this.Text = "Cliente_Vinculado";
            this.Load += new System.EventHandler(this.Cliente_Vinculado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteVinculado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClienteVinculado;
    }
}