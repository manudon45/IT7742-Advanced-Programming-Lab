namespace UnitTestingLab
{
    public class Calculator
    {
        /// <param name="a">The first number</param>
        /// <param name="b">The second number</param>
        /// <returns>The sum of a and b</returns>
        public int Add(int a, int b)
        {
            return a + b;
        }

        /// <param name="a">The first number</param>
        /// <param name="b">The second number to subtract</param>
        /// <returns>The difference (a - b)</returns>
        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("=== Unit Testing Lab: Calculator ===\n");

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

            Console.WriteLine("Run the unit tests to verify all operations work correctly!");
        }
    }
}
