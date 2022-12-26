namespace EMS
{
    partial class Leave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leave));
            this.minimiseButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.employeeidLabel = new System.Windows.Forms.Label();
            this.employeeidTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.positionLabel = new System.Windows.Forms.Label();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.dateappliedLabel = new System.Windows.Forms.Label();
            this.dateappliedTextBox = new System.Windows.Forms.TextBox();
            this.leaveComboBox = new System.Windows.Forms.ComboBox();
            this.leavetypeLabel = new System.Windows.Forms.Label();
            this.supportdocumentLabel = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.documentLabel = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.startdateLabel = new System.Windows.Forms.Label();
            this.enddateLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.submitButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.wordcountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // minimiseButton
            // 
            this.minimiseButton.BackColor = System.Drawing.Color.Gold;
            this.minimiseButton.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minimiseButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.minimiseButton.Location = new System.Drawing.Point(1815, 12);
            this.minimiseButton.Name = "minimiseButton";
            this.minimiseButton.Size = new System.Drawing.Size(73, 69);
            this.minimiseButton.TabIndex = 12;
            this.minimiseButton.Text = "-";
            this.minimiseButton.UseVisualStyleBackColor = false;
            this.minimiseButton.Click += new System.EventHandler(this.minimiseButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Tomato;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.closeButton.Location = new System.Drawing.Point(1894, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(73, 69);
            this.closeButton.TabIndex = 11;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(889, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(304, 65);
            this.titleLabel.TabIndex = 13;
            this.titleLabel.Text = "Apply Leave";
            // 
            // employeeidLabel
            // 
            this.employeeidLabel.AutoSize = true;
            this.employeeidLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.employeeidLabel.Location = new System.Drawing.Point(29, 99);
            this.employeeidLabel.Name = "employeeidLabel";
            this.employeeidLabel.Size = new System.Drawing.Size(241, 48);
            this.employeeidLabel.TabIndex = 14;
            this.employeeidLabel.Text = "Employee ID:";
            // 
            // employeeidTextBox
            // 
            this.employeeidTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.employeeidTextBox.Location = new System.Drawing.Point(265, 99);
            this.employeeidTextBox.Name = "employeeidTextBox";
            this.employeeidTextBox.ReadOnly = true;
            this.employeeidTextBox.Size = new System.Drawing.Size(205, 55);
            this.employeeidTextBox.TabIndex = 15;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(679, 103);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(129, 48);
            this.nameLabel.TabIndex = 16;
            this.nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameTextBox.Location = new System.Drawing.Point(814, 103);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(1120, 55);
            this.nameTextBox.TabIndex = 17;
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.positionLabel.Location = new System.Drawing.Point(29, 167);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(167, 48);
            this.positionLabel.TabIndex = 18;
            this.positionLabel.Text = "Position:";
            // 
            // positionTextBox
            // 
            this.positionTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.positionTextBox.Location = new System.Drawing.Point(193, 169);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.ReadOnly = true;
            this.positionTextBox.Size = new System.Drawing.Size(1085, 55);
            this.positionTextBox.TabIndex = 17;
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.departmentLabel.Location = new System.Drawing.Point(29, 237);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(234, 48);
            this.departmentLabel.TabIndex = 19;
            this.departmentLabel.Text = "Department:";
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.departmentTextBox.Location = new System.Drawing.Point(254, 237);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.ReadOnly = true;
            this.departmentTextBox.Size = new System.Drawing.Size(1085, 55);
            this.departmentTextBox.TabIndex = 20;
            // 
            // dateappliedLabel
            // 
            this.dateappliedLabel.AutoSize = true;
            this.dateappliedLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateappliedLabel.Location = new System.Drawing.Point(1462, 172);
            this.dateappliedLabel.Name = "dateappliedLabel";
            this.dateappliedLabel.Size = new System.Drawing.Size(249, 48);
            this.dateappliedLabel.TabIndex = 21;
            this.dateappliedLabel.Text = "Date Applied:";
            // 
            // dateappliedTextBox
            // 
            this.dateappliedTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateappliedTextBox.Location = new System.Drawing.Point(1717, 169);
            this.dateappliedTextBox.Name = "dateappliedTextBox";
            this.dateappliedTextBox.ReadOnly = true;
            this.dateappliedTextBox.Size = new System.Drawing.Size(217, 55);
            this.dateappliedTextBox.TabIndex = 22;
            // 
            // leaveComboBox
            // 
            this.leaveComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.leaveComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.leaveComboBox.FormattingEnabled = true;
            this.leaveComboBox.Items.AddRange(new object[] {
            "ANNUAL LEAVE",
            "MEDICAL LEAVE",
            "MATERNITY LEAVE",
            "TRAINING LEAVE",
            "OTHERS"});
            this.leaveComboBox.Location = new System.Drawing.Point(1571, 237);
            this.leaveComboBox.Name = "leaveComboBox";
            this.leaveComboBox.Size = new System.Drawing.Size(363, 56);
            this.leaveComboBox.TabIndex = 23;
            // 
            // leavetypeLabel
            // 
            this.leavetypeLabel.AutoSize = true;
            this.leavetypeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.leavetypeLabel.Location = new System.Drawing.Point(1351, 240);
            this.leavetypeLabel.Name = "leavetypeLabel";
            this.leavetypeLabel.Size = new System.Drawing.Size(214, 48);
            this.leavetypeLabel.TabIndex = 24;
            this.leavetypeLabel.Text = "Leave Type:";
            // 
            // supportdocumentLabel
            // 
            this.supportdocumentLabel.AutoSize = true;
            this.supportdocumentLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.supportdocumentLabel.Location = new System.Drawing.Point(29, 314);
            this.supportdocumentLabel.Name = "supportdocumentLabel";
            this.supportdocumentLabel.Size = new System.Drawing.Size(535, 48);
            this.supportdocumentLabel.TabIndex = 27;
            this.supportdocumentLabel.Text = "Support Document (Optional):";
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.browseButton.Image = global::EMS.Properties.Resources.browse;
            this.browseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.browseButton.Location = new System.Drawing.Point(29, 431);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(211, 89);
            this.browseButton.TabIndex = 28;
            this.browseButton.Text = "Browse";
            this.browseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // documentLabel
            // 
            this.documentLabel.AutoSize = true;
            this.documentLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.documentLabel.Location = new System.Drawing.Point(29, 368);
            this.documentLabel.Name = "documentLabel";
            this.documentLabel.Size = new System.Drawing.Size(0, 48);
            this.documentLabel.TabIndex = 29;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(29, 641);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 30;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(720, 641);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 31;
            this.monthCalendar2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            // 
            // startdateLabel
            // 
            this.startdateLabel.AutoSize = true;
            this.startdateLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startdateLabel.Location = new System.Drawing.Point(29, 584);
            this.startdateLabel.Name = "startdateLabel";
            this.startdateLabel.Size = new System.Drawing.Size(200, 48);
            this.startdateLabel.TabIndex = 32;
            this.startdateLabel.Text = "Start Date:";
            // 
            // enddateLabel
            // 
            this.enddateLabel.AutoSize = true;
            this.enddateLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enddateLabel.Location = new System.Drawing.Point(711, 584);
            this.enddateLabel.Name = "enddateLabel";
            this.enddateLabel.Size = new System.Drawing.Size(182, 48);
            this.enddateLabel.TabIndex = 33;
            this.enddateLabel.Text = "End Date:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.descriptionTextBox.Location = new System.Drawing.Point(720, 368);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(1214, 197);
            this.descriptionTextBox.TabIndex = 34;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.descriptionTextBox_TextChanged);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.descriptionLabel.Location = new System.Drawing.Point(711, 314);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(233, 48);
            this.descriptionLabel.TabIndex = 35;
            this.descriptionLabel.Text = "Description: ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submitButton.Image = global::EMS.Properties.Resources.submit;
            this.submitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.submitButton.Location = new System.Drawing.Point(1348, 668);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(217, 89);
            this.submitButton.TabIndex = 36;
            this.submitButton.Text = "Submit";
            this.submitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click_1);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetButton.Image = global::EMS.Properties.Resources.reset;
            this.resetButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resetButton.Location = new System.Drawing.Point(1348, 781);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(217, 89);
            this.resetButton.TabIndex = 37;
            this.resetButton.Text = "Reset";
            this.resetButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusLabel.Location = new System.Drawing.Point(6, 1127);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(1971, 48);
            this.statusLabel.TabIndex = 38;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wordcountLabel
            // 
            this.wordcountLabel.AutoSize = true;
            this.wordcountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wordcountLabel.Location = new System.Drawing.Point(1489, 317);
            this.wordcountLabel.Name = "wordcountLabel";
            this.wordcountLabel.Size = new System.Drawing.Size(445, 48);
            this.wordcountLabel.TabIndex = 39;
            this.wordcountLabel.Text = "100 characters remaining";
            // 
            // Leave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1979, 1203);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.enddateLabel);
            this.Controls.Add(this.startdateLabel);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.documentLabel);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.supportdocumentLabel);
            this.Controls.Add(this.leaveComboBox);
            this.Controls.Add(this.dateappliedTextBox);
            this.Controls.Add(this.dateappliedLabel);
            this.Controls.Add(this.departmentTextBox);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.employeeidTextBox);
            this.Controls.Add(this.employeeidLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.minimiseButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.leavetypeLabel);
            this.Controls.Add(this.wordcountLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Leave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apply Leave";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Leave_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Leave_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Leave_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button minimiseButton;
        private Button closeButton;
        private Label titleLabel;
        private Label employeeidLabel;
        private TextBox employeeidTextBox;
        private Label nameLabel;
        private TextBox nameTextBox;
        private Label positionLabel;
        private TextBox positionTextBox;
        private Label departmentLabel;
        private TextBox departmentTextBox;
        private Label dateappliedLabel;
        private TextBox dateappliedTextBox;
        private ComboBox leaveComboBox;
        private Label leavetypeLabel;
        private Label supportdocumentLabel;
        private Button browseButton;
        private Label documentLabel;
        private MonthCalendar monthCalendar1;
        private MonthCalendar monthCalendar2;
        private Label startdateLabel;
        private Label enddateLabel;
        private TextBox descriptionTextBox;
        private Label descriptionLabel;
        private Button submitButton;
        private Button resetButton;
        private Label statusLabel;
        private OpenFileDialog openFileDialog1;
        private Label wordcountLabel;
    }
}