namespace Login_form
{
    public partial class Form1 : Form
    {
        Double count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = "zulqarnain_ali";
            pass = "22011556-114";

            if ((textBox1.Text == user) && (textBox2.Text == pass))
            {
                MessageBox.Show("Welcome User");
            }
            else
            {

                count = count + 1;
                double maxcount = 3;
                double remain;
                remain = maxcount - count;
                MessageBox.Show("Wrong user name or password " + "\t" + remain + "" + "tries left");
                textBox2.Clear();
                textBox1.Clear();
                textBox1.Focus();
                if (count == maxcount)
                {
                    MessageBox.Show("Max try exceeded.");
                    Application.Exit();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //txtPass.Text = "";

            //txtPass.Text = string.Empty;
            textBox2.Clear();
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
