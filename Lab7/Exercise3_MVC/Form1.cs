namespace Exercise3_MVC
{
    public partial class Form1 : Form
    {
        private CalculatorController controller;

        public Form1()
        {
            InitializeComponent();
            controller = new CalculatorController();

            button2.Click += button2_Click;
            button3.Click += button3_Click;
            button4.Click += button4_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtNumber1.Text, out int num1) && 
                    int.TryParse(txtNumber2.Text, out int num2))
                {
                    // Delegate the calculation to the controller
                    int result = controller.PerformAddition(num1, num2);
                    lblResult.Text = $"Result: {result}";
                }
                else
                {
                    lblResult.Text = "Error: Please enter valid integers";
                }
            }
            catch (Exception ex)
            {
                lblResult.Text = $"Error: {ex.Message}";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtNumber1.Text, out int num1) && 
                    int.TryParse(txtNumber2.Text, out int num2))
                {
                    int result = controller.PerformSubtraction(num1, num2);
                    lblResult.Text = $"Result: {result}";
                }
                else
                {
                    lblResult.Text = "Error: Please enter valid integers";
                }
            }
            catch (Exception ex)
            {
                lblResult.Text = $"Error: {ex.Message}";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtNumber1.Text, out int num1) && 
                    int.TryParse(txtNumber2.Text, out int num2))
                {
                    int result = controller.PerformMultiplication(num1, num2);
                    lblResult.Text = $"Result: {result}";
                }
                else
                {
                    lblResult.Text = "Error: Please enter valid integers";
                }
            }
            catch (Exception ex)
            {
                lblResult.Text = $"Error: {ex.Message}";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtNumber1.Text, out int num1) && 
                    int.TryParse(txtNumber2.Text, out int num2))
                {
                    double result = controller.PerformDivision(num1, num2);
                    lblResult.Text = $"Result: {result:F2}";
                }
                else
                {
                    lblResult.Text = "Error: Please enter valid integers";
                }
            }
            catch (ArgumentException ex)
            {
                lblResult.Text = $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                lblResult.Text = $"Error: {ex.Message}";
            }
        }
    }
}
