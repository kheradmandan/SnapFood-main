namespace SnapFood.WinApp
{
    partial class RstOrderForm
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DvgOrders = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtFamily = new System.Windows.Forms.TextBox();
            this.TxtAdress = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtMob = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BtnFactorDetail = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ClmnUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnOrderGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DvgOrders)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1149, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(28, 657);
            this.panel1.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(1067, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(82, 69);
            this.panel4.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SnapFood.WinApp.Properties.Resources.pizza;
            this.pictureBox1.Location = new System.Drawing.Point(20, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // DvgOrders
            // 
            this.DvgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvgOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmnUserId,
            this.clmnOrderGuid,
            this.ClmnUserName,
            this.ClmnDate,
            this.ClmnSum});
            this.DvgOrders.Location = new System.Drawing.Point(12, 283);
            this.DvgOrders.Name = "DvgOrders";
            this.DvgOrders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DvgOrders.RowHeadersWidth = 62;
            this.DvgOrders.RowTemplate.Height = 28;
            this.DvgOrders.Size = new System.Drawing.Size(1101, 299);
            this.DvgOrders.TabIndex = 11;
            this.DvgOrders.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DvgOrders_RowHeaderMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1027, 117);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو بر اساس";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "جستجو";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(892, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "نام مشتری :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(916, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "تاریخ :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(641, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 26);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(641, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 26);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtFamily);
            this.groupBox2.Controls.Add(this.TxtAdress);
            this.groupBox2.Controls.Add(this.TxtName);
            this.groupBox2.Controls.Add(this.TxtMob);
            this.groupBox2.Location = new System.Drawing.Point(12, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(1101, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اطلاعات مشتری";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1024, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "موبایل :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1043, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "نام :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(598, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "نام خانوادگی :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(632, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "آدرس :";
            // 
            // TxtFamily
            // 
            this.TxtFamily.Location = new System.Drawing.Point(387, 19);
            this.TxtFamily.Name = "TxtFamily";
            this.TxtFamily.Size = new System.Drawing.Size(151, 26);
            this.TxtFamily.TabIndex = 2;
            // 
            // TxtAdress
            // 
            this.TxtAdress.Location = new System.Drawing.Point(188, 60);
            this.TxtAdress.Name = "TxtAdress";
            this.TxtAdress.Size = new System.Drawing.Size(350, 26);
            this.TxtAdress.TabIndex = 3;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(782, 25);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(198, 26);
            this.TxtName.TabIndex = 4;
            // 
            // TxtMob
            // 
            this.TxtMob.Location = new System.Drawing.Point(782, 68);
            this.TxtMob.Name = "TxtMob";
            this.TxtMob.Size = new System.Drawing.Size(198, 26);
            this.TxtMob.TabIndex = 5;
            // 
            // BtnFactorDetail
            // 
            this.BtnFactorDetail.Location = new System.Drawing.Point(33, 599);
            this.BtnFactorDetail.Name = "BtnFactorDetail";
            this.BtnFactorDetail.Size = new System.Drawing.Size(146, 41);
            this.BtnFactorDetail.TabIndex = 13;
            this.BtnFactorDetail.Text = "مشاهده جزئیات فاکتور";
            this.BtnFactorDetail.UseVisualStyleBackColor = true;
            this.BtnFactorDetail.Click += new System.EventHandler(this.BtnFactorDetail_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1149, 42);
            this.panel2.TabIndex = 14;
            // 
            // ClmnUserId
            // 
            this.ClmnUserId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ClmnUserId.HeaderText = "Column1";
            this.ClmnUserId.MinimumWidth = 8;
            this.ClmnUserId.Name = "ClmnUserId";
            this.ClmnUserId.Visible = false;
            this.ClmnUserId.Width = 150;
            // 
            // clmnOrderGuid
            // 
            this.clmnOrderGuid.HeaderText = "orderGuid";
            this.clmnOrderGuid.MinimumWidth = 8;
            this.clmnOrderGuid.Name = "clmnOrderGuid";
            this.clmnOrderGuid.Visible = false;
            this.clmnOrderGuid.Width = 150;
            // 
            // ClmnUserName
            // 
            this.ClmnUserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ClmnUserName.HeaderText = "نام خریدار";
            this.ClmnUserName.MinimumWidth = 8;
            this.ClmnUserName.Name = "ClmnUserName";
            this.ClmnUserName.Width = 222;
            // 
            // ClmnDate
            // 
            this.ClmnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ClmnDate.HeaderText = "تاریخ";
            this.ClmnDate.MinimumWidth = 8;
            this.ClmnDate.Name = "ClmnDate";
            this.ClmnDate.Width = 222;
            // 
            // ClmnSum
            // 
            this.ClmnSum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ClmnSum.HeaderText = "مجموع فاکتور";
            this.ClmnSum.MinimumWidth = 8;
            this.ClmnSum.Name = "ClmnSum";
            this.ClmnSum.Width = 224;
            // 
            // RstOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 657);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnFactorDetail);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DvgOrders);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RstOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DvgOrders)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DvgOrders;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtFamily;
        private System.Windows.Forms.TextBox TxtAdress;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtMob;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnFactorDetail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnOrderGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnSum;
    }
}