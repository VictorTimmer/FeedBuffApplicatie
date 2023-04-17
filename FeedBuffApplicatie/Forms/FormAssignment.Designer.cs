namespace FeedBuffApplicatie.Forms
{
    partial class FormAssignment
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
            this.dgvAssignment = new System.Windows.Forms.DataGridView();
            this.pnlBottem = new System.Windows.Forms.Panel();
            this.checkBoxCompleted = new System.Windows.Forms.CheckBox();
            this.labelCompleted = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonCreateAssignement = new System.Windows.Forms.Button();
            this.buttonSaveAssignement = new System.Windows.Forms.Button();
            this.buttonDiscardAssignement = new System.Windows.Forms.Button();
            this.buttonDeleteAssignement = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignment)).BeginInit();
            this.pnlBottem.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAssignment
            // 
            this.dgvAssignment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssignment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAssignment.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvAssignment.Location = new System.Drawing.Point(0, 0);
            this.dgvAssignment.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAssignment.Name = "dgvAssignment";
            this.dgvAssignment.RowHeadersWidth = 51;
            this.dgvAssignment.Size = new System.Drawing.Size(1647, 739);
            this.dgvAssignment.TabIndex = 15;
            this.dgvAssignment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFeedback_CellClick);
            // 
            // pnlBottem
            // 
            this.pnlBottem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.pnlBottem.Controls.Add(this.checkBoxCompleted);
            this.pnlBottem.Controls.Add(this.labelCompleted);
            this.pnlBottem.Controls.Add(this.dateTimePickerDate);
            this.pnlBottem.Controls.Add(this.labelDate);
            this.pnlBottem.Controls.Add(this.labelDescription);
            this.pnlBottem.Controls.Add(this.textBoxDescription);
            this.pnlBottem.Controls.Add(this.buttonCreateAssignement);
            this.pnlBottem.Controls.Add(this.buttonSaveAssignement);
            this.pnlBottem.Controls.Add(this.buttonDiscardAssignement);
            this.pnlBottem.Controls.Add(this.buttonDeleteAssignement);
            this.pnlBottem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottem.Location = new System.Drawing.Point(0, 489);
            this.pnlBottem.Name = "pnlBottem";
            this.pnlBottem.Size = new System.Drawing.Size(1647, 250);
            this.pnlBottem.TabIndex = 22;
            // 
            // checkBoxCompleted
            // 
            this.checkBoxCompleted.AutoSize = true;
            this.checkBoxCompleted.Location = new System.Drawing.Point(130, 122);
            this.checkBoxCompleted.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxCompleted.Name = "checkBoxCompleted";
            this.checkBoxCompleted.Size = new System.Drawing.Size(18, 17);
            this.checkBoxCompleted.TabIndex = 31;
            this.checkBoxCompleted.UseVisualStyleBackColor = true;
            // 
            // labelCompleted
            // 
            this.labelCompleted.AutoSize = true;
            this.labelCompleted.Location = new System.Drawing.Point(32, 121);
            this.labelCompleted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCompleted.Name = "labelCompleted";
            this.labelCompleted.Size = new System.Drawing.Size(73, 16);
            this.labelCompleted.TabIndex = 30;
            this.labelCompleted.Text = "Completed";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(130, 77);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerDate.TabIndex = 29;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(32, 82);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(62, 16);
            this.labelDate.TabIndex = 28;
            this.labelDate.Text = "Deadline";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(32, 41);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(75, 16);
            this.labelDescription.TabIndex = 27;
            this.labelDescription.Text = "Description";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(130, 38);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(265, 22);
            this.textBoxDescription.TabIndex = 26;
            // 
            // buttonCreateAssignement
            // 
            this.buttonCreateAssignement.Location = new System.Drawing.Point(403, 38);
            this.buttonCreateAssignement.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreateAssignement.Name = "buttonCreateAssignement";
            this.buttonCreateAssignement.Size = new System.Drawing.Size(115, 28);
            this.buttonCreateAssignement.TabIndex = 25;
            this.buttonCreateAssignement.Text = "Create";
            this.buttonCreateAssignement.UseVisualStyleBackColor = true;
            // 
            // buttonSaveAssignement
            // 
            this.buttonSaveAssignement.Location = new System.Drawing.Point(526, 38);
            this.buttonSaveAssignement.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveAssignement.Name = "buttonSaveAssignement";
            this.buttonSaveAssignement.Size = new System.Drawing.Size(115, 28);
            this.buttonSaveAssignement.TabIndex = 24;
            this.buttonSaveAssignement.Text = "Save";
            this.buttonSaveAssignement.UseVisualStyleBackColor = true;
            // 
            // buttonDiscardAssignement
            // 
            this.buttonDiscardAssignement.Location = new System.Drawing.Point(403, 71);
            this.buttonDiscardAssignement.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDiscardAssignement.Name = "buttonDiscardAssignement";
            this.buttonDiscardAssignement.Size = new System.Drawing.Size(115, 28);
            this.buttonDiscardAssignement.TabIndex = 23;
            this.buttonDiscardAssignement.Text = "Discard";
            this.buttonDiscardAssignement.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteAssignement
            // 
            this.buttonDeleteAssignement.Location = new System.Drawing.Point(526, 71);
            this.buttonDeleteAssignement.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteAssignement.Name = "buttonDeleteAssignement";
            this.buttonDeleteAssignement.Size = new System.Drawing.Size(115, 28);
            this.buttonDeleteAssignement.TabIndex = 22;
            this.buttonDeleteAssignement.Text = "Delete";
            this.buttonDeleteAssignement.UseVisualStyleBackColor = true;
            // 
            // FormAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1647, 739);
            this.Controls.Add(this.pnlBottem);
            this.Controls.Add(this.dgvAssignment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAssignment";
            this.Text = "AssignmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignment)).EndInit();
            this.pnlBottem.ResumeLayout(false);
            this.pnlBottem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAssignment;
        private System.Windows.Forms.Panel pnlBottem;
        private System.Windows.Forms.CheckBox checkBoxCompleted;
        private System.Windows.Forms.Label labelCompleted;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonCreateAssignement;
        private System.Windows.Forms.Button buttonSaveAssignement;
        private System.Windows.Forms.Button buttonDiscardAssignement;
        private System.Windows.Forms.Button buttonDeleteAssignement;
    }
}