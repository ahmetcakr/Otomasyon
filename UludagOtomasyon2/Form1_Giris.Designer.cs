
namespace UludagOtomasyon2
{
    partial class Form1_Giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1_Giris));
            this.linklbl_TıklayınızSifre = new System.Windows.Forms.LinkLabel();
            this.lbl_Hatırlamıyorsanız = new System.Windows.Forms.Label();
            this.btn_Giris = new System.Windows.Forms.Button();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.txt_KullanıcıAdi = new System.Windows.Forms.TextBox();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.lbl_KullanıcıAdi = new System.Windows.Forms.Label();
            this.lbl_Otomasyonu = new System.Windows.Forms.Label();
            this.lbl_BUOIsleri = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linklbl_TıklayınızSifre
            // 
            this.linklbl_TıklayınızSifre.AutoSize = true;
            this.linklbl_TıklayınızSifre.BackColor = System.Drawing.Color.Transparent;
            this.linklbl_TıklayınızSifre.Font = new System.Drawing.Font("Calisto MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_TıklayınızSifre.Location = new System.Drawing.Point(355, 471);
            this.linklbl_TıklayınızSifre.Name = "linklbl_TıklayınızSifre";
            this.linklbl_TıklayınızSifre.Size = new System.Drawing.Size(72, 16);
            this.linklbl_TıklayınızSifre.TabIndex = 14;
            this.linklbl_TıklayınızSifre.TabStop = true;
            this.linklbl_TıklayınızSifre.Text = "Tıklayınız";
            // 
            // lbl_Hatırlamıyorsanız
            // 
            this.lbl_Hatırlamıyorsanız.AutoSize = true;
            this.lbl_Hatırlamıyorsanız.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Hatırlamıyorsanız.Font = new System.Drawing.Font("Calisto MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hatırlamıyorsanız.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbl_Hatırlamıyorsanız.Location = new System.Drawing.Point(277, 443);
            this.lbl_Hatırlamıyorsanız.Name = "lbl_Hatırlamıyorsanız";
            this.lbl_Hatırlamıyorsanız.Size = new System.Drawing.Size(220, 16);
            this.lbl_Hatırlamıyorsanız.TabIndex = 13;
            this.lbl_Hatırlamıyorsanız.Text = "Öğrenci Şifrenizi Hatırlamıyorsanız";
            // 
            // btn_Giris
            // 
            this.btn_Giris.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_Giris.Font = new System.Drawing.Font("Calisto MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Giris.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Giris.Location = new System.Drawing.Point(349, 389);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(78, 38);
            this.btn_Giris.TabIndex = 12;
            this.btn_Giris.Text = "giriş";
            this.btn_Giris.UseVisualStyleBackColor = false;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Sifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Sifre.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Sifre.Location = new System.Drawing.Point(267, 363);
            this.txt_Sifre.Multiline = true;
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.PasswordChar = '*';
            this.txt_Sifre.Size = new System.Drawing.Size(251, 20);
            this.txt_Sifre.TabIndex = 10;
            // 
            // txt_KullanıcıAdi
            // 
            this.txt_KullanıcıAdi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_KullanıcıAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_KullanıcıAdi.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_KullanıcıAdi.Location = new System.Drawing.Point(267, 328);
            this.txt_KullanıcıAdi.Multiline = true;
            this.txt_KullanıcıAdi.Name = "txt_KullanıcıAdi";
            this.txt_KullanıcıAdi.Size = new System.Drawing.Size(251, 20);
            this.txt_KullanıcıAdi.TabIndex = 11;
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Sifre.Font = new System.Drawing.Font("Calisto MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sifre.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbl_Sifre.Location = new System.Drawing.Point(128, 363);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(133, 16);
            this.lbl_Sifre.TabIndex = 6;
            this.lbl_Sifre.Text = "Sifre                       :";
            // 
            // lbl_KullanıcıAdi
            // 
            this.lbl_KullanıcıAdi.AutoSize = true;
            this.lbl_KullanıcıAdi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_KullanıcıAdi.Font = new System.Drawing.Font("Calisto MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KullanıcıAdi.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbl_KullanıcıAdi.Location = new System.Drawing.Point(130, 332);
            this.lbl_KullanıcıAdi.Name = "lbl_KullanıcıAdi";
            this.lbl_KullanıcıAdi.Size = new System.Drawing.Size(131, 16);
            this.lbl_KullanıcıAdi.TabIndex = 7;
            this.lbl_KullanıcıAdi.Text = "Kullanıcı Adı         :";
            // 
            // lbl_Otomasyonu
            // 
            this.lbl_Otomasyonu.AutoSize = true;
            this.lbl_Otomasyonu.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Otomasyonu.Font = new System.Drawing.Font("Calisto MT", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Otomasyonu.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbl_Otomasyonu.Location = new System.Drawing.Point(209, 90);
            this.lbl_Otomasyonu.Name = "lbl_Otomasyonu";
            this.lbl_Otomasyonu.Size = new System.Drawing.Size(329, 46);
            this.lbl_Otomasyonu.TabIndex = 8;
            this.lbl_Otomasyonu.Text = "OTOMASYONU";
            // 
            // lbl_BUOIsleri
            // 
            this.lbl_BUOIsleri.AutoSize = true;
            this.lbl_BUOIsleri.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BUOIsleri.Font = new System.Drawing.Font("Calisto MT", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BUOIsleri.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbl_BUOIsleri.Location = new System.Drawing.Point(23, 28);
            this.lbl_BUOIsleri.Name = "lbl_BUOIsleri";
            this.lbl_BUOIsleri.Size = new System.Drawing.Size(709, 46);
            this.lbl_BUOIsleri.TabIndex = 9;
            this.lbl_BUOIsleri.Text = "BURSA ULUDAG OGRENCI ISLERI";
            // 
            // Form1_Giris
            // 
            this.AcceptButton = this.btn_Giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(751, 563);
            this.Controls.Add(this.linklbl_TıklayınızSifre);
            this.Controls.Add(this.lbl_Hatırlamıyorsanız);
            this.Controls.Add(this.btn_Giris);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_KullanıcıAdi);
            this.Controls.Add(this.lbl_Sifre);
            this.Controls.Add(this.lbl_KullanıcıAdi);
            this.Controls.Add(this.lbl_Otomasyonu);
            this.Controls.Add(this.lbl_BUOIsleri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(767, 602);
            this.Name = "Form1_Giris";
            this.Text = "Uludağ Öğrenci Otomasyonu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Giris_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linklbl_TıklayınızSifre;
        private System.Windows.Forms.Label lbl_Hatırlamıyorsanız;
        private System.Windows.Forms.Button btn_Giris;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.TextBox txt_KullanıcıAdi;
        private System.Windows.Forms.Label lbl_Sifre;
        private System.Windows.Forms.Label lbl_KullanıcıAdi;
        private System.Windows.Forms.Label lbl_Otomasyonu;
        private System.Windows.Forms.Label lbl_BUOIsleri;
    }
}

