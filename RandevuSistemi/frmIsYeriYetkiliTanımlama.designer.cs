namespace RandevuSistemi
{
    partial class frmIsYeriYetkiliTanımlama
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
            this.dgvIsYeri = new System.Windows.Forms.DataGridView();
            this.dgvIsYeriYetkili = new System.Windows.Forms.DataGridView();
            this.dgvIsYeriYetkiliTanımlama = new System.Windows.Forms.DataGridView();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.txtIsYeriYetkiliAdi = new System.Windows.Forms.TextBox();
            this.txtIsYeriAdi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsYeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsYeriYetkili)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsYeriYetkiliTanımlama)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIsYeri
            // 
            this.dgvIsYeri.AllowUserToAddRows = false;
            this.dgvIsYeri.AllowUserToDeleteRows = false;
            this.dgvIsYeri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIsYeri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIsYeri.Location = new System.Drawing.Point(12, 55);
            this.dgvIsYeri.Name = "dgvIsYeri";
            this.dgvIsYeri.ReadOnly = true;
            this.dgvIsYeri.RowTemplate.Height = 24;
            this.dgvIsYeri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIsYeri.Size = new System.Drawing.Size(419, 150);
            this.dgvIsYeri.TabIndex = 0;
            this.dgvIsYeri.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIsYeri2_CellEnter);
            // 
            // dgvIsYeriYetkili
            // 
            this.dgvIsYeriYetkili.AllowUserToAddRows = false;
            this.dgvIsYeriYetkili.AllowUserToDeleteRows = false;
            this.dgvIsYeriYetkili.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIsYeriYetkili.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIsYeriYetkili.Location = new System.Drawing.Point(464, 55);
            this.dgvIsYeriYetkili.Name = "dgvIsYeriYetkili";
            this.dgvIsYeriYetkili.ReadOnly = true;
            this.dgvIsYeriYetkili.RowTemplate.Height = 24;
            this.dgvIsYeriYetkili.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIsYeriYetkili.Size = new System.Drawing.Size(440, 150);
            this.dgvIsYeriYetkili.TabIndex = 1;
            this.dgvIsYeriYetkili.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIsYeriYetkili_CellEnter);
            // 
            // dgvIsYeriYetkiliTanımlama
            // 
            this.dgvIsYeriYetkiliTanımlama.AllowUserToAddRows = false;
            this.dgvIsYeriYetkiliTanımlama.AllowUserToDeleteRows = false;
            this.dgvIsYeriYetkiliTanımlama.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIsYeriYetkiliTanımlama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIsYeriYetkiliTanımlama.Location = new System.Drawing.Point(102, 341);
            this.dgvIsYeriYetkiliTanımlama.Name = "dgvIsYeriYetkiliTanımlama";
            this.dgvIsYeriYetkiliTanımlama.ReadOnly = true;
            this.dgvIsYeriYetkiliTanımlama.RowTemplate.Height = 24;
            this.dgvIsYeriYetkiliTanımlama.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIsYeriYetkiliTanımlama.Size = new System.Drawing.Size(671, 150);
            this.dgvIsYeriYetkiliTanımlama.TabIndex = 2;
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(400, 284);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(90, 33);
            this.btnOnayla.TabIndex = 3;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // txtIsYeriYetkiliAdi
            // 
            this.txtIsYeriYetkiliAdi.Location = new System.Drawing.Point(464, 242);
            this.txtIsYeriYetkiliAdi.Name = "txtIsYeriYetkiliAdi";
            this.txtIsYeriYetkiliAdi.Size = new System.Drawing.Size(440, 22);
            this.txtIsYeriYetkiliAdi.TabIndex = 4;
            this.txtIsYeriYetkiliAdi.TextChanged += new System.EventHandler(this.txtIsYeriYetkiliAdi_TextChanged);
            // 
            // txtIsYeriAdi
            // 
            this.txtIsYeriAdi.Location = new System.Drawing.Point(12, 242);
            this.txtIsYeriAdi.Name = "txtIsYeriAdi";
            this.txtIsYeriAdi.Size = new System.Drawing.Size(419, 22);
            this.txtIsYeriAdi.TabIndex = 5;
            // 
            // frmIsYeriYetkiliTanımlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 537);
            this.Controls.Add(this.txtIsYeriAdi);
            this.Controls.Add(this.txtIsYeriYetkiliAdi);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.dgvIsYeriYetkiliTanımlama);
            this.Controls.Add(this.dgvIsYeriYetkili);
            this.Controls.Add(this.dgvIsYeri);
            this.Name = "frmIsYeriYetkiliTanımlama";
            this.Text = "frmIsYeriYetkiliTanımlama";
            this.Load += new System.EventHandler(this.frmIsYeriYetkiliTanımlama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsYeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsYeriYetkili)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsYeriYetkiliTanımlama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIsYeri;
        private System.Windows.Forms.DataGridView dgvIsYeriYetkili;
        private System.Windows.Forms.DataGridView dgvIsYeriYetkiliTanımlama;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.TextBox txtIsYeriYetkiliAdi;
        private System.Windows.Forms.TextBox txtIsYeriAdi;
    }
}