namespace Exercise4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CourseSelectionComboBox.Items.AddRange(new string[] { "Mathematics", "Science", "History" });
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = StudentNameTextbox.Text;
            string id = StudentIdTextbox.Text;
            string course = CourseSelectionComboBox.SelectedItem?.ToString();
            DateTime enrollmentDate = dateTimePicker1.Value;

            Student newStudent = new Student
            {
                Name = name,
                ID = id,
                Course = course,
                EnrollmentDate = enrollmentDate
            };

            listBox1.Items.Add(newStudent);
        }
    }
}
