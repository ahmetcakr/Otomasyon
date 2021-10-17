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
    public partial class Form6_HesKodu : Form
    {
        public Form6_HesKodu()
        {
            InitializeComponent();
        }


        Form2_Duyurular form2_Duyurular;
        Form3_BölümBilgileri form3_BölümBilgileri;
        Form4_ÖzlükBilgileri form4_özlükBilgileri;
        Form5_SifreDegistirme form5_sifreDegistirme;
        

        private void bölümBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            form3_BölümBilgileri = new Form3_BölümBilgileri();
            form3_BölümBilgileri.FormClosing += form3_BölümBilgileri_FormClosing;
            form3_BölümBilgileri.Show();
        }

        private void form3_BölümBilgileri_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void şifreDeğiştirmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            form5_sifreDegistirme = new Form5_SifreDegistirme();
            form5_sifreDegistirme.FormClosing += form5_sifreDegistirme_FormClosing;
            form5_sifreDegistirme.Show();
        }

        private void form5_sifreDegistirme_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void özlükBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            form4_özlükBilgileri = new Form4_ÖzlükBilgileri();
            form4_özlükBilgileri.FormClosing += form4_özlükBilgileri_FormClosing;
            form4_özlükBilgileri.Show();
        }

        private void form4_özlükBilgileri_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void duyurularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2_Duyurular = new Form2_Duyurular();
            form2_Duyurular.FormClosing += Form2_Duyurular_FormClosing;
            form2_Duyurular.Show();
        }

        private void Form2_Duyurular_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
