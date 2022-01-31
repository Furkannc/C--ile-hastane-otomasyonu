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

namespace _12_hastane_otomasyon
{
    public partial class frmbrans : Form
    {
        public frmbrans()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();

        private void frmbrans_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_brans",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            SqlCommand km = new SqlCommand("insert into tbl_brans (brans_ad) values (@p1)", bgl.baglanti());
            km.Parameters.AddWithValue("@p1", txtad.Text);
            km.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show(txtad.Text + " " + "adlı branş eklendi!");


                
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[sec].Cells[1].Value.ToString();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("delete from tbl_brans where brans_ad=@p1",bgl.baglanti());
            sil.Parameters.AddWithValue("@p1", txtad.Text);
            sil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Brans silindi !");
            
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand gnc = new SqlCommand("update tbl_brans set brans_ad=@p1 where brans_id=@p2",bgl.baglanti());
            gnc.Parameters.AddWithValue("@p1", txtad.Text);
            gnc.Parameters.AddWithValue("@p2", txtid.Text);
            gnc.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Brans güncellendi !");

        }
    }
}
