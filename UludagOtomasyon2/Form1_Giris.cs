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


        public Form1_Giris()
        {
            InitializeComponent();
        }


        // VERİTABANI BAĞLANTI KISAYOLLARI
                SqlConnection con;
                SqlCommand cmd;
                SqlDataReader dr;
      


        private void btn_Giris_Click(object sender, EventArgs e)
        {

            string sorgu = "SELECT * FROM KullaniciAdiVeSifre where KullaniciAdi=@KullaniciAdi AND Sifre=@Sifre";
            con = new SqlConnection("Data Source=AHMETSPC;Initial Catalog=UludagUniversity;Integrated Security=true");
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@KullaniciAdi", txt_KullanıcıAdi.Text);
            cmd.Parameters.AddWithValue("@Sifre", txt_Sifre.Text);
            con.Open();

            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Başarıyla Giriş Yapılmıştır");
                form2_Duyurular.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış");
            }

            con.Close();
        }



        private void Form1_Giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
