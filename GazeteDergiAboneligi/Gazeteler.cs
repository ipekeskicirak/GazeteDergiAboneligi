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
    public partial class Gazeteler : Form
    {
        public Gazeteler()
        {
            InitializeComponent();
        }

        private void Gazeteler_Load(object sender, EventArgs e)
        {

        }

        private void Gazeteler_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Çıkmak istediğinize emin misiniz", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ANASAYFAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }

        private void ÜRÜNLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Urunler urun = new Urunler();
            urun.Show();
            this.Hide();
        }

        private void GAZETELERToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Gazeteler gazete = new Gazeteler();
            this.Hide();
        }

        private void DERGİLERToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Dergiler dergi = new Dergiler();
            dergi.Show();
            this.Hide();
        }

        private void ABONELİKLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abonelikler abonelik = new Abonelikler();
            abonelik.Show();
            this.Hide();
        }

        private void KULLANICILARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kullanicilar kullanici = new Kullanicilar();
            kullanici.Show();
            this.Hide();
        }

        private void SİLİNMİŞXKAYITLARIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SilinmisKayitlar silinmis = new SilinmisKayitlar();
            silinmis.Show();
            this.Hide();
        }

        private void ÇIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
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
    }
}
