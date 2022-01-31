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
    public partial class frmdoktorpanel : Form
    {
        public frmdoktorpanel()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();

        private void frmdoktorpanel_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_doktor", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand sq = new SqlCommand("select brans_ad from tbl_brans ",bgl.baglanti());
            SqlDataReader dr = sq.ExecuteReader();
            while (dr.Read())
            {
                cmb_brans.Items.Add(dr[0]);
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            SqlCommand ek = new SqlCommand("insert into tbl_doktor (doktor_ad,doktor_soyad,doktor_brans,doktor_tc,doktor_sifre) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            ek.Parameters.AddWithValue("@p1", txtad.Text);
            ek.Parameters.AddWithValue("@p2", txtsoyad.Text);
            ek.Parameters.AddWithValue("@p3", cmb_brans.Text);
            ek.Parameters.AddWithValue("@p4", msktc.Text);
            ek.Parameters.AddWithValue("@p5", txtsifre.Text);

            ek.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor kaydedildi!");
                
                


        }

        private void cmb_brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_brans.Items.Clear();
            SqlCommand sq = new SqlCommand("select brans_ad from tbl_brans",bgl.baglanti());
            SqlDataReader dr = sq.ExecuteReader();
            while (dr.Read())
            {
                cmb_brans.Items.Add(dr[0].ToString());
            }

            bgl.baglanti().Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seclen = dataGridView1.SelectedCells[0].RowIndex;
            txtad.Text = dataGridView1.Rows[seclen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[seclen].Cells[2].Value.ToString();
            cmb_brans.Text = dataGridView1.Rows[seclen].Cells[3].Value.ToString();
            msktc.Text = dataGridView1.Rows[seclen].Cells[4].Value.ToString();
            txtsifre.Text = dataGridView1.Rows[seclen].Cells[5].Value.ToString();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("delete from tbl_doktor where doktor_tc=@p1",bgl.baglanti());
            sil.Parameters.AddWithValue("@p1", msktc.Text);
            sil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor kaydı silindi!");

                
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand gnc = new SqlCommand("update tbl_doktor set doktor_ad=@p1,doktor_soyad=@p2,doktor_brans=@p3,doktor_sifre=@p5 where doktor_tc=@p4",bgl.baglanti());
            gnc.Parameters.AddWithValue("@p1", txtad.Text);
            gnc.Parameters.AddWithValue("@p2", txtsoyad.Text);
            gnc.Parameters.AddWithValue("@p3", cmb_brans.Text);
            gnc.Parameters.AddWithValue("@p4", msktc.Text);
            gnc.Parameters.AddWithValue("@p5", txtsifre.Text);
            gnc.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt guncellendi!");
        }
    }
}
