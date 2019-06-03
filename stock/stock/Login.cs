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

namespace stock
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtuser.Text = "";
            txtpass.Text = "";
            txtuser.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-DELL-30;Initial Catalog=testdb;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter(@"select * from Stock.dbo.Login where username = '"+txtuser.Text+"' and password = '"+txtpass.Text+"'",conn);
            DataTable  dt = new DataTable();
            sda.Fill(dt);  

            if(dt.Rows.Count == 1)
            {
                this.Hide();
                StockMain main = new StockMain();
                main.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username/Password..!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button2_Click(sender, e);

            }
}
    }
}
