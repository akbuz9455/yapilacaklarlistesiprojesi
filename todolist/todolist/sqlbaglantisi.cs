using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sql kütüphanelerini ekledik
using System.Data;
using System.Data.SqlClient;

namespace todolist
{
    class sqlbaglantisi
    {
        public SqlConnection baglan()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=.; initial Catalog=todolist; Integrated Security=true");
            baglanti.Open();
            SqlConnection.ClearPool(baglanti);
            SqlConnection.ClearAllPools();
            return (baglanti);
        }

    }
}
