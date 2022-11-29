using MySql.Data.MySqlClient;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using MySqlX.XDevAPI.Relational;

namespace EMS
{
    public partial class Manage : Form
    {
        public static string connectionString = null;
        MySqlConnection connection;
        public static string employeeid;
        public static string username;
        public static string password;
        public static string name;
        public static string position;
        public static string email;
        public static string department;
        public static int hourlyrate;

        public Manage()
        {
            InitializeComponent();
            try
            {
                connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                MySqlCommand command2 = connection.CreateCommand();
                command.CommandText = "SELECT employeeid, username, name, position, email, department, hourlyrate FROM EMPLOYEE";
                command2.CommandText = "SELECT COUNT(*) FROM EMPLOYEE ";
                command.ExecuteNonQuery();
                string rows = command2.ExecuteScalar().ToString();
                resultLabel.Text = rows + " rows returned";
                DataTable dataTable = new DataTable();
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                {
                    dataAdapter.Fill(dataTable);
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.DataMember = dataTable.TableName;
            }
            catch (Exception ex)
            {
                statusLabel.Text = ex.Message;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            AdminDashboard dashboard = new AdminDashboard();
            this.Hide();
            dashboard.ShowDialog();
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",RegexOptions.CultureInvariant | RegexOptions.Singleline);
            bool isValidEmail = regex.IsMatch(emailTextBox.Text);
            if (employeeidTextBox.Text == String.Empty || usernameTextBox.Text == String.Empty 
            || passwordTextBox.Text == String.Empty || nameTextBox.Text == String.Empty 
            || positionTextBox.Text == String.Empty || emailTextBox.Text == String.Empty 
            || departmentTextBox.Text == String.Empty)
            {
                statusLabel.Text = "Fields must not be empty";
            }
            else if (employeeidTextBox.Text.Length != 5)
            {
                statusLabel.Text = "Employee ID length must be 5 characters only";
            }
            else if (passwordTextBox.Text.Length < 8)
            {
                statusLabel.Text = "Password length must be at least 8 characters";
            }
            else if (!isValidEmail)
            {
                statusLabel.Text = "Please enter a valid email address";
            }
            else
            {
                employeeid = employeeidTextBox.Text;
                username = usernameTextBox.Text;
                password = passwordTextBox.Text;
                string hash;
                using (var md5Hash = MD5.Create())
                {
                    var sourceBytes = Encoding.UTF8.GetBytes(password);
                    var hashBytes = md5Hash.ComputeHash(sourceBytes);
                    hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);
                }
                name = nameTextBox.Text;
                position = positionTextBox.Text;
                email = emailTextBox.Text;
                department = departmentTextBox.Text;
                hourlyrate = (int)numericUpDown1.Value;
                try
                {
                    connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO EMPLOYEE(employeeid, username, password, name, position, " +
                    "email, department, hourlyrate) VALUES('" + employeeid + "','" + username + "','" + hash + "','" 
                    + name + "','" + position + "','" + email + "','" + department + "','" + hourlyrate + "')";
                    if (command.ExecuteNonQuery() == 1)
                    {
                        statusLabel.Text = "Data Inserted Successfully";
                        employeeidTextBox.Text = String.Empty;
                        usernameTextBox.Text = String.Empty;
                        passwordTextBox.Text = String.Empty;
                        nameTextBox.Text = String.Empty;
                        positionTextBox.Text = String.Empty;
                        emailTextBox.Text = String.Empty;
                        departmentTextBox.Text = String.Empty;
                        numericUpDown1.Value = 1;
                    }
                    else
                    {
                        statusLabel.Text = "Failed to Insert Data";
                    }
                    command.CommandText = "SELECT employeeid, username, name, position, email, department, hourlyrate FROM EMPLOYEE";
                    command.ExecuteNonQuery();
                    DataTable dataTable = new DataTable();
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.DataMember = dataTable.TableName;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    statusLabel.Text = ex.Message;
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            employeeidTextBox.Text = String.Empty;
            usernameTextBox.Text = String.Empty;
            passwordTextBox.Text = String.Empty;
            nameTextBox.Text = String.Empty;
            positionTextBox.Text = String.Empty;
            emailTextBox.Text = String.Empty;
            departmentTextBox.Text = String.Empty;
            numericUpDown1.Value = 1;
            statusLabel.Text = String.Empty;
            resultLabel.Text = String.Empty;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                employeeidTextBox.Text = row.Cells[0].Value.ToString();
                usernameTextBox.Text = row.Cells[1].Value.ToString();
                nameTextBox.Text = row.Cells[2].Value.ToString();
                positionTextBox.Text = row.Cells[3].Value.ToString();
                emailTextBox.Text = row.Cells[4].Value.ToString();
                departmentTextBox.Text = row.Cells[5].Value.ToString();
                numericUpDown1.Value = (int)row.Cells[6].Value;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            employeeid = employeeidTextBox.Text;
            username = usernameTextBox.Text;
            name = nameTextBox.Text;
            position = positionTextBox.Text;
            email = emailTextBox.Text;
            department = departmentTextBox.Text;
            hourlyrate = (int)numericUpDown1.Value;
            if (employeeidTextBox.Text == String.Empty || usernameTextBox.Text == String.Empty
            || nameTextBox.Text == String.Empty || positionTextBox.Text == String.Empty 
            || emailTextBox.Text == String.Empty || departmentTextBox.Text == String.Empty)
            {
                statusLabel.Text = "Fields Except Password Field Must Not Be Empty";
            }
            else
            {
                try
                {

                    connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "UPDATE EMPLOYEE SET employeeid = '" + employeeid + "', username = '" + username
                    + "', name = '" + name + "', position = '" + position + "', email = '" + email + "', department = '"
                    + department + "', hourlyrate = '" + hourlyrate + "' WHERE employeeid = '" + employeeid + "'";
                    if (command.ExecuteNonQuery() == 1)
                    {
                        statusLabel.Text = "Data Updated Successfully";
                    }
                    else
                    {
                        statusLabel.Text = "Failed to Update Data";
                    }
                    command.CommandText = "SELECT employeeid, username, name, position, email, department, hourlyrate FROM EMPLOYEE";
                    command.ExecuteNonQuery();
                    DataTable dataTable = new DataTable();
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.DataMember = dataTable.TableName;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    statusLabel.Text = ex.Message;
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            employeeid = employeeidTextBox.Text;
            if (employeeid == String.Empty)
            {
                statusLabel.Text = "Please Fill In Employee ID";
            }
            else
            {
                try
                {
                    connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "DELETE FROM EMPLOYEE WHERE employeeid = '" + employeeid + "'";
                    if (command.ExecuteNonQuery() == 1)
                    {
                        statusLabel.Text = "Data Deleted Successfully";
                        employeeidTextBox.Text = String.Empty;
                        usernameTextBox.Text = String.Empty;
                        passwordTextBox.Text = String.Empty;
                        nameTextBox.Text = String.Empty;
                        positionTextBox.Text = String.Empty;
                        emailTextBox.Text = String.Empty;
                        departmentTextBox.Text = String.Empty;
                        numericUpDown1.Value = 1;
                    }
                    else
                    {
                        statusLabel.Text = "Failed to Delete Data";
                    }
                    command.CommandText = "SELECT employeeid, username, name, position, email, department, hourlyrate FROM EMPLOYEE";
                    command.ExecuteNonQuery();
                    DataTable dataTable = new DataTable();
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.DataMember = dataTable.TableName;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    statusLabel.Text = ex.Message;
                }
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
                    command.CommandText = "SELECT employeeid, username, name, position, email, department, hourlyrate FROM EMPLOYEE " +
                    "WHERE employeeid LIKE '" + filterTextBox.Text + "%'";
                    command2.CommandText = "SELECT COUNT(*) FROM EMPLOYEE " + "WHERE employeeid LIKE '" + filterTextBox.Text + "%'";
                }
                if (nameRadioButton.Checked)
                {
                    command.CommandText = "SELECT employeeid, username, name, position, email, department, hourlyrate FROM EMPLOYEE " +
                    "WHERE name LIKE '" + filterTextBox.Text + "%'";
                    command2.CommandText = "SELECT COUNT(*) FROM EMPLOYEE " + "WHERE name LIKE '" + filterTextBox.Text + "%'";
                }
                if (positionRadioButton.Checked)
                {
                    command.CommandText = "SELECT employeeid, username, name, position, email, department, hourlyrate FROM EMPLOYEE " +
                    "WHERE position LIKE '" + filterTextBox.Text + "%'";
                    command2.CommandText = "SELECT COUNT(*) FROM EMPLOYEE " + "WHERE position LIKE '" + filterTextBox.Text + "%'";
                }
                if (departmentRadioButton.Checked)
                {
                    command.CommandText = "SELECT employeeid, username, name, position, email, department, hourlyrate FROM EMPLOYEE " +
                    "WHERE department LIKE '" + filterTextBox.Text + "%'";
                    command2.CommandText = "SELECT COUNT(*) FROM EMPLOYEE " + "WHERE department LIKE '" + filterTextBox.Text + "%'";
                }
                command.ExecuteNonQuery();
                string rows = command2.ExecuteScalar().ToString();
                resultLabel.Text = rows + " rows returned";
                DataTable dataTable = new DataTable();
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                {
                    dataAdapter.Fill(dataTable);
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.DataMember = dataTable.TableName;
                connection.Close();
            }
            catch (Exception ex)
            {
                statusLabel.Text = ex.Message;
            }
        }

        private void allRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                MySqlCommand command2 = connection.CreateCommand();
                if (allRadioButton.Checked)
                {
                    command.CommandText = "SELECT employeeid, username, name, position, email, department, hourlyrate FROM EMPLOYEE";
                    command2.CommandText = "SELECT COUNT(*) FROM EMPLOYEE ";
                }
                command.ExecuteNonQuery();
                string rows = command2.ExecuteScalar().ToString();
                resultLabel.Text = rows + " rows returned";
                DataTable dataTable = new DataTable();
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                {
                    dataAdapter.Fill(dataTable);
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.DataMember = dataTable.TableName;
                connection.Close();
            }
            catch (Exception ex)
            {
                statusLabel.Text = ex.Message;
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                var csv = new System.Text.StringBuilder();
                var header = string.Format("{0},{1},{2},{3},{4},{5},{6}", "Employee ID", "Username", "Name", "Position", "Email", "Department", "Hourly Rate");
                csv.AppendLine(header);
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    var newLine = string.Format("{0},{1},{2},{3},{4},{5},{6}", row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value, row.Cells[4].Value, row.Cells[5].Value, row.Cells[6].Value);
                    csv.AppendLine(newLine);
                }
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Export Data";
                saveFileDialog.Filter = "CSV file(*.csv)|*.csv";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, csv.ToString());
                    statusLabel.Text = "Data Successfully Exported";
                }
            }
            catch (Exception ex)
            {
                statusLabel.Text = ex.Message;
            }
        }
    }
}
