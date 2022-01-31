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
    public partial class hastakayit : Form
    {
        public hastakayit()
        {
            InitializeComponent();
        }
        sqlbaglanti baglan = new sqlbaglanti();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_hasta (hasta_ad,hasta_soyad,hasta_tc,hasta_telefon,hasta_sifre,hasta_cinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglan.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_ad.Text);
            komut.Parameters.AddWithValue("@p2", txt_soyad.Text);
            komut.Parameters.AddWithValue("@p3", msk_tc_no.Text);
            komut.Parameters.AddWithValue("@p4", msk_tel_no.Text);
            komut.Parameters.AddWithValue("@p5", txt_sifre.Text);
            komut.Parameters.AddWithValue("@p6", cmb_cinsiyet.Text);
            komut.ExecuteNonQuery();

            baglan.baglanti().Close();

            MessageBox.Show("Hasta kaydedildi!");

        }

        private void hastakayit_Load(object sender, EventArgs e)
        {
            cmb_cinsiyet.Items.Add("Erkek");
            cmb_cinsiyet.Items.Add("Kadin");
        }
    }
}
