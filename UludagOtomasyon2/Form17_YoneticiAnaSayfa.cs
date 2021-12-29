using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UludagOtomasyon2
{
    public partial class Form17_YoneticiAnaSayfa : Form
    {
        public Form17_YoneticiAnaSayfa()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=AHMETSPC;Initial Catalog=UludagUniversity;Integrated Security=True");
        SqlConnection baglanti2 = new SqlConnection("Data Source=AHMETSPC;Initial Catalog=UludagUniversity;Integrated Security=True");

       





        private void Form17_YoneticiAnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_ogrListGöster_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Ogrenciler";
            komut.Connection = baglanti;

            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();

            adap.Fill(tablo);

            dataGrid_ogrencilerListe.DataSource = tablo;
            baglanti.Close();

        }

        private void btn_ogrtListGoster_Click(object sender, EventArgs e)
        {
            baglanti2.Open();
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Ogretmenler";
            komut.Connection = baglanti2;

            SqlDataAdapter adap2 = new SqlDataAdapter(komut);
            DataTable tablo2 = new DataTable();

            adap2.Fill(tablo2);

            dataGrid_ogretmenlerListe.DataSource = tablo2;
            baglanti2.Close();

        }
    }
}
