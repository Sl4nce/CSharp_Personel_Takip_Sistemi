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
    public partial class FormAna : Form
    {
        public FormAna()
        {
            InitializeComponent();
        }
        SqlConnection baglantı=new SqlConnection("Data Source=HPVictus;Initial Catalog=personelveritabani;Integrated Security=True\r\n");

        private void Form1_Load(object sender, EventArgs e)
        {
         
           

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            this.tbl_perTableAdapter.Fill(this.personelveritabaniDataSet.tbl_per);
        }
        void temizle()
        {
            txtid.Text = string.Empty;
            txtad.Text = string.Empty;
            txtmaas.Text = string.Empty;
            txtmeslek.Text = string.Empty;
            txtsehir.Text = string.Empty;   
            txtsoyad.Text = string.Empty;
            radiobekar.Checked = false;
            radioevli.Checked = false;
            txtad.Focus();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_per (perad,persoyad,perşehir,permaas,permeslek,perdurum) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglantı);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2",txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtsehir.Text);
            komut.Parameters.AddWithValue("@p4", txtmaas.Text);
            komut.Parameters.AddWithValue("@p5", txtmeslek.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);


            komut.ExecuteNonQuery();
            //uptade delete insert gibi işlemlerde kullanılıyor.
            baglantı.Close();
            MessageBox.Show("Personel Eklendi");
        }

        private void radioevli_CheckedChanged(object sender, EventArgs e)
        {
            if (radioevli.Checked == true)
            {
                label8.Text = "True";
            }
        }

        private void radiobekar_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobekar.Checked == true)
            {
                label8.Text = "False";
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilendeger = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilendeger].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilendeger].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilendeger].Cells[2].Value.ToString();
            txtsehir.Text = dataGridView1.Rows[secilendeger].Cells[3].Value.ToString();
            txtmaas.Text= dataGridView1.Rows[secilendeger].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[secilendeger].Cells[5].Value.ToString();
            txtmeslek.Text= dataGridView1.Rows[secilendeger].Cells[6].Value.ToString();
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                radioevli.Checked = true;
            }
            if (label8.Text == "False")
            {
                radiobekar.Checked = true;
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komutsil =new SqlCommand("Delete From tbl_per Where perid=@k1",baglantı);
            komutsil.Parameters.AddWithValue("@k1", txtid.Text);
            komutsil.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Kayıt Silindi");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komutguncelle = new SqlCommand("Update tbl_per Set perad=@a1,persoyad=@a2,perşehir=@a3,permaas=@a4,perdurum=@a5,permeslek=@a6 Where perid=@a7", baglantı);
            komutguncelle.Parameters.AddWithValue("@a1", txtad.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txtsoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3", txtsehir.Text);
            komutguncelle.Parameters.AddWithValue("@a4", txtmaas.Text);
            komutguncelle.Parameters.AddWithValue("@a5", label8.Text);
            komutguncelle.Parameters.AddWithValue("@a6", txtmeslek.Text);
            komutguncelle.Parameters.AddWithValue("@a7",txtid.Text);    
            komutguncelle.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Kayıt Güncellendi");


            baglantı.Close();
        }

        private void btnistatistik_Click(object sender, EventArgs e)
        {
            formista formista = new formista();
            formista.Show();
        }

        private void btngrafikler_Click(object sender, EventArgs e)
        {
            formgrafik formgrafik = new formgrafik();
            formgrafik.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
