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
    public partial class reportviewerform : Form
    {
        public reportviewerform()
        {
            InitializeComponent();
        }
        public void Billcr(String sql)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Grocery_Shop_Management;Integrated Security=True");
            Con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, Con);
            DataSet1 ds = new DataSet1();
            da.Fill(ds, "Tbl_bill");
        

            CrystalReport1 cr = new CrystalReport1();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
        }

        private void PrintBill_Cry_report1_InitReport(object sender, EventArgs e)
        {

        }
    }
}
