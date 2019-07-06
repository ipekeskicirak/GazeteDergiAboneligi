using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GazeteDergiAboneligi
{

    public partial class Abonelikler : Form
    {
        public Abonelikler()
        {
            InitializeComponent();
        }

        private void Abonelikler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dataSet3.ABONELİK' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.aBONELİKTableAdapter1.Fill(this.dataSet3.ABONELİK);

            cmb_Tur.Items.Add("Gazete");
            cmb_Tur.Items.Add("Dergi");
        }

        private void Btn_Kontrol_Et_Click(object sender, EventArgs e)
        {
            txt_TC_Kimlik_No.Clear();
            txt_Kimlik_No.Enabled = true;
            txt_Adi.Enabled = true;
            txt_Soyadi.Enabled = true;
            txt_Telefon.Enabled = true;
            dttp_Bas_Tar.Enabled = true;
            dttp_Bit_Tar.Enabled = true;
            txt_Adres.Enabled = true;
            cmb_Tur.Enabled = true;
            cmb_Urun.Enabled = true;
            btn_Kaydet.Enabled = true;
            btn_Yeni_Kayit.Enabled = true;
        }

        private void Btn_Yeni_Kayit_Click(object sender, EventArgs e)
        {
            Kisiler kisi = new Kisiler();
            kisi.Show();
            this.Hide();
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            txt_TC_Kimlik_No.Clear();
            txt_Kimlik_No.Clear();
            txt_Kimlik_No.Enabled = false;
            txt_Adi.Clear();
            txt_Adi.Enabled = false;
            txt_Soyadi.Clear();
            txt_Soyadi.Enabled = false;
            txt_Telefon.Clear();
            txt_Telefon.Enabled = false;
            dttp_Bas_Tar.Enabled = false;
            dttp_Bit_Tar.Enabled = false;
            txt_Adres.Clear();
            txt_Adres.Enabled = false;
            cmb_Tur.Enabled = false;
            cmb_Urun.Enabled = false;
            btn_Kaydet.Enabled = false;
        }

        private void Btn_Guncel_Click(object sender, EventArgs e)
        {
            txt_TC_Kimlik_No.Clear();
            txt_Kimlik_No.Clear();
            txt_Kimlik_No.Enabled = false;
            txt_Adi.Clear();
            txt_Adi.Enabled = false;
            txt_Soyadi.Clear();
            txt_Soyadi.Enabled = false;
            txt_Telefon.Clear();
            txt_Telefon.Enabled = false;
            dttp_Bas_Tar.Enabled = false;
            dttp_Bit_Tar.Enabled = false;
            txt_Adres.Clear();
            txt_Adres.Enabled = false;
            cmb_Tur.Enabled = false;
            cmb_Urun.Enabled = false;
            btn_Guncelle.Enabled = false;
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            txt_TC_Kimlik_No.Clear();
            txt_Kimlik_No.Clear();
            txt_Kimlik_No.Enabled = false;
            txt_Adi.Clear();
            txt_Adi.Enabled = false;
            txt_Soyadi.Clear();
            txt_Soyadi.Enabled = false;
            txt_Telefon.Clear();
            txt_Telefon.Enabled = false;
            dttp_Bas_Tar.Enabled = false;
            dttp_Bit_Tar.Enabled = false;
            txt_Adres.Clear();
            txt_Adres.Enabled = false;
            cmb_Tur.Enabled = false;
            cmb_Urun.Enabled = false;
            btn_Sil.Enabled = false;
        }

        private void Abonelikler_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Çıkmak istediğinize emin misiniz", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ÇIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
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

        private void Grd_Abonelik_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
