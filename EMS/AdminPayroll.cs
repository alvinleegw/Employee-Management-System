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
    public partial class AdminPayroll : Form
    {
        private bool _dragging;
        private Point _startPoint = new Point(0, 0);
        private int _row;
        public static string connectionString = null;
        MySqlConnection connection;

        public AdminPayroll()
        {
            InitializeComponent();
            dateTimePicker1.Visible = false;
            searchButton.Enabled = false;
            filterTextBox.Enabled = false;
            try
            {
                connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT PAYSLIP.payslipid, PAYSLIP.employeeid, EMPLOYEE.name, EMPLOYEE.position, EMPLOYEE.department, EMPLOYEE.hourlyrate, PAYSLIP.totalworkinghours, "
                + " PAYSLIP.totalworkingdays, PAYSLIP.salary, PAYSLIP.dateissued, PAYSLIP.month, PAYSLIP.year FROM EMPLOYEE INNER JOIN PAYSLIP ON EMPLOYEE.employeeid = PAYSLIP.employeeid";
                command.ExecuteNonQuery();
                DataTable dataTable = new DataTable();
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                {
                    dataAdapter.Fill(dataTable);
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns[0].HeaderText = "Payslip ID";
                dataGridView1.Columns[1].HeaderText = "Employee ID";
                dataGridView1.Columns[2].HeaderText = "Name";
                dataGridView1.Columns[3].HeaderText = "Position";
                dataGridView1.Columns[4].HeaderText = "Department";
                dataGridView1.Columns[5].HeaderText = "Hourly Rate";
                dataGridView1.Columns[6].HeaderText = "Total Working Hours";
                dataGridView1.Columns[7].HeaderText = "Total Working Days";
                dataGridView1.Columns[8].HeaderText = "Salary";
                dataGridView1.Columns[9].HeaderText = "Date Issued";
                dataGridView1.Columns[10].HeaderText = "Month";
                dataGridView1.Columns[11].HeaderText = "Year";
                dataGridView1.DataMember = dataTable.TableName;
                connection.Close();
            }
            catch (Exception ex)
            {
                statusLabel.Text = ex.Message;
            }
        }

        private void AdminPayroll_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void AdminPayroll_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void AdminPayroll_MouseMove(object sender, MouseEventArgs e)
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

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void allRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (allRadioButton.Checked)
            {
                dateTimePicker1.Visible = false;
                searchButton.Visible = true;
                filterTextBox.Visible = true;
                searchButton.Enabled = false;
                filterTextBox.Enabled = false;
                try
                {
                    connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    MySqlCommand command2 = connection.CreateCommand();
                    command.CommandText = "SELECT PAYSLIP.payslipid, PAYSLIP.employeeid, EMPLOYEE.name, EMPLOYEE.position, EMPLOYEE.department, EMPLOYEE.hourlyrate, PAYSLIP.totalworkinghours, "
                    + " PAYSLIP.totalworkingdays, PAYSLIP.salary, PAYSLIP.dateissued, PAYSLIP.month, PAYSLIP.year FROM EMPLOYEE INNER JOIN PAYSLIP ON EMPLOYEE.employeeid = PAYSLIP.employeeid";
                    command2.CommandText = "SELECT COUNT(*) FROM PAYSLIP";
                    string rows = command2.ExecuteScalar().ToString();
                    statusLabel.Text = rows + " rows returned";
                    command.ExecuteNonQuery();
                    DataTable dataTable = new DataTable();
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns[0].HeaderText = "Payslip ID";
                    dataGridView1.Columns[1].HeaderText = "Employee ID";
                    dataGridView1.Columns[2].HeaderText = "Name";
                    dataGridView1.Columns[3].HeaderText = "Position";
                    dataGridView1.Columns[4].HeaderText = "Department";
                    dataGridView1.Columns[5].HeaderText = "Hourly Rate";
                    dataGridView1.Columns[6].HeaderText = "Total Working Hours";
                    dataGridView1.Columns[7].HeaderText = "Total Working Days";
                    dataGridView1.Columns[8].HeaderText = "Salary";
                    dataGridView1.Columns[9].HeaderText = "Date Issued";
                    dataGridView1.Columns[10].HeaderText = "Month";
                    dataGridView1.Columns[11].HeaderText = "Year";
                    dataGridView1.DataMember = dataTable.TableName;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    statusLabel.Text = ex.Message;
                }
            }
        }

        private void employeeidRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (employeeidRadioButton.Checked)
            {
                dateTimePicker1.Visible = false;
                searchButton.Visible = true;
                filterTextBox.Visible = true;
                searchButton.Enabled = true;
                filterTextBox.Enabled = true;
            }
        }

        private void nameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (nameRadioButton.Checked)
            {
                dateTimePicker1.Visible = false;
                searchButton.Visible = true;
                filterTextBox.Visible = true;
                searchButton.Enabled = true;
                filterTextBox.Enabled = true;
            }
        }

        private void departmentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (departmentRadioButton.Checked)
            {
                dateTimePicker1.Visible = false;
                searchButton.Visible = true;
                filterTextBox.Visible = true;
                searchButton.Enabled = true;
                filterTextBox.Enabled = true;
            }
        }

        private void monthyearRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (monthyearRadioButton.Checked)
            {
                dateTimePicker1.Visible = true;
                searchButton.Visible = false;
                filterTextBox.Visible = false;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                MySqlCommand command2 = connection.CreateCommand();
                if (employeeidRadioButton.Checked)
                {
                    command.CommandText = "SELECT PAYSLIP.payslipid, PAYSLIP.employeeid, EMPLOYEE.name, EMPLOYEE.position, EMPLOYEE.department, EMPLOYEE.hourlyrate, PAYSLIP.totalworkinghours, "
                    + " PAYSLIP.totalworkingdays, PAYSLIP.salary, PAYSLIP.dateissued, PAYSLIP.month, PAYSLIP.year FROM EMPLOYEE INNER JOIN PAYSLIP ON EMPLOYEE.employeeid = PAYSLIP.employeeid"
                    + " WHERE EMPLOYEE.employeeid LIKE '" + filterTextBox.Text + "%'";
                    command2.CommandText = "SELECT COUNT(*) FROM EMPLOYEE INNER JOIN PAYSLIP ON EMPLOYEE.employeeid = PAYSLIP.employeeid " + "WHERE PAYSLIP.employeeid LIKE '" + filterTextBox.Text + "%'";
                    command.ExecuteNonQuery();
                }
                else if (nameRadioButton.Checked)
                {
                    command.CommandText = "SELECT PAYSLIP.payslipid, PAYSLIP.employeeid, EMPLOYEE.name, EMPLOYEE.position, EMPLOYEE.department, EMPLOYEE.hourlyrate, PAYSLIP.totalworkinghours, "
                    + " PAYSLIP.totalworkingdays, PAYSLIP.salary, PAYSLIP.dateissued, PAYSLIP.month, PAYSLIP.year FROM EMPLOYEE INNER JOIN PAYSLIP ON EMPLOYEE.employeeid = PAYSLIP.employeeid" 
                    +" WHERE EMPLOYEE.name LIKE '" + filterTextBox.Text + "%'";
                    command2.CommandText = "SELECT COUNT(*) FROM EMPLOYEE INNER JOIN  PAYSLIP ON  EMPLOYEE.employeeid = PAYSLIP.employeeid " + "WHERE EMPLOYEE.name LIKE '" + filterTextBox.Text + "%'";
                    command.ExecuteNonQuery();
                }
                else if (departmentRadioButton.Checked)
                {
                    command.CommandText = "SELECT PAYSLIP.payslipid, PAYSLIP.employeeid, EMPLOYEE.name, EMPLOYEE.position, EMPLOYEE.department, EMPLOYEE.hourlyrate, PAYSLIP.totalworkinghours, "
                    + " PAYSLIP.totalworkingdays, PAYSLIP.salary, PAYSLIP.dateissued, PAYSLIP.month, PAYSLIP.year FROM EMPLOYEE INNER JOIN PAYSLIP ON EMPLOYEE.employeeid = PAYSLIP.employeeid"
                    + " WHERE EMPLOYEE.department LIKE '" + filterTextBox.Text + "%'";
                    command2.CommandText = "SELECT COUNT(*) FROM EMPLOYEE INNER JOIN  PAYSLIP ON  EMPLOYEE.employeeid = PAYSLIP.employeeid " + "WHERE EMPLOYEE.department LIKE '" + filterTextBox.Text + "%'";
                    command.ExecuteNonQuery();
                }
                command.ExecuteNonQuery();
                string rows = command2.ExecuteScalar().ToString();
                statusLabel.Text = rows + " rows returned";
                DataTable dataTable = new DataTable();
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                {
                    dataAdapter.Fill(dataTable);
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns[0].HeaderText = "Payslip ID";
                dataGridView1.Columns[1].HeaderText = "Employee ID";
                dataGridView1.Columns[2].HeaderText = "Name";
                dataGridView1.Columns[3].HeaderText = "Position";
                dataGridView1.Columns[4].HeaderText = "Department";
                dataGridView1.Columns[5].HeaderText = "Hourly Rate";
                dataGridView1.Columns[6].HeaderText = "Total Working Hours";
                dataGridView1.Columns[7].HeaderText = "Total Working Days";
                dataGridView1.Columns[8].HeaderText = "Salary";
                dataGridView1.Columns[9].HeaderText = "Date Issued";
                dataGridView1.Columns[10].HeaderText = "Month";
                dataGridView1.Columns[11].HeaderText = "Year";
                dataGridView1.DataMember = dataTable.TableName;
                connection.Close();
            }
            catch (Exception ex)
            {
                statusLabel.Text = ex.Message;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime time = dateTimePicker1.Value;
            string month = time.Month.ToString();
            string year = time.Year.ToString();
            try
            {
                connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                MySqlCommand command2 = connection.CreateCommand();
                command.CommandText = "SELECT PAYSLIP.payslipid, PAYSLIP.employeeid, EMPLOYEE.name, EMPLOYEE.position, EMPLOYEE.department, EMPLOYEE.hourlyrate, PAYSLIP.totalworkinghours, "
                    + " PAYSLIP.totalworkingdays, PAYSLIP.salary, PAYSLIP.dateissued, PAYSLIP.month, PAYSLIP.year FROM EMPLOYEE INNER JOIN PAYSLIP ON EMPLOYEE.employeeid = PAYSLIP.employeeid"
                    + " WHERE PAYSLIP.month ='" + month + "' AND PAYSLIP.year ='" + year + "'";
                command2.CommandText = "SELECT COUNT(*) FROM EMPLOYEE INNER JOIN PAYSLIP ON EMPLOYEE.employeeid = PAYSLIP.employeeid " + " WHERE PAYSLIP.month ='" + month + "' AND PAYSLIP.year ='" + year + "'";
                command.ExecuteNonQuery();
                string rows = command2.ExecuteScalar().ToString();
                statusLabel.Text = rows + " rows returned";
                DataTable dataTable = new DataTable();
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                {
                    dataAdapter.Fill(dataTable);
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns[0].HeaderText = "Payslip ID";
                dataGridView1.Columns[1].HeaderText = "Employee ID";
                dataGridView1.Columns[2].HeaderText = "Name";
                dataGridView1.Columns[3].HeaderText = "Position";
                dataGridView1.Columns[4].HeaderText = "Department";
                dataGridView1.Columns[5].HeaderText = "Hourly Rate";
                dataGridView1.Columns[6].HeaderText = "Total Working Hours";
                dataGridView1.Columns[7].HeaderText = "Total Working Days";
                dataGridView1.Columns[8].HeaderText = "Salary";
                dataGridView1.Columns[9].HeaderText = "Date Issued";
                dataGridView1.Columns[10].HeaderText = "Month";
                dataGridView1.Columns[11].HeaderText = "Year";
                dataGridView1.DataMember = dataTable.TableName;
                connection.Close();
            }
            catch (Exception ex)
            {

                statusLabel.Text = ex.Message;
            }
        }
    }
}
