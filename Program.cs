using System;

namespace SinhVien
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;
            Console.WriteLine("nhap so sinh vien:");
            n = Int32.Parse(Console.ReadLine());
            SinhVien[] sv = new SinhVien[n];
            for (int i = 0; i < n; i++)
            {
                sv[i] = new SinhVien();
                sv[i].nhap();
                sv[i].IN();
            }

            float min = sv[0].tinhdiemtb();
            for (int i = 1; i < n; i++)
            {
                if (sv[i].tinhdiemtb() < min)
                    min = sv[i].tinhdiemtb();

            }
            Console.WriteLine("SV diem thap nhat la:{0}", min);
            for (int j = 0; j < n; j++)
            {
                for (int k = j + 1; k < n; k++)
                {
                    if (sv[k].tinhdiemtb() < sv[j].tinhdiemtb())
                    {
                        SinhVien t = new SinhVien();
                        t = sv[j];
                        sv[j] = sv[k];
                        sv[k] = t;
                    }
                }
            }
            Console.WriteLine(" Sap xep diem trung binh theo thu tu tang dan cua SV:\n");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("SV ma {0} co diem trung binh {1} xep thu nhat", sv[j].maSV, sv[j].tinhdiemtb());
            }
            for (int i = 0; i < n; i++)
            {
                if (sv[i].maSV.Contains("IT"))
                    Console.WriteLine("sinh vien ma co chua ki tu IT la {0}", sv[i].maSV);
            }

            Console.ReadLine();
        }
    }
}


