using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Ứng_Dụng
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int SuLuaChon = 1;
            while (SuLuaChon!=0)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.Hình Tam Giác");
                Console.WriteLine("2.Hình Vuông ");
                Console.WriteLine("3.Hình Chữ Nhật");
                Console.WriteLine("0.Thoát");
                SuLuaChon=int.Parse(Console.ReadLine());
                switch (SuLuaChon)
                {
                    case 1:
                        Console.WriteLine("Hình Tam Giác");
                        Console.WriteLine("        *");
                        Console.WriteLine("       * *");
                        Console.WriteLine("      *   *");
                        Console.WriteLine("     *******");
                        break;
                    case 2:
                        Console.WriteLine("Hình Vuông");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("*         *");
                        Console.WriteLine("*         *");
                        Console.WriteLine("* * * * * *");
                        break;
                    case 3:
                        Console.WriteLine("Vẽ Hình Chữ Nhật");
                        Console.WriteLine("* * * * * *");
                        Console.WriteLine("*         *");
                        Console.WriteLine("* * * * * *");
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;


                    default:
                        Console.WriteLine("Không có lựa chọn!");
                        break;
                }
                SuLuaChon++;
            }
            Console.ReadLine();
        }
    }
}
