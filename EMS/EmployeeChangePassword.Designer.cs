namespace EMS
{
    partial class EmployeeChangePassword
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
            this.miniseButton = new System.Windows.Forms.Button();
            this.inputpasswordLabel = new System.Windows.Forms.Label();
            this.inputpassword2Label = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.password2TextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Tomato;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeButton.Location = new System.Drawing.Point(1252, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(73, 69);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // miniseButton
            // 
            this.miniseButton.BackColor = System.Drawing.Color.Gold;
            this.miniseButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.miniseButton.Location = new System.Drawing.Point(1173, 12);
            this.miniseButton.Name = "miniseButton";
            this.miniseButton.Size = new System.Drawing.Size(73, 69);
            this.miniseButton.TabIndex = 1;
            this.miniseButton.Text = "-";
            this.miniseButton.UseVisualStyleBackColor = false;
            this.miniseButton.Click += new System.EventHandler(this.miniseButton_Click);
            // 
            // inputpasswordLabel
            // 
            this.inputpasswordLabel.AutoSize = true;
            this.inputpasswordLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inputpasswordLabel.Location = new System.Drawing.Point(247, 170);
            this.inputpasswordLabel.Name = "inputpasswordLabel";
            this.inputpasswordLabel.Size = new System.Drawing.Size(373, 48);
            this.inputpasswordLabel.TabIndex = 2;
            this.inputpasswordLabel.Text = "Enter New Password:";
            // 
            // inputpassword2Label
            // 
            this.inputpassword2Label.AutoSize = true;
            this.inputpassword2Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inputpassword2Label.Location = new System.Drawing.Point(186, 258);
            this.inputpassword2Label.Name = "inputpassword2Label";
            this.inputpassword2Label.Size = new System.Drawing.Size(434, 48);
            this.inputpassword2Label.TabIndex = 3;
            this.inputpassword2Label.Text = "Enter Confirm Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordTextBox.Location = new System.Drawing.Point(626, 170);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(450, 55);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // password2TextBox
            // 
            this.password2TextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.password2TextBox.Location = new System.Drawing.Point(626, 258);
            this.password2TextBox.Name = "password2TextBox";
            this.password2TextBox.Size = new System.Drawing.Size(450, 55);
            this.password2TextBox.TabIndex = 5;
            this.password2TextBox.UseSystemPasswordChar = true;
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateButton.Location = new System.Drawing.Point(547, 354);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(341, 69);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Update Password";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetButton.Location = new System.Drawing.Point(908, 354);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(168, 69);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(512, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(423, 65);
            this.titleLabel.TabIndex = 8;
            this.titleLabel.Text = "Change Password";
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusLabel.ForeColor = System.Drawing.Color.Green;
            this.statusLabel.Location = new System.Drawing.Point(2, 448);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(1329, 48);
            this.statusLabel.TabIndex = 9;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmployeeChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1337, 672);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.password2TextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.inputpassword2Label);
            this.Controls.Add(this.inputpasswordLabel);
            this.Controls.Add(this.miniseButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeChangePassword";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EmployeeChangePassword_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EmployeeChangePassword_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EmployeeChangePassword_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button closeButton;
        private Button miniseButton;
        private Label inputpasswordLabel;
        private Label inputpassword2Label;
        private TextBox passwordTextBox;
        private TextBox password2TextBox;
        private Button updateButton;
        private Button resetButton;
        private Label titleLabel;
        private Label statusLabel;
    }
}