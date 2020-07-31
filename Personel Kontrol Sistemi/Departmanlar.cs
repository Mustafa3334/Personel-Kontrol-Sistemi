using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Personel_Kontrol_Sistemi
{
    class Departmanlar
    {
        private int _DepartmanID;
        private string _Departman;
        private string _Aciklama;

        public int DepartmanID { get => _DepartmanID; set => _DepartmanID = value; }
        public string Departman { get => _Departman; set => _Departman = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }

        public static SqlDataReader DepartmanGetir(System.Windows.Forms.ListView lst)
        {
            lst.Items.Clear();
            Database.baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *from Departmanlar", Database.baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()==true)
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr[0].ToString();
                ekle.SubItems.Add(dr[1].ToString());
                ekle.SubItems.Add(dr[2].ToString());
                lst.Items.Add(ekle);
            }
            Database.baglanti.Close();
            return dr;
        }

    }
}
