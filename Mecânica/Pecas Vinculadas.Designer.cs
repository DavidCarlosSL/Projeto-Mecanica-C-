namespace Mecânica
{
    partial class Pecas_Vinculadas
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
            this.dgvVeiculosVinculados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculosVinculados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVeiculosVinculados
            // 
            this.dgvVeiculosVinculados.AllowUserToAddRows = false;
            this.dgvVeiculosVinculados.AllowUserToDeleteRows = false;
            this.dgvVeiculosVinculados.AllowUserToResizeColumns = false;
            this.dgvVeiculosVinculados.AllowUserToResizeRows = false;
            this.dgvVeiculosVinculados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvVeiculosVinculados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvVeiculosVinculados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeiculosVinculados.Location = new System.Drawing.Point(12, 12);
            this.dgvVeiculosVinculados.Name = "dgvVeiculosVinculados";
            this.dgvVeiculosVinculados.ReadOnly = true;
            this.dgvVeiculosVinculados.Size = new System.Drawing.Size(760, 337);
            this.dgvVeiculosVinculados.TabIndex = 42;
            // 
            // Pecas_Vinculadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.dgvVeiculosVinculados);
            this.Name = "Pecas_Vinculadas";
            this.Text = "Pecas_Vinculadas";
            this.Load += new System.EventHandler(this.Pecas_Vinculadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculosVinculados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVeiculosVinculados;
    }
}