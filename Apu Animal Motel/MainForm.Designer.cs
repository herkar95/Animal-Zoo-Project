namespace Apu_Animal_Motel
{
    partial class MainForm
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
            this.groupBoxAnimalSpec = new System.Windows.Forms.GroupBox();
            this.groupBoxFoodDetails = new System.Windows.Forms.GroupBox();
            this.listViewDetails = new System.Windows.Forms.ListView();
            this.Contents = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.groupBoxCategorySpec = new System.Windows.Forms.GroupBox();
            this.labelAnimalAttr = new System.Windows.Forms.Label();
            this.textBoxAnimalAttr = new System.Windows.Forms.TextBox();
            this.textBoxCategoryAttr = new System.Windows.Forms.TextBox();
            this.labelCategoryAttr = new System.Windows.Forms.Label();
            this.groupBoxAnimalObject = new System.Windows.Forms.GroupBox();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.listBoxAnimalObjects = new System.Windows.Forms.ListBox();
            this.groupBoxCategory = new System.Windows.Forms.GroupBox();
            this.listBoxCategories = new System.Windows.Forms.ListBox();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.listBoxGenders = new System.Windows.Forms.ListBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textboxName = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBoxFeeding = new System.Windows.Forms.GroupBox();
            this.labelSelectedAnimal = new System.Windows.Forms.Label();
            this.textBoxFoodSchedule = new System.Windows.Forms.TextBox();
            this.textBoxEaterType = new System.Windows.Forms.TextBox();
            this.labelEaterType = new System.Windows.Forms.Label();
            this.groupBoxListAnimals = new System.Windows.Forms.GroupBox();
            this.listViewAnimals = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.animalName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Characteristics = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new System.Windows.Forms.Button();
            this.mnuFile = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpenAsText = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpenAsBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveAsTextFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveAsBinaryFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileXML = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileXMLImport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileXMLExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxAnimalSpec.SuspendLayout();
            this.groupBoxFoodDetails.SuspendLayout();
            this.groupBoxCategorySpec.SuspendLayout();
            this.groupBoxAnimalObject.SuspendLayout();
            this.groupBoxCategory.SuspendLayout();
            this.groupBoxGender.SuspendLayout();
            this.groupBoxFeeding.SuspendLayout();
            this.groupBoxListAnimals.SuspendLayout();
            this.mnuFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAnimalSpec
            // 
            this.groupBoxAnimalSpec.Controls.Add(this.groupBoxFoodDetails);
            this.groupBoxAnimalSpec.Controls.Add(this.groupBoxCategorySpec);
            this.groupBoxAnimalSpec.Controls.Add(this.groupBoxAnimalObject);
            this.groupBoxAnimalSpec.Controls.Add(this.groupBoxCategory);
            this.groupBoxAnimalSpec.Controls.Add(this.groupBoxGender);
            this.groupBoxAnimalSpec.Controls.Add(this.textBoxAge);
            this.groupBoxAnimalSpec.Controls.Add(this.textboxName);
            this.groupBoxAnimalSpec.Controls.Add(this.labelAge);
            this.groupBoxAnimalSpec.Controls.Add(this.labelName);
            this.groupBoxAnimalSpec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAnimalSpec.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBoxAnimalSpec.Location = new System.Drawing.Point(8, 25);
            this.groupBoxAnimalSpec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxAnimalSpec.Name = "groupBoxAnimalSpec";
            this.groupBoxAnimalSpec.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxAnimalSpec.Size = new System.Drawing.Size(1064, 286);
            this.groupBoxAnimalSpec.TabIndex = 0;
            this.groupBoxAnimalSpec.TabStop = false;
            this.groupBoxAnimalSpec.Text = "Animal specifications";
            // 
            // groupBoxFoodDetails
            // 
            this.groupBoxFoodDetails.Controls.Add(this.listViewDetails);
            this.groupBoxFoodDetails.Controls.Add(this.btnAddStaff);
            this.groupBoxFoodDetails.Controls.Add(this.btnAddFood);
            this.groupBoxFoodDetails.ForeColor = System.Drawing.Color.Magenta;
            this.groupBoxFoodDetails.Location = new System.Drawing.Point(500, 31);
            this.groupBoxFoodDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxFoodDetails.Name = "groupBoxFoodDetails";
            this.groupBoxFoodDetails.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxFoodDetails.Size = new System.Drawing.Size(556, 246);
            this.groupBoxFoodDetails.TabIndex = 8;
            this.groupBoxFoodDetails.TabStop = false;
            this.groupBoxFoodDetails.Text = "Food details";
            // 
            // listViewDetails
            // 
            this.listViewDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Contents});
            this.listViewDetails.HideSelection = false;
            this.listViewDetails.Location = new System.Drawing.Point(121, 23);
            this.listViewDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewDetails.Name = "listViewDetails";
            this.listViewDetails.Size = new System.Drawing.Size(425, 211);
            this.listViewDetails.TabIndex = 2;
            this.listViewDetails.UseCompatibleStateImageBehavior = false;
            this.listViewDetails.View = System.Windows.Forms.View.Details;
            // 
            // Contents
            // 
            this.Contents.Text = "";
            this.Contents.Width = 600;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStaff.Location = new System.Drawing.Point(11, 206);
            this.btnAddStaff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(96, 27);
            this.btnAddStaff.TabIndex = 1;
            this.btnAddStaff.Text = "Add Staff";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.AddStaffMember);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFood.Location = new System.Drawing.Point(11, 175);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(96, 27);
            this.btnAddFood.TabIndex = 0;
            this.btnAddFood.Text = "Add Food";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.AddFoodItem);
            // 
            // groupBoxCategorySpec
            // 
            this.groupBoxCategorySpec.Controls.Add(this.labelAnimalAttr);
            this.groupBoxCategorySpec.Controls.Add(this.textBoxAnimalAttr);
            this.groupBoxCategorySpec.Controls.Add(this.textBoxCategoryAttr);
            this.groupBoxCategorySpec.Controls.Add(this.labelCategoryAttr);
            this.groupBoxCategorySpec.ForeColor = System.Drawing.Color.Crimson;
            this.groupBoxCategorySpec.Location = new System.Drawing.Point(15, 187);
            this.groupBoxCategorySpec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxCategorySpec.Name = "groupBoxCategorySpec";
            this.groupBoxCategorySpec.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxCategorySpec.Size = new System.Drawing.Size(319, 90);
            this.groupBoxCategorySpec.TabIndex = 7;
            this.groupBoxCategorySpec.TabStop = false;
            this.groupBoxCategorySpec.Text = "Category Specifications";
            // 
            // labelAnimalAttr
            // 
            this.labelAnimalAttr.AutoSize = true;
            this.labelAnimalAttr.Location = new System.Drawing.Point(15, 58);
            this.labelAnimalAttr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAnimalAttr.Name = "labelAnimalAttr";
            this.labelAnimalAttr.Size = new System.Drawing.Size(0, 17);
            this.labelAnimalAttr.TabIndex = 3;
            // 
            // textBoxAnimalAttr
            // 
            this.textBoxAnimalAttr.Location = new System.Drawing.Point(176, 55);
            this.textBoxAnimalAttr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAnimalAttr.Name = "textBoxAnimalAttr";
            this.textBoxAnimalAttr.Size = new System.Drawing.Size(68, 23);
            this.textBoxAnimalAttr.TabIndex = 8;
            // 
            // textBoxCategoryAttr
            // 
            this.textBoxCategoryAttr.Location = new System.Drawing.Point(176, 27);
            this.textBoxCategoryAttr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCategoryAttr.Name = "textBoxCategoryAttr";
            this.textBoxCategoryAttr.Size = new System.Drawing.Size(68, 23);
            this.textBoxCategoryAttr.TabIndex = 7;
            // 
            // labelCategoryAttr
            // 
            this.labelCategoryAttr.AutoSize = true;
            this.labelCategoryAttr.Location = new System.Drawing.Point(15, 29);
            this.labelCategoryAttr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCategoryAttr.Name = "labelCategoryAttr";
            this.labelCategoryAttr.Size = new System.Drawing.Size(0, 17);
            this.labelCategoryAttr.TabIndex = 0;
            // 
            // groupBoxAnimalObject
            // 
            this.groupBoxAnimalObject.Controls.Add(this.btnAddAnimal);
            this.groupBoxAnimalObject.Controls.Add(this.listBoxAnimalObjects);
            this.groupBoxAnimalObject.Location = new System.Drawing.Point(338, 31);
            this.groupBoxAnimalObject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxAnimalObject.Name = "groupBoxAnimalObject";
            this.groupBoxAnimalObject.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxAnimalObject.Size = new System.Drawing.Size(158, 246);
            this.groupBoxAnimalObject.TabIndex = 6;
            this.groupBoxAnimalObject.TabStop = false;
            this.groupBoxAnimalObject.Text = "Animal Object";
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAnimal.Location = new System.Drawing.Point(15, 194);
            this.btnAddAnimal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(125, 28);
            this.btnAddAnimal.TabIndex = 9;
            this.btnAddAnimal.Text = "Add animal";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.addAnimal);
            // 
            // listBoxAnimalObjects
            // 
            this.listBoxAnimalObjects.FormattingEnabled = true;
            this.listBoxAnimalObjects.ItemHeight = 16;
            this.listBoxAnimalObjects.Location = new System.Drawing.Point(15, 21);
            this.listBoxAnimalObjects.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxAnimalObjects.Name = "listBoxAnimalObjects";
            this.listBoxAnimalObjects.Size = new System.Drawing.Size(127, 148);
            this.listBoxAnimalObjects.TabIndex = 6;
            this.listBoxAnimalObjects.SelectedIndexChanged += new System.EventHandler(this.showSpecificAnimalAttributes);
            // 
            // groupBoxCategory
            // 
            this.groupBoxCategory.Controls.Add(this.listBoxCategories);
            this.groupBoxCategory.Location = new System.Drawing.Point(192, 31);
            this.groupBoxCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxCategory.Name = "groupBoxCategory";
            this.groupBoxCategory.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxCategory.Size = new System.Drawing.Size(142, 127);
            this.groupBoxCategory.TabIndex = 5;
            this.groupBoxCategory.TabStop = false;
            this.groupBoxCategory.Text = "Category";
            // 
            // listBoxCategories
            // 
            this.listBoxCategories.FormattingEnabled = true;
            this.listBoxCategories.ItemHeight = 16;
            this.listBoxCategories.Location = new System.Drawing.Point(11, 23);
            this.listBoxCategories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.Size = new System.Drawing.Size(120, 100);
            this.listBoxCategories.TabIndex = 5;
            this.listBoxCategories.SelectedIndexChanged += new System.EventHandler(this.updateInterface);
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.listBoxGenders);
            this.groupBoxGender.Location = new System.Drawing.Point(15, 87);
            this.groupBoxGender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxGender.Size = new System.Drawing.Size(145, 88);
            this.groupBoxGender.TabIndex = 4;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Gender";
            // 
            // listBoxGenders
            // 
            this.listBoxGenders.FormattingEnabled = true;
            this.listBoxGenders.ItemHeight = 16;
            this.listBoxGenders.Location = new System.Drawing.Point(8, 21);
            this.listBoxGenders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxGenders.Name = "listBoxGenders";
            this.listBoxGenders.Size = new System.Drawing.Size(127, 68);
            this.listBoxGenders.TabIndex = 4;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(87, 57);
            this.textBoxAge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(68, 23);
            this.textBoxAge.TabIndex = 3;
            // 
            // textboxName
            // 
            this.textboxName.Location = new System.Drawing.Point(87, 26);
            this.textboxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxName.Name = "textboxName";
            this.textboxName.Size = new System.Drawing.Size(68, 23);
            this.textboxName.TabIndex = 2;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelAge.Location = new System.Drawing.Point(17, 62);
            this.labelAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(33, 17);
            this.labelAge.TabIndex = 1;
            this.labelAge.Text = "Age";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelName.Location = new System.Drawing.Point(17, 31);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // groupBoxFeeding
            // 
            this.groupBoxFeeding.Controls.Add(this.labelSelectedAnimal);
            this.groupBoxFeeding.Controls.Add(this.textBoxFoodSchedule);
            this.groupBoxFeeding.Controls.Add(this.textBoxEaterType);
            this.groupBoxFeeding.Controls.Add(this.labelEaterType);
            this.groupBoxFeeding.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFeeding.ForeColor = System.Drawing.Color.Orange;
            this.groupBoxFeeding.Location = new System.Drawing.Point(687, 311);
            this.groupBoxFeeding.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxFeeding.Name = "groupBoxFeeding";
            this.groupBoxFeeding.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxFeeding.Size = new System.Drawing.Size(385, 214);
            this.groupBoxFeeding.TabIndex = 8;
            this.groupBoxFeeding.TabStop = false;
            this.groupBoxFeeding.Text = "Feeding Schedule";
            // 
            // labelSelectedAnimal
            // 
            this.labelSelectedAnimal.AutoSize = true;
            this.labelSelectedAnimal.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelSelectedAnimal.Location = new System.Drawing.Point(12, 32);
            this.labelSelectedAnimal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSelectedAnimal.Name = "labelSelectedAnimal";
            this.labelSelectedAnimal.Size = new System.Drawing.Size(0, 17);
            this.labelSelectedAnimal.TabIndex = 3;
            this.labelSelectedAnimal.Visible = false;
            // 
            // textBoxFoodSchedule
            // 
            this.textBoxFoodSchedule.Enabled = false;
            this.textBoxFoodSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFoodSchedule.ForeColor = System.Drawing.Color.Orange;
            this.textBoxFoodSchedule.Location = new System.Drawing.Point(15, 96);
            this.textBoxFoodSchedule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFoodSchedule.Multiline = true;
            this.textBoxFoodSchedule.Name = "textBoxFoodSchedule";
            this.textBoxFoodSchedule.Size = new System.Drawing.Size(363, 106);
            this.textBoxFoodSchedule.TabIndex = 2;
            // 
            // textBoxEaterType
            // 
            this.textBoxEaterType.Enabled = false;
            this.textBoxEaterType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBoxEaterType.Location = new System.Drawing.Point(181, 58);
            this.textBoxEaterType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxEaterType.Name = "textBoxEaterType";
            this.textBoxEaterType.Size = new System.Drawing.Size(97, 23);
            this.textBoxEaterType.TabIndex = 1;
            // 
            // labelEaterType
            // 
            this.labelEaterType.AutoSize = true;
            this.labelEaterType.ForeColor = System.Drawing.Color.Orange;
            this.labelEaterType.Location = new System.Drawing.Point(12, 63);
            this.labelEaterType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEaterType.Name = "labelEaterType";
            this.labelEaterType.Size = new System.Drawing.Size(73, 17);
            this.labelEaterType.TabIndex = 0;
            this.labelEaterType.Text = "Eater type";
            // 
            // groupBoxListAnimals
            // 
            this.groupBoxListAnimals.Controls.Add(this.listViewAnimals);
            this.groupBoxListAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxListAnimals.ForeColor = System.Drawing.Color.ForestGreen;
            this.groupBoxListAnimals.Location = new System.Drawing.Point(8, 311);
            this.groupBoxListAnimals.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxListAnimals.Name = "groupBoxListAnimals";
            this.groupBoxListAnimals.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxListAnimals.Size = new System.Drawing.Size(661, 174);
            this.groupBoxListAnimals.TabIndex = 1;
            this.groupBoxListAnimals.TabStop = false;
            this.groupBoxListAnimals.Text = "List of registered animals";
            // 
            // listViewAnimals
            // 
            this.listViewAnimals.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewAnimals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.animalName,
            this.Age,
            this.Gender,
            this.Characteristics});
            this.listViewAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewAnimals.HideSelection = false;
            this.listViewAnimals.Location = new System.Drawing.Point(15, 21);
            this.listViewAnimals.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewAnimals.Name = "listViewAnimals";
            this.listViewAnimals.Size = new System.Drawing.Size(633, 139);
            this.listViewAnimals.TabIndex = 0;
            this.listViewAnimals.UseCompatibleStateImageBehavior = false;
            this.listViewAnimals.View = System.Windows.Forms.View.Details;
            this.listViewAnimals.SelectedIndexChanged += new System.EventHandler(this.populateFeedingSchedule);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 80;
            // 
            // animalName
            // 
            this.animalName.Text = "Name";
            this.animalName.Width = 100;
            // 
            // Age
            // 
            this.Age.Text = "Age";
            this.Age.Width = 70;
            // 
            // Gender
            // 
            this.Gender.Text = "Gender";
            this.Gender.Width = 85;
            // 
            // Characteristics
            // 
            this.Characteristics.Text = "Special Characteristics";
            this.Characteristics.Width = 400;
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Crimson;
            this.btnDelete.Location = new System.Drawing.Point(458, 487);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(211, 38);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.deleteFromList);
            // 
            // mnuFile
            // 
            this.mnuFile.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnuFile.Location = new System.Drawing.Point(0, 0);
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.mnuFile.Size = new System.Drawing.Size(1080, 24);
            this.mnuFile.TabIndex = 9;
            this.mnuFile.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.mnuFileOpen,
            this.mnuFileSave,
            this.mnuFileSaveAs,
            this.mnuFileXML,
            this.toolStripSeparator1,
            this.mnuFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.Size = new System.Drawing.Size(180, 22);
            this.mnuFileNew.Text = "New";
            this.mnuFileNew.Click += new System.EventHandler(this.NewProgram);
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileOpenAsText,
            this.mnuFileOpenAsBinary});
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Size = new System.Drawing.Size(180, 22);
            this.mnuFileOpen.Text = "Open ...";
            // 
            // mnuFileOpenAsText
            // 
            this.mnuFileOpenAsText.Name = "mnuFileOpenAsText";
            this.mnuFileOpenAsText.Size = new System.Drawing.Size(128, 22);
            this.mnuFileOpenAsText.Text = "Text File";
            this.mnuFileOpenAsText.Click += new System.EventHandler(this.openFile);
            // 
            // mnuFileOpenAsBinary
            // 
            this.mnuFileOpenAsBinary.Name = "mnuFileOpenAsBinary";
            this.mnuFileOpenAsBinary.Size = new System.Drawing.Size(128, 22);
            this.mnuFileOpenAsBinary.Text = "Binary File";
            this.mnuFileOpenAsBinary.Click += new System.EventHandler(this.openFile);
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.Size = new System.Drawing.Size(180, 22);
            this.mnuFileSave.Text = "Save ";
            this.mnuFileSave.Click += new System.EventHandler(this.Save);
            // 
            // mnuFileSaveAs
            // 
            this.mnuFileSaveAs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileSaveAsTextFile,
            this.mnuFileSaveAsBinaryFile});
            this.mnuFileSaveAs.Name = "mnuFileSaveAs";
            this.mnuFileSaveAs.Size = new System.Drawing.Size(180, 22);
            this.mnuFileSaveAs.Text = "Save as ...";
            // 
            // mnuFileSaveAsTextFile
            // 
            this.mnuFileSaveAsTextFile.Name = "mnuFileSaveAsTextFile";
            this.mnuFileSaveAsTextFile.Size = new System.Drawing.Size(128, 22);
            this.mnuFileSaveAsTextFile.Text = "Text File";
            this.mnuFileSaveAsTextFile.Click += new System.EventHandler(this.SaveAs);
            // 
            // mnuFileSaveAsBinaryFile
            // 
            this.mnuFileSaveAsBinaryFile.Name = "mnuFileSaveAsBinaryFile";
            this.mnuFileSaveAsBinaryFile.Size = new System.Drawing.Size(128, 22);
            this.mnuFileSaveAsBinaryFile.Text = "Binary File";
            this.mnuFileSaveAsBinaryFile.Click += new System.EventHandler(this.SaveAs);
            // 
            // mnuFileXML
            // 
            this.mnuFileXML.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileXMLImport,
            this.mnuFileXMLExport});
            this.mnuFileXML.Name = "mnuFileXML";
            this.mnuFileXML.Size = new System.Drawing.Size(180, 22);
            this.mnuFileXML.Text = "XML";
            // 
            // mnuFileXMLImport
            // 
            this.mnuFileXMLImport.Name = "mnuFileXMLImport";
            this.mnuFileXMLImport.Size = new System.Drawing.Size(187, 22);
            this.mnuFileXMLImport.Text = "Import from XML File";
            this.mnuFileXMLImport.Click += new System.EventHandler(this.ImportFromXML);
            // 
            // mnuFileXMLExport
            // 
            this.mnuFileXMLExport.Name = "mnuFileXMLExport";
            this.mnuFileXMLExport.Size = new System.Drawing.Size(187, 22);
            this.mnuFileXMLExport.Text = "Export to XML File";
            this.mnuFileXMLExport.Click += new System.EventHandler(this.ExportToXML);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(180, 22);
            this.mnuFileExit.Text = "Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.ExitProgram);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 545);
            this.Controls.Add(this.groupBoxFeeding);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBoxListAnimals);
            this.Controls.Add(this.groupBoxAnimalSpec);
            this.Controls.Add(this.mnuFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuFile;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apu Animal Motel";
            this.groupBoxAnimalSpec.ResumeLayout(false);
            this.groupBoxAnimalSpec.PerformLayout();
            this.groupBoxFoodDetails.ResumeLayout(false);
            this.groupBoxCategorySpec.ResumeLayout(false);
            this.groupBoxCategorySpec.PerformLayout();
            this.groupBoxAnimalObject.ResumeLayout(false);
            this.groupBoxCategory.ResumeLayout(false);
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxFeeding.ResumeLayout(false);
            this.groupBoxFeeding.PerformLayout();
            this.groupBoxListAnimals.ResumeLayout(false);
            this.mnuFile.ResumeLayout(false);
            this.mnuFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAnimalSpec;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textboxName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.GroupBox groupBoxCategorySpec;
        private System.Windows.Forms.GroupBox groupBoxAnimalObject;
        private System.Windows.Forms.GroupBox groupBoxCategory;
        private System.Windows.Forms.GroupBox groupBoxListAnimals;
        private System.Windows.Forms.ListBox listBoxCategories;
        private System.Windows.Forms.ListBox listBoxAnimalObjects;
        private System.Windows.Forms.ListView listViewAnimals;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.ListBox listBoxGenders;
        private System.Windows.Forms.Label labelCategoryAttr;
        private System.Windows.Forms.TextBox textBoxCategoryAttr;
        private System.Windows.Forms.TextBox textBoxAnimalAttr;
        private System.Windows.Forms.Label labelAnimalAttr;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader animalName;
        private System.Windows.Forms.ColumnHeader Age;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ColumnHeader Characteristics;
        private System.Windows.Forms.GroupBox groupBoxFeeding;
        private System.Windows.Forms.TextBox textBoxEaterType;
        private System.Windows.Forms.Label labelEaterType;
        private System.Windows.Forms.TextBox textBoxFoodSchedule;
        private System.Windows.Forms.Label labelSelectedAnimal;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBoxFoodDetails;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.ListView listViewDetails;
        private System.Windows.Forms.MenuStrip mnuFile;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mnuFileXML;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpenAsText;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpenAsBinary;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAsTextFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAsBinaryFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileXMLImport;
        private System.Windows.Forms.ToolStripMenuItem mnuFileXMLExport;
        private System.Windows.Forms.ColumnHeader Contents;
    }
}

