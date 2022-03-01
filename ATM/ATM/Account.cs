using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATM
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=ATMdb;Integrated Security=True;Pooling=False");
        private void button1_Click(object sender, EventArgs e)
        {
            if (AccNameTb.Text == "" || AccNumTb.Text == "" || SurnameTb == "" || PhoneTb.Text == "" || AddressTb.Text == "" || OccupationTb.Text == "" || PinTb == "")
            {

            }
            else
            {
                try
                {
                    con.Open();
                    con.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,)
                }
            }
        }
    }
}
