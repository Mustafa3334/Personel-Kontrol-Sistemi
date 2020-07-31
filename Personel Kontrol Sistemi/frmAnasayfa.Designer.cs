namespace Personel_Kontrol_Sistemi
{
    partial class frmAnasayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnasayfa));
            this.btnDepartmanlar = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.btnPersonelListele = new System.Windows.Forms.Button();
            this.btnMaasZamlari = new System.Windows.Forms.Button();
            this.btnMesaiEkle = new System.Windows.Forms.Button();
            this.btnMesailer = new System.Windows.Forms.Button();
            this.btnizinHareketListele = new System.Windows.Forms.Button();
            this.panelIslemler = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panelFormlar = new System.Windows.Forms.Panel();
            this.panelIslemler.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDepartmanlar
            // 
            this.btnDepartmanlar.FlatAppearance.BorderSize = 0;
            this.btnDepartmanlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartmanlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartmanlar.ImageIndex = 0;
            this.btnDepartmanlar.ImageList = this.ımageList1;
            this.btnDepartmanlar.Location = new System.Drawing.Point(1, 68);
            this.btnDepartmanlar.Name = "btnDepartmanlar";
            this.btnDepartmanlar.Size = new System.Drawing.Size(164, 50);
            this.btnDepartmanlar.TabIndex = 0;
            this.btnDepartmanlar.Text = "Departmanlar";
            this.btnDepartmanlar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDepartmanlar.UseVisualStyleBackColor = true;
            this.btnDepartmanlar.Click += new System.EventHandler(this.btnDepartmanlar_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "businessapplication_binarytree_tree_negocio_2316.ico");
            this.ımageList1.Images.SetKeyName(1, "calendar_office_day_1474.png");
            this.ımageList1.Images.SetKeyName(2, "organizer_calendar_clock_pencil_10047.png");
            this.ımageList1.Images.SetKeyName(3, "add_12966.png");
            this.ımageList1.Images.SetKeyName(4, "increase_25373.png");
            this.ımageList1.Images.SetKeyName(5, "list_992.png");
            this.ımageList1.Images.SetKeyName(6, "Menu_icon_icon-icons.com_71858.png");
            this.ımageList1.Images.SetKeyName(7, "business_application_addmale_useradd_insert_add_user_client_2312.png");
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.FlatAppearance.BorderSize = 0;
            this.btnPersonelEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonelEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonelEkle.ImageIndex = 7;
            this.btnPersonelEkle.ImageList = this.ımageList1;
            this.btnPersonelEkle.Location = new System.Drawing.Point(2, 124);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(164, 50);
            this.btnPersonelEkle.TabIndex = 0;
            this.btnPersonelEkle.Text = "Personel Ekle";
            this.btnPersonelEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonelEkle.UseVisualStyleBackColor = true;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // btnPersonelListele
            // 
            this.btnPersonelListele.FlatAppearance.BorderSize = 0;
            this.btnPersonelListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonelListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonelListele.ImageIndex = 5;
            this.btnPersonelListele.ImageList = this.ımageList1;
            this.btnPersonelListele.Location = new System.Drawing.Point(2, 190);
            this.btnPersonelListele.Name = "btnPersonelListele";
            this.btnPersonelListele.Size = new System.Drawing.Size(164, 50);
            this.btnPersonelListele.TabIndex = 0;
            this.btnPersonelListele.Text = "Personel Listele";
            this.btnPersonelListele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonelListele.UseVisualStyleBackColor = true;
            this.btnPersonelListele.Click += new System.EventHandler(this.btnPersonelListele_Click);
            // 
            // btnMaasZamlari
            // 
            this.btnMaasZamlari.FlatAppearance.BorderSize = 0;
            this.btnMaasZamlari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaasZamlari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaasZamlari.ImageIndex = 4;
            this.btnMaasZamlari.ImageList = this.ımageList1;
            this.btnMaasZamlari.Location = new System.Drawing.Point(2, 256);
            this.btnMaasZamlari.Name = "btnMaasZamlari";
            this.btnMaasZamlari.Size = new System.Drawing.Size(164, 50);
            this.btnMaasZamlari.TabIndex = 0;
            this.btnMaasZamlari.Text = "Maaş Zamları";
            this.btnMaasZamlari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMaasZamlari.UseVisualStyleBackColor = true;
            this.btnMaasZamlari.Click += new System.EventHandler(this.btnMaasZamlari_Click);
            // 
            // btnMesaiEkle
            // 
            this.btnMesaiEkle.FlatAppearance.BorderSize = 0;
            this.btnMesaiEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesaiEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMesaiEkle.ImageIndex = 3;
            this.btnMesaiEkle.ImageList = this.ımageList1;
            this.btnMesaiEkle.Location = new System.Drawing.Point(2, 322);
            this.btnMesaiEkle.Name = "btnMesaiEkle";
            this.btnMesaiEkle.Size = new System.Drawing.Size(164, 50);
            this.btnMesaiEkle.TabIndex = 0;
            this.btnMesaiEkle.Text = "Mesai Ekle";
            this.btnMesaiEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMesaiEkle.UseVisualStyleBackColor = true;
            this.btnMesaiEkle.Click += new System.EventHandler(this.btnMesaiEkle_Click);
            // 
            // btnMesailer
            // 
            this.btnMesailer.FlatAppearance.BorderSize = 0;
            this.btnMesailer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesailer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMesailer.ImageIndex = 2;
            this.btnMesailer.ImageList = this.ımageList1;
            this.btnMesailer.Location = new System.Drawing.Point(2, 388);
            this.btnMesailer.Name = "btnMesailer";
            this.btnMesailer.Size = new System.Drawing.Size(164, 50);
            this.btnMesailer.TabIndex = 0;
            this.btnMesailer.Text = "Mesailer";
            this.btnMesailer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMesailer.UseVisualStyleBackColor = true;
            this.btnMesailer.Click += new System.EventHandler(this.btnMesailer_Click);
            // 
            // btnizinHareketListele
            // 
            this.btnizinHareketListele.FlatAppearance.BorderSize = 0;
            this.btnizinHareketListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnizinHareketListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnizinHareketListele.ImageIndex = 1;
            this.btnizinHareketListele.ImageList = this.ımageList1;
            this.btnizinHareketListele.Location = new System.Drawing.Point(2, 456);
            this.btnizinHareketListele.Name = "btnizinHareketListele";
            this.btnizinHareketListele.Size = new System.Drawing.Size(164, 50);
            this.btnizinHareketListele.TabIndex = 0;
            this.btnizinHareketListele.Text = "İzin Hareketleri";
            this.btnizinHareketListele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnizinHareketListele.UseVisualStyleBackColor = true;
            this.btnizinHareketListele.Click += new System.EventHandler(this.btnizinHareketListele_Click);
            // 
            // panelIslemler
            // 
            this.panelIslemler.BackColor = System.Drawing.SystemColors.Control;
            this.panelIslemler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelIslemler.Controls.Add(this.btnMenu);
            this.panelIslemler.Controls.Add(this.btnDepartmanlar);
            this.panelIslemler.Controls.Add(this.btnMesailer);
            this.panelIslemler.Controls.Add(this.btnizinHareketListele);
            this.panelIslemler.Controls.Add(this.btnPersonelEkle);
            this.panelIslemler.Controls.Add(this.btnPersonelListele);
            this.panelIslemler.Controls.Add(this.btnMesaiEkle);
            this.panelIslemler.Controls.Add(this.btnMaasZamlari);
            this.panelIslemler.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIslemler.Location = new System.Drawing.Point(0, 0);
            this.panelIslemler.Name = "panelIslemler";
            this.panelIslemler.Size = new System.Drawing.Size(170, 521);
            this.panelIslemler.TabIndex = 1;
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ImageIndex = 6;
            this.btnMenu.ImageList = this.ımageList1;
            this.btnMenu.Location = new System.Drawing.Point(12, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(85, 50);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panelFormlar
            // 
            this.panelFormlar.BackColor = System.Drawing.Color.SkyBlue;
            this.panelFormlar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFormlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormlar.Location = new System.Drawing.Point(170, 0);
            this.panelFormlar.Name = "panelFormlar";
            this.panelFormlar.Size = new System.Drawing.Size(894, 521);
            this.panelFormlar.TabIndex = 2;
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 521);
            this.Controls.Add(this.panelFormlar);
            this.Controls.Add(this.panelIslemler);
            this.Name = "frmAnasayfa";
            this.Text = "Ana Sayfa ";
            this.Load += new System.EventHandler(this.frmAnasayfa_Load);
            this.panelIslemler.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDepartmanlar;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.Button btnPersonelListele;
        private System.Windows.Forms.Button btnMaasZamlari;
        private System.Windows.Forms.Button btnMesaiEkle;
        private System.Windows.Forms.Button btnMesailer;
        private System.Windows.Forms.Button btnizinHareketListele;
        private System.Windows.Forms.Panel panelIslemler;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panelFormlar;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

