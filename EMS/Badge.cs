using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS
{
    public partial class Badge : Form
    {
        Bitmap bitmap;
        private bool _dragging;
        private Point _startPoint = new Point(0, 0);
        private int _row;

        public Badge()
        {
            InitializeComponent();
            employeeidLabel.Text = Manage.employeeid;
            nameLabel.Text = Manage.name;
            positionLabel.Text = Manage.position;
            departmentLabel.Text = Manage.department;
        }

        private void Badge_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void Badge_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void Badge_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_dragging) return;
            var p = PointToScreen(e.Location);
            Location = new Point(p.X - this._startPoint.X, p.Y - this._startPoint.Y);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Manage.employeeid = String.Empty;
            Manage.name = String.Empty;
            Manage.position = String.Empty;
            Manage.department = String.Empty;
            this.Close();
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

        private void printButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please Upload An Image", "Image Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                printButton.Visible = false;
                closeButton.Visible = false;
                Panel panel = new Panel();
                this.Controls.Add(panel);
                Graphics grp = panel.CreateGraphics();
                Size formSize = this.ClientSize;
                bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
                grp = Graphics.FromImage(bitmap);
                Point panelLocation = PointToScreen(panel.Location);
                grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
                PrintDialog printDlg = new PrintDialog();
                printDlg.Document = printDocument1;
                printDlg.AllowSelection = true;
                printDlg.AllowSomePages = true;
                if (printDlg.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
                printButton.Visible = true;
                closeButton.Visible = true;
            }
        }

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            bitmap = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bitmap);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0); 
        }
    }
}
