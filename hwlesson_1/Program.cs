using System;

namespace hwlesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length >= 3)
            {
                int arg1 = int.Parse(args[0]);
                int arg2 = int.Parse(args[1]);
                string oper = args[2];
                int res = 0;

                switch (oper)
                {
                    case "+": res = arg1 + arg2; break;
                    case "-": res = arg1 - arg2; break;
                    case "*": res = arg1 * arg2; break;
                    case "/": res = arg1 / arg2; break;
                }

                Console.WriteLine($"Arguments: {arg1}, {arg2}, {oper}");
                Console.WriteLine($"Result + 10: {res + 10}");
            }

            Console.ReadKey();
        }
    }
}