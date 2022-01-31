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
    public partial class hastagiris : Form
    {
        public hastagiris()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();

        private void lnk_kayit_ol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hastakayit fr = new hastakayit();
            fr.Show();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_hasta where hasta_tc=@p1 and hasta_sifre=@p2", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", msk_tc_no.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);



            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                hastadetay fr = new hastadetay();
                fr.tc = msk_tc_no.Text;

                fr.Show();

    
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya SİFRE!");
            }

            bgl.baglanti().Close();

        }
    }
}
