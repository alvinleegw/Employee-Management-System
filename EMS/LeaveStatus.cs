using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS
{
    public partial class LeaveStatus : Form
    {
        private bool _dragging;
        private Point _startPoint = new Point(0, 0);
        private int _row;
        string connectionString = null;
        MySqlConnection connection;
        public static string username;
        public static string employeeid;
        public static string startdate;
        public static string enddate;
        public static string document;
        public static string status;
        public static string remarks;

        public LeaveStatus()
        {
            InitializeComponent();
            downloadButton.Visible = false;
            username = EmployeeDashboard.username;
            try
            {
                connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                MySqlCommand command2 = connection.CreateCommand();
                command.CommandText = "SELECT employeeid FROM EMPLOYEE WHERE username ='" + username + "'";
                employeeid = command.ExecuteScalar().ToString();
                command2.CommandText = "SELECT status, leavetype, description, dateapplied, startdate, enddate, dateapprovereject, remarks FROM LEAVEREQUEST WHERE employeeid ='"
                + employeeid + "' ORDER BY INSTR(status, 'PEN') DESC, status";
                command2.ExecuteNonQuery();
                DataTable dataTable = new DataTable();
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command2))
                {
                    dataAdapter.Fill(dataTable);
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns[0].HeaderText = "Status";
                dataGridView1.Columns[1].HeaderText = "Leave Type";
                dataGridView1.Columns[2].HeaderText = "Description";
                dataGridView1.Columns[3].HeaderText = "Date Applied";
                dataGridView1.Columns[4].HeaderText = "Start Date";
                dataGridView1.Columns[5].HeaderText = "End Date";
                dataGridView1.Columns[6].HeaderText = "Date Approved/Rejected";
                dataGridView1.Columns[7].HeaderText = "Remarks";
                dataGridView1.DataMember = dataTable.TableName;
                connection.Close();
            }
            catch (Exception ex)
            {
                status2Label.Text = ex.Message;
            }
        }

        private void LeaveStatus_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void LeaveStatus_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void LeaveStatus_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_dragging) return;
            var p = PointToScreen(e.Location);
            Location = new Point(p.X - this._startPoint.X, p.Y - this._startPoint.Y);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            EmployeeDashboard employeedashboard = new EmployeeDashboard();
            this.Hide();
            employeedashboard.ShowDialog();
            this.Close();
        }

        private void minimiseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    startdate = startdateTextBox.Text;
                    enddate = enddateTextBox.Text;
                    string filename = documentnameLabel.Text;
                    string path = folderBrowserDialog1.SelectedPath + "\\" + filename;
                    connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "SELECT document FROM LEAVEREQUEST WHERE documentname = '" + filename + "' AND employeeid ='"
                    + employeeid + "' AND startdate = '" + startdate + "' AND enddate ='" + enddate + "'";
                    MySqlDataReader reader = command.ExecuteReader(CommandBehavior.Default);
                    if (reader.Read())
                    {
                        byte[] fileData = (byte[])reader.GetValue(0);
                        using (FileStream filestream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite))
                        {
                            using (BinaryWriter binarywriter = new BinaryWriter(filestream))
                            {
                                binarywriter.Write(fileData);
                                MessageBox.Show("File Successfully Downloaded to Path: " + path, "File Downloaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                folderBrowserDialog1.SelectedPath = null;
                                binarywriter.Close();
                            }
                        }
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    status2Label.Text = ex.Message;
                }
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    statusTextBox.Text = row.Cells[0].Value.ToString();
                    status = row.Cells[0].Value.ToString();
                    connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    leavetypeTextBox.Text = row.Cells[1].Value.ToString();
                    descriptionTextBox.Text = row.Cells[2].Value.ToString();
                    dateappliedTextBox.Text = row.Cells[3].Value.ToString();
                    startdateTextBox.Text = row.Cells[4].Value.ToString();
                    startdate = row.Cells[4].Value.ToString();
                    enddateTextBox.Text = row.Cells[5].Value.ToString();
                    enddate = row.Cells[5].Value.ToString();
                    dateapproverejectTextBox.Text = row.Cells[6].Value.ToString();
                    remarksTextBox.Text = row.Cells[7].Value.ToString();
                    MySqlCommand command2 = connection.CreateCommand();
                    command2.CommandText = "SELECT documentname FROM LEAVEREQUEST WHERE employeeid ='" + employeeid + "' AND startdate ='"
                    + startdate + "' AND enddate ='" + enddate + "'";
                    document = command2.ExecuteScalar().ToString();
                    if (document != String.Empty)
                    {
                        documentnameLabel.Text = document;
                        downloadButton.Visible = true;
                    }
                    else
                    {
                        documentnameLabel.Text = String.Empty;
                        downloadButton.Visible = false;
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                status2Label.Text = ex.Message;
            }
        }
    }
}
