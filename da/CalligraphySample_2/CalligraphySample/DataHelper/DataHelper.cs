using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CalligraphySample.DataHelper
{
    public static class DataHelper
    {
        public static SqlConnection CreateConnection()
        {
            return new SqlConnection(@"Data Source=da\sqlexpress;Initial Catalog=Calligrapher;Integrated Security=True");
        }
    }
}
