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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EMS
{
    public partial class Payroll : Form
    {
        private bool _dragging;
        private Point _startPoint = new Point(0, 0);
        private int _row;
        public static string connectionString = null;
        MySqlConnection connection;
        //remember unnull
        public static string username = "alvinleegw";
        public static int payslipno;
        public static string payslipid;
        public static string employeeid;
        public static decimal salary;
        public static string dateissued;
        public static string month;
        public static string name;
        public static string position;
        public static string department;
        public static int hourlyrate;
        public static int totalworkingdays;
        public static decimal totalworkinghours;

        public Payroll()
        {
            InitializeComponent();
            //remember remove comment
            //username = EmployeeDashboard.username;
            try
            {
                month = DateTime.Now.Month.ToString();
                dateissued= DateTime.Now.Date.ToString("d");
                connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                MySqlCommand command2 = connection.CreateCommand();
                MySqlCommand command3 = connection.CreateCommand();
                MySqlCommand command4= connection.CreateCommand();
                command.CommandText = "SELECT employeeid, name, position, department, hourlyrate FROM EMPLOYEE WHERE username ='"
                + username + "'";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    employeeid = reader["employeeid"].ToString();
                    name = reader["name"].ToString();
                    position = reader["position"].ToString();
                    department = reader["department"].ToString();
                    hourlyrate = (int)reader["hourlyrate"];
                }
                reader.Close();
                command2.CommandText = "SELECT COUNT(*) FROM ATTENDANCE WHERE employeeid ='" + employeeid +
                "' AND month ='" + month + "'";
                totalworkingdays = Convert.ToInt32(command2.ExecuteScalar());
                command3.CommandText = "SELECT COUNT(*) FROM PAYSLIP WHERE employeeid ='" + employeeid + "' AND month ='" + month + "'";
                if (Convert.ToInt32(command3.ExecuteScalar()) == 0)
                {
                    command4.CommandText = "SELECT SUM(workinghours) FROM ATTENDANCE WHERE employeeid ='" + employeeid + "' AND month ='" + month + "'";
                    totalworkinghours = (decimal)command4.ExecuteScalar ();
                    salary = totalworkinghours * hourlyrate;
                    command4.CommandText = "INSERT INTO PAYSLIP (salary, totalworkingdays, dateissued, month, employeeid) VALUES ('"
                    + salary + "', '" + totalworkingdays + "', '" + dateissued + "', '" + month + "', '" + employeeid + "')";
                    command4.ExecuteNonQuery();
                    command4.CommandText = "SELECT payslipno FROM PAYSLIP WHERE employeeid ='" + employeeid + "' AND month ='" + month + "'";
                    payslipno = (int)command4.ExecuteScalar();
                    payslipid = "PS" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString("D2") + payslipno.ToString("D8");
                    command4.CommandText = "UPDATE PAYSLIP SET payslipid='" + payslipid + "' WHERE employeeid ='" + employeeid + "' AND month ='" + month + "'";
                    command4.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Payroll_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void Payroll_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void Payroll_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_dragging) return;
            var p = PointToScreen(e.Location);
            Location = new Point(p.X - this._startPoint.X, p.Y - this._startPoint.Y);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            EmployeeDashboard employeedashboard= new EmployeeDashboard();
            this.Hide();
            employeedashboard.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
