namespace EMS
{
    partial class Attendance
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendance));
            this.closeButton = new System.Windows.Forms.Button();
            this.minimiseButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.selectLabel = new System.Windows.Forms.Label();
            this.cameraComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clockinButton = new System.Windows.Forms.Button();
            this.clockoutButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.stopButton = new System.Windows.Forms.Button();
            this.displayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Tomato;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeButton.Location = new System.Drawing.Point(1649, 12);
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
            this.minimiseButton.Location = new System.Drawing.Point(1560, 12);
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
            this.titleLabel.BackColor = System.Drawing.Color.DimGray;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(635, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(475, 65);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Clock In / Clock Out";
            // 
            // selectLabel
            // 
            this.selectLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectLabel.ForeColor = System.Drawing.Color.White;
            this.selectLabel.Image = global::EMS.Properties.Resources.camera;
            this.selectLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectLabel.Location = new System.Drawing.Point(12, 119);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(385, 48);
            this.selectLabel.TabIndex = 3;
            this.selectLabel.Text = "Camera Available:";
            this.selectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cameraComboBox
            // 
            this.cameraComboBox.BackColor = System.Drawing.Color.White;
            this.cameraComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cameraComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cameraComboBox.FormattingEnabled = true;
            this.cameraComboBox.Location = new System.Drawing.Point(403, 116);
            this.cameraComboBox.Name = "cameraComboBox";
            this.cameraComboBox.Size = new System.Drawing.Size(503, 56);
            this.cameraComboBox.Sorted = true;
            this.cameraComboBox.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(232, 209);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1279, 522);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // clockinButton
            // 
            this.clockinButton.BackColor = System.Drawing.Color.Purple;
            this.clockinButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clockinButton.ForeColor = System.Drawing.Color.White;
            this.clockinButton.Image = global::EMS.Properties.Resources.clock_in_2;
            this.clockinButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clockinButton.Location = new System.Drawing.Point(922, 99);
            this.clockinButton.Name = "clockinButton";
            this.clockinButton.Size = new System.Drawing.Size(225, 89);
            this.clockinButton.TabIndex = 6;
            this.clockinButton.Text = "Clock In";
            this.clockinButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clockinButton.UseVisualStyleBackColor = false;
            this.clockinButton.Click += new System.EventHandler(this.clockinButton_Click);
            // 
            // clockoutButton
            // 
            this.clockoutButton.BackColor = System.Drawing.Color.MediumPurple;
            this.clockoutButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clockoutButton.ForeColor = System.Drawing.Color.White;
            this.clockoutButton.Image = global::EMS.Properties.Resources.clock_in_2;
            this.clockoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clockoutButton.Location = new System.Drawing.Point(1153, 99);
            this.clockoutButton.Name = "clockoutButton";
            this.clockoutButton.Size = new System.Drawing.Size(257, 89);
            this.clockoutButton.TabIndex = 7;
            this.clockoutButton.Text = "Clock Out";
            this.clockoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clockoutButton.UseVisualStyleBackColor = false;
            this.clockoutButton.Click += new System.EventHandler(this.clockoutButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusLabel.ForeColor = System.Drawing.Color.SpringGreen;
            this.statusLabel.Location = new System.Drawing.Point(0, 734);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(1722, 48);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.Firebrick;
            this.stopButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stopButton.ForeColor = System.Drawing.Color.White;
            this.stopButton.Image = global::EMS.Properties.Resources.stop;
            this.stopButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.stopButton.Location = new System.Drawing.Point(1416, 99);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(309, 89);
            this.stopButton.TabIndex = 9;
            this.stopButton.Text = "Stop Camera";
            this.stopButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // displayLabel
            // 
            this.displayLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.displayLabel.ForeColor = System.Drawing.Color.SpringGreen;
            this.displayLabel.Location = new System.Drawing.Point(0, 797);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(1722, 48);
            this.displayLabel.TabIndex = 10;
            this.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1742, 924);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.clockoutButton);
            this.Controls.Add(this.clockinButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cameraComboBox);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.minimiseButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Attendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Attendance_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Attendance_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Attendance_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button closeButton;
        private Button minimiseButton;
        private Label titleLabel;
        private Label selectLabel;
        private ComboBox cameraComboBox;
        private PictureBox pictureBox1;
        private Button clockinButton;
        private Button clockoutButton;
        private Label statusLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Button stopButton;
        private Label displayLabel;
    }
}