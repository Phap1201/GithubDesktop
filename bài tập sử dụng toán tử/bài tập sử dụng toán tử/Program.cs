using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_tập_sử_dụng_toán_tử
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float width;
            float height;
            Console.Write("Moi ban nhap width:");
            width=float.Parse(Console.ReadLine());
            Console.Write("Moi ban nhap height:");
            height=float.Parse(Console.ReadLine());
            float area=width*height;
            Console.WriteLine("Area is:" + area);
            Console.ReadLine();
        }
    }
}
