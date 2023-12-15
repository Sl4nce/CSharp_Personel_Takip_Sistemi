using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace personel
{
    public partial class formgrafik : Form
    {
        public formgrafik()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=HPVictus;Initial Catalog=personelveritabani;Integrated Security=True\r\n");
        private void formgrafik_Load(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komutg1 = new SqlCommand("Select Perşehir,Count(*) From tbl_per group by perşehir", baglantı);
            SqlDataReader drg1 = komutg1.ExecuteReader();
            while (drg1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(drg1[0], drg1[1]);
            }

            baglantı.Close();

            baglantı.Open();
            SqlCommand komutg2 = new SqlCommand("Select Permeslek,avg(permaas) From tbl_per group by permeslek", baglantı);
            SqlDataReader drg2 = komutg2.ExecuteReader();
            while (drg2.Read())
            {
                chart2.Series["Meslek-Maaş"].Points.AddXY(drg2[0], drg2[1]);
            }

            baglantı.Close();
        }

    }
}
