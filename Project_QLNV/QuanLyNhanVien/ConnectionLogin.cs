using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace QuanLyNhanVien
{
    class ConnectionLogin
    {
        
        
            private static string stringConnectionLogin = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C_Shap\Project_QLNV\QuanLyNhanVien\DatabaseQLNV.mdf;Integrated Security=True";
            public static SqlConnection getConnectionLogin()
            {
                return new SqlConnection(stringConnectionLogin);
            }
        

    }
}
