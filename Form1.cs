using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Pizzanova
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

    private void MakeRoundedButton(Button btn, int radius)
    {
        GraphicsPath path = new GraphicsPath();
        path.AddArc(0, 0, radius, radius, 180, 90);
        path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
        path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
        path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
        path.CloseFigure();

        btn.Region = new Region(path);
        btn.FlatStyle = FlatStyle.Flat;
        btn.FlatAppearance.BorderSize = 0;
    }

    private void frmHome_Load(object sender, EventArgs e)
        {
            MakeRoundedButton(btnMenu, 20);
            MakeRoundedButton(btnAbout, 20);
            MakeRoundedButton(btnOrder, 20);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Form frm = new frmMenu();
            frm.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            Form frm = new frmAbout();
            frm.ShowDialog();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Form frm = new frmOrder();
            frm.Show();
        }
    }
}
