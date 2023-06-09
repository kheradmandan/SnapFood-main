namespace SnapFood.WinApp
{
    partial class RstFoodsForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.DgvFoods = new System.Windows.Forms.DataGridView();
            this.ClmnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.TxtNam = new System.Windows.Forms.TextBox();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFoods)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(623, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 705);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(623, 26);
            this.panel3.TabIndex = 5;
            // 
            // DgvFoods
            // 
            this.DgvFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmnId,
            this.ClmnName,
            this.ClmnPrice});
            this.DgvFoods.Location = new System.Drawing.Point(12, 200);
            this.DgvFoods.Name = "DgvFoods";
            this.DgvFoods.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DgvFoods.RowHeadersWidth = 62;
            this.DgvFoods.RowTemplate.Height = 28;
            this.DgvFoods.Size = new System.Drawing.Size(601, 432);
            this.DgvFoods.TabIndex = 6;
            this.DgvFoods.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvFoods_RowHeaderMouseClick);
            // 
            // ClmnId
            // 
            this.ClmnId.HeaderText = "Column1";
            this.ClmnId.MinimumWidth = 8;
            this.ClmnId.Name = "ClmnId";
            this.ClmnId.Visible = false;
            this.ClmnId.Width = 150;
            // 
            // ClmnName
            // 
            this.ClmnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmnName.HeaderText = "عنوان";
            this.ClmnName.MinimumWidth = 8;
            this.ClmnName.Name = "ClmnName";
            // 
            // ClmnPrice
            // 
            this.ClmnPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmnPrice.HeaderText = "قیمت";
            this.ClmnPrice.MinimumWidth = 8;
            this.ClmnPrice.Name = "ClmnPrice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(521, 138);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(60, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "قیمت :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(522, 87);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(67, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "عنوان :";
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.LightGray;
            this.BtnEdit.Location = new System.Drawing.Point(295, 649);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(122, 44);
            this.BtnEdit.TabIndex = 14;
            this.BtnEdit.Text = "ویرایش";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.LightGray;
            this.BtnSave.Location = new System.Drawing.Point(22, 649);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(122, 44);
            this.BtnSave.TabIndex = 15;
            this.BtnSave.Text = "ذخیره";
            this.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Location = new System.Drawing.Point(527, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(96, 46);
            this.panel5.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SnapFood.WinApp.Properties.Resources.pizza;
            this.pictureBox1.Location = new System.Drawing.Point(34, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitle.Location = new System.Drawing.Point(349, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(142, 32);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "snapFood";
            // 
            // TxtNam
            // 
            this.TxtNam.Location = new System.Drawing.Point(267, 100);
            this.TxtNam.Name = "TxtNam";
            this.TxtNam.Size = new System.Drawing.Size(188, 26);
            this.TxtNam.TabIndex = 5;
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(267, 140);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(188, 26);
            this.TxtPrice.TabIndex = 18;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.LightGray;
            this.BtnDelete.Location = new System.Drawing.Point(159, 649);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(122, 44);
            this.BtnDelete.TabIndex = 19;
            this.BtnDelete.Text = "حذف";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // RstFoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 705);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.TxtNam);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DgvFoods);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RstFoodsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateMenu";
            this.Load += new System.EventHandler(this.UpdateMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFoods)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView DgvFoods;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnPrice;
        private System.Windows.Forms.TextBox TxtNam;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Button BtnDelete;
    }
}