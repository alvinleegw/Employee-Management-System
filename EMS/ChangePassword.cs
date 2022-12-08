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
    public partial class ChangePassword : Form
    {
        private bool _dragging;
        private Point _startPoint = new Point(0, 0);
        private int _row;

        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePassword_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void ChangePassword_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void ChangePassword_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_dragging) return;
            var p = PointToScreen(e.Location);
            Location = new Point(p.X - this._startPoint.X, p.Y - this._startPoint.Y);
        }
    }
}
