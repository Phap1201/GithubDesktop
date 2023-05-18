using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_Tập_IF_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Solve First Degree Equation");
            Console.WriteLine("Given a equation as 'a * x + b = 0',Please Enter a,b,c: ");
            Console.Write("a= ");
            a= double.Parse(Console.ReadLine());
            Console.Write("b= ");
            b= double.Parse(Console.ReadLine());
            double UniqueExperience=(-b/a);
            if(a!=0)
            {
                Console.WriteLine("Equation Has Only One Solution:  {0}", UniqueExperience);
            }  
            else if(b!=0)
            {
                Console.WriteLine("Ward Cheng Is Inexperienced!");
            }
            else {
                Console.WriteLine("Equation Countless Solutions!");
                }

            Console.ReadLine();
        }
    }
}
