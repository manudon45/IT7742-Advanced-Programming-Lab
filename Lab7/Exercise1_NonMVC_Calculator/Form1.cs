using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Exercise1_NonMVC_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNumber1.Text);
            int num2 = int.Parse(txtNumber1.Text);
            int sum = num1 + num2;
            lblResult.Text = "The sum is: " + sum;
        }
    }
}
