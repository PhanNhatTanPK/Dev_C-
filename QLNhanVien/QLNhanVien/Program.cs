using System;

namespace QLNhanVien
{
    class Program
    {
        public class NhanVien
        {
            protected string maNV;
            protected string HoTenNV;
            protected string NamSinh;
            protected string GioiTinh;
            protected double HSL;
            protected double Luong;
            
            public NhanVien(string mnv, string ht, string ns, string gt, double hsl)
            {
                maNV = mnv;
                HoTenNV = ht;
                NamSinh = ns;
                GioiTinh = gt;
                HSL = hsl;
                Luong = TinhLuong();
             
            }
            public double TinhLuong()
            {
                return  HSL * 1550000;
            }

            public virtual void xuat()
            {
                Console.WriteLine("Ho ten: {0}, Nam sinh: {1}, Gioi tinh: {2}, He so luong: {3}, Luong:{4}"
                    , HoTenNV, NamSinh, GioiTinh, HSL, Luong);
            }

            public virtual double DangPhi()
            {
                return 0;
            }

            public virtual bool KiemTra()
            {
                return false;
            }
        }

        public class DangVien : NhanVien
        {
            private DateTime NgayVaoDang;
            private DateTime NgayChinhThuc;
            private string NoiVaoDang;

            public DangVien(string mnv, string ht, string ns, string gt, double hsl, string nvd, string nct, string noivd )
                :base(mnv,ht,ns,gt,hsl)
            {
                NgayVaoDang = DateTime.Parse(nvd);
                NgayChinhThuc = DateTime.Parse(nct);
                NoiVaoDang = noivd;
            }

            public override double DangPhi()
            {
                return 0.01 * TinhLuong() ;
            }

            public override void xuat()
            {
                base.xuat();
                Console.WriteLine("Ngay vao Dang: {0}, Ngay chinh thuc: {1}, Noi vao Dang: {2}",
                    NgayVaoDang, NgayChinhThuc, NoiVaoDang);
            }

            public override bool KiemTra()
            {
                return DangPhi() > 400000;
            }
        }
        static void Main(string[] args)
        {
            NhanVien nv1 = new DangVien("01", "Nguyen Van Anh", "1998", "Nam", 10.0, "26/3/2018", "28/3/2018", "Quy Nhon");

            nv1.xuat();
            
            if (nv1.KiemTra())
            {
                Console.WriteLine("Dang vien nay co Dang phi lon hon 400.000");
            }
            else
                Console.WriteLine("Dang vien nay co Dang phi be hon 400.000");

        }
    }
}
