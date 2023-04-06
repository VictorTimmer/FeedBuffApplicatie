namespace FeedBuffApplicatie.Forms
{
    partial class FormInloggen
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
            this.InlogBTN = new System.Windows.Forms.Button();
            this.RegistreerBTN = new System.Windows.Forms.Button();
            this.HulpBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UsernameLB = new System.Windows.Forms.Label();
            this.PasswordLB = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InlogBTN
            // 
            this.InlogBTN.Location = new System.Drawing.Point(321, 312);
            this.InlogBTN.Name = "InlogBTN";
            this.InlogBTN.Size = new System.Drawing.Size(212, 49);
            this.InlogBTN.TabIndex = 0;
            this.InlogBTN.Text = "Inloggen";
            this.InlogBTN.UseVisualStyleBackColor = true;
            this.InlogBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistreerBTN
            // 
            this.RegistreerBTN.Location = new System.Drawing.Point(321, 378);
            this.RegistreerBTN.Name = "RegistreerBTN";
            this.RegistreerBTN.Size = new System.Drawing.Size(212, 49);
            this.RegistreerBTN.TabIndex = 1;
            this.RegistreerBTN.Text = "Registreren";
            this.RegistreerBTN.UseVisualStyleBackColor = true;
            // 
            // HulpBTN
            // 
            this.HulpBTN.Location = new System.Drawing.Point(366, 433);
            this.HulpBTN.Name = "HulpBTN";
            this.HulpBTN.Size = new System.Drawing.Size(126, 38);
            this.HulpBTN.TabIndex = 2;
            this.HulpBTN.Text = "Hulp";
            this.HulpBTN.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.PasswordLB);
            this.panel1.Controls.Add(this.UsernameLB);
            this.panel1.Location = new System.Drawing.Point(157, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 127);
            this.panel1.TabIndex = 3;
            // 
            // UsernameLB
            // 
            this.UsernameLB.AutoSize = true;
            this.UsernameLB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UsernameLB.Location = new System.Drawing.Point(70, 33);
            this.UsernameLB.Name = "UsernameLB";
            this.UsernameLB.Size = new System.Drawing.Size(73, 16);
            this.UsernameLB.TabIndex = 0;
            this.UsernameLB.Text = "Username:";
            // 
            // PasswordLB
            // 
            this.PasswordLB.AutoSize = true;
            this.PasswordLB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PasswordLB.Location = new System.Drawing.Point(70, 71);
            this.PasswordLB.Name = "PasswordLB";
            this.PasswordLB.Size = new System.Drawing.Size(70, 16);
            this.PasswordLB.TabIndex = 1;
            this.PasswordLB.Text = "Password:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(163, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 22);
            this.textBox2.TabIndex = 3;
            // 
            // FormInloggen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(913, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HulpBTN);
            this.Controls.Add(this.RegistreerBTN);
            this.Controls.Add(this.InlogBTN);
            this.DoubleBuffered = true;
            this.Name = "FormInloggen";
            this.Text = "FormInloggen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InlogBTN;
        private System.Windows.Forms.Button RegistreerBTN;
        private System.Windows.Forms.Button HulpBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label PasswordLB;
        private System.Windows.Forms.Label UsernameLB;
    }
}