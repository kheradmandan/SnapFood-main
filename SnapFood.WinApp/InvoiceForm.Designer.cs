namespace SnapFood.WinApp
{
    partial class InvoiceForm
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
            this.txtBoxAddressUser = new System.Windows.Forms.TextBox();
            this.txtBoxFamilyUser = new System.Windows.Forms.TextBox();
            this.txtBoxPhoneUser = new System.Windows.Forms.TextBox();
            this.txtBoxNameUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SumInvoiceLable = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OkBtnInvoice = new System.Windows.Forms.Button();
            this.dvgInvoicedetails = new System.Windows.Forms.DataGridView();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBoxAddressRestaurant = new System.Windows.Forms.TextBox();
            this.txtBoxNameRestaurant = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgInvoicedetails)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 160);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxAddressUser);
            this.groupBox1.Controls.Add(this.txtBoxFamilyUser);
            this.groupBox1.Controls.Add(this.txtBoxPhoneUser);
            this.groupBox1.Controls.Add(this.txtBoxNameUser);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1126, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات مشتری";
            // 
            // txtBoxAddressUser
            // 
            this.txtBoxAddressUser.Location = new System.Drawing.Point(54, 112);
            this.txtBoxAddressUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxAddressUser.Name = "txtBoxAddressUser";
            this.txtBoxAddressUser.Size = new System.Drawing.Size(556, 26);
            this.txtBoxAddressUser.TabIndex = 7;
            // 
            // txtBoxFamilyUser
            // 
            this.txtBoxFamilyUser.Location = new System.Drawing.Point(411, 58);
            this.txtBoxFamilyUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxFamilyUser.Name = "txtBoxFamilyUser";
            this.txtBoxFamilyUser.Size = new System.Drawing.Size(199, 26);
            this.txtBoxFamilyUser.TabIndex = 6;
            // 
            // txtBoxPhoneUser
            // 
            this.txtBoxPhoneUser.Location = new System.Drawing.Point(766, 112);
            this.txtBoxPhoneUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxPhoneUser.Name = "txtBoxPhoneUser";
            this.txtBoxPhoneUser.Size = new System.Drawing.Size(199, 26);
            this.txtBoxPhoneUser.TabIndex = 5;
            // 
            // txtBoxNameUser
            // 
            this.txtBoxNameUser.Location = new System.Drawing.Point(766, 52);
            this.txtBoxNameUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxNameUser.Name = "txtBoxNameUser";
            this.txtBoxNameUser.Size = new System.Drawing.Size(199, 26);
            this.txtBoxNameUser.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(680, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "آدرس :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(621, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "نام خانوادگی :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1014, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "موبایل :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1040, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 298);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1126, 577);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SumInvoiceLable);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.OkBtnInvoice);
            this.groupBox2.Controls.Add(this.dvgInvoicedetails);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(225, 31, 225, 31);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(1126, 577);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جزییات خرید";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // SumInvoiceLable
            // 
            this.SumInvoiceLable.AutoSize = true;
            this.SumInvoiceLable.Location = new System.Drawing.Point(270, 514);
            this.SumInvoiceLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SumInvoiceLable.Name = "SumInvoiceLable";
            this.SumInvoiceLable.Size = new System.Drawing.Size(37, 20);
            this.SumInvoiceLable.TabIndex = 3;
            this.SumInvoiceLable.Text = ".......";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 514);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "جمع خرید :";
            // 
            // OkBtnInvoice
            // 
            this.OkBtnInvoice.Image = global::SnapFood.WinApp.Properties.Resources.opts_16;
            this.OkBtnInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OkBtnInvoice.Location = new System.Drawing.Point(54, 506);
            this.OkBtnInvoice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OkBtnInvoice.Name = "OkBtnInvoice";
            this.OkBtnInvoice.Size = new System.Drawing.Size(112, 35);
            this.OkBtnInvoice.TabIndex = 1;
            this.OkBtnInvoice.Text = "تایید";
            this.OkBtnInvoice.UseVisualStyleBackColor = true;
            this.OkBtnInvoice.Click += new System.EventHandler(this.OkBtnInvoice_Click);
            // 
            // dvgInvoicedetails
            // 
            this.dvgInvoicedetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgInvoicedetails.BackgroundColor = System.Drawing.Color.Pink;
            this.dvgInvoicedetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgInvoicedetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodName,
            this.Count,
            this.Price});
            this.dvgInvoicedetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.dvgInvoicedetails.Location = new System.Drawing.Point(225, 50);
            this.dvgInvoicedetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dvgInvoicedetails.Name = "dvgInvoicedetails";
            this.dvgInvoicedetails.RowHeadersWidth = 62;
            this.dvgInvoicedetails.Size = new System.Drawing.Size(676, 425);
            this.dvgInvoicedetails.TabIndex = 0;
            // 
            // FoodName
            // 
            this.FoodName.DataPropertyName = "Name";
            this.FoodName.HeaderText = "نام غذا";
            this.FoodName.MinimumWidth = 8;
            this.FoodName.Name = "FoodName";
            // 
            // Count
            // 
            this.Count.DataPropertyName = "Count";
            this.Count.HeaderText = "تعداد";
            this.Count.MinimumWidth = 8;
            this.Count.Name = "Count";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "قیمت";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 160);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1126, 137);
            this.panel3.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBoxAddressRestaurant);
            this.groupBox3.Controls.Add(this.txtBoxNameRestaurant);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(1126, 137);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "اطلاعات رستوران";
            // 
            // txtBoxAddressRestaurant
            // 
            this.txtBoxAddressRestaurant.Location = new System.Drawing.Point(410, 82);
            this.txtBoxAddressRestaurant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxAddressRestaurant.Name = "txtBoxAddressRestaurant";
            this.txtBoxAddressRestaurant.Size = new System.Drawing.Size(556, 26);
            this.txtBoxAddressRestaurant.TabIndex = 6;
            // 
            // txtBoxNameRestaurant
            // 
            this.txtBoxNameRestaurant.Location = new System.Drawing.Point(766, 38);
            this.txtBoxNameRestaurant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxNameRestaurant.Name = "txtBoxNameRestaurant";
            this.txtBoxNameRestaurant.Size = new System.Drawing.Size(199, 26);
            this.txtBoxNameRestaurant.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1024, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "آدرس :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(976, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "نام رستوران :";
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 875);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InvoiceForm";
            this.Text = "InvoiceForm";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgInvoicedetails)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBoxAddressUser;
        private System.Windows.Forms.TextBox txtBoxFamilyUser;
        private System.Windows.Forms.TextBox txtBoxPhoneUser;
        private System.Windows.Forms.TextBox txtBoxNameUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OkBtnInvoice;
        private System.Windows.Forms.DataGridView dvgInvoicedetails;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxAddressRestaurant;
        private System.Windows.Forms.TextBox txtBoxNameRestaurant;
        private System.Windows.Forms.Label SumInvoiceLable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}