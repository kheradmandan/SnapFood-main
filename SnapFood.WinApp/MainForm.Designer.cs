namespace SnapFood.WinApp
{
    partial class MainForm
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
            this.TlsMainForm = new System.Windows.Forms.ToolStrip();
            this.tlsMainBtnLogin = new System.Windows.Forms.ToolStripButton();
            this.tlsMainBtnSignup = new System.Windows.Forms.ToolStripDropDownButton();
            this.tlsCustomerSignupMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsRestaurantSignupMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMainFormExitBtn = new System.Windows.Forms.ToolStripButton();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.dgvUserList = new System.Windows.Forms.DataGridView();
            this.dgvRestList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TlsMainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestList)).BeginInit();
            this.SuspendLayout();
            // 
            // TlsMainForm
            // 
            this.TlsMainForm.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TlsMainForm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TlsMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsMainBtnLogin,
            this.tlsMainBtnSignup,
            this.tlsMainFormExitBtn});
            this.TlsMainForm.Location = new System.Drawing.Point(0, 0);
            this.TlsMainForm.Name = "TlsMainForm";
            this.TlsMainForm.Size = new System.Drawing.Size(1211, 84);
            this.TlsMainForm.TabIndex = 0;
            this.TlsMainForm.Text = "toolStrip1";
            // 
            // tlsMainBtnLogin
            // 
            this.tlsMainBtnLogin.Image = global::SnapFood.WinApp.Properties.Resources.LoginIcon50px;
            this.tlsMainBtnLogin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlsMainBtnLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsMainBtnLogin.Name = "tlsMainBtnLogin";
            this.tlsMainBtnLogin.Size = new System.Drawing.Size(54, 79);
            this.tlsMainBtnLogin.Text = "ورود";
            this.tlsMainBtnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tlsMainBtnLogin.ToolTipText = "جهت ورود به سیستم بر روی این گزینه کلیک نمایید.";
            this.tlsMainBtnLogin.Click += new System.EventHandler(this.tlsMainBtnLogin_Click);
            // 
            // tlsMainBtnSignup
            // 
            this.tlsMainBtnSignup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsCustomerSignupMenu,
            this.tlsRestaurantSignupMenu});
            this.tlsMainBtnSignup.Image = global::SnapFood.WinApp.Properties.Resources.sign_up_icon_1_50px;
            this.tlsMainBtnSignup.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlsMainBtnSignup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsMainBtnSignup.Name = "tlsMainBtnSignup";
            this.tlsMainBtnSignup.Size = new System.Drawing.Size(93, 79);
            this.tlsMainBtnSignup.Text = "عضویت";
            this.tlsMainBtnSignup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tlsMainBtnSignup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tlsMainBtnSignup.ToolTipText = "جهت عضویت در سیستم بر روی این گزینه کلیک نمایید.";
            // 
            // tlsCustomerSignupMenu
            // 
            this.tlsCustomerSignupMenu.Name = "tlsCustomerSignupMenu";
            this.tlsCustomerSignupMenu.Size = new System.Drawing.Size(257, 34);
            this.tlsCustomerSignupMenu.Text = "ثبت نام مشتری";
            this.tlsCustomerSignupMenu.Click += new System.EventHandler(this.tlsCustomerSignupMenu_Click);
            // 
            // tlsRestaurantSignupMenu
            // 
            this.tlsRestaurantSignupMenu.Name = "tlsRestaurantSignupMenu";
            this.tlsRestaurantSignupMenu.Size = new System.Drawing.Size(257, 34);
            this.tlsRestaurantSignupMenu.Text = "ثبت نام رستوران";
            this.tlsRestaurantSignupMenu.Click += new System.EventHandler(this.tlsRestaurantSignupMenu_Click);
            // 
            // tlsMainFormExitBtn
            // 
            this.tlsMainFormExitBtn.Image = global::SnapFood.WinApp.Properties.Resources.Logout_Icon2_50px;
            this.tlsMainFormExitBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlsMainFormExitBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsMainFormExitBtn.Name = "tlsMainFormExitBtn";
            this.tlsMainFormExitBtn.Size = new System.Drawing.Size(61, 79);
            this.tlsMainFormExitBtn.Text = "خروج";
            this.tlsMainFormExitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tlsMainFormExitBtn.ToolTipText = "جهت خروج از سیستم بر روی این گزینه کلیک نمایید.";
            this.tlsMainFormExitBtn.Click += new System.EventHandler(this.tlsMainFormExitBtn_Click);
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.Location = new System.Drawing.Point(8, 92);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(683, 25);
            this.lblCopyRight.TabIndex = 1;
            this.lblCopyRight.Text = "© تمام حقوق برای تیم دوم پروژه گروهی بوت کمپ چارگون محفوظ می‌باشد.";
            // 
            // dgvUserList
            // 
            this.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserList.Location = new System.Drawing.Point(12, 170);
            this.dgvUserList.Name = "dgvUserList";
            this.dgvUserList.RowHeadersWidth = 51;
            this.dgvUserList.RowTemplate.Height = 24;
            this.dgvUserList.Size = new System.Drawing.Size(629, 150);
            this.dgvUserList.TabIndex = 2;
            // 
            // dgvRestList
            // 
            this.dgvRestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRestList.Location = new System.Drawing.Point(677, 170);
            this.dgvRestList.Name = "dgvRestList";
            this.dgvRestList.RowHeadersWidth = 51;
            this.dgvRestList.RowTemplate.Height = 24;
            this.dgvRestList.Size = new System.Drawing.Size(462, 150);
            this.dgvRestList.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "لیست کاربران";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(866, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "لیست رستوران ها";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1211, 591);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRestList);
            this.Controls.Add(this.dgvUserList);
            this.Controls.Add(this.lblCopyRight);
            this.Controls.Add(this.TlsMainForm);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اسنپ فود";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.TlsMainForm.ResumeLayout(false);
            this.TlsMainForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton tlsMainBtnLogin;
        private System.Windows.Forms.ToolStripDropDownButton tlsMainBtnSignup;
        private System.Windows.Forms.ToolStripMenuItem tlsCustomerSignupMenu;
        private System.Windows.Forms.ToolStripMenuItem tlsRestaurantSignupMenu;
        private System.Windows.Forms.ToolStripButton tlsMainFormExitBtn;
        private System.Windows.Forms.ToolStrip TlsMainForm;
        private System.Windows.Forms.Label lblCopyRight;
        private System.Windows.Forms.DataGridView dgvUserList;
        private System.Windows.Forms.DataGridView dgvRestList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}