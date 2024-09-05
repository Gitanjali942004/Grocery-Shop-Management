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

namespace Grocery_Shop_Management
{
    public partial class adminemployee : Form
    {
        public adminemployee()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Grocery_Shop_Management;Integrated Security=True");
       
        private void Admin_Form_Load(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from EmployeeDetails", Con);
            Con.Close();
            DataTable dt = new DataTable();
            da.Fill(dt);
            empdetailsgrid1.DataSource = dt;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //  Form1 fr = new Form1();
            // fr.Show();
            panel2.Hide();
            pnlemp.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
           // pnlemp.Visible = false;
            Items fr = new Items();
            fr.Show();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        //Add Employee Details
        private void btnsave_Click(object sender, EventArgs e)
        {
            if(txtempname.Text==""|| txtempphnno.Text==""|| txtempaddress.Text==""|| txtemppswrd.Text=="")
            {
                MessageBox.Show("Please Fill All Details Of Employee");
            }
            else
            {
                try
                {

                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into EmployeeDetails values('"+txtempname.Text+"' , '" +txtempphnno.Text  +"' , '" +txtempaddress.Text + "' , '" +txtemppswrd.Text +"' ) ",Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Saved Successfully....!");
                    Con.Close();
                    

                    Con.Open();
                    String Usertype = "Seller";
                    SqlCommand cmd1 = new SqlCommand("insert into  login values('" + Usertype + "','" + txtempname.Text + "' ,  '" + txtemppswrd.Text + "' ) ", Con);
                    cmd1.ExecuteNonQuery();
                  

                    SqlDataAdapter da = new SqlDataAdapter("Select * from EmployeeDetails ", Con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    empdetailsgrid1.DataSource = dt;
                    Con.Close();
                }
                catch(Exception Ex )
                {
                    MessageBox.Show(Ex.Message);
                }
                Con.Close();
            }
        }

        private void empdetailsgrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        //To Display selected Record Data in respective Text Fields 
        private void empdetailsgrid1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Grocery_Shop_Management;Integrated Security=True");

                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from EmployeeDetails where Emp_ID='" + empdetailsgrid1.Rows[empdetailsgrid1.SelectedCells[0].RowIndex].Cells[0].Value + "'", Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txtempname.Text = dt.Rows[0][1].ToString();
                    txtempphnno.Text = dt.Rows[0][2].ToString();
                    txtempaddress.Text = dt.Rows[0][3].ToString();
                    txtemppswrd.Text = dt.Rows[0][4].ToString();

                }
                Con.Close();
            }
            catch(Exception ex)
            {

            }
}
        //Delete Employee Details
        private void btndelete_Click(object sender, EventArgs e)
        {
            
            Con.Open();
            SqlCommand cmd = new SqlCommand("Delete from EmployeeDetails where Emp_ID='" + empdetailsgrid1.Rows[empdetailsgrid1.SelectedCells[0].RowIndex].Cells[0].Value + "'");
            cmd.Connection = Con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted Successfully");
            Con.Close();


            Con.Open();
            SqlCommand cmd1 = new SqlCommand("Delete from login where User_ID='" + empdetailsgrid1.Rows[empdetailsgrid1.SelectedCells[0].RowIndex].Cells[0].Value + "'");
            cmd1.Connection = Con;
            cmd1.ExecuteNonQuery();
            Con.Close();

            SqlDataAdapter da = new SqlDataAdapter("Select * from EmployeeDetails", Con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            empdetailsgrid1.DataSource = dt;

           

        }

        private void btneditemp_Click(object sender, EventArgs e)
        {
           
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
           

        }

        //Update Employee Details
        private void btneditemp_Click_1(object sender, EventArgs e)
        {
            try
                {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Update EmployeeDetails set Employee_Name='" + txtempname.Text + "', Phone_Number= '" + txtempphnno.Text + "',Address='" + txtempaddress.Text + "', Password= '" + txtemppswrd.Text + "' where Emp_ID='" + empdetailsgrid1.Rows[empdetailsgrid1.SelectedCells[0].RowIndex].Cells[0].Value + "' ");
                cmd.Connection = Con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                Con.Close();

                Con.Open();
                SqlCommand cmd1 = new SqlCommand("Update login set Username='" + txtempname.Text + "', Password= '" + txtemppswrd.Text + "' where User_ID='" + empdetailsgrid1.Rows[empdetailsgrid1.SelectedCells[0].RowIndex].Cells[0].Value + "' ");
                cmd1.Connection = Con;
                cmd1.ExecuteNonQuery();
               
                Con.Close();

                SqlDataAdapter da = new SqlDataAdapter("Select * from EmployeeDetails", Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                empdetailsgrid1.DataSource = dt;    
            }
             catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        //Refresh The Form
        private void btnclear_Click_1(object sender, EventArgs e)
        {
            txtempname.Clear();
            txtempphnno.Clear();
            txtempaddress.Clear();
            txtemppswrd.Clear();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Login_Form_2 lgnobj = new Login_Form_2();
            lgnobj.Show();
        }
    }
}
