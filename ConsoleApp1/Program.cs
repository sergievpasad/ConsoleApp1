using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string key;
            int a,b;
            Console.WriteLine("Главное меню:\nСложение(+)\nВычитание(-)\nДеление(/)\t\t  Символы в скобках\nУмножение(*)\t   подразумевают синтаксик который\nСтепень(sqr)\t\tдолжен использоваться\nКорень(sqrt)\nФакториал(!)\nМодуль(mod)\nСинус(sin)\nКосинус(cos)\nТангенс(tg)\nКотангенс(ctg)\nДонаты(don)\nВозврат в главное меню(gob)\nВыход из консоли(end)");
            key = Console.ReadLine();
            while (key!="end")
            {
                Console.Clear();
                switch (key)
                {
                    case "+":
                        Console.Write("Введите первое число: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Результат: {a+b}") ;
                        break;
                    case "*":
                        Console.Write("Введите первое число: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Результат: {a * b}");
                        break;
                        
                   

                }
                key = Console.ReadLine();
            }
        }
    }
}
