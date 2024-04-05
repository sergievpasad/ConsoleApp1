using System;

namespace ConsoleApp1
{
    class Number
    {
        public double A { get; set; }

        public double B { get; set; }
    }
    class Func:Number
    {   
        public double Sum(double a, double b)
        {
            return a + b;
        }
        public double Mod(double a)
        {
            if (a < 0)
            {
                return a * -1;
            }
            return a;
        }
        public double Fac(double a)
        {
            if (a != 0)
            {
                return a * Fac(a - 1);
            }
            return 1;
        }
        public double trig(string Key, double a)
        {
            while (a >= 360)
            {
                a -= 360;
            }
            switch (Key)
            {

                case "sin":
                case "Sin":
                    switch (a)
                    {
                        case 0:
                        case 180:
                            return 0;
                        case 30:
                        case 150:
                            return 0.5;
                        case 45:
                        case 135:
                            return Math.Round(Math.Sqrt(2) / 2, 10);
                        case 60:
                        case 120:
                            return Math.Round(Math.Sqrt(3) / 2, 10);
                        case 90:
                            return 1;
                        case 210:
                        case 330:
                            return -0.5;
                        case 225:
                        case 315:
                            return -Math.Round(Math.Sqrt(2) / 2, 10);
                        case 240:
                        case 300:
                            return -Math.Round(Math.Sqrt(3) / 2, 10);
                        case 270:
                            return -1;

                    }
                    break;
                case "cos":
                case "Cos":
                    switch (a)
                    {
                        case 0:
                            return 1;
                        case 30:
                        case 330:
                            return Math.Round(Math.Sqrt(3) / 2, 10);
                        case 45:
                        case 315:
                            return Math.Round(Math.Sqrt(2) / 2, 10);
                        case 60:
                        case 300:
                            return 0.5;
                        case 120:
                        case 240:
                            return -0.5;
                        case 135:
                        case 235:
                            return -Math.Round(Math.Sqrt(2) / 2, 10);
                        case 150:
                        case 210:
                            return -Math.Round(Math.Sqrt(3) / 2, 10);
                        case 180:
                            return -1;
                        case 90:
                        case 270:
                            return 0;
                    }
                    break;
                case "Tg":
                case "tg":
                    switch (a)
                    {
                        case 0:
                        case 180:
                        case 360:
                            return 0;
                        case 30:
                        case 210:
                            return 1 / Math.Sqrt(3);
                        case 45:
                        case 225:
                            return 1;
                        case 60:
                        case 240:
                            return Math.Sqrt(3);
                        case 90:
                        case 270:
                            return -1;
                        case 120:
                        case 300:
                            return -Math.Sqrt(3);
                    }
                    break;
            }
            return 0;
        }

    }

    class Program:Func
    {
        static void Main(string[] args)
        {
            string key;
            double a=0,b=0;
            Math.Round(a, 10);
            Math.Round(b, 10);
            Console.WriteLine("Главное меню:\nСложение(+)\nВычитание(-)\nДеление(/)\t\t  Символы в скобках\nУмножение(*)\t   подразумевают синтаксик который\nСтепень(sqr)\t\tдолжен использоваться\nКорень(sqrt)\nФакториал(!)\nМодуль(mod)\nСинус(sin)\nКосинус(cos)\nТангенс(tg)\nКотангенс(ctg)\nДонаты(don)\nВозврат в главное меню(gob)\nВыход из консоли(end)");
            key = Console.ReadLine();
            while (key!="end")
            {
                Console.Clear();
                switch (key)
                {
                    case "+":
                        Console.Write("Первое слагаемое: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Второе слагаемое: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Результат cложения: {}") ;
                        break;
                    case "*":
                        Console.Write("Первый множитель: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Второй множитель: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Результат умножения: {Math.Round(a * b,10)}");
                        break;
                    case "-":
                        Console.Write("Введите уменьшаемое: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите вычитаемое: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Результат разности: {a - b}");
                        break;
                    case "/":
                        Console.Write("Введите делимое: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите делитель: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Результат деления: {Math.Round(a / b,10)}");
                        break;
                    case "sqr":
                    case "Sqr":
                        Console.Write("Введите степень: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите число: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Результат: {Math.Pow(b,a)}");
                        break;
                    case "sqrt":
                        Console.Write("Введите степень: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите число: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Результат: {Math.Round(Math.Pow(b, 1/a),10)}");
                        break;
                    case "!":
                        Console.Write("Введите число: ");
                        a = Convert.ToInt32(Console.ReadLine());                   
                        Console.WriteLine($"Результат: {Fac(a)}");
                        break;
                    case "mod":
                        Console.Write("Введите число: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Результат: {Mod(a)}");
                        break;
                    case "sin":  
                        Console.Write("Введите количество градусов: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Результат: {trig(key ,a)}");
                        break;




                }
                key = Console.ReadLine();
            }
        }
    }
}
