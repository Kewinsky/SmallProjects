using System.Text.RegularExpressions;


namespace call_log_management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(textBox1.Text.Length > 0)
                {
                textBox2.Focus();

                }
                else
                {
                    textBox1.Focus();
                }
            }
        }

        
        private void textBox2_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox2.Text.Length > 0)
                {
                    textBox3.Focus();

                }
                else
                {
                    textBox2.Focus();
                }
            }
        }

    private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox3.Text.Length > 0)
                {
                    textBox4.Focus();

                }
                else
                {
                    textBox3.Focus();
                }
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox4.Text.Length > 0)
                {
                    button1.Focus();

                }
                else
                {
                    textBox4.Focus();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox1, "Filed Requried");
            }
            else if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox2, "Filed Requried");
            }
            else
            {
                MessageBox.Show("Confirmed !", "Information");
            }

        }
    }
}