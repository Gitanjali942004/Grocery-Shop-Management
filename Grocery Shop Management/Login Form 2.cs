using MySqlConnector;
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
    public partial class Login_Form_2 : Form
    {
        public Login_Form_2()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
              SqlConnection con = new SqlConnection(@"Data Source=DESKTOP - BI8HG8Q\SQLEXPRESS;Initial Catalog=Grocery_Shop_Management;Integrated Security=True");
             SqlCommand cmd = new SqlCommand("select * from login1 where Username='" + textBox1.Text + "'  and  Password='" + textBox2.Text + "'", con);
             SqlDataAdapter sda = new SqlDataAdapter(cmd);
             DataTable dt = new DataTable();
             sda.Fill(dt);

             String cmbItemValue = comboBox_role.SelectedItem.ToString();
             if (dt.Rows.Count > 0)
             {
                 for (int i = 0; i < dt.Rows.Count; i++)
                 {
                     if (dt.Rows[i]["Usertype"].ToString() == cmbItemValue)
                     {

                         if(comboBox_role.SelectedIndex==0)
                         {
                             MessageBox.Show("You are login as a ADMIN");
                             this.Hide();
                             adminemployee fr2 = new adminemployee();
                             fr2.Show();
                         }
                         else
                         {
                             MessageBox.Show("You are login as a SELLER");
                             this.Hide();
                             Sellers_Form fr3 = new Sellers_Form();
                             fr3.Show();
                         }
                     }
                 }
             }
             else
             {
                 MessageBox.Show("Please Enter Correct Username And Password....!");
             } 
        }

        private void ComboBox_role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Login_Form_2_Load(object sender, EventArgs e)
        {

        }
    }
}
