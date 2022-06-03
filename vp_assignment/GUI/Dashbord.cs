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
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
        }
        public Dashbord(String user)
        {
            InitializeComponent();
            if (user == "btnGuest")
            {
                btnAddItems.Hide();
                btnUpdate.Hide();
                btnRemoveItems.Hide();

            }
            else if (user == "admin")
            {
                btnAddItems.Show();
                btnUpdate.Show();
                btnRemoveItems.Show();

            }
        }

        private void btnlLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login fm = new Login();
            this.Hide();
            fm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            AddItems add = new AddItems();
            this.Hide();
            add.ShowDialog();
                
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            FrmPlaceOrder frm = new FrmPlaceOrder();
            this.Hide();
            frm.ShowDialog();
            

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashbord_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmupdateitems frm = new frmupdateitems();
            this.Hide();
            frm.ShowDialog();

        }

        private void btnRemoveItems_Click(object sender, EventArgs e)
        {
            frmdeleteitems frm = new frmdeleteitems();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
