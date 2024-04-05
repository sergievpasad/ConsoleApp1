using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Number
    {
        public double FirstNum { get; set; }
        public double SecNum { get; set; }
        //public void In()
        //{
        //    Console.Write("Первое число: ");
        //    FirstNum = Convert.ToDouble(Console.ReadLine());
        //    Console.Write("Второе число: ");
        //    SecNum = Convert.ToDouble(Console.ReadLine());
        //}
    }
    class Func : Number
    {
        public double Sum()
        {
            Console.Write("Первое слогаемое: ");
            FirstNum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Второе слогаемое: ");
            SecNum = Convert.ToDouble(Console.ReadLine());
            return FirstNum + SecNum;
        }

        public double Dif()
        {
            return FirstNum + SecNum;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Func Calc = new Func();
            Console.WriteLine($"Результат: {Calc.Sum()}");

        }
    }
}

