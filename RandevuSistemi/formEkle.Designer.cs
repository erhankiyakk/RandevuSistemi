namespace RandevuSistemi
{
    partial class formEkle
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
            this.mTxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.lblIsim = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mTxtTelefon
            // 
            this.mTxtTelefon.Location = new System.Drawing.Point(133, 93);
            this.mTxtTelefon.Mask = "(999) 000-0000";
            this.mTxtTelefon.Name = "mTxtTelefon";
            this.mTxtTelefon.Size = new System.Drawing.Size(114, 22);
            this.mTxtTelefon.TabIndex = 1;
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(133, 52);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(114, 22);
            this.txtIsim.TabIndex = 2;
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Location = new System.Drawing.Point(25, 55);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(32, 17);
            this.lblIsim.TabIndex = 3;
            this.lblIsim.Text = "İsim";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(28, 153);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(45, 17);
            this.lblAdres.TabIndex = 4;
            this.lblAdres.Text = "Adres";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 153);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 83);
            this.textBox1.TabIndex = 5;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(31, 271);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(216, 38);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(25, 93);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(56, 17);
            this.lblTelefon.TabIndex = 10;
            this.lblTelefon.Text = "Telefon";
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(133, 8);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(114, 24);
            this.cmbKategori.TabIndex = 11;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(28, 14);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(61, 17);
            this.lblKategori.TabIndex = 12;
            this.lblKategori.Text = "Kategori";
            // 
            // formEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 612);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblIsim);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.mTxtTelefon);
            this.Name = "formEkle";
            this.Text = "Ekle";
            this.Load += new System.EventHandler(this.formEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox mTxtTelefon;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label lblKategori;
    }
}