namespace SnapFood.WinApp
{
    partial class UserPanelForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateRestList = new System.Windows.Forms.Button();
            this.dgvRestauranList = new System.Windows.Forms.DataGridView();
            this.RestaurantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RestaurantOwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SumCartLable = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFinalOrder = new System.Windows.Forms.Button();
            this.btnFoodDelete = new System.Windows.Forms.Button();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.ClmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFoodSelect = new System.Windows.Forms.Button();
            this.dgvRestaurantMenu = new System.Windows.Forms.DataGridView();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnIdFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestauranList)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestaurantMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";

            this.panel1.Size = new System.Drawing.Size(884, 858);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateRestList);
            this.groupBox1.Controls.Add(this.dgvRestauranList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(884, 858);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لیست رستوران ها";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnUpdateRestList
            // 
            this.btnUpdateRestList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateRestList.BackColor = System.Drawing.Color.White;
            this.btnUpdateRestList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateRestList.Image = global::SnapFood.WinApp.Properties.Resources.ref_16;
            this.btnUpdateRestList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateRestList.Location = new System.Drawing.Point(394, 521);
            this.btnUpdateRestList.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdateRestList.Name = "btnUpdateRestList";

            this.btnUpdateRestList.Size = new System.Drawing.Size(258, 46);
            this.btnUpdateRestList.TabIndex = 0;
            this.btnUpdateRestList.Text = "بروز رسانی لیست رستوران ها";
            this.btnUpdateRestList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateRestList.UseVisualStyleBackColor = false;
            // 
            // dgvRestauranList
            // 
            this.dgvRestauranList.AllowUserToAddRows = false;
            this.dgvRestauranList.AllowUserToDeleteRows = false;
            this.dgvRestauranList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvRestauranList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRestauranList.BackgroundColor = System.Drawing.Color.Pink;
            this.dgvRestauranList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRestauranList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RestaurantName,
            this.RestaurantOwner,
            this.Address,
            this.clmnId});
            this.dgvRestauranList.GridColor = System.Drawing.Color.Silver;

            this.dgvRestauranList.Location = new System.Drawing.Point(4, 25);
            this.dgvRestauranList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvRestauranList.Name = "dgvRestauranList";
            this.dgvRestauranList.RowHeadersWidth = 62;
            this.dgvRestauranList.Size = new System.Drawing.Size(874, 758);
            this.dgvRestauranList.TabIndex = 0;
           this.dgvRestauranList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRestauranList_RowHeaderMouseClick);
            // 
            // RestaurantName
            // 
            this.RestaurantName.HeaderText = "نام رستوران";
            this.RestaurantName.MinimumWidth = 8;
            this.RestaurantName.Name = "RestaurantName";
            // 
            // RestaurantOwner
            // 
            this.RestaurantOwner.HeaderText = "صاحب رستوران";
            this.RestaurantOwner.MinimumWidth = 8;
            this.RestaurantOwner.Name = "RestaurantOwner";
            // 
            // Address
            // 
            this.Address.HeaderText = "آدرس";
            this.Address.MinimumWidth = 8;
            this.Address.Name = "Address";
            // 
            // clmnId
            // 
            this.clmnId.DataPropertyName = "clmnId";
            this.clmnId.HeaderText = "Column1";
            this.clmnId.MinimumWidth = 8;
            this.clmnId.Name = "clmnId";
            this.clmnId.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;

            this.panel2.Location = new System.Drawing.Point(884, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 858);
            this.panel2.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SumCartLable);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnFinalOrder);
            this.groupBox3.Controls.Add(this.btnFoodDelete);
            this.groupBox3.Controls.Add(this.dgvCart);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 471);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(38, 15, 38, 38);
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(730, 387);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "سبد خرید";
            // 
            // SumCartLable
            // 

            this.SumCartLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SumCartLable.AutoSize = true;
            this.SumCartLable.Location = new System.Drawing.Point(554, 332);
            this.SumCartLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SumCartLable.Name = "SumCartLable";
            this.SumCartLable.Size = new System.Drawing.Size(37, 20);
            this.SumCartLable.TabIndex = 5;
            this.SumCartLable.Text = ".......";
            // 
            // label6
            // 

            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(604, 332);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "جمع خرید :";
            // 
            // btnFinalOrder
            // 
            this.btnFinalOrder.BackColor = System.Drawing.Color.White;
            this.btnFinalOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalOrder.Image = global::SnapFood.WinApp.Properties.Resources.opts_16;
            this.btnFinalOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.btnFinalOrder.Location = new System.Drawing.Point(130, 332);
            this.btnFinalOrder.Margin = new System.Windows.Forms.Padding(0);
            this.btnFinalOrder.Name = "btnFinalOrder";
            this.btnFinalOrder.Size = new System.Drawing.Size(165, 46);
            this.btnFinalOrder.TabIndex = 3;
            this.btnFinalOrder.Text = "ثبت نهایی سفارش";
            this.btnFinalOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinalOrder.UseVisualStyleBackColor = false;
            this.btnFinalOrder.Click += new System.EventHandler(this.btnFinalOrder_Click);
            // 
            // btnFoodDelete
            // 
            this.btnFoodDelete.BackColor = System.Drawing.Color.White;
            this.btnFoodDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFoodDelete.Image = global::SnapFood.WinApp.Properties.Resources.del_16;
            this.btnFoodDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.btnFoodDelete.Location = new System.Drawing.Point(38, 332);
            this.btnFoodDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnFoodDelete.Name = "btnFoodDelete";
            this.btnFoodDelete.Size = new System.Drawing.Size(80, 46);
            this.btnFoodDelete.TabIndex = 2;
            this.btnFoodDelete.Text = "حذف";
            this.btnFoodDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFoodDelete.UseVisualStyleBackColor = false;
            this.btnFoodDelete.Click += new System.EventHandler(this.btnFoodDelete_Click);
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.BackgroundColor = System.Drawing.Color.Pink;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmName,
            this.FoodId,
            this.Count,
            this.ClmPrice});
            this.dgvCart.GridColor = System.Drawing.Color.Silver;
            this.dgvCart.Location = new System.Drawing.Point(38, 35);
            this.dgvCart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 62;
            this.dgvCart.Size = new System.Drawing.Size(656, 277);
            this.dgvCart.TabIndex = 1;
            this.dgvCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellContentClick);
            // 
            // ClmName
            // 
            this.ClmName.DataPropertyName = "Name";
            this.ClmName.HeaderText = "نام غذا";
            this.ClmName.MinimumWidth = 8;
            this.ClmName.Name = "ClmName";
            // 
            // FoodId
            // 
            this.FoodId.DataPropertyName = "FoodId";
            this.FoodId.HeaderText = "FoodId";
            this.FoodId.MinimumWidth = 8;
            this.FoodId.Name = "FoodId";
            this.FoodId.Visible = false;
            // 
            // Count
            // 
            this.Count.DataPropertyName = "Count";
            this.Count.HeaderText = "تعداد";
            this.Count.MinimumWidth = 8;
            this.Count.Name = "Count";
            // 
            // ClmPrice
            // 
            this.ClmPrice.DataPropertyName = "Price";
            this.ClmPrice.HeaderText = "قیمت";
            this.ClmPrice.MinimumWidth = 8;
            this.ClmPrice.Name = "ClmPrice";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFoodSelect);
            this.groupBox2.Controls.Add(this.dgvRestaurantMenu);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(38, 15, 38, 38);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(730, 471);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "منوی رستوران";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnFoodSelect
            // 
            this.btnFoodSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFoodSelect.BackColor = System.Drawing.Color.White;
            this.btnFoodSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFoodSelect.Image = global::SnapFood.WinApp.Properties.Resources.add_16;
            this.btnFoodSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFoodSelect.Location = new System.Drawing.Point(38, 420);
            this.btnFoodSelect.Margin = new System.Windows.Forms.Padding(0);
            this.btnFoodSelect.Name = "btnFoodSelect";
            this.btnFoodSelect.Size = new System.Drawing.Size(120, 46);
            this.btnFoodSelect.TabIndex = 2;
            this.btnFoodSelect.Text = "انتخاب غذا";
            this.btnFoodSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFoodSelect.UseVisualStyleBackColor = false;
            this.btnFoodSelect.Click += new System.EventHandler(this.btnFoodSelect_Click);
            // 
            // dgvRestaurantMenu
            // 
            this.dgvRestaurantMenu.AllowUserToAddRows = false;
            this.dgvRestaurantMenu.AllowUserToDeleteRows = false;
            this.dgvRestaurantMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRestaurantMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRestaurantMenu.BackgroundColor = System.Drawing.Color.Pink;
            this.dgvRestaurantMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRestaurantMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodName,
            this.Price,
            this.clmnIdFood});

            this.dgvRestaurantMenu.GridColor = System.Drawing.Color.Silver;
            this.dgvRestaurantMenu.Location = new System.Drawing.Point(38, 35);
            this.dgvRestaurantMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvRestaurantMenu.Name = "dgvRestaurantMenu";
            this.dgvRestaurantMenu.RowHeadersWidth = 62;
            this.dgvRestaurantMenu.Size = new System.Drawing.Size(656, 369);
            this.dgvRestaurantMenu.TabIndex = 0;
            // 
            // FoodName
            // 
            this.FoodName.HeaderText = "نام غذا";
            this.FoodName.MinimumWidth = 8;
            this.FoodName.Name = "FoodName";
            // 
            // Price
            // 
            this.Price.HeaderText = "قیمت";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            // 
            // clmnIdFood
            // 
            this.clmnIdFood.DataPropertyName = "FoodId";
            this.clmnIdFood.HeaderText = "Column1";
            this.clmnIdFood.MinimumWidth = 8;
            this.clmnIdFood.Name = "clmnIdFood";
            this.clmnIdFood.Visible = false;
            // 
            // UserPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(1614, 858);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1627, 888);
            this.Name = "UserPanelForm";
            this.Text = "UserPanelForm";
            this.Load += new System.EventHandler(this.UserPanelForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestauranList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestaurantMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdateRestList;
        private System.Windows.Forms.DataGridView dgvRestauranList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvRestaurantMenu;
        private System.Windows.Forms.Button btnFinalOrder;
        private System.Windows.Forms.Button btnFoodDelete;
        private System.Windows.Forms.Button btnFoodSelect;
        private System.Windows.Forms.Label SumCartLable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnIdFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn RestaurantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RestaurantOwner;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmPrice;
    }
}