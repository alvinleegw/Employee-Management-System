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
            updateButton.Enabled = false;
            deleteButton.Enabled = false;
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
                    command.CommandText = "INSERT INTO EMPLOYEE(employeeid, username, password, name, position, email, department, hourlyrate) VALUES('" + employeeid + "','" + username + "','" + hash + "','" + name + "','" + position + "','" + email + "','" + department + "','" + hourlyrate + "')";
                    if (command.ExecuteNonQuery() == 1)
                    {
                        statusLabel.Text = "Data Inserted Successfully";
                    }
                    else
                    {
                        statusLabel.Text = "Failed to Insert Data";
                    }
                    /*command.CommandText = "SELECT * FROM EMPLOYEE";
                    command.ExecuteNonQuery();
                    DataTable dataTable = new DataTable();
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.DataMember = dataTable.TableName;*/
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
        }
    }
}
