using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTraSoNguyenTo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter a number:");
            number=int.Parse(Console.ReadLine());
            if(number<2)
            {
                Console.WriteLine(number + " is not a prime");

            }
            else
            {
                        int i = 2;
                bool check = true;
                while(i<=Math.Sqrt(number))
                {
                    if(number% i==0)
                    {
                        check = false;
                        break;
                    }
                    i++;

                }
                if(check)
                {
                    Console.WriteLine(number + "Is a prime");

                }
                else
                {
                    Console.WriteLine(number + " is not a prime");
                }    

         
            }    
            Console.ReadLine();
        }
    }
}
