using System.Data;
using System.Security.Cryptography;
using System.Text;
using MySql.Data.MySqlClient;

namespace EMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string hash;
            string pass;
            if (username == "" || password == "")
            {
                errorLabel.Text = "Please enter username and password.";
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
                            MessageBox.Show("Welcome Back Admin");
                        }
                        else
                        {
                            MessageBox.Show("Invalid Password");
                        }
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Can not open connection!");
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
                                errorLabel.ForeColor = Color.Green;
                                errorLabel.Text = "Successfully Login.";
                                MessageBox.Show("Welcome back " + username);
                            }
                            else
                            {
                                errorLabel.Text = "Invalid Password";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Possible Empty Table or Connection Error.");
                    }
                }
                
            }

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            errorLabel.Text = "";
        }
    }
}