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
                Console.WriteLine("Type 'exit' to exit the program");
                
                int a = readint("First number: ");
                if (a == int.MinValue) break;

                Console.WriteLine("Choose action: +, -, *, /, %");
                String action = Console.ReadLine();
                if (action.ToLower() == "exit") break;

                int b = readint("Second number: ");
                if (b == int.MinValue) break;


                switch (action)
                {
                    case "+":
                        Console.WriteLine(add(a, b));
                        break;
                    case "-":
                        Console.WriteLine(sub(a, b));
                        break;
                    case "*":
                        Console.WriteLine(mul(a, b));
                        break;
                    case "/":
                        Console.WriteLine(div(a, b));
                        break;
                    case "%":
                        Console.WriteLine(modulo(a, b));
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

            static int readint(String prompt)
            {
                Console.WriteLine(prompt);
                String input = Console.ReadLine();

                if (input.ToLower() == "exit") return int.MinValue;
                


                try
                {
                    return (int)Convert.ToInt64(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input");
                    return readint(prompt);
                }
            }

            static int add(int a, int b) => a + b;


            static int sub(int a, int b) => a - b;

            static int mul(int a, int b) => a * b;

            static string div(int a, int b)
            {
                if (b == 0)
                    return "Unable to divide by zero";
                return (a / b).ToString();
            }

            static string modulo(int a, int b)
            {
                if (b == 0)
                    return "Cannot divide by zero";
                return (a % b).ToString();
            }
        }
    }
}