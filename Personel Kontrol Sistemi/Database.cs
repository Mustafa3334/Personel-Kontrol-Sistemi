using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Personel_Kontrol_Sistemi
{
    class Database
    {
        public static SqlConnection baglanti= new SqlConnection("Data Source=MUSTAFAUYAR;Initial Catalog=Personel_Takip;Integrated Security=True;Pooling=False");
        public static void ESG(SqlCommand cmd,string sql)
        {
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }
        public static DataTable Listele_Ara(DataGridView gridView,string sql)
        {
            DataTable tbl = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(sql, baglanti);
             adtr.Fill(tbl);
            gridView.DataSource = tbl;
            baglanti.Close();


            return tbl;
        }

   
    }
}
