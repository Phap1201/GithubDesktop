using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimGiaTriTrongMang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string>Dssv = new List<string>();
            Console.WriteLine("Nhap Gia Tri Phan Tu:");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Ten SV!");
            for(int i=0;i<n;i++)
            {

                Console.Write("Phan Tu Thu[" + i + "]=");
                Dssv.Add(Console.ReadLine());
            }
            Console.WriteLine();
            string hoten = "";
            Console.WriteLine("NhapHoTen:");
            hoten = Console.ReadLine();
            int index=Dssv.ToList().IndexOf(hoten);
            if (index < 0)
            {
                Console.WriteLine("Khong Tim Thay");

            }
            else
                Console.WriteLine("Da tim Thay , vi tri " + index);
            Console.ReadKey ();
        }
    }
}
