namespace Exercise3_MVC
{
    public class CalculatorController
    {
        private CalculatorModel model;

        public CalculatorController()
        {
            model = new CalculatorModel();
        }

        public int PerformAddition(int num1, int num2)
        {
            return model.Add(num1, num2);
        }

        public int PerformSubtraction(int num1, int num2)
        {
            return model.Subtract(num1, num2);
        }

        public int PerformMultiplication(int num1, int num2)
        {
            return model.Multiply(num1, num2);
        }

        public double PerformDivision(int num1, int num2)
        {
            return model.Divide(num1, num2);
        }
    }
}
