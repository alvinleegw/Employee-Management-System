using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            /*string connectionString = null;
            MySqlConnection cnn;
            connectionString = "server=localhost;database=ems;uid=root;pwd=;";
            cnn = new MySqlConnection(connectionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open !");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }*/
        }
    }
}