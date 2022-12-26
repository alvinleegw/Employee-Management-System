using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EMS
{
    public partial class Leave : Form
    {
        private bool _dragging;
        private Point _startPoint = new Point(0, 0);
        private int _row;
        string connectionString = null;
        MySqlConnection connection;
        public static string username;
        public static string employeeid;
        public static string name;
        public static string position;
        public static string department;
        public static string dateapplied;
        public static string leavetype;
        public static string description;
        public static string document;
        public static string startdate;
        public static string enddate;
        public static string month;
        public static string year;

        public Leave()
        {
            InitializeComponent();
            username = EmployeeDashboard.username;
            monthCalendar1.MinDate = DateTime.Now;
            monthCalendar2.MinDate = DateTime.Now;
            try
            {
                connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT employeeid, name, position, department FROM EMPLOYEE WHERE username ='" + username + "'";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    employeeid = reader["employeeid"].ToString();
                    name = reader["name"].ToString();
                    position = reader["position"].ToString();
                    department = reader["department"].ToString();
                }
                reader.Close();
                employeeidTextBox.Text = employeeid;
                nameTextBox.Text = name;
                positionTextBox.Text = position;
                departmentTextBox.Text = department;
                dateappliedTextBox.Text = DateTime.Now.ToString("d");
                connection.Close();
            }
            catch (Exception ex)
            {
                statusLabel.Text= ex.Message;
            }
        }

        private void Leave_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void Leave_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void Leave_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_dragging) return;
            var p = PointToScreen(e.Location);
            Location = new Point(p.X - this._startPoint.X, p.Y - this._startPoint.Y);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            EmployeeDashboard employeeDashboard = new EmployeeDashboard();
            this.Hide();
            employeeDashboard.ShowDialog();
            this.Close();
        }

        private void minimiseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C://Desktop";
            openFileDialog1.Title = "Select File";
            openFileDialog1.Filter = "PNG Files(*.png)|*.png|JPEG Files(*.jpg)|*.jpg|PDF Files(*.pdf)|*.pdf|Word Files(*.docx)|*.docx";
            openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        string path = Path.GetFileName(openFileDialog1.FileName);
                        if (path.Length > 25)
                        {
                            statusLabel.ForeColor = Color.Red;
                            statusLabel.Text = "Maximum Characters For Document Name is 25 Characters Only";
                        }
                        else
                        {
                            statusLabel.Text = String.Empty;
                            documentLabel.Text = path;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                statusLabel.Text = ex.Message;
            }
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            int length = descriptionTextBox.Text.Length;
            if (statusLabel.Text.Contains("Leave Application Submitted Sucessfully Please Check Apply Status Later"))
            {
                wordcountLabel.Text = "100 characters remaining";
            }
            else if (length <= 100)
            {
                wordcountLabel.Text = (100 - length).ToString() + " characters remaining";
                statusLabel.Text = String.Empty;
            }
            else if (length > 100)
            {
                wordcountLabel.Text = "0 characters remaining";
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Maximum Characters for Description is 100 Characters";
            }
        }

        private async void submitButton_Click_1(object sender, EventArgs e)
        {
            DayOfWeek startday = monthCalendar1.SelectionRange.Start.DayOfWeek;
            DayOfWeek endday = monthCalendar2.SelectionRange.Start.DayOfWeek;
            if (leaveComboBox.SelectedItem == null)
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Please Select Leave Type";
            }
            else if (startday == DayOfWeek.Saturday || startday == DayOfWeek.Sunday)
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Starting Date Should Not Be On Weekends";
            }
            else if (endday == DayOfWeek.Saturday || endday == DayOfWeek.Sunday)
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Ending Date Should Not Be On Weekends";
            }
            else if (monthCalendar1.SelectionRange.Start > monthCalendar2.SelectionRange.Start)
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Starting Date Should Not Exceeds Ending Date";
            }
            else if (descriptionTextBox.Text.Length > 100)
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Maximum Characters for Description is 100 Characters";
            }
            else
            {
                statusLabel.Text = String.Empty;
                employeeid = employeeidTextBox.Text;
                dateapplied = dateappliedTextBox.Text;
                document = documentLabel.Text;
                leavetype = leaveComboBox.SelectedItem.ToString();
                description = descriptionTextBox.Text;
                startdate = monthCalendar1.SelectionRange.Start.ToString("d");
                enddate = monthCalendar2.SelectionRange.Start.ToString("d");
                month = DateTime.Now.Month.ToString();
                year = DateTime.Now.Year.ToString();
                if (document == String.Empty)
                {
                    try
                    {
                        connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                        connection = new MySqlConnection(connectionString);
                        connection.Open();
                        MySqlCommand command = connection.CreateCommand();
                        command.CommandText = "INSERT INTO LEAVEREQUEST(leavetype, description, startdate, enddate, dateapplied, month, year, employeeid) VALUES('"
                        + leavetype + "', '" + description + "', '" + startdate + "', '" + enddate + "', '" + dateapplied + "', '" + month + "', '" + year + "', '" + employeeid + "')";
                        if (command.ExecuteNonQuery() == 1)
                        {
                            monthCalendar1.SetDate(DateTime.Now);
                            monthCalendar2.SetDate(DateTime.Now);
                            statusLabel.ForeColor = Color.Green;
                            statusLabel.Text = "Leave Application Submitted Sucessfully Please Check Apply Status Later";
                            leaveComboBox.SelectedItem = null;
                            descriptionTextBox.Text = String.Empty;
                            documentLabel.Text = String.Empty;
                            openFileDialog1.FileName = null;
                            await Task.Delay(1500);
                            statusLabel.Text = String.Empty;
                        }
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        statusLabel.ForeColor = Color.Red;
                        statusLabel.Text = ex.Message;
                    }
                }
                else
                {
                    try
                    {
                        connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                        connection = new MySqlConnection(connectionString);
                        connection.Open();
                        FileStream filestream = File.OpenRead(openFileDialog1.FileName);
                        byte[] contents = new byte[filestream.Length];
                        filestream.Read(contents, 0, (int)filestream.Length);
                        filestream.Close();
                        MySqlCommand command = connection.CreateCommand();
                        command.CommandText = "INSERT INTO LEAVEREQUEST(leavetype, description, documentname, document, startdate, enddate, dateapplied, month, year, employeeid) VALUES('"
                        + leavetype + "', '" + description + "', '" + document + "', @document, '" + startdate + "', '" + enddate + "', '" + dateapplied + "', '" + month + "', '" + year + "', '" + employeeid + "')";
                        command.Parameters.AddWithValue("@document", contents);
                        if (command.ExecuteNonQuery() == 1)
                        {
                            monthCalendar1.SetDate(DateTime.Now);
                            monthCalendar2.SetDate(DateTime.Now);
                            statusLabel.ForeColor = Color.Green;
                            statusLabel.Text = "Leave Application Submitted Sucessfully Please Check Apply Status Later";
                            leaveComboBox.SelectedItem = null;
                            descriptionTextBox.Text = String.Empty;
                            documentLabel.Text = String.Empty;
                            openFileDialog1.FileName = null;
                            await Task.Delay(2500);
                            statusLabel.Text = String.Empty;
                        }
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        statusLabel.ForeColor = Color.Red;
                        statusLabel.Text = ex.Message;
                    }
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            leaveComboBox.SelectedItem = null;
            descriptionTextBox.Text = String.Empty;
            documentLabel.Text = String.Empty;
            openFileDialog1.FileName = null;
            monthCalendar1.SetDate(DateTime.Now);
            monthCalendar2.SetDate(DateTime.Now);
            statusLabel.Text = String.Empty;
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            DayOfWeek endday = monthCalendar2.SelectionRange.Start.DayOfWeek;
            if (endday == DayOfWeek.Saturday || endday == DayOfWeek.Sunday)
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Ending Date Should Not Be On Weekends";
            }
            else if (monthCalendar1.SelectionRange.Start > monthCalendar2.SelectionRange.Start)
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Starting Date Should Not Exceeds Ending Date";
            }
            else if (statusLabel.Text.Contains("Leave Application Submitted Sucessfully Please Check Apply Status Later"))
            {
                statusLabel.Text = String.Empty;
            }
            else
            {
                statusLabel.Text = String.Empty;
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DayOfWeek startday = monthCalendar1.SelectionRange.Start.DayOfWeek;
            if (startday == DayOfWeek.Saturday || startday == DayOfWeek.Sunday)
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Starting Date Should Not Be On Weekends";
            }
            else if (monthCalendar1.SelectionRange.Start > monthCalendar2.SelectionRange.Start)
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Starting Date Should Not Exceeds Ending Date";
            }
            else if (statusLabel.Text.Contains("Leave Application Submitted Sucessfully Please Check Apply Status Later"))
            {
                statusLabel.Text = String.Empty;
            }
            else
            {
                statusLabel.Text = String.Empty;
            }
        }
    }
}
