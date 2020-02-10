namespace RandevuSistemi
{
    partial class frmKategoriTanimlama
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
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.txtIsYeri = new System.Windows.Forms.TextBox();
            this.dgvIsYeri = new System.Windows.Forms.DataGridView();
            this.btnOnayla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsYeri)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(34, 221);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(138, 24);
            this.cmbKategori.TabIndex = 0;
            this.cmbKategori.TextChanged += new System.EventHandler(this.cmbKategori_TextChanged);
            // 
            // txtIsYeri
            // 
            this.txtIsYeri.Location = new System.Drawing.Point(208, 221);
            this.txtIsYeri.Name = "txtIsYeri";
            this.txtIsYeri.Size = new System.Drawing.Size(317, 22);
            this.txtIsYeri.TabIndex = 1;
            // 
            // dgvIsYeri
            // 
            this.dgvIsYeri.AllowUserToAddRows = false;
            this.dgvIsYeri.AllowUserToDeleteRows = false;
            this.dgvIsYeri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIsYeri.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvIsYeri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIsYeri.Location = new System.Drawing.Point(34, 38);
            this.dgvIsYeri.Name = "dgvIsYeri";
            this.dgvIsYeri.ReadOnly = true;
            this.dgvIsYeri.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvIsYeri.RowTemplate.Height = 24;
            this.dgvIsYeri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIsYeri.Size = new System.Drawing.Size(610, 150);
            this.dgvIsYeri.TabIndex = 2;
            this.dgvIsYeri.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIsYeri_CellEnter);
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(546, 210);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(98, 35);
            this.btnOnayla.TabIndex = 3;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // frmKategoriTanimlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 297);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.dgvIsYeri);
            this.Controls.Add(this.txtIsYeri);
            this.Controls.Add(this.cmbKategori);
            this.Name = "frmKategoriTanimlama";
            this.Text = "frmKategoriTanimlama";
            this.Load += new System.EventHandler(this.frmKategoriTanimlama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsYeri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.TextBox txtIsYeri;
        private System.Windows.Forms.DataGridView dgvIsYeri;
        private System.Windows.Forms.Button btnOnayla;
    }
}