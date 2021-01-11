using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon
{
    public class KHACHHANG
    {
        public string MAKH { get; set; }
        public string TENKH { get; set; }
        public string GIOITINH { get; set; }
        public string DIACHI { get; set; }
        public string DIENTHOAI { get; set; }
        public LOAIKHACHHANG loaikhachhang { get; set; }
        public KHACHHANG(string MAKH,string TENKH, string GIOITINH , string DIACHI , string DIENTHOAI , LOAIKHACHHANG x)
        {
            this.MAKH = MAKH;
            this.TENKH = TENKH;
            this.GIOITINH = GIOITINH;
            this.DIACHI = DIACHI;
            this.DIENTHOAI = DIENTHOAI;
            this.loaikhachhang = x;
        }
        public KHACHHANG(KHACHHANG x)
        {
            this.MAKH = x.MAKH;
            this.TENKH = x.TENKH;
            this.GIOITINH = x.GIOITINH;
            this.DIACHI = x.DIACHI;
            this.DIENTHOAI = x.DIENTHOAI;
            this.loaikhachhang = x.loaikhachhang;
        }
    }
}
