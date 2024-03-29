﻿namespace EMS
{
    partial class History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            this.closeButton = new System.Windows.Forms.Button();
            this.minimiseButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.searchButton = new System.Windows.Forms.Button();
            this.selectLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.allRadioButton = new System.Windows.Forms.RadioButton();
            this.departmentRadioButton = new System.Windows.Forms.RadioButton();
            this.monthyearRadioButton = new System.Windows.Forms.RadioButton();
            this.employeenameRadioButton = new System.Windows.Forms.RadioButton();
            this.dateRadioButton = new System.Windows.Forms.RadioButton();
            this.employeeidRadioButton = new System.Windows.Forms.RadioButton();
            this.filterLabel = new System.Windows.Forms.Label();
            this.exportButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Tomato;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeButton.Location = new System.Drawing.Point(2221, 12);
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
            this.minimiseButton.Location = new System.Drawing.Point(2130, 12);
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
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(814, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(788, 65);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Employees\' Clock In / Out History";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(66, 287);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 123;
            this.dataGridView1.RowTemplate.Height = 57;
            this.dataGridView1.Size = new System.Drawing.Size(2169, 620);
            this.dataGridView1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.selectLabel);
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Controls.Add(this.allRadioButton);
            this.panel1.Controls.Add(this.departmentRadioButton);
            this.panel1.Controls.Add(this.monthyearRadioButton);
            this.panel1.Controls.Add(this.employeenameRadioButton);
            this.panel1.Controls.Add(this.dateRadioButton);
            this.panel1.Controls.Add(this.employeeidRadioButton);
            this.panel1.Controls.Add(this.filterLabel);
            this.panel1.Location = new System.Drawing.Point(66, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1704, 174);
            this.panel1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(853, 86);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(316, 61);
            this.dateTimePicker2.TabIndex = 9;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(853, 86);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(316, 61);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Image = global::EMS.Properties.Resources.search_2;
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchButton.Location = new System.Drawing.Point(1462, 72);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(211, 89);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectLabel.ForeColor = System.Drawing.Color.White;
            this.selectLabel.Location = new System.Drawing.Point(843, 22);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(0, 48);
            this.selectLabel.TabIndex = 7;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(853, 92);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(573, 55);
            this.searchTextBox.TabIndex = 5;
            // 
            // allRadioButton
            // 
            this.allRadioButton.AutoSize = true;
            this.allRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.allRadioButton.ForeColor = System.Drawing.Color.White;
            this.allRadioButton.Location = new System.Drawing.Point(569, 109);
            this.allRadioButton.Name = "allRadioButton";
            this.allRadioButton.Size = new System.Drawing.Size(242, 52);
            this.allRadioButton.TabIndex = 6;
            this.allRadioButton.TabStop = true;
            this.allRadioButton.Text = "Display All";
            this.allRadioButton.UseVisualStyleBackColor = true;
            this.allRadioButton.CheckedChanged += new System.EventHandler(this.allRadioButton_CheckedChanged);
            // 
            // departmentRadioButton
            // 
            this.departmentRadioButton.AutoSize = true;
            this.departmentRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.departmentRadioButton.ForeColor = System.Drawing.Color.White;
            this.departmentRadioButton.Location = new System.Drawing.Point(569, 51);
            this.departmentRadioButton.Name = "departmentRadioButton";
            this.departmentRadioButton.Size = new System.Drawing.Size(268, 52);
            this.departmentRadioButton.TabIndex = 5;
            this.departmentRadioButton.TabStop = true;
            this.departmentRadioButton.Text = "Department";
            this.departmentRadioButton.UseVisualStyleBackColor = true;
            this.departmentRadioButton.CheckedChanged += new System.EventHandler(this.departmentRadioButton_CheckedChanged);
            // 
            // monthyearRadioButton
            // 
            this.monthyearRadioButton.AutoSize = true;
            this.monthyearRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monthyearRadioButton.ForeColor = System.Drawing.Color.White;
            this.monthyearRadioButton.Location = new System.Drawing.Point(12, 109);
            this.monthyearRadioButton.Name = "monthyearRadioButton";
            this.monthyearRadioButton.Size = new System.Drawing.Size(265, 52);
            this.monthyearRadioButton.TabIndex = 4;
            this.monthyearRadioButton.TabStop = true;
            this.monthyearRadioButton.Text = "Month/Year";
            this.monthyearRadioButton.UseVisualStyleBackColor = true;
            this.monthyearRadioButton.CheckedChanged += new System.EventHandler(this.monthyearRadioButton_CheckedChanged);
            // 
            // employeenameRadioButton
            // 
            this.employeenameRadioButton.AutoSize = true;
            this.employeenameRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.employeenameRadioButton.ForeColor = System.Drawing.Color.White;
            this.employeenameRadioButton.Location = new System.Drawing.Point(366, 109);
            this.employeenameRadioButton.Name = "employeenameRadioButton";
            this.employeenameRadioButton.Size = new System.Drawing.Size(163, 52);
            this.employeenameRadioButton.TabIndex = 2;
            this.employeenameRadioButton.TabStop = true;
            this.employeenameRadioButton.Text = "Name";
            this.employeenameRadioButton.UseVisualStyleBackColor = true;
            this.employeenameRadioButton.CheckedChanged += new System.EventHandler(this.employeenameRadioButton_CheckedChanged);
            // 
            // dateRadioButton
            // 
            this.dateRadioButton.AutoSize = true;
            this.dateRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateRadioButton.ForeColor = System.Drawing.Color.White;
            this.dateRadioButton.Location = new System.Drawing.Point(366, 51);
            this.dateRadioButton.Name = "dateRadioButton";
            this.dateRadioButton.Size = new System.Drawing.Size(143, 52);
            this.dateRadioButton.TabIndex = 3;
            this.dateRadioButton.TabStop = true;
            this.dateRadioButton.Text = "Date";
            this.dateRadioButton.UseVisualStyleBackColor = true;
            this.dateRadioButton.CheckedChanged += new System.EventHandler(this.dateRadioButton_CheckedChanged);
            // 
            // employeeidRadioButton
            // 
            this.employeeidRadioButton.AutoSize = true;
            this.employeeidRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.employeeidRadioButton.ForeColor = System.Drawing.Color.White;
            this.employeeidRadioButton.Location = new System.Drawing.Point(12, 51);
            this.employeeidRadioButton.Name = "employeeidRadioButton";
            this.employeeidRadioButton.Size = new System.Drawing.Size(275, 52);
            this.employeeidRadioButton.TabIndex = 1;
            this.employeeidRadioButton.TabStop = true;
            this.employeeidRadioButton.Text = "Employee ID";
            this.employeeidRadioButton.UseVisualStyleBackColor = true;
            this.employeeidRadioButton.CheckedChanged += new System.EventHandler(this.employeeidRadioButton_CheckedChanged);
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.filterLabel.ForeColor = System.Drawing.Color.White;
            this.filterLabel.Location = new System.Drawing.Point(0, 0);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(414, 48);
            this.filterLabel.TabIndex = 0;
            this.filterLabel.Text = "Filter Results Based On:";
            // 
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.exportButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exportButton.ForeColor = System.Drawing.Color.White;
            this.exportButton.Image = global::EMS.Properties.Resources.export;
            this.exportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exportButton.Location = new System.Drawing.Point(1944, 182);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(291, 89);
            this.exportButton.TabIndex = 11;
            this.exportButton.Text = "Export Data";
            this.exportButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exportButton.UseVisualStyleBackColor = false;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultLabel.ForeColor = System.Drawing.Color.White;
            this.resultLabel.Location = new System.Drawing.Point(-1, 920);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(2304, 48);
            this.resultLabel.TabIndex = 10;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(2306, 1020);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.minimiseButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance History (Overall)";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.History_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.History_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.History_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button closeButton;
        private Button minimiseButton;
        private Label titleLabel;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label filterLabel;
        private RadioButton employeenameRadioButton;
        private RadioButton employeeidRadioButton;
        private DateTimePicker dateTimePicker1;
        private Label selectLabel;
        private RadioButton allRadioButton;
        private RadioButton departmentRadioButton;
        private RadioButton monthyearRadioButton;
        private RadioButton dateRadioButton;
        private Button exportButton;
        private TextBox searchTextBox;
        private Button searchButton;
        private Label resultLabel;
        private DateTimePicker dateTimePicker2;
    }
}