namespace Exercise4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            StudentNameLabel = new Label();
            StudentIdLabel = new Label();
            StudentNameTextbox = new TextBox();
            StudentIdTextbox = new TextBox();
            CourseSelectionLabel = new Label();
            CourseSelectionComboBox = new ComboBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            EnrolStudentButton = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // StudentNameLabel
            // 
            StudentNameLabel.AutoSize = true;
            StudentNameLabel.Location = new Point(12, 29);
            StudentNameLabel.Name = "StudentNameLabel";
            StudentNameLabel.Size = new Size(83, 15);
            StudentNameLabel.TabIndex = 0;
            StudentNameLabel.Text = "Student Name";
            // 
            // StudentIdLabel
            // 
            StudentIdLabel.AutoSize = true;
            StudentIdLabel.Location = new Point(12, 83);
            StudentIdLabel.Name = "StudentIdLabel";
            StudentIdLabel.Size = new Size(62, 15);
            StudentIdLabel.TabIndex = 1;
            StudentIdLabel.Text = "Student ID";
            // 
            // StudentNameTextbox
            // 
            StudentNameTextbox.Location = new Point(101, 26);
            StudentNameTextbox.Name = "StudentNameTextbox";
            StudentNameTextbox.Size = new Size(100, 23);
            StudentNameTextbox.TabIndex = 2;
            // 
            // StudentIdTextbox
            // 
            StudentIdTextbox.Location = new Point(101, 80);
            StudentIdTextbox.Name = "StudentIdTextbox";
            StudentIdTextbox.Size = new Size(100, 23);
            StudentIdTextbox.TabIndex = 3;
            // 
            // CourseSelectionLabel
            // 
            CourseSelectionLabel.AutoSize = true;
            CourseSelectionLabel.Location = new Point(17, 136);
            CourseSelectionLabel.Name = "CourseSelectionLabel";
            CourseSelectionLabel.Size = new Size(95, 15);
            CourseSelectionLabel.TabIndex = 5;
            CourseSelectionLabel.Text = "Course Selection";
            // 
            // CourseSelectionComboBox
            // 
            CourseSelectionComboBox.FormattingEnabled = true;
            CourseSelectionComboBox.Location = new Point(118, 133);
            CourseSelectionComboBox.Name = "CourseSelectionComboBox";
            CourseSelectionComboBox.Size = new Size(121, 23);
            CourseSelectionComboBox.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 186);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 7;
            label1.Text = "Enrolment Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(118, 180);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // EnrolStudentButton
            // 
            EnrolStudentButton.Location = new Point(17, 232);
            EnrolStudentButton.Name = "EnrolStudentButton";
            EnrolStudentButton.Size = new Size(131, 23);
            EnrolStudentButton.TabIndex = 9;
            EnrolStudentButton.Text = "Enrol student";
            EnrolStudentButton.UseVisualStyleBackColor = true;
            EnrolStudentButton.Click += button1_Click_1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(432, 26);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(277, 229);
            listBox1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(EnrolStudentButton);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(CourseSelectionComboBox);
            Controls.Add(CourseSelectionLabel);
            Controls.Add(StudentIdTextbox);
            Controls.Add(StudentNameTextbox);
            Controls.Add(StudentIdLabel);
            Controls.Add(StudentNameLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StudentNameLabel;
        private Label StudentIdLabel;
        private TextBox StudentNameTextbox;
        private TextBox StudentIdTextbox;
        private Label CourseSelectionLabel;
        private ComboBox CourseSelectionComboBox;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Button EnrolStudentButton;
        private ListBox listBox1;
    }
}
