using System;

namespace ConsoleApp
{
    class Program
    {
        delegate T Operation<T>(T x, T y);
        static void Main(string[] args)
        {
            string exit = "";
            Operation<double> operation;
            while (exit != "exit")
            {
                Console.Write("First number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.Write($"\n1. Plus.  2. Minus.  3.Muple.  4.devision.  5. exit.\n\nYour choice:  ");
                var choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        operation = Sum;
                        var result_sum = operation?.Invoke(num1, num2);
                        Console.WriteLine($" Resoult: {result_sum}");
                        break;
                    case 2:
                        operation = Subtract;
                        var result_subt = operation?.Invoke(num1, num2);
                        Console.WriteLine($"Resoult: {result_subt}");
                        break;
                    case 3:
                        operation = Multiply;
                        var result_mult = operation?.Invoke(num1, num2);
                        Console.WriteLine($"Resoult: {result_mult}");
                        break;
                    case 4:
                        operation = Divide;
                        var result_div = operation?.Invoke(num1, num2);
                        Console.WriteLine($"Resoult: {result_div}");
                        break;
                    case 5:
                        exit = "exit";
                        break;
                    default:
                        Console.WriteLine("Something went wrong");
                        break;
                }
                Console.WriteLine("Press Any key . . .");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static T Sum<T>(T x, T y)
        {
            return (dynamic)x + (dynamic)y;
        }
        static T Subtract<T>(T x, T y)
        {
            return (dynamic)x - (dynamic)y;
        }
        static T Multiply<T>(T x, T y)
        {
            return (dynamic)x * (dynamic)y;
        }
        static T Divide<T>(T x, T y)
        {
            if ((dynamic)y == 0)
            {
                return default(T);
            }
            return (dynamic)x / (dynamic)y;
        }

    }
}
