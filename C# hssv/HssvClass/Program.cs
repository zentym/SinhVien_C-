using System.Diagnostics;
using HssvClass.model;

namespace HssvClass
{
    class Program
    {
        private static int choice;
        static void Main(string[] args)
        {
            List<HocSinh> listHocSinh = new List<HocSinh>();
            List<SinhVien> listSinhVien = new List<SinhVien>();
            HocSinh hs;
            SinhVien sv;
            while (choice != 9)
            {
                Console.WriteLine("1. Them hoc sinh");
                Console.WriteLine("2. Them sinh vien");
                Console.WriteLine("3. Sua hoc sinh");
                Console.WriteLine("4. Sua sinh vien");
                Console.WriteLine("5. Xoa hoc sinh");
                Console.WriteLine("6. Xoa sinh vien");
                Console.WriteLine("7. Show hoc sinh");
                Console.WriteLine("8. Show sinh vien");
                Console.WriteLine("9. Exit");
                Console.WriteLine("Nhap lua chon cua ban: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("1. Them hoc sinh");
                        hs = new HocSinh();
                        hs.Them(listHocSinh);
                        break;
                    case 2:
                        Console.WriteLine("2. Them sinh vien");
                        sv = new SinhVien();
                        sv.Them(listSinhVien);
                        break;
                    case 3:
                        Console.WriteLine("3. Sua hoc sinh");
                        hs = new HocSinh();
                        hs.Sua(listHocSinh);
                        break;
                    case 4:
                        Console.WriteLine("4. Sua sinh vien");
                        sv = new SinhVien();
                        sv.Sua(listSinhVien);
                        break;
                    case 5:
                        Console.WriteLine("5. Xoa hoc sinh");
                        hs = new HocSinh();
                        hs.Xoa(listHocSinh);
                        break;
                    case 6:
                        Console.WriteLine("6. Xoa sinh vien");
                        sv = new SinhVien();
                        sv.Xoa(listSinhVien);
                        break;
                    case 7:
                        Console.WriteLine("7. Show hoc sinh");
                        hs = new HocSinh();
                        hs.Show(listHocSinh);
                        break;
                    case 8:
                        Console.WriteLine("8. Show sinh vien");
                        sv = new SinhVien();
                        sv.Show(listSinhVien);
                        break;
                    default:
                        Console.WriteLine("NAh");
                        break;
                }
            }
        }
    }
}
