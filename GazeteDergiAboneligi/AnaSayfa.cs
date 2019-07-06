using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GazeteDergiAboneligi
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void aNASAYFAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            this.Hide();
        }

        private void aBONELİKLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abonelikler abone = new Abonelikler();
            abone.Show();
            this.Hide();
        }

        private void kULLANICILARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kullanicilar kullanici = new Kullanicilar();
            kullanici.Show();
            this.Hide();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void AnaSayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Çıkmak istediğinize emin misiniz", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void sİLİNMİŞXKAYITLARIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SilinmisKayitlar silinmis = new SilinmisKayitlar();
            silinmis.Show();
            this.Hide();
        }


        private void btn_Abonelikler_Click(object sender, EventArgs e)
        {
            Abonelikler a = new Abonelikler();
            a.Show();
            this.Hide();
        }

        private void btn_Kullanicilar_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            k.Show();
            this.Hide();
        }

        private void btn_Silinmis_Kayitlar_Click(object sender, EventArgs e)
        {
            SilinmisKayitlar kayitlar = new SilinmisKayitlar();
            kayitlar.Show();
            this.Hide();
        }

        private void ÜRÜNLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Urunler urun = new Urunler();
            urun.Show();
            this.Hide();
        }

        private void Btn_Urunler_Click(object sender, EventArgs e)
        {
            Urunler u = new Urunler();
            u.Show();
            this.Hide();
        }

        private void GAZETELERToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Gazeteler gazete = new Gazeteler();
            gazete.Show();
            this.Hide();
        }

        private void DERGİLERToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Dergiler dergi = new Dergiler();
            dergi.Show();
            this.Hide();
        }

        private void TÜMÜRÜNLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TumUrunler tum = new TumUrunler();
            tum.Show();
            this.Hide();
        }

        private void KİŞİLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kisiler kisi = new Kisiler();
            kisi.Show();
            this.Hide();
        }

        private void Btn_Kisiler_Click(object sender, EventArgs e)
        {
            Kisiler k = new Kisiler();
            k.Show();
            this.Hide();
        }
    }
}
