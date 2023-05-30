using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDungChuyenDoiTienTe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int USD = 1;
            Console.WriteLine("MoiBanNhap USD:");
            USD=int.Parse(Console.ReadLine());
            int VND = 23 * USD;
            Console.WriteLine(USD + "USD=" + VND + "K.VND");
            Console.ReadLine();

        }
    }
}
