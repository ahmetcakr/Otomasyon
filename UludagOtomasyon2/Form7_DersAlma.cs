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
    public partial class Form7_DersAlma : Form
    {
        public Form7_DersAlma()
        {
            InitializeComponent();
        }
        Form2_Duyurular form2_Duyurular;
        Form3_BölümBilgileri form3_BölümBilgileri;
        Form4_ÖzlükBilgileri form4_özlükBilgileri;
        Form5_SifreDegistirme form5_sifreDegistirme;
        Form6_HesKodu form6_hesKodu;
        
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
            // Bölüm Bilgileri
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
            // Özlük Bilgileri
            this.Hide();
            form4_özlükBilgileri = new Form4_ÖzlükBilgileri();
            form4_özlükBilgileri.FormClosing += form4_özlükBilgileri_FormClosing;
            form4_özlükBilgileri.Show();
        }

        private void form4_özlükBilgileri_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void şifreDeğiştirmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Şifre Değiştirme
            this.Hide();
            form5_sifreDegistirme = new Form5_SifreDegistirme();
            form5_sifreDegistirme.FormClosing += form5_sifreDegistirme_FormClosing;
            form5_sifreDegistirme.Show();
        }

        private void form5_sifreDegistirme_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void hESKoduToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hes Kodu
            this.Hide();
            form6_hesKodu = new Form6_HesKodu();
            form6_hesKodu.FormClosing += form6_hesKodu_FormClosing;
            form6_hesKodu.Show();
        }

        private void form6_hesKodu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dersProgramıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ders Programı
            this.Hide();
            form8_dersProgramı = new Form8_DersProgramı();
            form8_dersProgramı.FormClosing += form8_dersProgramı_FormClosing;
            form8_dersProgramı.Show();
        }

        private void form8_dersProgramı_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dönemDersleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Dönem Dersleri
            this.Hide();
            form9_dönemDersleri = new Form9_DönemDersleri();
            form9_dönemDersleri.FormClosing += form9_dönemDersleri_FormClosing;
            form9_dönemDersleri.Show();
        }

        private void form9_dönemDersleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void harçDurumuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Harç Durumu
            this.Hide();
            form10_harcDurumu = new Form10_HarcDurumu();
            form10_harcDurumu.FormClosing += form10_harcDurumu_FormClosing;
            form10_harcDurumu.Show();
        }

        private void form10_harcDurumu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void krediKartıİleÖdemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Kredi Kartı İle Ödeme
            this.Hide();
            form11_krediKarti = new Form11_KrediKartı();
            form11_krediKarti.FormClosing += form11_krediKarti_FormClosing;
            form11_krediKarti.Show();
        }

        private void form11_krediKarti_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void notKartıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Not Kartı
            this.Hide();
            form12_notKarti = new Form12_NotKartı();
            form12_notKarti.FormClosing += form12_notKarti_FormClosing;
            form12_notKarti.Show();
        }

        private void form12_notKarti_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void sınavSonuçlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Sınav Sonuçları
            this.Hide();
            form13_sinavSonuclari = new Form13_SınavSonuclari();
            form13_sinavSonuclari.FormClosing += form13_sinavSonuclari_FormClosing;
            form13_sinavSonuclari.Show();
        }

        private void form13_sinavSonuclari_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void sınavlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Sınavlar
            this.Hide();
            form14_sinavlar = new Form14_Sınavlar();
            form14_sinavlar.FormClosing += form14_sinavlar_FormClosing;
            form14_sinavlar.Show();
        }

        private void form14_sinavlar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void stajBaşvurularıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Staj Başvuruları
            this.Hide();
            form15_stajBasvuru = new Form15_StajBasvuru();
            form15_stajBasvuru.FormClosing += form15_stajBasvuru_FormClosing;
            form15_stajBasvuru.Show();
        }

        private void form15_stajBasvuru_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void stajBilgilerimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Staj Bilgileri
            this.Hide();
            form16_stajBilgisi = new Form16_StajBilgi();
            form16_stajBilgisi.FormClosing += form16_stajBilgisi_FormClosing;
            form16_stajBilgisi.Show();
        }

        private void form16_stajBilgisi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void duyurularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Duyurular
            this.Hide();
            form2_Duyurular = new Form2_Duyurular();
            form2_Duyurular.FormClosing += form2_Duyurular_FormClosing;
            form2_Duyurular.Show();
        }

        private void form2_Duyurular_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
