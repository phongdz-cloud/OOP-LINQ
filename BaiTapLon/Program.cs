using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon
{
    class Program
    {
        // Danh sách sinh viên
        // 19110262 - Hồ Hoài Phong
        // 19110012 - Trần Lê Thanh Tuyền
        static List<LOAIKHACHHANG> DSLoaiKhachHang = new List<LOAIKHACHHANG>();
        static List<KHACHHANG> DSKhachHang = new List<KHACHHANG>();
        static List<DONDATHANG> DSDonDatHang = new List<DONDATHANG>();
        static List<PHIEUTHU> DSPhieuThu = new List<PHIEUTHU>();
        static List<PHIEUGIAOHANG> DSPhieuGiaoHang = new List<PHIEUGIAOHANG>();
        static List<NHOMSANPHAM> DSNhomSanPham = new List<NHOMSANPHAM>();
        static List<SANPHAM> DSSanPham = new List<SANPHAM>();
        static List<CHITIET_DDH> DSChiTiet_DDH = new List<CHITIET_DDH>();
        static List<CHITIET_PGH> DSChiTiet_PGH = new List<CHITIET_PGH>();
        static List<NHACUNGCAP> DSNhaCungCap = new List<NHACUNGCAP>();
        static List<HOPDONGCUNGCAP> DSHopDongCungCap = new List<HOPDONGCUNGCAP>();
        static List<CHITIET_HDCCAP> DSChiTiet_HDCCAP = new List<CHITIET_HDCCAP>();
        static List<NHANVIEN> DSNhanVien = new List<NHANVIEN>();
        static List<PHIEUCHI> DSPhieuChi = new List<PHIEUCHI>();
        public static void TaoDanhSachLoaiKhachHang()
        {
            DSLoaiKhachHang.Add(new LOAIKHACHHANG("LKH01", "Vang"));
            DSLoaiKhachHang.Add(new LOAIKHACHHANG("LKH02", "Bach Kim"));
            DSLoaiKhachHang.Add(new LOAIKHACHHANG("LKH03", "Kim Cuong"));
            DSLoaiKhachHang.Add(new LOAIKHACHHANG("LKH04", "dgvdv"));
            DSLoaiKhachHang.Add(new LOAIKHACHHANG("LKH05", "dgvdv"));
        }
        public static void TaoDanhSachKhangHang()
        {
            DSKhachHang.Add(new KHACHHANG("KH001", "Tran Huu Han", "Nam", "12 Minh Phung Q11", "0770990033", DSLoaiKhachHang[0]));
            DSKhachHang.Add(new KHACHHANG("KH002", "Nguyen Thi Hoan", "Nu", "Ba Ria Vung Tau", "0902382103", DSLoaiKhachHang[1]));
            DSKhachHang.Add(new KHACHHANG("KH003", "Cao Tien Quan", "Nam", "7 Le Lai Q1", "077392013", DSLoaiKhachHang[1]));
            DSKhachHang.Add(new KHACHHANG("KH004", "Cao Nhat Minh", "Nam", "454 Bui Huu Nghia Q5", "0990435332", DSLoaiKhachHang[1]));
            DSKhachHang.Add(new KHACHHANG("KH005", "Nguyen Chi Trung", "Nam", "122/3 Minh Phung Q11", "05502832013", DSLoaiKhachHang[2]));
            DSKhachHang.Add(new KHACHHANG("KH006", "Nguyen Quoc Thang", "Nam", "54/35 Binh Thoi Q11", "0880990011", DSLoaiKhachHang[2]));
            DSKhachHang.Add(new KHACHHANG("KH007", "Cao Le My Vy", "Nu", "68 Han Hai Nguyen", "0937485213", DSLoaiKhachHang[2]));
            DSKhachHang.Add(new KHACHHANG("KH008", "Ho Hoai Phong", "Nam", "63/6 Cao Ba Quat", "0375489103", DSLoaiKhachHang[2]));
            DSKhachHang.Add(new KHACHHANG("KH009", "Ho Hoai Phuong", "Nam", "14/44 Tran Binh Trong Q5", "0913782103", DSLoaiKhachHang[0]));
            DSKhachHang.Add(new KHACHHANG("KH010", "Lam A Han", "Nu", "321 Ba Huyen Thanh Quan Q3", "0967738312", DSLoaiKhachHang[1]));
            DSKhachHang.Add(new KHACHHANG("KH011", "Tran Le Thanh Tuyen", "Nu", "2 Tran Binh trong Q5", "0137889213", DSLoaiKhachHang[2]));
            DSKhachHang.Add(new KHACHHANG("KH012", "Tran Thi Khanh Linh", "Nu", "27/4 Le Thi Hoa", "0893218328", DSLoaiKhachHang[1]));
            DSKhachHang.Add(new KHACHHANG("KH013", " Nguyen Tran Huu Hoan", "Nam", "26/3 Linh Trung Thu Duc", "0993376129", DSLoaiKhachHang[2]));
            DSKhachHang.Add(new KHACHHANG("KH014", "Nguyen Thi Hong Tam", "Nu", "165/8 Duong Le Van Dong", "0887796251", DSLoaiKhachHang[1]));
            DSKhachHang.Add(new KHACHHANG("KH015", "Nguyen Cat Tuong Vy", "Nu", "68/6 Le Thi Hoa", "0902382103", DSLoaiKhachHang[0]));
            DSKhachHang.Add(new KHACHHANG("KH016", "Luu Huyen Linh", "Nam", "455/432 Ba Hat Q10", "0912486703", DSLoaiKhachHang[2]));
            DSKhachHang.Add(new KHACHHANG("KH017", "Ninh Van Nhat", "Nam", "78/6 Pham Ngu Lao", "0937070213", DSLoaiKhachHang[1]));
            DSKhachHang.Add(new KHACHHANG("KH018", "Doan Thanh Nam", "Nam", "96/8 Le Quy Don", "0908797923", DSLoaiKhachHang[2]));
            DSKhachHang.Add(new KHACHHANG("KH019", "Le Tu Phuong", "Nam", "86/7 Tran Quan Khai", "0375988077", DSLoaiKhachHang[0]));
            DSKhachHang.Add(new KHACHHANG("KH020", "Hoang Trung Nhat", "Nam", "12/14 Tran Van Quan", "0907083327", DSLoaiKhachHang[0]));
        }
        public static void TaoDanhSachDonDatHang()
        {
            DSDonDatHang.Add(new DONDATHANG("MADDH01", "", DSKhachHang[0]));
            DSDonDatHang.Add(new DONDATHANG("MADDH02", "Tat ca thung deu mau hong", DSKhachHang[1]));
            DSDonDatHang.Add(new DONDATHANG("MADDH03", "Tat ca thung deu mau den", DSKhachHang[0]));
            DSDonDatHang.Add(new DONDATHANG("MADDH04", "", DSKhachHang[2]));
            DSDonDatHang.Add(new DONDATHANG("MADDH05", "Thung hang in hinh con ca", DSKhachHang[3]));
            DSDonDatHang.Add(new DONDATHANG("MADDH06", "", DSKhachHang[3]));
            DSDonDatHang.Add(new DONDATHANG("MADDH07", "", DSKhachHang[4]));
            DSDonDatHang.Add(new DONDATHANG("MADDH08", "", DSKhachHang[4]));
            DSDonDatHang.Add(new DONDATHANG("MADDH09", "", DSKhachHang[5]));
            DSDonDatHang.Add(new DONDATHANG("MADDH10", "Thung hang khong duoc mau trang", DSKhachHang[6]));
            DSDonDatHang.Add(new DONDATHANG("MADDH11", "", DSKhachHang[6]));
            DSDonDatHang.Add(new DONDATHANG("MADDH12", "", DSKhachHang[7]));
            DSDonDatHang.Add(new DONDATHANG("MADDH13", "Moi san pham bo rieng 1 thung", DSKhachHang[8]));
            DSDonDatHang.Add(new DONDATHANG("MADDH14", "Moi san pham co giay kinh bao xung quanh", DSKhachHang[9]));
            DSDonDatHang.Add(new DONDATHANG("MADDH15", "", DSKhachHang[9]));
            DSDonDatHang.Add(new DONDATHANG("MADDH16", "", DSKhachHang[10]));
            DSDonDatHang.Add(new DONDATHANG("MADDH17", "", DSKhachHang[11]));
            DSDonDatHang.Add(new DONDATHANG("MADDH18", "Tat ca thung hang deu mau vang", DSKhachHang[11]));
            DSDonDatHang.Add(new DONDATHANG("MADDH19", "Hang khong can bo trong thung", DSKhachHang[12]));
            DSDonDatHang.Add(new DONDATHANG("MADDH20", "", DSKhachHang[13]));
            DSDonDatHang.Add(new DONDATHANG("MADDH21", "Thung hang in hinh Happy New Year", DSKhachHang[14]));
            DSDonDatHang.Add(new DONDATHANG("MADDH22", "", DSKhachHang[15]));
            DSDonDatHang.Add(new DONDATHANG("MADDH23", "", DSKhachHang[15]));
            DSDonDatHang.Add(new DONDATHANG("MADDH24", "Giay goi hang la bia cung", DSKhachHang[16]));
            DSDonDatHang.Add(new DONDATHANG("MADDH25", "", DSKhachHang[17]));
            DSDonDatHang.Add(new DONDATHANG("MADDH26", "", DSKhachHang[18]));
            DSDonDatHang.Add(new DONDATHANG("MADDH27", "", DSKhachHang[18]));
            DSDonDatHang.Add(new DONDATHANG("MADDH28", "", DSKhachHang[19]));
            DSDonDatHang.Add(new DONDATHANG("MADDH29", "Moi thung hang kem bao ni long", DSKhachHang[11]));
            DSDonDatHang.Add(new DONDATHANG("MADDH30", "a", DSKhachHang[13]));
        }
        public static void TaoDanhSachPhieuThu()
        {
            DSPhieuThu.Add(new PHIEUTHU("MPT01", "19/08/2006", 300000, DSDonDatHang[0]));
            DSPhieuThu.Add(new PHIEUTHU("MPT02", "13/08/2013", 500000, DSDonDatHang[0]));
            DSPhieuThu.Add(new PHIEUTHU("MPT03", "14/07/2006", 2000000, DSDonDatHang[1]));
            DSPhieuThu.Add(new PHIEUTHU("MPT04", "17/06/2017", 800000, DSDonDatHang[2]));
            DSPhieuThu.Add(new PHIEUTHU("MPT05", "28/02/2020", 900000, DSDonDatHang[2]));
            DSPhieuThu.Add(new PHIEUTHU("MPT06", "19/05/2020", 1000000, DSDonDatHang[3]));
            DSPhieuThu.Add(new PHIEUTHU("MPT07", "2/03/2006", 2000000, DSDonDatHang[4]));
            DSPhieuThu.Add(new PHIEUTHU("MPT08", "22/01/2020", 150000, DSDonDatHang[5]));
            DSPhieuThu.Add(new PHIEUTHU("MPT09", "11/08/2012", 300000, DSDonDatHang[6]));
            DSPhieuThu.Add(new PHIEUTHU("MPT10", "13/08/2006", 400000, DSDonDatHang[7]));
            DSPhieuThu.Add(new PHIEUTHU("MPT11", "22/07/2020", 170000, DSDonDatHang[7]));
            DSPhieuThu.Add(new PHIEUTHU("MPT12", "1/08/2013", 185000, DSDonDatHang[8]));
            DSPhieuThu.Add(new PHIEUTHU("MPT13", "6/08/2020", 350000, DSDonDatHang[8]));
            DSPhieuThu.Add(new PHIEUTHU("MPT14", "29/08/2020", 550000, DSDonDatHang[9]));
            DSPhieuThu.Add(new PHIEUTHU("MPT15", "7/02/2014", 650000, DSDonDatHang[10]));
            DSPhieuThu.Add(new PHIEUTHU("MPT16", "7/09/2015", 570000, DSDonDatHang[11]));
            DSPhieuThu.Add(new PHIEUTHU("MPT17", "8/03/2019", 300000, DSDonDatHang[12]));
            DSPhieuThu.Add(new PHIEUTHU("MPT18", "9/03/2019", 750000, DSDonDatHang[13]));
            DSPhieuThu.Add(new PHIEUTHU("MPT19", "22/04/2006", 850000, DSDonDatHang[14]));
            DSPhieuThu.Add(new PHIEUTHU("MPT20", "15/03/2018", 650000, DSDonDatHang[15]));
            DSPhieuThu.Add(new PHIEUTHU("MPT21", "6/02/2006", 550000, DSDonDatHang[14]));
            DSPhieuThu.Add(new PHIEUTHU("MPT22", "27/08/2017", 850000, DSDonDatHang[16]));
            DSPhieuThu.Add(new PHIEUTHU("MPT23", "17/04/2020", 750000, DSDonDatHang[11]));
            DSPhieuThu.Add(new PHIEUTHU("MPT24", "22/01/2006", 750000, DSDonDatHang[17]));
            DSPhieuThu.Add(new PHIEUTHU("MPT25", "22/04/2014", 775000, DSDonDatHang[18]));
            DSPhieuThu.Add(new PHIEUTHU("MPT26", "22/04/2015", 772000, DSDonDatHang[19]));
            DSPhieuThu.Add(new PHIEUTHU("MPT27", "12/01/2020", 765000, DSDonDatHang[20]));
            DSPhieuThu.Add(new PHIEUTHU("MPT28", "26/03/2020", 750200, DSDonDatHang[21]));
            DSPhieuThu.Add(new PHIEUTHU("MPT29", "16/04/2020", 553000, DSDonDatHang[22]));
            DSPhieuThu.Add(new PHIEUTHU("MPT30", "12/08/2006", 520300, DSDonDatHang[23]));
            DSPhieuThu.Add(new PHIEUTHU("MPT31", "7/08/2020", 300000, DSDonDatHang[24]));
            DSPhieuThu.Add(new PHIEUTHU("MPT32", "14/08/2017", 750000, DSDonDatHang[25]));
            DSPhieuThu.Add(new PHIEUTHU("MPT33", "16/07/2006", 650000, DSDonDatHang[26]));
            DSPhieuThu.Add(new PHIEUTHU("MPT34", "12/01/2020", 765000, DSDonDatHang[27]));
            DSPhieuThu.Add(new PHIEUTHU("MPT35", "11/02/2017", 634050, DSDonDatHang[28]));
            DSPhieuThu.Add(new PHIEUTHU("MPT36", "2/08/2006", 500000, DSDonDatHang[29]));
            DSPhieuThu.Add(new PHIEUTHU("MPT37", "19/10/2020", 735000, DSDonDatHang[27]));

        }
        public static void TaoDanhSachPhieuGiaoHang()
        {
            DSPhieuGiaoHang.Add(new PHIEUGIAOHANG("MPGH01", "Tranh giao vao buoi toi", DSDonDatHang[0]));
            DSPhieuGiaoHang.Add(new PHIEUGIAOHANG("MPGH02", "", DSDonDatHang[1]));
            DSPhieuGiaoHang.Add(new PHIEUGIAOHANG("MPGH03", "", DSDonDatHang[2]));
            DSPhieuGiaoHang.Add(new PHIEUGIAOHANG("MPGH04", "Hang de vo! Xin nhe tay", DSDonDatHang[3]));
            DSPhieuGiaoHang.Add(new PHIEUGIAOHANG("MPGH05", "Hang giao khong duoc tray xuoc", DSDonDatHang[4]));
            DSPhieuGiaoHang.Add(new PHIEUGIAOHANG("MPGH06", "", DSDonDatHang[5]));
            DSPhieuGiaoHang.Add(new PHIEUGIAOHANG("MPGH07", "", DSDonDatHang[6]));
            DSPhieuGiaoHang.Add(new PHIEUGIAOHANG("MPGH08", "", DSDonDatHang[7]));
            DSPhieuGiaoHang.Add(new PHIEUGIAOHANG("MPGH09", "Chi giao hang vao buoi trua", DSDonDatHang[8]));
            DSPhieuGiaoHang.Add(new PHIEUGIAOHANG("MPGH10", "", DSDonDatHang[9]));
            DSPhieuGiaoHang.Add(new PHIEUGIAOHANG("MPGH11", "", DSDonDatHang[10]));
            DSPhieuGiaoHang.Add(new PHIEUGIAOHANG("MPGH12", "Neu khong co nguoi nhan! Vui long lien he sdt 08434231211", DSDonDatHang[11]));
            DSPhieuGiaoHang.Add(new PHIEUGIAOHANG("MPGH13", "", DSDonDatHang[12]));
            DSPhieuGiaoHang.Add(new PHIEUGIAOHANG("MPGH14", "", DSDonDatHang[13]));
            DSPhieuGiaoHang.Add(new PHIEUGIAOHANG("MPGH15", "", DSDonDatHang[14]));
            DSPhieuGiaoHang.Add(new PHIEUGIAOHANG("MPGH16", "Chi giao khi co nguoi dat hang o nha", DSDonDatHang[15]));
            DSPhieuGiaoHang.Add(new PHIEUGIAOHANG("MPGH17", "", DSDonDatHang[16]));
            DSPhieuGiaoHang.Add(new PHIEUGIAOHANG("MPGH18", "Chi giao vao buoi sang", DSDonDatHang[17]));
            DSPhieuGiaoHang.Add(new PHIEUGIAOHANG("MPGH19", "", DSDonDatHang[18]));
            DSPhieuGiaoHang.Add(new PHIEUGIAOHANG("MPGH20", "", DSDonDatHang[19]));
            DSPhieuGiaoHang.Add(new PHIEUGIAOHANG("MPGH21", "Khong giao tre qua 3 ngay", DSDonDatHang[20]));
            DSPhieuGiaoHang.Add(new PHIEUGIAOHANG("MPGH22", "", DSDonDatHang[21]));
            DSPhieuGiaoHang.Add(new PHIEUGIAOHANG("MPGH23", "", DSDonDatHang[22]));
            DSPhieuGiaoHang.Add(new PHIEUGIAOHANG("MPGH24", "Nha trong hem nho! Xe van chuyen can nho", DSDonDatHang[23]));
            DSPhieuGiaoHang.Add(new PHIEUGIAOHANG("MPGH25", "", DSDonDatHang[24]));
            DSPhieuGiaoHang.Add(new PHIEUGIAOHANG("MPGH26", "Neu nha dong cua! Vui long de hang o nha ben canh", DSDonDatHang[25]));
            DSPhieuGiaoHang.Add(new PHIEUGIAOHANG("MPGH27", "Chi giao hang vao buoi trua", DSDonDatHang[26]));
            DSPhieuGiaoHang.Add(new PHIEUGIAOHANG("MPGH28", "", DSDonDatHang[27]));
            DSPhieuGiaoHang.Add(new PHIEUGIAOHANG("MPGH29", "", DSDonDatHang[28]));
            DSPhieuGiaoHang.Add(new PHIEUGIAOHANG("MPGH30", "Khi giao hang can goi truoc cho chu nha", DSDonDatHang[29]));
            DSPhieuGiaoHang.Add(new PHIEUGIAOHANG("MPGH31", "", DSDonDatHang[25]));
        }
        public static void TaoDanhSachNhomSanPham()
        {
            DSNhomSanPham.Add(new NHOMSANPHAM("BOT", "Bot"));
            DSNhomSanPham.Add(new NHOMSANPHAM("CSSD", "Cham soc sac dep"));
            DSNhomSanPham.Add(new NHOMSANPHAM("CSTT", "Cham soc than the"));
            DSNhomSanPham.Add(new NHOMSANPHAM("Tp", "Thuc Pham"));
        }
        public static void TaoDanhSachSanPham()
        {
            DSSanPham.Add(new SANPHAM("BCCL1", "Ban chai Close-up nang dong (72)", "cay", 7000, 1200, "singapore", DSNhomSanPham[2]));
            DSSanPham.Add(new SANPHAM("BCCL2", "Ban chai Close-up Fresh (720)", "cay", 4000, 1200, "trung quoc", DSNhomSanPham[2]));
            DSSanPham.Add(new SANPHAM("BCCL3", "Ban chai Close-up Flesx ", "cay", 6700, 400, "dai loan", DSNhomSanPham[2]));
            DSSanPham.Add(new SANPHAM("BGO01", "Bot giat Omo 30g", "day", 4500, 240, "viet nam", DSNhomSanPham[0]));
            DSSanPham.Add(new SANPHAM("BGO02", "Bot giat Omo 200g", "goi", 2900, 108, "trung quoc", DSNhomSanPham[0]));
            DSSanPham.Add(new SANPHAM("BGOM1", "Bot giat Omo Matic 1000g", "hop", 17400, 48, "viet nam", DSNhomSanPham[0]));
            DSSanPham.Add(new SANPHAM("BGOM2", "Bot giat Omo Matic 4000g", "hop", 69000, 36, "hong kong", DSNhomSanPham[0]));
            DSSanPham.Add(new SANPHAM("BGVJ1", "Bot giat Viso Javel 700ml", "chai", 3150, 60, "trung quoc", DSNhomSanPham[0]));
            DSSanPham.Add(new SANPHAM("BN001", "Bot nem", "goi", 1350, 390, "campuchia", DSNhomSanPham[3]));
            DSSanPham.Add(new SANPHAM("CAL01", "Chao an lien", "goi", 720, 450, "dai loan", DSNhomSanPham[3]));
            DSSanPham.Add(new SANPHAM("CLG01", "Close-up Green 40g", "cay", 2000, 1440, "viet nam", DSNhomSanPham[2]));
            DSSanPham.Add(new SANPHAM("CLM01", "Close-up muoi", "cay", 3500, 1152, "trung quoc", DSNhomSanPham[2]));
            DSSanPham.Add(new SANPHAM("CMLB2", "Lifebouy chong muoi 100ml", "chai", 15000, 108, "trung quoc", DSNhomSanPham[2]));
            DSSanPham.Add(new SANPHAM("DDCCP", "Kem duong da cao cap Ponds 50g", "chai", 3500, 420, "trung quoc", DSNhomSanPham[1]));
            DSSanPham.Add(new SANPHAM("DGCB1", "Dau goi clear bac hoa 7ml", "day", 9600, 144, "hong kong", DSNhomSanPham[2]));
            DSSanPham.Add(new SANPHAM("DGCB2", "Dau goi clear bac hoa 100ml", "chai", 13500, 108, "viet nam", DSNhomSanPham[2]));
            DSSanPham.Add(new SANPHAM("DGD01", "Dau goi Dove 100ml", "chai", 15000, 360, "singapore", DSNhomSanPham[2]));
            DSSanPham.Add(new SANPHAM("DGLB1", "Dau goi Lifebouy 6ml", "day", 4800, 216, "trung quoc", DSNhomSanPham[2]));
            DSSanPham.Add(new SANPHAM("ITD01", "Icetea day 10g", "day", 8700, 216, "trung quoc", DSNhomSanPham[3]));
            DSSanPham.Add(new SANPHAM("KCNP1", "Kem chong nang Ponds 20g", "chai", 20000, 360, "viet nam", DSNhomSanPham[2]));
            DSSanPham.Add(new SANPHAM("KDDH1", "Kem duong da Hazaline 20g", "chai", 12000, 420, "campuchia", DSNhomSanPham[2]));
            DSSanPham.Add(new SANPHAM("TG01", " Tra Lipton 10 gioi", "hop", 5300, 400, "dai loan", DSNhomSanPham[3]));
        }
        public static void TaoDanhSachChiTiet_DDH()
        {
            DSChiTiet_DDH.Add(new CHITIET_DDH(DSDonDatHang[0], DSSanPham[0], "19/02/2016", 120));
            DSChiTiet_DDH.Add(new CHITIET_DDH(DSDonDatHang[1], DSSanPham[1], "17/01/2020", 400));
            DSChiTiet_DDH.Add(new CHITIET_DDH(DSDonDatHang[2], DSSanPham[2], "14/07/2021", 130));
            DSChiTiet_DDH.Add(new CHITIET_DDH(DSDonDatHang[3], DSSanPham[3], "19/08/2006", 700));
            DSChiTiet_DDH.Add(new CHITIET_DDH(DSDonDatHang[4], DSSanPham[4], "15/06/2018", 300));
            DSChiTiet_DDH.Add(new CHITIET_DDH(DSDonDatHang[5], DSSanPham[5], "20/02/2020", 350));
            DSChiTiet_DDH.Add(new CHITIET_DDH(DSDonDatHang[6], DSSanPham[6], "11/02/2017", 280));
            DSChiTiet_DDH.Add(new CHITIET_DDH(DSDonDatHang[7], DSSanPham[7], "18/08/2015", 50));
            DSChiTiet_DDH.Add(new CHITIET_DDH(DSDonDatHang[8], DSSanPham[8], "22/01/2020", 360));
            DSChiTiet_DDH.Add(new CHITIET_DDH(DSDonDatHang[9], DSSanPham[9], "28/01/2019", 120));
            DSChiTiet_DDH.Add(new CHITIET_DDH(DSDonDatHang[10], DSSanPham[10], "27/03/2020", 150));
            DSChiTiet_DDH.Add(new CHITIET_DDH(DSDonDatHang[11], DSSanPham[11], "12/06/2021", 300));
            DSChiTiet_DDH.Add(new CHITIET_DDH(DSDonDatHang[12], DSSanPham[12], "28/07/2006", 400));
            DSChiTiet_DDH.Add(new CHITIET_DDH(DSDonDatHang[13], DSSanPham[13], "13/04/2020", 750));
            DSChiTiet_DDH.Add(new CHITIET_DDH(DSDonDatHang[13], DSSanPham[13], "13/04/2020", 780));
            DSChiTiet_DDH.Add(new CHITIET_DDH(DSDonDatHang[14], DSSanPham[14], "19/02/2016", 120));
            DSChiTiet_DDH.Add(new CHITIET_DDH(DSDonDatHang[15], DSSanPham[15], "20/11/2020", 380));
            DSChiTiet_DDH.Add(new CHITIET_DDH(DSDonDatHang[16], DSSanPham[16], "21/06/2020", 120));
            DSChiTiet_DDH.Add(new CHITIET_DDH(DSDonDatHang[17], DSSanPham[17], "11/03/2020", 390));
            DSChiTiet_DDH.Add(new CHITIET_DDH(DSDonDatHang[17], DSSanPham[16], "11/03/2020", 390));
            DSChiTiet_DDH.Add(new CHITIET_DDH(DSDonDatHang[18], DSSanPham[18], "29/11/2019", 120));
            DSChiTiet_DDH.Add(new CHITIET_DDH(DSDonDatHang[19], DSSanPham[19], "16/02/2006", 840));
            DSChiTiet_DDH.Add(new CHITIET_DDH(DSDonDatHang[20], DSSanPham[20], "19/02/2016", 870));
            DSChiTiet_DDH.Add(new CHITIET_DDH(DSDonDatHang[21], DSSanPham[19], "21/06/2018", 670));
            DSChiTiet_DDH.Add(new CHITIET_DDH(DSDonDatHang[22], DSSanPham[21], "21/11/2019", 120));
            DSChiTiet_DDH.Add(new CHITIET_DDH(DSDonDatHang[23], DSSanPham[3], "22/01/2017", 395));
            DSChiTiet_DDH.Add(new CHITIET_DDH(DSDonDatHang[24], DSSanPham[4], "22/08/2018", 750));
            DSChiTiet_DDH.Add(new CHITIET_DDH(DSDonDatHang[25], DSSanPham[20], "20/11/2018", 670));
            DSChiTiet_DDH.Add(new CHITIET_DDH(DSDonDatHang[26], DSSanPham[11], "17/03/2016", 440));
            DSChiTiet_DDH.Add(new CHITIET_DDH(DSDonDatHang[27], DSSanPham[14], "15/04/2019", 380));
            DSChiTiet_DDH.Add(new CHITIET_DDH(DSDonDatHang[28], DSSanPham[15], "20/01/2016", 390));
            DSChiTiet_DDH.Add(new CHITIET_DDH(DSDonDatHang[29], DSSanPham[12], "25/03/2019", 720));

        }
        public static void TaoDanhSachChiTiet_PGH()
        {
            DSChiTiet_PGH.Add(new CHITIET_PGH(DSPhieuGiaoHang[0], DSSanPham[0], "19/08/2006"));
            DSChiTiet_PGH.Add(new CHITIET_PGH(DSPhieuGiaoHang[1], DSSanPham[1], "7/12/2012"));
            DSChiTiet_PGH.Add(new CHITIET_PGH(DSPhieuGiaoHang[2], DSSanPham[2], "16/08/2006"));
            DSChiTiet_PGH.Add(new CHITIET_PGH(DSPhieuGiaoHang[3], DSSanPham[3], "13/08/2020"));
            DSChiTiet_PGH.Add(new CHITIET_PGH(DSPhieuGiaoHang[4], DSSanPham[5], "14/02/2018"));
            DSChiTiet_PGH.Add(new CHITIET_PGH(DSPhieuGiaoHang[5], DSSanPham[5], "7/08/2006"));
            DSChiTiet_PGH.Add(new CHITIET_PGH(DSPhieuGiaoHang[6], DSSanPham[6], "20/08/2020"));
            DSChiTiet_PGH.Add(new CHITIET_PGH(DSPhieuGiaoHang[7], DSSanPham[7], "11/02/2013"));
            DSChiTiet_PGH.Add(new CHITIET_PGH(DSPhieuGiaoHang[8], DSSanPham[8], "11/03/2011"));
            DSChiTiet_PGH.Add(new CHITIET_PGH(DSPhieuGiaoHang[9], DSSanPham[9], "21/08/2019"));
            DSChiTiet_PGH.Add(new CHITIET_PGH(DSPhieuGiaoHang[10], DSSanPham[10], "22/01/2006"));
            DSChiTiet_PGH.Add(new CHITIET_PGH(DSPhieuGiaoHang[11], DSSanPham[11], "19/12/2011"));
            DSChiTiet_PGH.Add(new CHITIET_PGH(DSPhieuGiaoHang[12], DSSanPham[12], "19/07/2018"));
            DSChiTiet_PGH.Add(new CHITIET_PGH(DSPhieuGiaoHang[13], DSSanPham[13], "1/01/2006"));
            DSChiTiet_PGH.Add(new CHITIET_PGH(DSPhieuGiaoHang[14], DSSanPham[14], "7/08/2019"));
            DSChiTiet_PGH.Add(new CHITIET_PGH(DSPhieuGiaoHang[15], DSSanPham[15], "2/03/2008"));
            DSChiTiet_PGH.Add(new CHITIET_PGH(DSPhieuGiaoHang[16], DSSanPham[16], "3/07/2013"));
            DSChiTiet_PGH.Add(new CHITIET_PGH(DSPhieuGiaoHang[17], DSSanPham[17], "19/11/2011"));
            DSChiTiet_PGH.Add(new CHITIET_PGH(DSPhieuGiaoHang[18], DSSanPham[18], "21/12/2020"));
            DSChiTiet_PGH.Add(new CHITIET_PGH(DSPhieuGiaoHang[19], DSSanPham[19], "29/02/2004"));
            DSChiTiet_PGH.Add(new CHITIET_PGH(DSPhieuGiaoHang[20], DSSanPham[20], "11/11/2016"));
            DSChiTiet_PGH.Add(new CHITIET_PGH(DSPhieuGiaoHang[21], DSSanPham[21], "20/10/2017"));
            DSChiTiet_PGH.Add(new CHITIET_PGH(DSPhieuGiaoHang[22], DSSanPham[3], "7/02/2018"));
            DSChiTiet_PGH.Add(new CHITIET_PGH(DSPhieuGiaoHang[23], DSSanPham[11], "8/06/2020"));
            DSChiTiet_PGH.Add(new CHITIET_PGH(DSPhieuGiaoHang[24], DSSanPham[7], "9/12/2020"));
            DSChiTiet_PGH.Add(new CHITIET_PGH(DSPhieuGiaoHang[25], DSSanPham[6], "7/07/2020"));
            DSChiTiet_PGH.Add(new CHITIET_PGH(DSPhieuGiaoHang[26], DSSanPham[8], "16/02/2020"));
            DSChiTiet_PGH.Add(new CHITIET_PGH(DSPhieuGiaoHang[27], DSSanPham[9], "11/09/2020"));
            DSChiTiet_PGH.Add(new CHITIET_PGH(DSPhieuGiaoHang[28], DSSanPham[2], "29/01/2020"));
            DSChiTiet_PGH.Add(new CHITIET_PGH(DSPhieuGiaoHang[29], DSSanPham[3], "11/02/2020"));
            DSChiTiet_PGH.Add(new CHITIET_PGH(DSPhieuGiaoHang[30], DSSanPham[14], "1/05/2020"));

        }
        public static void TaoDanhSachNhaCungCap()
        {
            DSNhaCungCap.Add(new NHACUNGCAP("NCC001", "Cua hang bach hoa tong hop IC", "202 Tran Hung Dao,P5,Q5, TPHCM", "08990771", "19110262@student.hcmute.edu.vn"));
            DSNhaCungCap.Add(new NHACUNGCAP("NCC002", "Cong ty bach hoa Long An", "99 Hoang Hoa Tham,Long An", "0658515044", "19110372@student.hcmute.edu.vn"));
            DSNhaCungCap.Add(new NHACUNGCAP("NCC003", "Cua hang tong hop DDC", "50 Pham Ngoc Thach, Long Xuyen", "075611299", "18110372@student.hcmute.edu.vn"));
            DSNhaCungCap.Add(new NHACUNGCAP("NCC004", "Chi nhanh 2 cong ty bach hoa FH", "11 Ly Tu Trong,Vung Tau", "0568900122", "19170308@student.hcmute.edu.vn"));
            DSNhaCungCap.Add(new NHACUNGCAP("NCC005", "Cua hang tong hop ABX", "2 Nguyen Chi Thanh,Can Tho", "071811111", "17120963@student.hcmute.edu.vn"));
            DSNhaCungCap.Add(new NHACUNGCAP("NCC006", "Cua hang tong hop DDC", "50 Pham Ngoc Thach, Long Xuyen", "075611299", "18110372@student.hcmute.edu.vn"));
            DSNhaCungCap.Add(new NHACUNGCAP("NCC007", "Cong ty ASB", "1 Nguyen Hue,Da Lat", "045990722", "16130399@student.hcmute.edu.vn"));
            DSNhaCungCap.Add(new NHACUNGCAP("NCC008", "Cong ty bach hoa Da Nang", "96 Hoang Van Thu Da Nang, Long Xuyen", "022877133", "19170363@student.hcmute.edu.vn"));
            DSNhaCungCap.Add(new NHACUNGCAP("NCC009", "Cua hang bach hoa GTT", "112 Le Loi, Ha Noi", "0129890731", "19170803@student.hcmute.edu.vn"));
            DSNhaCungCap.Add(new NHACUNGCAP("NCC010", "Cong ty ACD", "45 Quoc Lo 1A,Ben Tre", "062811077", "17110362@student.hcmute.edu.vn"));
            DSNhaCungCap.Add(new NHACUNGCAP("NCC011", "Cua hang thuc pham ABC", "355 Nguyen Chi Thanh,Q1,TPHCM", "089890211", "16120398@student.hcmute.edu.vn"));
            DSNhaCungCap.Add(new NHACUNGCAP("NCC012", "Cong ty thuc pham An Dong", "178 Ha Ton Quyen,Q5,TPHCM", "088732342", "17113366@student.hcmute.edu.vn"));
        }
        public static void TaoDanhSachHopDongCungCap()
        {
            DSHopDongCungCap.Add(new HOPDONGCUNGCAP("HD001", DSNhaCungCap[0]));
            DSHopDongCungCap.Add(new HOPDONGCUNGCAP("HD002", DSNhaCungCap[1]));
            DSHopDongCungCap.Add(new HOPDONGCUNGCAP("HD003", DSNhaCungCap[2]));
            DSHopDongCungCap.Add(new HOPDONGCUNGCAP("HD004", DSNhaCungCap[3]));
            DSHopDongCungCap.Add(new HOPDONGCUNGCAP("HD005", DSNhaCungCap[4]));
            DSHopDongCungCap.Add(new HOPDONGCUNGCAP("HD006", DSNhaCungCap[5]));
            DSHopDongCungCap.Add(new HOPDONGCUNGCAP("HD007", DSNhaCungCap[6]));
            DSHopDongCungCap.Add(new HOPDONGCUNGCAP("HD008", DSNhaCungCap[7]));
            DSHopDongCungCap.Add(new HOPDONGCUNGCAP("HD009", DSNhaCungCap[8]));
            DSHopDongCungCap.Add(new HOPDONGCUNGCAP("HD010", DSNhaCungCap[9]));
            DSHopDongCungCap.Add(new HOPDONGCUNGCAP("HD011", DSNhaCungCap[10]));
            DSHopDongCungCap.Add(new HOPDONGCUNGCAP("HD012", DSNhaCungCap[11]));
            DSHopDongCungCap.Add(new HOPDONGCUNGCAP("HD013", DSNhaCungCap[2]));
            DSHopDongCungCap.Add(new HOPDONGCUNGCAP("HD014", DSNhaCungCap[5]));
            DSHopDongCungCap.Add(new HOPDONGCUNGCAP("HD015", DSNhaCungCap[6]));
            DSHopDongCungCap.Add(new HOPDONGCUNGCAP("HD016", DSNhaCungCap[8]));
            DSHopDongCungCap.Add(new HOPDONGCUNGCAP("HD017", DSNhaCungCap[9]));
            DSHopDongCungCap.Add(new HOPDONGCUNGCAP("HD018", DSNhaCungCap[0]));
            DSHopDongCungCap.Add(new HOPDONGCUNGCAP("HD019", DSNhaCungCap[11]));
            DSHopDongCungCap.Add(new HOPDONGCUNGCAP("HD020", DSNhaCungCap[1]));
        }
        public static void TaoDanhSachChiTiet_HDCCAP()
        {
            DSChiTiet_HDCCAP.Add(new CHITIET_HDCCAP(DSHopDongCungCap[0], DSSanPham[0], 50, 700000));
            DSChiTiet_HDCCAP.Add(new CHITIET_HDCCAP(DSHopDongCungCap[1], DSSanPham[1], 30, 871500));
            DSChiTiet_HDCCAP.Add(new CHITIET_HDCCAP(DSHopDongCungCap[2], DSSanPham[2], 60, 747000));
            DSChiTiet_HDCCAP.Add(new CHITIET_HDCCAP(DSHopDongCungCap[3], DSSanPham[3], 50, 700000));
            DSChiTiet_HDCCAP.Add(new CHITIET_HDCCAP(DSHopDongCungCap[4], DSSanPham[4], 30, 871500));
            DSChiTiet_HDCCAP.Add(new CHITIET_HDCCAP(DSHopDongCungCap[5], DSSanPham[5], 60, 897400));
            DSChiTiet_HDCCAP.Add(new CHITIET_HDCCAP(DSHopDongCungCap[6], DSSanPham[6], 60, 747000));
            DSChiTiet_HDCCAP.Add(new CHITIET_HDCCAP(DSHopDongCungCap[7], DSSanPham[7], 100, 696000));
            DSChiTiet_HDCCAP.Add(new CHITIET_HDCCAP(DSHopDongCungCap[7], DSSanPham[8], 50, 700000));
            DSChiTiet_HDCCAP.Add(new CHITIET_HDCCAP(DSHopDongCungCap[9], DSSanPham[9], 60, 896400));
            DSChiTiet_HDCCAP.Add(new CHITIET_HDCCAP(DSHopDongCungCap[10], DSSanPham[10], 30, 871500));
            DSChiTiet_HDCCAP.Add(new CHITIET_HDCCAP(DSHopDongCungCap[10], DSSanPham[11], 60, 747000));
            DSChiTiet_HDCCAP.Add(new CHITIET_HDCCAP(DSHopDongCungCap[12], DSSanPham[12], 60, 1444200));
            DSChiTiet_HDCCAP.Add(new CHITIET_HDCCAP(DSHopDongCungCap[13], DSSanPham[13], 24, 88560));
            DSChiTiet_HDCCAP.Add(new CHITIET_HDCCAP(DSHopDongCungCap[15], DSSanPham[14], 3, 62484));
            DSChiTiet_HDCCAP.Add(new CHITIET_HDCCAP(DSHopDongCungCap[15], DSSanPham[15], 72, 122400));
            DSChiTiet_HDCCAP.Add(new CHITIET_HDCCAP(DSHopDongCungCap[16], DSSanPham[16], 72, 214200));
            DSChiTiet_HDCCAP.Add(new CHITIET_HDCCAP(DSHopDongCungCap[17], DSSanPham[17], 50, 700000));
            DSChiTiet_HDCCAP.Add(new CHITIET_HDCCAP(DSHopDongCungCap[18], DSSanPham[18], 100, 696000));
            DSChiTiet_HDCCAP.Add(new CHITIET_HDCCAP(DSHopDongCungCap[19], DSSanPham[19], 30, 871500));
        }
        public static void TaoDanhSachNhanVien()
        {
            DSNhanVien.Add(new NHANVIEN("NV001", "Huynh Tri Lam", "Nam", "12/12/1960", "12 Minh Phung Q11", "09634165", "5/3/1984", "Tot nghiep dai hoc kinh te"));
            DSNhanVien.Add(new NHANVIEN("NV002", "Tran Van Minh", "Nam", "21/1/1965", "7 Le Lai Q1", "08202933", "19/03/1980", "Tot nghiep dai hoc kinh te"));
            DSNhanVien.Add(new NHANVIEN("NV003", "Tran Hoang Ngan", "Nam", "7/1/1962", "551/A Lac Long Quan Q1", "09112135", "26/12/1985", "Tot nghiep dai hoc kinh te"));
            DSNhanVien.Add(new NHANVIEN("NV004", "Ly Hoai An", "Nam", "24/2/1977", "1025/1 Hung Vuong Q5", "09425354", "14/12/1999", "Tot nghiep pho thong trung hoc"));
            DSNhanVien.Add(new NHANVIEN("NV005", "Lam Trong Tin", "Nam", "13/3/1965", "2 Tran Binh Trong, Q5", "09987165", "19/7/1988", "Tot nghiep dai hoc kinh te"));
            DSNhanVien.Add(new NHANVIEN("NV006", "Nguyen Van Phuong", "Nam", "9/4/1967", "56 Nguyen Hue Q1", "08233911", "12/1/1995", "Tot nghiep dai hoc kinh te"));
            DSNhanVien.Add(new NHANVIEN("NV007", "Tran Minh Tam", "Nu ", "3/2/1961", "68 Han Hai Nguyen Q11", "09345235", "5/6/1984", "Tot nghiep dai hoc kinh te"));
            DSNhanVien.Add(new NHANVIEN("NV008", "Tran Minh", "Nam", "17/12/1969", "455/432 Ba Hat Q10", "08435523", "17/3/1992", "Tot nghiep dai hoc kinh te"));
            DSNhanVien.Add(new NHANVIEN("NV009", "Hoang Ly Ly", "Nu", "13/2/1968", "178/3 Minh Phung Q1", "09129833", "25/12/1991", "Tot nghiep dai hoc kinh te"));
            DSNhanVien.Add(new NHANVIEN("NV010", "Nguyen Hoai Nam", "Nam", "7/12/1970", "321 Ba Huyen Thanh Quan Q3", "08523122", "21/7/1993", "Tot nghiep dai hoc kinh te"));
            DSNhanVien.Add(new NHANVIEN("NV011", "Tran Van Lam", "Nam", "9/11/1962", "122/3 Minh Phung Q11", "09165002", "13/12/1986", "Tot nghiep dai hoc kinh te"));
            DSNhanVien.Add(new NHANVIEN("NV012", "Nguyen Van Hai", "Nam", "4/11/1967", "94/76 Tran Hung Dao Q1", "8332454", "11/4/1991", "Tot nghiep dai hoc kinh te"));
            DSNhanVien.Add(new NHANVIEN("NV013", "Nguyen Hoang Minh", "Nam", "17/1/1963", "5511A/4 Binh Thoi Q11", "09135521", "16/2/1987", "Tot nghiep dai hoc kinh te"));
            DSNhanVien.Add(new NHANVIEN("NV014", "Phung Van Tinh", "Nam", "19/11/1975", "14/44 Tran Binh Trong Q5", "09987165", "19/12/1988", "Tot nghiep dai hoc kinh te"));
            DSNhanVien.Add(new NHANVIEN("NV015", "Ha Van Tung", "Nam", "10/3/1966", "2/45 Tran Binh Trong Q5", "09987165", "19/12/1988", "Tot nghiep dai hoc kinh te"));
            DSNhanVien.Add(new NHANVIEN("NV016", "Nguyen Van Phu", "Nam", "14/8/1962", "454 Bui Huu Nghia Q5", "08554911", "19/12/1988", "Tot nghiep dai hoc kinh te"));
            DSNhanVien.Add(new NHANVIEN("NV017", "La Tri Chung", "Nam", "12/11/1965", "12 Minh Phung Q11", "09631533", "5/3/1986", "Tot nghiep dai hoc kinh te"));
            DSNhanVien.Add(new NHANVIEN("NV018", "Tran Hong long", "Nam", "27/1/1963", "7 Le Lai Q1", "08897633", "3/9/1985", "Tot nghiep dai hoc kinh te"));
            DSNhanVien.Add(new NHANVIEN("NV019", "Luu Tuyet Nhi", "Nu", "5/1/1966", "54/35 Binh Thoi Q11", "09634135", "8/3/1989", "Tot nghiep dai hoc kinh te"));
            DSNhanVien.Add(new NHANVIEN("NV020", "Tran Van Tuan", "Nam", "2/9/1961", "27/4 Nguyen Hue Q1", "08211911", "11/12/1983", "Tot nghiep dai hoc kinh te"));
        }
        public static void TaoDanhSachPhieuChi()
        {
            DSPhieuChi.Add(new PHIEUCHI("PC01", DSHopDongCungCap[0], DSNhanVien[0], "2/5/2016", 454000));
            DSPhieuChi.Add(new PHIEUCHI("PC02", DSHopDongCungCap[1], DSNhanVien[1], "2/1/2020", 476000));
            DSPhieuChi.Add(new PHIEUCHI("PC03", DSHopDongCungCap[2], DSNhanVien[1], "2/1/2012", 763000));
            DSPhieuChi.Add(new PHIEUCHI("PC04", DSHopDongCungCap[3], DSNhanVien[3], "2/1/2013", 674200));
            DSPhieuChi.Add(new PHIEUCHI("PC05", DSHopDongCungCap[4], DSNhanVien[3], "2/1/2016", 567000));
            DSPhieuChi.Add(new PHIEUCHI("PC06", DSHopDongCungCap[5], DSNhanVien[5], "2/1/2006", 323000));
            DSPhieuChi.Add(new PHIEUCHI("PC07", DSHopDongCungCap[6], DSNhanVien[6], "2/1/2006", 961000));
            DSPhieuChi.Add(new PHIEUCHI("PC08", DSHopDongCungCap[7], DSNhanVien[6], "2/1/2009", 763110));
            DSPhieuChi.Add(new PHIEUCHI("PC09", DSHopDongCungCap[8], DSNhanVien[8], "2/1/2020", 962000));
            DSPhieuChi.Add(new PHIEUCHI("PC10", DSHopDongCungCap[9], DSNhanVien[9], "2/1/2020", 520300));
            DSPhieuChi.Add(new PHIEUCHI("PC11", DSHopDongCungCap[10], DSNhanVien[9], "2/1/2021", 323000));
            DSPhieuChi.Add(new PHIEUCHI("PC12", DSHopDongCungCap[11], DSNhanVien[9], "2/1/2020", 210000));
            DSPhieuChi.Add(new PHIEUCHI("PC13", DSHopDongCungCap[12], DSNhanVien[12], "2/1/2019", 961730));
            DSPhieuChi.Add(new PHIEUCHI("PC14", DSHopDongCungCap[13], DSNhanVien[13], "2/1/2012", 850030));
            DSPhieuChi.Add(new PHIEUCHI("PC15", DSHopDongCungCap[14], DSNhanVien[13], "2/1/2011", 762910));
            DSPhieuChi.Add(new PHIEUCHI("PC16", DSHopDongCungCap[15], DSNhanVien[13], "2/1/2008", 762103));
            DSPhieuChi.Add(new PHIEUCHI("PC17", DSHopDongCungCap[16], DSNhanVien[16], "2/1/2014", 961282));
            DSPhieuChi.Add(new PHIEUCHI("PC18", DSHopDongCungCap[17], DSNhanVien[17], "2/1/2015", 552733));
            DSPhieuChi.Add(new PHIEUCHI("PC19", DSHopDongCungCap[18], DSNhanVien[16], "2/1/2016", 230000));
            DSPhieuChi.Add(new PHIEUCHI("PC20", DSHopDongCungCap[19], DSNhanVien[17], "2/1/2008", 541233));
        }


        // Mỗi nước sản xuất, tìm nước có ít nhất 3 sản phẩm có  tổng giá bán cao nhất
        public static void Linq1()
        {
            // đếm sản phẩm của từng nước trước
            var x = from n in DSSanPham
                    group n by n.NUOCSX into g
                    select new
                    {
                        value = g.Key,
                        DS = g.Count()
                    };
            // tìm ít nhất 3 sản phẩm
            var y = from n in x
                    where n.DS >= 3
                    select new
                    {
                        x = n.value
                    };
            //  tìm ra nước có tổng sản phẩm cao nhất
            var z = from n in y
                    join m in DSSanPham on n.x equals m.NUOCSX
                    select new
                    {
                        DSSanPham = m
                    };
            var k = from n in z
                    group n by n.DSSanPham.NUOCSX into g
                    select new
                    {
                        value = g.Key,
                        Total = g.Sum(n => n.DSSanPham.GIABAN * n.DSSanPham.SOLUONGTON)
                    };

            var result = from n in k
                         where n.Total == (from i in k select i.Total).Max()
                         select new
                         {
                             k = n
                         };
            Console.WriteLine("Ten Nuoc | Tong gia ban");
            foreach (var i in result)
            {
                Console.WriteLine("{0} | {1}", i.k.value, i.k.Total);
            }
        }
        // Tìm tên Nhà cung cấp và mã NCC của các HDCC mà nhà cung cấp phân phối nhiều sản phẩm nhất
        public static void Linq2()
        {
            // Đếm số lượng sản phẩm theo nhóm HD 
            var x = from n in DSChiTiet_HDCCAP
                    group n by n.hopdongcungcap into g
                    select new
                    {
                        value = g.Key,
                        HD = g.Count()
                    };
            // Tìm xem MaHD nào có nhiều sản phẩm cung cấp nhất
            var y = from n in x
                    where n.HD == (from k in x
                                   select k.HD).Max()
                    select new
                    {
                        x = n.value
                    };
            // Bước cuối chỉ ra tên và mã nhà cung cấp đã cung cấp các sản phẩm đó
            var z = from n in y
                    join m in DSHopDongCungCap on n.x.MAHD equals m.MAHD
                    select new
                    {
                        DSHopDongCungCap = m.nhacungcap
                    };
            var result = from n in DSNhaCungCap
                         join m in z on n.MANCC equals m.DSHopDongCungCap.MANCC
                         select new
                         {
                             m.DSHopDongCungCap.MANCC,
                             m.DSHopDongCungCap.TENNCC
                         };
            Console.WriteLine("Ma nha cung cap | Ten nha cung cap ");
            foreach (var i in result)
            {
                Console.WriteLine("{0}          | {1}  ", i.MANCC, i.TENNCC);
            }
        }
        // Tìm mã khách hàng và tên khách hàng có nhiều đơn đặt hàng nhất
        public static void Linq3()
        {
            var buoc1 = from n in DSDonDatHang
                        group n by n.khachhang into g
                        select new
                        {
                            value = g.Key,
                            DDH = g.Count()
                        };
            //  tìm ra số lượng max trong đơn đặt hàng
            var buoc2 = from n in buoc1
                        where n.DDH == (from z in buoc1
                                        select z.DDH).Max()
                        select new
                        {
                            buoc1 = n
                        };
            Console.WriteLine("Ma khach hang | Ten khach hang ");
            foreach (var i in buoc2)
            {
                Console.WriteLine("{0}         |{1}", i.buoc1.value.MAKH, i.buoc1.value.TENKH);
            }
        }
        // tìm những đơn đặt hàng mà khách hàng đã đặt
        public static void Linq4()
        {
            var x = from n in DSNhaCungCap
                    where n.TENNCC == "Cong ty thuc pham An Dong"
                    select new
                    {
                        MANCC = n.MANCC,
                    };
            var y = from n in x
                    join m in DSHopDongCungCap on n.MANCC equals m.nhacungcap.MANCC
                    select new
                    {
                        MAHD = m.MAHD
                    };
            var z = from n in y
                    join m in DSPhieuChi on n.MAHD equals m.hopdongcungcap.MAHD
                    select new
                    {
                        MANV = m.NhanVien.MANV
                    };
            var result = from n in z
                         join m in DSNhanVien on n.MANV equals m.MANV
                         select new
                         {
                             MANV = m.MANV,
                             TENNV = m.HOTEN
                         };
            Console.WriteLine("Ma nhan vien | Ten nhan vien");
            foreach (var i in result)
            {
                Console.WriteLine("{0}        | {1}", i.MANV, i.TENNV);
            }
        }
        // tìm những hợp đồng và tên sản phẩm chi trả chưa đủ cho thành tiền của sản phẩm
        public static void Linq5()
        {
            // bước 1 tìm ra các phiếu chi 
            var x = from n in DSPhieuChi
                    join m in DSPhieuChi on n.MAPHIEUCHI equals m.MAPHIEUCHI
                    select new
                    {
                        SOTIENCHI = n.SOTIENCHI,
                        MAHD = m.hopdongcungcap.MAHD
                    };
            // tìm ra các sản phẩm mà phiếu chi chưa chi đủ cho sản phẩm
            var y = from n in x
                    join m in DSHopDongCungCap on n.MAHD equals m.MAHD
                    select new
                    {
                        MAHD = n.MAHD,
                        SOTIENCHI = n.SOTIENCHI
                    };
            var k = from n in y
                    join m in DSChiTiet_HDCCAP on n.MAHD equals m.hopdongcungcap.MAHD
                    where m.THANHTIEN > n.SOTIENCHI
                    select new
                    {
                        MASANPHAM = m.sanpham.MASANPHAM
                    };
            var result = from n in k
                         join m in DSSanPham on n.MASANPHAM equals m.MASANPHAM
                         where n.MASANPHAM == m.MASANPHAM
                         select new
                         {
                             TenSanPham = m.TENSANPHAM
                         };
            Console.WriteLine("Ten san pham chua chi tra du tien ");

            foreach (var i in result)
            {
                Console.WriteLine("{0}", i.TenSanPham);
            }

        }
        // tìm max là khách hàng mua hàng là nam và có số lần mua nhiều nhất
        public static void Linq6()
        {
            // tính count theo mã khách hàng trước
            var x = from n in DSDonDatHang
                    group n by n.khachhang into g
                    select new
                    {
                        value = g.Key,
                        KH = g.Count()
                    };
            // chọn ra mã khách hàng có giới tính là nam
            var y = from n in DSKhachHang
                    where n.GIOITINH == "Nam"
                    select new
                    {
                        DSKhachHang = n
                    };
            var result = from n in x
                         join m in y on n.value.MAKH equals m.DSKhachHang.MAKH
                         select new
                         {
                             x = n
                         };
            var result1 = from n in result
                          where n.x.KH == (from i in result select i.x.KH).Max()
                          select new
                          {
                              result = n
                          };
            Console.WriteLine("Ma khach hang | Ten Khach Hang");
            foreach (var i in result1)
            {
                Console.WriteLine("{0}         | {1}", i.result.x.value.MAKH, i.result.x.value.TENKH);
            }
        }
        //Tháng mấy trong năm 2020, kinh doanh trì trệ nhất?
        public static void Linq7()
        {
            // tìm count theo tháng của năm 2020
            var x = from n in DSPhieuThu
                    group n by n.NGAYTHU.TachThang() into g
                    select new
                    {
                        value = g.Key,
                        PT = g.Count()
                    };
            var y = from n in x
                    where n.PT == (from i in x select i.PT).Min()
                    select new
                    {
                        x = n.value
                    };
            Console.WriteLine("Thang may trong nam 2020 kinh doanh tri tre nhat ");
            foreach (var i in y)
            {
                Console.WriteLine("thang {0}", i.x);
            }
        }
        //Tính tổng số lượng của từng sản phẩm bán ra trong tháng 4 năm 2020.
        public static void Linq8()
        {
            // tính count của tổng phiếu thu trong tháng 4
            var x = from n in DSPhieuThu
                    where n.NGAYTHU.TachThang() == "04" && n.NGAYTHU.TachNam() == "2020"
                    group n by n.dondathang into g
                    select new
                    {
                        value = g.Key,
                        PT = g.Count()
                    };
            // tìm mã sản phẩm của đơn đặt hàng
            var y = from n in x
                    join m in DSChiTiet_DDH on n.value.MADDH equals m.dondathang.MADDH
                    select new
                    {
                        DSChiTiet_DDH = m.sanpham.MASANPHAM
                    };
            // tính tổng số lượng sản phẩm tháng 4
            var z = from n in y
                    join m in DSSanPham on n.DSChiTiet_DDH equals m.MASANPHAM
                    select new
                    {
                        DSSanPham = m
                    };
            var result = from n in z
                         group n by n into g
                         select new
                         {
                             value = g.Key,
                             total = g.Sum(n => n.DSSanPham.SOLUONGTON)
                         };
            int sum = 0;
            foreach (var i in result)
            {
                sum += i.total;
            }
            Console.WriteLine("So luong | Ten san pham");
            foreach (var i in z)
            {
                Console.WriteLine("{0}       {1}", i.DSSanPham.SOLUONGTON, i.DSSanPham.TENSANPHAM);
            }
            Console.WriteLine("Tong san luong ban ra thang 4 nam 2020 = {0} ", sum);
        }
        //In ra danh sách các sản phẩm do “Trung Quốc” 
        //sản xuất có giá bằng 1 trong 3 mức giá thấp nhất (của sản phẩm do “Trung Quốc” sản xuất).
        public static void Linq9()
        {
            // chọn các sản phẩm của trung quốc rồi sắp xếp theo thứ tự tăng dần
            var x = from n in DSSanPham
                    where n.NUOCSX == "trung quoc"
                    orderby n.GIABAN ascending
                    select new
                    {
                        DSSanPham = n
                    };
            int count = 0;
            Console.WriteLine("Gia ban | Ten san pham");
            foreach (var i in x)
            {
                Console.WriteLine("{0}      {1}", i.DSSanPham.GIABAN, i.DSSanPham.TENSANPHAM);
                count++;
                if (count == 3) break;
            }

        }
        //Tìm số hóa đơn và sản phẩm trong năm 2020 đã mua ít nhất một trong tất cả các sản phẩm do Singapore sản xuất
        public static void Linq10()
        {
            var x = from n in DSSanPham
                    from m in DSChiTiet_DDH
                    where n.NUOCSX == "singapore" && n.MASANPHAM == m.sanpham.MASANPHAM && m.NGAYDATHANG.TachNam()=="2020" 
                    select new
                    {
                        DSSanPham = n,
                        DSChiTiet_DDH = m
                    };
            Console.WriteLine("Ma don dat hang | Ten san pham");
            foreach (var i in x)
            {
                Console.WriteLine("{0}         | {1}", i.DSChiTiet_DDH.dondathang.MADDH, i.DSSanPham.TENSANPHAM);
            }
        }
        //In ra danh sách các sản phẩm không bán được trong năm 2006.
        public static void Linq11()
        {
            // chọn những món hàng năm 2006 ra
            var x = from n in DSPhieuThu
                    where n.NGAYTHU.TachNam() != "2006"
                    select new
                    {
                        MADDH = n.dondathang.MADDH
                    };
            // tìm ra sản mà sản phẩm của những năm 2006
            var y = from n in x
                    join m in DSChiTiet_DDH on n.MADDH equals m.dondathang.MADDH
                    select new
                    {
                        MSP = m.sanpham.MASANPHAM
                    };

            // tìm ra những sản phẩm không bán được trong năm 2006
            var result = from n in y
                         from m in DSSanPham
                         where n.MSP == m.MASANPHAM
                         select new
                         {
                             TenSP = m.TENSANPHAM
                         };
            Console.WriteLine("Ten san pham khong ban duoc trong nam 2006");
            foreach (var i in result)
            {
                Console.WriteLine("{0} ", i.TenSP);
            }
        }
        // Với mỗi phiếu chi có nhiều hơn 2 nhân viên lập ra phiếu chi đó, cho biết mã phiếu chi, tên sản phẩm và tên nhân viên lập phiếu chi
        // số lượng lập phiếu chi ra nhân viên đó
        public static void Linq12()
        {
            // đếm số lần lặp phiếu chi của nhân viên
            var x = from n in DSPhieuChi
                    group n by n.NhanVien.MANV into g
                    select new
                    {
                        value = g.Key,
                        Count = g.Count()
                    };

            // Tìm ra các nhân viên lập phiếu chi ít nhất 2 lần
            var y = from n in x
                    where n.Count >= 2
                    select new
                    {
                        MaNV = n.value,
                        Count = n.Count
                    };

            // Tìm ra tên nhân viên lập phiếu chi đó
            var z = from n in y
                    join m in DSNhanVien on n.MaNV equals m.MANV
                    select new
                    {
                        MaNV = n.MaNV,
                        TenNV = m.HOTEN
                    };

            // tìm ra các sản phẩm của các nhân viên đó lập phiếu chi
            var k = from n in z
                    join m in DSPhieuChi on n.MaNV equals m.NhanVien.MANV
                    select new
                    {
                        MANV = n.MaNV,
                        TenNV = m.NhanVien.HOTEN,
                        MPC = m.MAPHIEUCHI
                    };
            var l = from n in k
                    join m in DSPhieuChi on n.MPC equals m.MAPHIEUCHI
                    select new
                    {
                        MANV = n.MANV,
                        TENNV = n.TenNV,
                        MAHD = m.hopdongcungcap.MAHD
                    };

            var p = from n in l
                    join m in DSHopDongCungCap on n.MAHD equals m.MAHD
                    select new
                    {
                        MANV = n.MANV,
                        TENNV = n.TENNV,
                        MAHD = m.MAHD
                    };
            var o = from n in p
                    join m in DSChiTiet_HDCCAP on n.MAHD equals m.hopdongcungcap.MAHD
                    select new
                    {
                        MANV = n.MANV,
                        TENNV = n.TENNV,
                        MSP = m.sanpham.MASANPHAM
                    };
            var result = from n in o
                         join m in DSSanPham on n.MSP equals m.MASANPHAM
                         select new
                         {
                             MANV = n.MANV,
                             TENNV = n.TENNV,
                             TENSANPHAM = m.TENSANPHAM
                         };
            foreach (var i in z)
            {
                Console.WriteLine("Ten nhan vien lap phieu chi: {0}", i.TenNV);
                Console.WriteLine("Cac san pham lap phieu chi: ");
                foreach (var j in result)
                {
                    if (i.MaNV == j.MANV)
                    {
                        Console.WriteLine("{0}", j.TENSANPHAM);
                    }
                }
                Console.WriteLine("----------------------------------------------");

            }
        }
        //Tìm mã nhân viên và tên nhân viên lập phiếu chi có nhà cung cấp tên "Cong ty thuc pham An Dong"
        public static void Linq13()
        {
       
            var result = from n in DSDonDatHang
                             //from m in DSKhachHang
                         join m in DSKhachHang on n.khachhang.MAKH equals m.MAKH
                         where n.khachhang.MAKH == m.MAKH
                         select new
                         {
                             DSDonDatHang = n.MADDH,
                             DSKhachHang = m.TENKH
                         };
            Console.WriteLine("Ma don dat hang | Ten khach hang ");
            foreach (var i in result)
            {
                Console.WriteLine("{0}         |{1}", i.DSDonDatHang, i.DSKhachHang);
            }
        }
        // Tìm họ tên khách hàng đã các mua hóa đơn có trị giá cao nhất trong năm 2006
        public static void Linq14()
        {
            // tìm các hóa đơn trong năm 2006
            var x = from n in DSPhieuThu
                    where n.NGAYTHU.TachNam() == "2006"
                    select new
                    {
                        MPT = n.MAPHIEUTHU,
                        MADDH = n.dondathang.MADDH,
                        STT = n.SOTIENTHU
                    };
            var y = from n in x
                    where n.STT == (from i in x select i.STT).Max()
                    select new
                    {
                        MPT = n.MPT,
                        MADDH = n.MADDH
                    };
            var z = from n in y
                    join m in DSDonDatHang on n.MADDH equals m.MADDH
                    select new
                    {

                        MKH = m.khachhang
                    };
            var result = from n in z
                         join m in DSKhachHang on n.MKH.MAKH equals m.MAKH
                         select new
                         {
                             TENKH = n.MKH.TENKH
                         };
            Console.WriteLine("Ho ten cac khach hang mua don cao nhat nam 2006: ");
            foreach (var i in result)
            {
                Console.WriteLine("{0}", i.TENKH);
            }

        }
        // Tìm ra họ tên các nhân viên và mã nhân viên chưa lập một phiếu chi nào trong năm 2020
        public static void Linq15()
        {
            //tìm các nhân viên lập phiếu chi năm 2020
            var x = from n in DSPhieuChi
                    where n.NGAYLAPPC.TachNam() == "2020"
                    select new
                    {
                        MANV = n.NhanVien.MANV
                    };
            var y = from n in DSNhanVien
                    select new
                    {
                        MANV = n.MANV
                    };
            var query = y.Except(x);
            var result = from n in query
                         from m in DSNhanVien
                         where n.MANV == m.MANV
                         select new
                         {
                             MANV = n.MANV,
                             TENNV = m.HOTEN
                         };
            Console.WriteLine("Ho ten cac nhan vien cac nhan vien chua lap phieu chi nao trong nam 2020");
            Console.WriteLine("Ma nhan vien | Ten nhan vien");
            foreach (var i in result)
            {
                Console.WriteLine("{0}        | {1}", i.MANV, i.TENNV);
            }
        }
        // Tìm ra các tên sản phẩm thuộc nhóm sản phẩm nào bán chạy nhất trong các năm trong bảng CSDL
        public static void Linq16()
        {
            // đầu tiên cho ra ngày đặt hàng của các năm
            var x = (from n in DSChiTiet_DDH
                    select new
                    {
                        NGAYDATHANG = n.NGAYDATHANG.TachNam()
                    }).Distinct();
            // Tìm max từ số lượng đặt hàng của tất cả các năm 
            var y = (from n in x
                    from m in DSChiTiet_DDH
                    where n.NGAYDATHANG == m.NGAYDATHANG.TachNam()
                    && m.SOLUONG == (from k in DSChiTiet_DDH
                                     where n.NGAYDATHANG == k.NGAYDATHANG.TachNam()
                                     select k.SOLUONG).Max()
                    select new
                    {
                        NGAYDATHANG = n.NGAYDATHANG,
                        MASANPHAM = m.sanpham.MASANPHAM,
                        SOLUONG = m.SOLUONG
                    }).Distinct();
            var z = from n in y
                    from m in DSSanPham
                    where n.MASANPHAM == m.MASANPHAM
                    select new
                    {
                        NGAYDATHANG = n.NGAYDATHANG,
                        SOLUONG = n.SOLUONG,
                        TENSANPHAM = m.TENSANPHAM,
                        MANHOMSP = m.nhomsanpham.MANHOMSP
                    };
            var result = from n in z
                         from m in DSNhomSanPham
                         where n.MANHOMSP == m.MANHOMSP
                         orderby n.NGAYDATHANG ascending
                         select new
                         {
                             NGAYDATHANG = n.NGAYDATHANG,
                             SOLUONG = n.SOLUONG,
                             TENSANPHAM =n.TENSANPHAM,
                             TENNHOMSP = m.TENNHOMSP
                         };
            foreach (var i in result)
            {
                Console.WriteLine("San pham ban chay nam {0}", i.NGAYDATHANG);
                Console.WriteLine("Ten nhom san pham: {0} && Ten san pham: {1}", i.TENNHOMSP, i.TENSANPHAM);
                Console.WriteLine("So luong ban ra cao nhat: {0}", i.SOLUONG);
                Console.WriteLine("------------------------------------");
            }
        }
        // Tìm các sản phẩm đặt hàng trong chi tiết đơn đặt hàng nếu số lượng lớn hơn số lượng tồn cho kho thì tính xem
        // cần thêm bao nhiêu sản phẩm từ mặt hàng đó. 
        public static void Linq17()
        {
            // tình số lượng sản phẩm theo mã sản phẩm
            var x = from n in DSChiTiet_DDH
                    group n by n.sanpham.MASANPHAM into g
                    select new
                    {
                        value = g.Key,
                        sum= g.Sum(n=>n.SOLUONG)
                    };
            // tìm ra các mã sản phẩm bị thiếu
            var result = from n in x
                    from m in DSSanPham
                    where n.sum > m.SOLUONGTON && n.value == m.MASANPHAM
                    select new
                    {
                        MASANPHAM = n.value,
                        sum = n.sum,
                        SOLUONGTON = m.SOLUONGTON,
                        conthieu = n.sum - m.SOLUONGTON,
                        TENSP = m.TENSANPHAM
                    };
            foreach (var i in result)
            {
                Console.WriteLine("Ten san pham mat hang con thieu: {0}",i.TENSP);
                Console.WriteLine("So luong can cung cap {0}", i.sum);
                Console.WriteLine("So luong trong kho {0}", i.SOLUONGTON);
                Console.WriteLine("Can them so san pham de cung cap la: {0}", i.conthieu);
                Console.WriteLine("--------------------------------------");
            }
        }
        // tổng kết các tháng giao hàng trong năm và tìm ra tháng nào trong năm có số lượng đơn giao hàng cao nhất 
        // và chỉ ra sản phẩm có số lượng đơn giao nhiều nhất các tháng trong năm
        public static void Linq18()
        {
            // đầu tiên tìm ra các năm
            var x = (from n in DSChiTiet_PGH
                    select new
                    {
                        year = n.NGAYGIAO.TachNam()
                    }).Distinct();
            var y = from m in DSChiTiet_PGH
                    group m by m.NGAYGIAO.TachThangNam() into g
                    select new
                    {
                        value=g.Key,
                        count = g.Count()
                    };
            // var result = from n in x
            var result = from n in y
                         from m in x
                         where n.value.TachThang() == m.year && n.count == (from i in y
                                                                            where m.year == i.value.TachThang()
                                                                            select i.count).Max()
                         orderby m.year ascending
                         select new
                         {
                             year = m.year,
                             max=n.count,
                         };
            string temp="";
            int count;
            foreach (var i in result)
            {
                if (temp != i.year)
                {
                    Console.WriteLine("Nam {0}", i.year);
                }
                count = 0;
                foreach (var k in y)
                {
                    if (i.year == k.value.TachThang() && temp!=i.year)
                    {
                        Console.WriteLine("Thang {0} So Phieu Giao {1}", k.value.TachNgay(), k.count);
                        count=1;
                    }
                }
                temp = i.year;
                if(count==1)
                { 
                Console.Write("So hang ban nhieu nhat cac thang trong nam: ");
                Console.WriteLine("{0}", i.max);
                Console.WriteLine("-------------------------------");
                }
            }
        }
        // Xóa nhân viên có số lượng lập phiếu chi có số lượng nhập phiếu chi ít nhất trong CSDL
        public static void Linq19()
        {
            var x = from n in DSPhieuChi
                    group n by n.NhanVien.MANV into g
                    select new
                    {
                        value = g.Key,
                        sum = g.Count()
                    };
            var y = from n in x
                    where n.sum == (from k in x select k.sum).Min()
                    select new
                    {
                        MANV = n.value,
                        Min=n.sum
                    };
            var result = from n in DSNhanVien
                         join m in y on n.MANV equals m.MANV
                         select new
                         {
                             NHANVIEN = n
                         };
            // Xóa nhân viên ra khỏi csdl
            List<string> s = new List<string>();
            foreach (var i in result)
            {
                s.Add(i.NHANVIEN.MANV);
            }
            foreach (var i in DSNhanVien)
            {
                Console.WriteLine("Ma nhan vien {0}", i.MANV);
            }
            Console.WriteLine("Da xoa thanh cong !!!");
            Console.WriteLine("---------------------------");
            foreach (var i in s)
            {
                DSNhanVien.RemoveAll(k => k.MANV == i);
            }
            Console.WriteLine("DANH SACH MA NHAN VIEN SAU KHI XOA");
            foreach (var i in DSNhanVien)
            {
                Console.WriteLine("Ma nhan vien {0}", i.MANV);
            }
            
        }   
        // Xóa các sản phẩm không bán được trong năm 2020
        public static void Linq20()
        {
            var x = from n in DSChiTiet_DDH
                    where n.NGAYDATHANG.TachNam() == "2020"
                    group n by n.sanpham.MASANPHAM into g
                    select new
                    {
                        value = g.Key,
                        count = g.Count()
                    };
            var k = from n in x
                    select new
                    {
                        MASP = n.value
                    };
            var y = from n in DSSanPham
                    select new
                    {
                        MASP = n.MASANPHAM
                    };
            var query = y.Except(k);
            List<string> s = new List<string>();
            foreach (var i in query)
            {
                s.Add(i.MASP);
            }
            foreach (var i in DSSanPham)
            {
                Console.WriteLine("Ma san pham {0} va Ten san pham {1} ", i.MASANPHAM,i.TENSANPHAM);
            }
            Console.WriteLine("Da xoa thanh cong !!!");
            Console.WriteLine("---------------- DANH SACH SAN PHAM SAU KHI XOA ----------------");
            foreach (var i in s)
            {
                DSSanPham.RemoveAll(l => l.MASANPHAM == i);
            }
            foreach (var i in DSSanPham)
            {
                Console.WriteLine("Ma san pham {0} va Ten san pham {1} ", i.MASANPHAM, i.TENSANPHAM);
            }
        }
        public static void TLTT_1_10()
        {
            int luachon;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("********************************** CÂU HỎI TRUY VẤN **********************************");
                Console.WriteLine("Câu 1: Mỗi nước sản xuất, tìm nước sản xuất ít nhất 3 sản phẩm có tổng giá bán cao nhất ?");
                Console.WriteLine("Câu 2: Tìm mã nhà cung cấp và tên nhà cung cấp của các hợp đồng cung cấp phân phối nhiều sản phẩm nhất ?");
                Console.WriteLine("Câu 3: Tìm mã khách hàng và tên khách hàng có nhiều đơn đặt hàng nhất");
                Console.WriteLine("Câu 4: Tìm mã nhân viên và tên nhân viên lập phiếu chi có nhà cung cấp tên “Cong ty thuc pham An Dong”");
                Console.WriteLine("Câu 5: Tìm những hợp đồng và tên sản phẩm chưa chi trả đù cho thành tiền sản phẩm ?");
                Console.WriteLine("Câu 6: Tìm khách hàng có số lần mua hàng nhiều nhất và là khách hàng nam ?");
                Console.WriteLine("Câu 7: Tháng mấy trong năm 2020 có kinh doanh trì trệ nhất ?");
                Console.WriteLine("Câu 8: Tính tổng số lượng của từng sản phẩm bán trong tháng 4 năm 2020 ?");
                Console.WriteLine("Câu 9: Tìm giá bán và tên sản phẩm của nhà sản xuất “trung quốc” và có giá bằng 1 trong 3 ");
                Console.WriteLine("       mức giá thấp nhất ( của sản phẩm do “Trung Quốc” sản xuất ) ?");
                Console.WriteLine("Câu 10:Tìm số hóa đơn và sản phẩm trong năm 2020 đã mua ít nhất một trong các sản phẩm do “Singapore” sản xuất ?");
                Console.WriteLine("0: Quay lai menu");
                Console.Write("Nhập vào lựa chọn của bạn: ");
                luachon = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------- KẾT QUẢ TRUY VẤN ----------------");
                if (luachon == 1) Linq1();
                else if (luachon == 2) Linq2();
                else if (luachon == 3) Linq3();
                else if (luachon == 4) Linq4();
                else if (luachon == 5) Linq5();
                else if (luachon == 6) Linq6();
                else if (luachon == 7) Linq7();
                else if (luachon == 8) Linq8();
                else if (luachon == 9) Linq9();
                else if (luachon == 10) Linq10();
                else break;
                Console.ReadKey();
            }
        }
        public static void HHP_11_20()
        {
            int luachon;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("********************************** CÂU HỎI TRUY VẤN **********************************");
                Console.WriteLine("Câu 11: Tìm danh sách các sản phẩm không bán được trong năm 2006 ?");
                Console.WriteLine("Câu 12: Tìm tên nhân viên lập phiếu chi và tên sản phẩm. Với mỗi phiếu chi mà nhân viên đó lập ít nhất 2 lần ?");
                Console.WriteLine("Câu 13: Tìm mã đơn đặt hàng và tên các khách hàng đã đặt hàng?");
                Console.WriteLine("Câu 14: Tìm họ tên khách hàng đã mua sản phẩm có hóa đơn cao nhất trong năm 2006 ?”");
                Console.WriteLine("Câu 15: Tìm mã nhân viên và họ tên nhân viên chưa lập một phiếu chi nào trong năm 2020 ?");
                Console.WriteLine("Câu 16: Tìm những mặt hàng bán chạy nhất trong các năm, in ra tên nhóm sản phẩm,");
                Console.WriteLine("        tên sản phẩm và số lượng sản phẩm bán ra cao nhất ?");
                Console.WriteLine("Câu 17: Tìm ra các sản phẩm có số lượng giao lớn hơn số lượng trong kho và cho biết ");
                Console.WriteLine("        cần thêm bao nhiêu để cung cấp đủ sản phẩm cho người tiêu dùng ?");
                Console.WriteLine("Câu 18: Tổng kết các tháng giao hàng trong từng năm có trong CSDL và ");
                Console.WriteLine("        tìm xem các tháng trong năm tháng nào có số lượng giao hàng nhiều nhất ?");
                Console.WriteLine("Câu 19: Xóa các nhân viên có số  lượng lập phiếu chi ít nhất trong CSDL");
                Console.WriteLine("Câu 20: Xóa các sản phẩm không bán được trong năm 2020 ");
                Console.WriteLine("0: Quay lai menu");
                Console.Write("Nhập vào lựa chọn của bạn: ");
                luachon = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------- KẾT QUẢ TRUY VẤN ----------------");
                if (luachon == 11) Linq11();
                else if (luachon == 12) Linq12();
                else if (luachon == 13) Linq13();
                else if (luachon == 14) Linq14();
                else if (luachon == 15) Linq15();
                else if (luachon == 16) Linq16();
                else if (luachon == 17) Linq17();
                else if (luachon == 18) Linq18();
                else if (luachon == 19) Linq19();
                else if (luachon == 20) Linq20();
                else break;
                Console.ReadKey();
            }
        }
        public static void Menu ()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int luachon;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("***************** QUẢN LÝ SẢN PHẨM BÁN HÀNG *****************");
                Console.WriteLine("1: Trần Lê Thanh Tuyền các câu hỏi từ 1-10");
                Console.WriteLine("2: Hồ Hoài Phong các câu hỏi từ 11-20");
                Console.WriteLine("0: Thoát");
                Console.Write("Nhập vào lựa chọn của bạn: ");
                luachon = int.Parse(Console.ReadLine());
                if (luachon == 1) TLTT_1_10();
                else if (luachon == 2) HHP_11_20();
                else break;
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            TaoDanhSachLoaiKhachHang();
            TaoDanhSachKhangHang();
            TaoDanhSachDonDatHang();
            TaoDanhSachPhieuThu();
            TaoDanhSachPhieuGiaoHang();
            TaoDanhSachNhomSanPham();
            TaoDanhSachSanPham();
            TaoDanhSachChiTiet_DDH();
            TaoDanhSachChiTiet_PGH();
            TaoDanhSachNhaCungCap();
            TaoDanhSachHopDongCungCap();
            TaoDanhSachChiTiet_HDCCAP();
            TaoDanhSachNhanVien();
            TaoDanhSachPhieuChi();
            Menu();
            Console.ReadKey();

        }
    }
}
