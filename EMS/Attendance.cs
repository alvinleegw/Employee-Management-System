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
        //remember set to null later
        public static string username = "alvinleegw";
        public static string employeeid;

        public Attendance()
        {
            InitializeComponent();
            //remember to uncomment later
            //username = EmployeeDashboard.username;
            try
            {
                connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT employeeid FROM EMPLOYEE WHERE username='" + username + "'";
                employeeid = command.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Error Connecting to Database";
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
            try
            {
                if (capturedevice.IsRunning)
                {
                    capturedevice.SignalToStop();
                    capturedevice.WaitForStop();
                }
                else
                {

                }
            }
            catch (NullReferenceException ex)
            {

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
            capturedevice = new VideoCaptureDevice(filterinfocollection[cameraComboBox.SelectedIndex].MonikerString);
            capturedevice.NewFrame += CaptureDevice_NewFrame;
            capturedevice.Start();
            timer1.Start();
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
                        statusLabel.ForeColor = Color.DarkGreen;
                        statusLabel.Text = "Clock In Successful. Your Clocking Time is ";
                    }
                    else
                    {
                        statusLabel.ForeColor = Color.Red;
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
    }
}
