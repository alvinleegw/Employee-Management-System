namespace EMS
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.userLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.panel1 = new System.Windows.Forms.Panel();
            this.payrollButton = new System.Windows.Forms.Button();
            this.archiveButton = new System.Windows.Forms.Button();
            this.changepasswordButton = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.manageButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.display1Label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.clockinLabel = new System.Windows.Forms.Label();
            this.display2Label = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.clockoutLabel = new System.Windows.Forms.Label();
            this.display3Label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userLabel.ForeColor = System.Drawing.Color.White;
            this.userLabel.Location = new System.Drawing.Point(3, 20);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(503, 54);
            this.userLabel.TabIndex = 0;
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Tomato;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeButton.Location = new System.Drawing.Point(1971, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(78, 69);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.payrollButton);
            this.panel1.Controls.Add(this.archiveButton);
            this.panel1.Controls.Add(this.changepasswordButton);
            this.panel1.Controls.Add(this.historyButton);
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.manageButton);
            this.panel1.Controls.Add(this.userLabel);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 896);
            this.panel1.TabIndex = 4;
            // 
            // payrollButton
            // 
            this.payrollButton.BackColor = System.Drawing.Color.Firebrick;
            this.payrollButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.payrollButton.ForeColor = System.Drawing.Color.White;
            this.payrollButton.Image = global::EMS.Properties.Resources.payroll_2;
            this.payrollButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.payrollButton.Location = new System.Drawing.Point(38, 608);
            this.payrollButton.Name = "payrollButton";
            this.payrollButton.Size = new System.Drawing.Size(442, 93);
            this.payrollButton.TabIndex = 10;
            this.payrollButton.Text = "Payroll";
            this.payrollButton.UseVisualStyleBackColor = false;
            this.payrollButton.Click += new System.EventHandler(this.payrollButton_Click);
            // 
            // archiveButton
            // 
            this.archiveButton.BackColor = System.Drawing.Color.Firebrick;
            this.archiveButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.archiveButton.ForeColor = System.Drawing.Color.White;
            this.archiveButton.Image = global::EMS.Properties.Resources.archive_2;
            this.archiveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.archiveButton.Location = new System.Drawing.Point(38, 475);
            this.archiveButton.Name = "archiveButton";
            this.archiveButton.Size = new System.Drawing.Size(442, 93);
            this.archiveButton.TabIndex = 9;
            this.archiveButton.Text = "View Archive";
            this.archiveButton.UseVisualStyleBackColor = false;
            this.archiveButton.Click += new System.EventHandler(this.archiveButton_Click);
            // 
            // changepasswordButton
            // 
            this.changepasswordButton.BackColor = System.Drawing.Color.Firebrick;
            this.changepasswordButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.changepasswordButton.ForeColor = System.Drawing.Color.White;
            this.changepasswordButton.Image = global::EMS.Properties.Resources.change_password;
            this.changepasswordButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.changepasswordButton.Location = new System.Drawing.Point(38, 210);
            this.changepasswordButton.Name = "changepasswordButton";
            this.changepasswordButton.Size = new System.Drawing.Size(442, 93);
            this.changepasswordButton.TabIndex = 4;
            this.changepasswordButton.Text = "Change Password";
            this.changepasswordButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changepasswordButton.UseVisualStyleBackColor = false;
            this.changepasswordButton.Click += new System.EventHandler(this.changepasswordButton_Click);
            // 
            // historyButton
            // 
            this.historyButton.BackColor = System.Drawing.Color.Firebrick;
            this.historyButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.historyButton.ForeColor = System.Drawing.Color.White;
            this.historyButton.Image = global::EMS.Properties.Resources.history;
            this.historyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.historyButton.Location = new System.Drawing.Point(38, 343);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(442, 93);
            this.historyButton.TabIndex = 3;
            this.historyButton.Text = "View History";
            this.historyButton.UseVisualStyleBackColor = false;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Firebrick;
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Image = global::EMS.Properties.Resources.logout;
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logoutButton.Location = new System.Drawing.Point(48, 742);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(442, 93);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // manageButton
            // 
            this.manageButton.BackColor = System.Drawing.Color.Firebrick;
            this.manageButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.manageButton.ForeColor = System.Drawing.Color.White;
            this.manageButton.Image = global::EMS.Properties.Resources.employee;
            this.manageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.manageButton.Location = new System.Drawing.Point(38, 77);
            this.manageButton.Name = "manageButton";
            this.manageButton.Size = new System.Drawing.Size(442, 93);
            this.manageButton.TabIndex = 0;
            this.manageButton.Text = "Manage Employee";
            this.manageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageButton.UseVisualStyleBackColor = false;
            this.manageButton.Click += new System.EventHandler(this.manageButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Gold;
            this.minimizeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minimizeButton.Location = new System.Drawing.Point(1887, 13);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(78, 69);
            this.minimizeButton.TabIndex = 6;
            this.minimizeButton.Text = "-";
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.employeeLabel);
            this.panel2.Controls.Add(this.display1Label);
            this.panel2.Location = new System.Drawing.Point(524, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 196);
            this.panel2.TabIndex = 7;
            // 
            // employeeLabel
            // 
            this.employeeLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.employeeLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.employeeLabel.Location = new System.Drawing.Point(3, 80);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(490, 96);
            this.employeeLabel.TabIndex = 1;
            this.employeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // display1Label
            // 
            this.display1Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.display1Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.display1Label.Image = global::EMS.Properties.Resources.employees;
            this.display1Label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.display1Label.Location = new System.Drawing.Point(73, 15);
            this.display1Label.Name = "display1Label";
            this.display1Label.Size = new System.Drawing.Size(349, 65);
            this.display1Label.TabIndex = 0;
            this.display1Label.Text = "Employees";
            this.display1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.clockinLabel);
            this.panel3.Controls.Add(this.display2Label);
            this.panel3.Location = new System.Drawing.Point(1035, 129);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(496, 196);
            this.panel3.TabIndex = 8;
            // 
            // clockinLabel
            // 
            this.clockinLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clockinLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.clockinLabel.Location = new System.Drawing.Point(3, 87);
            this.clockinLabel.Name = "clockinLabel";
            this.clockinLabel.Size = new System.Drawing.Size(490, 89);
            this.clockinLabel.TabIndex = 1;
            this.clockinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // display2Label
            // 
            this.display2Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.display2Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.display2Label.Image = global::EMS.Properties.Resources.clock_in;
            this.display2Label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.display2Label.Location = new System.Drawing.Point(23, 15);
            this.display2Label.Name = "display2Label";
            this.display2Label.Size = new System.Drawing.Size(446, 65);
            this.display2Label.TabIndex = 0;
            this.display2Label.Text = "Clock Ins Today";
            this.display2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.clockoutLabel);
            this.panel4.Controls.Add(this.display3Label);
            this.panel4.Location = new System.Drawing.Point(1545, 129);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(496, 196);
            this.panel4.TabIndex = 8;
            // 
            // clockoutLabel
            // 
            this.clockoutLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clockoutLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.clockoutLabel.Location = new System.Drawing.Point(6, 104);
            this.clockoutLabel.Name = "clockoutLabel";
            this.clockoutLabel.Size = new System.Drawing.Size(487, 72);
            this.clockoutLabel.TabIndex = 1;
            this.clockoutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // display3Label
            // 
            this.display3Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.display3Label.ForeColor = System.Drawing.Color.SteelBlue;
            this.display3Label.Image = global::EMS.Properties.Resources.clock_out;
            this.display3Label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.display3Label.Location = new System.Drawing.Point(6, 15);
            this.display3Label.Name = "display3Label";
            this.display3Label.Size = new System.Drawing.Size(479, 65);
            this.display3Label.TabIndex = 0;
            this.display3Label.Text = "Clock Outs Today";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(2061, 893);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminDashboard_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AdminDashboard_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AdminDashboard_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label userLabel;
        private Button closeButton;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Panel panel1;
        private Button logoutButton;
        private Button manageButton;
        private Button minimizeButton;
        private Button historyButton;
        private Button changepasswordButton;
        private Panel panel2;
        private Label employeeLabel;
        private Label display1Label;
        private Panel panel3;
        private Label clockinLabel;
        private Label display2Label;
        private Panel panel4;
        private Label clockoutLabel;
        private Label display3Label;
        private Button archiveButton;
        private Button payrollButton;
    }
}