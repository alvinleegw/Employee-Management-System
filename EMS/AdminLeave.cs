﻿using iTextSharp.text;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EMS
{
    public partial class AdminLeave : Form
    {
        private bool _dragging;
        private Point _startPoint = new Point(0, 0);
        private int _row;
        string connectionString = null;
        MySqlConnection connection;
        public static string employeeid;
        public static string startdate;
        public static string enddate;
        public static string document;
        public static string status;
        public static string remarks;

        public AdminLeave()
        {
            InitializeComponent();
            downloadButton.Visible = false;
            approveButton.Visible = false;
            rejectButton.Visible = false;
            try
            {
                connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT status, employeeid, leavetype, description, dateapplied, startdate, enddate, dateapprovereject, remarks, month, year FROM LEAVEREQUEST ORDER BY INSTR(status, 'PEN') DESC, status";
                command.ExecuteNonQuery();
                DataTable dataTable = new DataTable();
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                {
                    dataAdapter.Fill(dataTable);
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns[0].HeaderText = "Status";
                dataGridView1.Columns[1].HeaderText = "Employee ID";
                dataGridView1.Columns[2].HeaderText = "Leave Type";
                dataGridView1.Columns[3].HeaderText = "Description";
                dataGridView1.Columns[4].HeaderText = "Date Applied";
                dataGridView1.Columns[5].HeaderText = "Start Date";
                dataGridView1.Columns[6].HeaderText = "End Date";
                dataGridView1.Columns[7].HeaderText = "Date Approved/Rejected";
                dataGridView1.Columns[8].HeaderText = "Remarks";
                dataGridView1.Columns[9].HeaderText = "Month";
                dataGridView1.Columns[10].HeaderText = "Year";
                dataGridView1.DataMember = dataTable.TableName;
                connection.Close();
            }
            catch (Exception ex)
            {
                status2Label.Text = ex.Message;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            AdminDashboard admindashboard = new AdminDashboard();
            this.Hide();
            admindashboard.ShowDialog();
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AdminLeave_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void AdminLeave_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void AdminLeave_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_dragging) return;
            var p = PointToScreen(e.Location);
            Location = new Point(p.X - this._startPoint.X, p.Y - this._startPoint.Y);
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
                    employeeidTextBox.Text = row.Cells[1].Value.ToString();
                    employeeid = row.Cells[1].Value.ToString();
                    connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "SELECT name, position, department FROM EMPLOYEE WHERE employeeid ='" + employeeidTextBox.Text + "'";
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        nameTextBox.Text = reader["name"].ToString();
                        positionTextBox.Text = reader["position"].ToString();
                        departmentTextBox.Text = reader["department"].ToString();
                    }
                    reader.Close();
                    leavetypeTextBox.Text = row.Cells[2].Value.ToString();
                    descriptionTextBox.Text = row.Cells[3].Value.ToString();
                    dateappliedTextBox.Text = row.Cells[4].Value.ToString();
                    startdateTextBox.Text = row.Cells[5].Value.ToString();
                    startdate = row.Cells[5].Value.ToString();
                    enddateTextBox.Text = row.Cells[6].Value.ToString();
                    enddate = row.Cells[6].Value.ToString();
                    dateapproverejectTextBox.Text = row.Cells[7].Value.ToString();
                    remarksTextBox.Text = row.Cells[8].Value.ToString();
                    if (status == "PENDING")
                    {
                        approveButton.Visible = true;
                        rejectButton.Visible = true;
                    }
                    else
                    {
                        approveButton.Visible = false;
                        rejectButton.Visible = false;
                    }
                    MySqlCommand command2 = connection.CreateCommand();
                    command2.CommandText = "SELECT documentname FROM LEAVEREQUEST WHERE employeeid ='" + employeeid + "' AND startdate ='"
                    + startdate + "' AND enddate ='" + enddate + "' AND status ='" + status + "'";
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

        private void downloadButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    employeeid = employeeidTextBox.Text;
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

        private async void approveButton_Click(object sender, EventArgs e)
        {
            if (remarksTextBox.Text.Length > 100)
            {
                status3Label.Text = "Maximum Characters for Remarks is 100 Characters";
            }
            else
            {
                employeeid = employeeidTextBox.Text;
                startdate = startdateTextBox.Text;
                enddate = enddateTextBox.Text;
                remarks = remarksTextBox.Text;
                string dateapprovereject = DateTime.Now.ToString("d");
                try
                {
                    connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "UPDATE LEAVEREQUEST SET dateapprovereject ='" + dateapprovereject + "', status ='"
                    + "APPROVED', remarks ='" + remarks + "' WHERE employeeid ='" + employeeid + "' AND startdate = '" + startdate
                    + "' AND enddate ='" + enddate + "'";
                    if (command.ExecuteNonQuery() == 1)
                    {
                        status2Label.Text = "Approved Leave Request";
                        statusTextBox.Text = "APPROVED";
                        approveButton.Visible = false;
                        rejectButton.Visible = false;
                        dateapproverejectTextBox.Text = dateapprovereject;
                        MySqlCommand command2 = connection.CreateCommand();
                        DateTime startingDate = Convert.ToDateTime(startdate);
                        DateTime endingDate = Convert.ToDateTime(enddate);
                        for (DateTime date = startingDate; date <= endingDate; date = date.AddDays(1))
                        {
                            DayOfWeek day = date.DayOfWeek;
                            string month = date.Month.ToString();
                            string year = date.Year.ToString();
                            if ((day == DayOfWeek.Saturday) || (day == DayOfWeek.Sunday))
                            {

                            }
                            else
                            {
                                command2.CommandText = "INSERT INTO ATTENDANCE(status, counter, date, month, year, employeeid) VALUES('LEAVE', '2', '"
                                + date.ToString("d") + "', '" + month + "', '" + year + "', '" + employeeid + "')";
                                command2.ExecuteNonQuery();
                            }
                        }
                    }
                    MySqlCommand command3 = connection.CreateCommand();
                    command3.CommandText = "SELECT status, employeeid, leavetype, description, dateapplied, startdate, enddate, dateapprovereject, remarks, month, year FROM LEAVEREQUEST ORDER BY INSTR(status, 'PEN') DESC, status";
                    command3.ExecuteNonQuery();
                    DataTable dataTable = new DataTable();
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command3))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns[0].HeaderText = "Status";
                    dataGridView1.Columns[1].HeaderText = "Employee ID";
                    dataGridView1.Columns[2].HeaderText = "Leave Type";
                    dataGridView1.Columns[3].HeaderText = "Description";
                    dataGridView1.Columns[4].HeaderText = "Date Applied";
                    dataGridView1.Columns[5].HeaderText = "Start Date";
                    dataGridView1.Columns[6].HeaderText = "End Date";
                    dataGridView1.Columns[7].HeaderText = "Date Approved/Rejected";
                    dataGridView1.Columns[8].HeaderText = "Remarks";
                    dataGridView1.Columns[9].HeaderText = "Month";
                    dataGridView1.Columns[10].HeaderText = "Year";
                    dataGridView1.DataMember = dataTable.TableName;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    status2Label.Text = ex.Message;
                }
            }
        }

        private void rejectButton_Click(object sender, EventArgs e)
        {
            if (remarksTextBox.Text.Length > 100)
            {
                status3Label.Text = "Maximum Characters for Remarks is 100 Characters";
            }
            else
            {
                employeeid = employeeidTextBox.Text;
                startdate = startdateTextBox.Text;
                enddate = enddateTextBox.Text;
                remarks = remarksTextBox.Text;
                string dateapprovereject = DateTime.Now.ToString("d");
                try
                {
                    connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "UPDATE LEAVEREQUEST SET dateapprovereject ='" + dateapprovereject + "', status ='"
                    + "REJECTED', remarks ='" + remarks + "' WHERE employeeid ='" + employeeid + "' AND startdate = '" + startdate
                    + "' AND enddate ='" + enddate + "'";
                    if (command.ExecuteNonQuery() == 1)
                    {
                        status2Label.Text = "Rejected Leave Request";
                        statusTextBox.Text = "REJECTED";
                        approveButton.Visible = false;
                        rejectButton.Visible = false;
                        dateapproverejectTextBox.Text = dateapprovereject;
                    }
                    MySqlCommand command2 = connection.CreateCommand();
                    command2.CommandText = "SELECT status, employeeid, leavetype, description, dateapplied, startdate, enddate, dateapprovereject, remarks, month, year FROM LEAVEREQUEST ORDER BY INSTR(status, 'PEN') DESC, status";
                    command2.ExecuteNonQuery();
                    DataTable dataTable = new DataTable();
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command2))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns[0].HeaderText = "Status";
                    dataGridView1.Columns[1].HeaderText = "Employee ID";
                    dataGridView1.Columns[2].HeaderText = "Leave Type";
                    dataGridView1.Columns[3].HeaderText = "Description";
                    dataGridView1.Columns[4].HeaderText = "Date Applied";
                    dataGridView1.Columns[5].HeaderText = "Start Date";
                    dataGridView1.Columns[6].HeaderText = "End Date";
                    dataGridView1.Columns[7].HeaderText = "Date Approved/Rejected";
                    dataGridView1.Columns[8].HeaderText = "Remarks";
                    dataGridView1.Columns[9].HeaderText = "Month";
                    dataGridView1.Columns[10].HeaderText = "Year";
                    dataGridView1.DataMember = dataTable.TableName;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    status2Label.Text = ex.Message;
                }
            }
        }

        private void remarksTextBox_TextChanged(object sender, EventArgs e)
        {
            int length = remarksTextBox.Text.Length;
            if (length <= 100)
            {
                wordcountLabel.Text = (100 - length).ToString() + " characters remaining";
                status3Label.Text = String.Empty;
            }
            else if (length > 100)
            {
                wordcountLabel.Text = "0 characters remaining";
                status3Label.Text = "Maximum Characters for Remarks is 100 Characters";
            }
        }
    }
}
