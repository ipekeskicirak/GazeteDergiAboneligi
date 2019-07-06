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
    public partial class AnaSayfa2 : Form
    {
        public AnaSayfa2()
        {
            InitializeComponent();
        }

        private void aNASAYFAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaSayfa2 ana = new AnaSayfa2();
            ana.Show();
            this.Hide();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }

        private void tab_Kullanici_Islemleri_Click(object sender, EventArgs e)
        {
           
        }

        private void AnaSayfa2_Load(object sender, EventArgs e)
        {
            txt_Kullanici_Adi.Text = kullaniciAdi;
            txt_Sifre.Text = sifre;
            cmb_Tur.Items.Add("Gazete");
            cmb_Tur.Items.Add("Dergi");
        }

        private void AnaSayfa2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Duzenle_Click(object sender, EventArgs e)
        {
            txt_TC_Kimlik_No.Enabled = true;
            txt_Email.Enabled = true;
            txt_Adi_Soyadi.Enabled = true;
            txt_Telefon.Enabled = true;
            rdb_Bay.Enabled = true;
            rdb_Bayan.Enabled = true;
            dttp_Dogum_Tarihi.Enabled = true;
            txt_Kullanici_Adi.Enabled = true;
            txt_Sifre.Enabled = true;
            btn_Guncelle.Enabled = true;
            btn_Duzenle.Enabled = false;
        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            txt_TC_Kimlik_No.Enabled = false;
            txt_Email.Enabled = false;
            txt_Adi_Soyadi.Enabled = false;
            txt_Telefon.Enabled = false;
            rdb_Bay.Enabled = false;
            rdb_Bayan.Enabled = false;
            dttp_Dogum_Tarihi.Enabled = false;
            txt_Kullanici_Adi.Enabled = false;
            txt_Sifre.Enabled = false;
            btn_Duzenle.Enabled = true;
            btn_Guncelle.Enabled = false;
        }

        private void Btn_Kontrol_Et_Click(object sender, EventArgs e)
        {
            txt_TC.Clear();
            txt_Kimlik.Enabled = true;
            txt_Adi.Enabled = true;
            txt_Soyadi.Enabled = true;
            txt_Tel.Enabled = true;
            dttp_Bas_Tar.Enabled = true;
            dttp_Bit_Tar.Enabled = true;
            txt_Adres.Enabled = true;
            cmb_Tur.Enabled = true;
            cmb_Urun.Enabled = true;
            btn_Kaydet.Enabled = true;
            btn_Yeni_Kayit.Enabled = true;
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            txt_Kimlik.Clear();
            txt_Kimlik.Enabled = false;
            txt_Adi.Clear();
            txt_Adi.Enabled = false;
            txt_Soyadi.Clear();
            txt_Soyadi.Enabled = false;
            txt_Tel.Clear();
            txt_Tel.Enabled = false;
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
            txt_Kimlik.Clear();
            txt_Kimlik.Enabled = false;
            txt_Adi.Clear();
            txt_Adi.Enabled = false;
            txt_Soyadi.Clear();
            txt_Soyadi.Enabled = false;
            txt_Tel.Clear();
            txt_Tel.Enabled = false;
            dttp_Bas_Tar.Enabled = false;
            dttp_Bit_Tar.Enabled = false;
            txt_Adres.Clear();
            txt_Adres.Enabled = false;
            cmb_Tur.Enabled = false;
            cmb_Urun.Enabled = false;
            btn_Guncel.Enabled = false;
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            txt_Kimlik.Clear();
            txt_Kimlik.Enabled = false;
            txt_Adi.Clear();
            txt_Adi.Enabled = false;
            txt_Soyadi.Clear();
            txt_Soyadi.Enabled = false;
            txt_Tel.Clear();
            txt_Tel.Enabled = false;
            dttp_Bas_Tar.Enabled = false;
            dttp_Bit_Tar.Enabled = false;
            txt_Adres.Clear();
            txt_Adres.Enabled = false;
            cmb_Tur.Enabled = false;
            cmb_Urun.Enabled = false;
            btn_Sil.Enabled = false;
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Yeni_Kayit_Click(object sender, EventArgs e)
        {
            tab_Calisan.SelectedIndex = 3;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
