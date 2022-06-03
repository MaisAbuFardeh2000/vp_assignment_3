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
    public partial class AddItems : Form
    {
        

        public AddItems()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            btnAddItem.Visible = true;
            btnAddItem.BringToFront();
        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashbord frm = new Dashbord();
            this.Hide();
            frm.ShowDialog();
        }

        private void AddItems_Load(object sender, EventArgs e)
        {
            
        }
    }
}
