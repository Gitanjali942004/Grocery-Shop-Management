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

namespace Grocery_Shop_Management
{
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Grocery_Shop_Management;Integrated Security=True");


        private void Items_Load(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from ItemsData", Con);
            Con.Close();
            DataTable dt = new DataTable();
            da.Fill(dt);
            Itemdatagrid.DataSource = dt;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Items fr = new Items();
            fr.Show();
        }

        private void mngemplable_Click(object sender, EventArgs e)
        {
            this.Close();
            adminemployee frm = new adminemployee();
            frm.Show();
        }


        //ADD ITEMS
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtquantity.Text == "" || txtprice.Text == "" || cmbboxCategory.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into  ItemsData values('" + txtname.Text + "' , '" + txtquantity.Text + "' , '" + txtprice.Text + "' , '" + cmbboxCategory.Text + "' ) ", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Saved Successfully");
                    Con.Close();


                   

                    SqlDataAdapter da = new SqlDataAdapter("Select * from ItemsData ", Con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Itemdatagrid.DataSource = dt;
                    txtname.Clear();
                    txtquantity.Clear();
                    txtprice.Clear();
                    cmbboxCategory.Text = string.Empty;
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }


        //REFRESH FORM
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtquantity.Clear();
            txtprice.Clear();
            cmbboxCategory.Text = string.Empty;
            MessageBox.Show("Refreshed Successfully");
         
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Update ItemsData set Item_Name='" + txtname.Text + "', Item_Quantity = '" + txtquantity.Text + "',Item_Price='" + txtprice.Text + "', Item_Category= '" + cmbboxCategory.SelectedItem.ToString() + "' where Item_Id='" + Itemdatagrid.Rows[Itemdatagrid.SelectedCells[0].RowIndex].Cells[0].Value + "' ");
                cmd.Connection = Con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                Con.Close();

                SqlDataAdapter da = new SqlDataAdapter("Select * from ItemsData", Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Itemdatagrid.DataSource = dt;
                txtname.Clear();
                txtquantity.Clear();
                txtprice.Clear();
                cmbboxCategory.Text = string.Empty;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Itemdatagrid_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Grocery_Shop_Management;Integrated Security=True");

                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from ItemsData where Item_Id='" + Itemdatagrid.Rows[Itemdatagrid.SelectedCells[0].RowIndex].Cells[0].Value + "'", Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txtname.Text = dt.Rows[0][1].ToString();
                    txtquantity.Text = dt.Rows[0][2].ToString();
                    txtprice.Text = dt.Rows[0][3].ToString();
                    cmbboxCategory.Text = dt.Rows[0][4].ToString();

                }

            }
            catch (Exception ex)
            {

            }
        }


        //Delete Item
        private void btndelete_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Delete from ItemsData where Item_Id='" + Itemdatagrid.Rows[Itemdatagrid.SelectedCells[0].RowIndex].Cells[0].Value + "'");
            cmd.Connection = Con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted Successfully");
            Con.Close();

            SqlDataAdapter da = new SqlDataAdapter("Select * from ItemsData", Con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Itemdatagrid.DataSource = dt;

            txtname.Clear();
            txtquantity.Clear();
            txtprice.Clear();
            cmbboxCategory.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Login_Form_2 lgnobj = new Login_Form_2();
            lgnobj.Show();
        }
    }
}
