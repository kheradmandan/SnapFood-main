namespace SnapFood.WinApp
{
    partial class RestaurantRegisterForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtTimeTo = new System.Windows.Forms.TextBox();
            this.EndTimeLabel = new System.Windows.Forms.Label();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.TxtRestAddress = new System.Windows.Forms.TextBox();
            this.TxtTimeFrom = new System.Windows.Forms.TextBox();
            this.TxtOwner = new System.Windows.Forms.TextBox();
            this.TxtRestName = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.RestUserLabel = new System.Windows.Forms.Label();
            this.WorkTimeLabel = new System.Windows.Forms.Label();
            this.TxtAdminAddress = new System.Windows.Forms.TextBox();
            this.TxtAdminNationalCode = new System.Windows.Forms.TextBox();
            this.TxtAdminFamily = new System.Windows.Forms.TextBox();
            this.txtAdmin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FamilyLabel = new System.Windows.Forms.Label();
            this.NationalCodeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::SnapFood.WinApp.Properties.Resources.download;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.TxtAdminAddress);
            this.groupBox1.Controls.Add(this.TxtAdminNationalCode);
            this.groupBox1.Controls.Add(this.TxtAdminFamily);
            this.groupBox1.Controls.Add(this.txtAdmin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FamilyLabel);
            this.groupBox1.Controls.Add(this.NationalCodeLabel);
            this.groupBox1.Controls.Add(this.TxtTimeTo);
            this.groupBox1.Controls.Add(this.EndTimeLabel);
            this.groupBox1.Controls.Add(this.StartTimeLabel);
            this.groupBox1.Controls.Add(this.RegisterButton);
            this.groupBox1.Controls.Add(this.TxtRestAddress);
            this.groupBox1.Controls.Add(this.TxtTimeFrom);
            this.groupBox1.Controls.Add(this.TxtOwner);
            this.groupBox1.Controls.Add(this.TxtRestName);
            this.groupBox1.Controls.Add(this.NameLabel);
            this.groupBox1.Controls.Add(this.AddressLabel);
            this.groupBox1.Controls.Add(this.RestUserLabel);
            this.groupBox1.Controls.Add(this.WorkTimeLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(561, 508);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TxtTimeTo
            // 
            this.TxtTimeTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTimeTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtTimeTo.Location = new System.Drawing.Point(23, 231);
            this.TxtTimeTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTimeTo.Multiline = true;
            this.TxtTimeTo.Name = "TxtTimeTo";
            this.TxtTimeTo.Size = new System.Drawing.Size(72, 34);
            this.TxtTimeTo.TabIndex = 11;
            // 
            // EndTimeLabel
            // 
            this.EndTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EndTimeLabel.AutoSize = true;
            this.EndTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.EndTimeLabel.Location = new System.Drawing.Point(103, 234);
            this.EndTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.Size = new System.Drawing.Size(23, 16);
            this.EndTimeLabel.TabIndex = 10;
            this.EndTimeLabel.Text = "تا :";
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.StartTimeLabel.Location = new System.Drawing.Point(385, 234);
            this.StartTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(26, 16);
            this.StartTimeLabel.TabIndex = 9;
            this.StartTimeLabel.Text = "از : ";
            // 
            // RegisterButton
            // 
            this.RegisterButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegisterButton.BackColor = System.Drawing.Color.DeepPink;
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RegisterButton.ForeColor = System.Drawing.Color.White;
            this.RegisterButton.Location = new System.Drawing.Point(23, 461);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(227, 41);
            this.RegisterButton.TabIndex = 8;
            this.RegisterButton.Text = "ثبت رستوران";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // TxtRestAddress
            // 
            this.TxtRestAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtRestAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtRestAddress.Location = new System.Drawing.Point(23, 275);
            this.TxtRestAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtRestAddress.Multiline = true;
            this.TxtRestAddress.Name = "TxtRestAddress";
            this.TxtRestAddress.Size = new System.Drawing.Size(388, 83);
            this.TxtRestAddress.TabIndex = 7;
            // 
            // TxtTimeFrom
            // 
            this.TxtTimeFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTimeFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtTimeFrom.Location = new System.Drawing.Point(304, 231);
            this.TxtTimeFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTimeFrom.Multiline = true;
            this.TxtTimeFrom.Name = "TxtTimeFrom";
            this.TxtTimeFrom.Size = new System.Drawing.Size(72, 34);
            this.TxtTimeFrom.TabIndex = 6;
            // 
            // TxtOwner
            // 
            this.TxtOwner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtOwner.Location = new System.Drawing.Point(23, 49);
            this.TxtOwner.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtOwner.Multiline = true;
            this.TxtOwner.Name = "TxtOwner";
            this.TxtOwner.Size = new System.Drawing.Size(388, 34);
            this.TxtOwner.TabIndex = 5;
            // 
            // TxtRestName
            // 
            this.TxtRestName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtRestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtRestName.Location = new System.Drawing.Point(23, 5);
            this.TxtRestName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtRestName.Multiline = true;
            this.TxtRestName.Name = "TxtRestName";
            this.TxtRestName.Size = new System.Drawing.Size(388, 34);
            this.TxtRestName.TabIndex = 4;
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NameLabel.Location = new System.Drawing.Point(479, 14);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(69, 16);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "نام رستوران:";
            // 
            // AddressLabel
            // 
            this.AddressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AddressLabel.Location = new System.Drawing.Point(460, 278);
            this.AddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(88, 16);
            this.AddressLabel.TabIndex = 3;
            this.AddressLabel.Text = "آدرس رستوران :";
            // 
            // RestUserLabel
            // 
            this.RestUserLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RestUserLabel.AutoSize = true;
            this.RestUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RestUserLabel.Location = new System.Drawing.Point(461, 58);
            this.RestUserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RestUserLabel.Name = "RestUserLabel";
            this.RestUserLabel.Size = new System.Drawing.Size(87, 16);
            this.RestUserLabel.TabIndex = 1;
            this.RestUserLabel.Text = "صاحب رستوران:";
            // 
            // WorkTimeLabel
            // 
            this.WorkTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkTimeLabel.AutoSize = true;
            this.WorkTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.WorkTimeLabel.Location = new System.Drawing.Point(424, 234);
            this.WorkTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WorkTimeLabel.Name = "WorkTimeLabel";
            this.WorkTimeLabel.Size = new System.Drawing.Size(129, 16);
            this.WorkTimeLabel.TabIndex = 2;
            this.WorkTimeLabel.Text = "ساعت کارکرد رستوران :";
            // 
            // TxtAdminAddress
            // 
            this.TxtAdminAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAdminAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtAdminAddress.Location = new System.Drawing.Point(23, 368);
            this.TxtAdminAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtAdminAddress.Multiline = true;
            this.TxtAdminAddress.Name = "TxtAdminAddress";
            this.TxtAdminAddress.Size = new System.Drawing.Size(388, 83);
            this.TxtAdminAddress.TabIndex = 19;
            // 
            // TxtAdminNationalCode
            // 
            this.TxtAdminNationalCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAdminNationalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtAdminNationalCode.Location = new System.Drawing.Point(23, 187);
            this.TxtAdminNationalCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtAdminNationalCode.Multiline = true;
            this.TxtAdminNationalCode.Name = "TxtAdminNationalCode";
            this.TxtAdminNationalCode.Size = new System.Drawing.Size(388, 34);
            this.TxtAdminNationalCode.TabIndex = 18;
            // 
            // TxtAdminFamily
            // 
            this.TxtAdminFamily.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAdminFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtAdminFamily.Location = new System.Drawing.Point(23, 143);
            this.TxtAdminFamily.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtAdminFamily.Multiline = true;
            this.TxtAdminFamily.Name = "TxtAdminFamily";
            this.TxtAdminFamily.Size = new System.Drawing.Size(388, 34);
            this.TxtAdminFamily.TabIndex = 17;
            // 
            // txtAdmin
            // 
            this.txtAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtAdmin.Location = new System.Drawing.Point(23, 99);
            this.txtAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAdmin.Multiline = true;
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.Size = new System.Drawing.Size(388, 34);
            this.txtAdmin.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(488, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "نام کاربر :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(472, 371);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "آدرس کاربر :";
            // 
            // FamilyLabel
            // 
            this.FamilyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FamilyLabel.AutoSize = true;
            this.FamilyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FamilyLabel.Location = new System.Drawing.Point(436, 152);
            this.FamilyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FamilyLabel.Name = "FamilyLabel";
            this.FamilyLabel.Size = new System.Drawing.Size(112, 16);
            this.FamilyLabel.TabIndex = 13;
            this.FamilyLabel.Text = "نام خانوادگی کاربر :";
            // 
            // NationalCodeLabel
            // 
            this.NationalCodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NationalCodeLabel.AutoSize = true;
            this.NationalCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NationalCodeLabel.Location = new System.Drawing.Point(467, 190);
            this.NationalCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NationalCodeLabel.Name = "NationalCodeLabel";
            this.NationalCodeLabel.Size = new System.Drawing.Size(81, 16);
            this.NationalCodeLabel.TabIndex = 14;
            this.NationalCodeLabel.Text = "کد ملی کاربر :";
            // 
            // RestaurantRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 508);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "RestaurantRegisterForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ثبت نام رستوران";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.TextBox TxtRestAddress;
        private System.Windows.Forms.TextBox TxtTimeFrom;
        private System.Windows.Forms.TextBox TxtOwner;
        private System.Windows.Forms.TextBox TxtRestName;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label RestUserLabel;
        private System.Windows.Forms.Label WorkTimeLabel;
        private System.Windows.Forms.TextBox TxtTimeTo;
        private System.Windows.Forms.Label EndTimeLabel;
        private System.Windows.Forms.Label StartTimeLabel;
        private System.Windows.Forms.TextBox TxtAdminAddress;
        private System.Windows.Forms.TextBox TxtAdminNationalCode;
        private System.Windows.Forms.TextBox TxtAdminFamily;
        private System.Windows.Forms.TextBox txtAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FamilyLabel;
        private System.Windows.Forms.Label NationalCodeLabel;
    }
}