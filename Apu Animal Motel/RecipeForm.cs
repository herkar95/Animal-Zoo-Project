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
    public partial class RecipeForm : Form
    {
        // Private fields
        private Recipe m_recipe;

        // Properties
        public Recipe Recipe
        {
            get { return m_recipe; }
            set { m_recipe = value; }
        }

        // Constructor(s)
        public RecipeForm()
        {
            InitializeComponent();
            init();
            if (m_recipe == null)
            {
                m_recipe = new Recipe();
            }
        }

        // Initializes the form elements
        private void init()
        {
            textBoxFoodName.Clear();
            textBoxAddIngredient.Clear();
            listViewIngredients.Clear();
            textBoxFoodName.Select();
        }

        // Executes when the user clicks the Cancel button.
        // Calls the init function to reset all textfields
        private void cancelClicked(object sender, EventArgs e)
        {
            init();
            Close();
        }

        // Adds an ingredient to the listview and to the recipe object
        private void addIngredient(object sender, EventArgs e)
        {
            if(textBoxAddIngredient.Text.Trim() != "")
            {
                m_recipe.Ingredients.Add(textBoxAddIngredient.Text);
                listViewIngredients.Items.Add(textBoxAddIngredient.Text);
                clearAddIngredient();
            }
            // If the ingredient value is left empty
            else
            {
                validationNotSuccessful("Ingredient can not be left empty.", "Validation of data unsuccessful");
                clearAddIngredient();
            }
        }

        // Displays a messagebox to the user of what data was not successfully validated.
        public void validationNotSuccessful(string msg, string heading)
        {
            MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Removes an ingredient from the listview
        private void deleteIngredient(object sender, EventArgs e)
        {
            // To make sure that there is an item selected
            if (listViewIngredients.SelectedItems.Count > 0)
            {
                m_recipe.Ingredients.RemoveAt(listViewIngredients.FocusedItem.Index);
                listViewIngredients.SelectedItems[0].Remove();
                clearAddIngredient();
            }
            // If no ingredient is selected
            else
            {
                validationNotSuccessful("No ingredient selected, please select one.", "Unable to delete nothing!");
            }
        }

        // A simple method to clear the text in the Ingredient textbox, aswell as focus it.
        // I noticed that these lines of code appeared very frequently and decided to make a method for it.
        private void clearAddIngredient()
        {
            textBoxAddIngredient.Select();
            textBoxAddIngredient.Clear();
        }

        // Changes the value of the selected ingredient item.
        // Shows an inputbox to the user with the help of the interaction namespace.
        private void changeIngredient(object sender, EventArgs e)
        {
            // To make sure that there is an item selected
            if(listViewIngredients.SelectedItems.Count > 0)
            {
                var selectedItem = listViewIngredients.SelectedItems[0];
                string newValue = Interaction.InputBox("The name of the new ingredient", "Change ingredient name of " + selectedItem.Text, "New value");
                // To make sure the new value is properly formatted.
                if (newValue.Trim() != "")
                {
                    m_recipe.Ingredients[listViewIngredients.FocusedItem.Index] = newValue;
                    selectedItem.Text = newValue;
                    clearAddIngredient();
                }
                // If the new value is not supported or empty.
                else
                {
                    validationNotSuccessful("The new value cannot be empty. Please enter a new one.", "Enter a new value in the field Ingredient");
                    clearAddIngredient();
                }
            }
            // If no ingredient is selected
            else
            {
                validationNotSuccessful("No ingredient selected, please select one.", "Unable to change nothing!");
            }
        }

        // Gets called when the user clicks the OK button in the form.
        private void recipeAddedOK(object sender, EventArgs e)
        {
            // To make sure the recipe has a valid name
            if(textBoxFoodName.Text.Trim() != "")
            {
                // To make sure the recipe contains at least one ingredient
                if(m_recipe.Ingredients.Count > 0)
                {
                    m_recipe.Name = textBoxFoodName.Text;
                    this.DialogResult = DialogResult.OK;
                }
                // If the user tries to click OK with an empty recipe
                else
                {
                    validationNotSuccessful("Please add at least one ingredient to the recipe first.", "Recipe with no ingredients");
                    textBoxAddIngredient.Focus();
                }
            }
            // If the Recipe does not have a valid name
            else
            {
                validationNotSuccessful("Please enter a valid name for the recipe.", "Unvalid recipe name");
                textBoxFoodName.Select();
                textBoxFoodName.Clear();
            }
        }
    }
}
