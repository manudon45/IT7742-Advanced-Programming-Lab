public class Program
{
    public static void Main()
    {
        Console.WriteLine("====== Multiple Exception Handling Example =========\n");

        Console.WriteLine("Test 1- ParseAndDivide(\"10\", \"2\")");
        ParseAndDivide("10", "2");
        Console.WriteLine();

        Console.WriteLine("Test 2 ParseAndDivide(\"abc\", \"2\")");
        ParseAndDivide("abc", "2");
        Console.WriteLine();

        Console.WriteLine("Test 3 ParseAndDivide(\"10\", \"0\")");
        ParseAndDivide("10", "0");
        Console.WriteLine();
    }

    public static void ParseAndDivide(string num1, string num2)
    {
        try
        {
            int firstNumber = int.Parse(num1);
            int secondNumber = int.Parse(num2);
            int result = firstNumber / secondNumber;
            Console.WriteLine($"Result: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Input must be a valid integer.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
    }
}
