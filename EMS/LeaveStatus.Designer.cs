namespace EMS
{
    partial class LeaveStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaveStatus));
            this.minimiseButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.remarksLabel = new System.Windows.Forms.Label();
            this.remarksTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.dateapproverejectTextBox = new System.Windows.Forms.TextBox();
            this.dateapprovedrejectLabel = new System.Windows.Forms.Label();
            this.enddateTextBox = new System.Windows.Forms.TextBox();
            this.startdateTextBox = new System.Windows.Forms.TextBox();
            this.downloadButton = new System.Windows.Forms.Button();
            this.dateappliedTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.enddateLabel = new System.Windows.Forms.Label();
            this.startdateLabel = new System.Windows.Forms.Label();
            this.supportdocumentLabel = new System.Windows.Forms.Label();
            this.dateappliedLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.documentnameLabel = new System.Windows.Forms.Label();
            this.status2Label = new System.Windows.Forms.Label();
            this.leavetypeTextBox = new System.Windows.Forms.TextBox();
            this.leavetypeLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // minimiseButton
            // 
            this.minimiseButton.BackColor = System.Drawing.Color.Gold;
            this.minimiseButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minimiseButton.Location = new System.Drawing.Point(2656, 12);
            this.minimiseButton.Name = "minimiseButton";
            this.minimiseButton.Size = new System.Drawing.Size(73, 69);
            this.minimiseButton.TabIndex = 3;
            this.minimiseButton.Text = "-";
            this.minimiseButton.UseVisualStyleBackColor = false;
            this.minimiseButton.Click += new System.EventHandler(this.minimiseButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Tomato;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeButton.Location = new System.Drawing.Point(2735, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(73, 69);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(1253, 16);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(310, 65);
            this.titleLabel.TabIndex = 10;
            this.titleLabel.Text = "Leave Status";
            // 
            // remarksLabel
            // 
            this.remarksLabel.AutoSize = true;
            this.remarksLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.remarksLabel.ForeColor = System.Drawing.Color.White;
            this.remarksLabel.Location = new System.Drawing.Point(18, 882);
            this.remarksLabel.Name = "remarksLabel";
            this.remarksLabel.Size = new System.Drawing.Size(174, 48);
            this.remarksLabel.TabIndex = 79;
            this.remarksLabel.Text = "Remarks:";
            // 
            // remarksTextBox
            // 
            this.remarksTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.remarksTextBox.Location = new System.Drawing.Point(24, 945);
            this.remarksTextBox.Multiline = true;
            this.remarksTextBox.Name = "remarksTextBox";
            this.remarksTextBox.ReadOnly = true;
            this.remarksTextBox.Size = new System.Drawing.Size(1352, 197);
            this.remarksTextBox.TabIndex = 78;
            // 
            // statusTextBox
            // 
            this.statusTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusTextBox.Location = new System.Drawing.Point(171, 105);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(262, 55);
            this.statusTextBox.TabIndex = 77;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Location = new System.Drawing.Point(23, 105);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(134, 48);
            this.statusLabel.TabIndex = 76;
            this.statusLabel.Text = "Status:";
            // 
            // dateapproverejectTextBox
            // 
            this.dateapproverejectTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateapproverejectTextBox.Location = new System.Drawing.Point(473, 507);
            this.dateapproverejectTextBox.Name = "dateapproverejectTextBox";
            this.dateapproverejectTextBox.ReadOnly = true;
            this.dateapproverejectTextBox.Size = new System.Drawing.Size(224, 55);
            this.dateapproverejectTextBox.TabIndex = 75;
            // 
            // dateapprovedrejectLabel
            // 
            this.dateapprovedrejectLabel.AutoSize = true;
            this.dateapprovedrejectLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateapprovedrejectLabel.ForeColor = System.Drawing.Color.White;
            this.dateapprovedrejectLabel.Location = new System.Drawing.Point(23, 507);
            this.dateapprovedrejectLabel.Name = "dateapprovedrejectLabel";
            this.dateapprovedrejectLabel.Size = new System.Drawing.Size(444, 48);
            this.dateapprovedrejectLabel.TabIndex = 74;
            this.dateapprovedrejectLabel.Text = "Date Approved/Rejected:";
            // 
            // enddateTextBox
            // 
            this.enddateTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enddateTextBox.Location = new System.Drawing.Point(655, 393);
            this.enddateTextBox.Name = "enddateTextBox";
            this.enddateTextBox.ReadOnly = true;
            this.enddateTextBox.Size = new System.Drawing.Size(224, 55);
            this.enddateTextBox.TabIndex = 73;
            // 
            // startdateTextBox
            // 
            this.startdateTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startdateTextBox.Location = new System.Drawing.Point(221, 400);
            this.startdateTextBox.Name = "startdateTextBox";
            this.startdateTextBox.ReadOnly = true;
            this.startdateTextBox.Size = new System.Drawing.Size(224, 55);
            this.startdateTextBox.TabIndex = 72;
            // 
            // downloadButton
            // 
            this.downloadButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.downloadButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.downloadButton.ForeColor = System.Drawing.Color.White;
            this.downloadButton.Image = global::EMS.Properties.Resources.download_2;
            this.downloadButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.downloadButton.Location = new System.Drawing.Point(973, 264);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(260, 89);
            this.downloadButton.TabIndex = 71;
            this.downloadButton.Text = "Download";
            this.downloadButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.downloadButton.UseVisualStyleBackColor = false;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // dateappliedTextBox
            // 
            this.dateappliedTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateappliedTextBox.Location = new System.Drawing.Point(1016, 98);
            this.dateappliedTextBox.Name = "dateappliedTextBox";
            this.dateappliedTextBox.ReadOnly = true;
            this.dateappliedTextBox.Size = new System.Drawing.Size(224, 55);
            this.dateappliedTextBox.TabIndex = 70;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.descriptionLabel.ForeColor = System.Drawing.Color.White;
            this.descriptionLabel.Location = new System.Drawing.Point(19, 587);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(233, 48);
            this.descriptionLabel.TabIndex = 69;
            this.descriptionLabel.Text = "Description: ";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.descriptionTextBox.Location = new System.Drawing.Point(25, 650);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(1352, 197);
            this.descriptionTextBox.TabIndex = 68;
            // 
            // enddateLabel
            // 
            this.enddateLabel.AutoSize = true;
            this.enddateLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enddateLabel.ForeColor = System.Drawing.Color.White;
            this.enddateLabel.Location = new System.Drawing.Point(467, 400);
            this.enddateLabel.Name = "enddateLabel";
            this.enddateLabel.Size = new System.Drawing.Size(182, 48);
            this.enddateLabel.TabIndex = 67;
            this.enddateLabel.Text = "End Date:";
            // 
            // startdateLabel
            // 
            this.startdateLabel.AutoSize = true;
            this.startdateLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startdateLabel.ForeColor = System.Drawing.Color.White;
            this.startdateLabel.Location = new System.Drawing.Point(23, 400);
            this.startdateLabel.Name = "startdateLabel";
            this.startdateLabel.Size = new System.Drawing.Size(200, 48);
            this.startdateLabel.TabIndex = 66;
            this.startdateLabel.Text = "Start Date:";
            // 
            // supportdocumentLabel
            // 
            this.supportdocumentLabel.AutoSize = true;
            this.supportdocumentLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.supportdocumentLabel.ForeColor = System.Drawing.Color.White;
            this.supportdocumentLabel.Location = new System.Drawing.Point(25, 284);
            this.supportdocumentLabel.Name = "supportdocumentLabel";
            this.supportdocumentLabel.Size = new System.Drawing.Size(206, 48);
            this.supportdocumentLabel.TabIndex = 65;
            this.supportdocumentLabel.Text = "Document:";
            // 
            // dateappliedLabel
            // 
            this.dateappliedLabel.AutoSize = true;
            this.dateappliedLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateappliedLabel.ForeColor = System.Drawing.Color.White;
            this.dateappliedLabel.Location = new System.Drawing.Point(761, 101);
            this.dateappliedLabel.Name = "dateappliedLabel";
            this.dateappliedLabel.Size = new System.Drawing.Size(249, 48);
            this.dateappliedLabel.TabIndex = 64;
            this.dateappliedLabel.Text = "Date Applied:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1431, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 123;
            this.dataGridView1.RowTemplate.Height = 57;
            this.dataGridView1.Size = new System.Drawing.Size(1352, 1041);
            this.dataGridView1.TabIndex = 63;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // documentnameLabel
            // 
            this.documentnameLabel.AutoSize = true;
            this.documentnameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.documentnameLabel.ForeColor = System.Drawing.Color.White;
            this.documentnameLabel.Location = new System.Drawing.Point(226, 284);
            this.documentnameLabel.Name = "documentnameLabel";
            this.documentnameLabel.Size = new System.Drawing.Size(0, 48);
            this.documentnameLabel.TabIndex = 80;
            // 
            // status2Label
            // 
            this.status2Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.status2Label.ForeColor = System.Drawing.Color.White;
            this.status2Label.Location = new System.Drawing.Point(1431, 1145);
            this.status2Label.Name = "status2Label";
            this.status2Label.Size = new System.Drawing.Size(1352, 48);
            this.status2Label.TabIndex = 81;
            this.status2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leavetypeTextBox
            // 
            this.leavetypeTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.leavetypeTextBox.Location = new System.Drawing.Point(237, 182);
            this.leavetypeTextBox.Name = "leavetypeTextBox";
            this.leavetypeTextBox.ReadOnly = true;
            this.leavetypeTextBox.Size = new System.Drawing.Size(1003, 55);
            this.leavetypeTextBox.TabIndex = 83;
            // 
            // leavetypeLabel
            // 
            this.leavetypeLabel.AutoSize = true;
            this.leavetypeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.leavetypeLabel.ForeColor = System.Drawing.Color.White;
            this.leavetypeLabel.Location = new System.Drawing.Point(25, 185);
            this.leavetypeLabel.Name = "leavetypeLabel";
            this.leavetypeLabel.Size = new System.Drawing.Size(214, 48);
            this.leavetypeLabel.TabIndex = 82;
            this.leavetypeLabel.Text = "Leave Type:";
            // 
            // LeaveStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(2820, 1250);
            this.Controls.Add(this.leavetypeTextBox);
            this.Controls.Add(this.leavetypeLabel);
            this.Controls.Add(this.status2Label);
            this.Controls.Add(this.documentnameLabel);
            this.Controls.Add(this.remarksLabel);
            this.Controls.Add(this.remarksTextBox);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.dateapproverejectTextBox);
            this.Controls.Add(this.dateapprovedrejectLabel);
            this.Controls.Add(this.enddateTextBox);
            this.Controls.Add(this.startdateTextBox);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.dateappliedTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.enddateLabel);
            this.Controls.Add(this.startdateLabel);
            this.Controls.Add(this.supportdocumentLabel);
            this.Controls.Add(this.dateappliedLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.minimiseButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LeaveStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leave Status";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeaveStatus_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeaveStatus_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeaveStatus_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button minimiseButton;
        private Button closeButton;
        private Label titleLabel;
        private Label remarksLabel;
        private TextBox remarksTextBox;
        private TextBox statusTextBox;
        private Label statusLabel;
        private TextBox dateapproverejectTextBox;
        private Label dateapprovedrejectLabel;
        private TextBox enddateTextBox;
        private TextBox startdateTextBox;
        private Button downloadButton;
        private TextBox dateappliedTextBox;
        private Label descriptionLabel;
        private TextBox descriptionTextBox;
        private Label enddateLabel;
        private Label startdateLabel;
        private Label supportdocumentLabel;
        private Label dateappliedLabel;
        private DataGridView dataGridView1;
        private Label documentnameLabel;
        private Label status2Label;
        private TextBox leavetypeTextBox;
        private Label leavetypeLabel;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}