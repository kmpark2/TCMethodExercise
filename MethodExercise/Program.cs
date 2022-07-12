using System;

namespace MethodExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string userColor = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string userAnimal = Console.ReadLine();
            Console.WriteLine("What is the name of your favorite band?");
            string userBand = Console.ReadLine();

            Console.WriteLine($"{userName} decided to dress as a(n) {userColor} {userAnimal} for the biggest concert of {userBand} this year.");

            Console.WriteLine("Pick a number 'a'");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Pick a second number 'b'");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Add(num1, num2);
            Console.WriteLine($"Sum (a + b): {sum}");
            int diff = Subtract(num1, num2);
            Console.WriteLine($"Difference (a - b): {diff}");
            int product = Multiply(num1, num2);
            Console.WriteLine($"Product (a * b): {product}");
            double quotient = Divide(num1, num2);
            Console.WriteLine($"Quotient (a / b): {quotient}");
            int mod = Modulus(num1, num2);
            Console.WriteLine($"Modulus (a % b): {mod}");
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }
    }
}
