using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vp_assignment.DAL;
using vp_assignment.Entity;

namespace vp_assignment
{
    public partial class FrmPlaceOrder : Form
    {
        private static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ASUS\\Desktop\\Database21.accdb";
        private static OleDbConnection conn = new OleDbConnection(connectionString);

        public FrmPlaceOrder()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmPlaceOrder_Load(object sender, EventArgs e)
        {
            ComboConnect();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnhadditem_Click(object sender, EventArgs e)
        {
            Dashbord frm = new Dashbord();
            this.Hide();
            frm.ShowDialog();
        }

        private void lblplace_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        
        private void cbcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void btnremove_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void ComboConnect()
        {

            string commandText = string.Format("Select Category from Items");

            OleDbCommand command = new OleDbCommand(commandText, conn);

            OleDbDataAdapter da = new OleDbDataAdapter(command);

            DataTable dt = new DataTable();

            OleDbDataReader dr;
            conn.Open();

            dr = command.ExecuteReader();
            while (dr.Read())
            {
                cbcategory.Items.Add(dr[0].ToString());
            }
            dr.Close();
            conn.Close();

        }
        Items currentOrder;

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            currentOrder = new Items();
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            currentOrder.ItemName = row.Cells[1].Value.ToString();
            currentOrder.price = double.Parse(row.Cells[3].Value.ToString());


            txtitemname.Text = currentOrder.ItemName;
            txtprice.Text = currentOrder.price.ToString();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            FilterSearch();
        }

        public void FilterSearch()
        {
            try
            {
                conn.Open();

                string commandText = "Select ItemName,price from Items where Category='" + cbcategory.SelectedItem.ToString() + "'";
                OleDbDataAdapter da = new OleDbDataAdapter(commandText, conn);
                OleDbCommandBuilder builder = new OleDbCommandBuilder(da);
                var dt = new DataSet();
                da.Fill(dt);
                dataGridView2.DataSource = dt.Tables[0];
                conn.Close();
            }
            catch
            {

            }

        }
    }
}
