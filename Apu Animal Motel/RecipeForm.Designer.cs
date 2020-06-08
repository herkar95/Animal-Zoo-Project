namespace Apu_Animal_Motel
{
    partial class RecipeForm
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
            this.labelFoodName = new System.Windows.Forms.Label();
            this.labelAddIngredient = new System.Windows.Forms.Label();
            this.groupBoxAddIngredient = new System.Windows.Forms.GroupBox();
            this.textBoxFoodName = new System.Windows.Forms.TextBox();
            this.textBoxAddIngredient = new System.Windows.Forms.TextBox();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.btnChangeIngredient = new System.Windows.Forms.Button();
            this.btnDeleteIngredient = new System.Windows.Forms.Button();
            this.listViewIngredients = new System.Windows.Forms.ListView();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBoxAddIngredient.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFoodName
            // 
            this.labelFoodName.AutoSize = true;
            this.labelFoodName.Font = new System.Drawing.Font("Rockwell Nova", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFoodName.ForeColor = System.Drawing.Color.Fuchsia;
            this.labelFoodName.Location = new System.Drawing.Point(55, 58);
            this.labelFoodName.Name = "labelFoodName";
            this.labelFoodName.Size = new System.Drawing.Size(71, 27);
            this.labelFoodName.TabIndex = 22;
            this.labelFoodName.Text = "Name";
            // 
            // labelAddIngredient
            // 
            this.labelAddIngredient.AutoSize = true;
            this.labelAddIngredient.ForeColor = System.Drawing.Color.Fuchsia;
            this.labelAddIngredient.Location = new System.Drawing.Point(17, 37);
            this.labelAddIngredient.Name = "labelAddIngredient";
            this.labelAddIngredient.Size = new System.Drawing.Size(119, 27);
            this.labelAddIngredient.TabIndex = 20;
            this.labelAddIngredient.Text = "Ingredient";
            // 
            // groupBoxAddIngredient
            // 
            this.groupBoxAddIngredient.Controls.Add(this.listViewIngredients);
            this.groupBoxAddIngredient.Controls.Add(this.btnDeleteIngredient);
            this.groupBoxAddIngredient.Controls.Add(this.btnChangeIngredient);
            this.groupBoxAddIngredient.Controls.Add(this.btnAddIngredient);
            this.groupBoxAddIngredient.Controls.Add(this.textBoxAddIngredient);
            this.groupBoxAddIngredient.Controls.Add(this.labelAddIngredient);
            this.groupBoxAddIngredient.Font = new System.Drawing.Font("Rockwell Nova", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAddIngredient.ForeColor = System.Drawing.Color.Purple;
            this.groupBoxAddIngredient.Location = new System.Drawing.Point(59, 122);
            this.groupBoxAddIngredient.Name = "groupBoxAddIngredient";
            this.groupBoxAddIngredient.Size = new System.Drawing.Size(781, 343);
            this.groupBoxAddIngredient.TabIndex = 21;
            this.groupBoxAddIngredient.TabStop = false;
            this.groupBoxAddIngredient.Text = "Add Ingredient";
            // 
            // textBoxFoodName
            // 
            this.textBoxFoodName.Font = new System.Drawing.Font("Rockwell Nova", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFoodName.ForeColor = System.Drawing.Color.Black;
            this.textBoxFoodName.Location = new System.Drawing.Point(233, 51);
            this.textBoxFoodName.Name = "textBoxFoodName";
            this.textBoxFoodName.Size = new System.Drawing.Size(253, 34);
            this.textBoxFoodName.TabIndex = 0;
            // 
            // textBoxAddIngredient
            // 
            this.textBoxAddIngredient.ForeColor = System.Drawing.Color.Black;
            this.textBoxAddIngredient.Location = new System.Drawing.Point(174, 30);
            this.textBoxAddIngredient.Name = "textBoxAddIngredient";
            this.textBoxAddIngredient.Size = new System.Drawing.Size(395, 34);
            this.textBoxAddIngredient.TabIndex = 1;
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddIngredient.Location = new System.Drawing.Point(21, 99);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(115, 42);
            this.btnAddIngredient.TabIndex = 2;
            this.btnAddIngredient.Text = "Add";
            this.btnAddIngredient.UseVisualStyleBackColor = true;
            this.btnAddIngredient.Click += new System.EventHandler(this.addIngredient);
            // 
            // btnChangeIngredient
            // 
            this.btnChangeIngredient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeIngredient.Location = new System.Drawing.Point(21, 185);
            this.btnChangeIngredient.Name = "btnChangeIngredient";
            this.btnChangeIngredient.Size = new System.Drawing.Size(115, 42);
            this.btnChangeIngredient.TabIndex = 3;
            this.btnChangeIngredient.Text = "Change";
            this.btnChangeIngredient.UseVisualStyleBackColor = true;
            this.btnChangeIngredient.Click += new System.EventHandler(this.changeIngredient);
            // 
            // btnDeleteIngredient
            // 
            this.btnDeleteIngredient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteIngredient.Location = new System.Drawing.Point(21, 271);
            this.btnDeleteIngredient.Name = "btnDeleteIngredient";
            this.btnDeleteIngredient.Size = new System.Drawing.Size(115, 42);
            this.btnDeleteIngredient.TabIndex = 4;
            this.btnDeleteIngredient.Text = "Delete";
            this.btnDeleteIngredient.UseVisualStyleBackColor = true;
            this.btnDeleteIngredient.Click += new System.EventHandler(this.deleteIngredient);
            // 
            // listViewIngredients
            // 
            this.listViewIngredients.HideSelection = false;
            this.listViewIngredients.Location = new System.Drawing.Point(174, 99);
            this.listViewIngredients.MultiSelect = false;
            this.listViewIngredients.Name = "listViewIngredients";
            this.listViewIngredients.Size = new System.Drawing.Size(584, 214);
            this.listViewIngredients.TabIndex = 10;
            this.listViewIngredients.TabStop = false;
            this.listViewIngredients.UseCompatibleStateImageBehavior = false;
            this.listViewIngredients.View = System.Windows.Forms.View.List;
            // 
            // btnOK
            // 
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnOK.Location = new System.Drawing.Point(60, 495);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(199, 64);
            this.btnOK.TabIndex = 5;
            this.btnOK.TabStop = false;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.recipeAddedOK);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Crimson;
            this.btnCancel.Location = new System.Drawing.Point(299, 495);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(199, 64);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.cancelClicked);
            // 
            // RecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 571);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textBoxFoodName);
            this.Controls.Add(this.groupBoxAddIngredient);
            this.Controls.Add(this.labelFoodName);
            this.Name = "RecipeForm";
            this.Text = "Food Register";
            this.groupBoxAddIngredient.ResumeLayout(false);
            this.groupBoxAddIngredient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFoodName;
        private System.Windows.Forms.Label labelAddIngredient;
        private System.Windows.Forms.GroupBox groupBoxAddIngredient;
        private System.Windows.Forms.TextBox textBoxAddIngredient;
        private System.Windows.Forms.TextBox textBoxFoodName;
        private System.Windows.Forms.Button btnAddIngredient;
        private System.Windows.Forms.ListView listViewIngredients;
        private System.Windows.Forms.Button btnDeleteIngredient;
        private System.Windows.Forms.Button btnChangeIngredient;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}