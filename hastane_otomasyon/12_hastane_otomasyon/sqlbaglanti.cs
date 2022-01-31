using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _12_hastane_otomasyon
{
    class sqlbaglanti
    {
        public SqlConnection baglanti()
        {
            string database = "Data Source=DESKTOP-0SJFNV5\\SQLEXPRESS;Initial Catalog=ornek_db;Integrated Security=True";
            SqlConnection baglan = new SqlConnection(database);
            baglan.Open();
            return baglan;
        }

    }
}
