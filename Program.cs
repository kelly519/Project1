using System;

namespace NumberBaseConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number (decimal, octal, or hexadecimal): ");
            string input = Console.ReadLine();

            int num;

            if (input.StartsWith("0x"))
            {
                // Input is a hexadecimal number
                input = input.Substring(2);
                num = Convert.ToInt32(input, 16);
            }
            else if (input.StartsWith("0"))
            {
                // Input is an octal number
                num = Convert.ToInt32(input, 8);
            }
            else
            {
                // Input is a decimal number
                num = Convert.ToInt32(input);
            }

            Console.WriteLine("Decimal: " + num);
            Console.WriteLine("Binary: " + Convert.ToString(num, 2));
            Console.WriteLine("Octal: " + Convert.ToString(num, 8));
            Console.WriteLine("Hexadecimal: " + Convert.ToString(num, 16));

            Console.ReadLine();
        }
    }
}
