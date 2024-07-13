using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    class NhanVien_add
    {
        private string manv;
        private string ho;
        private string ten;
        private string gioiTinh;
        private DateTime ngaySinh;
        private string diachi;
        private string sdt;
        private string chucVu;

        public NhanVien_add()
        {
        }

        public NhanVien_add(string manv, string ho, string ten, DateTime ngaySinh,string gioiTinh, string diachi, string sdt, string chucVu)
        {
            this.manv = manv;
            this.ho = ho;
            this.ten = ten;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.diachi = diachi;
            this.sdt = sdt;
            this.chucVu = chucVu;
        }


        public string Manv { get => manv; set => manv = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Ho { get => ho; set => ho = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh= value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Chucvu { get => chucVu; set => chucVu = value; }
    
    }



    class NhanVien_salary
    {
        private string manv;
        private string ho;
        private string ten;
        private int luong;
        private string chucVu;

        public NhanVien_salary()
        {
        }

        public NhanVien_salary(string manv, string ho, string ten, int luong, string chucVu)
        {
            this.manv = manv;
            this.ho = ho;
            this.ten = ten;
            this.luong = luong;
            this.chucVu = chucVu;
        }

        public string Manv { get => manv; set => manv = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Ho { get => ho; set => ho = value; }
        public int Luong { get => luong; set => luong = value; }
        public string Chucvu { get => chucVu; set => chucVu = value; }

    }
}
