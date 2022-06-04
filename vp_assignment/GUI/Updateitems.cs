using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vp_assignment.DAL;
using vp_assignment.Entity;

namespace vp_assignment
{
    public partial class frmupdateitems : Form
    {
        public frmupdateitems()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshdataGridView();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnhadditem_Click(object sender, EventArgs e)
        {
            Dashbord frm = new Dashbord();
            this.Hide();
            frm.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentOrder = new Items();
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            currentOrder.ItemName = row.Cells[1].Value.ToString();
            currentOrder.price = double.Parse(row.Cells[3].Value.ToString());
            currentOrder.Category = (row.Cells[2].Value.ToString());


            txtcategory.Text = currentOrder.Category;
            txtprice.Text = currentOrder.price.ToString();
            txtsearchitem.Text = currentOrder.ItemName;
        }

        Items currentOrder;


        private void btnupdate_Click(object sender, EventArgs e)
        {

            currentOrder = new Items();
                currentOrder.ItemName = txtsearchitem.Text;
                currentOrder.Category = txtcategory.Text;
                currentOrder.price = double.Parse(txtprice.Text);
                
                ItemsDAL.InsertCommand(currentOrder);
                MessageBox.Show("Order seccessfully added");
            RefreshdataGridView();
            txtcategory.Text = "";
            txtprice.Text = "";
            txtsearchitem.Text = "";
        }
        private void RefreshdataGridView()
        {
            dataGridView1.DataSource = ItemsDAL.GetAllcommand();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
/*
 
 
         private static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ASUS\\Desktop\\Database21.accdb";

 */
