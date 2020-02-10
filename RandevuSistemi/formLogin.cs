using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RandevuSistemi
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        Admin admin = new Admin();
        frmAnaSayfa frmAnaSayfa = new frmAnaSayfa();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
            if (admin.KullaniciAdi==txtKullaniciAdi.Text & admin.Sifre == txtSifre.Text)
            {
                this.Hide();
                frmAnaSayfa = new frmAnaSayfa();
                frmAnaSayfa.FormClosing += frmAnasayfa_FormClosing;
                frmAnaSayfa.Show();

            }
            else
                {
                    MessageBox.Show("Hatalı Giriş Yaptınız");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        private void frmAnasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
        private void cboxSifreGöster_CheckedChanged(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = txtSifre.PasswordChar == '\0' ? '*' : '\0';
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
