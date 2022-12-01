using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        Bitmap bitmap;
        public static string connectionString = null;
        MySqlConnection connection;
        public static string username;
        public static int payslipno;
        public static string payslipid;
        public static string employeeid;
        public static decimal salary;
        public static string dateissued;
        public static string month;
        public static string year;
        public static string name;
        public static string position;
        public static string department;
        public static int hourlyrate;
        public static int totalworkingdays;
        public static decimal totalworkinghours;

        public Payroll()
        {
            InitializeComponent();
            dateTimePicker1.CustomFormat = "MM/yyyy";
            DateTime now = DateTime.Now;
            DateTime lastdayofmonth = now.AddDays(1 - now.Day).AddMonths(1).AddDays(-1).Date;
            dateTimePicker1.MaxDate = lastdayofmonth;

            username = EmployeeDashboard.username;
            if (checkLastDayOfMonth())
            {
                printButton.Enabled = true;
            }
            else
            {
                printButton.Enabled = false;
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Partial Payslip Could Be Preview Anytime but Complete Version Could Be Printed Only At the Last Day of the Month or Later";
            }
            try
            {
                month = DateTime.Now.Month.ToString();
                year = DateTime.Now.Year.ToString();
                connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                MySqlCommand command2 = connection.CreateCommand();
                MySqlCommand command3 = connection.CreateCommand();
                MySqlCommand command4= connection.CreateCommand();
                MySqlCommand command5 = connection.CreateCommand();
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
                "' AND month ='" + month + "' AND year ='" + year + "'";
                totalworkingdays = Convert.ToInt32(command2.ExecuteScalar());
                command3.CommandText = "SELECT COUNT(*) FROM PAYSLIP WHERE employeeid ='" + employeeid + "' AND month ='" + month + "' AND year ='" + year + "'";
                if (Convert.ToInt32(command3.ExecuteScalar()) == 0)
                {
                    month = DateTime.Now.Month.ToString();
                    year = DateTime.Now.Year.ToString();
                    command4.CommandText = "SELECT SUM(workinghours) FROM ATTENDANCE WHERE employeeid ='" + employeeid + "' AND month ='" + month + "' AND year ='" + year + "'";
                    string temp = command4.ExecuteScalar().ToString();
                    if (temp == String.Empty)
                    {
                        totalworkinghours = 0;
                        
                    }
                    else
                    {
                        totalworkinghours = (decimal)command4.ExecuteScalar();
                    }
                    salary = totalworkinghours * hourlyrate;
                    if (checkLastDayOfMonth())
                    {
                        dateissued = DateTime.Now.Date.ToString("d");
                        command4.CommandText = "INSERT INTO PAYSLIP (salary, totalworkinghours, totalworkingdays, dateissued, month, year, employeeid) VALUES ('"
                        + salary + "', '" + totalworkinghours + "', '" + totalworkingdays + "', '" + dateissued + "', '" + month + "', '" + year + "', '" + employeeid + "')";
                        command4.ExecuteNonQuery();
                        command4.CommandText = "SELECT payslipno FROM PAYSLIP WHERE employeeid ='" + employeeid + "' AND month ='" + month + "' AND year ='" + year + "'";
                        payslipno = (int)command4.ExecuteScalar();
                        payslipid = "PS" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString("D2") + payslipno.ToString("D8");
                        command4.CommandText = "UPDATE PAYSLIP SET payslipid='" + payslipid + "' WHERE employeeid ='" + employeeid + "' AND month ='" + month + "' AND year ='" + year + "'";
                        command4.ExecuteNonQuery();
                    }
                }
                else
                {
                    command5.CommandText = "SELECT payslipid, salary, totalworkinghours, totalworkingdays, dateissued, month, year FROM PAYSLIP WHERE employeeid ='"
                    + employeeid + "' AND month = '" + month + "' AND year = '" + year + "'";
                    MySqlDataReader reader2 = command5.ExecuteReader();
                    while (reader2.Read())
                    {
                        payslipid = reader2["payslipid"].ToString();
                        salary = (decimal)reader2["salary"];
                        totalworkinghours = (decimal)reader2["totalworkinghours"];
                        totalworkingdays = (int)reader2["totalworkingdays"];
                        dateissued = reader2["dateissued"].ToString();
                        month = reader2["month"].ToString();
                        year = reader2["year"].ToString();
                    }
                    reader2.Close();
                }
                connection.Close();
                payslipidLabel.Text = "Payslip ID: " + payslipid;
                employeeidLabel.Text = "Employee ID: " + employeeid;
                nameLabel.Text = "Name: " + name;
                positionLabel.Text = "Position: " + position;
                departmentLabel.Text = "Department: " + department;
                hourlysalaryLabel.Text = "Hourly Salary: RM" + hourlyrate.ToString();
                dateissuedLabel.Text = "Date Issued: " + dateissued;
                monthLabel.Text = "Month: " + month;
                yearLabel.Text = "Year: " + year;
                totalworkinghoursLabel.Text = "Total Working Hours: " + totalworkinghours.ToString();
                totalworkingdaysLabel.Text = "Total Working Days: " + totalworkingdays.ToString();
                totalsalaryLabel.Text = "Total Salary: RM" + salary.ToString();
            }
            catch (Exception ex)
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = ex.Message;
            }
        }

        private bool checkLastDayOfMonth()
        {
            DateTime date= DateTime.Now;
            DateTime dateto = date.Date;
            dateto = dateto.AddMonths(1);
            dateto = dateto.AddDays(-(dateto.Day));

            if (date.Date == dateto)
            {
                return true;
            }
            else
            {
                return false;
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

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            bitmap = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bitmap);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private async void printButton_Click(object sender, EventArgs e)
        {
            statusLabel.Text = String.Empty;
            selectLabel.Visible = false;
            dateTimePicker1.Visible = false;
            printButton.Visible = false;
            closeButton.Visible = false;
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            PrintDialog printDlg = new PrintDialog();
            printDlg.Document = printDocument1;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            if (printDlg.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
            selectLabel.Visible = true;
            dateTimePicker1.Visible = true;
            closeButton.Visible = true;
            printButton.Visible = true;
            statusLabel.ForeColor = Color.Green;
            statusLabel.Text = "Payslip Successfully Printed";
            await Task.Delay(1500);
            statusLabel.Text = String.Empty;
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void closeButton_Click_1(object sender, EventArgs e)
        {
            EmployeeDashboard employeedashboard = new EmployeeDashboard();
            this.Hide();
            employeedashboard.ShowDialog();
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime time = dateTimePicker1.Value;
            month = time.Month.ToString();
            year = time.Year.ToString();
            if (time.Month == DateTime.Now.Month && checkLastDayOfMonth() == false)
            {
                try
                {
                    connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    MySqlCommand command2 = connection.CreateCommand();
                    month = DateTime.Now.Month.ToString();
                    command.CommandText = "SELECT SUM(workinghours) FROM ATTENDANCE WHERE employeeid ='" + employeeid + "' AND month ='" + month + "' AND year ='" + year + "'";
                    command2.CommandText = "SELECT COUNT(*) FROM ATTENDANCE WHERE employeeid ='" + employeeid +
                    "' AND month ='" + month + "' AND year ='" + year + "'";
                    totalworkingdays = Convert.ToInt32(command2.ExecuteScalar());
                    string temp = command.ExecuteScalar().ToString();
                    if (temp == String.Empty)
                    {
                        totalworkinghours = 0;
                    }
                    else
                    {
                        totalworkinghours = (decimal)command.ExecuteScalar();
                    }
                    salary = totalworkinghours * hourlyrate;
                }
                catch (Exception ex)
                {
                    statusLabel.ForeColor = Color.Red;
                    statusLabel.Text = ex.Message;
                }
                statusLabel.Text = "Partial Payslip Could Be Preview Anytime but Complete Version Could Be Printed Only At the Last Day of the Month or Later";
                payslipidLabel.Text = "Payslip ID: ";
                dateissuedLabel.Text = "Date Issued: ";
                monthLabel.Text = "Month: " + month;
                yearLabel.Text = "Year: " + year;
                totalworkinghoursLabel.Text = "Total Working Hours: " + totalworkinghours;
                totalworkingdaysLabel.Text = "Total Working Days: " + totalworkingdays;
                totalsalaryLabel.Text = "Total Salary: RM" + salary;
            }
            else
            {
                printButton.Enabled = true;
                statusLabel.Text = String.Empty;
                try
                {
                    connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    MySqlCommand command2 = connection.CreateCommand();
                    command.CommandText = "SELECT COUNT(*) FROM PAYSLIP WHERE employeeid ='"
                    + employeeid + "' AND month = '" + month + "' AND year ='" + year + "'";
                    command2.CommandText = "SELECT payslipid, salary, totalworkinghours, totalworkingdays, dateissued, "
                    + "month, year FROM PAYSLIP WHERE employeeid ='" + employeeid + "' AND month ='" + month + "' AND year ='" + year + "'";
                    if (Convert.ToInt32(command.ExecuteScalar()) == 0)
                    {
                        payslipidLabel.Text = "Payslip ID: ";
                        dateissuedLabel.Text = "Date Issued: ";
                        monthLabel.Text = "Month: ";
                        yearLabel.Text = "Year: ";
                        totalworkinghoursLabel.Text = "Total Working Hours: ";
                        totalworkingdaysLabel.Text = "Total Working Days: ";
                        totalsalaryLabel.Text = "Total Salary: RM";
                    }
                    else
                    {
                        MySqlDataReader reader = command2.ExecuteReader();
                        while (reader.Read())
                        {
                            payslipid = reader["payslipid"].ToString();
                            salary = (decimal)reader["salary"];
                            totalworkinghours = (decimal)reader["totalworkinghours"];
                            totalworkingdays = (int)reader["totalworkingdays"];
                            dateissued = reader["dateissued"].ToString();
                            month = reader["month"].ToString();
                            year = reader["year"].ToString();
                        }
                        reader.Close();
                        payslipidLabel.Text = "Payslip ID: " + payslipid;
                        dateissuedLabel.Text = "Date Issued: " + dateissued;
                        totalworkinghoursLabel.Text = "Total Working Hours: " + totalworkinghours.ToString();
                        totalworkingdaysLabel.Text = "Total Working Days: " + totalworkingdays.ToString();
                        totalsalaryLabel.Text = "Total Salary: RM" + salary.ToString();
                    }
                    connection.Close();
                    employeeidLabel.Text = "Employee ID: " + employeeid;
                    nameLabel.Text = "Name: " + name;
                    positionLabel.Text = "Position: " + position;
                    departmentLabel.Text = "Department: " + department;
                    hourlysalaryLabel.Text = "Hourly Salary: RM" + hourlyrate.ToString();
                    monthLabel.Text = "Month: " + month;
                    yearLabel.Text = "Year: " + year;
                }
                catch (Exception ex)
                {
                    statusLabel.ForeColor = Color.Red;
                    statusLabel.Text = ex.Message;
                }
            }
        }
    }
}
