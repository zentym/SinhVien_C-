using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HssvClass.model
{
    public class SinhVien : HsSv<SinhVien>
    {
        private string maSV = "";
        private string hoTen = "";
        private DateTime ngaySinh;
        private string lop = "";
        private string khoa = "";

        public string MaSV
        {
            get
            {
                return maSV;
            }
            set
            {
                maSV = value;
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
        public string Khoa
        {
            get
            {
                return khoa;
            }
            set
            {
                khoa = value;
            }
        }
        public void Them(List<SinhVien> sinhViens)
        {
            Console.WriteLine("Them sinh vien");
            if (sinhViens.Count == 0)
            {
                this.MaSV = "001";
            }
            else
            {
                //001,002,003,...,010,011,012,...
                int maSv = int.Parse(sinhViens[sinhViens.Count - 1].MaSV);
                this.MaSV = (maSv + 1).ToString("D3");
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
            Console.WriteLine("Nhap khoa: ");
            while (true)
            {
                this.Khoa = Console.ReadLine();
                if (Khoa != null && Khoa == "")
                {
                    Console.WriteLine("Nhap lai khoa: ");
                }
                else
                {
                    this.Khoa = Khoa;
                    break;
                }
            }

            sinhViens.Add(this);
        }

        public void Sua(List<SinhVien> sinhViens)
        {
            Console.WriteLine("Sua sinh vien");
            Console.WriteLine("Nhap ma sinh vien can sua: ");
            string maSV = Console.ReadLine();
            if (sinhViens.Count == 0)
            {
                Console.WriteLine("Khong co sinh vien nao de sua");
                return;
            }
            while (true)
            {
                if (sinhViens.Any(sv => sv.MaSV == maSV))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nhap lai ma sinh vien can sua: ");
                    maSV = Console.ReadLine();
                }
            }
            SinhVien sv = sinhViens.Find(sv => sv.MaSV == maSV);
            //in ra thong tin sinh vien can sua

            Console.WriteLine("Nhap ho ten: ");
            while (true)
            {
                sv.HoTen = Console.ReadLine();
                if (sv.HoTen != null && sv.HoTen == "")
                {
                    Console.WriteLine("Nhap lai ho ten: ");
                }
                else
                {
                    sv.HoTen = sv.HoTen;
                    break;
                }
            }
            Console.WriteLine("Nhap ngay sinh: ");
            while (true)
            {
                try
                {
                    sv.NgaySinh = DateTime.Parse(Console.ReadLine());
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
                sv.Lop = Console.ReadLine();
                if (sv.Lop != null && sv.Lop == "")
                {
                    Console.WriteLine("Nhap lai lop: ");
                }
                else
                {
                    sv.Lop = sv.Lop;
                    break;
                }
            }
            Console.WriteLine("Nhap khoa: ");
            while (true)
            {
                sv.Khoa = Console.ReadLine();
                if (sv.Khoa != null && sv.Khoa == "")
                {
                    Console.WriteLine("Nhap lai khoa: ");
                }
                else
                {
                    sv.Khoa = sv.Khoa;
                    break;
                }
            }
            Console.WriteLine("Sua sinh vien");


        }

        public void Xoa(List<SinhVien> sinhViens)
        {
            Console.WriteLine("Nhap ma sinh vien can xoa: ");
            string maSV = Console.ReadLine();
            if (sinhViens.Count == 0)
            {
                Console.WriteLine("Khong co sinh vien nao de xoa");
                return;
            }
            while (true)
            {
                if (sinhViens.Any(sv => sv.MaSV == maSV))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nhap lai ma sinh vien can xoa: ");
                    maSV = Console.ReadLine();
                }
            }
            sinhViens.RemoveAll(sv => sv.MaSV == maSV);
            Console.WriteLine("Xoa sinh vien");
        }

        public void Show(List<SinhVien> sinhViens)
        {
            sinhViens.ForEach(sv => Console.WriteLine(sv.MaSV + " " + sv.HoTen + " Ngay:" + sv.NgaySinh.Date + " Lop:" + sv.Lop + " Khoa:" + sv.Khoa));
        }
    }
}