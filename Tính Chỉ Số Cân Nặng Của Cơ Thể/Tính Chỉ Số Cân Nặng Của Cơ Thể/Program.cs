using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tính_Chỉ_Số_Cân_Nặng_Của_Cơ_Thể
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Weight;
            double Height;
            Console.Write("Please Enter Weight:");
            Weight = double.Parse(Console.ReadLine());
            Console.Write("Please Enter Height:");
            Height = double.Parse(Console.ReadLine());
            double bmi = Weight / Math.Pow(Height, 2);
            bmi = Math.Round(bmi, 1);
            Console.WriteLine("BMI:" + bmi);

            if (bmi < 18.5)
            {
                Console.WriteLine("A Partition Is: Underweight");
            }
            else if (bmi < 25.0)
            {
                Console.WriteLine("A Partition Is:Normal");

            }
            else if (bmi < 30.0)
            {
                Console.WriteLine("A Partition Is:Overweight");
            }
            else
            {
                Console.WriteLine("A Partition Is:Obese");
            }
            Console.ReadLine();
        }
    }
}
