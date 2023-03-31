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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            RoundButton(btnDashboard, 10);
            RoundButton(btnFeedup, 10);
            RoundButton(btnFeedforward, 10);
            RoundButton(btnFeedup, 10);
            RoundButton(btnFeedback, 10);
            ButtonColorReset(btnDashboard);

            lblTabTitle.Text = "DASHBOARD";
            pnlContent.Controls.Clear();
            FormDashboard formDashboard = new FormDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnlContent.Controls.Add(formDashboard);
            formDashboard.Show();

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
            pnlUser.BackColor = Color.White;
            pnlUser.BorderStyle = BorderStyle.None;
            pnlUser.Dock = DockStyle.Top;
            pnlUser.SizeChanged += Pnl2_SizeChanged;

            System.Drawing.Drawing2D.GraphicsPath path2 = new System.Drawing.Drawing2D.GraphicsPath();
            path2.AddArc(pnlUser.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path2.AddArc(pnlUser.Width - cornerRadius, pnlUser.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path2.AddArc(0, pnlUser.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path2.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            pnlUser.Region = new System.Drawing.Region(path2);

            // ROUND PANEL 3
            pnlNav.BackColor = Color.White;
            pnlNav.BorderStyle = BorderStyle.None;
            pnlNav.SizeChanged += Pnl3_SizeChanged;

            System.Drawing.Drawing2D.GraphicsPath path3 = new System.Drawing.Drawing2D.GraphicsPath();
            path3.AddArc(pnlNav.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path3.AddArc(pnlNav.Width - cornerRadius, pnlNav.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path3.AddArc(0, pnlNav.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path3.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            pnlNav.Region = new System.Drawing.Region(path3);
        }
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
            path2.AddArc(pnlUser.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path2.AddArc(pnlUser.Width - cornerRadius, pnlUser.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path2.AddArc(0, pnlUser.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path2.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            pnlUser.Region = new System.Drawing.Region(path2);
        }

        // PANEL 3 ROUNDED CORNER
        private void Pnl3_SizeChanged(object sender, EventArgs e)
        {
            // Set the panel's rounded corner region
            int cornerRadius = 15;
            System.Drawing.Drawing2D.GraphicsPath path3 = new System.Drawing.Drawing2D.GraphicsPath();
            path3.AddArc(pnlNav.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path3.AddArc(pnlNav.Width - cornerRadius, pnlNav.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path3.AddArc(0, pnlNav.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path3.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            pnlNav.Region = new System.Drawing.Region(path3);
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

        // NAVIGATION BUTTON COLOR
        private void ButtonColorReset(Button button)
        {
            Color activeColor = Color.FromArgb(185, 115, 117);
            Color inactiveColor = Color.Black;
            Color btnColor = Color.FromArgb(255, 255, 255);

            btnFeedback.BackColor = btnColor;
            btnFeedback.ForeColor = inactiveColor;

            btnFeedforward.BackColor = btnColor;
            btnFeedforward.ForeColor = inactiveColor;

            btnDashboard.BackColor = btnColor;
            btnDashboard.ForeColor = inactiveColor;

            btnFeedup.BackColor = btnColor;
            btnFeedup.ForeColor = inactiveColor;

            button.BackColor = activeColor;
            button.ForeColor = Color.White;
        }

        // BUTTON CLICK

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ButtonColorReset(btnDashboard);

            lblTabTitle.Text = "DASHBOARD";
            this.pnlContent.Controls.Clear();
            FormDashboard formDashboard = new FormDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(formDashboard);
            formDashboard.Show();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            ButtonColorReset(btnFeedup);

            lblTabTitle.Text = "FEEDUP";
            this.pnlContent.Controls.Clear();
            FormFeedup formFeedup = new FormFeedup() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(formFeedup);
            formFeedup.Show();
        }

        private void btnFeedup_Click(object sender, EventArgs e)
        {
            ButtonColorReset(btnFeedback);

            lblTabTitle.Text = "FEEDBACK";
            this.pnlContent.Controls.Clear();
            FormFeedback formFeedback = new FormFeedback() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(formFeedback);
            formFeedback.Show();
        }

        private void btnFeedforward_Click(object sender, EventArgs e)
        {
            ButtonColorReset(btnFeedforward);

            lblTabTitle.Text = "FEEDFORWARD";
            this.pnlContent.Controls.Clear();
            FormFeedforward formFeedforward = new FormFeedforward() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(formFeedforward);
            formFeedforward.Show();
        }
    }
}
