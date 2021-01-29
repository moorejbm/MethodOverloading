using System;

namespace MethodOverloading
{
    class Program
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        public static string Add(int num1, int num2, bool isCheck)
        {
            var sum = num1 + num2;

            if (isCheck == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isCheck == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return sum.ToString();
            }
        }

        static void Main(string[] args)
        {
            var a = 5;
            var b = 6;
            var number = Add(a, b);
            Console.WriteLine(number);
            Console.WriteLine();

            var x = 32.7m;
            var y = 45.1m;

            var decimalAnswer = Add(x, y);

            var thirdAnswer = Add(a, b, true);

            Console.WriteLine($"int add: {number} decimal add: {decimalAnswer}");
            Console.WriteLine();
            Console.WriteLine(thirdAnswer);
        }
    }
}
