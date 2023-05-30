using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTongCacPhanTU
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<int>a= new List<int>();
            Console.Write("So Luong Phan Tu Can Nhap:");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Gia Tri Cac Phan Tu:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phan Tu Thu[" + i + "]=");
                a.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("\n");
            Console.WriteLine("Xuat Gia Tri Vua Nhap:");
            Console.WriteLine(string.Join(" ", a));
            Console.WriteLine("Tong Gia Trin Cua Mang " +  a.Sum());
          
            Console.ReadKey();
        }
    }
}
