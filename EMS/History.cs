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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace EMS
{
    public partial class History : Form
    {
        private bool _dragging;
        private Point _startPoint = new Point(0, 0);
        private int _row;
        public static string connectionString = null;
        MySqlConnection connection;

        public History()
        {
            InitializeComponent();
            selectLabel.Text = String.Empty;
            dateTimePicker2.CustomFormat = "MM/yyyy";
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            searchButton.Visible = false;
            searchTextBox.Visible = false;
            try
            {
                string result;
                connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT Employee.employeeid, Employee.name, Employee.position, Employee.department, " +
                "Attendance.clockin, Attendance.clockout, Attendance.date, Attendance.status, Attendance.month, Attendance.year FROM Employee " +
                "INNER JOIN Attendance ON Employee.employeeid = Attendance.employeeid";
                command.ExecuteNonQuery();
                DataTable dataTable = new DataTable();
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                {
                    dataAdapter.Fill(dataTable);
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns[0].HeaderText = "Employee ID";
                dataGridView1.Columns[1].HeaderText = "Name";
                dataGridView1.Columns[2].HeaderText = "Position";
                dataGridView1.Columns[3].HeaderText = "Department";
                dataGridView1.Columns[4].HeaderText = "Clock In";
                dataGridView1.Columns[5].HeaderText = "Clock Out";
                dataGridView1.Columns[6].HeaderText = "Date";
                dataGridView1.Columns[7].HeaderText = "Status";
                dataGridView1.Columns[8].HeaderText = "Month";
                dataGridView1.Columns[9].HeaderText = "Year";
                dataGridView1.DataMember = dataTable.TableName;
                connection.Close();
            }
            catch (Exception ex)
            {
                resultLabel.ForeColor = Color.Brown;
                resultLabel.Text = ex.Message;
            }
        }

        private void History_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void History_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void History_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_dragging) return;
            var p = PointToScreen(e.Location);
            Location = new Point(p.X - this._startPoint.X, p.Y - this._startPoint.Y);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            AdminDashboard admindashboard = new AdminDashboard();
            this.Hide();
            admindashboard.ShowDialog();
            this.Close();
        }

        private void minimiseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (dateRadioButton.Checked)
            {
                selectLabel.Text = "Please Select a Date:";
                dateTimePicker1.Visible= true;
                dateTimePicker2.Visible = false;
                searchButton.Visible = false;
                searchTextBox.Visible = false;
                string date = DateTime.Now.ToString("d");
                string result;
                try
                {
                    connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    MySqlCommand command2 = connection.CreateCommand();
                    command.CommandText = "SELECT Employee.employeeid, Employee.name, Employee.position, Employee.department, " +
                    "Attendance.clockin, Attendance.clockout, Attendance.date, Attendance.status, Attendance.month, Attendance.year FROM Employee " +
                    "INNER JOIN Attendance ON Employee.employeeid = Attendance.employeeid WHERE Attendance.date ='" + date + "'";
                    command.ExecuteNonQuery();
                    command2.CommandText = "SELECT COUNT(*) FROM Employee INNER JOIN Attendance ON Employee.employeeid " +
                    "= Attendance.employeeid WHERE Attendance.date ='" + date + "'";
                    result = command2.ExecuteScalar().ToString();
                    DataTable dataTable = new DataTable();
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns[0].HeaderText = "Employee ID";
                    dataGridView1.Columns[1].HeaderText = "Name";
                    dataGridView1.Columns[2].HeaderText = "Position";
                    dataGridView1.Columns[3].HeaderText = "Department";
                    dataGridView1.Columns[4].HeaderText = "Clock In";
                    dataGridView1.Columns[5].HeaderText = "Clock Out";
                    dataGridView1.Columns[6].HeaderText = "Date";
                    dataGridView1.Columns[7].HeaderText = "Status";
                    dataGridView1.Columns[8].HeaderText = "Month";
                    dataGridView1.Columns[9].HeaderText = "Year";
                    dataGridView1.DataMember = dataTable.TableName;
                    resultLabel.ForeColor = Color.White;
                    resultLabel.Text = result + " rows returned";
                    connection.Close();
                }
                catch (Exception ex)
                {
                    resultLabel.ForeColor = Color.Brown;
                    resultLabel.Text = ex.Message;
                }
            }
        }

        private void allRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (allRadioButton.Checked)
            {
                selectLabel.Text = String.Empty;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
                searchButton.Visible = false;
                searchTextBox.Visible = false;
                try
                {
                    string result;
                    connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    MySqlCommand command2 = connection.CreateCommand();
                    command.CommandText = "SELECT Employee.employeeid, Employee.name, Employee.position, Employee.department, " +
                    "Attendance.clockin, Attendance.clockout, Attendance.date, Attendance.status, Attendance.month, Attendance.year FROM Employee " +
                    "INNER JOIN Attendance ON Employee.employeeid = Attendance.employeeid";
                    command.ExecuteNonQuery();
                    command2.CommandText = "SELECT COUNT(*) FROM Employee INNER JOIN Attendance ON Employee.employeeid " +
                    "= Attendance.employeeid";
                    result = command2.ExecuteScalar().ToString();
                    DataTable dataTable = new DataTable();
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns[0].HeaderText = "Employee ID";
                    dataGridView1.Columns[1].HeaderText = "Name";
                    dataGridView1.Columns[2].HeaderText = "Position";
                    dataGridView1.Columns[3].HeaderText = "Department";
                    dataGridView1.Columns[4].HeaderText = "Clock In";
                    dataGridView1.Columns[5].HeaderText = "Clock Out";
                    dataGridView1.Columns[6].HeaderText = "Date";
                    dataGridView1.Columns[7].HeaderText = "Status";
                    dataGridView1.Columns[8].HeaderText = "Month";
                    dataGridView1.Columns[9].HeaderText = "Year";
                    dataGridView1.DataMember = dataTable.TableName;
                    resultLabel.ForeColor = Color.White;
                    resultLabel.Text = result + " rows returned";
                    connection.Close();
                }
                catch (Exception ex)
                {
                    resultLabel.ForeColor = Color.Brown;
                    resultLabel.Text = ex.Message;
                }
            }
        }

        private void employeeidRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (employeeidRadioButton.Checked)
            {
                selectLabel.Text = "Please Enter Employee ID:";
                searchButton.Visible = true;
                searchTextBox.Visible = true;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
            }
        }

        private void employeenameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (employeenameRadioButton.Checked)
            {
                selectLabel.Text = "Please Enter Employee Name:";
                searchButton.Visible = true;
                searchTextBox.Visible = true;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
            }
        }

        private void departmentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (departmentRadioButton.Checked)
            {
                selectLabel.Text = "Please Enter Department:";
                searchButton.Visible = true;
                searchTextBox.Visible = true;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
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
                command.CommandText = "SELECT Employee.employeeid, Employee.name, Employee.position, Employee.department, " +
                "Attendance.clockin, Attendance.clockout, Attendance.date, Attendance.status, Attendance.month, Attendance.year FROM Employee " +
                "INNER JOIN Attendance ON Employee.employeeid = Attendance.employeeid WHERE Attendance.date ='" + date + "'";
                command.ExecuteNonQuery();
                command2.CommandText = "SELECT COUNT(*) FROM Employee INNER JOIN Attendance ON Employee.employeeid " +
                "= Attendance.employeeid WHERE Attendance.date ='" + date + "'";
                result = command2.ExecuteScalar().ToString();
                DataTable dataTable = new DataTable();
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                {
                    dataAdapter.Fill(dataTable);
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns[0].HeaderText = "Employee ID";
                dataGridView1.Columns[1].HeaderText = "Name";
                dataGridView1.Columns[2].HeaderText = "Position";
                dataGridView1.Columns[3].HeaderText = "Department";
                dataGridView1.Columns[4].HeaderText = "Clock In";
                dataGridView1.Columns[5].HeaderText = "Clock Out";
                dataGridView1.Columns[6].HeaderText = "Date";
                dataGridView1.Columns[7].HeaderText = "Status";
                dataGridView1.Columns[8].HeaderText = "Month";
                dataGridView1.Columns[9].HeaderText = "Year";
                dataGridView1.DataMember = dataTable.TableName;
                resultLabel.ForeColor = Color.White;
                resultLabel.Text = result + " rows returned";
                connection.Close();
            }
            catch (Exception ex)
            {
                resultLabel.ForeColor = Color.Brown;
                resultLabel.Text = ex.Message;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string result;
            if (employeeidRadioButton.Checked)
            {
                string employeeid = searchTextBox.Text;
                try
                {
                    connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    MySqlCommand command2 = connection.CreateCommand();
                    command.CommandText = "SELECT Employee.employeeid, Employee.name, Employee.position, Employee.department, " +
                    "Attendance.clockin, Attendance.clockout, Attendance.date, Attendance.status, Attendance.month, Attendance.year FROM Employee " +
                    "INNER JOIN Attendance ON Employee.employeeid = Attendance.employeeid WHERE Employee.employeeid LIKE '" + employeeid + "%'";
                    command.ExecuteNonQuery();
                    command2.CommandText = "SELECT COUNT(*) FROM Employee INNER JOIN Attendance ON Employee.employeeid " +
                    "= Attendance.employeeid WHERE Employee.employeeid LIKE '" + employeeid + "%'";
                    result = command2.ExecuteScalar().ToString();
                    DataTable dataTable = new DataTable();
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns[0].HeaderText = "Employee ID";
                    dataGridView1.Columns[1].HeaderText = "Name";
                    dataGridView1.Columns[2].HeaderText = "Position";
                    dataGridView1.Columns[3].HeaderText = "Department";
                    dataGridView1.Columns[4].HeaderText = "Clock In";
                    dataGridView1.Columns[5].HeaderText = "Clock Out";
                    dataGridView1.Columns[6].HeaderText = "Date";
                    dataGridView1.Columns[7].HeaderText = "Status";
                    dataGridView1.Columns[8].HeaderText = "Month";
                    dataGridView1.Columns[9].HeaderText = "Year";
                    dataGridView1.DataMember = dataTable.TableName;
                    resultLabel.ForeColor = Color.White;
                    resultLabel.Text = result + " rows returned";
                    connection.Close();
                }
                catch (Exception ex)
                {
                    resultLabel.ForeColor = Color.Brown;
                    resultLabel.Text = ex.Message;
                }
            }
            else if (employeenameRadioButton.Checked)
            {
                string name = searchTextBox.Text;
                try
                {
                    connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    MySqlCommand command2 = connection.CreateCommand();
                    command.CommandText = "SELECT Employee.employeeid, Employee.name, Employee.position, Employee.department, " +
                    "Attendance.clockin, Attendance.clockout, Attendance.date, Attendance.status, Attendance.month, Attendance.year FROM Employee " +
                    "INNER JOIN Attendance ON Employee.employeeid = Attendance.employeeid WHERE Employee.name LIKE '" + name + "%'";
                    command.ExecuteNonQuery();
                    command2.CommandText = "SELECT COUNT(*) FROM Employee INNER JOIN Attendance ON Employee.employeeid " +
                    "= Attendance.employeeid WHERE Employee.name LIKE '" + name + "%'";
                    result = command2.ExecuteScalar().ToString();
                    DataTable dataTable = new DataTable();
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns[0].HeaderText = "Employee ID";
                    dataGridView1.Columns[1].HeaderText = "Name";
                    dataGridView1.Columns[2].HeaderText = "Position";
                    dataGridView1.Columns[3].HeaderText = "Department";
                    dataGridView1.Columns[4].HeaderText = "Clock In";
                    dataGridView1.Columns[5].HeaderText = "Clock Out";
                    dataGridView1.Columns[6].HeaderText = "Date";
                    dataGridView1.Columns[7].HeaderText = "Status";
                    dataGridView1.Columns[8].HeaderText = "Month";
                    dataGridView1.Columns[9].HeaderText = "Year";
                    dataGridView1.DataMember = dataTable.TableName;
                    resultLabel.ForeColor = Color.White;
                    resultLabel.Text = result + " rows returned";
                    connection.Close();
                }
                catch (Exception ex)
                {
                    resultLabel.ForeColor = Color.Brown;
                    resultLabel.Text = ex.Message;
                }
            }
            else if (departmentRadioButton.Checked)
            {
                string department = searchTextBox.Text;
                try
                {
                    connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    MySqlCommand command2 = connection.CreateCommand();
                    command.CommandText = "SELECT Employee.employeeid, Employee.name, Employee.position, Employee.department, " +
                    "Attendance.clockin, Attendance.clockout, Attendance.date, Attendance.status, Attendance.month, Attendance.year FROM Employee " +
                    "INNER JOIN Attendance ON Employee.employeeid = Attendance.employeeid WHERE Employee.department LIKE '" + department + "%'";
                    command.ExecuteNonQuery();
                    command2.CommandText = "SELECT COUNT(*) FROM Employee INNER JOIN Attendance ON Employee.employeeid " +
                    "= Attendance.employeeid WHERE Employee.department LIKE '" + department + "%'";
                    result = command2.ExecuteScalar().ToString();
                    DataTable dataTable = new DataTable();
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns[0].HeaderText = "Employee ID";
                    dataGridView1.Columns[1].HeaderText = "Name";
                    dataGridView1.Columns[2].HeaderText = "Position";
                    dataGridView1.Columns[3].HeaderText = "Department";
                    dataGridView1.Columns[4].HeaderText = "Clock In";
                    dataGridView1.Columns[5].HeaderText = "Clock Out";
                    dataGridView1.Columns[6].HeaderText = "Date";
                    dataGridView1.Columns[7].HeaderText = "Status";
                    dataGridView1.Columns[8].HeaderText = "Month";
                    dataGridView1.Columns[9].HeaderText = "Year";
                    dataGridView1.DataMember = dataTable.TableName;
                    resultLabel.ForeColor = Color.White;
                    resultLabel.Text = result + " rows returned";
                    connection.Close();
                }
                catch (Exception ex)
                {
                    resultLabel.ForeColor = Color.Brown;
                    resultLabel.Text = ex.Message;
                }
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            try
            {
                var csv = new System.Text.StringBuilder();
                var header = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", "Employee ID", "Name", "Position", "Department", "Clock In", "Clock Out", "Date", "Status", "Month", "Year");
                csv.AppendLine(header);
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    var newLine = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value, row.Cells[4].Value, row.Cells[5].Value, row.Cells[6].Value, row.Cells[7].Value, row.Cells[8].Value, row.Cells[9].Value);
                    csv.AppendLine(newLine);
                }
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Export Data";
                saveFileDialog.Filter = "CSV file(*.csv)|*.csv";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, csv.ToString());
                    resultLabel.Text = "Data Successfully Exported";
                }
            }
            catch (Exception ex)
            {
                resultLabel.Text = ex.Message;
            }
        }

        private void monthyearRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (monthyearRadioButton.Checked)
            {
                selectLabel.Text = "Please Select Month and Year:";
                dateTimePicker2.Visible = true;
                dateTimePicker1.Visible = false;
                searchButton.Visible = false;
                searchTextBox.Visible = false;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime time = dateTimePicker2.Value;
            string month = time.Month.ToString();
            string year = time.Year.ToString();
            string result;
            try
            {
                connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                MySqlCommand command2 = connection.CreateCommand();
                command.CommandText = "SELECT Employee.employeeid, Employee.name, Employee.position, Employee.department, " +
                "Attendance.clockin, Attendance.clockout, Attendance.date, Attendance.status, Attendance.month, Attendance.year FROM Employee " +
                "INNER JOIN Attendance ON Employee.employeeid = Attendance.employeeid WHERE Attendance.month ='" + month + "' AND year ='" + year + "'";
                command.ExecuteNonQuery();
                command2.CommandText = "SELECT COUNT(*) FROM Employee INNER JOIN Attendance ON Employee.employeeid " +
                "= Attendance.employeeid WHERE Attendance.month ='" + month + "' AND year ='" + year + "'";
                result = command2.ExecuteScalar().ToString();
                DataTable dataTable = new DataTable();
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                {
                    dataAdapter.Fill(dataTable);
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns[0].HeaderText = "Employee ID";
                dataGridView1.Columns[1].HeaderText = "Name";
                dataGridView1.Columns[2].HeaderText = "Position";
                dataGridView1.Columns[3].HeaderText = "Department";
                dataGridView1.Columns[4].HeaderText = "Clock In";
                dataGridView1.Columns[5].HeaderText = "Clock Out";
                dataGridView1.Columns[6].HeaderText = "Date";
                dataGridView1.Columns[7].HeaderText = "Status";
                dataGridView1.Columns[8].HeaderText = "Month";
                dataGridView1.Columns[9].HeaderText = "Year";
                dataGridView1.DataMember = dataTable.TableName;
                resultLabel.ForeColor = Color.White;
                resultLabel.Text = result + " rows returned";
                connection.Close();
            }
            catch (Exception ex)
            {
                resultLabel.ForeColor = Color.Brown;
                resultLabel.Text = ex.Message;
            }
        }
    }
}
