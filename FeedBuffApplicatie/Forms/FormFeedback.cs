﻿using FeedBuffApplicatie.Classes;
using FeedBuffApplicatie.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedBuffApplicatie.Forms
{
    public partial class FormFeedback : Form
    {
        FeeditemDAL feeditemDal;
        FeedbackDAL feedbackDal;
        AssignmentDAL assignmentDal;
        UserDAL userDAL;
        SupervisorDAL supervisorDAL;
        StudentDAL studentDAL;

        Feedback selectedItem;

        public FormFeedback(DALs dals)
        {
            InitializeComponent();

            // Contains all of the dals inside
            this.feedbackDal = dals.feedbackDAL;
            this.feeditemDal = dals.feeditemDAL;
            this.assignmentDal = dals.assignmentDAL;
            this.userDAL = dals.userDAL;
            this.supervisorDAL = dals.supervisorDAL;
            this.studentDAL = dals.studentDAL;

            RefreshAndPopulate();
            SetEditMode(false);
        }

        private void RefreshAndPopulate()
        {
            assignmentDal.GetAll();
            feeditemDal.GetAll();
            feedbackDal.GetAll();
            userDAL.GetAll();
            supervisorDAL.GetAll();
            studentDAL.GetAll();

            // ASSIGNMENT COMBO BOX
            var bindingSourceAssignment = new BindingSource();
            bindingSourceAssignment.DataSource = this.assignmentDal.Assignments;

            comboBoxAssignment.DataSource = bindingSourceAssignment.DataSource;
            comboBoxAssignment.DisplayMember = "Description";
            comboBoxAssignment.ValueMember = "Id";


            // STUDENT COMBO BOX
            var bindingSourceStudent = new BindingSource();
            bindingSourceStudent.DataSource = this.studentDAL.Students;

            comboBoxStudent.DataSource = bindingSourceStudent.DataSource;
            comboBoxStudent.DisplayMember = "Firstname";
            comboBoxStudent.ValueMember = "Id";


            // SUPERVISOR COMBO BOX
            var bindingSourceSupervisor = new BindingSource();
            bindingSourceSupervisor.DataSource = this.supervisorDAL.Supervisors;

            comboBoxSupervisor.DataSource = bindingSourceSupervisor.DataSource;
            comboBoxSupervisor.DisplayMember = "Firstname";
            comboBoxSupervisor.ValueMember = "Id";
            // AND REVIEWED BY
            comboBoxReviewedBy.DataSource = bindingSourceSupervisor.DataSource;
            comboBoxReviewedBy.DisplayMember = "Firstname";
            comboBoxReviewedBy.ValueMember = "Id";


            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            // Goes through every element of the Feedback class and makes a new collumn for each
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(Feedback));
            DataTable dt = new DataTable();

            foreach (PropertyDescriptor p in props)
                dt.Columns.Add(p.Name, p.PropertyType);

            for (int i = 0; i < feedbackDal.Feedbacks.Count; i++)
            {
                var item = feedbackDal.Feedbacks[i];

                dt.Rows.Add(
                    item.FeeditemId,
                    item.Notes,
                    item.Id,
                    item.CreationDate,
                    item.Completed,
                    item.ApprovedBy,
                    item.AssignmentId,
                    item.SupervisorId,
                    item.StudentId,
                    item.Contents
                );
            }

            dgvFeedback.DataSource = dt;

            //dgvFeedback.Columns[0].Visible = false;
        }

        // Toggle between 'editMode' and 'addMode'
        private void SetEditMode(Boolean editModeEnabled)
        {
            // Just to make sure users know that adding won't edit the selected
            buttonCreateFeedback.Text = editModeEnabled ? "Append" : "Create";
            buttonDiscardFeedback.Enabled = editModeEnabled;
            buttonSaveFeedback.Enabled = editModeEnabled;
            buttonDeleteFeedback.Enabled = editModeEnabled;
        }

        // Clear all inputs to an empty default
        private void ClearInputs()
        {
            dateTimePickerCreatedDate.Value = DateTime.Now;
            checkBoxCompleted.Checked = false;
            // TODO Comboboxes
            richTextBoxNotes.Text = "";
            richTextBoxContents.Text = "";
            SetEditMode(false);
        }

        // Populate all inputs with a user instance
        private void PopulateInputs(Feedback item)
        {
            dateTimePickerCreatedDate.Value = item.CreationDate;
            checkBoxCompleted.Checked = item.Completed;
            // TODO Comboboxes
            richTextBoxNotes.Text = item.Notes;
            richTextBoxContents.Text = item.Contents;

            SetEditMode(true);
        }

        private void buttonCreateFeedback_Click(object sender, EventArgs e)
        {
            // Id set to -1 as a placeholder for the autogenerated SQL id
            feedbackDal.Insert(
                new Feedback(
                    -1,
                    dateTimePickerCreatedDate.Value,
                    checkBoxCompleted.Checked,
                    1,
                    1,
                    1,
                    1,
                    // TODO: Fix
                    richTextBoxContents.Text,
                    1,
                    richTextBoxNotes.Text
                )
            );
            selectedItem = null;
            ClearInputs();
            RefreshAndPopulate();
        }

        private void buttonDiscardFeedback_Click(object sender, EventArgs e)
        {
            if (selectedItem != null)
                PopulateInputs(selectedItem);
        }

        private void buttonDeleteFeedback_Click(object sender, EventArgs e)
        {
            if (selectedItem != null)
                feedbackDal.Delete(selectedItem);
            ClearInputs();
            RefreshAndPopulate();
        }

        private void SelectRowFromDataGridView(int Index)
        {
            // The "header" can be pressed (cauing the below code to break) so make sure that -1 uis not alowed
            if (Index != -1)
            {
                // Data row into a Customer instance with casting (keep it tidy for later)
                selectedItem = new Feedback(
                    (int)dgvFeedback.Rows[Index].Cells[2].Value,
                    (DateTime)dgvFeedback.Rows[Index].Cells[3].Value,
                    (bool)dgvFeedback.Rows[Index].Cells[4].Value,
                    (int)dgvFeedback.Rows[Index].Cells[5].Value,
                    (int)dgvFeedback.Rows[Index].Cells[6].Value,
                    (int)dgvFeedback.Rows[Index].Cells[7].Value,
                    (int)dgvFeedback.Rows[Index].Cells[8].Value,
                    (string)dgvFeedback.Rows[Index].Cells[9].Value,
                    (int)dgvFeedback.Rows[Index].Cells[0].Value,
                    (string)dgvFeedback.Rows[Index].Cells[1].Value
                );

                //Debug.WriteLine(Index);
                //foreach (DataGridViewCell cell in (dgvFeedback.Rows[Index].Cells))
                //{
                //    Debug.WriteLine(cell.Value);
                //}
                PopulateInputs(selectedItem);
            }
        }


        private void dgvFeedback_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (sender is DataGridView)
            {
                // Make sure sender is a grid view
                DataGridView dgv = (DataGridView)sender;

                // Only if clicking a real row (not the empty bottom one)
                if (e.RowIndex + 1 < dgv.RowCount)
                    SelectRowFromDataGridView(e.RowIndex);
            }
        }

        private void buttonSaveFeedback_Click(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                var newItem = new Feedback(
                    selectedItem.Id,
                    dateTimePickerCreatedDate.Value,
                    checkBoxCompleted.Checked,
                    (int)comboBoxReviewedBy.SelectedValue,
                    (int)comboBoxAssignment.SelectedValue,
                    (int)comboBoxSupervisor.SelectedValue,
                    (int)comboBoxStudent.SelectedValue,
                    richTextBoxContents.Text,
                    selectedItem.FeeditemId,
                    richTextBoxNotes.Text
                );

                feedbackDal.Update(newItem);
                selectedItem = newItem;
                RefreshAndPopulate();
            }
        }
    }
}
