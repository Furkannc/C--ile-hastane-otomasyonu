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
    public partial class frmdoktorblgduzenle : Form
    {
        public frmdoktorblgduzenle()
        {
            InitializeComponent();
        }
        sqlbaglanti bg = new sqlbaglanti();
        public string tc;
        private void frmdoktorblgduzenle_Load(object sender, EventArgs e)
        {
            msk_tc_no.Text = tc;

            SqlCommand km = new SqlCommand("select doktor_ad,doktor_soyad,doktor_brans,doktor_sifre from tbl_doktor where doktor_tc=@p1",bg.baglanti());
            km.Parameters.AddWithValue("@p1", msk_tc_no.Text);
            SqlDataReader dr = km.ExecuteReader();
            while (dr.Read())
            {
                txt_ad.Text = dr[0].ToString();
                txt_soyad.Text = dr[1].ToString();
                cmbbrans.Text = dr[2].ToString();
                txt_sifre.Text = dr[3].ToString();
            }
            bg.baglanti().Close();



           
        }

        

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand km = new SqlCommand("update tbl_doktor set doktor_ad=@p1,doktor_soyad=@p2,doktor_brans=@p3,doktor_sifre=@p4 where doktor_tc=@p5",bg.baglanti());
            km.Parameters.AddWithValue("@p1",txt_ad.Text);
            km.Parameters.AddWithValue("@p2", txt_soyad.Text);
            km.Parameters.AddWithValue("@p3", cmbbrans.Text);
            km.Parameters.AddWithValue("@p4", txt_sifre.Text);
            km.Parameters.AddWithValue("@p5", msk_tc_no.Text);
            km.ExecuteNonQuery();
            bg.baglanti().Close();
            MessageBox.Show("Bilgiler güncellendi !");
        }

        private void cmbbrans_Click(object sender, EventArgs e)
        {
            cmbbrans.Items.Clear();


            SqlCommand km = new SqlCommand("select brans_ad from tbl_brans",bg.baglanti());
            SqlDataReader dr =km.ExecuteReader();
            while (dr.Read())
            {
                cmbbrans.Items.Add(dr[0].ToString());
            }
        }
    }
}
