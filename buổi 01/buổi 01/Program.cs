using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buổi_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập Ngày Tháng Năm Sinh Của Bạn(dd/MM/yyyy):");
            DateTime DateOfBirth = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            DateTime YearBirth = DateTime.Today;
            DateTime NextBirthYear = new DateTime(YearBirth.Year + 1, DateOfBirth.Month, DateOfBirth.Day);
            DateTime ThisYearBirthday = new DateTime(YearBirth.Year, DateOfBirth.Month, DateOfBirth.Day);
            int NumberDaysLeft = ((NextBirthYear - YearBirth).Days) % ((NextBirthYear - ThisYearBirthday).Days);
            Console.WriteLine("Còn {0} Ngày Là Đến Sinh Nhật Của Bạn!", NumberDaysLeft);
            Console.ReadLine();



        }
    }
}
