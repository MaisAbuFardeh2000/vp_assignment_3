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
    public partial class frmdeleteitems : Form
    {
        public frmdeleteitems()
        {
            InitializeComponent();
        }
        Items currentOrder;


        private void btnhadditem_Click(object sender, EventArgs e)
        {
            Dashbord frm = new Dashbord();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ItemsDAL.DeleteCommand(currentOrder);
            RefreshdataGridView();
            MessageBox.Show("Item Successfully Deleted");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentOrder = new Items();
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            currentOrder.ItemName = row.Cells[1].Value.ToString();

            txtsearch.Text = currentOrder.ItemName;
        }
        private void RefreshdataGridView()
        {
            dataGridView1.DataSource = ItemsDAL.GetAllcommand();
        }

        private void frmdeleteitems_Load(object sender, EventArgs e)
        {
            RefreshdataGridView();
        }
    }
}
