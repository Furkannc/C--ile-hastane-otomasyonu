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
    public partial class frmbilgiduzenle : Form
    {
        public frmbilgiduzenle()
        {
            InitializeComponent();
        }
        public string tcno;

        sqlbaglanti bgl = new sqlbaglanti();
        private void frmbilgiduzenle_Load(object sender, EventArgs e)
        {
            msktc.Text = tcno;
            SqlCommand komut = new SqlCommand("select * from tbl_hasta where hasta_tc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
           
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txt_ad.Text = dr[1].ToString();
                txt_soyad.Text = dr[2].ToString();
                msk_tel_no.Text = dr[4].ToString();
                txt_sifre.Text = dr[5].ToString();
                cmb_cinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();

        }

        private void btngilgiduzenle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_hasta set hasta_ad=@p1,hasta_soyad=@p2,hasta_telefon=@p4,hasta_sifre=@p5,hasta_cinsiyet=@p6 where hasta_tc=@p", bgl.baglanti());
            komut.Parameters.AddWithValue("@p", msktc.Text);
            komut.Parameters.AddWithValue("@p1", txt_ad.Text);
            komut.Parameters.AddWithValue("@p2", txt_soyad.Text);
            komut.Parameters.AddWithValue("@p4", msk_tel_no.Text);
            komut.Parameters.AddWithValue("@p5", txt_sifre.Text);
            komut.Parameters.AddWithValue("@p6",cmb_cinsiyet.Text);
            komut.ExecuteNonQuery();

            bgl.baglanti().Close();

            MessageBox.Show("Veriler güncellendi!");
           
        }
    }
}
