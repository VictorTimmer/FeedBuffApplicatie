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
    public partial class FormFeedback : Form
    {
        FeedbackDAL feedbackDal;

        public FormFeedback(DALs dals)
        {
            InitializeComponent();

            this.feedbackDal = dals.feedbackDAL; // Contains all of the dals inside

            RefreshAndPopulate();
            SetEditMode(false);
        }

        private void RefreshAndPopulate()
        {
            feedbackDal.GetAll();

            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = this.feedbackDal.Feedbacks;

            //comboBoxCategory.DataSource = bindingSource1.DataSource;
            //comboBoxCategory.DisplayMember = "Name";
            //comboBoxCategory.ValueMember = "Id";

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
                    item.StudentId,
                    item.AssignmentId,
                    item.SupervisorId,
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

        // Populate all inputs with a user instance
        private void PopulateInputs(Feedback item)
        {
            //textBoxName.Text = item.Name;
            //textBoxPrice.Text = item.Price.ToString();
            //textBoxDescription.Text = item.Description;
            //textBoxStockCount.Text = item.StockCount.ToString();
            //comboBoxCategory.SelectedItem = item.Category;
            ////comboBoxCategory
            ////textBoxName.Text = item.Category.Id;
            //SetEditMode(true);
        }
    }
}
