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
    public partial class AdminDashboard : Form
    {

        public AdminDashboard()
        {
            InitializeComponent();
            userLabel.Text = Login.username;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                MessageBox.Show("You have clicked Ok Button");
                //Some task…
            }
            if (result == DialogResult.Cancel)
            {
                MessageBox.Show("You have clicked Cancel Button");
                //Some task…
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
                this.Close();
            }
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage manage = new Manage();
            this.Hide();
            manage.ShowDialog();
            this.Close();
        }

        private void manageButton_Click(object sender, EventArgs e)
        { 
            Manage manage = new Manage();
            this.Hide();
            manage.ShowDialog();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
                this.Close();
                userLabel.Text = "";
                Login.username = "";
            }
        }
    }
}
