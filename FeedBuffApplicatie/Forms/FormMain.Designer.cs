﻿namespace FeedBuffApplicatie.Forms
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTabTitle = new System.Windows.Forms.Label();
            this.userPicBox = new System.Windows.Forms.PictureBox();
            this.pnlNavMid = new System.Windows.Forms.Panel();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.lblTtl = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.orderBtn = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlTabTitle = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.pnlBack = new System.Windows.Forms.Panel();
            this.btnFeedforward = new System.Windows.Forms.Button();
            this.btnFeedup = new System.Windows.Forms.Button();
            this.pnlBottem = new System.Windows.Forms.Panel();
            this.pnlMid = new System.Windows.Forms.Panel();
            this.panelMidConNav = new System.Windows.Forms.Panel();
            this.barPnl = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.userPicBox)).BeginInit();
            this.pnlUser.SuspendLayout();
            this.pnlTabTitle.SuspendLayout();
            this.pnlNav.SuspendLayout();
            this.pnlBack.SuspendLayout();
            this.barPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTabTitle
            // 
            this.lblTabTitle.AutoSize = true;
            this.lblTabTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTabTitle.Location = new System.Drawing.Point(13, 9);
            this.lblTabTitle.Name = "lblTabTitle";
            this.lblTabTitle.Size = new System.Drawing.Size(171, 41);
            this.lblTabTitle.TabIndex = 0;
            this.lblTabTitle.Text = "Dashboard";
            // 
            // userPicBox
            // 
            this.userPicBox.Image = global::FeedBuffApplicatie.Properties.Resources.icons8_male_user_96;
            this.userPicBox.Location = new System.Drawing.Point(16, 27);
            this.userPicBox.Name = "userPicBox";
            this.userPicBox.Size = new System.Drawing.Size(67, 57);
            this.userPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPicBox.TabIndex = 2;
            this.userPicBox.TabStop = false;
            // 
            // pnlNavMid
            // 
            this.pnlNavMid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.pnlNavMid.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavMid.Location = new System.Drawing.Point(0, 119);
            this.pnlNavMid.Name = "pnlNavMid";
            this.pnlNavMid.Size = new System.Drawing.Size(254, 20);
            this.pnlNavMid.TabIndex = 17;
            // 
            // pnlUser
            // 
            this.pnlUser.BackColor = System.Drawing.Color.White;
            this.pnlUser.Controls.Add(this.lblTtl);
            this.pnlUser.Controls.Add(this.userPicBox);
            this.pnlUser.Controls.Add(this.lblName);
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUser.Location = new System.Drawing.Point(0, 0);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(254, 119);
            this.pnlUser.TabIndex = 17;
            // 
            // lblTtl
            // 
            this.lblTtl.AutoSize = true;
            this.lblTtl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTtl.ForeColor = System.Drawing.Color.Gray;
            this.lblTtl.Location = new System.Drawing.Point(93, 55);
            this.lblTtl.Name = "lblTtl";
            this.lblTtl.Size = new System.Drawing.Size(62, 20);
            this.lblTtl.TabIndex = 1;
            this.lblTtl.Text = "Student";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblName.Location = new System.Drawing.Point(92, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(119, 28);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Jan Janssen";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(0, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(232, 54);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = " FEEDBUFF";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // orderBtn
            // 
            this.orderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.orderBtn.BackColor = System.Drawing.Color.White;
            this.orderBtn.FlatAppearance.BorderSize = 0;
            this.orderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderBtn.ForeColor = System.Drawing.Color.Black;
            this.orderBtn.Location = new System.Drawing.Point(1764, 12);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(143, 34);
            this.orderBtn.TabIndex = 0;
            this.orderBtn.Text = "NEW ORDER";
            this.orderBtn.UseVisualStyleBackColor = false;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(294, 135);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1610, 798);
            this.pnlContent.TabIndex = 29;
            // 
            // pnlTabTitle
            // 
            this.pnlTabTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.pnlTabTitle.Controls.Add(this.lblTabTitle);
            this.pnlTabTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTabTitle.ForeColor = System.Drawing.Color.Black;
            this.pnlTabTitle.Location = new System.Drawing.Point(294, 80);
            this.pnlTabTitle.Name = "pnlTabTitle";
            this.pnlTabTitle.Size = new System.Drawing.Size(1610, 55);
            this.pnlTabTitle.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1904, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 853);
            this.panel2.TabIndex = 22;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(274, 80);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(20, 853);
            this.pnlLeft.TabIndex = 21;
            // 
            // btnFeedback
            // 
            this.btnFeedback.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFeedback.FlatAppearance.BorderSize = 0;
            this.btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeedback.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedback.ForeColor = System.Drawing.Color.Black;
            this.btnFeedback.Location = new System.Drawing.Point(0, 55);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(254, 55);
            this.btnFeedback.TabIndex = 3;
            this.btnFeedback.Text = "FEEDBACK";
            this.btnFeedback.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(254, 55);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.White;
            this.pnlNav.Controls.Add(this.pnlBack);
            this.pnlNav.Controls.Add(this.pnlNavMid);
            this.pnlNav.Controls.Add(this.pnlUser);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNav.Location = new System.Drawing.Point(20, 80);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(254, 853);
            this.pnlNav.TabIndex = 26;
            // 
            // pnlBack
            // 
            this.pnlBack.BackColor = System.Drawing.Color.White;
            this.pnlBack.Controls.Add(this.btnFeedforward);
            this.pnlBack.Controls.Add(this.btnFeedup);
            this.pnlBack.Controls.Add(this.btnFeedback);
            this.pnlBack.Controls.Add(this.btnDashboard);
            this.pnlBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBack.Location = new System.Drawing.Point(0, 139);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(254, 440);
            this.pnlBack.TabIndex = 3;
            // 
            // btnFeedforward
            // 
            this.btnFeedforward.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFeedforward.FlatAppearance.BorderSize = 0;
            this.btnFeedforward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeedforward.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedforward.ForeColor = System.Drawing.Color.Black;
            this.btnFeedforward.Location = new System.Drawing.Point(0, 165);
            this.btnFeedforward.Name = "btnFeedforward";
            this.btnFeedforward.Size = new System.Drawing.Size(254, 55);
            this.btnFeedforward.TabIndex = 5;
            this.btnFeedforward.Text = "FEEDFORWARD";
            this.btnFeedforward.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFeedforward.UseVisualStyleBackColor = true;
            this.btnFeedforward.Click += new System.EventHandler(this.btnFeedforward_Click);
            // 
            // btnFeedup
            // 
            this.btnFeedup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFeedup.FlatAppearance.BorderSize = 0;
            this.btnFeedup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeedup.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedup.ForeColor = System.Drawing.Color.Black;
            this.btnFeedup.Location = new System.Drawing.Point(0, 110);
            this.btnFeedup.Name = "btnFeedup";
            this.btnFeedup.Size = new System.Drawing.Size(254, 55);
            this.btnFeedup.TabIndex = 4;
            this.btnFeedup.Text = "FEEDUP";
            this.btnFeedup.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFeedup.UseVisualStyleBackColor = true;
            this.btnFeedup.Click += new System.EventHandler(this.btnFeedup_Click);
            // 
            // pnlBottem
            // 
            this.pnlBottem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.pnlBottem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottem.Location = new System.Drawing.Point(20, 933);
            this.pnlBottem.Name = "pnlBottem";
            this.pnlBottem.Size = new System.Drawing.Size(1904, 20);
            this.pnlBottem.TabIndex = 25;
            // 
            // pnlMid
            // 
            this.pnlMid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.pnlMid.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMid.Location = new System.Drawing.Point(20, 60);
            this.pnlMid.Name = "pnlMid";
            this.pnlMid.Size = new System.Drawing.Size(1904, 20);
            this.pnlMid.TabIndex = 24;
            // 
            // panelMidConNav
            // 
            this.panelMidConNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.panelMidConNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMidConNav.Location = new System.Drawing.Point(0, 60);
            this.panelMidConNav.Name = "panelMidConNav";
            this.panelMidConNav.Size = new System.Drawing.Size(20, 893);
            this.panelMidConNav.TabIndex = 27;
            // 
            // barPnl
            // 
            this.barPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(115)))), ((int)(((byte)(117)))));
            this.barPnl.Controls.Add(this.titleLbl);
            this.barPnl.Controls.Add(this.orderBtn);
            this.barPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.barPnl.Location = new System.Drawing.Point(0, 0);
            this.barPnl.Name = "barPnl";
            this.barPnl.Size = new System.Drawing.Size(1924, 60);
            this.barPnl.TabIndex = 23;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1924, 953);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTabTitle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.pnlBottem);
            this.Controls.Add(this.pnlMid);
            this.Controls.Add(this.panelMidConNav);
            this.Controls.Add(this.barPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.userPicBox)).EndInit();
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            this.pnlTabTitle.ResumeLayout(false);
            this.pnlTabTitle.PerformLayout();
            this.pnlNav.ResumeLayout(false);
            this.pnlBack.ResumeLayout(false);
            this.barPnl.ResumeLayout(false);
            this.barPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTabTitle;
        private System.Windows.Forms.PictureBox userPicBox;
        private System.Windows.Forms.Panel pnlNavMid;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Label lblTtl;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlTabTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel pnlBack;
        private System.Windows.Forms.Button btnFeedforward;
        private System.Windows.Forms.Button btnFeedup;
        private System.Windows.Forms.Panel pnlBottem;
        private System.Windows.Forms.Panel pnlMid;
        private System.Windows.Forms.Panel panelMidConNav;
        private System.Windows.Forms.Panel barPnl;
    }
}