using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Windows.Compatibility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
using MySql.Data.MySqlClient;
using System.Drawing.Drawing2D;

namespace EMS
{
    public partial class Attendance : Form
    {
        private bool _dragging;
        private Point _startPoint = new Point(0, 0);
        private int _row;
        public static string connectionString = null;
        MySqlConnection connection;
        FilterInfoCollection filterinfocollection;
        VideoCaptureDevice capturedevice;
        public static string username;
        public static string employeeid;
        public static string clockin;
        public static string clockout;
        public static double workinghours;
        public static int counter;
        public static string date;
        public static string month;
        public static string year;

        public Attendance()
        {
            InitializeComponent();
            username = EmployeeDashboard.username;
            DayOfWeek day = DateTime.Now.DayOfWeek;
            TimeSpan start = new TimeSpan(07, 30, 00);
            TimeSpan end = new TimeSpan(17, 31, 00);
            TimeSpan now = DateTime.Now.TimeOfDay;
            if (day.ToString() == "Saturday" || day.ToString() == "Sunday")
            {
                displayLabel.ForeColor = Color.MistyRose;
                displayLabel.Text = "Clock In / Out Enabled on Weekdays Only";
                clockinButton.Enabled = false;
                clockoutButton.Enabled = false;
            }
            else if (now >= start && now <= end)
            {
                try
                {
                    date = DateTime.Now.ToString("d");
                    connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    MySqlCommand command2 = connection.CreateCommand();
                    command.CommandText = "SELECT employeeid FROM EMPLOYEE WHERE username='" + username + "'";
                    employeeid = command.ExecuteScalar().ToString();
                    command2.CommandText = "SELECT counter FROM ATTENDANCE WHERE employeeid = '" + employeeid + "' AND date = '" +
                    date + "'";
                    counter = (int)command2.ExecuteScalar();
                    connection.Close();
                }
                catch (NullReferenceException e)
                {
                    counter = 0;
                    statusLabel.ForeColor = Color.SpringGreen;
                    statusLabel.Text = "Please Scan Employee Badge to Clock In / Out";
                }
                catch (Exception ex)
                {
                    statusLabel.ForeColor = Color.MistyRose;
                    statusLabel.Text = ex.Message;
                }
                if (counter == 0 || counter == null)
                {
                    statusLabel.ForeColor = Color.SpringGreen;
                    statusLabel.Text = "Please Scan Employee Badge to Clock In / Out";
                    clockinButton.Enabled = true;
                    clockoutButton.Enabled = false;
                }
                else if (counter == 1)
                {
                    statusLabel.ForeColor = Color.SpringGreen;
                    statusLabel.Text = "You Have 1 Scan Attempt Remaining for Today";
                    clockinButton.Enabled = false;
                    clockoutButton.Enabled = true;
                }
                else if (counter == 2)
                {
                    statusLabel.ForeColor = Color.MistyRose;
                    statusLabel.Text = "You Have Reached Maximum Scanning Attempt for Today";
                    clockinButton.Enabled = false;
                    clockoutButton.Enabled = false;
                }
            }
            else
            {
                displayLabel.ForeColor = Color.MistyRose;
                displayLabel.Text = "Clock In / Out Enabled Between 0730 to 1730 Only";
                clockinButton.Enabled = false;
                clockoutButton.Enabled = false;
            }
            filterinfocollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterinfocollection)
            {
                cameraComboBox.Items.Add(filterInfo.Name);
            }
            cameraComboBox.SelectedIndex = 0; 
        }

        private void Attendance_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void Attendance_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void Attendance_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_dragging) return;
            var p = PointToScreen(e.Location);
            Location = new Point(p.X - this._startPoint.X, p.Y - this._startPoint.Y);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            if (capturedevice != null)
            {
                if (capturedevice.IsRunning)
                {
                    capturedevice.SignalToStop();
                    capturedevice.WaitForStop();
                }
            }
            pictureBox1.Image = null;
            EmployeeDashboard employeedashboard = new EmployeeDashboard();
            this.Hide();
            employeedashboard.ShowDialog();
            this.Close();
        }

        private void minimiseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void clockinButton_Click(object sender, EventArgs e)
        {
            TimeSpan start = new TimeSpan(07, 30, 00);
            TimeSpan end = new TimeSpan(17, 31, 00);
            TimeSpan now = DateTime.Now.TimeOfDay;
            if (now >= start && now <= end)
            {
                capturedevice = new VideoCaptureDevice(filterinfocollection[cameraComboBox.SelectedIndex].MonikerString);
                capturedevice.NewFrame += CaptureDevice_NewFrame;
                capturedevice.Start();
                timer1.Start();
            }
            else
            {
                displayLabel.ForeColor = Color.MistyRose;
                displayLabel.Text = "Clock In / Out Enabled Between 0730 to 1730 Only";
            }
                
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);
                if (result != null)
                {
                    if (result.ToString() == employeeid)
                    {
                        try
                        {
                            connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                            connection = new MySqlConnection(connectionString);
                            connection.Open();
                            MySqlCommand command = connection.CreateCommand();
                            command.CommandText = "SELECT counter FROM ATTENDANCE WHERE employeeid = '" + employeeid + "' AND date = '" +
                            date + "'";
                            counter = (int)command.ExecuteScalar();
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            statusLabel.ForeColor = Color.MistyRose;
                            statusLabel.Text = "Error Connecting to Database";
                        }
                        if (counter == 0)
                        {
                            clockin = DateTime.Now.ToString("HH:mm");
                            counter = 1;
                            date = DateTime.Now.ToString("d");
                            month = DateTime.Now.Month.ToString();
                            year = DateTime.Now.Year.ToString();
                            try
                            {
                                connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                                connection = new MySqlConnection(connectionString);
                                connection.Open();
                                MySqlCommand command = connection.CreateCommand();
                                command.CommandText = "INSERT INTO ATTENDANCE (clockin, counter, date, month, year, employeeid) VALUES ('" + clockin
                                + "', " + "'" + counter + "', " + "'" + date + "', " + "'" + month + "', " + "'" + year + "', " + "'" + employeeid + "')";
                                if (command.ExecuteNonQuery() == 1)
                                {
                                    statusLabel.ForeColor = Color.SpringGreen;
                                    statusLabel.Text = "Clock In Successful. Your Clocking Time is " + clockin + ".";
                                    clockinButton.Enabled = false;
                                    clockoutButton.Enabled = true;
                                }
                                else
                                {
                                    statusLabel.ForeColor = Color.MistyRose;
                                    statusLabel.Text = "Failed to Clock In Please Try Again";
                                    counter = 0;
                                }
                                connection.Close();
                            }
                            catch (Exception ex)
                            {
                                statusLabel.Text = ex.Message;
                            }
                        }
                    }
                    else
                    {
                        statusLabel.ForeColor = Color.MistyRose;
                        statusLabel.Text = "Please Use Your Own Employee Badge to Clock In";
                    }
                    timer1.Stop();
                    if (capturedevice.IsRunning)
                    {
                        capturedevice.SignalToStop();
                        capturedevice.WaitForStop();
                    }
                    pictureBox1.Image = null;
                }
            }
        }

        private void clockoutButton_Click(object sender, EventArgs e)
        {
            TimeSpan start = new TimeSpan(07, 30, 00);
            TimeSpan end = new TimeSpan(17, 31, 00);
            TimeSpan now = DateTime.Now.TimeOfDay;
            if (now >= start && now <= end)
            {
                capturedevice = new VideoCaptureDevice(filterinfocollection[cameraComboBox.SelectedIndex].MonikerString);
                capturedevice.NewFrame += CaptureDevice_NewFrame;
                capturedevice.Start();
                timer2.Start();
            }
            else
            {
                displayLabel.ForeColor = Color.MistyRose;
                displayLabel.Text = "Clock In / Out Enabled Between 0730 to 1730 Only";
            }
                
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);
                if (result != null)
                {
                    if (result.ToString() == employeeid)
                    {
                        date = DateTime.Now.ToString("d");
                        try
                        {
                            connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                            connection = new MySqlConnection(connectionString);
                            connection.Open();
                            MySqlCommand command = connection.CreateCommand();
                            command.CommandText = "SELECT counter FROM ATTENDANCE WHERE employeeid = '" + employeeid + "' AND date = '" +
                            date + "'";
                            counter = (int)command.ExecuteScalar();
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            statusLabel.ForeColor = Color.MistyRose;
                            statusLabel.Text = "Error Connecting to Database";
                        }
                        if (counter == 1)
                        {
                            clockout = DateTime.Now.ToString("HH:mm");
                            counter = 2;
                            month = DateTime.Now.Month.ToString();
                            DateTime timefrom, timeto;
                            if (DateTime.TryParse(clockin, out timefrom) && DateTime.TryParse(clockout, out timeto))
                            {
                                TimeSpan TS = timeto - timefrom;
                                double hour = TS.TotalHours;
                                workinghours = Math.Round(hour, 2);
                                if (workinghours >= 8.00)
                                {
                                    workinghours = 8.00;
                                }
                            }
                            try
                            {
                                connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                                connection = new MySqlConnection(connectionString);
                                connection.Open();
                                MySqlCommand command = connection.CreateCommand();
                                command.CommandText = "UPDATE ATTENDANCE SET clockout = '" + clockout + "', workinghours = '" +
                                workinghours + "', counter = '" + counter + "' WHERE employeeid = '" + employeeid + "' AND date = '"
                                + date + "'";
                                if (command.ExecuteNonQuery() == 1)
                                {
                                    statusLabel.ForeColor = Color.SpringGreen;
                                    statusLabel.Text = "Clock Out Successful. Your Clocking Time is " + clockout + ".";
                                    displayLabel.Text = "Your Working Hours for Today(" + date + ") is " + workinghours + " hours.";
                                    clockoutButton.Enabled = false;
                                    counter = 0;
                                }
                                else
                                {
                                    statusLabel.ForeColor = Color.MistyRose;
                                    statusLabel.Text = "Failed to Clock Out Please Try Again";
                                }
                                connection.Close();
                            }
                            catch (Exception ex)
                            {
                                statusLabel.Text = ex.Message;
                            }
                        }
                    }
                    else
                    {
                        statusLabel.ForeColor = Color.MistyRose;
                        statusLabel.Text = "Please Use Your Own Employee Badge to Clock Out";
                    }
                    timer2.Stop();
                    if (capturedevice.IsRunning)
                    {
                        capturedevice.SignalToStop();
                        capturedevice.WaitForStop();
                    }
                    pictureBox1.Image = null;
                }
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (capturedevice != null)
            {
                if (capturedevice.IsRunning)
                {
                    capturedevice.SignalToStop();
                    capturedevice.WaitForStop();
                }
            }
            pictureBox1.Image = null;
        }
    }
}
