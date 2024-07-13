using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection_Sql_Server
{
    internal class Connection
    {
        private static string stringConnection = @"Data Source=DESKTOP-PKBG0MG;Initial Catalog=QLSINHVIEN;Integrated Security=True";
        public static SqlConnection getConnection()
        {
            return new SqlConnection(stringConnection);
        }
        
    }
}
