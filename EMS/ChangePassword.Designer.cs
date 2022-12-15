namespace EMS
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.closeButton = new System.Windows.Forms.Button();
            this.minimiseButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.inputusernameLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.inputpasswordLabel = new System.Windows.Forms.Label();
            this.password2TextBox = new System.Windows.Forms.TextBox();
            this.inputpassword2Label = new System.Windows.Forms.Label();
            this.status2Label = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Tomato;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeButton.Location = new System.Drawing.Point(1323, 12);
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
            this.minimiseButton.Location = new System.Drawing.Point(1235, 12);
            this.minimiseButton.Name = "minimiseButton";
            this.minimiseButton.Size = new System.Drawing.Size(73, 69);
            this.minimiseButton.TabIndex = 1;
            this.minimiseButton.Text = "-";
            this.minimiseButton.UseVisualStyleBackColor = false;
            this.minimiseButton.Click += new System.EventHandler(this.minimiseButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.SkyBlue;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(542, 16);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(423, 65);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Change Password";
            // 
            // inputusernameLabel
            // 
            this.inputusernameLabel.AutoSize = true;
            this.inputusernameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inputusernameLabel.ForeColor = System.Drawing.Color.White;
            this.inputusernameLabel.Location = new System.Drawing.Point(248, 119);
            this.inputusernameLabel.Name = "inputusernameLabel";
            this.inputusernameLabel.Size = new System.Drawing.Size(306, 48);
            this.inputusernameLabel.TabIndex = 3;
            this.inputusernameLabel.Text = "Enter Username: ";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inputTextBox.Location = new System.Drawing.Point(564, 116);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(351, 55);
            this.inputTextBox.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Plum;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchButton.ForeColor = System.Drawing.Color.SlateBlue;
            this.searchButton.Image = global::EMS.Properties.Resources.search_3;
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchButton.Location = new System.Drawing.Point(928, 99);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(197, 89);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Location = new System.Drawing.Point(258, 167);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 48);
            this.statusLabel.TabIndex = 6;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Plum;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateButton.ForeColor = System.Drawing.Color.SlateBlue;
            this.updateButton.Image = global::EMS.Properties.Resources.change_password_4;
            this.updateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateButton.Location = new System.Drawing.Point(526, 390);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(389, 89);
            this.updateButton.TabIndex = 9;
            this.updateButton.Text = "Update Password";
            this.updateButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordTextBox.Location = new System.Drawing.Point(633, 220);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(492, 55);
            this.passwordTextBox.TabIndex = 8;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // inputpasswordLabel
            // 
            this.inputpasswordLabel.AutoSize = true;
            this.inputpasswordLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inputpasswordLabel.ForeColor = System.Drawing.Color.White;
            this.inputpasswordLabel.Location = new System.Drawing.Point(248, 223);
            this.inputpasswordLabel.Name = "inputpasswordLabel";
            this.inputpasswordLabel.Size = new System.Drawing.Size(383, 48);
            this.inputpasswordLabel.TabIndex = 7;
            this.inputpasswordLabel.Text = "Enter New Password: ";
            // 
            // password2TextBox
            // 
            this.password2TextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.password2TextBox.Location = new System.Drawing.Point(633, 309);
            this.password2TextBox.Name = "password2TextBox";
            this.password2TextBox.Size = new System.Drawing.Size(492, 55);
            this.password2TextBox.TabIndex = 11;
            this.password2TextBox.UseSystemPasswordChar = true;
            // 
            // inputpassword2Label
            // 
            this.inputpassword2Label.AutoSize = true;
            this.inputpassword2Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inputpassword2Label.ForeColor = System.Drawing.Color.White;
            this.inputpassword2Label.Location = new System.Drawing.Point(187, 309);
            this.inputpassword2Label.Name = "inputpassword2Label";
            this.inputpassword2Label.Size = new System.Drawing.Size(444, 48);
            this.inputpassword2Label.TabIndex = 10;
            this.inputpassword2Label.Text = "Enter Confirm Password: ";
            // 
            // status2Label
            // 
            this.status2Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.status2Label.ForeColor = System.Drawing.Color.White;
            this.status2Label.Location = new System.Drawing.Point(4, 486);
            this.status2Label.Name = "status2Label";
            this.status2Label.Size = new System.Drawing.Size(1404, 48);
            this.status2Label.TabIndex = 12;
            this.status2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Plum;
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetButton.ForeColor = System.Drawing.Color.SlateBlue;
            this.resetButton.Image = global::EMS.Properties.Resources.reset_3;
            this.resetButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resetButton.Location = new System.Drawing.Point(940, 390);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(185, 89);
            this.resetButton.TabIndex = 13;
            this.resetButton.Text = "Reset";
            this.resetButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1408, 672);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.status2Label);
            this.Controls.Add(this.password2TextBox);
            this.Controls.Add(this.inputpassword2Label);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.inputpasswordLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.inputusernameLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.minimiseButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password (Admin)";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChangePassword_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangePassword_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ChangePassword_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button closeButton;
        private Button minimiseButton;
        private Label titleLabel;
        private Label inputusernameLabel;
        private TextBox inputTextBox;
        private Button searchButton;
        private Label statusLabel;
        private Button updateButton;
        private TextBox passwordTextBox;
        private Label inputpasswordLabel;
        private TextBox password2TextBox;
        private Label inputpassword2Label;
        private Label status2Label;
        private Button resetButton;
    }
}