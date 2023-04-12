namespace FeedBuffApplicatie.Forms
{
    partial class FormLogin
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
            this.barPnl = new System.Windows.Forms.Panel();
            this.titleLbl = new System.Windows.Forms.Label();
            this.pnlBottem = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlMid = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlBckgrnd = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.textBoxStudentId = new System.Windows.Forms.TextBox();
            this.btnKeyboard = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.barPnl.SuspendLayout();
            this.pnlBckgrnd.SuspendLayout();
            this.SuspendLayout();
            // 
            // barPnl
            // 
            this.barPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(115)))), ((int)(((byte)(117)))));
            this.barPnl.Controls.Add(this.titleLbl);
            this.barPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.barPnl.Location = new System.Drawing.Point(20, 20);
            this.barPnl.Name = "barPnl";
            this.barPnl.Size = new System.Drawing.Size(382, 60);
            this.barPnl.TabIndex = 17;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(0, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(199, 54);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "FEEDBUF";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBottem
            // 
            this.pnlBottem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.pnlBottem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottem.Location = new System.Drawing.Point(20, 370);
            this.pnlBottem.Name = "pnlBottem";
            this.pnlBottem.Size = new System.Drawing.Size(382, 20);
            this.pnlBottem.TabIndex = 16;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(402, 20);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(20, 370);
            this.pnlRight.TabIndex = 15;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 20);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(20, 370);
            this.pnlLeft.TabIndex = 14;
            // 
            // pnlMid
            // 
            this.pnlMid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.pnlMid.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMid.Location = new System.Drawing.Point(0, 0);
            this.pnlMid.Name = "pnlMid";
            this.pnlMid.Size = new System.Drawing.Size(422, 20);
            this.pnlMid.TabIndex = 18;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(115)))), ((int)(((byte)(117)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(142, 316);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(143, 34);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnlBckgrnd
            // 
            this.pnlBckgrnd.BackColor = System.Drawing.Color.White;
            this.pnlBckgrnd.Controls.Add(this.btnHelp);
            this.pnlBckgrnd.Controls.Add(this.textBoxName);
            this.pnlBckgrnd.Controls.Add(this.lblStudentId);
            this.pnlBckgrnd.Controls.Add(this.lblPassword);
            this.pnlBckgrnd.Controls.Add(this.textBoxStudentId);
            this.pnlBckgrnd.Controls.Add(this.btnKeyboard);
            this.pnlBckgrnd.Controls.Add(this.textBoxPassword);
            this.pnlBckgrnd.Controls.Add(this.btnLogin);
            this.pnlBckgrnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBckgrnd.Location = new System.Drawing.Point(0, 0);
            this.pnlBckgrnd.Name = "pnlBckgrnd";
            this.pnlBckgrnd.Size = new System.Drawing.Size(422, 390);
            this.pnlBckgrnd.TabIndex = 19;
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.AutoSize = true;
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(318, 81);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(30, 36);
            this.btnHelp.TabIndex = 20;
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxName.Location = new System.Drawing.Point(44, 93);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(295, 15);
            this.textBoxName.TabIndex = 19;
            this.textBoxName.WordWrap = false;
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentId.ForeColor = System.Drawing.Color.DimGray;
            this.lblStudentId.Location = new System.Drawing.Point(45, 148);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(81, 17);
            this.lblStudentId.TabIndex = 18;
            this.lblStudentId.Text = "STUDENT ID";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.DimGray;
            this.lblPassword.Location = new System.Drawing.Point(45, 204);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(86, 16);
            this.lblPassword.TabIndex = 17;
            this.lblPassword.Text = "PASSWORD";
            // 
            // textBoxStudentId
            // 
            this.textBoxStudentId.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxStudentId.Location = new System.Drawing.Point(44, 167);
            this.textBoxStudentId.Name = "textBoxStudentId";
            this.textBoxStudentId.Size = new System.Drawing.Size(337, 22);
            this.textBoxStudentId.TabIndex = 16;
            this.textBoxStudentId.Text = " 1248510";
            this.textBoxStudentId.Enter += new System.EventHandler(this.textBoxStudentId_Enter);
            this.textBoxStudentId.Leave += new System.EventHandler(this.textBoxStudentId_Leave);
            // 
            // btnKeyboard
            // 
            this.btnKeyboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKeyboard.AutoSize = true;
            this.btnKeyboard.BackColor = System.Drawing.Color.Transparent;
            this.btnKeyboard.FlatAppearance.BorderSize = 0;
            this.btnKeyboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeyboard.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeyboard.ForeColor = System.Drawing.Color.White;
            this.btnKeyboard.Location = new System.Drawing.Point(356, 77);
            this.btnKeyboard.Name = "btnKeyboard";
            this.btnKeyboard.Size = new System.Drawing.Size(36, 36);
            this.btnKeyboard.TabIndex = 13;
            this.btnKeyboard.UseVisualStyleBackColor = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxPassword.Location = new System.Drawing.Point(44, 223);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(337, 22);
            this.textBoxPassword.TabIndex = 15;
            this.textBoxPassword.Text = " ******";
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 390);
            this.Controls.Add(this.barPnl);
            this.Controls.Add(this.pnlBottem);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlMid);
            this.Controls.Add(this.pnlBckgrnd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.barPnl.ResumeLayout(false);
            this.barPnl.PerformLayout();
            this.pnlBckgrnd.ResumeLayout(false);
            this.pnlBckgrnd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barPnl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Panel pnlBottem;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlMid;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnlBckgrnd;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox textBoxStudentId;
        private System.Windows.Forms.Button btnKeyboard;
        private System.Windows.Forms.TextBox textBoxPassword;
    }
}