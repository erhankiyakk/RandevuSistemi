using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandevuSistemi
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }
        frmIslemler frmIslemleri;
        frmKategoriTanimlama frmKategoriTanimla;
        frmIsYeriYetkiliTanımlama frmIsYeriYetkiliTanımla;
        frmKullaniciOnaylama frmKullaniciOnayla;
        

        private void IsYeriIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmIslemleri == null)
            {
                frmIslemleri = new frmIslemler();
                frmIslemleri.MdiParent = this;
                frmIslemleri.FormClosed += new FormClosedEventHandler(frmKategoriTanimla_FormClosed);
                frmIslemleri.Show();
            }
            else 
            {
                frmIslemleri.Activate();
            }
        }
        void frmIslemleri_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmIslemleri = null;
        }

        private void kategoriBelirleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmKategoriTanimla== null)
            {
                frmKategoriTanimla = new frmKategoriTanimlama();
                frmKategoriTanimla.MdiParent = this;
                frmKategoriTanimla.FormClosed+= new FormClosedEventHandler(frmKategoriTanimla_FormClosed);
                frmKategoriTanimla.Show();
            }
            else 
            {
                frmKategoriTanimla.Activate();
            }
        }
        void frmKategoriTanimla_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmKategoriTanimla = null;
        }

        private void yetkiliTanımlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (frmIsYeriYetkiliTanımla == null)
            {
                frmIsYeriYetkiliTanımla = new frmIsYeriYetkiliTanımlama();
                frmIsYeriYetkiliTanımla.MdiParent = this;
                frmIsYeriYetkiliTanımla.FormClosed +=new FormClosedEventHandler(frmIsYeriYetkiliTanımla_FormClosed);
                frmIsYeriYetkiliTanımla.Show();
            }
            else
            {
                frmIsYeriYetkiliTanımla.Activate();
            }
        }
        void frmIsYeriYetkiliTanımla_FormClosed(object sender, FormClosedEventArgs e)
            {
                frmIsYeriYetkiliTanımla = null;
            }
        private void kullanıcıOnaylamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmKullaniciOnayla == null)
            {
                frmKullaniciOnayla = new frmKullaniciOnaylama();
                frmKullaniciOnayla.MdiParent = this;
                frmKullaniciOnayla.FormClosed += new FormClosedEventHandler(frmKullaniciOnayla_FormClosed);
                frmKullaniciOnayla.Show();
            }
            else
            {
                frmKullaniciOnayla.Activate();
                
            }
        }
        void frmKullaniciOnayla_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmKullaniciOnayla = null;
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void kullanıcıListelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRapor frmRapor = new frmRapor();
            frmRapor.Show();
        }

        private void firmaListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFirmaListesiRapor frmFirmaListesiRapor  = new frmFirmaListesiRapor();
            frmFirmaListesiRapor.Show();
        }

        private void yetkiliListelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIsYeriYetkilisiRapor frmIsYeriYetkilisiRapor = new frmIsYeriYetkilisiRapor();
            frmIsYeriYetkilisiRapor.Show();
        }
    }
}
