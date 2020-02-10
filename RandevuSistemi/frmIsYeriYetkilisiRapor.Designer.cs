namespace RandevuSistemi
{
    partial class frmIsYeriYetkilisiRapor
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
            this.dgvİsYeriYetkilileri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvİsYeriYetkilileri)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvİsYeriYetkilileri
            // 
            this.dgvİsYeriYetkilileri.AllowUserToAddRows = false;
            this.dgvİsYeriYetkilileri.AllowUserToDeleteRows = false;
            this.dgvİsYeriYetkilileri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvİsYeriYetkilileri.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvİsYeriYetkilileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvİsYeriYetkilileri.Location = new System.Drawing.Point(22, 12);
            this.dgvİsYeriYetkilileri.Name = "dgvİsYeriYetkilileri";
            this.dgvİsYeriYetkilileri.ReadOnly = true;
            this.dgvİsYeriYetkilileri.RowTemplate.Height = 24;
            this.dgvİsYeriYetkilileri.Size = new System.Drawing.Size(240, 278);
            this.dgvİsYeriYetkilileri.TabIndex = 0;
            // 
            // frmIsYeriYetkilisiRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 315);
            this.Controls.Add(this.dgvİsYeriYetkilileri);
            this.Name = "frmIsYeriYetkilisiRapor";
            this.Text = "frmIsYeriYetkilisiRapor";
            this.Load += new System.EventHandler(this.frmIsYeriYetkilisiRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvİsYeriYetkilileri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvİsYeriYetkilileri;
    }
}