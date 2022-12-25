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
    public partial class AdminDashboard : Form
    {
        private bool _dragging;
        private Point _startPoint = new Point(0, 0);
        private int _row;
        public static string connectionString = null;
        MySqlConnection connection;

        public AdminDashboard()
        {
            InitializeComponent();
            userLabel.Text = Login.username;
            try
            {
                string date = DateTime.Now.ToString("d");
                connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                MySqlCommand command2 = connection.CreateCommand();
                MySqlCommand command3 = connection.CreateCommand();
                MySqlCommand command4 = connection.CreateCommand();
                MySqlCommand command5 = connection.CreateCommand();
                command.CommandText = "SELECT COUNT(*) FROM EMPLOYEE";
                employeeLabel.Text = command.ExecuteScalar().ToString();
                command2.CommandText = "SELECT COUNT(*) FROM ATTENDANCE WHERE counter != 0 AND date ='" + date +"' AND status IS NULL";
                clockinLabel.Text= command2.ExecuteScalar().ToString();
                command3.CommandText = "SELECT COUNT(*) FROM ATTENDANCE WHERE counter = 2 AND date ='" + date + "' AND status IS NULL";
                clockoutLabel.Text = command3.ExecuteScalar().ToString();
                command4.CommandText = "SELECT COUNT(*) FROM LEAVEREQUEST WHERE status = 'PENDING'";
                pendingLabel.Text = command4.ExecuteScalar().ToString();
                command5.CommandText = "SELECT COUNT(*) FROM ATTENDANCE WHERE date ='" + date + "' AND status = 'LEAVE'";
                leaveLabel.Text = command5.ExecuteScalar().ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
                userLabel.Text = "";
                Login.username = "";
                this.Close();
            }
        }

        private void manageButton_Click(object sender, EventArgs e)
        { 
            Manage manage = new Manage();
            this.Hide();
            manage.ShowDialog();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
                userLabel.Text = "";
                Login.username = "";
                this.Close();
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AdminDashboard_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void AdminDashboard_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void AdminDashboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_dragging) return;
            var p = PointToScreen(e.Location);
            Location = new Point(p.X - this._startPoint.X, p.Y - this._startPoint.Y);
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            History history = new History();
            this.Hide();
            history.ShowDialog();
            this.Close();
        }

        private void changepasswordButton_Click(object sender, EventArgs e)
        {
            ChangePassword changepassword = new ChangePassword();
            this.Hide();
            changepassword.ShowDialog();
            this.Close();
        }

        private void archiveButton_Click(object sender, EventArgs e)
        {
            Archive archive = new Archive();
            this.Hide();
            archive.ShowDialog();
            this.Close();
        }

        private void payrollButton_Click(object sender, EventArgs e)
        {
            AdminPayroll adminpayroll = new AdminPayroll();
            this.Hide();
            adminpayroll.ShowDialog();
            this.Close();
        }

        private void leaveButton_Click(object sender, EventArgs e)
        {
            AdminLeave adminleave = new AdminLeave();
            this.Hide();
            adminleave.ShowDialog();
            this.Close();
        }
    }
}
