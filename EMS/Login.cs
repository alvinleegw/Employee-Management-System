using System.Data;
using System.Security.Cryptography;
using System.Text;
using MySql.Data.MySqlClient;

namespace EMS
{
    public partial class Login : Form
    {
        private bool _dragging;
        private Point _startPoint = new Point(0, 0);
        private int _row;
        public static string username;

        public Login()
        {
            InitializeComponent();
        }

        private async void signinButton_Click(object sender, EventArgs e)
        {
            username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string hash;
            string pass;
            if (username == "" || password == "")
            {
                statusLabel.Text = "Please enter username and password.";
            }
            else
            {
                using (var md5Hash = MD5.Create())
                {
                    var sourceBytes = Encoding.UTF8.GetBytes(password);
                    var hashBytes = md5Hash.ComputeHash(sourceBytes);
                    hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);
                }
                string connectionString = null;
                MySqlConnection connection;
                connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                connection = new MySqlConnection(connectionString);
                if (username == "admin")
                {
                    try
                    {
                        connection.Open();
                        MySqlCommand command = connection.CreateCommand();
                        command.CommandText = "SELECT password from ADMIN";
                        pass = command.ExecuteScalar().ToString();
                        if (hash == pass)
                        {
                            statusLabel.ForeColor = Color.Green;
                            statusLabel.Text = "Successfully Login";
                            signinButton.Enabled = false;
                            resetButton.Enabled = false;
                            await Task.Delay(1500);
                            statusLabel.Text = "Welcome back admin";
                            await Task.Delay(1500);
                            AdminDashboard admindashboard = new AdminDashboard();
                            this.Hide();
                            admindashboard.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            statusLabel.Text = "Invalid Username or Password";
                        }
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        statusLabel.Text = "Error Connecting to Database";
                    }
                }
                else
                {
                    try
                    {
                        connection.Open();
                        MySqlCommand command = connection.CreateCommand();
                        command.CommandText = "SELECT password from EMPLOYEE WHERE username='" + username + "'";
                        if(command.ExecuteScalar() != null)
                        {
                            pass = command.ExecuteScalar().ToString();
                            if (hash == pass)
                            {
                                statusLabel.ForeColor = Color.Green;
                                statusLabel.Text = "Successfully Login";
                                await Task.Delay(1500);
                                statusLabel.Text = "Welcome back " + username;
                            }
                            else
                            {
                                statusLabel.Text = "Invalid Username or Password";
                            }
                        }
                        else
                        {
                            statusLabel.Text = "Invalid Username or Password";
                        }
                    }
                    catch (Exception ex)
                    {
                        statusLabel.Text = "Error Connecting to Database";
                    }
                }
                
            }

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            statusLabel.Text = "";
            statusLabel.ForeColor = Color.Red;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_dragging) return;
            var p = PointToScreen(e.Location);
            Location = new Point(p.X - this._startPoint.X, p.Y - this._startPoint.Y);
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void minimiseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}