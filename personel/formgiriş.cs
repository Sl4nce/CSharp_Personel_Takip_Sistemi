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
    public partial class formgiriş : Form
    {
        public formgiriş()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=HPVictus;Initial Catalog=personelveritabani;Integrated Security=True\r\n");
        private void button1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand kmt = new SqlCommand("Select * From tbl_giris Where kullanıcıadı=@p1 and sifre=@p2", baglantı);
            kmt.Parameters.AddWithValue("@p1", textBox1.Text);
            kmt.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader drr = kmt.ExecuteReader();
            if (drr.Read())
            {
                FormAna formAna = new FormAna();
                formAna.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve ya şifreniz yanlış");
            }



            baglantı.Close();
        }
    }
}
