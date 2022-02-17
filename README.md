# **Kullanımı**

######  1. Veri tabanı oluştur
![enter image description here](https://github.com/Furkannc/C--ile-hastane-otomasyonu/blob/main/hastane_otomasyon/database.png?raw=true)
######  2. sqlbaglanti.cs dosyasını düzenle
`

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
    }`
	
###### 3. database değişkenine kendi veri tabanı adresinizi verin

       string database = "BURAYA";
	 
###### 4. Kullanmaya hazırsınız
