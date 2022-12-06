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
    public partial class EmployeeDashboard : Form
    {
        private bool _dragging;
        private Point _startPoint = new Point(0, 0);
        private int _row;
        public static string username;
        public static string connectionString = null;
        MySqlConnection connection;

        public EmployeeDashboard()
        {
            InitializeComponent();
            username = Login.username;
            userLabel.Text = username;
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
                command.CommandText = "SELECT employeeid FROM EMPLOYEE WHERE username ='" + username + "'";
                string employeeid = command.ExecuteScalar().ToString();
                command2.CommandText = "SELECT clockin FROM ATTENDANCE WHERE date ='" + date + "'"
                + " AND employeeid ='" + employeeid + "'";
                if (command2.ExecuteScalar() != null)
                {
                    clockinLabel.Text = command2.ExecuteScalar().ToString();
                }
                 command3.CommandText = "SELECT clockout FROM ATTENDANCE WHERE date ='" + date + "'"
                 + " AND employeeid ='" + employeeid + "'";
                if (command3.ExecuteScalar() != null)
                {
                    clockoutLabel.Text = command3.ExecuteScalar().ToString();
                }
                 command4.CommandText = "SELECT workinghours FROM ATTENDANCE WHERE date ='" + date + "'"
                 + " AND employeeid ='" + employeeid + "'";
                if (command4.ExecuteScalar() != null)
                {
                    workinghoursLabel.Text = command4.ExecuteScalar().ToString();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmployeeDashboard_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void EmployeeDashboard_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void EmployeeDashboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_dragging) return;
            var p = PointToScreen(e.Location);
            Location = new Point(p.X - this._startPoint.X, p.Y - this._startPoint.Y);
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

        private void minimiseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void clockinButton_Click(object sender, EventArgs e)
        {
            Attendance attendance = new Attendance();
            this.Hide();
            attendance.ShowDialog();
            this.Close();
        }

        private void clockoutButton_Click(object sender, EventArgs e)
        {
            Attendance attendance = new Attendance();
            this.Hide();
            attendance.ShowDialog();
            this.Close();
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            EmployeeHistory employeehistory = new EmployeeHistory();
            this.Hide();
            employeehistory.ShowDialog();
            this.Close();
        }

        private void payrollButton_Click(object sender, EventArgs e)
        {
            Payroll payroll = new Payroll();
            this.Hide();
            payroll.ShowDialog();
            this.Close();
        }

        private void changepasswordButton_Click(object sender, EventArgs e)
        {
            EmployeeChangePassword employeechangepassword = new EmployeeChangePassword();
            this.Hide();
            employeechangepassword.ShowDialog();
            this.Close();
        }
    }
}
