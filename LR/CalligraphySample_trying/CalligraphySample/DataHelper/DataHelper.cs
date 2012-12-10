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
            return new SqlConnection(@"Data Source=WIN-20120318IAK\LR;Initial Catalog=LR_test;Integrated Security=True");
        }
    }
}
