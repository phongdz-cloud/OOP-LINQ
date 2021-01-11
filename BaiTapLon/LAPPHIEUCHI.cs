using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon
{
    public class LAPPHIEUCHI
    {
        public PHIEUCHI phieuchi { get; set; }
        public NHANVIEN nhanvien { get; set; }
        public string NGAYLAPPC { get; set; }
        public int SOTIENCHI { get; set; }
        public LAPPHIEUCHI(PHIEUCHI phieuchi, NHANVIEN nhanvien , string NGAYLAPPC, int SOTIENCHI)
        {
            this.phieuchi = phieuchi;
            this.nhanvien = nhanvien;
            this.NGAYLAPPC = NGAYLAPPC;
            this.SOTIENCHI = SOTIENCHI;
        }
        public LAPPHIEUCHI(LAPPHIEUCHI x)
        {
            this.phieuchi = x.phieuchi;
            this.nhanvien = x.nhanvien;
            this.NGAYLAPPC = x.NGAYLAPPC;
            this.SOTIENCHI = x.SOTIENCHI;
        }
    }
}
