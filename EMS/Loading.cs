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
    public partial class Loading : Form
    {
        int num = 50;

        public Loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            panel1.Width += 2;
            num += 2;
            loadingLabel.Text = "Loading... " + num/10 + "%";
            if (panel1.Width >= 1000)
            {
                timer1.Stop();
                Login login= new Login();
                this.Hide();
                login.ShowDialog();
                this.Close();
            }
        }
    }
}
