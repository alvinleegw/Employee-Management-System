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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EMS
{
    public partial class Position : Form
    {
        private bool _dragging;
        private Point _startPoint = new Point(0, 0);
        private int _row;
        public static string connectionString = null;
        MySqlConnection connection;
        public static string departmentcode;
        public static string departmentname;
        public static string position;

        public Position()
        {
            InitializeComponent();
            try
            {
                connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                MySqlCommand command2= connection.CreateCommand();
                command.CommandText = "SELECT PositionInfo.positionname, DepartmentInfo.departmentname FROM POSITIONINFO INNER JOIN DEPARTMENTINFO ON " +
                "PositionInfo.departmentcode = DepartmentInfo.departmentcode";
                command2.CommandText = "SELECT departmentname FROM DEPARTMENTINFO";
                MySqlDataReader read = command2.ExecuteReader();
                while(read.Read())
                {
                    departmentComboBox.Items.Add(read[0]);
                }
                read.Close();
                DataTable dataTable = new DataTable();
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                {
                    dataAdapter.Fill(dataTable);
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns[0].HeaderText = "Position";
                dataGridView1.Columns[1].HeaderText = "Department";
                dataGridView1.DataMember = dataTable.TableName;
                connection.Close();
            }
            catch (Exception ex)
            {
                statusLabel.ForeColor = Color.MistyRose;
                statusLabel.Text = ex.Message;
            }
        }

        private void Position_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void Position_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void Position_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_dragging) return;
            var p = PointToScreen(e.Location);
            Location = new Point(p.X - this._startPoint.X, p.Y - this._startPoint.Y);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void departmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (departmentComboBox.SelectedIndex != -1)
            {
                departmentname = departmentComboBox.SelectedItem.ToString();
                try
                {
                    connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    MySqlCommand command2 = connection.CreateCommand();
                    command.CommandText = "SELECT departmentcode FROM DEPARTMENTINFO WHERE departmentname ='" + departmentname + "'";
                    departmentcode = command.ExecuteScalar().ToString();
                    command2.CommandText = "SELECT PositionInfo.positionname, DepartmentInfo.departmentname FROM POSITIONINFO INNER JOIN DEPARTMENTINFO ON " +
                    "PositionInfo.departmentcode = Departmentinfo.departmentcode WHERE PositionInfo.departmentcode ='" + departmentcode + "'";
                    DataTable dataTable = new DataTable();
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command2))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns[0].HeaderText = "Position";
                    dataGridView1.Columns[1].HeaderText = "Department";
                    dataGridView1.DataMember = dataTable.TableName;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    statusLabel.ForeColor = Color.MistyRose;
                    statusLabel.Text = ex.Message;
                }
            }
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            if (departmentComboBox.SelectedIndex == -1 || positionTextBox.Text == String.Empty)
            {
                statusLabel.ForeColor = Color.MistyRose;
                statusLabel.Text = "Please Select Department And Enter Position";
            }
            else if (positionTextBox.Text.Length < 3 || positionTextBox.Text.Length > 30)
            {
                statusLabel.ForeColor = Color.MistyRose;
                statusLabel.Text = "Position Must Be Between 3 To 30 Characters";
            }
            else
            {
                departmentname = departmentComboBox.SelectedItem.ToString();
                position = positionTextBox.Text.ToUpper();
                try
                {
                    connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    MySqlCommand command2 = connection.CreateCommand();
                    MySqlCommand command3 = connection.CreateCommand();
                    command.CommandText = "SELECT departmentcode FROM DEPARTMENTINFO WHERE departmentname ='" + departmentname + "'";
                    departmentcode = command.ExecuteScalar().ToString();
                    command2.CommandText = "INSERT INTO POSITIONINFO(positionname, departmentcode) VALUES('" + position + "', '" + departmentcode + "')";
                    if (command2.ExecuteNonQuery() == 1)
                    {
                        statusLabel.ForeColor = Color.LightGreen;
                        statusLabel.Text = "Position Successfully Added";
                        positionTextBox.Text = String.Empty;
                    }
                    command3.CommandText = "SELECT PositionInfo.positionname, DepartmentInfo.departmentname FROM POSITIONINFO INNER JOIN DEPARTMENTINFO ON " +
                    "PositionInfo.departmentcode = Departmentinfo.departmentcode WHERE PositionInfo.departmentcode ='" + departmentcode + "'";
                    DataTable dataTable = new DataTable();
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command3))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns[0].HeaderText = "Position";
                    dataGridView1.Columns[1].HeaderText = "Department";
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
                    positionTextBox.Text = row.Cells[0].Value.ToString();
                    departmentComboBox.SelectedIndex = departmentComboBox.FindStringExact(row.Cells[1].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                statusLabel.Text = ex.Message;
            }
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            if (departmentComboBox.SelectedIndex == -1 || positionTextBox.Text == String.Empty)
            {
                statusLabel.ForeColor = Color.MistyRose;
                statusLabel.Text = "Please Select Department And Enter Position";
            }
            else
            {
                try
                {
                    position = positionTextBox.Text;
                    connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    MySqlCommand command2 = connection.CreateCommand();
                    MySqlCommand command3 = connection.CreateCommand();
                    command.CommandText = "SELECT departmentcode FROM DEPARTMENTINFO WHERE departmentname ='" + departmentname + "'";
                    departmentcode = command.ExecuteScalar().ToString();
                    command2.CommandText = "DELETE FROM POSITIONINFO WHERE positionname = '" + position + "' AND departmentcode = '" + departmentcode + "'";
                    if (command2.ExecuteNonQuery() == 1)
                    {
                        statusLabel.ForeColor = Color.LightGreen;
                        statusLabel.Text = "Position Successfully Deleted";
                        positionTextBox.Text = String.Empty;
                    }
                    command3.CommandText = "SELECT PositionInfo.positionname, DepartmentInfo.departmentname FROM POSITIONINFO INNER JOIN DEPARTMENTINFO ON " +
                    "PositionInfo.departmentcode = Departmentinfo.departmentcode WHERE PositionInfo.departmentcode ='" + departmentcode + "'";
                    DataTable dataTable = new DataTable();
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command3))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns[0].HeaderText = "Position";
                    dataGridView1.Columns[1].HeaderText = "Department";
                    dataGridView1.DataMember = dataTable.TableName;
                    positionTextBox.Text = String.Empty;
                    departmentComboBox.SelectedItem = null;
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
            departmentComboBox.SelectedItem = null;
            positionTextBox.Text= String.Empty;
            statusLabel.Text = String.Empty;
        }
    }
}
