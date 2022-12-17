using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS
{
    public partial class Department : Form
    {
        private bool _dragging;
        private Point _startPoint = new Point(0, 0);
        private int _row;
        public static string connectionString = null;
        MySqlConnection connection;
        public static string departmentcode;
        public static string departmentname;

        public Department()
        {
            InitializeComponent();
            try
            {
                connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT departmentcode, departmentname FROM DEPARTMENTINFO";
                connection.Close();
                DataTable dataTable = new DataTable();
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                {
                    dataAdapter.Fill(dataTable);
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns[0].HeaderText = "Department Code";
                dataGridView1.Columns[1].HeaderText = "Department Name";
                dataGridView1.DataMember = dataTable.TableName;
            }
            catch (Exception ex)
            {
                statusLabel.ForeColor = Color.MistyRose;
                statusLabel.Text = ex.Message;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddDepartment_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void AddDepartment_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void AddDepartment_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_dragging) return;
            var p = PointToScreen(e.Location);
            Location = new Point(p.X - this._startPoint.X, p.Y - this._startPoint.Y);
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[a-zA-Z]+$");
            bool checkCode = regex.IsMatch(codeTextBox.Text);
            if (codeTextBox.Text == String.Empty || nameTextBox.Text == String.Empty)
            {
                statusLabel.ForeColor = Color.MistyRose;
                statusLabel.Text = "Please Enter Department Code and Name";
            }
            else if (codeTextBox.Text.Length != 2)
            {
                statusLabel.ForeColor = Color.MistyRose;
                statusLabel.Text = "Department Code Must Be 2 Characters Only";
            }
            else if (!checkCode)
            {
                statusLabel.ForeColor = Color.MistyRose;
                statusLabel.Text = "Department Code Must Be Alphabets Only";
            }
            else if (nameTextBox.Text.Length < 2 || nameTextBox.Text.Length > 30)
            {
                statusLabel.ForeColor = Color.MistyRose;
                statusLabel.Text = "Department Name Must Between 2 To 30 Characters Only";
            }
            else
            {
                departmentcode = codeTextBox.Text.ToUpper();
                departmentname = nameTextBox.Text.ToUpper();
                try
                {
                    connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    MySqlCommand command2 = connection.CreateCommand();
                    command.CommandText = "INSERT INTO DEPARTMENTINFO(departmentcode, departmentname) VALUES('" + departmentcode + "', '" + departmentname + "')";
                    command2.CommandText = "SELECT departmentcode, departmentname FROM DEPARTMENTINFO";
                    if (command.ExecuteNonQuery() == 1)
                    {
                        statusLabel.ForeColor = Color.LawnGreen;
                        codeTextBox.Text = String.Empty;
                        nameTextBox.Text = String.Empty;
                        statusLabel.ForeColor = Color.LawnGreen;
                        statusLabel.Text = "Department Successfully Added";
                    }
                    DataTable dataTable = new DataTable();
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command2))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns[0].HeaderText = "Department Code";
                    dataGridView1.Columns[1].HeaderText = "Department Name";
                    dataGridView1.DataMember = dataTable.TableName;
                    await Task.Delay(1500);
                    statusLabel.Text = String.Empty;
                }
                catch (Exception ex)
                {
                    statusLabel.ForeColor = Color.MistyRose;
                    statusLabel.Text = ex.Message;
                }
                connection.Close();
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    codeTextBox.Text = row.Cells[0].Value.ToString();
                    nameTextBox.Text = row.Cells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                statusLabel.Text = ex.Message;
            }
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            if (codeTextBox.Text == String.Empty || nameTextBox.Text == String.Empty)
            {
                statusLabel.ForeColor = Color.MistyRose;
                statusLabel.Text = "Please Enter Department Code and Name";
            }
            else
            {
                departmentcode = codeTextBox.Text.ToUpper();
                departmentname = nameTextBox.Text.ToUpper();
                try
                {
                    connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    MySqlCommand command2 = connection.CreateCommand();
                    command.CommandText = "DELETE FROM DEPARTMENTINFO WHERE departmentcode ='" + departmentcode + "' AND departmentname = '" + departmentname + "'";
                    command2.CommandText = "SELECT departmentcode, departmentname FROM DEPARTMENTINFO";
                    if (command.ExecuteNonQuery() == 1)
                    {
                        codeTextBox.Text = String.Empty;
                        nameTextBox.Text = String.Empty;
                        statusLabel.ForeColor = Color.LawnGreen;
                        statusLabel.Text = "Department Successfully Deleted";
                    }
                    DataTable dataTable = new DataTable();
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command2))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns[0].HeaderText = "Department Code";
                    dataGridView1.Columns[1].HeaderText = "Department Name";
                    dataGridView1.DataMember = dataTable.TableName;
                    await Task.Delay(1500);
                    statusLabel.Text = String.Empty;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    statusLabel.ForeColor = Color.MistyRose;
                    statusLabel.Text = ex.Message;
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            codeTextBox.Text = String.Empty;
            nameTextBox.Text = String.Empty;
            statusLabel.Text = String.Empty;
        }

        private void codeTextBox_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[a-zA-Z]+$");
            bool checkCode = regex.IsMatch(codeTextBox.Text);
            if (codeTextBox.Text != String.Empty)
            {
                if (codeTextBox.Text.Length != 2)
                {
                    statusLabel.ForeColor = Color.MistyRose;
                    statusLabel.Text = "Department Code Must Be 2 Characters Only";
                }
                else if (!checkCode)
                {
                    statusLabel.ForeColor = Color.MistyRose;
                    statusLabel.Text = "Department Code Must Be Alphabets Only";
                }
                else
                {
                    statusLabel.Text = String.Empty;
                }
            }
            else
            {
                if (!statusLabel.Text.Contains("Department Successfully Added") || !statusLabel.Text.Contains("Department Successfully Deleted"))
                {
                    statusLabel.ForeColor = Color.MistyRose;
                    statusLabel.Text = "Please Enter Department Code and Name";
                }
                else
                {
                    statusLabel.Text = String.Empty;
                }
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nameTextBox.Text != String.Empty)
            {
                if (nameTextBox.Text.Length < 2 || nameTextBox.Text.Length > 30)
                {
                    statusLabel.ForeColor = Color.MistyRose;
                    statusLabel.Text = "Department Name Must Between 2 To 30 Characters Only";
                }
                else
                {
                    statusLabel.Text = String.Empty;
                }
            }
            else
            {
                if (!statusLabel.Text.Contains("Department Successfully Added") || !statusLabel.Text.Contains("Department Successfully Deleted"))
                {
                    statusLabel.ForeColor = Color.MistyRose;
                    statusLabel.Text = "Please Enter Department Code and Name";
                }
                else
                {
                    statusLabel.Text = String.Empty;
                }
            }
        }
    }
}
