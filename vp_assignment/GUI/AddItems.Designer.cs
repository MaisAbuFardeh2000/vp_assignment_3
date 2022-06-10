namespace vp_assignment
{
    partial class AddItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItems));
            this.lblprice = new System.Windows.Forms.Label();
            this.lblitemname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCtegory = new System.Windows.Forms.ComboBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnhadditem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblprice.Location = new System.Drawing.Point(118, 297);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(57, 27);
            this.lblprice.TabIndex = 15;
            this.lblprice.Text = "Price";
            // 
            // lblitemname
            // 
            this.lblitemname.AutoSize = true;
            this.lblitemname.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitemname.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblitemname.Location = new System.Drawing.Point(75, 204);
            this.lblitemname.Name = "lblitemname";
            this.lblitemname.Size = new System.Drawing.Size(117, 27);
            this.lblitemname.TabIndex = 14;
            this.lblitemname.Text = "Item Name";
            this.lblitemname.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(82, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "category";
            // 
            // btnAddItem
            // 
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddItem.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnAddItem.Image = ((System.Drawing.Image)(resources.GetObject("btnAddItem.Image")));
            this.btnAddItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddItem.Location = new System.Drawing.Point(554, 409);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(161, 55);
            this.btnAddItem.TabIndex = 12;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Add New  Item";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbCtegory
            // 
            this.cbCtegory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCtegory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCtegory.FormattingEnabled = true;
            this.cbCtegory.Location = new System.Drawing.Point(209, 148);
            this.cbCtegory.Name = "cbCtegory";
            this.cbCtegory.Size = new System.Drawing.Size(266, 28);
            this.cbCtegory.TabIndex = 16;
            this.cbCtegory.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(209, 240);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(266, 26);
            this.txtItemName.TabIndex = 19;
            this.txtItemName.TextChanged += new System.EventHandler(this.txtItemName_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(209, 331);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(266, 26);
            this.txtPrice.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Bisque;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(726, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 38);
            this.button1.TabIndex = 22;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnhadditem
            // 
            this.btnhadditem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhadditem.BackgroundImage")));
            this.btnhadditem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnhadditem.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhadditem.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnhadditem.Image = ((System.Drawing.Image)(resources.GetObject("btnhadditem.Image")));
            this.btnhadditem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhadditem.Location = new System.Drawing.Point(449, 486);
            this.btnhadditem.Name = "btnhadditem";
            this.btnhadditem.Size = new System.Drawing.Size(128, 42);
            this.btnhadditem.TabIndex = 23;
            this.btnhadditem.Text = "Home";
            this.btnhadditem.UseVisualStyleBackColor = true;
            this.btnhadditem.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(786, 592);
            this.Controls.Add(this.btnhadditem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.cbCtegory);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblitemname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItems";
            this.Load += new System.EventHandler(this.AddItems_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblitemname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCtegory;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnhadditem;
    }
}