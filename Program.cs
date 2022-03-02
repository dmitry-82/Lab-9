using System;

namespace _9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double a, b = 0;
                char z;
                Console.Write("Консольный калькулятор 1 \nВведите 1 число ");
                a = double.Parse(Console.ReadLine());
                Console.Write("Введите действие (+, -, *, /, s) ");
                z = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (z != 's')
                {
                    Console.Write("Введите 2 число ");
                    b = double.Parse(Console.ReadLine());
                }
                switch (z)
                {
                    case '+':
                        Console.WriteLine("{0}+{1}={2}", a, b, a + b);
                        break;
                    case '-':
                        Console.WriteLine("{0}-{1}={2}", a, b, a - b);
                        break;
                    case '*':
                        Console.WriteLine("{0}*{1}={2}", a, b, a * b);
                        break;
                    case '/':
                        try
                        {
                            Console.WriteLine("{0}/{1}={2}", a, b, a / b);
                        }
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine("Ошибка - на ноль делить нельзя!");
                        }
                        finally
                        { 
                            Console.WriteLine("Ошибка - на ноль делить нельзя!");
                        }
                        break;
                    case 's':
                        Console.WriteLine("sqrt({0})={1}", a, Math.Sqrt(a));
                        break;
                    default:
                        Console.WriteLine("Ошибка");
                        
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
