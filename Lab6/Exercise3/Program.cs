public class Program
{
    public static void Main()
    {
        Console.WriteLine("Test 1: DivideNumbers(10, 2)");
        DivideNumbers(10, 2);
        Console.WriteLine();

        Console.WriteLine("Test 2: DivideNumbers(10, 0)");
        DivideNumbers(10, 0);
        Console.WriteLine();
    }

    public static void DivideNumbers(int a, int b)
    {
        try
        {
            int result = a / b;
            Console.WriteLine(result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        finally
        {
            Console.WriteLine("Execution completed.");
        }
    }
}
