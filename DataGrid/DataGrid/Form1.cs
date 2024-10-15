using System.Data;
using System.Windows.Forms;
namespace DataGrid
{
    public partial class Form1 : Form
    {
        private DataTable dt; // Declare DataTable as a member variable
        public Form1()
        {
            InitializeComponent();
            InitializeDataTable(); // Initialize the DataTable in the constructor
        }
        private void InitializeDataTable()
        {
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Course id", typeof(int)));
            dt.Columns.Add(new DataColumn("Course Name", typeof(string)));
            dt.Columns.Add(new DataColumn("Course Marks", typeof(double)));
            dt.Columns.Add(new DataColumn("Course Grade", typeof(char)));
            dt.Columns.Add(new DataColumn("Course Status", typeof(string)));
            dataGridView1.DataSource = dt; // Set the DataSource once
        }
        public void createnewrow()
        {
            // Validate input and parse appropriately
            int courseId;
            double creditHour;
            char courseGrade;
            string courseName = textBox2.Text;
            string courseStatus = textBox5.Text;
            if (int.TryParse(textBox1.Text, out courseId) &&
                double.TryParse(textBox3.Text, out creditHour) &&
                char.TryParse(textBox4.Text, out courseGrade))
            {
                dt.Rows.Add(courseId, courseName, creditHour, courseGrade, courseStatus);
            }
            else
            {
                MessageBox.Show("Please enter valid data.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createnewrow();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Error Printer not Found.");
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}