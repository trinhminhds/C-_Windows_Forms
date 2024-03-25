using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyNhanVien
{
    class Connection
    {
        private static string stringConnection = @"Data Source=DESKTOP-PKBG0MG;Initial Catalog=QLNHANVIENJAVA;Integrated Security=True";
        public static SqlConnection getConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }

}
