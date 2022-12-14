namespace EMS
{
    partial class Badge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Badge));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.employeeidLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.positionLabel = new System.Windows.Forms.Label();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(171, 237);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 383);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // employeeidLabel
            // 
            this.employeeidLabel.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.employeeidLabel.Location = new System.Drawing.Point(2, 644);
            this.employeeidLabel.Name = "employeeidLabel";
            this.employeeidLabel.Size = new System.Drawing.Size(633, 33);
            this.employeeidLabel.TabIndex = 1;
            this.employeeidLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(2, 693);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(633, 33);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // positionLabel
            // 
            this.positionLabel.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.positionLabel.Location = new System.Drawing.Point(2, 745);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(633, 33);
            this.positionLabel.TabIndex = 3;
            this.positionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // departmentLabel
            // 
            this.departmentLabel.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.departmentLabel.Location = new System.Drawing.Point(2, 794);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(633, 33);
            this.departmentLabel.TabIndex = 4;
            this.departmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.White;
            this.printButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.printButton.Image = global::EMS.Properties.Resources.print;
            this.printButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.printButton.Location = new System.Drawing.Point(271, 830);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(169, 89);
            this.printButton.TabIndex = 5;
            this.printButton.Text = "Print";
            this.printButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.White;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeButton.Image = global::EMS.Properties.Resources.close;
            this.closeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeButton.Location = new System.Drawing.Point(457, 830);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(170, 89);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "Close";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EMS.Properties.Resources.company_logo;
            this.pictureBox2.Location = new System.Drawing.Point(261, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(2, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(633, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "Alpha Sigma Company";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Badge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(639, 942);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.employeeidLabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Badge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Badge";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Badge_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Badge_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Badge_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Label employeeidLabel;
        private Label nameLabel;
        private Label positionLabel;
        private Label departmentLabel;
        private Button printButton;
        private Button closeButton;
        private PrintDialog printDialog1;
        private OpenFileDialog openFileDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PictureBox pictureBox2;
        private Label label1;
    }
}