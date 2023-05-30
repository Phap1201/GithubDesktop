using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HienThiThoiGianHeThong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime LocalDate= DateTime.Now;
            Console.WriteLine("Datetime Now is:" + LocalDate);
            Console.WriteLine("Datetime Now new is:" + string.Format("{0:dd/MM/yyyy HH:mm:ss}", LocalDate));
            Console.ReadLine();
        }
    }
}
