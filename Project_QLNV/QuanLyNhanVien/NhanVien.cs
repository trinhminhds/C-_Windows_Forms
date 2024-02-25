using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien
{
    class NhanVien
    {
        private string manv;
        private string name;
        private string gt;
        private DateTime ngaySinh;
        private int luong;
        private string maph;
        private string sdt;
        private DateTime ngayBC;

        public NhanVien()
        {
        }

        public NhanVien(string manv, string name, string gt, DateTime ngaySinh, int luong, string maph, string sdt, DateTime ngayBC)
        {
            this.manv = manv;
            this.name = name;
            this.gt = gt;
            this.ngaySinh = ngaySinh;
            this.luong = luong;
            this.maph = maph;
            this.sdt = sdt;
            this.ngayBC = ngayBC;
        }

        public string Manv { get => manv; set => manv = value; }
        public string Name { get => name; set => name = value; }
        public string Gt { get => gt; set => gt = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public int Luong { get => luong; set => luong = value; }
        public string Maph { get => maph; set => maph = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public DateTime NgayBC { get => ngayBC; set => ngayBC = value; }
    }
}
