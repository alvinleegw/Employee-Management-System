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
    public partial class Archive : Form
    {
        private bool _dragging;
        private Point _startPoint = new Point(0, 0);
        private int _row;
        public static string connectionString = null;
        MySqlConnection connection;

        public Archive()
        {
            InitializeComponent();
            searchButton.Enabled = false;
            filterTextBox.Enabled = false;
            try
            {
                connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT employeeid, name, ic, dateofbirth, age, mobileno, email, addressline1, addressline2, addressline3, postcode, district, "
                + "state, datejoined, dateleft, position, department, hourlyrate FROM ARCHIVE";
                command.ExecuteNonQuery();
                DataTable dataTable = new DataTable();
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                {
                    dataAdapter.Fill(dataTable);
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns[0].HeaderText = "Employee ID";
                dataGridView1.Columns[1].HeaderText = "Name";
                dataGridView1.Columns[2].HeaderText = "IC";
                dataGridView1.Columns[3].HeaderText = "Date of Birth";
                dataGridView1.Columns[4].HeaderText = "Age";
                dataGridView1.Columns[5].HeaderText = "Mobile No";
                dataGridView1.Columns[6].HeaderText = "Email";
                dataGridView1.Columns[7].HeaderText = "Address Line 1";
                dataGridView1.Columns[8].HeaderText = "Address Line 2";
                dataGridView1.Columns[9].HeaderText = "Address Line 3";
                dataGridView1.Columns[10].HeaderText = "Postcode";
                dataGridView1.Columns[11].HeaderText = "District";
                dataGridView1.Columns[12].HeaderText = "State";
                dataGridView1.Columns[13].HeaderText = "Date Joined";
                dataGridView1.Columns[14].HeaderText = "Date Left";
                dataGridView1.Columns[15].HeaderText = "Position";
                dataGridView1.Columns[16].HeaderText = "Department";
                dataGridView1.Columns[17].HeaderText = "Hourly Rate";
                dataGridView1.DataMember = dataTable.TableName;
                connection.Close();
            }
            catch (Exception ex)
            {
                statusLabel.Text = ex.Message;
            }
        }

        private void Archive_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void Archive_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void Archive_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_dragging) return;
            var p = PointToScreen(e.Location);
            Location = new Point(p.X - this._startPoint.X, p.Y - this._startPoint.Y);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            AdminDashboard admindashboard = new AdminDashboard();
            this.Hide();
            admindashboard.ShowDialog();
            this.Close();
        }

        private void minimiseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                string ic; ;
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    employeeidTextBox.Text = row.Cells[0].Value.ToString();
                    nameTextBox.Text = row.Cells[1].Value.ToString();
                    ic = row.Cells[2].Value.ToString();
                    icTextBox.Text = row.Cells[2].Value.ToString();
                    dobTextBox.Text = row.Cells[3].Value.ToString();
                    ageTextBox.Text = row.Cells[4].Value.ToString();
                    phoneTextBox.Text = row.Cells[5].Value.ToString();
                    emailTextBox.Text = row.Cells[6].Value.ToString();
                    address1TextBox.Text = row.Cells[7].Value.ToString();
                    address2TextBox.Text = row.Cells[8].Value.ToString();
                    address3TextBox.Text = row.Cells[9].Value.ToString();
                    postcodeTextBox.Text = row.Cells[10].Value.ToString();
                    districtTextBox.Text = row.Cells[11].Value.ToString();
                    stateTextBox.Text = row.Cells[12].Value.ToString();
                    datejoinedTextBox.Text = row.Cells[13].Value.ToString();
                    dateleftTextBox.Text = row.Cells[14].Value.ToString();
                    positionTextBox.Text = row.Cells[15].Value.ToString();
                    departmentTextBox.Text = row.Cells[16].Value.ToString();
                    hourlyrateTextBox.Text = row.Cells[17].Value.ToString();
                    connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "SELECT portrait FROM ARCHIVE WHERE ic ='" + ic + "'";
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                    DataSet dataset = new DataSet();
                    dataAdapter.Fill(dataset);
                    if (dataset.Tables[0].Rows.Count > 0)
                    {
                        MemoryStream ms = new MemoryStream((byte[])dataset.Tables[0].Rows[0]["portrait"]);
                        pictureBox1.Image = new Bitmap(ms);
                    }
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                statusLabel.Text = ex.Message;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (employeeidTextBox.Text == String.Empty)
            {
                statusLabel.Text = "Fields Must Not Be Empty";
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record? You cannot undo this action.", "Delete Record Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                        connection = new MySqlConnection(connectionString);
                        connection.Open();
                        MySqlCommand command = connection.CreateCommand();
                        command.CommandText = "DELETE FROM ARCHIVE WHERE ic ='" + icTextBox.Text + "'";
                        if (command.ExecuteNonQuery() == 1)
                        {
                            statusLabel.Text = "Archived Data Successfully Deleted";
                        }
                        MySqlCommand command2 = connection.CreateCommand();
                        command2.CommandText = "SELECT employeeid, name, ic, dateofbirth, age, mobileno, email, addressline1, addressline2, addressline3, postcode, district, "
                        + "state, datejoined, dateleft, position, department, hourlyrate FROM ARCHIVE";
                        command2.ExecuteNonQuery();
                        DataTable dataTable = new DataTable();
                        using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command2))
                        {
                            dataAdapter.Fill(dataTable);
                        }
                        dataGridView1.DataSource = dataTable;
                        dataGridView1.Columns[0].HeaderText = "Employee ID";
                        dataGridView1.Columns[1].HeaderText = "Name";
                        dataGridView1.Columns[2].HeaderText = "IC";
                        dataGridView1.Columns[3].HeaderText = "Date of Birth";
                        dataGridView1.Columns[4].HeaderText = "Age";
                        dataGridView1.Columns[5].HeaderText = "Mobile No";
                        dataGridView1.Columns[6].HeaderText = "Email";
                        dataGridView1.Columns[7].HeaderText = "Address Line 1";
                        dataGridView1.Columns[8].HeaderText = "Address Line 2";
                        dataGridView1.Columns[9].HeaderText = "Address Line 3";
                        dataGridView1.Columns[10].HeaderText = "Postcode";
                        dataGridView1.Columns[11].HeaderText = "District";
                        dataGridView1.Columns[12].HeaderText = "State";
                        dataGridView1.Columns[13].HeaderText = "Date Joined";
                        dataGridView1.Columns[14].HeaderText = "Date Left";
                        dataGridView1.Columns[15].HeaderText = "Position";
                        dataGridView1.Columns[16].HeaderText = "Department";
                        dataGridView1.Columns[17].HeaderText = "Hourly Rate";
                        dataGridView1.DataMember = dataTable.TableName;
                        pictureBox1.Image = null;
                        employeeidTextBox.Text = String.Empty;
                        nameTextBox.Text = String.Empty;
                        icTextBox.Text = String.Empty;
                        dobTextBox.Text = String.Empty;
                        ageTextBox.Text = String.Empty;
                        phoneTextBox.Text = String.Empty;
                        emailTextBox.Text = String.Empty;
                        address1TextBox.Text = String.Empty;
                        address2TextBox.Text = String.Empty;
                        address3TextBox.Text = String.Empty;
                        postcodeTextBox.Text = String.Empty;
                        districtTextBox.Text = String.Empty;
                        stateTextBox.Text = String.Empty;
                        datejoinedTextBox.Text = String.Empty;
                        dateleftTextBox.Text = String.Empty;
                        positionTextBox.Text = String.Empty;
                        departmentTextBox.Text = String.Empty;
                        hourlyrateTextBox.Text = String.Empty;
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        statusLabel.Text = ex.Message;
                    }
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            employeeidTextBox.Text = String.Empty;
            nameTextBox.Text = String.Empty;
            icTextBox.Text = String.Empty;
            dobTextBox.Text = String.Empty;
            ageTextBox.Text = String.Empty;
            phoneTextBox.Text = String.Empty;
            emailTextBox.Text = String.Empty;
            address1TextBox.Text = String.Empty;
            address2TextBox.Text = String.Empty;
            address3TextBox.Text = String.Empty;
            postcodeTextBox.Text = String.Empty;
            districtTextBox.Text = String.Empty;
            stateTextBox.Text = String.Empty;
            datejoinedTextBox.Text = String.Empty;
            dateleftTextBox.Text = String.Empty;
            positionTextBox.Text = String.Empty;
            departmentTextBox.Text = String.Empty;
            hourlyrateTextBox.Text = String.Empty;
            statusLabel.Text = String.Empty;
            resultLabel.Text = String.Empty;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                MySqlCommand command2 = connection.CreateCommand();
                if (employeeidRadioButton.Checked)
                {
                    command.CommandText = "SELECT employeeid, name, ic, dateofbirth, age, mobileno, email, addressline1, addressline2, addressline3, postcode, district, "
                    + "state, datejoined, dateleft, position, department, hourlyrate FROM ARCHIVE WHERE employeeid LIKE '" + filterTextBox.Text + "%'";
                    command2.CommandText = "SELECT COUNT(*) FROM ARCHIVE " + "WHERE employeeid LIKE '" + filterTextBox.Text + "%'";
                }
                if (nameRadioButton.Checked)
                {
                    command.CommandText = "SELECT employeeid, name, ic, dateofbirth, age, mobileno, email, addressline1, addressline2, addressline3, postcode, district, "
                    + "state, datejoined, dateleft, position, department, hourlyrate FROM ARCHIVE WHERE name LIKE '" + filterTextBox.Text + "%'";
                    command2.CommandText = "SELECT COUNT(*) FROM ARCHIVE " + "WHERE name LIKE '" + filterTextBox.Text + "%'";
                }
                if (positionRadioButton.Checked)
                {
                    command.CommandText = "SELECT employeeid, name, ic, dateofbirth, age, mobileno, email, addressline1, addressline2, addressline3, postcode, district, "
                    + "state, datejoined, dateleft, position, department, hourlyrate FROM ARCHIVE WHERE position LIKE '" + filterTextBox.Text + "%'";
                    command2.CommandText = "SELECT COUNT(*) FROM ARCHIVE " + "WHERE position LIKE '" + filterTextBox.Text + "%'";
                }
                if (departmentRadioButton.Checked)
                {
                    command.CommandText = "SELECT employeeid, name, ic, dateofbirth, age, mobileno, email, addressline1, addressline2, addressline3, postcode, district, "
                    + "state, datejoined, dateleft, position, department, hourlyrate FROM ARCHIVE WHERE department LIKE '" + filterTextBox.Text + "%'";
                    command2.CommandText = "SELECT COUNT(*) FROM ARCHIVE " + "WHERE department LIKE '" + filterTextBox.Text + "%'";
                }
                command.ExecuteNonQuery();
                string rows = command2.ExecuteScalar().ToString();
                resultLabel.Text = rows + " rows returned";
                DataTable dataTable = new DataTable();
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                {
                    dataAdapter.Fill(dataTable);
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns[0].HeaderText = "Employee ID";
                dataGridView1.Columns[1].HeaderText = "Name";
                dataGridView1.Columns[2].HeaderText = "IC";
                dataGridView1.Columns[3].HeaderText = "Date of Birth";
                dataGridView1.Columns[4].HeaderText = "Age";
                dataGridView1.Columns[5].HeaderText = "Mobile No";
                dataGridView1.Columns[6].HeaderText = "Email";
                dataGridView1.Columns[7].HeaderText = "Address Line 1";
                dataGridView1.Columns[8].HeaderText = "Address Line 2";
                dataGridView1.Columns[9].HeaderText = "Address Line 3";
                dataGridView1.Columns[10].HeaderText = "Postcode";
                dataGridView1.Columns[11].HeaderText = "District";
                dataGridView1.Columns[12].HeaderText = "State";
                dataGridView1.Columns[13].HeaderText = "Date Joined";
                dataGridView1.Columns[14].HeaderText = "Date Left";
                dataGridView1.Columns[15].HeaderText = "Position";
                dataGridView1.Columns[16].HeaderText = "Department";
                dataGridView1.Columns[17].HeaderText = "Hourly Rate";
                dataGridView1.DataMember = dataTable.TableName;
                connection.Close();
            }
            catch (Exception ex)
            {
                statusLabel.Text = ex.Message;
            }
        }

        private void allRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (allRadioButton.Checked)
            {
                searchButton.Enabled = false;
                filterTextBox.Enabled = false;
                try
                {
                    connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "SELECT employeeid, name, ic, dateofbirth, age, mobileno, email, addressline1, addressline2, addressline3, postcode, district, "
                    + "state, datejoined, dateleft, position, department, hourlyrate FROM ARCHIVE";
                    command.ExecuteNonQuery();
                    MySqlCommand command2 = connection.CreateCommand();
                    command2.CommandText = "SELECT COUNT(*) FROM ARCHIVE";
                    string rows = command2.ExecuteScalar().ToString();
                    resultLabel.Text = rows + " rows returned";
                    DataTable dataTable = new DataTable();
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns[0].HeaderText = "Employee ID";
                    dataGridView1.Columns[1].HeaderText = "Name";
                    dataGridView1.Columns[2].HeaderText = "IC";
                    dataGridView1.Columns[3].HeaderText = "Date of Birth";
                    dataGridView1.Columns[4].HeaderText = "Age";
                    dataGridView1.Columns[5].HeaderText = "Mobile No";
                    dataGridView1.Columns[6].HeaderText = "Email";
                    dataGridView1.Columns[7].HeaderText = "Address Line 1";
                    dataGridView1.Columns[8].HeaderText = "Address Line 2";
                    dataGridView1.Columns[9].HeaderText = "Address Line 3";
                    dataGridView1.Columns[10].HeaderText = "Postcode";
                    dataGridView1.Columns[11].HeaderText = "District";
                    dataGridView1.Columns[12].HeaderText = "State";
                    dataGridView1.Columns[13].HeaderText = "Date Joined";
                    dataGridView1.Columns[14].HeaderText = "Date Left";
                    dataGridView1.Columns[15].HeaderText = "Position";
                    dataGridView1.Columns[16].HeaderText = "Department";
                    dataGridView1.Columns[17].HeaderText = "Hourly Rate";
                    dataGridView1.DataMember = dataTable.TableName;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    statusLabel.Text = ex.Message;
                }
            }
        }

        private void employeeidRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (employeeidRadioButton.Checked)
            {
                searchButton.Enabled = true;
                filterTextBox.Enabled = true;
            }
        }

        private void nameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (nameRadioButton.Checked)
            {
                searchButton.Enabled = true;
                filterTextBox.Enabled = true;
            }
        }

        private void positionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (positionRadioButton.Checked)
            {
                searchButton.Enabled = true;
                filterTextBox.Enabled = true;
            }
        }

        private void departmentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (departmentRadioButton.Checked)
            {
                searchButton.Enabled = true;
                filterTextBox.Enabled = true;
            }
        }
    }
}