namespace FeedBuffApplicatie.Forms
{
    partial class FormFeedup
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
            this.buttonSaveFeedback = new System.Windows.Forms.Button();
            this.buttonDiscardFeedback = new System.Windows.Forms.Button();
            this.buttonDeleteFeedback = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvFeedback = new System.Windows.Forms.DataGridView();
            this.comboBoxAssignment = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerCreatedDate = new System.Windows.Forms.DateTimePicker();
            this.checkBoxCompleted = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxSupervisor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBoxContents = new System.Windows.Forms.RichTextBox();
            this.comboBoxStudent = new System.Windows.Forms.ComboBox();
            this.comboBoxReviewedBy = new System.Windows.Forms.ComboBox();
            this.buttonCreateFeedback = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBoxReflection = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownPriority = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPriority)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSaveFeedback
            // 
            this.buttonSaveFeedback.AllowDrop = true;
            this.buttonSaveFeedback.Location = new System.Drawing.Point(502, 301);
            this.buttonSaveFeedback.Name = "buttonSaveFeedback";
            this.buttonSaveFeedback.Size = new System.Drawing.Size(86, 23);
            this.buttonSaveFeedback.TabIndex = 10;
            this.buttonSaveFeedback.Text = "Save";
            this.buttonSaveFeedback.UseVisualStyleBackColor = true;
            this.buttonSaveFeedback.Click += new System.EventHandler(this.buttonSaveFeedback_Click);
            // 
            // buttonDiscardFeedback
            // 
            this.buttonDiscardFeedback.AllowDrop = true;
            this.buttonDiscardFeedback.Location = new System.Drawing.Point(410, 330);
            this.buttonDiscardFeedback.Name = "buttonDiscardFeedback";
            this.buttonDiscardFeedback.Size = new System.Drawing.Size(86, 23);
            this.buttonDiscardFeedback.TabIndex = 9;
            this.buttonDiscardFeedback.Text = "Discard";
            this.buttonDiscardFeedback.UseVisualStyleBackColor = true;
            this.buttonDiscardFeedback.Click += new System.EventHandler(this.buttonDiscardFeedback_Click);
            // 
            // buttonDeleteFeedback
            // 
            this.buttonDeleteFeedback.AllowDrop = true;
            this.buttonDeleteFeedback.Location = new System.Drawing.Point(502, 330);
            this.buttonDeleteFeedback.Name = "buttonDeleteFeedback";
            this.buttonDeleteFeedback.Size = new System.Drawing.Size(86, 23);
            this.buttonDeleteFeedback.TabIndex = 8;
            this.buttonDeleteFeedback.Text = "Delete";
            this.buttonDeleteFeedback.UseVisualStyleBackColor = true;
            this.buttonDeleteFeedback.Click += new System.EventHandler(this.buttonDeleteFeedback_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Student";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Reviewed By";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvFeedback
            // 
            this.dgvFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeedback.Location = new System.Drawing.Point(12, 12);
            this.dgvFeedback.Name = "dgvFeedback";
            this.dgvFeedback.Size = new System.Drawing.Size(576, 162);
            this.dgvFeedback.TabIndex = 16;
            this.dgvFeedback.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFeedback_CellClick);
            // 
            // comboBoxAssignment
            // 
            this.comboBoxAssignment.FormattingEnabled = true;
            this.comboBoxAssignment.Location = new System.Drawing.Point(409, 241);
            this.comboBoxAssignment.Name = "comboBoxAssignment";
            this.comboBoxAssignment.Size = new System.Drawing.Size(179, 21);
            this.comboBoxAssignment.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Assignment";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Created Date";
            // 
            // dateTimePickerCreatedDate
            // 
            this.dateTimePickerCreatedDate.Location = new System.Drawing.Point(93, 187);
            this.dateTimePickerCreatedDate.Name = "dateTimePickerCreatedDate";
            this.dateTimePickerCreatedDate.Size = new System.Drawing.Size(214, 20);
            this.dateTimePickerCreatedDate.TabIndex = 22;
            // 
            // checkBoxCompleted
            // 
            this.checkBoxCompleted.AutoSize = true;
            this.checkBoxCompleted.Location = new System.Drawing.Point(93, 215);
            this.checkBoxCompleted.Name = "checkBoxCompleted";
            this.checkBoxCompleted.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCompleted.TabIndex = 23;
            this.checkBoxCompleted.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Completed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(346, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Supervisor";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBoxSupervisor
            // 
            this.comboBoxSupervisor.FormattingEnabled = true;
            this.comboBoxSupervisor.Location = new System.Drawing.Point(409, 185);
            this.comboBoxSupervisor.Name = "comboBoxSupervisor";
            this.comboBoxSupervisor.Size = new System.Drawing.Size(179, 21);
            this.comboBoxSupervisor.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Contents";
            // 
            // richTextBoxContents
            // 
            this.richTextBoxContents.Location = new System.Drawing.Point(93, 236);
            this.richTextBoxContents.Name = "richTextBoxContents";
            this.richTextBoxContents.Size = new System.Drawing.Size(214, 40);
            this.richTextBoxContents.TabIndex = 27;
            this.richTextBoxContents.Text = "";
            // 
            // comboBoxStudent
            // 
            this.comboBoxStudent.FormattingEnabled = true;
            this.comboBoxStudent.Location = new System.Drawing.Point(409, 213);
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(179, 21);
            this.comboBoxStudent.TabIndex = 29;
            // 
            // comboBoxReviewedBy
            // 
            this.comboBoxReviewedBy.FormattingEnabled = true;
            this.comboBoxReviewedBy.Location = new System.Drawing.Point(409, 270);
            this.comboBoxReviewedBy.Name = "comboBoxReviewedBy";
            this.comboBoxReviewedBy.Size = new System.Drawing.Size(179, 21);
            this.comboBoxReviewedBy.TabIndex = 30;
            // 
            // buttonCreateFeedback
            // 
            this.buttonCreateFeedback.AllowDrop = true;
            this.buttonCreateFeedback.Location = new System.Drawing.Point(410, 301);
            this.buttonCreateFeedback.Name = "buttonCreateFeedback";
            this.buttonCreateFeedback.Size = new System.Drawing.Size(86, 23);
            this.buttonCreateFeedback.TabIndex = 31;
            this.buttonCreateFeedback.Text = "Create";
            this.buttonCreateFeedback.UseVisualStyleBackColor = true;
            this.buttonCreateFeedback.Click += new System.EventHandler(this.buttonCreateFeedback_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Reflection";
            // 
            // richTextBoxReflection
            // 
            this.richTextBoxReflection.Location = new System.Drawing.Point(93, 318);
            this.richTextBoxReflection.Name = "richTextBoxReflection";
            this.richTextBoxReflection.Size = new System.Drawing.Size(214, 40);
            this.richTextBoxReflection.TabIndex = 32;
            this.richTextBoxReflection.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Priority";
            // 
            // numericUpDownPriority
            // 
            this.numericUpDownPriority.Location = new System.Drawing.Point(93, 288);
            this.numericUpDownPriority.Name = "numericUpDownPriority";
            this.numericUpDownPriority.Size = new System.Drawing.Size(214, 20);
            this.numericUpDownPriority.TabIndex = 35;
            // 
            // FormFeedup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.numericUpDownPriority);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBoxReflection);
            this.Controls.Add(this.buttonCreateFeedback);
            this.Controls.Add(this.comboBoxReviewedBy);
            this.Controls.Add(this.comboBoxStudent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.richTextBoxContents);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxSupervisor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBoxCompleted);
            this.Controls.Add(this.dateTimePickerCreatedDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxAssignment);
            this.Controls.Add(this.dgvFeedback);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSaveFeedback);
            this.Controls.Add(this.buttonDiscardFeedback);
            this.Controls.Add(this.buttonDeleteFeedback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormFeedup";
            this.Text = "FormFeedback";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPriority)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSaveFeedback;
        private System.Windows.Forms.Button buttonDiscardFeedback;
        private System.Windows.Forms.Button buttonDeleteFeedback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvFeedback;
        private System.Windows.Forms.ComboBox comboBoxAssignment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerCreatedDate;
        private System.Windows.Forms.CheckBox checkBoxCompleted;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxSupervisor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBoxContents;
        private System.Windows.Forms.ComboBox comboBoxStudent;
        private System.Windows.Forms.ComboBox comboBoxReviewedBy;
        private System.Windows.Forms.Button buttonCreateFeedback;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBoxReflection;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownPriority;
    }
}