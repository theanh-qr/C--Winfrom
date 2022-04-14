using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiKT_bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            string chon;
            Console.Write("Moi ban cho chuong trinh!!!: ");
            chon = Console.ReadLine();
            switch (chon)
            {
                case "1":
                    //tao 1 bien: la the hien cua class da xay dung
                    Ham1 xyz = new Ham1();
                    //goi den ham can thuc hien: ten_bien.ten_ham();
                    xyz.tinhtong();
                    break;
                case "2":
                    baitap2 abc = new baitap2();
                    abc.bt2();
                    break;
                case "3":
                    baitap3 edf = new baitap3();
                    edf.bt3();
                    break;
                default:
                    Console.WriteLine("Chuong trinh chua co, dang cap nhap");
                    break;
            }

            Console.ReadKey();
        }
    }
    //ham tinh tong
    class Ham1
    {
        public void tinhtong()
        {
            int[] a = new int[100];
            int i, n, sum = 0;


            Console.Write("\nTim tong cac phan tu mang trong C#:\n");
            Console.Write("------------------------------------\n");

            Console.Write("Nhap so phan tu can luu tru vao trong mang: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao trong mang: \n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                sum += a[i];
            }

            Console.Write("Tong cac phan tu trong mang la: {0}\n\n", sum);
        }
    }
}
