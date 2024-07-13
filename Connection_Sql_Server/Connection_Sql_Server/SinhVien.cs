using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection_Sql_Server
{
    class SinhVien
    {
      
        private string masv;
        private string hoTen;
        private DateTime ngaySinh;
        private string makhoa;

        public SinhVien()
        {
        }

        public SinhVien(string masv, string hoTen, DateTime ngaySinh, string makhoa)  
        {
            this.masv = masv;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.makhoa = makhoa;
        }

        public string Masv { get => masv; set => masv = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value;}
        public string MaKhoa { get => makhoa; set => makhoa = value; }


    }
}
