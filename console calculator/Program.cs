using System;


namespace console_calculator
{
    internal class Program
    {

        static void Main()
        {
            while (true)
            {
                Console.Clear();
                double a, b;
                string result;
                try
                {
                    Console.WriteLine("enter a number ");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("enter a number ");
                    b = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("The wrong symbol!!");
                    Console.ReadLine();
                    continue;
                }
                Console.WriteLine("select an operation: '+' '-' '*' '/' ");
                result = Console.ReadLine();
                switch (result)
                {
                    case "+":
                        Console.WriteLine(a + b);
                        break;
                    case "-":
                        Console.WriteLine(a - b);
                        break;
                    case "*":
                        Console.WriteLine(a * b);
                        break;
                    case "/":
                        Console.WriteLine(a / b);
                        break;
                    default:
                        Console.WriteLine("Mistake! Try again!");
                        break;
                }

                Console.ReadLine();

            }
        }
    }
}
