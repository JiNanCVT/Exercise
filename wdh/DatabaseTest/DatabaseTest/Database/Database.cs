using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTest.Database
{
  public  class Database
    {
      /*
         返回连接字符串
       */
      public static SqlConnection CreateConnection()
      {
          return new SqlConnection(@"Data Source=WDH\SQLEXP;Initial Catalog=xwzsql1;Integrated Security=True");
      }
    }
}
