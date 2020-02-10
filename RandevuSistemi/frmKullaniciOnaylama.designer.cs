namespace RandevuSistemi
{
    partial class frmKullaniciOnaylama
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
            this.dgvKullanici = new System.Windows.Forms.DataGridView();
            this.btnKullaniciOnayla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKullanici
            // 
            this.dgvKullanici.AllowUserToAddRows = false;
            this.dgvKullanici.AllowUserToDeleteRows = false;
            this.dgvKullanici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKullanici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullanici.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvKullanici.Location = new System.Drawing.Point(32, 52);
            this.dgvKullanici.Name = "dgvKullanici";
            this.dgvKullanici.ReadOnly = true;
            this.dgvKullanici.RowTemplate.Height = 24;
            this.dgvKullanici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKullanici.Size = new System.Drawing.Size(659, 283);
            this.dgvKullanici.TabIndex = 0;
            this.dgvKullanici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKullanici_CellContentClick);
            this.dgvKullanici.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKullanici_CellEnter);
            // 
            // btnKullaniciOnayla
            // 
            this.btnKullaniciOnayla.Location = new System.Drawing.Point(278, 360);
            this.btnKullaniciOnayla.Name = "btnKullaniciOnayla";
            this.btnKullaniciOnayla.Size = new System.Drawing.Size(177, 45);
            this.btnKullaniciOnayla.TabIndex = 1;
            this.btnKullaniciOnayla.Text = "Kullanıcıyı Onayla";
            this.btnKullaniciOnayla.UseVisualStyleBackColor = true;
            this.btnKullaniciOnayla.Click += new System.EventHandler(this.btnKullaniciOnayla_Click);
            // 
            // frmKullaniciOnaylama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 445);
            this.Controls.Add(this.btnKullaniciOnayla);
            this.Controls.Add(this.dgvKullanici);
            this.Name = "frmKullaniciOnaylama";
            this.Text = "KullaniciOnaylama";
            this.Load += new System.EventHandler(this.KullaniciOnaylama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKullanici;
        private System.Windows.Forms.Button btnKullaniciOnayla;
    }
}