namespace EMS
{
    partial class AdminPayroll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPayroll));
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusLabel = new System.Windows.Forms.Label();
            this.filterLabel = new System.Windows.Forms.Label();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.monthyearRadioButton = new System.Windows.Forms.RadioButton();
            this.allRadioButton = new System.Windows.Forms.RadioButton();
            this.departmentRadioButton = new System.Windows.Forms.RadioButton();
            this.searchLabel = new System.Windows.Forms.Label();
            this.nameRadioButton = new System.Windows.Forms.RadioButton();
            this.employeeidRadioButton = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Gold;
            this.minimizeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minimizeButton.Location = new System.Drawing.Point(1518, 6);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(78, 69);
            this.minimizeButton.TabIndex = 8;
            this.minimizeButton.Text = "-";
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Tomato;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeButton.Location = new System.Drawing.Point(1602, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(78, 69);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(692, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 65);
            this.label1.TabIndex = 9;
            this.label1.Text = "Employee Payroll";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(74, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 123;
            this.dataGridView1.RowTemplate.Height = 57;
            this.dataGridView1.Size = new System.Drawing.Size(1549, 606);
            this.dataGridView1.TabIndex = 10;
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Location = new System.Drawing.Point(74, 897);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(1549, 65);
            this.statusLabel.TabIndex = 11;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.filterLabel.ForeColor = System.Drawing.Color.White;
            this.filterLabel.Location = new System.Drawing.Point(962, 87);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(472, 54);
            this.filterLabel.TabIndex = 35;
            this.filterLabel.Text = "Enter Information Here:";
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(971, 151);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(463, 55);
            this.filterTextBox.TabIndex = 32;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Blue;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Image = global::EMS.Properties.Resources.search;
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchButton.Location = new System.Drawing.Point(1465, 133);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(215, 89);
            this.searchButton.TabIndex = 34;
            this.searchButton.TabStop = false;
            this.searchButton.Text = "Search";
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.monthyearRadioButton);
            this.panel1.Controls.Add(this.allRadioButton);
            this.panel1.Controls.Add(this.departmentRadioButton);
            this.panel1.Controls.Add(this.searchLabel);
            this.panel1.Controls.Add(this.nameRadioButton);
            this.panel1.Controls.Add(this.employeeidRadioButton);
            this.panel1.Location = new System.Drawing.Point(44, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 166);
            this.panel1.TabIndex = 33;
            // 
            // monthyearRadioButton
            // 
            this.monthyearRadioButton.AutoSize = true;
            this.monthyearRadioButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monthyearRadioButton.ForeColor = System.Drawing.Color.White;
            this.monthyearRadioButton.Location = new System.Drawing.Point(315, 109);
            this.monthyearRadioButton.Name = "monthyearRadioButton";
            this.monthyearRadioButton.Size = new System.Drawing.Size(291, 58);
            this.monthyearRadioButton.TabIndex = 31;
            this.monthyearRadioButton.TabStop = true;
            this.monthyearRadioButton.Text = "Month/Year";
            this.monthyearRadioButton.UseVisualStyleBackColor = true;
            this.monthyearRadioButton.CheckedChanged += new System.EventHandler(this.monthyearRadioButton_CheckedChanged);
            // 
            // allRadioButton
            // 
            this.allRadioButton.AutoSize = true;
            this.allRadioButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.allRadioButton.ForeColor = System.Drawing.Color.White;
            this.allRadioButton.Location = new System.Drawing.Point(619, 56);
            this.allRadioButton.Name = "allRadioButton";
            this.allRadioButton.Size = new System.Drawing.Size(267, 58);
            this.allRadioButton.TabIndex = 30;
            this.allRadioButton.TabStop = true;
            this.allRadioButton.Text = "Display All";
            this.allRadioButton.UseVisualStyleBackColor = true;
            this.allRadioButton.CheckedChanged += new System.EventHandler(this.allRadioButton_CheckedChanged);
            // 
            // departmentRadioButton
            // 
            this.departmentRadioButton.AutoSize = true;
            this.departmentRadioButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.departmentRadioButton.ForeColor = System.Drawing.Color.White;
            this.departmentRadioButton.Location = new System.Drawing.Point(315, 55);
            this.departmentRadioButton.Name = "departmentRadioButton";
            this.departmentRadioButton.Size = new System.Drawing.Size(298, 58);
            this.departmentRadioButton.TabIndex = 29;
            this.departmentRadioButton.TabStop = true;
            this.departmentRadioButton.Text = "Department";
            this.departmentRadioButton.UseVisualStyleBackColor = true;
            this.departmentRadioButton.CheckedChanged += new System.EventHandler(this.departmentRadioButton_CheckedChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchLabel.ForeColor = System.Drawing.Color.White;
            this.searchLabel.Location = new System.Drawing.Point(6, -2);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(376, 54);
            this.searchLabel.TabIndex = 27;
            this.searchLabel.Text = "Search or Filter by:";
            // 
            // nameRadioButton
            // 
            this.nameRadioButton.AutoSize = true;
            this.nameRadioButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameRadioButton.ForeColor = System.Drawing.Color.White;
            this.nameRadioButton.Location = new System.Drawing.Point(14, 109);
            this.nameRadioButton.Name = "nameRadioButton";
            this.nameRadioButton.Size = new System.Drawing.Size(180, 58);
            this.nameRadioButton.TabIndex = 26;
            this.nameRadioButton.TabStop = true;
            this.nameRadioButton.Text = "Name";
            this.nameRadioButton.UseVisualStyleBackColor = true;
            this.nameRadioButton.CheckedChanged += new System.EventHandler(this.nameRadioButton_CheckedChanged);
            // 
            // employeeidRadioButton
            // 
            this.employeeidRadioButton.AutoSize = true;
            this.employeeidRadioButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.employeeidRadioButton.ForeColor = System.Drawing.Color.White;
            this.employeeidRadioButton.Location = new System.Drawing.Point(14, 55);
            this.employeeidRadioButton.Name = "employeeidRadioButton";
            this.employeeidRadioButton.Size = new System.Drawing.Size(305, 58);
            this.employeeidRadioButton.TabIndex = 25;
            this.employeeidRadioButton.TabStop = true;
            this.employeeidRadioButton.Text = "Employee ID";
            this.employeeidRadioButton.UseVisualStyleBackColor = true;
            this.employeeidRadioButton.CheckedChanged += new System.EventHandler(this.employeeidRadioButton_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(970, 153);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(295, 55);
            this.dateTimePicker1.TabIndex = 36;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // AdminPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1700, 1061);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPayroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll (Admin)";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminPayroll_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AdminPayroll_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AdminPayroll_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button minimizeButton;
        private Button closeButton;
        private Label label1;
        private DataGridView dataGridView1;
        private Label statusLabel;
        private Label filterLabel;
        private TextBox filterTextBox;
        private Button searchButton;
        private Panel panel1;
        private RadioButton monthyearRadioButton;
        private RadioButton allRadioButton;
        private RadioButton departmentRadioButton;
        private Label searchLabel;
        private RadioButton nameRadioButton;
        private RadioButton employeeidRadioButton;
        private DateTimePicker dateTimePicker1;
    }
}