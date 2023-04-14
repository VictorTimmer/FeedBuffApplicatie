namespace FeedBuffApplicatie.Forms
{
    partial class FormFeedforward
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
            this.buttonDeleteFeedForward = new System.Windows.Forms.Button();
            this.buttonDiscardFeedForward = new System.Windows.Forms.Button();
            this.buttonSaveFeedForward = new System.Windows.Forms.Button();
            this.buttonCreateFeedForward = new System.Windows.Forms.Button();
            this.dgvFeedforward = new System.Windows.Forms.DataGridView();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedforward)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDeleteFeedForward
            // 
            this.buttonDeleteFeedForward.AllowDrop = true;
            this.buttonDeleteFeedForward.Location = new System.Drawing.Point(502, 328);
            this.buttonDeleteFeedForward.Name = "buttonDeleteFeedForward";
            this.buttonDeleteFeedForward.Size = new System.Drawing.Size(86, 23);
            this.buttonDeleteFeedForward.TabIndex = 0;
            this.buttonDeleteFeedForward.Text = "Delete";
            this.buttonDeleteFeedForward.UseVisualStyleBackColor = true;
            // 
            // buttonDiscardFeedForward
            // 
            this.buttonDiscardFeedForward.AllowDrop = true;
            this.buttonDiscardFeedForward.Location = new System.Drawing.Point(410, 328);
            this.buttonDiscardFeedForward.Name = "buttonDiscardFeedForward";
            this.buttonDiscardFeedForward.Size = new System.Drawing.Size(86, 23);
            this.buttonDiscardFeedForward.TabIndex = 1;
            this.buttonDiscardFeedForward.Text = "Discard";
            this.buttonDiscardFeedForward.UseVisualStyleBackColor = true;
            // 
            // buttonSaveFeedForward
            // 
            this.buttonSaveFeedForward.AllowDrop = true;
            this.buttonSaveFeedForward.Location = new System.Drawing.Point(502, 299);
            this.buttonSaveFeedForward.Name = "buttonSaveFeedForward";
            this.buttonSaveFeedForward.Size = new System.Drawing.Size(86, 23);
            this.buttonSaveFeedForward.TabIndex = 2;
            this.buttonSaveFeedForward.Text = "Save";
            this.buttonSaveFeedForward.UseVisualStyleBackColor = true;
            // 
            // buttonCreateFeedForward
            // 
            this.buttonCreateFeedForward.AllowDrop = true;
            this.buttonCreateFeedForward.Location = new System.Drawing.Point(410, 299);
            this.buttonCreateFeedForward.Name = "buttonCreateFeedForward";
            this.buttonCreateFeedForward.Size = new System.Drawing.Size(86, 23);
            this.buttonCreateFeedForward.TabIndex = 3;
            this.buttonCreateFeedForward.Text = "Create";
            this.buttonCreateFeedForward.UseVisualStyleBackColor = true;
            // 
            // dgvFeedforward
            // 
            this.dgvFeedforward.AllowDrop = true;
            this.dgvFeedforward.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeedforward.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvFeedforward.Location = new System.Drawing.Point(12, 12);
            this.dgvFeedforward.Name = "dgvFeedforward";
            this.dgvFeedforward.Size = new System.Drawing.Size(561, 150);
            this.dgvFeedforward.TabIndex = 4;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.AllowDrop = true;
            this.textBoxDescription.Location = new System.Drawing.Point(90, 291);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(200, 20);
            this.textBoxDescription.TabIndex = 5;
            // 
            // labelDescription
            // 
            this.labelDescription.AllowDrop = true;
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(12, 291);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(59, 13);
            this.labelDescription.TabIndex = 6;
            this.labelDescription.Text = "Created By";
            // 
            // labelDate
            // 
            this.labelDate.AllowDrop = true;
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(12, 317);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(72, 13);
            this.labelDate.TabIndex = 7;
            this.labelDate.Text = "Creation Time";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.AllowDrop = true;
            this.dateTimePickerDate.Location = new System.Drawing.Point(90, 317);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDate.TabIndex = 8;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(90, 178);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(200, 96);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Feed Forward";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Reviewed By";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(374, 197);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(374, 233);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Completed";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FormFeedforward
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.dgvFeedforward);
            this.Controls.Add(this.buttonCreateFeedForward);
            this.Controls.Add(this.buttonSaveFeedForward);
            this.Controls.Add(this.buttonDiscardFeedForward);
            this.Controls.Add(this.buttonDeleteFeedForward);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormFeedforward";
            this.Text = "FormFeedforward";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedforward)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDeleteFeedForward;
        private System.Windows.Forms.Button buttonDiscardFeedForward;
        private System.Windows.Forms.Button buttonSaveFeedForward;
        private System.Windows.Forms.Button buttonCreateFeedForward;
        private System.Windows.Forms.DataGridView dgvFeedforward;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}