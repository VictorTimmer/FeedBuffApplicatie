using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedBuffApplicatie.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            RoundButton(btnLogin, 10);

            // ROUND PANEL 1
            barPnl.BorderStyle = BorderStyle.None;
            barPnl.Dock = DockStyle.Top;
            barPnl.SizeChanged += Pnl1_SizeChanged;

            int cornerRadius = 10;
            System.Drawing.Drawing2D.GraphicsPath path1 = new System.Drawing.Drawing2D.GraphicsPath();
            path1.AddArc(barPnl.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path1.AddArc(barPnl.Width - cornerRadius, barPnl.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path1.AddArc(0, barPnl.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path1.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            barPnl.Region = new System.Drawing.Region(path1);

            // ROUND PANEL 2
            pnlBckgrnd.BackColor = Color.White;
            pnlBckgrnd.BorderStyle = BorderStyle.None;
            pnlBckgrnd.Dock = DockStyle.Fill;
            pnlBckgrnd.SizeChanged += Pnl2_SizeChanged;

            System.Drawing.Drawing2D.GraphicsPath path2 = new System.Drawing.Drawing2D.GraphicsPath();
            path2.AddArc(pnlBckgrnd.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path2.AddArc(pnlBckgrnd.Width - cornerRadius, pnlBckgrnd.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path2.AddArc(0, pnlBckgrnd.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path2.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            pnlBckgrnd.Region = new System.Drawing.Region(path2);
        }

        // PANEL 1 ROUNDED CORNER
        private void Pnl1_SizeChanged(object sender, EventArgs e)
        {
            // Set the panel's rounded corner region
            int cornerRadius = 10;
            System.Drawing.Drawing2D.GraphicsPath path1 = new System.Drawing.Drawing2D.GraphicsPath();
            path1.AddArc(barPnl.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path1.AddArc(barPnl.Width - cornerRadius, barPnl.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path1.AddArc(0, barPnl.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path1.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            barPnl.Region = new System.Drawing.Region(path1);
        }

        // PANEL 2 ROUNDED CORNER
        private void Pnl2_SizeChanged(object sender, EventArgs e)
        {
            // Set the panel's rounded corner region
            int cornerRadius = 10;
            System.Drawing.Drawing2D.GraphicsPath path2 = new System.Drawing.Drawing2D.GraphicsPath();
            path2.AddArc(pnlBckgrnd.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path2.AddArc(pnlBckgrnd.Width - cornerRadius, pnlBckgrnd.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path2.AddArc(0, pnlBckgrnd.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path2.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            pnlBckgrnd.Region = new System.Drawing.Region(path2);
        }

        // ROUND BUTTON
        public void RoundButton(Button button, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(button.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(button.Width - radius, button.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, button.Height - radius, radius, radius, 90, 90);
            path.AddArc(0, 0, radius, radius, 180, 90);
            button.Region = new System.Drawing.Region(path);
        }
        // ENTER & LEAVE

        // BUTTON CLICK
        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            this.Hide();
        }

        private void textBoxStudentId_Enter(object sender, EventArgs e)
        {
            if (textBoxStudentId.Text == " 1248510")
            {
                textBoxStudentId.Text = "";
                textBoxStudentId.ForeColor = Color.Black;
            }
        }

        private void textBoxStudentId_Leave(object sender, EventArgs e)
        {
            if (textBoxStudentId.Text == "")
            {
                textBoxStudentId.Text = " 1248510";
                textBoxStudentId.ForeColor = Color.DarkGray;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == " ******")
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.Black;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = " ******";
                textBoxPassword.ForeColor = Color.DarkGray;
            }
        }
    }
}
