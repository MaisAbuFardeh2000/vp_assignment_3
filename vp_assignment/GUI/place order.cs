using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vp_assignment
{
    public partial class FrmPlaceOrder : Form
    {
        

        public FrmPlaceOrder()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmPlaceOrder_Load(object sender, EventArgs e)
        {
            

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
    }
}
