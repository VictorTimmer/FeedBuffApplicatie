namespace FeedBuffApplicatie.Forms
{
    partial class FormFeedback
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
            this.dgvFeedback = new System.Windows.Forms.DataGridView();
            this.pnlBottem = new System.Windows.Forms.Panel();
            this.comboBoxReviewedBy = new System.Windows.Forms.ComboBox();
            this.comboBoxStudent = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBoxContents = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxSupervisor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxCompleted = new System.Windows.Forms.CheckBox();
            this.dateTimePickerCreatedDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBoxNotes = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxAssignment = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCreateFeedback = new System.Windows.Forms.Button();
            this.buttonSaveFeedback = new System.Windows.Forms.Button();
            this.buttonDiscardFeedback = new System.Windows.Forms.Button();
            this.buttonDeleteFeedback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).BeginInit();
            this.pnlBottem.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFeedback
            // 
            this.dgvFeedback.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeedback.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFeedback.Location = new System.Drawing.Point(0, 0);
            this.dgvFeedback.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFeedback.Name = "dgvFeedback";
            this.dgvFeedback.RowHeadersWidth = 51;
            this.dgvFeedback.Size = new System.Drawing.Size(1647, 739);
            this.dgvFeedback.TabIndex = 16;
            this.dgvFeedback.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFeedback_CellClick);
            // 
            // pnlBottem
            // 
            this.pnlBottem.Controls.Add(this.comboBoxReviewedBy);
            this.pnlBottem.Controls.Add(this.comboBoxStudent);
            this.pnlBottem.Controls.Add(this.label8);
            this.pnlBottem.Controls.Add(this.richTextBoxContents);
            this.pnlBottem.Controls.Add(this.label7);
            this.pnlBottem.Controls.Add(this.comboBoxSupervisor);
            this.pnlBottem.Controls.Add(this.label6);
            this.pnlBottem.Controls.Add(this.checkBoxCompleted);
            this.pnlBottem.Controls.Add(this.dateTimePickerCreatedDate);
            this.pnlBottem.Controls.Add(this.label5);
            this.pnlBottem.Controls.Add(this.label4);
            this.pnlBottem.Controls.Add(this.richTextBoxNotes);
            this.pnlBottem.Controls.Add(this.label3);
            this.pnlBottem.Controls.Add(this.comboBoxAssignment);
            this.pnlBottem.Controls.Add(this.label2);
            this.pnlBottem.Controls.Add(this.label1);
            this.pnlBottem.Controls.Add(this.buttonCreateFeedback);
            this.pnlBottem.Controls.Add(this.buttonSaveFeedback);
            this.pnlBottem.Controls.Add(this.buttonDiscardFeedback);
            this.pnlBottem.Controls.Add(this.buttonDeleteFeedback);
            this.pnlBottem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottem.Location = new System.Drawing.Point(0, 489);
            this.pnlBottem.Name = "pnlBottem";
            this.pnlBottem.Size = new System.Drawing.Size(1647, 250);
            this.pnlBottem.TabIndex = 31;
            // 
            // comboBoxReviewedBy
            // 
            this.comboBoxReviewedBy.FormattingEnabled = true;
            this.comboBoxReviewedBy.Location = new System.Drawing.Point(543, 123);
            this.comboBoxReviewedBy.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxReviewedBy.Name = "comboBoxReviewedBy";
            this.comboBoxReviewedBy.Size = new System.Drawing.Size(237, 24);
            this.comboBoxReviewedBy.TabIndex = 50;
            // 
            // comboBoxStudent
            // 
            this.comboBoxStudent.FormattingEnabled = true;
            this.comboBoxStudent.Location = new System.Drawing.Point(543, 53);
            this.comboBoxStudent.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(237, 24);
            this.comboBoxStudent.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 94);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 48;
            this.label8.Text = "Contents";
            // 
            // richTextBoxContents
            // 
            this.richTextBoxContents.Location = new System.Drawing.Point(122, 94);
            this.richTextBoxContents.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxContents.Name = "richTextBoxContents";
            this.richTextBoxContents.Size = new System.Drawing.Size(284, 54);
            this.richTextBoxContents.TabIndex = 47;
            this.richTextBoxContents.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(442, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 46;
            this.label7.Text = "Supervisor";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBoxSupervisor
            // 
            this.comboBoxSupervisor.FormattingEnabled = true;
            this.comboBoxSupervisor.Location = new System.Drawing.Point(543, 19);
            this.comboBoxSupervisor.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSupervisor.Name = "comboBoxSupervisor";
            this.comboBoxSupervisor.Size = new System.Drawing.Size(237, 24);
            this.comboBoxSupervisor.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 44;
            this.label6.Text = "Completed";
            // 
            // checkBoxCompleted
            // 
            this.checkBoxCompleted.AutoSize = true;
            this.checkBoxCompleted.Location = new System.Drawing.Point(122, 63);
            this.checkBoxCompleted.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxCompleted.Name = "checkBoxCompleted";
            this.checkBoxCompleted.Size = new System.Drawing.Size(18, 17);
            this.checkBoxCompleted.TabIndex = 43;
            this.checkBoxCompleted.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerCreatedDate
            // 
            this.dateTimePickerCreatedDate.Location = new System.Drawing.Point(122, 22);
            this.dateTimePickerCreatedDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerCreatedDate.Name = "dateTimePickerCreatedDate";
            this.dateTimePickerCreatedDate.Size = new System.Drawing.Size(284, 22);
            this.dateTimePickerCreatedDate.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Created Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Notes";
            // 
            // richTextBoxNotes
            // 
            this.richTextBoxNotes.Location = new System.Drawing.Point(122, 164);
            this.richTextBoxNotes.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxNotes.Name = "richTextBoxNotes";
            this.richTextBoxNotes.Size = new System.Drawing.Size(284, 54);
            this.richTextBoxNotes.TabIndex = 39;
            this.richTextBoxNotes.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Assignment";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxAssignment
            // 
            this.comboBoxAssignment.FormattingEnabled = true;
            this.comboBoxAssignment.Location = new System.Drawing.Point(543, 88);
            this.comboBoxAssignment.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAssignment.Name = "comboBoxAssignment";
            this.comboBoxAssignment.Size = new System.Drawing.Size(237, 24);
            this.comboBoxAssignment.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Reviewed By";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Student";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonCreateFeedback
            // 
            this.buttonCreateFeedback.AllowDrop = true;
            this.buttonCreateFeedback.Location = new System.Drawing.Point(545, 161);
            this.buttonCreateFeedback.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreateFeedback.Name = "buttonCreateFeedback";
            this.buttonCreateFeedback.Size = new System.Drawing.Size(115, 28);
            this.buttonCreateFeedback.TabIndex = 34;
            this.buttonCreateFeedback.Text = "Create";
            this.buttonCreateFeedback.UseVisualStyleBackColor = true;
            // 
            // buttonSaveFeedback
            // 
            this.buttonSaveFeedback.AllowDrop = true;
            this.buttonSaveFeedback.Location = new System.Drawing.Point(667, 161);
            this.buttonSaveFeedback.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveFeedback.Name = "buttonSaveFeedback";
            this.buttonSaveFeedback.Size = new System.Drawing.Size(115, 28);
            this.buttonSaveFeedback.TabIndex = 33;
            this.buttonSaveFeedback.Text = "Save";
            this.buttonSaveFeedback.UseVisualStyleBackColor = true;
            // 
            // buttonDiscardFeedback
            // 
            this.buttonDiscardFeedback.AllowDrop = true;
            this.buttonDiscardFeedback.Location = new System.Drawing.Point(545, 197);
            this.buttonDiscardFeedback.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDiscardFeedback.Name = "buttonDiscardFeedback";
            this.buttonDiscardFeedback.Size = new System.Drawing.Size(115, 28);
            this.buttonDiscardFeedback.TabIndex = 32;
            this.buttonDiscardFeedback.Text = "Discard";
            this.buttonDiscardFeedback.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteFeedback
            // 
            this.buttonDeleteFeedback.AllowDrop = true;
            this.buttonDeleteFeedback.Location = new System.Drawing.Point(667, 197);
            this.buttonDeleteFeedback.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteFeedback.Name = "buttonDeleteFeedback";
            this.buttonDeleteFeedback.Size = new System.Drawing.Size(115, 28);
            this.buttonDeleteFeedback.TabIndex = 31;
            this.buttonDeleteFeedback.Text = "Delete";
            this.buttonDeleteFeedback.UseVisualStyleBackColor = true;
            // 
            // FormFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1647, 739);
            this.Controls.Add(this.pnlBottem);
            this.Controls.Add(this.dgvFeedback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormFeedback";
            this.Text = "FormFeedback";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).EndInit();
            this.pnlBottem.ResumeLayout(false);
            this.pnlBottem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvFeedback;
        private System.Windows.Forms.Panel pnlBottem;
        private System.Windows.Forms.ComboBox comboBoxReviewedBy;
        private System.Windows.Forms.ComboBox comboBoxStudent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBoxContents;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxSupervisor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxCompleted;
        private System.Windows.Forms.DateTimePicker dateTimePickerCreatedDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBoxNotes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxAssignment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCreateFeedback;
        private System.Windows.Forms.Button buttonSaveFeedback;
        private System.Windows.Forms.Button buttonDiscardFeedback;
        private System.Windows.Forms.Button buttonDeleteFeedback;
    }
}