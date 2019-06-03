using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }// end of constructor
        private void Products_Load(object sender, EventArgs e)
        {
            cmbprostatus.SelectedIndex = 1;
            loadData();
        }//private void Products_Load

        private void btnaddpro_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-DELL-30;Initial Catalog=testdb;Integrated Security=True");
                conn.Open();
                bool status = true;
                if(cmbprostatus.SelectedIndex == 0)
                {
                    status = false;
                }

                String sqlQuery = ""; 

                if(ifProductExist(conn, txtprocode.Text))
                {
                    sqlQuery = "update Stock.dbo.products set productname = '"+txtproname.Text+"', productstatus = '"+status+"' where productcode = '"+txtprocode.Text+"'";
                }
                else
                {
                    sqlQuery = @"INSERT INTO [Stock].[dbo].[products]([productname], [productstatus])
                                VALUES ('" + txtproname.Text + "','" + status + "')";
                }
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);

                cmd.ExecuteNonQuery();
                conn.Close();
                //clear text fields after data insertion
                txtprocode.Text = "";
                txtproname.Text = "";

                SqlDataAdapter sda = new SqlDataAdapter("select * from Stock.dbo.products",conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                DataGridView.Rows.Clear();

                foreach(DataRow item in dt.Rows)
                {
                    int n = DataGridView.Rows.Add();
                    DataGridView.Rows[n].Cells[0].Value = item["productcode"].ToString();
                    DataGridView.Rows[n].Cells[1].Value = item["productname"].ToString();
                    if ((bool)item["productstatus"] == false)
                    {
                        DataGridView.Rows[n].Cells[2].Value = "Deactive";
                    }
                    else
                    {
                        DataGridView.Rows[n].Cells[2].Value = "Active";
                    }

                }
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.ToString());
            }
        }//private void btnaddpro_Clic

        private bool ifProductExist(SqlConnection conn, String productcode)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from Stock.dbo.products where productcode = '"+productcode+"'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count > 0)
                return true;
            else
            return false;
        }
        public void loadData()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-DELL-30;Initial Catalog=testdb;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select * from Stock.dbo.products", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            DataGridView.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = DataGridView.Rows.Add();
                DataGridView.Rows[n].Cells[0].Value = item["productcode"].ToString();
                DataGridView.Rows[n].Cells[1].Value = item["productname"].ToString();
                if ((bool)item["productstatus"] == false)
                {
                    DataGridView.Rows[n].Cells[2].Value = "Deactive";
                }
                else
                {
                    DataGridView.Rows[n].Cells[2].Value = "Active";
                }
            }
        }//public void loadData()
        private void DataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            txtprocode.Text = DataGridView.SelectedRows[0].Cells[0].Value.ToString();
            txtproname.Text = DataGridView.SelectedRows[0].Cells[1].Value.ToString();
            if(DataGridView.SelectedRows[0].Cells[2].Value.ToString() == "Active")
            {
                cmbprostatus.SelectedIndex = 1;
            }
            else
            {
                cmbprostatus.SelectedIndex = 0;
            }
        }//DataGridView_MouseClick

        private void btndeletepro_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-DELL-30;Initial Catalog=testdb;Integrated Security=True");
                conn.Open();
                    SqlCommand cmd = new SqlCommand(@"delete from [Stock].[dbo].[products] where productcode = "+txtprocode.Text,conn);
                    cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ae)
            { MessageBox.Show(ae.ToString()); }
            //clear text fields after deletion
            txtprocode.Text = "";
            txtproname.Text = "";
            loadData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtprocode.Text = "";
            txtproname.Text = "";
        }
    }//public partial class Products
}//stock namespace
