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

namespace personel
{
    public partial class formista : Form
    {
        public formista()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=HPVictus;Initial Catalog=personelveritabani;Integrated Security=True\r\n");
        private void formista_Load(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut1 = new SqlCommand("Select Count(*) From tbl_per", baglantı);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                label2.Text = dr1[0].ToString();
            }

            baglantı.Close();


            //Evli olanlar bulma
            baglantı.Open ();
            SqlCommand komut2 = new SqlCommand("Select Count(*) From tbl_per Where perdurum=1", baglantı);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                label4.Text = dr2[0].ToString();
            }
            baglantı.Close ();

            //Bekar olanları bulma
            baglantı.Open();
            SqlCommand komut3 = new SqlCommand("Select Count(*) From tbl_per Where perdurum=0", baglantı);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                label6.Text = dr3[0].ToString();
            }
            baglantı.Close();

            //Şehir sayılarını bulma
            baglantı.Open();
            SqlCommand komut4 = new SqlCommand("Select Count(distinct(perşehir)) From tbl_per",baglantı);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                label8.Text = dr4[0].ToString();
            }

            baglantı.Close();

            //Toplam maaş
            baglantı.Open();
            SqlCommand komut5 = new SqlCommand("Select Sum(permaas) From tbl_per",baglantı);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while(dr5.Read())
            {
                label10.Text = dr5[0].ToString();
            }
            baglantı.Close() ;
            //Ortalama Maaş
            baglantı.Open();
            SqlCommand komut6 = new SqlCommand("Select Avg(permaas) From tbl_per", baglantı);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                label12.Text = dr6[0].ToString();
            }
            baglantı.Close();

        }
    }
}
