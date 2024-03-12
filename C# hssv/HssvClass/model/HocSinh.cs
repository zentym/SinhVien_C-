using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HssvClass.model
{
    public class HocSinh : HsSv<HocSinh>
    {
        private string maHS = "";
        private string hoTen = "";
        private DateTime ngaySinh;
        private string lop = "";

        public string MaHS
        {
            get
            {
                return maHS;
            }
            set
            {
                maHS = value;
            }
        }
        public string HoTen
        {
            get
            {
                return hoTen;
            }
            set
            {
                hoTen = value;
            }
        }
        public DateTime NgaySinh
        {
            get
            {
                return ngaySinh;
            }
            set
            {
                ngaySinh = value;
            }
        }
        public string Lop
        {
            get
            {
                return lop;
            }
            set
            {
                lop = value;
            }
        }

        public void Them(List<HocSinh> list)
        {
            Console.WriteLine("Them hoc sinh");
            if (list.Count == 0)
            {
                this.maHS = "001";
            }
            else
            {
                //001,002,003,...,010,011,012,...
                int maSv = int.Parse(list[list.Count - 1].maHS);
                this.maHS = (maSv + 1).ToString("D3");
            }
            Console.WriteLine("Nhap ho ten: ");
            while (true)
            {
                this.HoTen = Console.ReadLine();
                if (HoTen != null && HoTen == "")
                {
                    Console.WriteLine("Nhap lai ho ten: ");
                }
                else
                {
                    this.HoTen = HoTen;
                    break;
                }
            }
            Console.WriteLine("Nhap ngay sinh: ");
            while (true)
            {
                try
                {
                    this.NgaySinh = DateTime.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Nhap lai ngay sinh: ");
                }
            }
            Console.WriteLine("Nhap lop: ");
            while (true)
            {
                this.Lop = Console.ReadLine();
                if (Lop != null && Lop == "")
                {
                    Console.WriteLine("Nhap lai lop: ");
                }
                else
                {
                    this.Lop = Lop;
                    break;
                }
            }

            list.Add(this);
        }

        public void Sua(List<HocSinh> list)
        {
            Console.WriteLine("Sua sinh vien");
            Console.WriteLine("Nhap ma sinh vien can sua: ");
            string maHS = Console.ReadLine();
            if (list.Count == 0)
            {
                Console.WriteLine("Khong co sinh vien nao de sua");
                return;
            }
            while (true)
            {
                if (list.Any(hs => hs.MaHS == maHS))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nhap lai ma sinh vien can sua: ");
                    maHS = Console.ReadLine();
                }
            }
            HocSinh hs = list.Find(hs => hs.MaHS == maHS);
            //in ra thong tin sinh vien can sua

            Console.WriteLine("Nhap ho ten: ");
            while (true)
            {
                hs.HoTen = Console.ReadLine();
                if (hs.HoTen != null && hs.HoTen == "")
                {
                    Console.WriteLine("Nhap lai ho ten: ");
                }
                else
                {
                    hs.HoTen = hs.HoTen;
                    break;
                }
            }
            Console.WriteLine("Nhap ngay sinh: ");
            while (true)
            {
                try
                {
                    hs.NgaySinh = DateTime.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Nhap lai ngay sinh: ");
                }
            }
            Console.WriteLine("Nhap lop: ");
            while (true)
            {
                hs.Lop = Console.ReadLine();
                if (hs.Lop != null && hs.Lop == "")
                {
                    Console.WriteLine("Nhap lai lop: ");
                }
                else
                {
                    hs.Lop = hs.Lop;
                    break;
                }
            }
            Console.WriteLine("Sua hoc sinh thanh cong!");
        }
        public void Xoa(List<HocSinh> list)
        {
            Console.WriteLine("Nhap ma sinh vien can xoa: ");
            string maSV = Console.ReadLine();
            if (list.Count == 0)
            {
                Console.WriteLine("Khong co sinh vien nao de xoa");
                return;
            }
            while (true)
            {
                if (list.Any(hs => hs.MaHS == maSV))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nhap lai ma sinh vien can xoa: ");
                    maSV = Console.ReadLine();
                }
            }
            list.RemoveAll(hs => hs.MaHS == maSV);
            Console.WriteLine("Xoa sinh vien");
        }

        public void Show(List<HocSinh> list)
        {
            list.ForEach(hs => Console.WriteLine(hs.MaHS + " " + hs.HoTen + " Ngay:" + hs.NgaySinh.Date + " Lop:" + hs.Lop));
        }
    }
}