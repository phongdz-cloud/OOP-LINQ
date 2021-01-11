using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon
{
    public class NHANVIEN
    {
        public string MANV { get; set; }
        public string HOTEN { get; set; }
        public string GIOITINH { get; set; }
        public string NGAYSINH { get; set; }
        public string DIACHI { get; set; }
        public string DIENTHOAI { get; set; }
        public string NGAYVAOLAM { get; set; }
        public string GHICHU { get; set; }
        public NHANVIEN(string MANV, string HOTEN , string GIOITINH , string NGAYSINH , string DIACHI, string DIENTHOAI
            ,string NGAYVAOLAM, string GHICHU)
        {
            this.MANV = MANV;
            this.HOTEN = HOTEN;
            this.GIOITINH = GIOITINH;
            this.NGAYSINH = NGAYSINH;
            this.DIACHI = DIACHI;
            this.DIENTHOAI = DIENTHOAI;
            this.NGAYVAOLAM = NGAYVAOLAM;
            this.GHICHU = GHICHU;
        }
        public NHANVIEN(NHANVIEN x)
        {
            this.MANV = x.MANV;
            this.HOTEN = x.HOTEN;
            this.GIOITINH = x.GIOITINH;
            this.NGAYSINH = x.NGAYSINH;
            this.DIACHI = x.DIACHI;
            this.DIENTHOAI = x.DIENTHOAI;
            this.NGAYVAOLAM = x.NGAYVAOLAM;
            this.GHICHU = x.GHICHU;
        }
    }
}
