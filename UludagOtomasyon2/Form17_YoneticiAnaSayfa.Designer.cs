
namespace UludagOtomasyon2
{
    partial class Form17_YoneticiAnaSayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form17_YoneticiAnaSayfa));
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_ogrtListGoster = new System.Windows.Forms.Button();
            this.dataGrid_ogretmenlerListe = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_ogrListGöster = new System.Windows.Forms.Button();
            this.dataGrid_ogrencilerListe = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_sinifListGoster = new System.Windows.Forms.Button();
            this.dataGrid_sınıflarListe = new System.Windows.Forms.DataGridView();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ogretmenlerListe)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ogrencilerListe)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_sınıflarListe)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_ogrtListGoster);
            this.tabPage4.Controls.Add(this.dataGrid_ogretmenlerListe);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(746, 536);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ogretmen Düzenle";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_ogrtListGoster
            // 
            this.btn_ogrtListGoster.BackColor = System.Drawing.Color.Silver;
            this.btn_ogrtListGoster.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ogrtListGoster.Location = new System.Drawing.Point(574, 49);
            this.btn_ogrtListGoster.Name = "btn_ogrtListGoster";
            this.btn_ogrtListGoster.Size = new System.Drawing.Size(141, 35);
            this.btn_ogrtListGoster.TabIndex = 3;
            this.btn_ogrtListGoster.Text = "Öğretmenleri Listele";
            this.btn_ogrtListGoster.UseVisualStyleBackColor = false;
            this.btn_ogrtListGoster.Click += new System.EventHandler(this.btn_ogrtListGoster_Click);
            // 
            // dataGrid_ogretmenlerListe
            // 
            this.dataGrid_ogretmenlerListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_ogretmenlerListe.Location = new System.Drawing.Point(7, 6);
            this.dataGrid_ogretmenlerListe.Name = "dataGrid_ogretmenlerListe";
            this.dataGrid_ogretmenlerListe.Size = new System.Drawing.Size(522, 534);
            this.dataGrid_ogretmenlerListe.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_ogrListGöster);
            this.tabPage2.Controls.Add(this.dataGrid_ogrencilerListe);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(746, 536);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ogrenci Düzenle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_ogrListGöster
            // 
            this.btn_ogrListGöster.BackColor = System.Drawing.Color.Silver;
            this.btn_ogrListGöster.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ogrListGöster.Location = new System.Drawing.Point(574, 49);
            this.btn_ogrListGöster.Name = "btn_ogrListGöster";
            this.btn_ogrListGöster.Size = new System.Drawing.Size(130, 35);
            this.btn_ogrListGöster.TabIndex = 1;
            this.btn_ogrListGöster.Text = "Öğrencileri Listele";
            this.btn_ogrListGöster.UseVisualStyleBackColor = false;
            this.btn_ogrListGöster.Click += new System.EventHandler(this.btn_ogrListGöster_Click);
            // 
            // dataGrid_ogrencilerListe
            // 
            this.dataGrid_ogrencilerListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_ogrencilerListe.Location = new System.Drawing.Point(7, 6);
            this.dataGrid_ogrencilerListe.Name = "dataGrid_ogrencilerListe";
            this.dataGrid_ogrencilerListe.Size = new System.Drawing.Size(522, 534);
            this.dataGrid_ogrencilerListe.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(754, 562);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_sinifListGoster);
            this.tabPage1.Controls.Add(this.dataGrid_sınıflarListe);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(746, 536);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Sınıf Düzenle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_sinifListGoster
            // 
            this.btn_sinifListGoster.BackColor = System.Drawing.Color.Silver;
            this.btn_sinifListGoster.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sinifListGoster.Location = new System.Drawing.Point(574, 49);
            this.btn_sinifListGoster.Name = "btn_sinifListGoster";
            this.btn_sinifListGoster.Size = new System.Drawing.Size(130, 35);
            this.btn_sinifListGoster.TabIndex = 4;
            this.btn_sinifListGoster.Text = "Sınıfları Listele";
            this.btn_sinifListGoster.UseVisualStyleBackColor = false;
            // 
            // dataGrid_sınıflarListe
            // 
            this.dataGrid_sınıflarListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_sınıflarListe.Location = new System.Drawing.Point(7, 6);
            this.dataGrid_sınıflarListe.Name = "dataGrid_sınıflarListe";
            this.dataGrid_sınıflarListe.Size = new System.Drawing.Size(522, 534);
            this.dataGrid_sınıflarListe.TabIndex = 1;
            // 
            // Form17_YoneticiAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 563);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(767, 602);
            this.MinimumSize = new System.Drawing.Size(767, 602);
            this.Name = "Form17_YoneticiAnaSayfa";
            this.Text = "Yönetici Ana Sayfası";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form17_YoneticiAnaSayfa_FormClosing);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ogretmenlerListe)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ogrencilerListe)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_sınıflarListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGrid_ogretmenlerListe;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGrid_ogrencilerListe;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGrid_sınıflarListe;
        private System.Windows.Forms.Button btn_ogrListGöster;
        private System.Windows.Forms.Button btn_ogrtListGoster;
        private System.Windows.Forms.Button btn_sinifListGoster;
    }
}