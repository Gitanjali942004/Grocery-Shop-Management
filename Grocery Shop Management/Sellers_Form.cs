using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery_Shop_Management
{
    public partial class Sellers_Form : Form
    {
        public Sellers_Form()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Grocery_Shop_Management;Integrated Security=True");

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sellers_Form_Load(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from ItemsData", Con);
            Con.Close();
            DataTable dt = new DataTable();
            da.Fill(dt);
            stockdatagrid.DataSource = dt;
        }

        int stock=0,Key=0 ;
        private void stockdatagrid_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Grocery_Shop_Management;Integrated Security=True");
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from ItemsData where Item_Id='" + stockdatagrid.Rows[stockdatagrid.SelectedCells[0].RowIndex].Cells[0].Value + "'", Con);
                DataTable dt = new DataTable();
                Con.Close();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txtitem.Text = dt.Rows[0][1].ToString();
                    txtprice.Text = dt.Rows[0][3].ToString();
                }
                if(txtitem.Text=="")
                {
                    stock = 0;
                    Key = 0;
                }
                else
                {
                    stock = Convert.ToInt32(stockdatagrid.SelectedRows[0].Cells[2].Value.ToString());
                    Key= Convert.ToInt32(stockdatagrid.SelectedRows[0].Cells[0].Value.ToString());
                }

            }
            catch (Exception ex)
            {

            }
        }

      

        int n = 0,GrdTotal=0;
        private void btnaddtobill_Click(object sender, EventArgs e)
        {
           
            Con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from ItemsData where Item_Id='" + stockdatagrid.Rows[stockdatagrid.SelectedCells[0].RowIndex].Cells[0].Value + "'", Con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Con.Close();
              dt.Rows[0][2].ToString();
            int Availablestock = Convert.ToInt32(dt.Rows[0][2].ToString());
            if (txtquantity.Text==""|| Convert.ToInt32(txtquantity.Text)> Availablestock)
            {
                MessageBox.Show("Check Available Quantity");
            }
            else
            {
                int total = Convert.ToInt32(txtquantity.Text) * Convert.ToInt32(txtprice.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(billdatagrid);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = txtitem.Text;
                newRow.Cells[2].Value =  txtprice.Text;
                newRow.Cells[3].Value = txtquantity.Text;
                newRow.Cells[4].Value = total;
                billdatagrid.Rows.Add(newRow);
                GrdTotal = GrdTotal + total;
                TotalLbl.Text = "Rs" + GrdTotal;
               

                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Tbl_bill values('" + newRow.Cells[0].Value + "' , '" + txtitem.Text + "' , '" + txtprice.Text + "' , '" + txtquantity.Text + "','" + total + "','" + txtclientname.Text + "' ) ", Con);
                cmd.ExecuteNonQuery();
                Con.Close();


                n++;
                Reset();
            }
        }
       
        private void Reset()
        {
            txtitem.Text = "";
            txtquantity.Text = "";
            txtprice.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportviewerform frm = new reportviewerform();
            frm.Billcr("Select * from Tbl_bill");
            frm.Show();
        }

        private void newcust_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Delete from Tbl_bill ");
            cmd.Connection = Con;
            cmd.ExecuteNonQuery();
            Con.Close();

            billdatagrid.Rows.Clear();
            TotalLbl.Text = "Total" ;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Delete from Tbl_bill ");
            cmd.Connection = Con;
            cmd.ExecuteNonQuery();
            Con.Close();

            billdatagrid.Rows.Clear();
            TotalLbl.Text = "Total";

            this.Close();
            Login_Form_2 lgnobj=new Login_Form_2();
            lgnobj.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Delete from Tbl_bill ");
            cmd.Connection = Con;
            cmd.ExecuteNonQuery();
            Con.Close();

            billdatagrid.Rows.Clear();
            TotalLbl.Text = "Total";

            Reset();
            txtclientname.Text = "";
        }

        private void btnreset_Click_1(object sender, EventArgs e)
        {
            Reset();
        }

        private void billdatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
