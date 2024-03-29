﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EMS
{
    public partial class Position : Form
    {
        private bool _dragging;
        private Point _startPoint = new Point(0, 0);
        private int _row;
        public static string connectionString = null;
        MySqlConnection connection;
        public static string departmentcode;
        public static string departmentname;
        public static string position;

        public Position()
        {
            InitializeComponent();
            try
            {
                connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                MySqlCommand command2= connection.CreateCommand();
                command.CommandText = "SELECT Position.positionname, Department.departmentname FROM POSITION INNER JOIN DEPARTMENT ON " +
                "Position.departmentcode = Department.departmentcode";
                command2.CommandText = "SELECT departmentname FROM DEPARTMENT";
                MySqlDataReader read = command2.ExecuteReader();
                while(read.Read())
                {
                    departmentComboBox.Items.Add(read[0]);
                }
                read.Close();
                DataTable dataTable = new DataTable();
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                {
                    dataAdapter.Fill(dataTable);
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns[0].HeaderText = "Position";
                dataGridView1.Columns[1].HeaderText = "Department";
                dataGridView1.DataMember = dataTable.TableName;
                connection.Close();
            }
            catch (Exception ex)
            {
                statusLabel.ForeColor = Color.MistyRose;
                statusLabel.Text = ex.Message;
            }
        }

        private void Position_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void Position_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void Position_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_dragging) return;
            var p = PointToScreen(e.Location);
            Location = new Point(p.X - this._startPoint.X, p.Y - this._startPoint.Y);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void departmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (departmentComboBox.SelectedIndex != -1)
            {
                departmentname = departmentComboBox.SelectedItem.ToString();
                try
                {
                    connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    MySqlCommand command2 = connection.CreateCommand();
                    command.CommandText = "SELECT departmentcode FROM DEPARTMENT WHERE departmentname ='" + departmentname + "'";
                    departmentcode = command.ExecuteScalar().ToString();
                    command2.CommandText = "SELECT Position.positionname, Department.departmentname FROM POSITION INNER JOIN DEPARTMENT ON " +
                    "Position.departmentcode = Department.departmentcode WHERE Position.departmentcode ='" + departmentcode + "'";
                    DataTable dataTable = new DataTable();
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command2))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns[0].HeaderText = "Position";
                    dataGridView1.Columns[1].HeaderText = "Department";
                    dataGridView1.DataMember = dataTable.TableName;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    statusLabel.ForeColor = Color.MistyRose;
                    statusLabel.Text = ex.Message;
                }
            }
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            Regex regexname = new Regex(@"^[A-Za-z\s&()\s-./ ]*$");
            bool checkname = regexname.IsMatch(positionTextBox.Text);
            if (departmentComboBox.SelectedIndex == -1 || positionTextBox.Text == String.Empty)
            {
                statusLabel.ForeColor = Color.MistyRose;
                statusLabel.Text = "Please Select Department And Enter Position";
            }
            else if (positionTextBox.Text.Length < 3 || positionTextBox.Text.Length > 30)
            {
                statusLabel.ForeColor = Color.MistyRose;
                statusLabel.Text = "Position Must Be Between 3 To 30 Characters";
            }
            else if (!checkname)
            {
                statusLabel.ForeColor = Color.MistyRose;
                statusLabel.Text = "Position Name Must Be Alphabets And Certain Special Characters &&()-./ Only";
            }
            else
            {
                departmentname = departmentComboBox.SelectedItem.ToString();
                position = positionTextBox.Text.ToUpper();
                try
                {
                    connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    MySqlCommand command2 = connection.CreateCommand();
                    MySqlCommand command3 = connection.CreateCommand();
                    command.CommandText = "SELECT departmentcode FROM DEPARTMENT WHERE departmentname ='" + departmentname + "'";
                    departmentcode = command.ExecuteScalar().ToString();
                    command2.CommandText = "INSERT INTO `position`(`positionname`, `adminid`, `departmentcode`) VALUES('" + position + "', '1', '" + departmentcode + "')";
                    if (command2.ExecuteNonQuery() == 1)
                    {
                        positionTextBox.Text = String.Empty;
                        statusLabel.ForeColor = Color.LightGreen;
                        statusLabel.Text = "Position Successfully Added";
                    }
                    command3.CommandText = "SELECT Position.positionname, Department.departmentname FROM POSITION INNER JOIN DEPARTMENT ON " +
                    "Position.departmentcode = Department.departmentcode WHERE Position.departmentcode ='" + departmentcode + "'";
                    DataTable dataTable = new DataTable();
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command3))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns[0].HeaderText = "Position";
                    dataGridView1.Columns[1].HeaderText = "Department";
                    dataGridView1.DataMember = dataTable.TableName;
                    await Task.Delay(1500);
                    statusLabel.Text = String.Empty;
                }
                catch (Exception ex)
                {
                    statusLabel.ForeColor = Color.MistyRose;
                    statusLabel.Text = ex.Message;
                }
                connection.Close();
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) 
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    positionTextBox.Text = row.Cells[0].Value.ToString();
                    departmentComboBox.SelectedIndex = departmentComboBox.FindStringExact(row.Cells[1].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                statusLabel.Text = ex.Message;
            }
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            if (departmentComboBox.SelectedIndex == -1 || positionTextBox.Text == String.Empty)
            {
                statusLabel.ForeColor = Color.MistyRose;
                statusLabel.Text = "Please Select Department And Enter Position";
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this position? You have to update, archive or delete employees in this position if you wish to proceed.", "Delete Position Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        position = positionTextBox.Text;
                        connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                        connection = new MySqlConnection(connectionString);
                        connection.Open();
                        MySqlCommand command = connection.CreateCommand();
                        command.CommandText = "SELECT COUNT(*) FROM EMPLOYEE WHERE position ='" + position + "'";
                        if (Convert.ToInt32(command.ExecuteScalar()) > 0)
                        {
                            MessageBox.Show("Records with this position exists. Please update, delete or archive those records first.", "Records Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MySqlCommand command2 = connection.CreateCommand();
                            MySqlCommand command3 = connection.CreateCommand();
                            MySqlCommand command4 = connection.CreateCommand();
                            command2.CommandText = "SELECT departmentcode FROM DEPARTMENT WHERE departmentname ='" + departmentname + "'";
                            departmentcode = command2.ExecuteScalar().ToString();
                            command3.CommandText = "DELETE FROM POSITION WHERE positionname = '" + position + "' AND departmentcode = '" + departmentcode + "'";
                            if (command3.ExecuteNonQuery() == 1)
                            {
                                positionTextBox.Text = String.Empty;
                                statusLabel.ForeColor = Color.LightGreen;
                                statusLabel.Text = "Position Successfully Deleted";
                            }
                            command4.CommandText = "SELECT Position.positionname, Department.departmentname FROM POSITION INNER JOIN DEPARTMENT ON " +
                            "Position.departmentcode = Department.departmentcode WHERE Position.departmentcode ='" + departmentcode + "'";
                            DataTable dataTable = new DataTable();
                            using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command4))
                            {
                                dataAdapter.Fill(dataTable);
                            }
                            dataGridView1.DataSource = dataTable;
                            dataGridView1.Columns[0].HeaderText = "Position";
                            dataGridView1.Columns[1].HeaderText = "Department";
                            dataGridView1.DataMember = dataTable.TableName;
                            positionTextBox.Text = String.Empty;
                            await Task.Delay(1500);
                            statusLabel.Text = String.Empty;
                        }
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        statusLabel.ForeColor = Color.MistyRose;
                        statusLabel.Text = ex.Message;
                    }
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            departmentComboBox.SelectedItem = null;
            positionTextBox.Text= String.Empty;
            statusLabel.Text = String.Empty;
        }

        private void positionTextBox_TextChanged(object sender, EventArgs e)
        {
            Regex regexname = new Regex(@"^[A-Za-z\s&()\s-./ ]*$");
            bool checkname = regexname.IsMatch(positionTextBox.Text);
            if (positionTextBox.Text != String.Empty)
            {
                if (positionTextBox.Text.Length < 3 || positionTextBox.Text.Length > 30)
                {
                    statusLabel.ForeColor = Color.MistyRose;
                    statusLabel.Text = "Position Must Be Between 3 To 30 Characters";
                }
                else if (!checkname)
                {
                    statusLabel.ForeColor = Color.MistyRose;
                    statusLabel.Text = "Position Name Must Be Alphabets And Certain Special Characters &&()-./ Only";
                }
                else
                {
                    statusLabel.Text = String.Empty;
                }
            }
            else
            {
                if (!statusLabel.Text.Contains("Position Successfully Added") || !statusLabel.Text.Contains("Position Successfully Deleted"))
                {
                    statusLabel.ForeColor = Color.MistyRose;
                    statusLabel.Text = "Please Select Department And Enter Position";
                }
                else
                {
                    statusLabel.Text = String.Empty;
                }
            }
        }
    }
}
