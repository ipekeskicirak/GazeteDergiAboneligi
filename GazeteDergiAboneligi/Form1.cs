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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int guvenlik1, guvenlik2, guvenlik, toplam;
        void GuvenlikTanimla()
        {
            Random rnd = new Random();
            guvenlik1 = rnd.Next(1, 100);
            guvenlik2 = rnd.Next(1, 100);
            guvenlik = guvenlik1 + guvenlik2;
            l_Guvenlik_Kodu.Text = "=" + guvenlik1 + "+" + guvenlik2;
            toplam = guvenlik1 + guvenlik2;
        }
        private void btn_Giris_Yap_Click(object sender, EventArgs e)
        {
            if(txt_Kullanici_Adi.Text=="Admin")
            {
                if(txt_Sifre.Text=="1")
                {
                    if(txt_Guvenlik_Kodu.Text==toplam.ToString())
                    {
                        AnaSayfa ana = new AnaSayfa();
                        ana.Show();
                        this.Hide();
                    }
                    else
                    {
                        l_Uyari.Text = "Bilgileri doğru giriniz";
                        txt_Kullanici_Adi.Clear();
                        txt_Sifre.Clear();
                        txt_Guvenlik_Kodu.Clear();
                        GuvenlikTanimla();
                    }
                }
                else
                {
                    l_Uyari.Text = "Bilgileri doğru giriniz";
                    txt_Kullanici_Adi.Clear();
                    txt_Sifre.Clear();
                    txt_Guvenlik_Kodu.Clear();
                    GuvenlikTanimla();
                }
            }
            
            else if (txt_Kullanici_Adi.Text =="Furkan" )
            {
                if (txt_Sifre.Text == "2")
                {
                    if (txt_Guvenlik_Kodu.Text == toplam.ToString())
                    {
                        AnaSayfa2 sayfa = new AnaSayfa2();
                        sayfa.kullaniciAdi = txt_Kullanici_Adi.Text;
                        sayfa.sifre = txt_Sifre.Text;
                        sayfa.Show();
                        this.Hide();
                    }
                    else
                    {
                        l_Uyari.Text = "Bilgileri doğru giriniz";
                        txt_Kullanici_Adi.Clear();
                        txt_Sifre.Clear();
                        txt_Guvenlik_Kodu.Clear();
                        GuvenlikTanimla();
                    }
                }
                else
                {
                    l_Uyari.Text = "Bilgileri doğru giriniz";
                    txt_Kullanici_Adi.Clear();
                    txt_Sifre.Clear();
                    txt_Guvenlik_Kodu.Clear();
                    GuvenlikTanimla();
                }
            }
            else
            {
                l_Uyari.Text = "Bilgileri doğru giriniz";
                txt_Kullanici_Adi.Clear();
                txt_Sifre.Clear();
                txt_Guvenlik_Kodu.Clear();
                GuvenlikTanimla();
            }

        }

        private void btn_Yenile_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Şifrenizin gösterilmesini istediğinize emin misiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                GuvenlikTanimla();
            }
          
        }

        private void btn_Sifreyi_Goster_Click(object sender, EventArgs e)
        {
              DialogResult dialog = new DialogResult();
           dialog= MessageBox.Show("Şifrenizin gösterilmesini istediğinize emin misiniz","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(dialog==DialogResult.Yes)
            {
                txt_Sifre.UseSystemPasswordChar = false;
            }
           
        }

        private void txt_Guvenlik_Kodu_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GuvenlikTanimla();
        }


        private void btn_Iptal_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
           dialog= MessageBox.Show("Çıkmak istediğinize emin misiniz","Çıkış",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dialog==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Çıkmak istediğinize emin misiniz", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
