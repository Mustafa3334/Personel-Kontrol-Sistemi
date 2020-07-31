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

namespace Personel_Kontrol_Sistemi
{
    public partial class frmizinHareketLisetele : Form
    {
        public frmizinHareketLisetele()
        {
            InitializeComponent();
        }

        izin Izin = new izin();
        private void frmizinHareketLisetele_Load(object sender, EventArgs e)
        {
            Database.Listele_Ara(dataGridView1, "select izinHareketID,PersonelID,KullaniciID,tur.izinTuru,izinBaslangic,izinBitis," +
              "islem,Aciklama,Tarih,Saat from izinHareketListele i, izinTurleri tur where i.izinTurID=tur.izinTurID");
            Personeller.ComboyaKayitGetir(comboizinTuru);
        }
        private void frmizinHareketleri_Load(object sender, EventArgs e)
        {
          
        }
        private void btnizinTurleri_Click(object sender, EventArgs e)
        {
            frmizinturleri frm = new frmizinturleri();
            frm.ShowDialog();
        }
        private void Temizle()
        {
            dateTimeBaslangic.Value = DateTime.Now;
            dateTimeBitis.Value = DateTime.Now;

            Personeller.ComboyaKayitGetir(comboizinTuru);
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            izin i = new izin();
            i.PERSONELID = int.Parse(txtPersonelID.Text);
            i.KullaniciID = Kullanicilar.kid;
            i.IzinTurID = (int)comboizinTuru.SelectedValue;
            i.IzinBaslangic = dateTimeBaslangic.Value;
            i.IzinBitis = dateTimeBitis.Value;
            i.Islem = i.PERSONELID + "-" + txtAdiSoyadi.Text+"için "+comboizinTuru.Text+" oluşturuldu.";
            i.Aciklama = txtAciklama.Text;
            i.Tarih = DateTime.Now;
            i.Saat = DateTime.Now;

            string sql = "insert into izinHareketListele values('"+i.PERSONELID+"','"+i.KullaniciID+"','"+i.IzinTurID+"',@izinBaslangic,@izinBitis," +
                " '"+i.Islem+"','"+i.Aciklama+"',@Tarih,@Saat)";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.Add("@izinBaslangic", SqlDbType.Date).Value = i.IzinBaslangic;
            komut.Parameters.Add("@izinBitis", SqlDbType.Date).Value = i.IzinBitis;
            komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = i.Tarih;
            komut.Parameters.Add("@Saat", SqlDbType.Date).Value = i.Saat;
            try
            {
                Database.ESG(komut,sql);
                Temizle();
                MessageBox.Show( " izin kaydı oluşturuldu.", "İzin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Database.Listele_Ara(dataGridView1, "select izinHareketID,PersonelID,KullaniciID,tur.izinTuru,izinBaslangic,izinBitis," +
                  "islem,Aciklama,Tarih,Saat from izinHareketListele i, izinTurleri tur where i.izinTurID=tur.izinTurID");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı");
              
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            izin i = new izin();
            i.IzinHareketID = int.Parse(txtizinHareketID.Text);
            i.PERSONELID = int.Parse(txtPersonelID.Text);
            i.KullaniciID = Kullanicilar.kid;
            i.IzinTurID = (int)comboizinTuru.SelectedValue;
            i.IzinBaslangic = dateTimeBaslangic.Value;
            i.IzinBitis = dateTimeBitis.Value;
            i.Aciklama = txtAciklama.Text;
            i.Tarih = DateTime.Now;
            i.Saat = DateTime.Now;
            i.Islem = i.IzinHareketID + " nolu izin bilgileri değiştirildi";

            string sql = "update izinHareketListele set PersonelID='"+i.PERSONELID+"',izinTurID='"+i.IzinTurID+"',izinBaslangic=@izinBaslangic," +
                "izinBitis=@izinBitis,islem='"+i.Islem+"',Aciklama='"+i.Aciklama+"',Tarih=@Tarih,Saat=@Saat where izinHareketID='"+i.IzinHareketID+"'";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.Add("@izinBaslangic", SqlDbType.Date).Value = i.IzinBaslangic;
            komut.Parameters.Add("@izinBitis", SqlDbType.Date).Value = i.IzinBitis;
            komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = i.Tarih;
            komut.Parameters.Add("@Saat", SqlDbType.Date).Value = i.Saat;
            try
            {
                Database.ESG(komut, sql);
                Temizle();
                MessageBox.Show(" izin bilgileri güncellendi.", "İzin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Database.Listele_Ara(dataGridView1, "select izinHareketID,PersonelID,KullaniciID,tur.izinTuru,izinBaslangic,izinBitis," +
                  "islem,Aciklama,Tarih,Saat from izinHareketListele i, izinTurleri tur where i.izinTurID=tur.izinTurID");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı");

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            izin i = new izin();
            i.IzinHareketID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string sql = "delete from izinHareketListele where izinHareketID='"+i.IzinHareketID+"'";
            SqlCommand komut = new SqlCommand();
            try
            {
                Database.ESG(komut, sql);
                Temizle();
                MessageBox.Show(" izin bilgileri silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Database.Listele_Ara(dataGridView1, "select izinHareketID,PersonelID,KullaniciID,tur.izinTuru,izinBaslangic,izinBitis," +
                  "islem,Aciklama,Tarih,Saat from izinHareketListele i, izinTurleri tur where i.izinTurID=tur.izinTurID");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı");

            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPersonelID_TextChanged(object sender, EventArgs e)
        {
            Primler.PersonelAdSoyadGetir(txtPersonelID,txtAdiSoyadi);
            if (txtPersonelID.Text=="")
            {
                txtAdiSoyadi.Text = "";
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtizinHareketID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtPersonelID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboizinTuru.Text =  dataGridView1.CurrentRow.Cells["izinTuru"].Value.ToString();
            dateTimeBaslangic.Text=  dataGridView1.CurrentRow.Cells["izinBaslangic"].Value.ToString();
           dateTimeBitis.Text=  dataGridView1.CurrentRow.Cells["izinBitis"].Value.ToString();
           txtAciklama.Text=dataGridView1.CurrentRow.Cells["Aciklama"].Value.ToString();
        }
    }
}
