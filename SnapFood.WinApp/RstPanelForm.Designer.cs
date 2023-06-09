namespace SnapFood.WinApp
{
    partial class RstPanelForm
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
            this.BtnFood = new System.Windows.Forms.Button();
            this.BtnFactor = new System.Windows.Forms.Button();
            this.BtnCustomer = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.SidPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LblRstNam = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.BtnFood);
            this.panel1.Controls.Add(this.BtnFactor);
            this.panel1.Controls.Add(this.BtnCustomer);
            this.panel1.Controls.Add(this.BtnHome);
            this.panel1.Controls.Add(this.SidPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(961, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 615);
            this.panel1.TabIndex = 0;
            // 
            // BtnFood
            // 
            this.BtnFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnFood.FlatAppearance.BorderSize = 0;
            this.BtnFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFood.ForeColor = System.Drawing.Color.White;
            this.BtnFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFood.Location = new System.Drawing.Point(12, 189);
            this.BtnFood.Name = "BtnFood";
            this.BtnFood.Size = new System.Drawing.Size(182, 41);
            this.BtnFood.TabIndex = 14;
            this.BtnFood.Text = "Edit / Add Foods";
            this.BtnFood.UseVisualStyleBackColor = true;
            this.BtnFood.Click += new System.EventHandler(this.button5_Click);
            // 
            // BtnFactor
            // 
            this.BtnFactor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnFactor.FlatAppearance.BorderSize = 0;
            this.BtnFactor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFactor.ForeColor = System.Drawing.Color.White;
            this.BtnFactor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFactor.Location = new System.Drawing.Point(10, 250);
            this.BtnFactor.Name = "BtnFactor";
            this.BtnFactor.Size = new System.Drawing.Size(182, 41);
            this.BtnFactor.TabIndex = 13;
            this.BtnFactor.Text = "Factors";
            this.BtnFactor.UseVisualStyleBackColor = true;
            this.BtnFactor.Click += new System.EventHandler(this.BtnFactor_Click);
            // 
            // BtnCustomer
            // 
            this.BtnCustomer.BackgroundImage = global::SnapFood.WinApp.Properties.Resources.customer;
            this.BtnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCustomer.FlatAppearance.BorderSize = 0;
            this.BtnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCustomer.ForeColor = System.Drawing.Color.White;
            this.BtnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCustomer.Location = new System.Drawing.Point(14, 311);
            this.BtnCustomer.Name = "BtnCustomer";
            this.BtnCustomer.Size = new System.Drawing.Size(182, 41);
            this.BtnCustomer.TabIndex = 11;
            this.BtnCustomer.Text = "Customer";
            this.BtnCustomer.UseVisualStyleBackColor = false;
            this.BtnCustomer.Click += new System.EventHandler(this.BtnCustomer_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.BackgroundImage = global::SnapFood.WinApp.Properties.Resources.home__2_;
            this.BtnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.ForeColor = System.Drawing.Color.White;
            this.BtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnHome.Location = new System.Drawing.Point(3, 116);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(168, 54);
            this.BtnHome.TabIndex = 8;
            this.BtnHome.Text = "Home";
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // SidPanel
            // 
            this.SidPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.SidPanel.Location = new System.Drawing.Point(172, 126);
            this.SidPanel.Name = "SidPanel";
            this.SidPanel.Size = new System.Drawing.Size(10, 41);
            this.SidPanel.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(961, 37);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.panel4.Controls.Add(this.LblRstNam);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(865, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(96, 104);
            this.panel4.TabIndex = 2;
            // 
            // LblRstNam
            // 
            this.LblRstNam.AutoSize = true;
            this.LblRstNam.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblRstNam.Location = new System.Drawing.Point(3, 75);
            this.LblRstNam.Name = "LblRstNam";
            this.LblRstNam.Size = new System.Drawing.Size(79, 20);
            this.LblRstNam.TabIndex = 0;
            this.LblRstNam.Text = "اسم رستوران";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SnapFood.WinApp.Properties.Resources.pizza;
            this.pictureBox1.Location = new System.Drawing.Point(-6, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitle.Location = new System.Drawing.Point(711, 47);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(142, 32);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "snapFood";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.button2.BackgroundImage = global::SnapFood.WinApp.Properties.Resources.yahoo;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(104, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.button3.BackgroundImage = global::SnapFood.WinApp.Properties.Resources.whatsapp;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(58, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 40);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.button1.BackgroundImage = global::SnapFood.WinApp.Properties.Resources.power_off;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RstPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1161, 615);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RstPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "resturanPanelNew";
            this.Load += new System.EventHandler(this.resturanPanelNew_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SidPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label LblRstNam;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button BtnCustomer;
        private System.Windows.Forms.Button BtnFood;
        private System.Windows.Forms.Button BtnFactor;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}