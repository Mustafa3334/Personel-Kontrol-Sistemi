namespace Personel_Kontrol_Sistemi
{
    partial class frmYapilanZamlar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYapilanZamlar));
            this.radioYuzde = new System.Windows.Forms.RadioButton();
            this.radioFiyat = new System.Windows.Forms.RadioButton();
            this.txtYuzde = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.comboPersoneller = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPersonelID = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnOnay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioYuzde
            // 
            this.radioYuzde.AutoSize = true;
            this.radioYuzde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioYuzde.Location = new System.Drawing.Point(74, 22);
            this.radioYuzde.Name = "radioYuzde";
            this.radioYuzde.Size = new System.Drawing.Size(101, 19);
            this.radioYuzde.TabIndex = 0;
            this.radioYuzde.TabStop = true;
            this.radioYuzde.Text = "Yüzdeye Göre";
            this.radioYuzde.UseVisualStyleBackColor = true;
            this.radioYuzde.CheckedChanged += new System.EventHandler(this.radioYuzde_CheckedChanged);
            // 
            // radioFiyat
            // 
            this.radioFiyat.AutoSize = true;
            this.radioFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioFiyat.Location = new System.Drawing.Point(206, 22);
            this.radioFiyat.Name = "radioFiyat";
            this.radioFiyat.Size = new System.Drawing.Size(87, 19);
            this.radioFiyat.TabIndex = 0;
            this.radioFiyat.TabStop = true;
            this.radioFiyat.Text = "Fiyata Göre";
            this.radioFiyat.UseVisualStyleBackColor = true;
            this.radioFiyat.CheckedChanged += new System.EventHandler(this.radioFiyat_CheckedChanged);
            // 
            // txtYuzde
            // 
            this.txtYuzde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYuzde.Location = new System.Drawing.Point(77, 126);
            this.txtYuzde.Name = "txtYuzde";
            this.txtYuzde.Size = new System.Drawing.Size(201, 21);
            this.txtYuzde.TabIndex = 1;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyat.Location = new System.Drawing.Point(77, 161);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(201, 21);
            this.txtFiyat.TabIndex = 2;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(77, 196);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(201, 67);
            this.txtAciklama.TabIndex = 3;
            // 
            // comboAy
            // 
            this.comboAy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboAy.FormattingEnabled = true;
            this.comboAy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboAy.Location = new System.Drawing.Point(77, 54);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(89, 23);
            this.comboAy.TabIndex = 4;
            // 
            // comboYil
            // 
            this.comboYil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(189, 54);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(89, 23);
            this.comboYil.TabIndex = 4;
            this.comboYil.SelectedIndexChanged += new System.EventHandler(this.comboYil_SelectedIndexChanged);
            // 
            // comboPersoneller
            // 
            this.comboPersoneller.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboPersoneller.FormattingEnabled = true;
            this.comboPersoneller.Items.AddRange(new object[] {
            "Tüm Personeller"});
            this.comboPersoneller.Location = new System.Drawing.Point(77, 90);
            this.comboPersoneller.Name = "comboPersoneller";
            this.comboPersoneller.Size = new System.Drawing.Size(182, 23);
            this.comboPersoneller.TabIndex = 5;
            this.comboPersoneller.Text = " ";
            this.comboPersoneller.SelectedIndexChanged += new System.EventHandler(this.comboPersoneller_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dönem:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Personeller:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(11, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yüzde(%):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(14, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fiyat(TL):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Açıklama:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(172, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "/";
            // 
            // lblPersonelID
            // 
            this.lblPersonelID.AutoSize = true;
            this.lblPersonelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelID.Location = new System.Drawing.Point(265, 93);
            this.lblPersonelID.Name = "lblPersonelID";
            this.lblPersonelID.Size = new System.Drawing.Size(14, 15);
            this.lblPersonelID.TabIndex = 7;
            this.lblPersonelID.Text = "0";
            // 
            // btnCikis
            // 
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.ImageIndex = 1;
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(198, 272);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(79, 40);
            this.btnCikis.TabIndex = 8;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "confirm_icon-icons.com_66471.png");
            this.ımageList1.Images.SetKeyName(1, "off_downnearexit_apagado_abajo_6017.png");
            // 
            // btnOnay
            // 
            this.btnOnay.FlatAppearance.BorderSize = 0;
            this.btnOnay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOnay.ImageIndex = 0;
            this.btnOnay.ImageList = this.ımageList1;
            this.btnOnay.Location = new System.Drawing.Point(117, 272);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(79, 40);
            this.btnOnay.TabIndex = 8;
            this.btnOnay.Text = "Onay";
            this.btnOnay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOnay.UseVisualStyleBackColor = true;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // frmYapilanZamlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(293, 324);
            this.Controls.Add(this.btnOnay);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.lblPersonelID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboPersoneller);
            this.Controls.Add(this.comboYil);
            this.Controls.Add(this.comboAy);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtYuzde);
            this.Controls.Add(this.radioFiyat);
            this.Controls.Add(this.radioYuzde);
            this.Name = "frmYapilanZamlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Maaş Zamları";
            this.Load += new System.EventHandler(this.frmYapilanZamlar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioYuzde;
        private System.Windows.Forms.RadioButton radioFiyat;
        private System.Windows.Forms.TextBox txtYuzde;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.ComboBox comboPersoneller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPersonelID;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnOnay;
        private System.Windows.Forms.ImageList ımageList1;
    }
}