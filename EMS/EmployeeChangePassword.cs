using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EMS
{
    public partial class EmployeeChangePassword : Form
    {
        private bool _dragging;
        private Point _startPoint = new Point(0, 0);
        private int _row;
        public static string connectionString = null;
        MySqlConnection connection;
        string username;

        public EmployeeChangePassword()
        {
            InitializeComponent();
            username = EmployeeDashboard.username;
        }

        private void EmployeeChangePassword_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void EmployeeChangePassword_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void EmployeeChangePassword_MouseMove(object sender, MouseEventArgs e)
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

        private void miniseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void updateButton_Click(object sender, EventArgs e)
        {
            string password = passwordTextBox.Text;
            string password2 = password2TextBox.Text;
            if (password == String.Empty || password2 == String.Empty)
            {
                statusLabel.ForeColor = Color.DarkRed;
                statusLabel.Text = "Please Enter New Password And Confirm Password";
            }
            else if (passwordTextBox.Text.Length < 8 || passwordTextBox.Text.Length < 8)
            {
                statusLabel.Text = "New Password Length Must Be At Least 8 Characters";
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

                    statusLabel.ForeColor = Color.DarkRed;
                    statusLabel.Text = "New Password And Confirm Password Must Be The Same";
                }
                else if (hash == hash2)
                {
                    resetButton.Enabled = false;
                    updateButton.Enabled = false;
                    passwordTextBox.Enabled = false;
                    password2TextBox.Enabled = false;
                    statusLabel.ForeColor = Color.Green;
                    statusLabel.Text = "Updating...";
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
                            statusLabel.ForeColor = Color.Green;
                            statusLabel.Text = "Password Successfully Updated";
                        }
                        passwordTextBox.Text = String.Empty;
                        password2TextBox.Text = String.Empty;
                        passwordTextBox.Enabled = true;
                        password2TextBox.Enabled = true;
                        resetButton.Enabled = true;
                        updateButton.Enabled = true;
                        connection.Close();
                        await Task.Delay(5000);
                        statusLabel.Text = String.Empty;
                    }
                    catch (Exception ex)
                    {
                        statusLabel.ForeColor = Color.DarkRed;
                        statusLabel.Text = ex.Message;
                    }
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            passwordTextBox.Text = String.Empty;
            password2TextBox.Text = String.Empty;
            statusLabel.Text = String.Empty;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordTextBox.Text != String.Empty && password2TextBox.Text != String.Empty)
            {
                if (passwordTextBox.Text.Length < 8 || password2TextBox.Text.Length < 8)
                {
                    statusLabel.ForeColor = Color.DarkRed;
                    statusLabel.Text = "New Password And Confirm Password Length Must Be At Least 8 Characters";
                }
                else if (passwordTextBox.Text != password2TextBox.Text)
                {
                    statusLabel.ForeColor = Color.DarkRed;
                    statusLabel.Text = "New Password And Confirm Password Must Be The Same";
                }
                else
                {
                    statusLabel.ForeColor = Color.Green;
                    statusLabel.Text = "New Password And Confirm Password Matched";
                }
            }
            else
            {
                if (!statusLabel.Text.Contains("Password Successfully Updated"))
                {
                    statusLabel.ForeColor = Color.DarkRed;
                    statusLabel.Text = "Please Enter New Password And Confirm Password";
                }
            }
        }

        private void password2TextBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordTextBox.Text != String.Empty && password2TextBox.Text != String.Empty)
            {
                if (passwordTextBox.Text.Length < 8 || password2TextBox.Text.Length < 8)
                {
                    statusLabel.ForeColor = Color.DarkRed;
                    statusLabel.Text = "New Password And Confirm Password Length Must Be At Least 8 Characters";
                }
                else if (passwordTextBox.Text != password2TextBox.Text)
                {
                    statusLabel.ForeColor = Color.DarkRed;
                    statusLabel.Text = "New Password And Confirm Password Must Be The Same";
                }
                else
                {
                    statusLabel.ForeColor = Color.Green;
                    statusLabel.Text = "New Password And Confirm Password Matched";
                }
            }
            else
            {
                if (!statusLabel.Text.Contains("Password Successfully Updated"))
                {
                    statusLabel.ForeColor = Color.DarkRed;
                    statusLabel.Text = "Please Enter New Password And Confirm Password";
                }
            }
        }
    }
}
