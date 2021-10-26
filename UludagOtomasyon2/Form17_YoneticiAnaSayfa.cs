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

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
       





        private void Form17_YoneticiAnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_ogrListGöster_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT * FROM Ogrenciler";
            cmd.Connection = baglanti;

            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable ogrTablo = new DataTable();

            adap.Fill(ogrTablo);
            dataGrid_ogrencilerListe.DataSource = ogrTablo;


        }
    }
}
