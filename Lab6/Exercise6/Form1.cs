namespace Exercise6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(txtNumber1.Text);
                int num2 = int.Parse(txtNumber2.Text);
                int result = num1 + num2;
                lblResult.Text = result.ToString();
            }
            catch (FormatException)
            {
                lblResult.Text = "Input must be a valid number.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(txtNumber1.Text);
                int num2 = int.Parse(txtNumber2.Text);
                int result = num1 - num2;
                lblResult.Text = result.ToString();
            }
            catch (FormatException)
            {
                lblResult.Text = "Input must be a valid number.";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(txtNumber1.Text);
                int num2 = int.Parse(txtNumber2.Text);
                int result = num1 * num2;
                lblResult.Text = result.ToString();
            }
            catch (FormatException)
            {
                lblResult.Text = "Input must be a valid number.";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(txtNumber1.Text);
                int num2 = int.Parse(txtNumber2.Text);
                int result = num1 / num2;
                lblResult.Text = result.ToString();
            }
            catch (FormatException)
            {
                lblResult.Text = "Input must be a valid number.";
            }
            catch (DivideByZeroException)
            {
                lblResult.Text = "Cannot divide by zero.";
            }
        }
    }
}
