using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Apu_Animal_Motel
{
    public partial class StaffForm : Form
    {
        // Private fields
        private Staff m_staff;

        // Properties
        public Staff Staff
        {
            get { return m_staff; }
            set { m_staff = value; }
        }

        // Constructor(s)
        public StaffForm()
        {
            InitializeComponent();
            init();
            if (m_staff == null)
            {
                m_staff = new Staff();
            }
        }

        // Initializes the form elements
        private void init()
        {
            textBoxStaffName.Clear();
            textBoxAddQual.Clear();
            listViewQualifications.Clear();
            textBoxStaffName.Select();
        }

        // Executes when the user clicks the Cancel button.
        // Calls the init function to reset all textfields
        private void cancelClicked(object sender, EventArgs e)
        {
            init();
            Close();
        }

        // Displays a messagebox to the user of what data was not successfully validated.
        public void validationNotSuccessful(string msg, string heading)
        {
            MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // A simple method to clear the text in the Qualification textbox, aswell as focus it.
        // I noticed that these lines of code appeared very frequently and decided to make a method for it.
        private void clearQualifications()
        {
            textBoxAddQual.Select();
            textBoxAddQual.Clear();
        }

        // Adds a qualification to the listview and to the Staff object
        private void addQualification(object sender, EventArgs e)
        {
            if (textBoxAddQual.Text.Trim() != "")
            {
                m_staff.Qualifications.Add(textBoxAddQual.Text);
                listViewQualifications.Items.Add(textBoxAddQual.Text);
                clearQualifications();
            }
            // If the qualification value is left empty
            else
            {
                validationNotSuccessful("Qualification can not be left empty.", "Validation of data unsuccessful");
                clearQualifications();
            }
        }

        // Gets called when the user clicks the OK button in the form.
        private void staffAddedOK(object sender, EventArgs e)
        {
            // To make sure the staff member has a valid name (not empty)
            if (textBoxStaffName.Text.Trim() != "")
            {
                // To make sure the staff member contains at least one qualification.
                if (m_staff.Qualifications.Count > 0)
                {
                    m_staff.Name = textBoxStaffName.Text;
                    this.DialogResult = DialogResult.OK;
                }
                // If the user tries to click OK with no qualifications added.
                else
                {
                    validationNotSuccessful("Please add at least one qualification to the staff member first.", "Staff member not qualified");
                    textBoxAddQual.Focus();
                }
            }
            // If the Staff member does not have a valid name
            else
            {
                validationNotSuccessful("Please enter a valid name for the staff member.", "Unvalid staff member name");
                textBoxStaffName.Select();
                textBoxStaffName.Clear();
            }
        }

        // Changes the value of the selected qualification item.
        // Shows an inputbox to the user with the help of the interaction namespace.
        private void changeQualification(object sender, EventArgs e)
        {
            // To make sure that there is an item selected
            if (listViewQualifications.SelectedItems.Count > 0)
            {
                var selectedItem = listViewQualifications.SelectedItems[0];
                string newValue = Interaction.InputBox("The name of the new qualification", "Change qualification name of " + selectedItem.Text, "New value");
                // To make sure the new value is properly formatted.
                if (newValue.Trim() != "")
                {
                    m_staff.Qualifications.ChangeAt(newValue, listViewQualifications.FocusedItem.Index);
                    selectedItem.Text = newValue;
                    clearQualifications();
                }
                // If the new value is not supported or empty.
                else
                {
                    validationNotSuccessful("The new value cannot be empty. Please enter a new one.", "Enter a new value in the field Qualification");
                    clearQualifications();
                }
            }
            // If no qualification is selected
            else
            {
                validationNotSuccessful("No qualification selected, please select one.", "Unable to change nothing!");
            }
        }

        // Removes a qualification from the listview.
        private void deleteQualification(object sender, EventArgs e)
        {
            // To make sure that there is an item selected
            if (listViewQualifications.SelectedItems.Count > 0)
            {
                m_staff.Qualifications.DeleteAt(listViewQualifications.FocusedItem.Index);
                listViewQualifications.SelectedItems[0].Remove();
                clearQualifications();
            }
            // If no qualification is selected
            else
            {
                validationNotSuccessful("No qualification selected, please select one.", "Unable to delete nothing!");
            }
        }
    }
}
