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
    public partial class frmsekretergiris : Form
    {
        public frmsekretergiris()
        {
            InitializeComponent();
        }

        
        sqlbaglanti bgl = new sqlbaglanti();

        private void btn_giris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_sekreter where sekreter_tc=@p1 and sekreter_sifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msk_tc_no.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            
            SqlDataReader dr = komut.ExecuteReader();
            
            if (dr.Read())
            {
                frmsekreterdetay fr = new frmsekreterdetay();
                fr.tc = msk_tc_no.Text;
                fr.Show();
            
            }
            bgl.baglanti().Close();
            ///////////////////////////////////////////////////////
            

        }

    }
}
