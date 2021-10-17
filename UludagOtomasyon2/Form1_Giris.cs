using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UludagOtomasyon2
{
    public partial class Form1_Giris : Form
    {
        Form2_Duyurular form2_Duyurular = new Form2_Duyurular();
        public Form1_Giris()
        {
            InitializeComponent();
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
           if (txt_KullanıcıAdi.Text == "ahmet" && txt_Sifre.Text == "1234")
           {
            form2_Duyurular.Show();
            this.Hide();
            }
             else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifreniz Yanlış");
            }
        }

        private void Form1_Giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
