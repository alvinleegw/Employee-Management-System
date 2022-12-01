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
            this.closeButton = new System.Windows.Forms.Button();
            this.minimiseButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.historyButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.payrollButton = new System.Windows.Forms.Button();
            this.clockoutButton = new System.Windows.Forms.Button();
            this.clockinButton = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Tomato;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeButton.Location = new System.Drawing.Point(1543, 12);
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
            this.minimiseButton.Location = new System.Drawing.Point(1464, 12);
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
            this.panel1.Controls.Add(this.historyButton);
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.payrollButton);
            this.panel1.Controls.Add(this.clockoutButton);
            this.panel1.Controls.Add(this.clockinButton);
            this.panel1.Controls.Add(this.userLabel);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 800);
            this.panel1.TabIndex = 2;
            // 
            // historyButton
            // 
            this.historyButton.BackColor = System.Drawing.Color.Black;
            this.historyButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.historyButton.ForeColor = System.Drawing.Color.White;
            this.historyButton.Location = new System.Drawing.Point(60, 351);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(225, 69);
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
            this.logoutButton.Location = new System.Drawing.Point(60, 576);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(225, 69);
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
            this.payrollButton.Location = new System.Drawing.Point(60, 462);
            this.payrollButton.Name = "payrollButton";
            this.payrollButton.Size = new System.Drawing.Size(225, 69);
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
            this.clockoutButton.Location = new System.Drawing.Point(60, 237);
            this.clockoutButton.Name = "clockoutButton";
            this.clockoutButton.Size = new System.Drawing.Size(225, 69);
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
            this.clockinButton.Location = new System.Drawing.Point(60, 125);
            this.clockinButton.Name = "clockinButton";
            this.clockinButton.Size = new System.Drawing.Size(225, 69);
            this.clockinButton.TabIndex = 3;
            this.clockinButton.Text = "Clock In";
            this.clockinButton.UseVisualStyleBackColor = false;
            this.clockinButton.Click += new System.EventHandler(this.clockinButton_Click);
            // 
            // userLabel
            // 
            this.userLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userLabel.ForeColor = System.Drawing.Color.Black;
            this.userLabel.Location = new System.Drawing.Point(0, 23);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(337, 48);
            this.userLabel.TabIndex = 0;
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1626, 800);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.minimiseButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeDashboard";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EmployeeDashboard_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EmployeeDashboard_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EmployeeDashboard_MouseUp);
            this.panel1.ResumeLayout(false);
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
    }
}