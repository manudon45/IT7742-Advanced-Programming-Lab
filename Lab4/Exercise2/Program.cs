using Exercise2;

public static class Program
{
    public static void Main()
    {
        Circle circle = new Circle { Radius = 5 };
        circle.Draw();
        Console.WriteLine($"Circle Area: {circle.Area}");

        Console.WriteLine();

        Rectangle rectangle = new Rectangle { Width = 4, Height = 6 };
        rectangle.Draw();
        Console.WriteLine($"Rectangle Area: {rectangle.Area}");
    }
}
