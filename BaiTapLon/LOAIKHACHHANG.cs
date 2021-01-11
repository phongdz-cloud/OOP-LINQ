using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon
{
    public class LOAIKHACHHANG
    {
        public string MALOAIKH { get; set; }
        public string TENLOAI { get; set; }
        public LOAIKHACHHANG(string MALOAIKH , string TENLOAI)
        {
            this.MALOAIKH = MALOAIKH;
            this.TENLOAI = TENLOAI;
        }
        public LOAIKHACHHANG(LOAIKHACHHANG x)
        {
            this.MALOAIKH = x.MALOAIKH;
            this.TENLOAI = x.TENLOAI;
        }
    }
}
