namespace RandevuSistemi
{
    partial class frmFirmaListesiRapor
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
            this.dgvIsYeriListe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsYeriListe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIsYeriListe
            // 
            this.dgvIsYeriListe.AllowUserToAddRows = false;
            this.dgvIsYeriListe.AllowUserToDeleteRows = false;
            this.dgvIsYeriListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIsYeriListe.Location = new System.Drawing.Point(21, 12);
            this.dgvIsYeriListe.Name = "dgvIsYeriListe";
            this.dgvIsYeriListe.ReadOnly = true;
            this.dgvIsYeriListe.RowTemplate.Height = 24;
            this.dgvIsYeriListe.Size = new System.Drawing.Size(240, 323);
            this.dgvIsYeriListe.TabIndex = 0;
            // 
            // frmFirmaListesiRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 362);
            this.Controls.Add(this.dgvIsYeriListe);
            this.Name = "frmFirmaListesiRapor";
            this.Text = "frmFirmaListesiRapor";
            this.Load += new System.EventHandler(this.frmFirmaListesiRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsYeriListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIsYeriListe;
    }
}