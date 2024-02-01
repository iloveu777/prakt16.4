using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sotryd[] arr = new Sotryd[1];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Sotryd();
                arr[i].Input();
            }
            Clear();
            WriteLine("ID |  ИМЯ  | ФАМИЛИЯ | ДАТА РОЖДЕНИЯ | ДОЛЖНОСТЬ | ОКЛАД |");
            foreach (Sotryd sod in arr)
            {
                sod.Print();
            
            
            }
            foreach (Sotryd sod in arr)
            {
                sod.PrintAge();
                sod.CheckDaysWork();

            }
            ReadLine();
        }
    }
}
