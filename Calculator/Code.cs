using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Code
    {
        public static void Main(String[] args)
        {
            while (true)
            {
                Console.WriteLine("======================");
                Console.WriteLine("      Calculator      ");
                Console.WriteLine("======================");
                int a = readint("First number: ");
                Console.WriteLine("Choose action: +, -, *, /, %");
                String action = Console.ReadLine();
                int b = readint("Second number: ");

                switch (action)
                {
                    case "+":
                        add(a, b);
                        break;
                    case "-":
                        sub(a, b);
                        break;
                    case "*":
                        mul(a, b);
                        break;
                    case "/":
                        div(a, b);
                        break;
                    case "%":
                        modulo(a, b);
                        break;
                    default:
                        Console.WriteLine("Wrong command");
                        break;
                }

                if (action == "exit")
                {
                    break;
                }
            }

            static int readint(String a)
            {
                int result;
                try
                {
                    Console.WriteLine(a);
                    return result = (int)Convert.ToInt64(Console.ReadLine());
                }
                catch (FormatException)
                {
                    return 0;
                }
            }

            static void add(int a, int b)
            {
                Console.WriteLine(a + b);
            }

            static void sub(int a, int b)
            {
                Console.WriteLine(a - b);
            }

            static void mul(int a, int b)
            {
                Console.WriteLine(a * b);
            }

            static void div(int a, int b)
            {
                try
                {
                    Console.WriteLine(a / b);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero");
                }
            }

            static void modulo(int a, int b)
            {
                try
                {
                    Console.WriteLine(a % b);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero");
                }
            }
        }
    }
}