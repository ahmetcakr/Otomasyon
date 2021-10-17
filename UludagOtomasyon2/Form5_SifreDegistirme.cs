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
    public partial class Form5_SifreDegistirme : Form
    {
        public Form5_SifreDegistirme()
        {
            InitializeComponent();
        }
        
        
        Form2_Duyurular form2_Duyurular;
        Form3_BölümBilgileri form3_BölümBilgileri;
        Form4_ÖzlükBilgileri form4_özlükBilgileri;
        //Form5_SifreDegistirme form5_sifreDegistirme;
        Form6_HesKodu form6_hesKodu;
        Form7_DersAlma form7_dersAlma;
        Form8_DersProgramı form8_dersProgramı;
        Form9_DönemDersleri form9_dönemDersleri;
        Form10_HarcDurumu form10_harcDurumu;
        Form11_KrediKartı form11_krediKarti;
        Form12_NotKartı form12_notKarti;
        Form13_SınavSonuclari form13_sinavSonuclari;
        Form14_Sınavlar form14_sinavlar;
        Form15_StajBasvuru form15_stajBasvuru;
        Form16_StajBilgi form16_stajBilgisi;




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

        private void hESKoduToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            form6_hesKodu = new Form6_HesKodu();
            form6_hesKodu.FormClosing += form6_hesKodu_FormClosing;
            form6_hesKodu.Show();
        }

        private void form6_hesKodu_FormClosing(object sender, FormClosingEventArgs e)
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
