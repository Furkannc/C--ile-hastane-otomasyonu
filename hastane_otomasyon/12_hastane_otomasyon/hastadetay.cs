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
    public partial class hastadetay : Form
    {
        public hastadetay()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();
        public string tc;
        private void hastadetay_Load(object sender, EventArgs e)
        {
            lbl_tc.Text = tc;

            SqlCommand komut = new SqlCommand("select hasta_ad,hasta_soyad from tbl_hasta where hasta_tc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tc);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbl_ad_soyad.Text = dr[0] + " " +dr[1];     //labelın içini tablodan gelen 1 ve 2. satır ile doldur

            }
            bgl.baglanti().Close();
            //////////////////////////////////////////////////////
            DataTable dt = new DataTable();     //veri tablosu oluşturulur

            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevu where hasta_tc=" + tc, bgl.baglanti());   
            da.Fill(dt);                        //data adapter ile sql e baglanıyoruz  değerleri direk adapter içinden veriyoruz
            dataGridView1.DataSource = dt;      //data adapterin içini veri tablosuyla dolduruyoruz
                                                //datagridin içini dt den gelen veri ile dolduruyoruz

            //////////////////////////////////////////////////////////////////////////////////////////
       
            SqlCommand komut1 = new SqlCommand("select brans_ad from tbl_brans",bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                cmb_brans.Items.Add(dr1[0]);
            }

            bgl.baglanti().Close();

            ///////////////////////////////////////////////////////////////////////
            
           

        }

        private void cmb_brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_doktor.Items.Clear();

            SqlCommand komu2 = new SqlCommand("select doktor_ad,doktor_soyad from tbl_doktor where doktor_brans=@p1", bgl.baglanti());
            komu2.Parameters.AddWithValue("@p1", cmb_brans.Text);
            SqlDataReader dr2 = komu2.ExecuteReader();
            while (dr2.Read())
            {
                cmb_doktor.Items.Add(dr2[0] + " " + dr2[1]);
            }
            bgl.baglanti().Close();
        }

        private void cmb_doktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevu where randevu_brans='" + cmb_brans.Text + "'" + "and randevu_doktor='" + cmb_doktor.Text+"'and randevu_durum=0", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void lnkbilgiduzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmbilgiduzenle fr = new frmbilgiduzenle();
            
            
            fr.tcno = lbl_tc.Text;


            fr.Show();

        }

        private void btn_randevu_al_Click(object sender, EventArgs e)
        {
            SqlCommand al = new SqlCommand("update tbl_randevu set randevu_durum=1,hasta_tc=@p1,hasta_sikayet=@p2 where randevu_id=@p3)",bgl.baglanti());
            al.Parameters.AddWithValue("@p1", lbl_tc.Text);
            al.Parameters.AddWithValue("@p2", richsikayet.Text);
            al.Parameters.AddWithValue("@p3", txtid.Text);
            al.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ranevu başaıyla alındı");
            
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            int sec = dataGridView2.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView2.Rows[sec].Cells[0].Value.ToString();
        }
    }
}
