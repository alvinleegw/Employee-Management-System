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

        public EmployeeDashboard()
        {
            InitializeComponent();
            username = Login.username;
            userLabel.Text = username;
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
            this.Close();
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
    }
}
