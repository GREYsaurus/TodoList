namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            Console.WriteLine("Input the first number:");
            var firstAsText = Console.ReadLine();
            var number1 = int.Parse(firstAsText);

            Console.WriteLine("Input the second number:");
            var secondAsText = Console.ReadLine();
            var number2 = int.Parse(secondAsText);

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("[A]dd");
            Console.WriteLine("[S]ubtract");
            Console.WriteLine("[M]ultiply");
            var choice = Console.ReadLine();

            if (EqualsCaseInsensitive(choice, "a"))
            {
                var result = number1 + number2;
                PrintFinalEquation(number1, number2, "+", result);
            }
            else if (EqualsCaseInsensitive(choice, "s"))
            {
                var result = number1 - number2;
                PrintFinalEquation(number1, number2, "-", result);
            }
            else if (EqualsCaseInsensitive(choice, "m"))
            {
                var result = number1 * number2;
                PrintFinalEquation(number1, number2, "*", result);
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

            Console.WriteLine("Press any key to close.");
            Console.ReadKey();

            void PrintFinalEquation(int num1, int num2, string operation, int result)
            {
                Console.WriteLine($"{num1} {operation} {num2} = {result}");
            }

            bool EqualsCaseInsensitive(string input, string comparison)
            {
                return string.Equals(input, comparison, StringComparison.OrdinalIgnoreCase);
            }
        }
    }
}
