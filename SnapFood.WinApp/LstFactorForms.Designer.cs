
namespace SnapFood.WinApp
{
    partial class LstFactorForms
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFoodSelect = new System.Windows.Forms.Button();
            this.dgvRestaurantFactor = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalFactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestaurantFactor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.btnFoodSelect);
            this.groupBox2.Controls.Add(this.dgvRestaurantFactor);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(38, 15, 38, 38);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(782, 736);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "لیست فاکتورهای رستوران";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnFoodSelect
            // 
            this.btnFoodSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFoodSelect.BackColor = System.Drawing.Color.White;
            this.btnFoodSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFoodSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFoodSelect.Location = new System.Drawing.Point(564, 628);
            this.btnFoodSelect.Margin = new System.Windows.Forms.Padding(0);
            this.btnFoodSelect.Name = "btnFoodSelect";
            this.btnFoodSelect.Size = new System.Drawing.Size(147, 51);
            this.btnFoodSelect.TabIndex = 2;
            this.btnFoodSelect.Text = "مشاهده فاکتور";
            this.btnFoodSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFoodSelect.UseVisualStyleBackColor = false;
            this.btnFoodSelect.Click += new System.EventHandler(this.btnFoodSelect_Click);
            // 
            // dgvRestaurantFactor
            // 
            this.dgvRestaurantFactor.AllowUserToAddRows = false;
            this.dgvRestaurantFactor.AllowUserToDeleteRows = false;
            this.dgvRestaurantFactor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRestaurantFactor.BackgroundColor = System.Drawing.Color.Pink;
            this.dgvRestaurantFactor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRestaurantFactor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.TotalFactor,
            this.OrderId});
            this.dgvRestaurantFactor.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvRestaurantFactor.GridColor = System.Drawing.Color.Silver;
            this.dgvRestaurantFactor.Location = new System.Drawing.Point(38, 34);
            this.dgvRestaurantFactor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvRestaurantFactor.Name = "dgvRestaurantFactor";
            this.dgvRestaurantFactor.RowHeadersWidth = 62;
            this.dgvRestaurantFactor.Size = new System.Drawing.Size(706, 566);
            this.dgvRestaurantFactor.TabIndex = 0;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "نام مشتری";
            this.UserName.MinimumWidth = 8;
            this.UserName.Name = "UserName";
            // 
            // TotalFactor
            // 
            this.TotalFactor.DataPropertyName = "TotalFactor";
            this.TotalFactor.HeaderText = "قیمت کل";
            this.TotalFactor.MinimumWidth = 8;
            this.TotalFactor.Name = "TotalFactor";
            // 
            // OrderId
            // 
            this.OrderId.DataPropertyName = "OrderId";
            this.OrderId.HeaderText = "Column1";
            this.OrderId.MinimumWidth = 8;
            this.OrderId.Name = "OrderId";
            this.OrderId.Visible = false;
            // 
            // LstFactorForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(782, 692);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LstFactorForms";
            this.Text = "LstFactorForms";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestaurantFactor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFoodSelect;
        private System.Windows.Forms.DataGridView dgvRestaurantFactor;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalFactor;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
    }
}