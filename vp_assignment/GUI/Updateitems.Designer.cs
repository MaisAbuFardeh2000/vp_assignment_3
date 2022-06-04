namespace vp_assignment
{
    partial class frmupdateitems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmupdateitems));
            this.lblupdateitems = new System.Windows.Forms.Label();
            this.lblitem = new System.Windows.Forms.Label();
            this.txtsearchitem = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblp = new System.Windows.Forms.Label();
            this.txtcategory = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.lblcategory = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnhadditem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblupdateitems
            // 
            this.lblupdateitems.AutoSize = true;
            this.lblupdateitems.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblupdateitems.Location = new System.Drawing.Point(38, 46);
            this.lblupdateitems.Name = "lblupdateitems";
            this.lblupdateitems.Size = new System.Drawing.Size(175, 35);
            this.lblupdateitems.TabIndex = 0;
            this.lblupdateitems.Text = "Update Items";
            // 
            // lblitem
            // 
            this.lblitem.AutoSize = true;
            this.lblitem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitem.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblitem.Location = new System.Drawing.Point(182, 455);
            this.lblitem.Name = "lblitem";
            this.lblitem.Size = new System.Drawing.Size(113, 23);
            this.lblitem.TabIndex = 1;
            this.lblitem.Text = " Items Name";
            // 
            // txtsearchitem
            // 
            this.txtsearchitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearchitem.ForeColor = System.Drawing.Color.Black;
            this.txtsearchitem.Location = new System.Drawing.Point(210, 482);
            this.txtsearchitem.Multiline = true;
            this.txtsearchitem.Name = "txtsearchitem";
            this.txtsearchitem.Size = new System.Drawing.Size(164, 30);
            this.txtsearchitem.TabIndex = 2;
            this.txtsearchitem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(682, 203);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblp
            // 
            this.lblp.AutoSize = true;
            this.lblp.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblp.Location = new System.Drawing.Point(407, 375);
            this.lblp.Name = "lblp";
            this.lblp.Size = new System.Drawing.Size(48, 23);
            this.lblp.TabIndex = 4;
            this.lblp.Text = "Price";
            // 
            // txtcategory
            // 
            this.txtcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcategory.ForeColor = System.Drawing.Color.Black;
            this.txtcategory.Location = new System.Drawing.Point(210, 401);
            this.txtcategory.Multiline = true;
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.Size = new System.Drawing.Size(164, 30);
            this.txtcategory.TabIndex = 7;
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.ForeColor = System.Drawing.Color.Black;
            this.txtprice.Location = new System.Drawing.Point(433, 401);
            this.txtprice.Multiline = true;
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(164, 30);
            this.txtprice.TabIndex = 9;
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategory.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblcategory.Location = new System.Drawing.Point(182, 375);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Size = new System.Drawing.Size(80, 23);
            this.lblcategory.TabIndex = 8;
            this.lblcategory.Text = "Category";
            // 
            // btnupdate
            // 
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnupdate.Image = ((System.Drawing.Image)(resources.GetObject("btnupdate.Image")));
            this.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdate.Location = new System.Drawing.Point(452, 455);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(145, 39);
            this.btnupdate.TabIndex = 14;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnhadditem
            // 
            this.btnhadditem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhadditem.BackgroundImage")));
            this.btnhadditem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnhadditem.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhadditem.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnhadditem.Image = ((System.Drawing.Image)(resources.GetObject("btnhadditem.Image")));
            this.btnhadditem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhadditem.Location = new System.Drawing.Point(653, 496);
            this.btnhadditem.Name = "btnhadditem";
            this.btnhadditem.Size = new System.Drawing.Size(88, 33);
            this.btnhadditem.TabIndex = 25;
            this.btnhadditem.Text = "Home";
            this.btnhadditem.UseVisualStyleBackColor = true;
            this.btnhadditem.Click += new System.EventHandler(this.btnhadditem_Click);
            // 
            // frmupdateitems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(770, 553);
            this.Controls.Add(this.btnhadditem);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.lblcategory);
            this.Controls.Add(this.txtcategory);
            this.Controls.Add(this.lblp);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtsearchitem);
            this.Controls.Add(this.lblitem);
            this.Controls.Add(this.lblupdateitems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmupdateitems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "updateitems";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblupdateitems;
        private System.Windows.Forms.Label lblitem;
        private System.Windows.Forms.TextBox txtsearchitem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblp;
        private System.Windows.Forms.TextBox txtcategory;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label lblcategory;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnhadditem;
    }
}