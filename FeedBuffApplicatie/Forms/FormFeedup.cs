using FeedBuffApplicatie.Classes;
using FeedBuffApplicatie.DAL;
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
    public partial class FormFeedup : Form
    {
        FeeditemDAL feeditemDal;
        FeedupDAL feedupDAL;
        AssignmentDAL assignmentDal;
        UserDAL userDAL;
        SupervisorDAL supervisorDAL;
        StudentDAL studentDAL;

        Feedup selectedItem;

        public FormFeedup(DALs dals)
        {

            InitializeComponent();

            // Contains all of the dals inside
            this.feedupDAL = dals.feedupDAL;
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
            feedupDAL.GetAll();
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
            var bindingSourceReviewedBy = new BindingSource();
            bindingSourceReviewedBy.DataSource = this.supervisorDAL.Supervisors;

            comboBoxReviewedBy.BindingContext = new BindingContext();
            comboBoxReviewedBy.DataSource = bindingSourceReviewedBy.DataSource;
            comboBoxReviewedBy.DisplayMember = "Firstname";
            comboBoxReviewedBy.ValueMember = "Id";


            PopulateDataGridView();
        }


        private void PopulateDataGridView()
        {
            // Goes through every element of the Feedback class and makes a new collumn for each
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(Feedup));
            DataTable dt = new DataTable();

            foreach (PropertyDescriptor p in props)
                dt.Columns.Add(p.Name, p.PropertyType);

            for (int i = 0; i < feedupDAL.Feedups.Count; i++)
            {
                var item = feedupDAL.Feedups[i];

                dt.Rows.Add(
                    item.FeeditemId,
                    item.Priority,
                    item.Reflection,
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
            //comboBoxAssignment.SelectedIndex = 0;
            //comboBoxReviewedBy.SelectedIndex = 0;
            //comboBoxStudent.SelectedIndex = 0;
            //comboBoxSupervisor.SelectedIndex = 0;

            richTextBoxContents.Text = "";
            SetEditMode(false);
        }

        // Populate all inputs with a user instance
        private void PopulateInputs(Feedup item)
        {
            dateTimePickerCreatedDate.Value = item.CreationDate;
            checkBoxCompleted.Checked = item.Completed;

            // Combobox comboBoxSupervisor
            comboBoxSupervisor.SelectedItem = this.supervisorDAL.Supervisors.Find(element => element.Id == item.SupervisorId);

            // Combobox comboBoxReviewedBy - aka ApprovedBy
            comboBoxReviewedBy.SelectedItem = this.supervisorDAL.Supervisors.Find(element => element.Id == item.ApprovedBy);

            // Combobox comboBoxAssignment
            comboBoxAssignment.SelectedItem = this.assignmentDal.Assignments.Find(element => element.Id == item.AssignmentId);

            // Combobox comboBoxStudent - aka StudentId
            comboBoxStudent.SelectedItem = this.studentDAL.Students.Find(element => element.Id == item.StudentId);

            richTextBoxContents.Text = item.Contents;

            richTextBoxReflection.Text = item.Reflection;
            numericUpDownPriority.Value = item.Priority;

            SetEditMode(true);
        }



        private void buttonCreateFeedback_Click(object sender, EventArgs e)
        {
            // Id set to -1 as a placeholder for the autogenerated SQL id
            feedupDAL.Insert(
                new Feedup(
                    -1,
                    dateTimePickerCreatedDate.Value,
                    checkBoxCompleted.Checked,
                    (int)comboBoxReviewedBy.SelectedValue,
                    (int)comboBoxAssignment.SelectedValue,
                    (int)comboBoxSupervisor.SelectedValue,
                    (int)comboBoxStudent.SelectedValue,
                    richTextBoxContents.Text,
                    -1,
                    (int)numericUpDownPriority.Value,
                    richTextBoxReflection.Text
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
                feedupDAL.Delete(selectedItem);
            ClearInputs();
            RefreshAndPopulate();
        }


        private void SelectRowFromDataGridView(int Index)
        {
            // The "header" can be pressed (cauing the below code to break) so make sure that -1 uis not alowed
            if (Index != -1)
            {
                // Data row into a Customer instance with casting (keep it tidy for later)
                selectedItem = new Feedup(
                    (int)dgvFeedback.Rows[Index].Cells[3].Value,
                    (DateTime)dgvFeedback.Rows[Index].Cells[4].Value,
                    (bool)dgvFeedback.Rows[Index].Cells[5].Value,
                    (int)dgvFeedback.Rows[Index].Cells[6].Value,
                    (int)dgvFeedback.Rows[Index].Cells[7].Value,
                    (int)dgvFeedback.Rows[Index].Cells[8].Value,
                    (int)dgvFeedback.Rows[Index].Cells[9].Value,
                    (string)dgvFeedback.Rows[Index].Cells[10].Value,
                    (int)dgvFeedback.Rows[Index].Cells[0].Value,
                    (int)dgvFeedback.Rows[Index].Cells[1].Value,
                    (string)dgvFeedback.Rows[Index].Cells[2].Value
                );

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
                var newItem = new Feedup(
                    selectedItem.Id,
                    dateTimePickerCreatedDate.Value,
                    checkBoxCompleted.Checked,
                    (int)comboBoxReviewedBy.SelectedValue,
                    (int)comboBoxAssignment.SelectedValue,
                    (int)comboBoxSupervisor.SelectedValue,
                    (int)comboBoxStudent.SelectedValue,
                    richTextBoxContents.Text,
                    selectedItem.FeeditemId,
                    (int)numericUpDownPriority.Value,
                    richTextBoxReflection.Text
                );

                feedupDAL.Update(newItem);
                selectedItem = newItem;
                RefreshAndPopulate();
            }
        }
    }
}
