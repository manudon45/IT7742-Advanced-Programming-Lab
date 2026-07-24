namespace Exercise7
{
    public class NegativeAgeException : Exception
    {
        public NegativeAgeException(string message) : base(message)
        {
        }
    }

    public class AgeOutOfRangeException : Exception
    {
        public AgeOutOfRangeException(string message) : base(message)
        {
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                int age = int.Parse(txtAge.Text);

                if (age < 0)
                {
                    throw new NegativeAgeException("Age cannot be negative.");
                }
                if (age > 120)
                {
                    throw new AgeOutOfRangeException("Age is not realistic.");
                }

                lblMessage.Text = "Age submitted successfully: " + age;
            }
            catch (FormatException)
            {
                lblMessage.Text = "Please enter a valid number.";
            }
            catch (NegativeAgeException ex)
            {
                lblMessage.Text = ex.Message;
            }
            catch (AgeOutOfRangeException ex)
            {
                lblMessage.Text = ex.Message;
            }
        }
    }
}
