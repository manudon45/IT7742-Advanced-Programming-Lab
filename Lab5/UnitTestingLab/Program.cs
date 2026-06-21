namespace UnitTestingLab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("Unit Testing Lab: Calculator");

            // Addition examples
            Console.WriteLine("Addition Examples:");
            Console.WriteLine($"5 + 3 = {calculator.Add(5, 3)}");
            Console.WriteLine($"10 + (-3) = {calculator.Add(10, -3)}");
            Console.WriteLine($"42 + 0 = {calculator.Add(42, 0)}\n");

            // Subtraction examples
            Console.WriteLine("Subtraction Examples:");
            Console.WriteLine($"10 - 3 = {calculator.Subtract(10, 3)}");
            Console.WriteLine($"10 - (-5) = {calculator.Subtract(10, -5)}");
            Console.WriteLine($"42 - 0 = {calculator.Subtract(42, 0)}\n");

            // Division examples
            Console.WriteLine("Division Examples:");
            Console.WriteLine($"10 / 2 = {calculator.Divide(10, 2)}");
            Console.WriteLine($"15 / 4 = {calculator.Divide(15, 4)}");
            Console.WriteLine($"-10 / 2 = {calculator.Divide(-10, 2)}\n");

            // Factorial examples
            Console.WriteLine("Factorial Examples:");
            Console.WriteLine($"0! = {calculator.Factorial(0)}");
            Console.WriteLine($"5! = {calculator.Factorial(5)}");
            Console.WriteLine($"10! = {calculator.Factorial(10)}\n");
        }
    }
}
