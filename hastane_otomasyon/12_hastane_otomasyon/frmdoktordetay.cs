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
    public partial class frmdoktordetay : Form
    {
        public frmdoktordetay()
        {
            InitializeComponent();
        }
        public string tc;
        sqlbaglanti bg = new sqlbaglanti();
        private void frmdoktordetay_Load(object sender, EventArgs e)
        {
            lbltcno.Text = tc;
            SqlCommand ad = new SqlCommand("select (doktor_ad+' '+doktor_soyad) from tbl_doktor where doktor_tc=@p1 ",bg.baglanti());
            ad.Parameters.AddWithValue("@p1", tc);
            SqlDataReader dr = ad.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0].ToString();
            }
       
            bg.baglanti().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevu where randevu_doktor='"+lbladsoyad.Text+"'",bg.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void btnduyrular_Click(object sender, EventArgs e)
        {
            frmduyrular dr = new frmduyrular();
            dr.Show();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            frmdoktorgiris gr = new frmdoktorgiris();
            gr.Show();
            this.Close();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            
            frmdoktorblgduzenle d = new frmdoktorblgduzenle();
            d.tc = lbltcno.Text;
            d.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            rxhsikayet.Text = dataGridView1.Rows[sec].Cells[7].Value.ToString();
        }
    }
}
