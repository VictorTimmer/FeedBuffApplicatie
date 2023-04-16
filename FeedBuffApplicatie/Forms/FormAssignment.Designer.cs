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
            this.checkBoxCompleted = new System.Windows.Forms.CheckBox();
            this.labelCompleted = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.dgvAssignment = new System.Windows.Forms.DataGridView();
            this.buttonCreateAssignement = new System.Windows.Forms.Button();
            this.buttonSaveAssignement = new System.Windows.Forms.Button();
            this.buttonDiscardAssignement = new System.Windows.Forms.Button();
            this.buttonDeleteAssignement = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignment)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxCompleted
            // 
            this.checkBoxCompleted.AutoSize = true;
            this.checkBoxCompleted.Location = new System.Drawing.Point(94, 337);
            this.checkBoxCompleted.Name = "checkBoxCompleted";
            this.checkBoxCompleted.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCompleted.TabIndex = 21;
            this.checkBoxCompleted.UseVisualStyleBackColor = true;
            // 
            // labelCompleted
            // 
            this.labelCompleted.AutoSize = true;
            this.labelCompleted.Location = new System.Drawing.Point(22, 337);
            this.labelCompleted.Name = "labelCompleted";
            this.labelCompleted.Size = new System.Drawing.Size(57, 13);
            this.labelCompleted.TabIndex = 20;
            this.labelCompleted.Text = "Completed";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(94, 301);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDate.TabIndex = 19;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(31, 304);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(49, 13);
            this.labelDate.TabIndex = 18;
            this.labelDate.Text = "Deadline";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(20, 272);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 17;
            this.labelDescription.Text = "Description";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(94, 269);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(200, 20);
            this.textBoxDescription.TabIndex = 16;
            // 
            // dgvAssignment
            // 
            this.dgvAssignment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignment.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvAssignment.Location = new System.Drawing.Point(12, 12);
            this.dgvAssignment.Name = "dgvAssignment";
            this.dgvAssignment.Size = new System.Drawing.Size(576, 238);
            this.dgvAssignment.TabIndex = 15;
            this.dgvAssignment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFeedback_CellClick);
            // 
            // buttonCreateAssignement
            // 
            this.buttonCreateAssignement.Location = new System.Drawing.Point(405, 303);
            this.buttonCreateAssignement.Name = "buttonCreateAssignement";
            this.buttonCreateAssignement.Size = new System.Drawing.Size(86, 23);
            this.buttonCreateAssignement.TabIndex = 14;
            this.buttonCreateAssignement.Text = "Create";
            this.buttonCreateAssignement.UseVisualStyleBackColor = true;
            this.buttonCreateAssignement.Click += new System.EventHandler(this.buttonCreateFeedback_Click);
            // 
            // buttonSaveAssignement
            // 
            this.buttonSaveAssignement.Location = new System.Drawing.Point(497, 304);
            this.buttonSaveAssignement.Name = "buttonSaveAssignement";
            this.buttonSaveAssignement.Size = new System.Drawing.Size(86, 23);
            this.buttonSaveAssignement.TabIndex = 13;
            this.buttonSaveAssignement.Text = "Save";
            this.buttonSaveAssignement.UseVisualStyleBackColor = true;
            this.buttonSaveAssignement.Click += new System.EventHandler(this.buttonSaveFeedback_Click);
            // 
            // buttonDiscardAssignement
            // 
            this.buttonDiscardAssignement.Location = new System.Drawing.Point(405, 333);
            this.buttonDiscardAssignement.Name = "buttonDiscardAssignement";
            this.buttonDiscardAssignement.Size = new System.Drawing.Size(86, 23);
            this.buttonDiscardAssignement.TabIndex = 12;
            this.buttonDiscardAssignement.Text = "Discard";
            this.buttonDiscardAssignement.UseVisualStyleBackColor = true;
            this.buttonDiscardAssignement.Click += new System.EventHandler(this.buttonDiscardFeedback_Click);
            // 
            // buttonDeleteAssignement
            // 
            this.buttonDeleteAssignement.Location = new System.Drawing.Point(497, 333);
            this.buttonDeleteAssignement.Name = "buttonDeleteAssignement";
            this.buttonDeleteAssignement.Size = new System.Drawing.Size(86, 23);
            this.buttonDeleteAssignement.TabIndex = 11;
            this.buttonDeleteAssignement.Text = "Delete";
            this.buttonDeleteAssignement.UseVisualStyleBackColor = true;
            this.buttonDeleteAssignement.Click += new System.EventHandler(this.buttonDeleteFeedback_Click);
            // 
            // FormAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.checkBoxCompleted);
            this.Controls.Add(this.labelCompleted);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.dgvAssignment);
            this.Controls.Add(this.buttonCreateAssignement);
            this.Controls.Add(this.buttonSaveAssignement);
            this.Controls.Add(this.buttonDiscardAssignement);
            this.Controls.Add(this.buttonDeleteAssignement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAssignment";
            this.Text = "AssignmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxCompleted;
        private System.Windows.Forms.Label labelCompleted;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.DataGridView dgvAssignment;
        private System.Windows.Forms.Button buttonCreateAssignement;
        private System.Windows.Forms.Button buttonSaveAssignement;
        private System.Windows.Forms.Button buttonDiscardAssignement;
        private System.Windows.Forms.Button buttonDeleteAssignement;
    }
}