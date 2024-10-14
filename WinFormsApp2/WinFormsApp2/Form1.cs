namespace WinFormsApp2
{
    public partial class user_login : Form
    {
        private int count = 0;
        private int maxcount = 3;
        public user_login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user, password;
            user = "shahmir";
            password = "22011556-056";
            if ((textBox1.Text == user) && (textBox2.Text == password))
            {
                MessageBox.Show("Welcome User");
                // Open the data_form after successful login
                data_form dataForm = new data_form();
                dataForm.Show();
                this.Hide(); // Hide the login form
            }
            else
            {
                count++;
                int remain = maxcount - count;
                MessageBox.Show("Wrong user name or password" + "\t" + remain + " tries left");
                textBox2.Clear();
                textBox1.Clear();
                textBox1.Focus();
                if (count >= maxcount)
                {
                    MessageBox.Show("Max tries exceeded.");
                    Application.Exit();
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); // Clear the username textbox
            textBox2.Clear(); // Clear the password textbox
            textBox1.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
