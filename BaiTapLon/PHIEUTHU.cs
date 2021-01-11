using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon
{
    public class PHIEUTHU
    {
        public string MAPHIEUTHU { get; set; }
        public string NGAYTHU { get; set; }
        public int SOTIENTHU { get; set; }
        public DONDATHANG dondathang { get; set; }
        public PHIEUTHU(string MAPHIEUTHU,string NGAYTHU , int SOTIENTHU , DONDATHANG x)
        {
            this.MAPHIEUTHU = MAPHIEUTHU;
            this.NGAYTHU = NGAYTHU;
            this.SOTIENTHU = SOTIENTHU;
            this.dondathang = x;
        }
        public PHIEUTHU(PHIEUTHU x)
        {
            this.MAPHIEUTHU = x.MAPHIEUTHU;
            this.NGAYTHU = x.NGAYTHU;
            this.SOTIENTHU = x.SOTIENTHU;
            this.dondathang = x.dondathang;
        }
    }
}
