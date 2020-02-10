namespace RandevuSistemi
{
    partial class frmIslemler
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
            this.btnSil = new System.Windows.Forms.Button();
            this.mtxtTel = new System.Windows.Forms.MaskedTextBox();
            this.btnIsYeriEkle = new System.Windows.Forms.Button();
            this.lblTelefonNo = new System.Windows.Forms.Label();
            this.lblIsYeriAdres = new System.Windows.Forms.Label();
            this.txtIsYeriAdres = new System.Windows.Forms.TextBox();
            this.lblIsYeriAdi = new System.Windows.Forms.Label();
            this.txtIsYeriAdi = new System.Windows.Forms.TextBox();
            this.dgvIsYeri = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.lblArama = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsYeri)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(453, 127);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(182, 57);
            this.btnSil.TabIndex = 24;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // mtxtTel
            // 
            this.mtxtTel.Location = new System.Drawing.Point(141, 237);
            this.mtxtTel.Mask = "0000000000";
            this.mtxtTel.Name = "mtxtTel";
            this.mtxtTel.Size = new System.Drawing.Size(185, 22);
            this.mtxtTel.TabIndex = 23;
            // 
            // btnIsYeriEkle
            // 
            this.btnIsYeriEkle.Location = new System.Drawing.Point(453, 54);
            this.btnIsYeriEkle.Name = "btnIsYeriEkle";
            this.btnIsYeriEkle.Size = new System.Drawing.Size(182, 50);
            this.btnIsYeriEkle.TabIndex = 22;
            this.btnIsYeriEkle.Text = "Ekle";
            this.btnIsYeriEkle.UseVisualStyleBackColor = true;
            this.btnIsYeriEkle.Click += new System.EventHandler(this.btnIsYeriEkle_Click);
            // 
            // lblTelefonNo
            // 
            this.lblTelefonNo.AutoSize = true;
            this.lblTelefonNo.Location = new System.Drawing.Point(88, 242);
            this.lblTelefonNo.Name = "lblTelefonNo";
            this.lblTelefonNo.Size = new System.Drawing.Size(28, 17);
            this.lblTelefonNo.TabIndex = 21;
            this.lblTelefonNo.Text = "Tel";
            // 
            // lblIsYeriAdres
            // 
            this.lblIsYeriAdres.AutoSize = true;
            this.lblIsYeriAdres.Location = new System.Drawing.Point(71, 149);
            this.lblIsYeriAdres.Name = "lblIsYeriAdres";
            this.lblIsYeriAdres.Size = new System.Drawing.Size(45, 17);
            this.lblIsYeriAdres.TabIndex = 20;
            this.lblIsYeriAdres.Text = "Adres";
            // 
            // txtIsYeriAdres
            // 
            this.txtIsYeriAdres.Location = new System.Drawing.Point(141, 149);
            this.txtIsYeriAdres.Multiline = true;
            this.txtIsYeriAdres.Name = "txtIsYeriAdres";
            this.txtIsYeriAdres.Size = new System.Drawing.Size(185, 58);
            this.txtIsYeriAdres.TabIndex = 19;
            // 
            // lblIsYeriAdi
            // 
            this.lblIsYeriAdi.AutoSize = true;
            this.lblIsYeriAdi.Location = new System.Drawing.Point(88, 112);
            this.lblIsYeriAdi.Name = "lblIsYeriAdi";
            this.lblIsYeriAdi.Size = new System.Drawing.Size(25, 17);
            this.lblIsYeriAdi.TabIndex = 18;
            this.lblIsYeriAdi.Text = "Ad";
            // 
            // txtIsYeriAdi
            // 
            this.txtIsYeriAdi.BackColor = System.Drawing.SystemColors.Window;
            this.txtIsYeriAdi.Location = new System.Drawing.Point(141, 107);
            this.txtIsYeriAdi.Name = "txtIsYeriAdi";
            this.txtIsYeriAdi.Size = new System.Drawing.Size(185, 22);
            this.txtIsYeriAdi.TabIndex = 17;
            // 
            // dgvIsYeri
            // 
            this.dgvIsYeri.AllowUserToAddRows = false;
            this.dgvIsYeri.AllowUserToDeleteRows = false;
            this.dgvIsYeri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIsYeri.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvIsYeri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIsYeri.Location = new System.Drawing.Point(91, 335);
            this.dgvIsYeri.Name = "dgvIsYeri";
            this.dgvIsYeri.ReadOnly = true;
            this.dgvIsYeri.RowTemplate.Height = 24;
            this.dgvIsYeri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIsYeri.Size = new System.Drawing.Size(949, 164);
            this.dgvIsYeri.TabIndex = 14;
            this.dgvIsYeri.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIsYeri_CellEnter);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(141, 68);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(185, 22);
            this.txtID.TabIndex = 25;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(95, 71);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 26;
            this.lblID.Text = "ID";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(453, 220);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(182, 57);
            this.btnGuncelle.TabIndex = 27;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // lblArama
            // 
            this.lblArama.AutoSize = true;
            this.lblArama.Location = new System.Drawing.Point(718, 68);
            this.lblArama.Name = "lblArama";
            this.lblArama.Size = new System.Drawing.Size(49, 17);
            this.lblArama.TabIndex = 29;
            this.lblArama.Text = "Arama";
            // 
            // txtArama
            // 
            this.txtArama.BackColor = System.Drawing.SystemColors.Window;
            this.txtArama.Location = new System.Drawing.Point(773, 63);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(185, 22);
            this.txtArama.TabIndex = 28;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // frmIslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 540);
            this.Controls.Add(this.lblArama);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.mtxtTel);
            this.Controls.Add(this.btnIsYeriEkle);
            this.Controls.Add(this.lblTelefonNo);
            this.Controls.Add(this.lblIsYeriAdres);
            this.Controls.Add(this.txtIsYeriAdres);
            this.Controls.Add(this.lblIsYeriAdi);
            this.Controls.Add(this.txtIsYeriAdi);
            this.Controls.Add(this.dgvIsYeri);
            this.Name = "frmIslemler";
            this.Text = "frmIslemler";
            this.Load += new System.EventHandler(this.frmIslemler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsYeri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.MaskedTextBox mtxtTel;
        private System.Windows.Forms.Button btnIsYeriEkle;
        private System.Windows.Forms.Label lblTelefonNo;
        private System.Windows.Forms.Label lblIsYeriAdres;
        private System.Windows.Forms.TextBox txtIsYeriAdres;
        private System.Windows.Forms.Label lblIsYeriAdi;
        private System.Windows.Forms.TextBox txtIsYeriAdi;
        private System.Windows.Forms.DataGridView dgvIsYeri;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label lblArama;
        private System.Windows.Forms.TextBox txtArama;
    }
}