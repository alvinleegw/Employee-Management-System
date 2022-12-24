namespace EMS
{
    partial class EmployeeDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDashboard));
            this.closeButton = new System.Windows.Forms.Button();
            this.minimiseButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.leaveButton = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.changepasswordButton = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.payrollButton = new System.Windows.Forms.Button();
            this.clockoutButton = new System.Windows.Forms.Button();
            this.clockinButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.clockoutLabel = new System.Windows.Forms.Label();
            this.display2Label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.clockinLabel = new System.Windows.Forms.Label();
            this.displayLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.workinghoursLabel = new System.Windows.Forms.Label();
            this.display3Label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Tomato;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeButton.Location = new System.Drawing.Point(1922, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(73, 69);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // minimiseButton
            // 
            this.minimiseButton.BackColor = System.Drawing.Color.Gold;
            this.minimiseButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minimiseButton.Location = new System.Drawing.Point(1843, 12);
            this.minimiseButton.Name = "minimiseButton";
            this.minimiseButton.Size = new System.Drawing.Size(73, 69);
            this.minimiseButton.TabIndex = 1;
            this.minimiseButton.Text = "-";
            this.minimiseButton.UseVisualStyleBackColor = false;
            this.minimiseButton.Click += new System.EventHandler(this.minimiseButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.leaveButton);
            this.panel1.Controls.Add(this.userLabel);
            this.panel1.Controls.Add(this.changepasswordButton);
            this.panel1.Controls.Add(this.historyButton);
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.payrollButton);
            this.panel1.Controls.Add(this.clockoutButton);
            this.panel1.Controls.Add(this.clockinButton);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 906);
            this.panel1.TabIndex = 2;
            // 
            // leaveButton
            // 
            this.leaveButton.BackColor = System.Drawing.Color.Black;
            this.leaveButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.leaveButton.ForeColor = System.Drawing.Color.White;
            this.leaveButton.Image = global::EMS.Properties.Resources.leave;
            this.leaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.leaveButton.Location = new System.Drawing.Point(32, 686);
            this.leaveButton.Name = "leaveButton";
            this.leaveButton.Size = new System.Drawing.Size(442, 89);
            this.leaveButton.TabIndex = 9;
            this.leaveButton.Text = "Apply Leave";
            this.leaveButton.UseVisualStyleBackColor = false;
            this.leaveButton.Click += new System.EventHandler(this.leaveButton_Click);
            // 
            // userLabel
            // 
            this.userLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userLabel.ForeColor = System.Drawing.Color.Black;
            this.userLabel.Location = new System.Drawing.Point(3, 34);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(493, 48);
            this.userLabel.TabIndex = 0;
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // changepasswordButton
            // 
            this.changepasswordButton.BackColor = System.Drawing.Color.Black;
            this.changepasswordButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.changepasswordButton.ForeColor = System.Drawing.Color.White;
            this.changepasswordButton.Image = global::EMS.Properties.Resources.change_password_2;
            this.changepasswordButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.changepasswordButton.Location = new System.Drawing.Point(32, 126);
            this.changepasswordButton.Name = "changepasswordButton";
            this.changepasswordButton.Size = new System.Drawing.Size(442, 93);
            this.changepasswordButton.TabIndex = 8;
            this.changepasswordButton.Text = "Change Password";
            this.changepasswordButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changepasswordButton.UseVisualStyleBackColor = false;
            this.changepasswordButton.Click += new System.EventHandler(this.changepasswordButton_Click);
            // 
            // historyButton
            // 
            this.historyButton.BackColor = System.Drawing.Color.Black;
            this.historyButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.historyButton.ForeColor = System.Drawing.Color.White;
            this.historyButton.Image = global::EMS.Properties.Resources.history;
            this.historyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.historyButton.Location = new System.Drawing.Point(32, 468);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(442, 89);
            this.historyButton.TabIndex = 7;
            this.historyButton.Text = "History";
            this.historyButton.UseVisualStyleBackColor = false;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Black;
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Image = global::EMS.Properties.Resources.logout;
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logoutButton.Location = new System.Drawing.Point(32, 793);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(442, 89);
            this.logoutButton.TabIndex = 6;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // payrollButton
            // 
            this.payrollButton.BackColor = System.Drawing.Color.Black;
            this.payrollButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.payrollButton.ForeColor = System.Drawing.Color.White;
            this.payrollButton.Image = global::EMS.Properties.Resources.payroll;
            this.payrollButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.payrollButton.Location = new System.Drawing.Point(32, 579);
            this.payrollButton.Name = "payrollButton";
            this.payrollButton.Size = new System.Drawing.Size(442, 89);
            this.payrollButton.TabIndex = 5;
            this.payrollButton.Text = "Payroll";
            this.payrollButton.UseVisualStyleBackColor = false;
            this.payrollButton.Click += new System.EventHandler(this.payrollButton_Click);
            // 
            // clockoutButton
            // 
            this.clockoutButton.BackColor = System.Drawing.Color.Black;
            this.clockoutButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clockoutButton.ForeColor = System.Drawing.Color.White;
            this.clockoutButton.Image = global::EMS.Properties.Resources.clock_out_2;
            this.clockoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clockoutButton.Location = new System.Drawing.Point(32, 354);
            this.clockoutButton.Name = "clockoutButton";
            this.clockoutButton.Size = new System.Drawing.Size(442, 89);
            this.clockoutButton.TabIndex = 4;
            this.clockoutButton.Text = "Clock Out";
            this.clockoutButton.UseVisualStyleBackColor = false;
            this.clockoutButton.Click += new System.EventHandler(this.clockoutButton_Click);
            // 
            // clockinButton
            // 
            this.clockinButton.BackColor = System.Drawing.Color.Black;
            this.clockinButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clockinButton.ForeColor = System.Drawing.Color.White;
            this.clockinButton.Image = global::EMS.Properties.Resources.clock_in_3;
            this.clockinButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clockinButton.Location = new System.Drawing.Point(32, 242);
            this.clockinButton.Name = "clockinButton";
            this.clockinButton.Size = new System.Drawing.Size(442, 89);
            this.clockinButton.TabIndex = 3;
            this.clockinButton.Text = "Clock In";
            this.clockinButton.UseVisualStyleBackColor = false;
            this.clockinButton.Click += new System.EventHandler(this.clockinButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.clockoutLabel);
            this.panel4.Controls.Add(this.display2Label);
            this.panel4.Location = new System.Drawing.Point(1030, 125);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(458, 196);
            this.panel4.TabIndex = 11;
            // 
            // clockoutLabel
            // 
            this.clockoutLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clockoutLabel.ForeColor = System.Drawing.Color.Black;
            this.clockoutLabel.Location = new System.Drawing.Point(6, 104);
            this.clockoutLabel.Name = "clockoutLabel";
            this.clockoutLabel.Size = new System.Drawing.Size(449, 72);
            this.clockoutLabel.TabIndex = 1;
            this.clockoutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // display2Label
            // 
            this.display2Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.display2Label.ForeColor = System.Drawing.Color.Black;
            this.display2Label.Image = global::EMS.Properties.Resources.clock_out;
            this.display2Label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.display2Label.Location = new System.Drawing.Point(82, 13);
            this.display2Label.Name = "display2Label";
            this.display2Label.Size = new System.Drawing.Size(309, 65);
            this.display2Label.TabIndex = 0;
            this.display2Label.Text = "Clock Out";
            this.display2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.clockinLabel);
            this.panel3.Controls.Add(this.displayLabel);
            this.panel3.Location = new System.Drawing.Point(519, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(458, 196);
            this.panel3.TabIndex = 10;
            // 
            // clockinLabel
            // 
            this.clockinLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clockinLabel.ForeColor = System.Drawing.Color.Black;
            this.clockinLabel.Location = new System.Drawing.Point(3, 87);
            this.clockinLabel.Name = "clockinLabel";
            this.clockinLabel.Size = new System.Drawing.Size(452, 89);
            this.clockinLabel.TabIndex = 1;
            this.clockinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayLabel
            // 
            this.displayLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.displayLabel.ForeColor = System.Drawing.Color.Black;
            this.displayLabel.Image = global::EMS.Properties.Resources.clock_in;
            this.displayLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.displayLabel.Location = new System.Drawing.Point(99, 13);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(268, 65);
            this.displayLabel.TabIndex = 0;
            this.displayLabel.Text = "Clock In";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.workinghoursLabel);
            this.panel2.Controls.Add(this.display3Label);
            this.panel2.Location = new System.Drawing.Point(1537, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 196);
            this.panel2.TabIndex = 9;
            // 
            // workinghoursLabel
            // 
            this.workinghoursLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.workinghoursLabel.ForeColor = System.Drawing.Color.Black;
            this.workinghoursLabel.Location = new System.Drawing.Point(3, 80);
            this.workinghoursLabel.Name = "workinghoursLabel";
            this.workinghoursLabel.Size = new System.Drawing.Size(449, 96);
            this.workinghoursLabel.TabIndex = 1;
            this.workinghoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // display3Label
            // 
            this.display3Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.display3Label.ForeColor = System.Drawing.Color.Black;
            this.display3Label.Image = global::EMS.Properties.Resources.working_hours;
            this.display3Label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.display3Label.Location = new System.Drawing.Point(3, 10);
            this.display3Label.Name = "display3Label";
            this.display3Label.Size = new System.Drawing.Size(449, 65);
            this.display3Label.TabIndex = 0;
            this.display3Label.Text = "Working Hours";
            // 
            // EmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(2007, 904);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.minimiseButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Dashboard";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EmployeeDashboard_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EmployeeDashboard_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EmployeeDashboard_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button closeButton;
        private Button minimiseButton;
        private Panel panel1;
        private Label userLabel;
        private Button clockinButton;
        private Button logoutButton;
        private Button payrollButton;
        private Button clockoutButton;
        private Button historyButton;
        private Button changepasswordButton;
        private Panel panel4;
        private Label clockoutLabel;
        private Label display2Label;
        private Panel panel3;
        private Label clockinLabel;
        private Label displayLabel;
        private Panel panel2;
        private Label workinghoursLabel;
        private Label display3Label;
        private Button leaveButton;
    }
}