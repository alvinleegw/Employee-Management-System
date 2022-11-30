using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS
{
    public partial class EmployeeHistory : Form
    {
        private bool _dragging;
        private Point _startPoint = new Point(0, 0);
        private int _row;
        public static string connectionString = null;
        MySqlConnection connection;
        public static string username;
        public static string employeeid;

        public EmployeeHistory()
        {
            InitializeComponent();
            username = EmployeeDashboard.username;
            try
            {
                string result;
                connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                MySqlCommand command2 = connection.CreateCommand();
                MySqlCommand command3 = connection.CreateCommand();
                command.CommandText = "SELECT employeeid FROM EMPLOYEE WHERE username='" + username + "'";
                employeeid = command.ExecuteScalar().ToString();
                command2.CommandText = "SELECT clockin, clockout, workinghours, date, month FROM ATTENDANCE WHERE employeeid = '" 
                + employeeid + "'";
                command2.ExecuteNonQuery();
                command3.CommandText = "SELECT COUNT(*) FROM ATTENDANCE WHERE employeeid = '" + employeeid + "'";
                result = command3.ExecuteScalar().ToString();
                DataTable dataTable = new DataTable();
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command2))
                {
                    dataAdapter.Fill(dataTable);
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns[0].HeaderText = "Clock In";
                dataGridView1.Columns[1].HeaderText = "Clock Out";
                dataGridView1.Columns[2].HeaderText = "Working Hours";
                dataGridView1.Columns[3].HeaderText = "Date";
                dataGridView1.Columns[4].HeaderText = "Month";
                dataGridView1.DataMember = dataTable.TableName;
                resultLabel.ForeColor = Color.Black;
                resultLabel.Text = result + " rows returned";
                connection.Close();
            }
            catch (Exception ex)
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = ex.Message;
            }
        }

        private void EmployeeHistory_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void EmployeeHistory_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void EmployeeHistory_MouseMove(object sender, MouseEventArgs e)
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

        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string month = monthComboBox.SelectedItem.ToString();
            string result;
            try
            {
                connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                MySqlCommand command2 = connection.CreateCommand();
                command.CommandText = "SELECT clockin, clockout, workinghours, date, month FROM ATTENDANCE WHERE month = '"
                + month + "' AND employeeid = '" + employeeid + "'";
                command.ExecuteNonQuery();
                command2.CommandText = "SELECT COUNT(*) FROM ATTENDANCE WHERE month = '"
                + month + "' AND employeeid = '" + employeeid + "'";
                result = command2.ExecuteScalar().ToString();
                DataTable dataTable = new DataTable();
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                {
                    dataAdapter.Fill(dataTable);
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns[0].HeaderText = "Clock In";
                dataGridView1.Columns[1].HeaderText = "Clock Out";
                dataGridView1.Columns[2].HeaderText = "Working Hours";
                dataGridView1.Columns[3].HeaderText = "Date";
                dataGridView1.Columns[4].HeaderText = "Month";
                dataGridView1.DataMember = dataTable.TableName;
                resultLabel.ForeColor = Color.Black;
                resultLabel.Text = result + " rows returned";
                connection.Close();
            }
            catch (Exception ex)
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = ex.Message;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToString("d");
            string result;
            try
            {
                connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                MySqlCommand command2 = connection.CreateCommand();
                command.CommandText = "SELECT clockin, clockout, workinghours, date, month FROM ATTENDANCE WHERE date = '"
                + date + "' AND employeeid = '" + employeeid + "'";
                command.ExecuteNonQuery();
                command2.CommandText = "SELECT COUNT(*) FROM ATTENDANCE WHERE date = '"
                + date + "' AND employeeid = '" + employeeid + "'";
                result = command2.ExecuteScalar().ToString();
                DataTable dataTable = new DataTable();
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                {
                    dataAdapter.Fill(dataTable);
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns[0].HeaderText = "Clock In";
                dataGridView1.Columns[1].HeaderText = "Clock Out";
                dataGridView1.Columns[2].HeaderText = "Working Hours";
                dataGridView1.Columns[3].HeaderText = "Date";
                dataGridView1.Columns[4].HeaderText = "Month";
                dataGridView1.DataMember = dataTable.TableName;
                resultLabel.ForeColor = Color.Black;
                resultLabel.Text = result.ToString() + " rows returned";
                connection.Close();
            }
            catch (Exception ex)
            {
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = ex.Message;
            }
        }

        private void dateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (dateRadioButton.Checked)
            {
                selectLabel.Text = "Please Select a Date:";
                dateTimePicker1.Visible = true;
                monthComboBox.Visible = false;
                string date = DateTime.Now.ToString("d");
                string result;
                try
                {
                    connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    MySqlCommand command2 = connection.CreateCommand();
                    command.CommandText = "SELECT clockin, clockout, workinghours, date, month FROM ATTENDANCE WHERE date = '"
                    + date + "' AND employeeid = '" + employeeid + "'";
                    command.ExecuteNonQuery();
                    command2.CommandText = "SELECT COUNT(*) FROM ATTENDANCE WHERE date = '"
                    + date + "' AND employeeid = '" + employeeid + "'";
                    result = command2.ExecuteScalar().ToString();
                    DataTable dataTable = new DataTable();
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns[0].HeaderText = "Clock In";
                    dataGridView1.Columns[1].HeaderText = "Clock Out";
                    dataGridView1.Columns[2].HeaderText = "Working Hours";
                    dataGridView1.Columns[3].HeaderText = "Date";
                    dataGridView1.Columns[4].HeaderText = "Month";
                    dataGridView1.DataMember = dataTable.TableName;
                    resultLabel.ForeColor = Color.Black;
                    resultLabel.Text = result.ToString() + " rows returned";
                    connection.Close();
                }
                catch (Exception ex)
                {
                    resultLabel.ForeColor = Color.Red;
                    resultLabel.Text = ex.Message;
                }
            }
        }

        private void monthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (monthRadioButton.Checked)
            {
                selectLabel.Text = "Please Select Month:";
                monthComboBox.Visible = true;
                dateTimePicker1.Visible = false;
            }
        }

        private void allRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (allRadioButton.Checked)
            {
                selectLabel.Text = String.Empty;
                monthComboBox.Visible = false;
                dateTimePicker1.Visible = false;
                try
                {
                    string result;
                    connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    MySqlCommand command2 = connection.CreateCommand();
                    MySqlCommand command3 = connection.CreateCommand();
                    command.CommandText = "SELECT employeeid FROM EMPLOYEE WHERE username='" + username + "'";
                    employeeid = command.ExecuteScalar().ToString();
                    command2.CommandText = "SELECT clockin, clockout, workinghours, date, month FROM ATTENDANCE WHERE employeeid = '"
                    + employeeid + "'";
                    command2.ExecuteNonQuery();
                    command3.CommandText = "SELECT COUNT(*) FROM ATTENDANCE WHERE employeeid = '" + employeeid + "'";
                    result = command3.ExecuteScalar().ToString();
                    DataTable dataTable = new DataTable();
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command2))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns[0].HeaderText = "Clock In";
                    dataGridView1.Columns[1].HeaderText = "Clock Out";
                    dataGridView1.Columns[2].HeaderText = "Working Hours";
                    dataGridView1.Columns[3].HeaderText = "Date";
                    dataGridView1.Columns[4].HeaderText = "Month";
                    dataGridView1.DataMember = dataTable.TableName;
                    resultLabel.ForeColor = Color.Black;
                    resultLabel.Text = result + " rows returned";
                    connection.Close();
                }
                catch (Exception ex)
                {
                    resultLabel.ForeColor = Color.Red;
                    resultLabel.Text = ex.Message;
                }
            }
        }
    }
}
