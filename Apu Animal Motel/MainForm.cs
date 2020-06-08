using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace Apu_Animal_Motel
{
    public partial class MainForm : Form
    {
        // Private fields
        private AnimalManager animalManager;
        private RecipeManager recipeManager;
        private bool unsavedChanges; // this boolean keeps track of changes made in the program
                                     // true, if an animal/recipe/staff gets added.
        private CurrentFileType currentFileType;
        private string currentFileName = "undefined";

        // Runs on execution
        public MainForm()
        {
            InitializeComponent();
            animalManager = new AnimalManager();
            recipeManager = new RecipeManager();
            initInterface();
        }

        /* Initializes the user interface and its values.
        This function is also called after an animal has been added. */
        private void initInterface()
        {
            // Initializes elements and clears all text from input fields. 
            listBoxCategories.Items.Clear();
            listBoxGenders.Items.Clear();
            listBoxAnimalObjects.Items.Clear();
            textBoxCategoryAttr.Clear();
            textBoxAnimalAttr.Clear();
            textBoxAge.Clear();
            textboxName.Clear();
            textboxName.Focus();
            textBoxEaterType.Clear();
            textBoxFoodSchedule.Clear();
            labelSelectedAnimal.Visible = false;
            this.Height = 580;
            this.Width = 1100;

            // Populates the categories listbox with the values defined in the enum 'CategoryType'
            listBoxCategories.Items.AddRange(Enum.GetNames(typeof(CategoryType)));
            // Populates the genders listbox with the values defined in the enum GenderType
            listBoxGenders.Items.AddRange(Enum.GetNames(typeof(GenderType)));

            // Hides the elements in the category specifications before a category is selected
            labelCategoryAttr.Visible = false;
            textBoxCategoryAttr.Visible = false;
            labelAnimalAttr.Visible = false;
            textBoxAnimalAttr.Visible = false;

            unsavedChanges = false;
        }

        // Resets some specific elements
        private void Reset()
        {
            animalManager.Reset();
            recipeManager.Reset();
            listViewDetails.Items.Clear();
            listViewAnimals.Items.Clear();
            currentFileType = CurrentFileType.None;
            currentFileName = "undefined";
        }

        // Updates listbox, as well as the specifications tab
        private void updateInterface(object sender, EventArgs e)
        {
            // Resets and clears certain elements if the user switches the selected category.
            listBoxAnimalObjects.Items.Clear();
            labelAnimalAttr.Visible = false;
            textBoxAnimalAttr.Visible = false;
            textBoxCategoryAttr.Clear();
            textBoxAnimalAttr.Clear();

            // To make sure there actually is a category selected.
            if (listBoxCategories.SelectedItem != null)
            {
                CategoryType selectedCategory = getSelectedCategory();
                populateAnimalObjectsList(selectedCategory);
                populateCategorySpecifications(selectedCategory);
            }
        }

        // Fetches and returns the selected category.
        private CategoryType getSelectedCategory()
        {
            return (CategoryType)Enum.Parse(typeof(CategoryType), listBoxCategories.SelectedItem.ToString());
        }

        /* Populates the animalObjects listbox with animals of type Mammal or Bird,
         depending on the category selected. */
        private void populateAnimalObjectsList(CategoryType selectedItem)
        {
            switch (selectedItem)
            {
                case CategoryType.Mammal:
                    listBoxAnimalObjects.Items.AddRange(Enum.GetNames(typeof(MammalSpecies)));
                    break;
                case CategoryType.Bird:
                    listBoxAnimalObjects.Items.AddRange(Enum.GetNames(typeof(BirdSpecies)));
                    break;
            }
            // 'Mammal specifications', 'Bird specifications' etc... as title of groupbox
            groupBoxCategorySpec.Text = selectedItem.ToString() + " Specifications";
        }

        // Populates the category specifications tab depending on which category is selected
        private void populateCategorySpecifications(CategoryType selectedCategory)
        {
            // Makes certain elements visible (previously hidden)
            labelCategoryAttr.Visible = true;
            textBoxCategoryAttr.Visible = true;

            switch (selectedCategory)
            {
                case CategoryType.Bird:
                    labelCategoryAttr.Text = "Flying speed(mph): ";
                    break;
                case CategoryType.Mammal:
                    labelCategoryAttr.Text = "Number of teeth: ";
                    break;
            }
        }

        // Populates the feeding schedule tab when the user selects an animal in the listview
        private void populateFeedingSchedule(object sender, EventArgs e)
        {
            if (listViewAnimals.FocusedItem != null && listViewAnimals.FocusedItem.Index != -1)
            {
                Animal animal;
                animal = animalManager.GetAt(listViewAnimals.FocusedItem.Index);
                textBoxEaterType.Text = animal.GetEaterType().ToString();
                textBoxFoodSchedule.Text = "To be fed four times as follows: " + Environment.NewLine + animal.FoodSchedule.ToString();

                // Displays the name of the selected animal
                labelSelectedAnimal.Text = animal.Name;
                labelSelectedAnimal.Visible = true;
            }
        }

        /* Shows attribute(s) for the specific animal selected.
        This function gets called when the value of the selected animal in
        the listbox changes. */
        private void showSpecificAnimalAttributes(object sender, EventArgs e)
        {
            if (listBoxAnimalObjects.SelectedItem != null)
            {
                labelAnimalAttr.Visible = true;
                textBoxAnimalAttr.Visible = true;
                CategoryType category = getSelectedCategory();

                switch (category)
                {
                    case CategoryType.Bird:
                        BirdSpecies bird = (BirdSpecies)Enum.Parse(typeof(BirdSpecies), listBoxAnimalObjects.SelectedItem.ToString());
                        switch (bird)
                        {
                            case BirdSpecies.Crow:
                                labelAnimalAttr.Text = "Weight(kg): ";
                                break;
                            case BirdSpecies.Eagle:
                                labelAnimalAttr.Text = "Wing spread(cm): ";
                                break;
                            case BirdSpecies.Vulture:
                                labelAnimalAttr.Text = "Neck color: ";
                                break;
                        }
                        break;

                    case CategoryType.Mammal:
                        MammalSpecies mammal = (MammalSpecies)Enum.Parse(typeof(MammalSpecies), listBoxAnimalObjects.SelectedItem.ToString());
                        switch (mammal)
                        {
                            case MammalSpecies.Cat:
                                labelAnimalAttr.Text = "Whisker length(cm): ";
                                break;
                            case MammalSpecies.Dog:
                                labelAnimalAttr.Text = "Breed: ";
                                break;
                            case MammalSpecies.Lion:
                                labelAnimalAttr.Text = "Tail length(cm): ";
                                break;
                        }
                        break;
                }
            }
        }

        // Adds an animal to the list in AnimalManager(via ListManager).
        private void addAnimal(object sender, EventArgs e)
        {
            Animal animalObject;

            if (listBoxCategories.SelectedItem != null)
            {
                if (listBoxAnimalObjects.SelectedItem != null)
                {
                    CategoryType selectedCategory = getSelectedCategory();
                    /* Depending on the category selected, an animal object
                     will be created of type Mammal or Bird, by calling either
                     the MammalFactory or the BirdFactory. */
                    switch (selectedCategory)
                    {
                        case CategoryType.Mammal:
                            MammalSpecies mammalSpecie = (MammalSpecies)Enum.Parse(typeof(MammalSpecies), listBoxAnimalObjects.SelectedItem.ToString());
                            animalObject = MammalFactory.CreateMammal(mammalSpecie);
                            break;
                        case CategoryType.Bird:
                            BirdSpecies birdSpecie = (BirdSpecies)Enum.Parse(typeof(BirdSpecies), listBoxAnimalObjects.SelectedItem.ToString());
                            animalObject = BirdFactory.CreateBird(birdSpecie);
                            break;
                        default:
                            animalObject = null;
                            break;
                    }

                    // If validation of entered data is successful. (validateInput returns true)
                    if (validateInput(animalObject))
                    {
                        // Generates a unique id for the animal
                        animalManager.generateUniqueId(animalObject);
                        // Adds the validated animal object to the list in ListManager.
                        animalManager.Add(animalObject);
                        listViewAnimals.Items.Add(createListViewItem(animalObject));
                        // Informs the user that everything succeeded.
                        MessageBox.Show(animalObject.Name + " has been added to the list!", "Animal has been added successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Resets graphical elements to their initial state.
                        initInterface();
                        unsavedChanges = true;
                    }
                }
                // If trying to add an animal with no specific animal selected.
                else
                {
                    validationNotSuccessful("Please select an animal to add");
                }

            }
            // If trying to add an animal with no category selected.
            else
            {
                validationNotSuccessful("Please select a category");
            }
        }

        /* Validates all of the user's input. Adding an animal to the list only
        happens if this method returns true.
        Basically checks that all of the entered data is formatted correctly - 
        number of teeth is an integer etc. */
        private bool validateInput(Animal animal)
        {
            // Validates Name
            if (textboxName.Text.Trim() != "")
            {
                animal.Name = textboxName.Text;
            }
            else
            {
                validationNotSuccessful("Please enter a name for the animal");
                textboxName.Focus();
                return false;
            }

            // Validates Age
            if (int.TryParse(textBoxAge.Text, out int age))
            {
                animal.Age = age;
            }
            else
            {
                validationNotSuccessful("Please enter a whole number for the animal's age");
                textBoxAge.Focus();
                return false;
            }

            // Validates Gender
            if (listBoxGenders.SelectedItem != null)
            {
                animal.Gender = (GenderType)Enum.Parse(typeof(GenderType), listBoxGenders.SelectedItem.ToString());
            }
            else
            {
                validationNotSuccessful("Please select the animal's gender");
                return false;
            }

            // If the animal is of type Dog/Cat/Lion (Mammal)
            if (animal is Mammal)
            {
                // Validates Teeth 
                if (int.TryParse(textBoxCategoryAttr.Text, out int teeth))
                {
                    ((Mammal)animal).Teeth = teeth;
                    animal.AdditionalInfo = ((Mammal)animal).getCategorySpecificData();
                }
                else
                {
                    validationNotSuccessful("Please enter a whole number for the amount of teeth");
                    textBoxCategoryAttr.Focus();
                    return false;
                }

                // If it's a Dog
                if (animal is Dog)
                {
                    // Validates Breed
                    if (textBoxAnimalAttr.Text.Trim() != "")
                    {
                        ((Dog)animal).Breed = textBoxAnimalAttr.Text;
                        animal.AdditionalInfo += ((Dog)animal).getAnimalSpecificData();
                    }
                    else
                    {
                        validationNotSuccessful("Please enter a type of breed for the dog");
                        textBoxAnimalAttr.Focus();
                        return false;
                    }
                }

                // If it's a Cat
                else if (animal is Cat)
                {
                    // Validates Whisker Length
                    if (int.TryParse(textBoxAnimalAttr.Text, out int whisker))
                    {
                        ((Cat)animal).WhiskerLength = whisker;
                        animal.AdditionalInfo += ((Cat)animal).getAnimalSpecificData();
                    }
                    else
                    {
                        validationNotSuccessful("Please enter a whole number as whisker length");
                        textBoxAnimalAttr.Focus();
                        return false;
                    }
                }

                // If it's a Lion
                else if (animal is Lion)
                {
                    // Validates Tail Length
                    if (int.TryParse(textBoxAnimalAttr.Text, out int tail))
                    {
                        ((Lion)animal).TailLength = tail;
                        animal.AdditionalInfo += ((Lion)animal).getAnimalSpecificData();
                    }
                    else
                    {
                        validationNotSuccessful("Please enter a whole number as tail length");
                        textBoxAnimalAttr.Focus();
                        return false;
                    }
                }
            }
            // If the animal is of type Eagle/Crow/Vulture (Bird)
            else if (animal is Bird)
            {
                // Validates Flying Speed
                if (int.TryParse(textBoxCategoryAttr.Text, out int speed))
                {
                    ((Bird)animal).FlyingSpeed = speed;
                    animal.AdditionalInfo = ((Bird)animal).getCategorySpecificData();
                }
                else
                {
                    validationNotSuccessful("Please enter a whole number as the flying speed");
                    textBoxCategoryAttr.Focus();
                    return false;
                }

                // If it's a Crow
                if (animal is Crow)
                {
                    // Validates Weight 
                    if (int.TryParse(textBoxAnimalAttr.Text, out int weight))
                    {
                        ((Crow)animal).Weight = weight;
                        animal.AdditionalInfo += ((Crow)animal).getAnimalSpecificData();
                    }
                    else
                    {
                        validationNotSuccessful("Please enter a whole number as weight");
                        textBoxAnimalAttr.Focus();
                        return false;
                    }
                }

                // If it's an Eagle
                else if (animal is Eagle)
                {
                    // Validates Wing Spread
                    if (int.TryParse(textBoxAnimalAttr.Text, out int wingSpread))
                    {
                        ((Eagle)animal).WingSpread = wingSpread;
                        animal.AdditionalInfo += ((Eagle)animal).getAnimalSpecificData();
                    }
                    else
                    {
                        validationNotSuccessful("Please enter a whole number as wing spread");
                        textBoxAnimalAttr.Focus();
                        return false;
                    }
                }

                // If it's a Vulture
                else if (animal is Vulture)
                {
                    // Validates Neck Color
                    if (textBoxAnimalAttr.Text.Trim() != "")
                    {
                        ((Vulture)animal).NeckColor = textBoxAnimalAttr.Text;
                        animal.AdditionalInfo += ((Vulture)animal).getAnimalSpecificData();
                    }
                    else
                    {
                        validationNotSuccessful("Please enter the vulture's neck color");
                        textBoxAnimalAttr.Focus();
                        return false;
                    }
                }
            }

            return true; // all of the data above is formatted correctly
        }

        // Displays a messagebox to the user of what data was not successfully validated
        public void validationNotSuccessful(string msg)
        {
            MessageBox.Show(msg, "Validation of data unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /* Creates a listviewitem of an animal's attribute values.
        This method gets called after validation of data is successful. */
        private ListViewItem createListViewItem(Animal animal)
        {
            // Creates a listviewitem to be displayed in the listview
            string[] columns = { animal.ID, animal.Name, animal.Age.ToString(), animal.Gender.ToString(), animal.AdditionalInfo };
            ListViewItem listItem = new ListViewItem(columns);
            return listItem;
        }

        // Removes an object from the collection, also updating the listview 
        private void deleteFromList(object sender, EventArgs e)
        {
            if (listViewAnimals.FocusedItem != null)
            {
                // Stores the name of the object in question
                string itemName = listViewAnimals.FocusedItem.SubItems[1].Text;

                // Requires extra confirmation from the user
                if (MessageBox.Show("Are you sure you want to delete " + itemName + "?", "Additional confirmation required", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    // Removes the item from the collection in ListManager
                    animalManager.DeleteAt(listViewAnimals.FocusedItem.Index);
                    addAllAnimalsToListView();
                    // Clears the feeding schedule information
                    textBoxEaterType.Clear();
                    textBoxFoodSchedule.Clear();
                    labelSelectedAnimal.Text = "";
                    unsavedChanges = true;
                }
            }
        }

        // Executes when the user presses the Add Food button in the GUI
        private void AddFoodItem(object sender, EventArgs e)
        {
            RecipeForm recipeForm = new RecipeForm();
            if (recipeForm.ShowDialog() == DialogResult.OK)
            {
                recipeManager.Add(recipeForm.Recipe);
                listViewDetails.Items.Clear();
                foreach (string item in recipeManager.ToStringArray())
                {
                    listViewDetails.Items.Add(item);
                }
                unsavedChanges = true;
            }
        }

        // Executes when the user presses the Add Staff button in the GUI
        private void AddStaffMember(object sender, EventArgs e)
        {
            StaffForm s_form = new StaffForm();
            if (s_form.ShowDialog() == DialogResult.OK)
            {
                listViewDetails.Items.Add(s_form.Staff.ToString());
                unsavedChanges = true;
            }
        }

        // Imports the contents of a binary or a text file and adds them to the details-listview
        private void openFile(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                // The sender object keeps track of which menu option was clicked (under Open)
                if (sender.ToString() == "Binary File")
                {
                    dialog.Title = "Open binary file";
                    dialog.Filter = "Binary files|*.bin";
                    currentFileType = CurrentFileType.Binary;
                }
                // If the open text file option was clicked
                else if (sender.ToString() == "Text File")
                {
                    dialog.Title = "Open text file";
                    dialog.Filter = "JSON files|*.json";
                    currentFileType = CurrentFileType.Text;
                }

                dialog.ShowDialog();
                if (dialog.FileName.Trim() != "")
                {
                    // binary deserialize necessary
                    if (sender.ToString() == "Binary File")
                    {
                        try
                        {
                            animalManager.BinaryDeSerialize(dialog.FileName);
                            addAllAnimalsToListView();
                        }
                        catch (SerializationException error)
                        {
                            MessageBox.Show("Failed to deserialize. Reason: " + error.Message, "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (sender.ToString() == "Text File")
                    {
                        try
                        {
                            animalManager.JSONDeSerialize(dialog.FileName);
                            addAllAnimalsToListView();
                        }
                        catch (JsonSerializationException error)
                        {
                            MessageBox.Show("Failed to deserialize. Reason: " + error.Message, "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (JsonReaderException error)
                        {
                            MessageBox.Show("Failed to deserialize. Reason: " + error.Message, "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    currentFileName = dialog.FileName;
                }
            }

        }

        // when the user clicks save as in the menu.
        private void SaveAs(object sender, EventArgs e)
        {
            // if there is nothing to save. Asks the user for confirmation
            if (!unsavedChanges)
            {
                // if the user still wants to save
                if (MessageBox.Show("No changes have been made. Do you still wish to save?",
                    "Nothing new to save",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveToFile(sender.ToString());
                }
            }
            // if there are unsaved changes
            else
            {
                SaveToFile(sender.ToString());
            }
        }

        // saves the animal objects to a file. Either as binary or plain text
        private void SaveToFile(string format)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                // if the user clicked save as binary file
                if (format == "Binary File")
                {
                    dialog.Title = "Save as binary file";
                    dialog.Filter = "Binary files|*.bin";
                }
                // if the user clicked save as text file
                else if (format == "Text File")
                {
                    dialog.DefaultExt = "json";
                    dialog.AddExtension = true;
                    dialog.Title = "Save as text file";
                    dialog.Filter = "JSON files|*.json";
                }
                dialog.ShowDialog();

                if (dialog.FileName.Trim() != "")
                {
                    if (format == "Binary File")
                    {
                        try
                        {
                            animalManager.BinarySerialize(dialog.FileName);
                            currentFileType = CurrentFileType.Binary;
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show("Could not serialize file in binary format. Reason: " + error.Message, "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (format == "Text File")
                    {
                        try
                        {
                            animalManager.JSONSerialize(dialog.FileName);
                            currentFileType = CurrentFileType.Text;
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show("Could not serialize file to JSON format. Reason: " + error.Message, "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    unsavedChanges = false;
                    currentFileName = dialog.FileName;
                }
            }
        }
        // Exports recipe objects in recipemanager to xml file
        private void ExportToXML(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.DefaultExt = "xml";
                dialog.AddExtension = true;
                dialog.Title = "Export as XML file";
                dialog.Filter = "XML files|*.xml";
                dialog.ShowDialog();

                if (dialog.FileName != "")
                {
                    try
                    {
                        recipeManager.XMLSerialize(dialog.FileName);
                        currentFileType = CurrentFileType.XML;
                        currentFileName = dialog.FileName;
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Failed to export XML-file. Reason: " + error.Message, "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                unsavedChanges = false;
            }
        }

        // Imports the contents of an XML file and adds them to the details-listview
        private void ImportFromXML(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Open an XML file";
                dialog.Filter = "XML files|*.xml";
                dialog.ShowDialog();

                if (dialog.FileName != "")
                {
                    try
                    {
                        recipeManager.XMLDeSerialize(dialog.FileName);
                        addAllRecipesToListView();
                        currentFileType = CurrentFileType.XML;
                        currentFileName = dialog.FileName;
                    }
                    catch (NullReferenceException error)
                    {
                        MessageBox.Show("Failed to load XML-file. Reason: " + error.Message, "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show("Failed to load XML-file. Reason: " + ex.Message, "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Adds all of the animal objects in the animalmanager object to the animals-listview
        private void addAllAnimalsToListView()
        {
            listViewAnimals.Items.Clear();
            for (int i = 0; i < animalManager.Count; i++)
            {
                listViewAnimals.Items.Add(createListViewItem(animalManager.GetAt(i)));
            }
        }

        // Adds all of the recipe objects in the recipemanager object to the details-listview
        private void addAllRecipesToListView()
        {
            listViewDetails.Items.Clear();
            for (int i = 0; i < recipeManager.Count; i++)
            {
                listViewDetails.Items.Add(recipeManager.GetAt(i).ToString());
            }
        }

        // Resets the GUI and its elements to their initial state.
        // If there are any unsaved changes, the user will be presented with a messagebox
        // to allow them to save their progress before continuing.
        private void NewProgram(object sender, EventArgs e)
        {
            // If the user presses New with unsaved changes
            if (unsavedChanges)
            {
                // If the user says no and opts not to save
                if (MessageBox.Show("You are about to proceed before saving your changes. Is this OK?", "Unsaved changes detected", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    initInterface();
                    Reset();
                }
            }
            // If all changes are saved
            else
            {
                initInterface();
                Reset();
            }
        }

        // When the user clicks on the menu item Save
        private void Save(object sender, EventArgs e)
        {
            // this is a way to know if the user is working with an opened/saved file or not
            if (currentFileType == CurrentFileType.None)
            {
                DialogResult result = MessageBox.Show("Save in what format? Please select Yes for binary, and No to save as Text.",
                    "Save as...",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);
                // if the user selects yes (save as binary)
                if (result == DialogResult.Yes)
                {
                    SaveToFile("Binary File");
                }
                // if the user selects no (save as text)
                else if (result == DialogResult.No)
                {
                    SaveToFile("Text File");
                }
            }
            // if the file the user is currently trying to save is a binary file
            else if (currentFileType == CurrentFileType.Binary)
            {
                animalManager.BinarySerialize(currentFileName);
            }
            // if the file the user is currently trying to save is a text file
            else if (currentFileType == CurrentFileType.Text)
            {
                animalManager.JSONSerialize(currentFileName);
            }
        }
        // Exits out of the program, when the user selects 'Exit' in the menu.
        private void ExitProgram(object sender, EventArgs e)
        {
            Close();
        }
    }
}
