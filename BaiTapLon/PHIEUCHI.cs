using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon
{
    public class PHIEUCHI
    {
        public string MAPHIEUCHI { get; set; }
        public HOPDONGCUNGCAP hopdongcungcap { get; set; }
        public NHANVIEN NhanVien { get; set; }
        public string NGAYLAPPC { get; set; }
        public int SOTIENCHI { get; set; }
        public PHIEUCHI(string MAPHIEUCHI , HOPDONGCUNGCAP hopdongcungcap,NHANVIEN NhanVien , string NGAYLAPPC, int SOTIENCHI)
        {
            this.MAPHIEUCHI = MAPHIEUCHI;
            this.hopdongcungcap = hopdongcungcap;
            this.NhanVien = NhanVien;
            this.NGAYLAPPC = NGAYLAPPC;
            this.SOTIENCHI = SOTIENCHI;
        }
        public PHIEUCHI(PHIEUCHI x)
        {
            this.MAPHIEUCHI = x.MAPHIEUCHI;
            this.hopdongcungcap = x.hopdongcungcap;
            this.NhanVien = x.NhanVien;
            this.NGAYLAPPC = x.NGAYLAPPC;
            this.SOTIENCHI = x.SOTIENCHI;
        }

    }
}
