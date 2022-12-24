namespace EMS
{
    partial class AdminLeave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLeave));
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.enddateLabel = new System.Windows.Forms.Label();
            this.startdateLabel = new System.Windows.Forms.Label();
            this.supportdocumentLabel = new System.Windows.Forms.Label();
            this.dateappliedLabel = new System.Windows.Forms.Label();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.positionLabel = new System.Windows.Forms.Label();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.employeeidTextBox = new System.Windows.Forms.TextBox();
            this.employeeidLabel = new System.Windows.Forms.Label();
            this.leavetypeLabel = new System.Windows.Forms.Label();
            this.dateappliedTextBox = new System.Windows.Forms.TextBox();
            this.leavetypeTextBox = new System.Windows.Forms.TextBox();
            this.documentnameLabel = new System.Windows.Forms.Label();
            this.downloadButton = new System.Windows.Forms.Button();
            this.startdateTextBox = new System.Windows.Forms.TextBox();
            this.enddateTextBox = new System.Windows.Forms.TextBox();
            this.dateapproverejectTextBox = new System.Windows.Forms.TextBox();
            this.dateapprovedrejectLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.remarksLabel = new System.Windows.Forms.Label();
            this.remarksTextBox = new System.Windows.Forms.TextBox();
            this.approveButton = new System.Windows.Forms.Button();
            this.rejectButton = new System.Windows.Forms.Button();
            this.status2Label = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Gold;
            this.minimizeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minimizeButton.Location = new System.Drawing.Point(2629, 15);
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
            this.closeButton.Location = new System.Drawing.Point(2713, 14);
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
            this.label1.Location = new System.Drawing.Point(1259, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 65);
            this.label1.TabIndex = 9;
            this.label1.Text = "Manage Leave";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1439, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 123;
            this.dataGridView1.RowTemplate.Height = 57;
            this.dataGridView1.Size = new System.Drawing.Size(1352, 978);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.descriptionLabel.ForeColor = System.Drawing.Color.White;
            this.descriptionLabel.Location = new System.Drawing.Point(20, 691);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(233, 48);
            this.descriptionLabel.TabIndex = 50;
            this.descriptionLabel.Text = "Description: ";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.descriptionTextBox.Location = new System.Drawing.Point(26, 754);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(1352, 197);
            this.descriptionTextBox.TabIndex = 49;
            // 
            // enddateLabel
            // 
            this.enddateLabel.AutoSize = true;
            this.enddateLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enddateLabel.ForeColor = System.Drawing.Color.White;
            this.enddateLabel.Location = new System.Drawing.Point(460, 540);
            this.enddateLabel.Name = "enddateLabel";
            this.enddateLabel.Size = new System.Drawing.Size(182, 48);
            this.enddateLabel.TabIndex = 48;
            this.enddateLabel.Text = "End Date:";
            // 
            // startdateLabel
            // 
            this.startdateLabel.AutoSize = true;
            this.startdateLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startdateLabel.ForeColor = System.Drawing.Color.White;
            this.startdateLabel.Location = new System.Drawing.Point(16, 540);
            this.startdateLabel.Name = "startdateLabel";
            this.startdateLabel.Size = new System.Drawing.Size(200, 48);
            this.startdateLabel.TabIndex = 47;
            this.startdateLabel.Text = "Start Date:";
            // 
            // supportdocumentLabel
            // 
            this.supportdocumentLabel.AutoSize = true;
            this.supportdocumentLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.supportdocumentLabel.ForeColor = System.Drawing.Color.White;
            this.supportdocumentLabel.Location = new System.Drawing.Point(54, 456);
            this.supportdocumentLabel.Name = "supportdocumentLabel";
            this.supportdocumentLabel.Size = new System.Drawing.Size(206, 48);
            this.supportdocumentLabel.TabIndex = 46;
            this.supportdocumentLabel.Text = "Document:";
            // 
            // dateappliedLabel
            // 
            this.dateappliedLabel.AutoSize = true;
            this.dateappliedLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateappliedLabel.ForeColor = System.Drawing.Color.White;
            this.dateappliedLabel.Location = new System.Drawing.Point(890, 96);
            this.dateappliedLabel.Name = "dateappliedLabel";
            this.dateappliedLabel.Size = new System.Drawing.Size(249, 48);
            this.dateappliedLabel.TabIndex = 44;
            this.dateappliedLabel.Text = "Date Applied:";
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.departmentTextBox.Location = new System.Drawing.Point(258, 294);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.ReadOnly = true;
            this.departmentTextBox.Size = new System.Drawing.Size(1120, 55);
            this.departmentTextBox.TabIndex = 43;
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.departmentLabel.ForeColor = System.Drawing.Color.White;
            this.departmentLabel.Location = new System.Drawing.Point(26, 294);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(234, 48);
            this.departmentLabel.TabIndex = 42;
            this.departmentLabel.Text = "Department:";
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.positionLabel.ForeColor = System.Drawing.Color.White;
            this.positionLabel.Location = new System.Drawing.Point(85, 226);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(167, 48);
            this.positionLabel.TabIndex = 41;
            this.positionLabel.Text = "Position:";
            // 
            // positionTextBox
            // 
            this.positionTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.positionTextBox.Location = new System.Drawing.Point(258, 226);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.ReadOnly = true;
            this.positionTextBox.Size = new System.Drawing.Size(1120, 55);
            this.positionTextBox.TabIndex = 39;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameTextBox.Location = new System.Drawing.Point(258, 158);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(1120, 55);
            this.nameTextBox.TabIndex = 40;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(123, 165);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(129, 48);
            this.nameLabel.TabIndex = 38;
            this.nameLabel.Text = "Name:";
            // 
            // employeeidTextBox
            // 
            this.employeeidTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.employeeidTextBox.Location = new System.Drawing.Point(259, 89);
            this.employeeidTextBox.Name = "employeeidTextBox";
            this.employeeidTextBox.ReadOnly = true;
            this.employeeidTextBox.Size = new System.Drawing.Size(205, 55);
            this.employeeidTextBox.TabIndex = 37;
            // 
            // employeeidLabel
            // 
            this.employeeidLabel.AutoSize = true;
            this.employeeidLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.employeeidLabel.ForeColor = System.Drawing.Color.White;
            this.employeeidLabel.Location = new System.Drawing.Point(12, 89);
            this.employeeidLabel.Name = "employeeidLabel";
            this.employeeidLabel.Size = new System.Drawing.Size(241, 48);
            this.employeeidLabel.TabIndex = 36;
            this.employeeidLabel.Text = "Employee ID:";
            // 
            // leavetypeLabel
            // 
            this.leavetypeLabel.AutoSize = true;
            this.leavetypeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.leavetypeLabel.ForeColor = System.Drawing.Color.White;
            this.leavetypeLabel.Location = new System.Drawing.Point(46, 364);
            this.leavetypeLabel.Name = "leavetypeLabel";
            this.leavetypeLabel.Size = new System.Drawing.Size(214, 48);
            this.leavetypeLabel.TabIndex = 45;
            this.leavetypeLabel.Text = "Leave Type:";
            // 
            // dateappliedTextBox
            // 
            this.dateappliedTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateappliedTextBox.Location = new System.Drawing.Point(1154, 89);
            this.dateappliedTextBox.Name = "dateappliedTextBox";
            this.dateappliedTextBox.ReadOnly = true;
            this.dateappliedTextBox.Size = new System.Drawing.Size(224, 55);
            this.dateappliedTextBox.TabIndex = 51;
            // 
            // leavetypeTextBox
            // 
            this.leavetypeTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.leavetypeTextBox.Location = new System.Drawing.Point(258, 361);
            this.leavetypeTextBox.Name = "leavetypeTextBox";
            this.leavetypeTextBox.ReadOnly = true;
            this.leavetypeTextBox.Size = new System.Drawing.Size(1121, 55);
            this.leavetypeTextBox.TabIndex = 52;
            // 
            // documentnameLabel
            // 
            this.documentnameLabel.AutoSize = true;
            this.documentnameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.documentnameLabel.ForeColor = System.Drawing.Color.White;
            this.documentnameLabel.Location = new System.Drawing.Point(258, 456);
            this.documentnameLabel.Name = "documentnameLabel";
            this.documentnameLabel.Size = new System.Drawing.Size(0, 48);
            this.documentnameLabel.TabIndex = 53;
            // 
            // downloadButton
            // 
            this.downloadButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.downloadButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.downloadButton.ForeColor = System.Drawing.Color.MediumBlue;
            this.downloadButton.Image = global::EMS.Properties.Resources.download;
            this.downloadButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.downloadButton.Location = new System.Drawing.Point(1004, 436);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(266, 89);
            this.downloadButton.TabIndex = 54;
            this.downloadButton.Text = "Download";
            this.downloadButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.downloadButton.UseVisualStyleBackColor = false;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // startdateTextBox
            // 
            this.startdateTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startdateTextBox.Location = new System.Drawing.Point(214, 540);
            this.startdateTextBox.Name = "startdateTextBox";
            this.startdateTextBox.ReadOnly = true;
            this.startdateTextBox.Size = new System.Drawing.Size(224, 55);
            this.startdateTextBox.TabIndex = 55;
            // 
            // enddateTextBox
            // 
            this.enddateTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enddateTextBox.Location = new System.Drawing.Point(648, 533);
            this.enddateTextBox.Name = "enddateTextBox";
            this.enddateTextBox.ReadOnly = true;
            this.enddateTextBox.Size = new System.Drawing.Size(224, 55);
            this.enddateTextBox.TabIndex = 56;
            // 
            // dateapproverejectTextBox
            // 
            this.dateapproverejectTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateapproverejectTextBox.Location = new System.Drawing.Point(460, 614);
            this.dateapproverejectTextBox.Name = "dateapproverejectTextBox";
            this.dateapproverejectTextBox.ReadOnly = true;
            this.dateapproverejectTextBox.Size = new System.Drawing.Size(224, 55);
            this.dateapproverejectTextBox.TabIndex = 58;
            // 
            // dateapprovedrejectLabel
            // 
            this.dateapprovedrejectLabel.AutoSize = true;
            this.dateapprovedrejectLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateapprovedrejectLabel.ForeColor = System.Drawing.Color.White;
            this.dateapprovedrejectLabel.Location = new System.Drawing.Point(20, 614);
            this.dateapprovedrejectLabel.Name = "dateapprovedrejectLabel";
            this.dateapprovedrejectLabel.Size = new System.Drawing.Size(444, 48);
            this.dateapprovedrejectLabel.TabIndex = 57;
            this.dateapprovedrejectLabel.Text = "Date Approved/Rejected:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Location = new System.Drawing.Point(470, 93);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(134, 48);
            this.statusLabel.TabIndex = 59;
            this.statusLabel.Text = "Status:";
            // 
            // statusTextBox
            // 
            this.statusTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusTextBox.Location = new System.Drawing.Point(610, 93);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(262, 55);
            this.statusTextBox.TabIndex = 60;
            // 
            // remarksLabel
            // 
            this.remarksLabel.AutoSize = true;
            this.remarksLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.remarksLabel.ForeColor = System.Drawing.Color.White;
            this.remarksLabel.Location = new System.Drawing.Point(21, 967);
            this.remarksLabel.Name = "remarksLabel";
            this.remarksLabel.Size = new System.Drawing.Size(174, 48);
            this.remarksLabel.TabIndex = 62;
            this.remarksLabel.Text = "Remarks:";
            // 
            // remarksTextBox
            // 
            this.remarksTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.remarksTextBox.Location = new System.Drawing.Point(27, 1030);
            this.remarksTextBox.Multiline = true;
            this.remarksTextBox.Name = "remarksTextBox";
            this.remarksTextBox.Size = new System.Drawing.Size(1352, 197);
            this.remarksTextBox.TabIndex = 61;
            // 
            // approveButton
            // 
            this.approveButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.approveButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.approveButton.ForeColor = System.Drawing.Color.MediumBlue;
            this.approveButton.Image = global::EMS.Properties.Resources.approve;
            this.approveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.approveButton.Location = new System.Drawing.Point(914, 1278);
            this.approveButton.Name = "approveButton";
            this.approveButton.Size = new System.Drawing.Size(225, 89);
            this.approveButton.TabIndex = 63;
            this.approveButton.Text = "Approve";
            this.approveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.approveButton.UseVisualStyleBackColor = false;
            this.approveButton.Click += new System.EventHandler(this.approveButton_Click);
            // 
            // rejectButton
            // 
            this.rejectButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.rejectButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rejectButton.ForeColor = System.Drawing.Color.MediumBlue;
            this.rejectButton.Image = global::EMS.Properties.Resources.reject;
            this.rejectButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rejectButton.Location = new System.Drawing.Point(1178, 1278);
            this.rejectButton.Name = "rejectButton";
            this.rejectButton.Size = new System.Drawing.Size(200, 89);
            this.rejectButton.TabIndex = 64;
            this.rejectButton.Text = "Reject";
            this.rejectButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rejectButton.UseVisualStyleBackColor = false;
            this.rejectButton.Click += new System.EventHandler(this.rejectButton_Click);
            // 
            // status2Label
            // 
            this.status2Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.status2Label.ForeColor = System.Drawing.Color.White;
            this.status2Label.Location = new System.Drawing.Point(1439, 1249);
            this.status2Label.Name = "status2Label";
            this.status2Label.Size = new System.Drawing.Size(1352, 48);
            this.status2Label.TabIndex = 65;
            this.status2Label.Text = "dfg";
            this.status2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(2820, 1500);
            this.Controls.Add(this.status2Label);
            this.Controls.Add(this.rejectButton);
            this.Controls.Add(this.approveButton);
            this.Controls.Add(this.remarksLabel);
            this.Controls.Add(this.remarksTextBox);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.dateapproverejectTextBox);
            this.Controls.Add(this.dateapprovedrejectLabel);
            this.Controls.Add(this.enddateTextBox);
            this.Controls.Add(this.startdateTextBox);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.documentnameLabel);
            this.Controls.Add(this.leavetypeTextBox);
            this.Controls.Add(this.dateappliedTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.enddateLabel);
            this.Controls.Add(this.startdateLabel);
            this.Controls.Add(this.supportdocumentLabel);
            this.Controls.Add(this.dateappliedLabel);
            this.Controls.Add(this.departmentTextBox);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.employeeidTextBox);
            this.Controls.Add(this.employeeidLabel);
            this.Controls.Add(this.leavetypeLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminLeave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leave";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminLeave_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AdminLeave_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AdminLeave_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button minimizeButton;
        private Button closeButton;
        private Label label1;
        private DataGridView dataGridView1;
        private Label descriptionLabel;
        private TextBox descriptionTextBox;
        private Label enddateLabel;
        private Label startdateLabel;
        private Label supportdocumentLabel;
        private Label dateappliedLabel;
        private TextBox departmentTextBox;
        private Label departmentLabel;
        private Label positionLabel;
        private TextBox positionTextBox;
        private TextBox nameTextBox;
        private Label nameLabel;
        private TextBox employeeidTextBox;
        private Label employeeidLabel;
        private Label leavetypeLabel;
        private TextBox dateappliedTextBox;
        private TextBox leavetypeTextBox;
        private Label documentnameLabel;
        private Button downloadButton;
        private TextBox startdateTextBox;
        private TextBox enddateTextBox;
        private TextBox dateapproverejectTextBox;
        private Label dateapprovedrejectLabel;
        private Label statusLabel;
        private TextBox statusTextBox;
        private Label remarksLabel;
        private TextBox remarksTextBox;
        private Button approveButton;
        private Button rejectButton;
        private Label status2Label;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}