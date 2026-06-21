using Exercise1;

public static class Program
{
    public static void Main(string[] args)
    {
        var car = new Car();
        var bicycle = new Bicycle();

        car.Move();
        car.Stop();

        bicycle.Move();
        bicycle.Stop();
    }
}