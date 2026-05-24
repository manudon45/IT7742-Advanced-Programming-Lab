using System;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            // CAR
            Car myCar = new Car("Toyota", "Camry", 2023);

            myCar.DisplayInfo();
            myCar.StartEngine();

            // PERSON
            Person person = new Person();
            person.DisplayInfo();

            // COUNTER
            Counter counter1 = new Counter();
            Counter counter2 = new Counter();

            counter1.Increment();
            counter1.Increment();
            counter2.Increment();

            Console.WriteLine($"Current Count: {Counter.GetCount()}");

            // CALCULATOR
            Calculator calculator = new Calculator();

            int result1 = calculator.Add(5, 10);
            Console.WriteLine($"Add(5, 10) = {result1}");

            int result2 = calculator.Add(5, 11, 125);
            Console.WriteLine($"Add(5, 11, 125) = {result2}");

            int result3 = calculator.Add(5, 11, 25, 40);
            Console.WriteLine($"Add(5, 11, 25, 40) = {result3}");
        }
    }
}
