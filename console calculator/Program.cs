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
                double the first number, the second number;
                string result;
                try
                {
                    Console.WriteLine("enter a number ");
                    the first number = double.Parse(Console.ReadLine());
                    Console.WriteLine("enter a number ");
                    the second number = double.Parse(Console.ReadLine());
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
                        Console.WriteLine(the first number + the second number);
                        break;
                    case "-":
                        Console.WriteLine(the first number - the second number);
                        break;
                    case "*":
                        Console.WriteLine(the first number * the second number);
                        break;
                    case "/":
                        Console.WriteLine(the first number / the second number);
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
