using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BienDoiSoThanhChu
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int n, sum = 0, r;

            Console.WriteLine("Nhap mot so bat ky = \n");
            n=int.Parse(Console.ReadLine());
          
            while (n > 0)
            {
                r = n % 10;
                sum = sum * 10 + r;
                n = n / 10;
            }
            n = sum;
            while (n > 0)
            {
                r = n % 10;
                switch (r)
                {
                    case 1:
                        Console.Write("mot ");
                        break;
                    case 2:
                        Console.Write("hai ");
                        break;
                    case 3:
                        Console.Write("ba ");
                        break;
                    case 4:
                        Console.Write("bon ");
                        break;
                    case 5:
                        Console.Write("nam ");
                        break;
                    case 6:
                    Console.WriteLine("sau ");
                        break;
                    case 7:
                        Console.Write("bay ");
                        break;
                    case 8:
                        Console.Write("tam ");
                        break;
                    case 9:
                        Console.Write("chin ");
                        break;
                    case 0:
                        Console.Write("khong ");
                        break;
                    default:
                        Console.Write("___");
                        break;
                }
                n = n / 10;
            }

            Console.Write("\n\n===========================\n");

            Console.ReadLine    ();
        }
    }
}
