public class InvalidTemperatureException : Exception
{
    public InvalidTemperatureException(string message) : base(message)
    {
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Test 1: SetTemperature(25)");
        SetTemperature(25);
        Console.WriteLine();

        Console.WriteLine("Test 2: SetTemperature(60)");
        SetTemperature(60);
        Console.WriteLine();
    }

    public static void SetTemperature(int temperature)
    {
        try
        {
            if (temperature < -50 || temperature > 50)
            {
                throw new InvalidTemperatureException("Temperature out of range!");
            }
            Console.WriteLine($"Temperature set to {temperature} degrees.");
        }
        catch (InvalidTemperatureException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
