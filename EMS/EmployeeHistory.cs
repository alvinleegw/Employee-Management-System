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
    public partial class EmployeeHistory : Form
    {
        private bool _dragging;
        private Point _startPoint = new Point(0, 0);
        private int _row;
        public static string connectionString = null;
        MySqlConnection connection;
        //remember unnull
        public static string username = "alvinleegw";
        public static string employeeid;

        public EmployeeHistory()
        {
            InitializeComponent();
            //remember uncomment
            //username = EmployeeDashboard.username;
            try
            {
                connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                MySqlCommand command2 = connection.CreateCommand();
                command.CommandText = "SELECT employeeid FROM EMPLOYEE WHERE username='" + username + "'";
                employeeid = command.ExecuteScalar().ToString();
                command2.CommandText = "SELECT clockin, clockout, workinghours, date, month FROM ATTENDANCE WHERE employeeid = '" 
                + employeeid + "'";
                command2.ExecuteNonQuery();
                DataTable dataTable = new DataTable();
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command2))
                {
                    dataAdapter.Fill(dataTable);
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.DataMember = dataTable.TableName;
                connection.Close();
            }
            catch (Exception ex)
            {
                resultLabel.Text = ex.Message;
            }
        }

        private void EmployeeHistory_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void EmployeeHistory_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void EmployeeHistory_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_dragging) return;
            var p = PointToScreen(e.Location);
            Location = new Point(p.X - this._startPoint.X, p.Y - this._startPoint.Y);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            EmployeeDashboard employeedashboard = new EmployeeDashboard();
            this.Hide();
            employeedashboard.ShowDialog();
            this.Close();
        }

        private void minimiseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string month = monthComboBox.SelectedItem.ToString();
            MessageBox.Show(month);
        }
    }
}
