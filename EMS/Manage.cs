using MySql.Data.MySqlClient;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using MySqlX.XDevAPI.Relational;
using Google.Protobuf.WellKnownTypes;
using System.Diagnostics;
using static QRCoder.Base64QRCode;
using System.Reflection.Metadata;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Font = iTextSharp.text.Font;
using Document = iTextSharp.text.Document;

namespace EMS
{
    public partial class Manage : Form
    {
        private bool _dragging;
        private Point _startPoint = new Point(0, 0);
        private int _row;
        public static string connectionString = null;
        MySqlConnection connection;
        public static string employeeid;
        public static string username;
        public static string password;
        public static string portrait;
        public static string name;
        public static string ic;
        public static string dob;
        public static string age;
        public static string mobileno;
        public static string email;
        public static string addressline1;
        public static string addressline2;
        public static string addressline3;
        public static string postcode;
        public static string district;
        public static string state;
        public static string datejoined;
        public static string position;
        public static string department;
        public static int hourlyrate;

        public Manage()
        {
            InitializeComponent();
            searchButton.Enabled = false;
            filterTextBox.Enabled = false;
            datejoinedTextBox.Text = DateTime.Now.ToString("d");
            try
            {
                connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT departmentcode FROM DEPARTMENTINFO";
                MySqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    employeeidComboBox.Items.Add(read[0]);
                }
                read.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                statusLabel.Text = ex.Message;
            }
            try
            {
                connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT employeeid, username, name, ic, dateofbirth, age, mobileno, email, addressline1, "
                + "addressline2, addressline3, postcode, district, state, datejoined, position, department, hourlyrate FROM EMPLOYEE";
                command.ExecuteNonQuery();
                DataTable dataTable = new DataTable();
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                {
                    dataAdapter.Fill(dataTable);
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns[0].HeaderText = "Employee ID";
                dataGridView1.Columns[1].HeaderText = "Username";
                dataGridView1.Columns[2].HeaderText = "Name";
                dataGridView1.Columns[3].HeaderText = "IC";
                dataGridView1.Columns[4].HeaderText = "Date of Birth";
                dataGridView1.Columns[5].HeaderText = "Age";
                dataGridView1.Columns[6].HeaderText = "Mobile No";
                dataGridView1.Columns[7].HeaderText = "Email";
                dataGridView1.Columns[8].HeaderText = "Address Line 1";
                dataGridView1.Columns[9].HeaderText = "Address Line 2";
                dataGridView1.Columns[10].HeaderText = "Address Line 3";
                dataGridView1.Columns[11].HeaderText = "Postcode";
                dataGridView1.Columns[12].HeaderText = "District";
                dataGridView1.Columns[13].HeaderText = "State";
                dataGridView1.Columns[14].HeaderText = "Date Joined";
                dataGridView1.Columns[15].HeaderText = "Position";
                dataGridView1.Columns[16].HeaderText = "Department";
                dataGridView1.Columns[17].HeaderText = "Hourly Rate";
                dataGridView1.DataMember = dataTable.TableName;
            }
            catch (Exception ex)
            {
                statusLabel.Text = ex.Message;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            AdminDashboard dashboard = new AdminDashboard();
            this.Hide();
            dashboard.ShowDialog();
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Regex regexname = new Regex(@"^[A-Za-z\s@`\s-/.]*$");
            bool checkname = regexname.IsMatch(nameTextBox.Text);
            Regex regexphone = new Regex(@"\+?6?(?:01[0-46-9]\d{7,8}|0\d{8})");
            bool checkphone = regexphone.IsMatch(phoneTextBox.Text);
            Regex regexemail = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",RegexOptions.CultureInvariant | RegexOptions.Singleline);
            bool checkemail = regexemail.IsMatch(emailTextBox.Text);
            Regex regexpostcode = new Regex(@"^[0-9]*$");
            bool checkpostcode = regexpostcode.IsMatch(postcodeTextBox.Text);
            Regex regexdistrict = new Regex(@"^[a-zA-Z ]+$");
            bool checkdistrict = regexdistrict.IsMatch(districtTextBox.Text);
            if (employeeidComboBox.SelectedItem == null || employeeidTextBox.Text == String.Empty
            || icTextBox.Text == String.Empty || passwordTextBox.Text == String.Empty 
            || nameTextBox.Text == String.Empty || dobTextBox.Text == String.Empty || ageTextBox.Text == String.Empty
            || phoneTextBox.Text == String.Empty || emailTextBox.Text == String.Empty || address1TextBox.Text == String.Empty
            || address2TextBox.Text == String.Empty || postcodeTextBox.Text == String.Empty || districtTextBox.Text == String.Empty
            || stateComboBox.SelectedItem == null || positionComboBox.SelectedItem == null || departmentTextBox.Text == String.Empty
            || pictureBox1.Image == null)
            {
                statusLabel.Text = "Please Fill In Every Required Fields And Upload Employee Portrait";
            }
            else if (usernameTextBox.Text.Length > 20)
            {
                statusLabel.Text = "Maximum Username Length Is 20 Characters Only";
            }
            else if (passwordTextBox.Text.Length < 8)
            {
                statusLabel.Text = "Password Length Must Be At Least 8 Characters";
            }
            else if (nameTextBox.Text.Length > 37)
            {
                statusLabel.Text = "Maximum Characters For Name is 37 Characters Only";
            }
            else if (!checkname)
            {
                statusLabel.Text = "Name Must Be Alphabets And Certain Special Characters @./`- Only";
            }
            else if (phoneTextBox.Text.Length > 12)
            {
                statusLabel.Text = "Maximum Phone Number Characters is 12 Only (Start With 60/601 Without -)";
            }
            else if (!checkphone)
            {
                statusLabel.Text = "Please Enter Valid Malaysia Phone Number (Start With 60/601 Without -)";
            }
            else if (!checkemail)
            {
                statusLabel.Text = "Please Enter A Valid Email Address";
            }
            else if (emailTextBox.Text.Length > 30)
            {
                statusLabel.Text = "Maximum Email Length is 30 Characters Only";
            }
            else if (address1TextBox.Text.Length > 30)
            {
                statusLabel.Text = "Maximum Characters For Address Line 1 is 30 Characters Only";
            }
            else if (address2TextBox.Text.Length > 30)
            {
                statusLabel.Text = "Maximum Characters For Address Line 2 is 30 Characters Only";
            }
            else if (address3TextBox.Text.Length > 30)
            {
                statusLabel.Text = "Maximum Characters For Address Line 3 is 30 Characters Only";
            }
            else if (postcodeTextBox.Text.Length != 5)
            {
                statusLabel.Text = "Maximum Characters For Postcode is 5 Characters Only";
            }
            else if (!checkpostcode)
            {
                statusLabel.Text = "Postcode Must Be 5 Digits Only";
            }
            else if (districtTextBox.Text.Length > 25)
            {
                statusLabel.Text = "Maximum Characters For District is 25 Characters Only";
            }
            else if (!checkdistrict)
            {
                statusLabel.Text = "District Must Be Alphabets Only";
            }
            else
            {
                string departmentcode = employeeidComboBox.SelectedItem.ToString();
                employeeid =  departmentcode + employeeidTextBox.Text;
                username = usernameTextBox.Text;
                ic = icTextBox.Text;
                password = passwordTextBox.Text;
                string hash;
                using (var md5Hash = MD5.Create())
                {
                    var sourceBytes = Encoding.UTF8.GetBytes(password);
                    var hashBytes = md5Hash.ComputeHash(sourceBytes);
                    hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);
                }
                name = nameTextBox.Text.ToUpper();
                dob = dobTextBox.Text;
                age = ageTextBox.Text;
                mobileno = phoneTextBox.Text;
                email = emailTextBox.Text;
                addressline1 = address1TextBox.Text.ToUpper();
                addressline2 = address2TextBox.Text.ToUpper();
                addressline3 = address3TextBox.Text.ToUpper();
                postcode = postcodeTextBox.Text;
                district = districtTextBox.Text.ToUpper();
                state = stateComboBox.SelectedItem.ToString();
                datejoined = DateTime.Now.ToString("d");
                position = positionComboBox.SelectedItem.ToString();
                department = departmentTextBox.Text;
                hourlyrate = (int)numericUpDown1.Value;
                byte[] BlobValue = null;
                string filePath = openFileDialog1.FileName;
                FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                BinaryReader reader = new BinaryReader(fs);
                BlobValue = reader.ReadBytes((int)fs.Length);
                fs.Close();
                reader.Close();
                try
                {
                    connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO EMPLOYEE(employeeid, username, password, portrait, name, ic, dateofbirth,"
                    + " age, mobileno, email, addressline1, addressline2, addressline3, postcode, district, state, datejoined, position,"
                    + " department, hourlyrate) VALUES('" + employeeid + "', '" + username + "', '" + hash + "', @BlobFile, '" 
                    + name + "', '" + ic + "', '" + dob + "', '" + age + "', '" + mobileno + "', '" + email + "', '" + addressline1 + "', '"
                    + addressline2 + "', '" + addressline3 + "', '" + postcode + "', '" + district + "', '" + state + "', '" + datejoined
                    + "', '" + position + "', '" + department + "', '" + hourlyrate + "')";
                    MySqlParameter fileContentParameter = new MySqlParameter("@BlobFile", MySqlDbType.MediumBlob, BlobValue.Length);
                    command.Parameters.Add(fileContentParameter);
                    fileContentParameter.Value = BlobValue;
                    if (command.ExecuteNonQuery() == 1)
                    {
                        resultLabel.Text = "Data Inserted Successfully";
                        MySqlCommand command2 = connection.CreateCommand();
                        command2.CommandText = "SELECT counter FROM DEPARTMENTINFO WHERE departmentcode ='" + departmentcode + "'";
                        int counter = Convert.ToInt32(command2.ExecuteScalar());
                        counter++;
                        MySqlCommand command3 = connection.CreateCommand();
                        command3.CommandText = "UPDATE DEPARTMENTINFO SET counter ='" + counter + "' WHERE departmentcode ='" + departmentcode + "'";
                        command3.ExecuteNonQuery();
                        employeeidComboBox.SelectedItem = null;
                        employeeidTextBox.Text = String.Empty;
                        pictureBox1.Image = null;
                        usernameTextBox.Text = String.Empty;
                        passwordTextBox.Text = String.Empty;
                        icTextBox.Text = String.Empty;
                        nameTextBox.Text = String.Empty;
                        dobTextBox.Text = String.Empty;
                        ageTextBox.Text = String.Empty;
                        phoneTextBox.Text = String.Empty;
                        emailTextBox.Text = String.Empty;
                        address1TextBox.Text = String.Empty;
                        address2TextBox.Text = String.Empty;
                        address3TextBox.Text = String.Empty;
                        postcodeTextBox.Text = String.Empty;
                        districtTextBox.Text = String.Empty;
                        stateComboBox.SelectedItem = null;
                        datejoinedTextBox.Text = DateTime.Now.ToString("d");
                        positionComboBox.SelectedItem = null;
                        departmentTextBox.Text = String.Empty;
                        numericUpDown1.Value = 10;
                    }
                    else
                    {
                        statusLabel.Text = "Failed to Insert Data";
                    }
                    MySqlCommand command4 = connection.CreateCommand();
                    command4.CommandText = "SELECT employeeid, username, name, ic, dateofbirth, age, mobileno, email, addressline1, " 
                    + "addressline2, addressline3, postcode, district, state, datejoined, position, department, hourlyrate FROM EMPLOYEE";
                    command4.ExecuteNonQuery();
                    DataTable dataTable = new DataTable();
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command4))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns[0].HeaderText = "Employee ID";
                    dataGridView1.Columns[1].HeaderText = "Username";
                    dataGridView1.Columns[2].HeaderText = "Name";
                    dataGridView1.Columns[3].HeaderText = "IC";
                    dataGridView1.Columns[4].HeaderText = "Date of Birth";
                    dataGridView1.Columns[5].HeaderText = "Age";
                    dataGridView1.Columns[6].HeaderText = "Mobile No";
                    dataGridView1.Columns[7].HeaderText = "Email";
                    dataGridView1.Columns[8].HeaderText = "Address Line 1";
                    dataGridView1.Columns[9].HeaderText = "Address Line 2";
                    dataGridView1.Columns[10].HeaderText = "Address Line 3";
                    dataGridView1.Columns[11].HeaderText = "Postcode";
                    dataGridView1.Columns[12].HeaderText = "District";
                    dataGridView1.Columns[13].HeaderText = "State";
                    dataGridView1.Columns[14].HeaderText = "Date Joined";
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

        private void managedepartmentButton_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            department.ShowDialog();
            try
            {
                employeeidComboBox.Items.Clear();
                positionComboBox.Items.Clear();
                departmentTextBox.Text = String.Empty;
                connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT departmentcode FROM DEPARTMENTINFO";
                MySqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    employeeidComboBox.Items.Add(read[0]);
                }
                read.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                statusLabel.Text = ex.Message;
            }
        }

        private void managepositionButton_Click(object sender, EventArgs e)
        {
            Position position = new Position();
            position.ShowDialog();
            try
            {
                employeeidComboBox.Items.Clear();
                positionComboBox.Items.Clear();
                departmentTextBox.Text = String.Empty;
                connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT departmentcode FROM DEPARTMENTINFO";
                MySqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    employeeidComboBox.Items.Add(read[0]);
                }
                read.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                statusLabel.Text = ex.Message;
            }
        }

        private void employeeidComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (employeeidComboBox.SelectedItem != null)
            {
                string departmentcode = employeeidComboBox.SelectedItem.ToString();
                string departmentname;
                int temp;
                try
                {
                    positionComboBox.Items.Clear();
                    departmentTextBox.Text = String.Empty;
                    connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    MySqlCommand command2 = connection.CreateCommand();
                    MySqlCommand command3 = connection.CreateCommand();
                    command.CommandText = "SELECT counter FROM DEPARTMENTINFO WHERE departmentcode ='" + departmentcode + "'";
                    temp = (int)command.ExecuteScalar();
                    employeeidTextBox.Text = temp.ToString("D3");
                    command2.CommandText = "SELECT positionname FROM POSITIONINFO WHERE departmentcode ='" + departmentcode + "'";
                    MySqlDataReader read = command2.ExecuteReader();
                    while (read.Read())
                    {
                        positionComboBox.Items.Add(read[0]);
                    }
                    read.Close();
                    command3.CommandText = "SELECT departmentname FROM DEPARTMENTINFO WHERE departmentcode ='" + departmentcode + "'";
                    departmentname = command3.ExecuteScalar().ToString();
                    departmentTextBox.Text = departmentname;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    statusLabel.Text = ex.Message;
                }
            }
        }

        private void icTextBox_TextChanged(object sender, EventArgs e)
        {
            Regex regexic = new Regex(@"(([[0-9]{2})(0[1-9]|1[0-2])(0[1-9]|[12][0-9]|3[01]))([0-9]{2})([0-9]{4})");
            bool checkic = regexic.IsMatch(icTextBox.Text);
            if (icTextBox.Text != String.Empty)
            {
                if (icTextBox.Text.Length != 12)
                {
                    dobTextBox.Text = String.Empty;
                    ageTextBox.Text = String.Empty;
                    statusLabel.Text = "IC Must Be 12 Characters Only (Without '-')";
                }
                else if (!checkic)
                {
                    statusLabel.Text = "Please Enter Valid IC";
                }
                else
                {
                    statusLabel.Text = String.Empty;
                    ic = icTextBox.Text;
                    string cyear = ic.Substring(0, 2);
                    int nyear;
                    int ages;
                    int year;
                    string month;
                    string day;
                    nyear = Convert.ToInt32(cyear);
                    if (nyear >= 22)
                    {
                        ages = (int)DateTime.Now.Year - (1900 + nyear);
                        age = ages.ToString();
                        ageTextBox.Text = age;
                        year = 1900 + nyear;
                    }
                    else
                    {
                        ages = (int)DateTime.Now.Year - (2000 + nyear);
                        age = ages.ToString();
                        ageTextBox.Text = age;
                        year = 2000 + nyear;
                    }
                    month = ic.Substring(2, 2);
                    day = ic.Substring(4, 2);
                    dob = day.ToString() + "/" + month.ToString() + "/" + year.ToString();
                    dobTextBox.Text = dob;
                }
            }
            else
            {
                statusLabel.Text = String.Empty;
            }
        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
            Regex regexphone = new Regex(@"601([0-46-9]\d{7,8}|0\d{8})");
            bool checkphone = regexphone.IsMatch(phoneTextBox.Text);
            if (phoneTextBox.Text != String.Empty)
            {
                if (phoneTextBox.Text.Length > 12)
                {
                    statusLabel.Text = "Maximum Phone Number Characters is 12 Only (Start With 60/601 Without -)";
                }
                else if (!checkphone)
                {
                    statusLabel.Text = "Please Enter Valid Malaysia Phone Number (Start With 60/601 Without -)";
                }
                else
                {
                    statusLabel.Text = String.Empty;
                }
            }
            else
            {
                statusLabel.Text = String.Empty;
            }
        }

        private void address1TextBox_TextChanged(object sender, EventArgs e)
        {
            if (address1TextBox.Text != String.Empty)
            {
                if (address1TextBox.Text.Length > 30)
                {
                    statusLabel.Text = "Maximum Characters For Address Line 1 is 30 Characters Only";
                }
                else
                {
                    statusLabel.Text = String.Empty;
                }
            }
            else
            {
                statusLabel.Text= String.Empty;
            }
        }

        private void address2TextBox_TextChanged(object sender, EventArgs e)
        {
           if (address2TextBox.Text != String.Empty)
           {
                if (address2TextBox.Text.Length > 30)
                {
                    statusLabel.Text = "Maximum Characters For Address Line 2 is 30 Characters Only";
                }
                else
                {
                    statusLabel.Text = String.Empty;
                }
           }
           else
            {
                statusLabel.Text= String.Empty;
            }
        }

        private void address3TextBox_TextChanged(object sender, EventArgs e)
        {
            if (address3TextBox.Text != String.Empty)
            {
                if (address3TextBox.Text.Length > 30)
                {
                    statusLabel.Text = "Maximum Characters For Address Line 3 is 30 Characters Only";
                }
                else
                {
                    statusLabel.Text = String.Empty;
                }
            }
            else
            {
                statusLabel.Text= String.Empty;
            }
        }

        private void postcodeTextBox_TextChanged(object sender, EventArgs e)
        {
            Regex regexpostcode = new Regex(@"^[0-9]*$");
            bool checkpostcode = regexpostcode.IsMatch(postcodeTextBox.Text);
            if (postcodeTextBox.Text != String.Empty)
            {
                if (postcodeTextBox.Text.Length != 5)
                {
                    statusLabel.Text = "Maximum Characters For Postcode is 5 Characters Only";
                }
                else if (!checkpostcode)
                {
                    statusLabel.Text = "Postcode Must Be 5 Digits Only";
                }
                else
                {
                    statusLabel.Text = String.Empty;
                }
            }
            else
            {
                statusLabel.Text= String.Empty;
            }
        }

        private void districtTextBox_TextChanged(object sender, EventArgs e)
        {
            Regex regexdistrict = new Regex(@"^[a-zA-Z ]+$");
            bool checkdistrict = regexdistrict.IsMatch(districtTextBox.Text);
            if (districtTextBox.Text != String.Empty)
            {
                if (districtTextBox.Text.Length > 25)
                {
                    statusLabel.Text = "Maximum Characters For District is 25 Characters Only";
                }
                else if (!checkdistrict)
                {
                    statusLabel.Text = "District Must Be Alphabets Only";
                }
                else
                {
                    statusLabel.Text = String.Empty;
                }
            }
            else
            {
                statusLabel.Text= String.Empty;
            }
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (usernameTextBox.Text != String.Empty)
            {
                if (usernameTextBox.Text.Length > 20)
                {
                    statusLabel.Text = "Maximum Username Length Is 20 Characters Only";
                }
                else
                {
                    statusLabel.Text = String.Empty;
                }
            }
            else
            {
                statusLabel.Text= String.Empty;
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordTextBox.Text != String.Empty)
            {
                if (passwordTextBox.Text.Length < 8)
                {
                    statusLabel.Text = "Password Length Must Be At Least 8 Characters";
                }
                else
                {
                    statusLabel.Text = String.Empty;
                }
            }
            else
            {
                statusLabel.Text = String.Empty;
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            Regex regexname = new Regex(@"^[A-Za-z\s@`\s-/.]*$");
            bool checkname = regexname.IsMatch(nameTextBox.Text);
            if (nameTextBox.Text != String.Empty)
            {
                if (nameTextBox.Text.Length > 37)
                {
                    statusLabel.Text = "Maximum Characters For Name is 37 Characters Only";
                }
                else if (!checkname)
                {
                    statusLabel.Text = "Name Must Be Alphabets And Certain Special Characters @./`- Only";
                }
                else
                {
                    statusLabel.Text = String.Empty;
                }
            }
            else
            {
                statusLabel.Text = String.Empty;
            }
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            Regex regexemail = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", RegexOptions.CultureInvariant | RegexOptions.Singleline);
            bool checkemail = regexemail.IsMatch(emailTextBox.Text);
            if (emailTextBox.Text != String.Empty)
            {
                if (!checkemail)
                {
                    statusLabel.Text = "Please Enter A Valid Email Address";
                }
                else if (emailTextBox.Text.Length > 30)
                {
                    statusLabel.Text = "Maximum Email Length is 30 Characters Only";
                }
                else
                {
                    statusLabel.Text = String.Empty;
                }
            }
            else
            {
                statusLabel.Text = String.Empty;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Insert Employee Portrait";
            openFileDialog1.Filter = "JPEG Files(*.jpeg)|*.jpg|PNG Files(*.png)|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }


        
        private void clearButton_Click(object sender, EventArgs e)
        {
            statusLabel.Text = String.Empty;
            resultLabel.Text = String.Empty;
            employeeidComboBox.SelectedItem = null;
            employeeidTextBox.Text = String.Empty;
            pictureBox1.Image = null;
            usernameTextBox.Text = String.Empty;
            passwordTextBox.Text = String.Empty;
            icTextBox.Text = String.Empty;
            nameTextBox.Text = String.Empty;
            dobTextBox.Text = String.Empty;
            ageTextBox.Text = String.Empty;
            phoneTextBox.Text = String.Empty;
            emailTextBox.Text = String.Empty;
            address1TextBox.Text = String.Empty;
            address2TextBox.Text = String.Empty;
            address3TextBox.Text = String.Empty;
            postcodeTextBox.Text = String.Empty;
            districtTextBox.Text = String.Empty;
            stateComboBox.SelectedItem = null;
            datejoinedTextBox.Text = DateTime.Now.ToString("d");
            positionComboBox.SelectedItem = null;
            departmentTextBox.Text = String.Empty;
            numericUpDown1.Value = 10;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                string id;
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    id = row.Cells[0].Value.ToString();
                    string code = id.Substring(0, 2);
                    string num = id.Substring(2, 3);
                    employeeidComboBox.SelectedIndex = employeeidComboBox.FindStringExact(code);
                    employeeidTextBox.Text = num.ToString();
                    usernameTextBox.Text = row.Cells[1].Value.ToString();
                    nameTextBox.Text = row.Cells[2].Value.ToString();
                    icTextBox.Text = row.Cells[3].Value.ToString();
                    dobTextBox.Text = row.Cells[4].Value.ToString();
                    ageTextBox.Text = row.Cells[5].Value.ToString();
                    phoneTextBox.Text = row.Cells[6].Value.ToString();
                    emailTextBox.Text = row.Cells[7].Value.ToString();
                    address1TextBox.Text = row.Cells[8].Value.ToString();
                    address2TextBox.Text = row.Cells[9].Value.ToString();
                    address3TextBox.Text = row.Cells[10].Value.ToString();
                    postcodeTextBox.Text = row.Cells[11].Value.ToString();
                    districtTextBox.Text = row.Cells[12].Value.ToString();
                    stateComboBox.SelectedIndex = stateComboBox.FindStringExact(row.Cells[13].Value.ToString());
                    datejoinedTextBox.Text = row.Cells[14].Value.ToString();
                    positionComboBox.SelectedIndex = positionComboBox.FindStringExact(row.Cells[15].Value.ToString());
                    departmentTextBox.Text = row.Cells[16].Value.ToString();
                    numericUpDown1.Value = (int)row.Cells[17].Value;
                    connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "SELECT portrait FROM EMPLOYEE WHERE employeeid ='" + id + "'";
                    MySqlDataAdapter dataAdapter= new MySqlDataAdapter(command);
                    DataSet dataset = new DataSet();
                    dataAdapter.Fill(dataset);
                    if (dataset.Tables[0].Rows.Count > 0)
                    {
                        MemoryStream ms = new MemoryStream((byte[])dataset.Tables[0].Rows[0]["portrait"]);
                        pictureBox1.Image = new Bitmap(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                statusLabel.Text = ex.Message;
            }
        }

        
        private void updateButton_Click(object sender, EventArgs e)
        {
            Regex regexname = new Regex(@"^[A-Za-z\s@`\s-/.]*$");
            bool checkname = regexname.IsMatch(nameTextBox.Text);
            Regex regexphone = new Regex(@"\+?6?(?:01[0-46-9]\d{7,8}|0\d{8})");
            bool checkphone = regexphone.IsMatch(phoneTextBox.Text);
            Regex regexemail = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", RegexOptions.CultureInvariant | RegexOptions.Singleline);
            bool checkemail = regexemail.IsMatch(emailTextBox.Text);
            Regex regexpostcode = new Regex(@"^[0-9]*$");
            bool checkpostcode = regexpostcode.IsMatch(postcodeTextBox.Text);
            Regex regexdistrict = new Regex(@"^[a-zA-Z ]+$");
            bool checkdistrict = regexdistrict.IsMatch(districtTextBox.Text);
            if (employeeidComboBox.SelectedItem == null || employeeidTextBox.Text == String.Empty
            || nameTextBox.Text == String.Empty || phoneTextBox.Text == String.Empty || emailTextBox.Text == String.Empty 
            || address1TextBox.Text == String.Empty || address2TextBox.Text == String.Empty || postcodeTextBox.Text == String.Empty || districtTextBox.Text == String.Empty
            || stateComboBox.SelectedItem == null || positionComboBox.SelectedItem == null || departmentTextBox.Text == String.Empty
            || pictureBox1.Image == null)
            {
                statusLabel.Text = "Fields Except Username, Password, IC, Date of Birth, Age, Address Line 3 (Optional) And Date Joined Must Not Be Empty";
            }
            else if (nameTextBox.Text.Length > 37)
            {
                statusLabel.Text = "Maximum Characters For Name is 37 Characters Only";
            }
            else if (!checkname)
            {
                statusLabel.Text = "Name Must Be Alphabets And Certain Special Characters @./`- Only";
            }
            else if (phoneTextBox.Text.Length > 12)
            {
                statusLabel.Text = "Maximum Phone Number Characters is 12 Only (Start With 60/601 Without -)";
            }
            else if (!checkphone)
            {
                statusLabel.Text = "Please Enter Valid Malaysia Phone Number (Start With 60/601 Without -)";
            }
            else if (!checkemail)
            {
                statusLabel.Text = "Please Enter A Valid Email Address";
            }
            else if (emailTextBox.Text.Length > 30)
            {
                statusLabel.Text = "Maximum Email Length is 30 Characters Only";
            }
            else if (address1TextBox.Text.Length > 30)
            {
                statusLabel.Text = "Maximum Characters For Address Line 1 is 30 Characters Only";
            }
            else if (address2TextBox.Text.Length > 30)
            {
                statusLabel.Text = "Maximum Characters For Address Line 2 is 30 Characters Only";
            }
            else if (address3TextBox.Text.Length > 30)
            {
                statusLabel.Text = "Maximum Characters For Address Line 3 is 30 Characters Only";
            }
            else if (postcodeTextBox.Text.Length != 5)
            {
                statusLabel.Text = "Maximum Characters For Postcode is 5 Characters Only";
            }
            else if (!checkpostcode)
            {
                statusLabel.Text = "Postcode Must Be 5 Digits Only";
            }
            else if (districtTextBox.Text.Length > 25)
            {
                statusLabel.Text = "Maximum Characters For District is 25 Characters Only";
            }
            else if (!checkdistrict)
            {
                statusLabel.Text = "District Must Be Alphabets Only";
            }
            else
            {
                string departmentcode = employeeidComboBox.SelectedItem.ToString();
                employeeid = departmentcode + employeeidTextBox.Text;
                name = nameTextBox.Text.ToUpper();
                mobileno = phoneTextBox.Text;
                email = emailTextBox.Text;
                addressline1 = address1TextBox.Text.ToUpper();
                addressline2 = address2TextBox.Text.ToUpper();
                addressline3 = address3TextBox.Text.ToUpper();
                postcode = postcodeTextBox.Text;
                district = districtTextBox.Text.ToUpper();
                state = stateComboBox.SelectedItem.ToString();
                position = positionComboBox.SelectedItem.ToString();
                department = departmentTextBox.Text;
                hourlyrate = (int)numericUpDown1.Value;
                byte[] BlobValue = null;
                string filePath = openFileDialog1.FileName;
                try
                {
                    FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                    BinaryReader reader = new BinaryReader(fs);
                    BlobValue = reader.ReadBytes((int)fs.Length);
                    fs.Close();
                    reader.Close();
                }
                catch (FileNotFoundException ex)
                {
                    statusLabel.Text = String.Empty;
                }
                try
                {
                    connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    if (File.Exists(filePath))
                    {
                        command.CommandText = "UPDATE EMPLOYEE SET portrait =@BlobFile, name ='" + name + "', mobileno ='" + mobileno + "', email ='"
                        + email + "', addressline1 ='" + addressline1 + "', addressline2 ='" + addressline2 + "', addressline3 ='"
                        + addressline3 + "', postcode ='" + postcode + "', district ='" + district + "', state ='" + state + "', position ='"
                        + position + "', department ='" + department + "', hourlyrate ='" + hourlyrate + "' WHERE employeeid ='" + employeeid + "'";
                        MySqlParameter fileContentParameter = new MySqlParameter("@BlobFile", MySqlDbType.MediumBlob, BlobValue.Length);
                        command.Parameters.Add(fileContentParameter);
                        fileContentParameter.Value = BlobValue;
                    }
                    else
                    {
                        command.CommandText = "UPDATE EMPLOYEE SET name ='" + name + "', mobileno ='" + mobileno + "', email ='"
                        + email + "', addressline1 ='" + addressline1 + "', addressline2 ='" + addressline2 + "', addressline3 ='"
                        + addressline3 + "', postcode ='" + postcode + "', district ='" + district + "', state ='" + state + "', position ='"
                        + position + "', department ='" + department + "', hourlyrate ='" + hourlyrate + "' WHERE employeeid ='" + employeeid + "'";
                    }
                    if (command.ExecuteNonQuery() == 1)
                    {
                        resultLabel.Text = "Data Updated Successfully";
                    }
                    else
                    {
                        resultLabel.Text = "Failed To Update Data";
                    }
                    MySqlCommand command2 = connection.CreateCommand();
                    command2.CommandText = "SELECT employeeid, username, name, ic, dateofbirth, age, mobileno, email, addressline1, "
                    + "addressline2, addressline3, postcode, district, state, datejoined, position, department, hourlyrate FROM EMPLOYEE";
                    command2.ExecuteNonQuery();
                    DataTable dataTable = new DataTable();
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command2))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns[0].HeaderText = "Employee ID";
                    dataGridView1.Columns[1].HeaderText = "Username";
                    dataGridView1.Columns[2].HeaderText = "Name";
                    dataGridView1.Columns[3].HeaderText = "IC";
                    dataGridView1.Columns[4].HeaderText = "Date of Birth";
                    dataGridView1.Columns[5].HeaderText = "Age";
                    dataGridView1.Columns[6].HeaderText = "Mobile No";
                    dataGridView1.Columns[7].HeaderText = "Email";
                    dataGridView1.Columns[8].HeaderText = "Address Line 1";
                    dataGridView1.Columns[9].HeaderText = "Address Line 2";
                    dataGridView1.Columns[10].HeaderText = "Address Line 3";
                    dataGridView1.Columns[11].HeaderText = "Postcode";
                    dataGridView1.Columns[12].HeaderText = "District";
                    dataGridView1.Columns[13].HeaderText = "State";
                    dataGridView1.Columns[14].HeaderText = "Date Joined";
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
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (employeeidComboBox.SelectedItem == null || employeeidTextBox.Text == String.Empty)
            {
                statusLabel.Text = "Employee ID Field Must Not Be Empty";
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record? You can archive the record instead.", "Delete Record Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    string departmentcode = employeeidComboBox.SelectedItem.ToString();
                    employeeid = departmentcode + employeeidTextBox.Text;
                    try
                    {
                        connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                        connection = new MySqlConnection(connectionString);
                        connection.Open();
                        MySqlCommand command = connection.CreateCommand();
                        MySqlCommand command2 = connection.CreateCommand();
                        command.CommandText = "DELETE FROM EMPLOYEE WHERE employeeid = '" + employeeid + "'";
                        if (command.ExecuteNonQuery() == 1)
                        {
                            resultLabel.Text = "Data Deleted Successfully";
                            employeeidComboBox.SelectedItem = null;
                            employeeidTextBox.Text = String.Empty;
                            pictureBox1.Image = null;
                            usernameTextBox.Text = String.Empty;
                            passwordTextBox.Text = String.Empty;
                            icTextBox.Text = String.Empty;
                            nameTextBox.Text = String.Empty;
                            dobTextBox.Text = String.Empty;
                            ageTextBox.Text = String.Empty;
                            phoneTextBox.Text = String.Empty;
                            emailTextBox.Text = String.Empty;
                            address1TextBox.Text = String.Empty;
                            address2TextBox.Text = String.Empty;
                            address3TextBox.Text = String.Empty;
                            postcodeTextBox.Text = String.Empty;
                            districtTextBox.Text = String.Empty;
                            stateComboBox.SelectedItem = null;
                            datejoinedTextBox.Text = DateTime.Now.ToString("d");
                            positionComboBox.SelectedItem = null;
                            departmentTextBox.Text = String.Empty;
                            numericUpDown1.Value = 10;
                        }
                        else
                        {
                            statusLabel.Text = "Failed to Delete Data";
                        }
                        command2.CommandText = "SELECT employeeid, username, name, ic, dateofbirth, age, mobileno, email, addressline1, "
                        + "addressline2, addressline3, postcode, district, state, datejoined, position, department, hourlyrate FROM EMPLOYEE";
                        command2.ExecuteNonQuery();
                        DataTable dataTable = new DataTable();
                        using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command2))
                        {
                            dataAdapter.Fill(dataTable);
                        }
                        dataGridView1.DataSource = dataTable;
                        dataGridView1.Columns[0].HeaderText = "Employee ID";
                        dataGridView1.Columns[1].HeaderText = "Username";
                        dataGridView1.Columns[2].HeaderText = "Name";
                        dataGridView1.Columns[3].HeaderText = "IC";
                        dataGridView1.Columns[4].HeaderText = "Date of Birth";
                        dataGridView1.Columns[5].HeaderText = "Age";
                        dataGridView1.Columns[6].HeaderText = "Mobile No";
                        dataGridView1.Columns[7].HeaderText = "Email";
                        dataGridView1.Columns[8].HeaderText = "Address Line 1";
                        dataGridView1.Columns[9].HeaderText = "Address Line 2";
                        dataGridView1.Columns[10].HeaderText = "Address Line 3";
                        dataGridView1.Columns[11].HeaderText = "Postcode";
                        dataGridView1.Columns[12].HeaderText = "District";
                        dataGridView1.Columns[13].HeaderText = "State";
                        dataGridView1.Columns[14].HeaderText = "Date Joined";
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
                    command.CommandText = "SELECT employeeid, username, name, ic, dateofbirth, age, mobileno, email, addressline1, "
                    + "addressline2, addressline3, postcode, district, state, datejoined, position, department, hourlyrate FROM EMPLOYEE " +
                    "WHERE employeeid LIKE '" + filterTextBox.Text + "%'";
                    command2.CommandText = "SELECT COUNT(*) FROM EMPLOYEE " + "WHERE employeeid LIKE '" + filterTextBox.Text + "%'";
                }
                if (nameRadioButton.Checked)
                {
                    command.CommandText = "SELECT employeeid, username, name, ic, dateofbirth, age, mobileno, email, addressline1, "
                    + "addressline2, addressline3, postcode, district, state, datejoined, position, department, hourlyrate FROM EMPLOYEE " +
                    "WHERE name LIKE '" + filterTextBox.Text + "%'";
                    command2.CommandText = "SELECT COUNT(*) FROM EMPLOYEE " + "WHERE name LIKE '" + filterTextBox.Text + "%'";
                }
                if (positionRadioButton.Checked)
                {
                    command.CommandText = "SELECT employeeid, username, name, ic, dateofbirth, age, mobileno, email, addressline1, "
                    + "addressline2, addressline3, postcode, district, state, datejoined, position, department, hourlyrate FROM EMPLOYEE " +
                    "WHERE position LIKE '" + filterTextBox.Text + "%'";
                    command2.CommandText = "SELECT COUNT(*) FROM EMPLOYEE " + "WHERE position LIKE '" + filterTextBox.Text + "%'";
                }
                if (departmentRadioButton.Checked)
                {
                    command.CommandText = "SELECT employeeid, username, name, ic, dateofbirth, age, mobileno, email, addressline1, "
                    + "addressline2, addressline3, postcode, district, state, datejoined, position, department, hourlyrate FROM EMPLOYEE " +
                    "WHERE department LIKE '" + filterTextBox.Text + "%'";
                    command2.CommandText = "SELECT COUNT(*) FROM EMPLOYEE " + "WHERE department LIKE '" + filterTextBox.Text + "%'";
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
                dataGridView1.Columns[1].HeaderText = "Username";
                dataGridView1.Columns[2].HeaderText = "Name";
                dataGridView1.Columns[3].HeaderText = "IC";
                dataGridView1.Columns[4].HeaderText = "Date of Birth";
                dataGridView1.Columns[5].HeaderText = "Age";
                dataGridView1.Columns[6].HeaderText = "Mobile No";
                dataGridView1.Columns[7].HeaderText = "Email";
                dataGridView1.Columns[8].HeaderText = "Address Line 1";
                dataGridView1.Columns[9].HeaderText = "Address Line 2";
                dataGridView1.Columns[10].HeaderText = "Address Line 3";
                dataGridView1.Columns[11].HeaderText = "Postcode";
                dataGridView1.Columns[12].HeaderText = "District";
                dataGridView1.Columns[13].HeaderText = "State";
                dataGridView1.Columns[14].HeaderText = "Date Joined";
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
                    MySqlCommand command2 = connection.CreateCommand();
                    if (allRadioButton.Checked)
                    {
                    command.CommandText = "SELECT employeeid, username, name, ic, dateofbirth, age, mobileno, email, addressline1, "
                    + "addressline2, addressline3, postcode, district, state, datejoined, position, department, hourlyrate FROM EMPLOYEE";
                    command2.CommandText = "SELECT COUNT(*) FROM EMPLOYEE ";
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
                    dataGridView1.Columns[1].HeaderText = "Username";
                    dataGridView1.Columns[2].HeaderText = "Name";
                    dataGridView1.Columns[3].HeaderText = "IC";
                    dataGridView1.Columns[4].HeaderText = "Date of Birth";
                    dataGridView1.Columns[5].HeaderText = "Age";
                    dataGridView1.Columns[6].HeaderText = "Mobile No";
                    dataGridView1.Columns[7].HeaderText = "Email";
                    dataGridView1.Columns[8].HeaderText = "Address Line 1";
                    dataGridView1.Columns[9].HeaderText = "Address Line 2";
                    dataGridView1.Columns[10].HeaderText = "Address Line 3";
                    dataGridView1.Columns[11].HeaderText = "Postcode";
                    dataGridView1.Columns[12].HeaderText = "District";
                    dataGridView1.Columns[13].HeaderText = "State";
                    dataGridView1.Columns[14].HeaderText = "Date Joined";
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

        
        private void exportButton_Click(object sender, EventArgs e)
        {
             try
             {
                 var csv = new System.Text.StringBuilder();
                 var header = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}", "Employee ID", "Username", "Name", "IC", "Date of Birth", "Age", "Mobile No", "Email", "Address Line 1", "Address Line 2", "Address Line 3", "Postcode",  "District", "State", "Date Joined", "Position", "Department", "Hourly Rate");
                 csv.AppendLine(header);
                 foreach (DataGridViewRow row in dataGridView1.Rows)
                 {
                     var newLine = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}","\"" + row.Cells[0].Value + "\"", "\"" + row.Cells[1].Value + "\"", "\"" + row.Cells[2].Value + "\"", "=\"" + row.Cells[3].Value + "\"", "\"" + row.Cells[4].Value + "\"", "\"" + row.Cells[5].Value + "\"", "=\"" + row.Cells[6].Value + "\"", "\"" + row.Cells[7].Value + "\"", "\"" + row.Cells[8].Value + "\"", "\"" + row.Cells[9].Value + "\"", "\"" + row.Cells[10].Value + "\"", "=\"" + row.Cells[11].Value + "\"", "\"" + row.Cells[12].Value + "\"", "\"" + row.Cells[13].Value + "\"", "\"" + row.Cells[14].Value + "\"", "\"" + row.Cells[15].Value + "\"", "\"" + row.Cells[16].Value + "\"", "\"" + row.Cells[17].Value + "\"");
                     csv.AppendLine(newLine);
                 }
                 SaveFileDialog saveFileDialog = new SaveFileDialog();
                 saveFileDialog.Title = "Export Data";
                 saveFileDialog.Filter = "CSV file(*.csv)|*.csv";
                 if (saveFileDialog.ShowDialog() == DialogResult.OK)
                 {
                     File.WriteAllText(saveFileDialog.FileName, csv.ToString(), System.Text.Encoding.UTF8);
                     statusLabel.Text = "Data Successfully Exported (CSV)";
                 }
             }
             catch (Exception ex)
             {
                 statusLabel.Text = ex.Message;
             }
        }

        private void Manage_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void Manage_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void Manage_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_dragging) return;
            var p = PointToScreen(e.Location);
            Location = new Point(p.X - this._startPoint.X, p.Y - this._startPoint.Y);
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        
        private void badgeButton_Click(object sender, EventArgs e)
        {
            
            if (employeeidComboBox.SelectedItem == null || employeeidTextBox.Text == String.Empty || nameTextBox.Text == String.Empty
            || positionComboBox.SelectedItem == null || departmentTextBox.Text == String.Empty)
            {
                statusLabel.Text = "Employee ID, Name, Position and Department Field Must Not Be Empty";
            }
            else
            {
                string departmentcode = employeeidComboBox.SelectedItem.ToString();
                employeeid = departmentcode + employeeidTextBox.Text;
                statusLabel.Text = String.Empty;
                name = nameTextBox.Text;
                position = positionComboBox.SelectedItem.ToString();
                department = departmentTextBox.Text;
                Badge badge = new Badge();
                badge.ShowDialog();
            } 
        }

        
        private void qrButton_Click(object sender, EventArgs e)
        {
            if (employeeidTextBox.Text == String.Empty)
            {
                statusLabel.Text = "Employee ID Must Not Be Empty";
                }
            else
            {
                statusLabel.Text = String.Empty;
                string departmentcode = employeeidComboBox.SelectedItem.ToString();
                employeeid = departmentcode + employeeidTextBox.Text;
                QR qr = new QR();
                qr.ShowDialog();
            }
        }

        private void export2Button_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            bool fileError = false;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(sfd.FileName))
                {
                    try
                    {
                        File.Delete(sfd.FileName);
                    }
                    catch (IOException ex)
                    {
                        fileError = true;
                        statusLabel.Text = ex.Message;
                    }
                }
                if (!fileError)
                {
                    try
                    {
                        PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                        pdfTable.DefaultCell.Padding = 2;
                        pdfTable.WidthPercentage = 100;
                        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;


                        foreach (DataGridViewColumn column in dataGridView1.Columns)
                        {
                            Font tablefont = FontFactory.GetFont("Times-Roman", 8);
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, tablefont));
                            pdfTable.AddCell(cell);
                        }

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                Font font = FontFactory.GetFont("Times-Roman", 8);
                                pdfTable.AddCell(new Phrase(cell.Value.ToString(), font));
                            }
                        }

                        using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                        {
                            Document pdfDoc = new Document(iTextSharp.text.PageSize.A4.Rotate(), 10f, 20f, 20f, 10f);
                            PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.Open();
                            pdfDoc.Add(pdfTable);
                            pdfDoc.Close();
                            stream.Close();
                        }
                        statusLabel.Text = "Data Successfully Exported (PDF)";
                    }
                    catch (Exception ex)
                    {
                        statusLabel.Text = ex.Message;
                    }
                }
            }
        }

        private void archiveButton_Click(object sender, EventArgs e)
        {
            
            if (employeeidComboBox.SelectedItem == null || employeeidTextBox.Text == String.Empty)
            {
                statusLabel.Text = "Employee ID Field Must Not Be Empty";
            }
            else
            {
                string departmentcode = employeeidComboBox.SelectedItem.ToString();
                employeeid = departmentcode + employeeidTextBox.Text;
                DialogResult result = MessageBox.Show("Are you sure you want to archive this record? You cannot undo this action.", "Archive Record Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string dateleft = DateTime.Now.ToString("d");
                        connectionString = "server=localhost;database=ems;uid=root;pwd=;";
                        connection = new MySqlConnection(connectionString);
                        connection.Open();
                        MySqlCommand command = connection.CreateCommand();
                        command.CommandText = "INSERT INTO ARCHIVE (employeeid, portrait, name, ic, dateofbirth, age, mobileno, email, addressline1, addressline2, addressline3, postcode, district, state, datejoined, position, department, hourlyrate) "
                        + "SELECT employeeid, portrait, name, ic, dateofbirth, age, mobileno, email, addressline1, addressline2, addressline3, postcode, district, state, datejoined, position, department, hourlyrate FROM EMPLOYEE WHERE employeeid='" + employeeid + "'";
                        if (command.ExecuteNonQuery() == 1)
                        {
                            resultLabel.Text = "Data Archived Successfully";
                            MySqlCommand command3 = connection.CreateCommand();
                            command3.CommandText = "DELETE FROM EMPLOYEE WHERE employeeid ='" + employeeid + "'";
                            command3.ExecuteNonQuery();
                        }
                        MySqlCommand command2 = connection.CreateCommand();
                        command2.CommandText = "UPDATE ARCHIVE SET dateleft ='" + dateleft + "' WHERE employeeid ='" + employeeid + "'";
                        command2.ExecuteNonQuery();
                        MySqlCommand command4 = connection.CreateCommand();
                        command4.CommandText = "SELECT employeeid, username, name, ic, dateofbirth, age, mobileno, email, addressline1, "
                        + "addressline2, addressline3, postcode, district, state, datejoined, position, department, hourlyrate FROM EMPLOYEE";
                        command4.ExecuteNonQuery();
                        DataTable dataTable = new DataTable();
                        using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command4))
                        {
                            dataAdapter.Fill(dataTable);
                        }
                        dataGridView1.DataSource = dataTable;
                        dataGridView1.Columns[0].HeaderText = "Employee ID";
                        dataGridView1.Columns[1].HeaderText = "Username";
                        dataGridView1.Columns[2].HeaderText = "Name";
                        dataGridView1.Columns[3].HeaderText = "IC";
                        dataGridView1.Columns[4].HeaderText = "Date of Birth";
                        dataGridView1.Columns[5].HeaderText = "Age";
                        dataGridView1.Columns[6].HeaderText = "Mobile No";
                        dataGridView1.Columns[7].HeaderText = "Email";
                        dataGridView1.Columns[8].HeaderText = "Address Line 1";
                        dataGridView1.Columns[9].HeaderText = "Address Line 2";
                        dataGridView1.Columns[10].HeaderText = "Address Line 3";
                        dataGridView1.Columns[11].HeaderText = "Postcode";
                        dataGridView1.Columns[12].HeaderText = "District";
                        dataGridView1.Columns[13].HeaderText = "State";
                        dataGridView1.Columns[14].HeaderText = "Date Joined";
                        dataGridView1.Columns[15].HeaderText = "Position";
                        dataGridView1.Columns[16].HeaderText = "Department";
                        dataGridView1.Columns[17].HeaderText = "Hourly Rate";
                        dataGridView1.DataMember = dataTable.TableName;
                        connection.Close();
                        employeeidComboBox.SelectedItem = null;
                        employeeidTextBox.Text = String.Empty;
                        pictureBox1.Image = null;
                        usernameTextBox.Text = String.Empty;
                        passwordTextBox.Text = String.Empty;
                        icTextBox.Text = String.Empty;
                        nameTextBox.Text = String.Empty;
                        dobTextBox.Text = String.Empty;
                        ageTextBox.Text = String.Empty;
                        phoneTextBox.Text = String.Empty;
                        emailTextBox.Text = String.Empty;
                        address1TextBox.Text = String.Empty;
                        address2TextBox.Text = String.Empty;
                        address3TextBox.Text = String.Empty;
                        postcodeTextBox.Text = String.Empty;
                        districtTextBox.Text = String.Empty;
                        stateComboBox.SelectedItem = null;
                        datejoinedTextBox.Text = DateTime.Now.ToString("d");
                        positionComboBox.SelectedItem = null;
                        departmentTextBox.Text = String.Empty;
                        numericUpDown1.Value = 10;
                    }
                    catch (Exception ex)
                    {
                        statusLabel.Text = ex.Message;
                    }
                }
            }
        }
    }
}
