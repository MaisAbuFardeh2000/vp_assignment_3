namespace vp_assignment
{
    partial class FrmPlaceOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlaceOrder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblplace = new System.Windows.Forms.Label();
            this.lblcategory = new System.Windows.Forms.Label();
            this.cbcategory = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnaddtocart = new System.Windows.Forms.Button();
            this.numquantityupdown = new System.Windows.Forms.NumericUpDown();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtitemname = new System.Windows.Forms.TextBox();
            this.lblitem = new System.Windows.Forms.Label();
            this.lblquantity = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnhadditem = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.lblgrandtotal = new System.Windows.Forms.Label();
            this.lbltotalamount = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numquantityupdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblplace
            // 
            this.lblplace.AutoSize = true;
            this.lblplace.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplace.Location = new System.Drawing.Point(37, 29);
            this.lblplace.Name = "lblplace";
            this.lblplace.Size = new System.Drawing.Size(153, 35);
            this.lblplace.TabIndex = 0;
            this.lblplace.Text = "Place Order";
            this.lblplace.Click += new System.EventHandler(this.lblplace_Click);
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategory.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblcategory.Location = new System.Drawing.Point(22, 79);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Size = new System.Drawing.Size(78, 23);
            this.lblcategory.TabIndex = 2;
            this.lblcategory.Text = "Category";
            // 
            // cbcategory
            // 
            this.cbcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcategory.ForeColor = System.Drawing.Color.Black;
            this.cbcategory.FormattingEnabled = true;
            this.cbcategory.Location = new System.Drawing.Point(26, 117);
            this.cbcategory.Name = "cbcategory";
            this.cbcategory.Size = new System.Drawing.Size(142, 26);
            this.cbcategory.TabIndex = 3;
            this.cbcategory.SelectedIndexChanged += new System.EventHandler(this.cbcategory_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnaddtocart);
            this.panel1.Controls.Add(this.numquantityupdown);
            this.panel1.Controls.Add(this.txttotal);
            this.panel1.Controls.Add(this.txtprice);
            this.panel1.Controls.Add(this.txtitemname);
            this.panel1.Controls.Add(this.lblitem);
            this.panel1.Controls.Add(this.lblquantity);
            this.panel1.Controls.Add(this.lblprice);
            this.panel1.Controls.Add(this.lbltotal);
            this.panel1.Location = new System.Drawing.Point(241, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 218);
            this.panel1.TabIndex = 6;
            // 
            // btnaddtocart
            // 
            this.btnaddtocart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaddtocart.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddtocart.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnaddtocart.Image = ((System.Drawing.Image)(resources.GetObject("btnaddtocart.Image")));
            this.btnaddtocart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddtocart.Location = new System.Drawing.Point(351, 163);
            this.btnaddtocart.Name = "btnaddtocart";
            this.btnaddtocart.Size = new System.Drawing.Size(145, 39);
            this.btnaddtocart.TabIndex = 11;
            this.btnaddtocart.Text = "Add to Cart";
            this.btnaddtocart.UseVisualStyleBackColor = true;
            this.btnaddtocart.Click += new System.EventHandler(this.btnaddtocart_Click);
            // 
            // numquantityupdown
            // 
            this.numquantityupdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numquantityupdown.Location = new System.Drawing.Point(33, 114);
            this.numquantityupdown.Name = "numquantityupdown";
            this.numquantityupdown.Size = new System.Drawing.Size(169, 29);
            this.numquantityupdown.TabIndex = 10;
            this.numquantityupdown.ValueChanged += new System.EventHandler(this.numquantityupdown_ValueChanged);
            // 
            // txttotal
            // 
            this.txttotal.ForeColor = System.Drawing.Color.Black;
            this.txttotal.Location = new System.Drawing.Point(295, 113);
            this.txttotal.Multiline = true;
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(164, 30);
            this.txttotal.TabIndex = 9;
            this.txttotal.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtprice
            // 
            this.txtprice.ForeColor = System.Drawing.Color.Black;
            this.txtprice.Location = new System.Drawing.Point(295, 43);
            this.txtprice.Multiline = true;
            this.txtprice.Name = "txtprice";
            this.txtprice.ReadOnly = true;
            this.txtprice.Size = new System.Drawing.Size(164, 30);
            this.txtprice.TabIndex = 8;
            // 
            // txtitemname
            // 
            this.txtitemname.ForeColor = System.Drawing.Color.Black;
            this.txtitemname.Location = new System.Drawing.Point(33, 43);
            this.txtitemname.Multiline = true;
            this.txtitemname.Name = "txtitemname";
            this.txtitemname.ReadOnly = true;
            this.txtitemname.Size = new System.Drawing.Size(158, 30);
            this.txtitemname.TabIndex = 7;
            this.txtitemname.TextChanged += new System.EventHandler(this.txtitemname_TextChanged);
            // 
            // lblitem
            // 
            this.lblitem.AutoSize = true;
            this.lblitem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitem.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblitem.Location = new System.Drawing.Point(15, 9);
            this.lblitem.Name = "lblitem";
            this.lblitem.Size = new System.Drawing.Size(95, 23);
            this.lblitem.TabIndex = 6;
            this.lblitem.Text = "Item Name";
            // 
            // lblquantity
            // 
            this.lblquantity.AutoSize = true;
            this.lblquantity.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquantity.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblquantity.Location = new System.Drawing.Point(15, 82);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.Size = new System.Drawing.Size(76, 23);
            this.lblquantity.TabIndex = 5;
            this.lblquantity.Text = "Quantity";
            this.lblquantity.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblprice.Location = new System.Drawing.Point(252, 9);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(47, 23);
            this.lblprice.TabIndex = 4;
            this.lblprice.Text = "Price";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbltotal.Location = new System.Drawing.Point(251, 82);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(49, 23);
            this.lbltotal.TabIndex = 3;
            this.lbltotal.Text = "Total";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(262, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 201);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Moccasin;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle13;
            this.Column1.HeaderText = "Item Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Moccasin;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle14;
            this.Column2.HeaderText = "Unit price";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Moccasin;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle15;
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Moccasin;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle16;
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            // 
            // btnhadditem
            // 
            this.btnhadditem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhadditem.BackgroundImage")));
            this.btnhadditem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnhadditem.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhadditem.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnhadditem.Image = ((System.Drawing.Image)(resources.GetObject("btnhadditem.Image")));
            this.btnhadditem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhadditem.Location = new System.Drawing.Point(686, 547);
            this.btnhadditem.Name = "btnhadditem";
            this.btnhadditem.Size = new System.Drawing.Size(88, 33);
            this.btnhadditem.TabIndex = 24;
            this.btnhadditem.Text = "Home";
            this.btnhadditem.UseVisualStyleBackColor = true;
            this.btnhadditem.Click += new System.EventHandler(this.btnhadditem_Click);
            // 
            // btnremove
            // 
            this.btnremove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnremove.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnremove.Image = ((System.Drawing.Image)(resources.GetObject("btnremove.Image")));
            this.btnremove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnremove.Location = new System.Drawing.Point(262, 496);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(110, 39);
            this.btnremove.TabIndex = 25;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnprint
            // 
            this.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnprint.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnprint.Image = ((System.Drawing.Image)(resources.GetObject("btnprint.Image")));
            this.btnprint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprint.Location = new System.Drawing.Point(596, 496);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(110, 39);
            this.btnprint.TabIndex = 26;
            this.btnprint.Text = "print";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblgrandtotal
            // 
            this.lblgrandtotal.AutoSize = true;
            this.lblgrandtotal.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrandtotal.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblgrandtotal.Location = new System.Drawing.Point(446, 455);
            this.lblgrandtotal.Name = "lblgrandtotal";
            this.lblgrandtotal.Size = new System.Drawing.Size(98, 23);
            this.lblgrandtotal.TabIndex = 27;
            this.lblgrandtotal.Text = "Grand Total";
            // 
            // lbltotalamount
            // 
            this.lbltotalamount.BackColor = System.Drawing.Color.SeaShell;
            this.lbltotalamount.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalamount.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbltotalamount.Location = new System.Drawing.Point(430, 496);
            this.lbltotalamount.Name = "lbltotalamount";
            this.lbltotalamount.Size = new System.Drawing.Size(123, 39);
            this.lbltotalamount.TabIndex = 28;
            this.lbltotalamount.Text = "JD.00";
            this.lbltotalamount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnsearch
            // 
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsearch.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnsearch.Image = ((System.Drawing.Image)(resources.GetObject("btnsearch.Image")));
            this.btnsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsearch.Location = new System.Drawing.Point(26, 163);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(93, 33);
            this.btnsearch.TabIndex = 29;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 232);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(212, 303);
            this.dataGridView2.TabIndex = 30;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // FrmPlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(786, 592);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.lbltotalamount);
            this.Controls.Add(this.lblgrandtotal);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnhadditem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbcategory);
            this.Controls.Add(this.lblcategory);
            this.Controls.Add(this.lblplace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPlaceOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Place Order";
            this.Load += new System.EventHandler(this.FrmPlaceOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numquantityupdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblplace;
        private System.Windows.Forms.Label lblcategory;
        private System.Windows.Forms.ComboBox cbcategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblitem;
        private System.Windows.Forms.Label lblquantity;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.NumericUpDown numquantityupdown;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtitemname;
        private System.Windows.Forms.Button btnaddtocart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnhadditem;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Label lblgrandtotal;
        private System.Windows.Forms.Label lbltotalamount;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}