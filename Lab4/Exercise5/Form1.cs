namespace Exercise5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string itemName = textBox1.Text;
            string itemCode = textBox2.Text;
            string quantityText = textBox3.Text;
            string priceText = textBox4.Text;

            var parseQuantity = int.TryParse(quantityText, out int quantity);
            if (!parseQuantity)
            {
                MessageBox.Show("Please enter a valid quantity (whole number).");
                return;
            }

            var parsePrice = decimal.TryParse(priceText, out decimal price);
            if (!parsePrice)
            {
                MessageBox.Show("Please enter a valid price (decimal number).");
                return;
            }

            StockItem newItem = new StockItem
            {
                ItemName = itemName,
                ItemCode = itemCode,
                Quantity = quantity,
                Price = price
            };

            listBox1.Items.Add(newItem);
        }
    }
}
