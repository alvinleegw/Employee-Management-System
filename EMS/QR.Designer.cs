namespace EMS
{
    partial class QR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QR));
            this.printButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.White;
            this.printButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.printButton.Image = global::EMS.Properties.Resources.print;
            this.printButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.printButton.Location = new System.Drawing.Point(247, 841);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(163, 89);
            this.printButton.TabIndex = 0;
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
            this.closeButton.Location = new System.Drawing.Point(429, 841);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(166, 89);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(52, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(543, 533);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // QR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 942);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.printButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee QR";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.QR_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.QR_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.QR_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button printButton;
        private Button closeButton;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PictureBox pictureBox1;
    }
}