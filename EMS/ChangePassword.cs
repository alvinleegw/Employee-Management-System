using MySql.Data.MySqlClient;
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

namespace EMS
{
    public partial class ChangePassword : Form
    {
        private bool _dragging;
        private Point _startPoint = new Point(0, 0);
        private int _row;
        public static string connectionString = null;
        MySqlConnection connection;
        string username;

        public ChangePassword()
        {
            InitializeComponent();
            inputpasswordLabel.Enabled = false;
            passwordTextBox.Enabled = false;
            inputpassword2Label.Enabled = false;
            password2TextBox.Enabled = false;
            updateButton.Enabled = false;
            resetButton.Enabled = false;
        }

        private void ChangePassword_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void ChangePassword_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void ChangePassword_MouseMove(object sender, MouseEventArgs e)
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

        private async void searchButton_Click(object sender, EventArgs e)
        {
            username = inputTextBox.Text;
            if (username == String.Empty)
            {
                await Task.Delay(1500);
                statusLabel.ForeColor = Color.DarkRed;
                statusLabel.Text = "Please Enter Employee's Username";
            }
            else
            {
                statusLabel.ForeColor = Color.Green;
                statusLabel.Text = "Searching... Hang On Tight...";
                await Task.Delay(2500);
                try
                {
                    connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "SELECT COUNT(*) FROM EMPLOYEE WHERE username ='" + username + "'";
                    if (Convert.ToInt32(command.ExecuteScalar()) == 1)
                    {
                        statusLabel.ForeColor = Color.Green;
                        statusLabel.Text = "Username Exists";
                        inputusernameLabel.Enabled = false;
                        inputTextBox.Enabled = false;
                        searchButton.Enabled = false;
                        inputpasswordLabel.Enabled = true;
                        passwordTextBox.Enabled = true;
                        inputpassword2Label.Enabled = true;
                        password2TextBox.Enabled = true;
                        updateButton.Enabled = true;
                        resetButton.Enabled = true;
                    }
                    else
                    {
                        statusLabel.ForeColor = Color.DarkRed;
                        statusLabel.Text = "Username Not Found. Spelling Error?";
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    statusLabel.ForeColor = Color.DarkRed;
                    statusLabel.Text = ex.Message;
                }
            }
        }

        private async void enterButton_Click(object sender, EventArgs e)
        {
            string password = passwordTextBox.Text;
            string password2 = password2TextBox.Text;
            if (password == String.Empty || password2 == String.Empty)
            {
                status2Label.ForeColor = Color.DarkRed;
                status2Label.Text = "Please Enter New Password And Confirm Password";
            }
            else if (passwordTextBox.Text.Length < 8 || passwordTextBox.Text.Length < 8)
            {
                status2Label.Text = "New Password Length Must Be At Least 8 Characters";
            }
            else
            {
                string hash;
                string hash2;
                using (var md5Hash = MD5.Create())
                {
                    var sourceBytes = Encoding.UTF8.GetBytes(password);
                    var hashBytes = md5Hash.ComputeHash(sourceBytes);
                    hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);
                    var sourceBytes2 = Encoding.UTF8.GetBytes(password2);
                    var hashBytes2 = md5Hash.ComputeHash(sourceBytes2);
                    hash2 = BitConverter.ToString(hashBytes2).Replace("-", string.Empty);
                }
                if (hash != hash2)
                {

                    status2Label.ForeColor = Color.DarkRed;
                    status2Label.Text = "New Password And Confirm Password Must Be The Same";
                }
                else if (hash == hash2)
                {
                    resetButton.Enabled = false;
                    status2Label.ForeColor = Color.Green;
                    status2Label.Text = "Updating...";
                    await Task.Delay(2500);
                    try
                    {
                        connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                        connection = new MySqlConnection(connectionString);
                        connection.Open();
                        MySqlCommand command = connection.CreateCommand();
                        command.CommandText = "UPDATE EMPLOYEE SET password ='" + hash + "' WHERE username='" + username + "'";
                        if (command.ExecuteNonQuery() == 1)
                        {
                            status2Label.ForeColor = Color.Green;
                            status2Label.Text = "Password Successfully Updated For Username " + username;
                        }
                        inputusernameLabel.Enabled = true;
                        inputTextBox.Enabled = true;
                        searchButton.Enabled = true;
                        inputTextBox.Text = String.Empty;
                        inputpasswordLabel.Enabled = false;
                        passwordTextBox.Text = String.Empty;
                        passwordTextBox.Enabled = false;
                        inputpassword2Label.Enabled = false;
                        password2TextBox.Text = String.Empty;
                        password2TextBox.Enabled = false;
                        updateButton.Enabled = false;
                        resetButton.Enabled = false;
                        statusLabel.Text = String.Empty;
                        connection.Close();
                        await Task.Delay(5000);
                        status2Label.Text = String.Empty;
                    }
                    catch (Exception ex)
                    {
                        status2Label.ForeColor = Color.DarkRed;
                        status2Label.Text = ex.Message;
                    }
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            inputusernameLabel.Enabled = true;
            inputTextBox.Enabled = true;
            searchButton.Enabled = true;
            statusLabel.Text = String.Empty;
            status2Label.Text = String.Empty;
            inputTextBox.Text = String.Empty;
            inputpasswordLabel.Enabled = false;
            passwordTextBox.Text = String.Empty;
            passwordTextBox.Enabled = false;
            inputpassword2Label.Enabled = false;
            password2TextBox.Text = String.Empty;
            password2TextBox.Enabled = false;
            updateButton.Enabled = false;
            resetButton.Enabled = false;
        }
    }
}