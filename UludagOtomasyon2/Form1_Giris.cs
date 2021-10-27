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



namespace UludagOtomasyon2
{
    public partial class Form1_Giris : Form
    {
        Form2_Duyurular form2_Duyurular = new Form2_Duyurular();
        Form17_YoneticiAnaSayfa form17_yoneticiAnaSayfa = new Form17_YoneticiAnaSayfa();


        public Form1_Giris()
        {
            InitializeComponent();
        }


        // VERİTABANI BAĞLANTI KISAYOLLARI
                SqlConnection con;
                SqlConnection con2;
                SqlCommand cmd;
                SqlCommand cmd2;
                SqlDataReader dr;
                SqlDataReader dr2;


      


        private void btn_Giris_Click(object sender, EventArgs e)
        {

            // ÖĞRENCİ GİRİŞİ SORGULAMA
            string sorgu = "SELECT * FROM OgrKullaniciAdiVeSifre where KullaniciAdi=@KullaniciAdi AND Sifre=@Sifre";
            con = new SqlConnection("Data Source=AHMETSPC;Initial Catalog=UludagUniversity;Integrated Security=true");
            cmd = new SqlCommand(sorgu, con);

            cmd.Parameters.AddWithValue("@KullaniciAdi", txt_KullanıcıAdi.Text);
            cmd.Parameters.AddWithValue("@Sifre", txt_Sifre.Text);

            con.Open();

            dr = cmd.ExecuteReader();



            // YÖNETİCİ GİRİŞİ SORGULAMA
            string sorgu2 = "SELECT * FROM Ogrt_KullaniciAdiVeSifre where KullanıcıAdı=@KullanıcıAdı AND Şifre=@Şifre";
            con2 = new SqlConnection("Data Source=AHMETSPC;Initial Catalog=UludagUniversity;Integrated Security=true");
            cmd2 = new SqlCommand(sorgu2, con2);

            cmd2.Parameters.AddWithValue("@KullanıcıAdı",txt_KullanıcıAdi.Text);
            cmd2.Parameters.AddWithValue("@Şifre",txt_Sifre.Text);

            con2.Open();

            dr2 = cmd2.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Başarıyla Öğrenci Girişi Yapılmıştır");
                form2_Duyurular.Show();
                this.Hide();
            }
            else if (dr2.Read())
            {
                MessageBox.Show("Başarıyla Yönetici Giriş Yapılmıştır");
                form17_yoneticiAnaSayfa.Show();
                this.Hide();
            }


            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış");
            }

            con.Close();
            con2.Close();
        }



        private void Form1_Giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
