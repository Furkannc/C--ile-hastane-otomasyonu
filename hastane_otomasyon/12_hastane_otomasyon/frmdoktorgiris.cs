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
    public partial class frmdoktorgiris : Form
    {
        public frmdoktorgiris()
        {
            InitializeComponent();
        }
        sqlbaglanti bg = new sqlbaglanti();

        

        private void btn_giris_Click(object sender, EventArgs e)
        {
            frmdoktordetay fr = new frmdoktordetay();
            fr.tc = msk_tc_no.Text;
            

            SqlCommand gir = new SqlCommand("select * from tbl_doktor where doktor_tc=@p1 and doktor_sifre=@p1", bg.baglanti());
            gir.Parameters.AddWithValue("@p1", msk_tc_no.Text);
            gir.Parameters.AddWithValue("@p2", txtsifre.Text);

            SqlDataReader dr = gir.ExecuteReader();
            if (dr.Read())
            {

            
            fr.Show();
            dr.Read();
            this.Hide();
            
            }
            else
            {
                MessageBox.Show("Hatali tc no veya şifre");
            }
            
        }
    }
}
