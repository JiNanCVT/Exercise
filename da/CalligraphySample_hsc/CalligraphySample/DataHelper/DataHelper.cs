﻿using System;
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
            return new SqlConnection(@"Data Source=HSC_win8;Initial Catalog=CalligraphyTeaching;Persist Security Info=True;User ID=sa;Password=0663");
        }
    }
}
