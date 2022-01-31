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
    public partial class frmsekreterdetay : Form
    {
        public frmsekreterdetay()
        {
            InitializeComponent();
        }
        public string tc;
        sqlbaglanti bgl = new sqlbaglanti();

        

        private void frmsekreterdetay_Load(object sender, EventArgs e)
        {
            //labela ad,soyad verme

            lbltcno.Text = tc;
            SqlCommand komut1 = new SqlCommand("select sekreter_ad_soyad from tbl_sekreter where sekreter_tc=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", lbltcno.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lbladsoyad.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();
            ///////////////////////////////////////////////////tabloya a brans ekleme
            ///
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_brans",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            /////////////////////////////////////// combo box a doktor ekleme
            ///
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select (doktor_ad+' '+doktor_soyad) as 'doktorlar',doktor_brans from tbl_doktor",bgl.baglanti());
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;
            ///////////////////////////////
            ///
            SqlCommand brans = new SqlCommand("select brans_ad from tbl_brans",bgl.baglanti());
            SqlDataReader br = brans.ExecuteReader();
            while (br.Read())
            {
                cmb_brans.Items.Add(br[0].ToString());
            }
            ///////////////////////
            ///
        
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand kaydet = new SqlCommand("insert into tbl_randevu (randevu_tarih,randevu_saat,randevu_brans,randevu_doktor,hasta_tc) values (@p1,@p2,@p3,@p4,@p5)",bgl.baglanti());
            kaydet.Parameters.AddWithValue("@p1", msk_tarih.Text);
            kaydet.Parameters.AddWithValue("@p2", msk_saat.Text);
            kaydet.Parameters.AddWithValue("@p3", cmb_brans.Text);
            kaydet.Parameters.AddWithValue("@p4", cmb_doktor.Text);
            kaydet.Parameters.AddWithValue("@p5", msk_tc.Text);

            kaydet.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Randevu oluşturuldu!");
        }

       

        private void cmb_brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_doktor.Items.Clear();
            SqlCommand doktor = new SqlCommand("select (doktor_ad+ ' '+doktor_soyad) from tbl_doktor where doktor_brans=@p1 ", bgl.baglanti());
            doktor.Parameters.AddWithValue("@p1", cmb_brans.Text);
            SqlDataReader dk = doktor.ExecuteReader();
            while (dk.Read())
            {
                cmb_doktor.Items.Add(dk[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void btnrandevuliste_Click(object sender, EventArgs e)
        {
            frmrandevulist rl = new frmrandevulist();
            rl.Show();
        }

        private void btnduyuruol_Click(object sender, EventArgs e)
        {
            SqlCommand duy = new SqlCommand("insert into tbl_duyuru (duyuru) values (@p1)",bgl.baglanti());
            duy.Parameters.AddWithValue("@p1", richduyuru.Text);
            duy.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Duyuru başarıyla yayımlandı!");
        }

        private void btndoktorpanel_Click(object sender, EventArgs e)
        {
            frmdoktorpanel drp = new frmdoktorpanel();
            drp.Show();
        }

        private void btnbranspanel_Click(object sender, EventArgs e)
        {
            frmbrans fr = new frmbrans();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmduyrular fr = new frmduyrular();
            fr.Show();
        }
    }
}
