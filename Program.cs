using System;

namespace QuanLiSach
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap vao so loai sach:");
            n = int.Parse(Console.ReadLine());
            SachGiaoKhoa[] sgk = new SachGiaoKhoa[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin sach thu: " + (i + 1).ToString());
                sgk[i] = new SachGiaoKhoa();
                sgk[i].Nhap();

            }
            Console.WriteLine("Danh sach Sach:");
            Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}", "maSach", "Soluong", "Dongia", "Thanhtien");
            for (int i = 0; i <= n; i++)
            {
                sgk[i].Hienthi();
            }
            Console.ReadLine();
        }
    }
}