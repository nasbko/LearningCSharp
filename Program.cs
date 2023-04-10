using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1
{
    internal class Program
    {
        public static void Main() 
        { 
        
            Console.WriteLine("Введите первое число:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число:");
            int c = int.Parse(Console.ReadLine());

            double result = (a + b + c) / 3;
            
            Console.WriteLine("Среднее арифметическое: " + result);
        }
    }
}
