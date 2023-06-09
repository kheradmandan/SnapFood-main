namespace SnapFood.WinApp
{
    partial class RestaurantPanelForm
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
            this.UpdateMenuButton = new System.Windows.Forms.Button();
            this.InsertMenuButton = new System.Windows.Forms.Button();
            this.OrdersButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DgvFood = new System.Windows.Forms.DataGridView();
            this.clmnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtFood = new System.Windows.Forms.TextBox();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFood)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateMenuButton
            // 
            this.UpdateMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateMenuButton.BackColor = System.Drawing.Color.DeepPink;
            this.UpdateMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.UpdateMenuButton.ForeColor = System.Drawing.Color.White;
            this.UpdateMenuButton.Location = new System.Drawing.Point(11, 45);
            this.UpdateMenuButton.Name = "UpdateMenuButton";
            this.UpdateMenuButton.Size = new System.Drawing.Size(138, 69);
            this.UpdateMenuButton.TabIndex = 0;
            this.UpdateMenuButton.Text = "ویرایش منو";
            this.UpdateMenuButton.UseVisualStyleBackColor = false;
            this.UpdateMenuButton.Click += new System.EventHandler(this.UpdateMenuButton_Click);
            // 
            // InsertMenuButton
            // 
            this.InsertMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InsertMenuButton.BackColor = System.Drawing.Color.DeepPink;
            this.InsertMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.InsertMenuButton.ForeColor = System.Drawing.Color.White;
            this.InsertMenuButton.Location = new System.Drawing.Point(11, 137);
            this.InsertMenuButton.Name = "InsertMenuButton";
            this.InsertMenuButton.Size = new System.Drawing.Size(138, 69);
            this.InsertMenuButton.TabIndex = 1;
            this.InsertMenuButton.Text = "وارد کردن منوی جدید";
            this.InsertMenuButton.UseVisualStyleBackColor = false;
            // 
            // OrdersButton
            // 
            this.OrdersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OrdersButton.BackColor = System.Drawing.Color.DeepPink;
            this.OrdersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.OrdersButton.ForeColor = System.Drawing.Color.White;
            this.OrdersButton.Location = new System.Drawing.Point(11, 229);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Size = new System.Drawing.Size(138, 69);
            this.OrdersButton.TabIndex = 2;
            this.OrdersButton.Text = "فاکتورها";
            this.OrdersButton.UseVisualStyleBackColor = false;
            this.OrdersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OrdersButton);
            this.groupBox1.Controls.Add(this.UpdateMenuButton);
            this.groupBox1.Controls.Add(this.InsertMenuButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(221, 333);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "پنل رستوران";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DgvFood
            // 
            this.DgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnId,
            this.clmnName,
            this.clmnPrice});
            this.DgvFood.Location = new System.Drawing.Point(269, 8);
            this.DgvFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgvFood.Name = "DgvFood";
            this.DgvFood.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DgvFood.RowHeadersWidth = 62;
            this.DgvFood.RowTemplate.Height = 28;
            this.DgvFood.Size = new System.Drawing.Size(439, 228);
            this.DgvFood.TabIndex = 7;
            // 
            // clmnId
            // 
            this.clmnId.HeaderText = "Id";
            this.clmnId.MinimumWidth = 8;
            this.clmnId.Name = "clmnId";
            this.clmnId.Width = 150;
            // 
            // clmnName
            // 
            this.clmnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnName.DataPropertyName = "Name";
            this.clmnName.HeaderText = "اسم غذا";
            this.clmnName.MinimumWidth = 8;
            this.clmnName.Name = "clmnName";
            // 
            // clmnPrice
            // 
            this.clmnPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnPrice.DataPropertyName = "Price";
            this.clmnPrice.HeaderText = "قیمت";
            this.clmnPrice.MinimumWidth = 8;
            this.clmnPrice.Name = "clmnPrice";
            // 
            // TxtFood
            // 
            this.TxtFood.Location = new System.Drawing.Point(509, 258);
            this.TxtFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtFood.Name = "TxtFood";
            this.TxtFood.Size = new System.Drawing.Size(107, 20);
            this.TxtFood.TabIndex = 8;
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(509, 298);
            this.TxtPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(107, 20);
            this.TxtPrice.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(668, 258);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "نام غذا";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(668, 302);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "قیمت ";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(509, 345);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(50, 21);
            this.BtnSave.TabIndex = 12;
            this.BtnSave.Text = "ذخیره";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(652, 345);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(50, 21);
            this.BtnEdit.TabIndex = 13;
            this.BtnEdit.Text = "ویرایش";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // RestaurantPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 447);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.TxtFood);
            this.Controls.Add(this.DgvFood);
            this.Controls.Add(this.groupBox1);
            this.Name = "RestaurantPanelForm";
            this.Text = "RestaurantPanel";
            this.Load += new System.EventHandler(this.RestaurantPanelForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateMenuButton;
        private System.Windows.Forms.Button InsertMenuButton;
        private System.Windows.Forms.Button OrdersButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgvFood;
        private System.Windows.Forms.TextBox TxtFood;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPrice;
    }
}