namespace Apu_Animal_Motel
{
    partial class StaffForm
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
            this.labelStaffName = new System.Windows.Forms.Label();
            this.labelAddQual = new System.Windows.Forms.Label();
            this.groupBoxAddStaff = new System.Windows.Forms.GroupBox();
            this.listViewQualifications = new System.Windows.Forms.ListView();
            this.btnDeleteQual = new System.Windows.Forms.Button();
            this.btnChangeQual = new System.Windows.Forms.Button();
            this.btnAddQual = new System.Windows.Forms.Button();
            this.textBoxAddQual = new System.Windows.Forms.TextBox();
            this.textBoxStaffName = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBoxAddStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStaffName
            // 
            this.labelStaffName.AutoSize = true;
            this.labelStaffName.Font = new System.Drawing.Font("Rockwell Nova", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaffName.ForeColor = System.Drawing.Color.Fuchsia;
            this.labelStaffName.Location = new System.Drawing.Point(55, 58);
            this.labelStaffName.Name = "labelStaffName";
            this.labelStaffName.Size = new System.Drawing.Size(71, 27);
            this.labelStaffName.TabIndex = 22;
            this.labelStaffName.Text = "Name";
            // 
            // labelAddQual
            // 
            this.labelAddQual.AutoSize = true;
            this.labelAddQual.ForeColor = System.Drawing.Color.Fuchsia;
            this.labelAddQual.Location = new System.Drawing.Point(17, 37);
            this.labelAddQual.Name = "labelAddQual";
            this.labelAddQual.Size = new System.Drawing.Size(139, 27);
            this.labelAddQual.TabIndex = 20;
            this.labelAddQual.Text = "Qualification";
            // 
            // groupBoxAddStaff
            // 
            this.groupBoxAddStaff.Controls.Add(this.listViewQualifications);
            this.groupBoxAddStaff.Controls.Add(this.btnDeleteQual);
            this.groupBoxAddStaff.Controls.Add(this.btnChangeQual);
            this.groupBoxAddStaff.Controls.Add(this.btnAddQual);
            this.groupBoxAddStaff.Controls.Add(this.textBoxAddQual);
            this.groupBoxAddStaff.Controls.Add(this.labelAddQual);
            this.groupBoxAddStaff.Font = new System.Drawing.Font("Rockwell Nova", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAddStaff.ForeColor = System.Drawing.Color.Purple;
            this.groupBoxAddStaff.Location = new System.Drawing.Point(59, 122);
            this.groupBoxAddStaff.Name = "groupBoxAddStaff";
            this.groupBoxAddStaff.Size = new System.Drawing.Size(781, 343);
            this.groupBoxAddStaff.TabIndex = 21;
            this.groupBoxAddStaff.TabStop = false;
            this.groupBoxAddStaff.Text = "Qualifications";
            // 
            // listViewQualifications
            // 
            this.listViewQualifications.HideSelection = false;
            this.listViewQualifications.Location = new System.Drawing.Point(174, 99);
            this.listViewQualifications.MultiSelect = false;
            this.listViewQualifications.Name = "listViewQualifications";
            this.listViewQualifications.Size = new System.Drawing.Size(584, 214);
            this.listViewQualifications.TabIndex = 10;
            this.listViewQualifications.TabStop = false;
            this.listViewQualifications.UseCompatibleStateImageBehavior = false;
            this.listViewQualifications.View = System.Windows.Forms.View.List;
            // 
            // btnDeleteQual
            // 
            this.btnDeleteQual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteQual.Location = new System.Drawing.Point(21, 271);
            this.btnDeleteQual.Name = "btnDeleteQual";
            this.btnDeleteQual.Size = new System.Drawing.Size(115, 42);
            this.btnDeleteQual.TabIndex = 4;
            this.btnDeleteQual.Text = "Delete";
            this.btnDeleteQual.UseVisualStyleBackColor = true;
            this.btnDeleteQual.Click += new System.EventHandler(this.deleteQualification);
            // 
            // btnChangeQual
            // 
            this.btnChangeQual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeQual.Location = new System.Drawing.Point(21, 185);
            this.btnChangeQual.Name = "btnChangeQual";
            this.btnChangeQual.Size = new System.Drawing.Size(115, 42);
            this.btnChangeQual.TabIndex = 3;
            this.btnChangeQual.Text = "Change";
            this.btnChangeQual.UseVisualStyleBackColor = true;
            this.btnChangeQual.Click += new System.EventHandler(this.changeQualification);
            // 
            // btnAddQual
            // 
            this.btnAddQual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddQual.Location = new System.Drawing.Point(21, 99);
            this.btnAddQual.Name = "btnAddQual";
            this.btnAddQual.Size = new System.Drawing.Size(115, 42);
            this.btnAddQual.TabIndex = 2;
            this.btnAddQual.Text = "Add";
            this.btnAddQual.UseVisualStyleBackColor = true;
            this.btnAddQual.Click += new System.EventHandler(this.addQualification);
            // 
            // textBoxAddQual
            // 
            this.textBoxAddQual.ForeColor = System.Drawing.Color.Black;
            this.textBoxAddQual.Location = new System.Drawing.Point(174, 30);
            this.textBoxAddQual.Name = "textBoxAddQual";
            this.textBoxAddQual.Size = new System.Drawing.Size(395, 34);
            this.textBoxAddQual.TabIndex = 1;
            // 
            // textBoxStaffName
            // 
            this.textBoxStaffName.Font = new System.Drawing.Font("Rockwell Nova", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStaffName.ForeColor = System.Drawing.Color.Black;
            this.textBoxStaffName.Location = new System.Drawing.Point(233, 51);
            this.textBoxStaffName.Name = "textBoxStaffName";
            this.textBoxStaffName.Size = new System.Drawing.Size(253, 34);
            this.textBoxStaffName.TabIndex = 0;
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
            this.btnOK.Click += new System.EventHandler(this.staffAddedOK);
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
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 571);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textBoxStaffName);
            this.Controls.Add(this.groupBoxAddStaff);
            this.Controls.Add(this.labelStaffName);
            this.Name = "StaffForm";
            this.Text = "Staff Registration";
            this.groupBoxAddStaff.ResumeLayout(false);
            this.groupBoxAddStaff.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStaffName;
        private System.Windows.Forms.Label labelAddQual;
        private System.Windows.Forms.GroupBox groupBoxAddStaff;
        private System.Windows.Forms.TextBox textBoxAddQual;
        private System.Windows.Forms.TextBox textBoxStaffName;
        private System.Windows.Forms.Button btnAddQual;
        private System.Windows.Forms.ListView listViewQualifications;
        private System.Windows.Forms.Button btnDeleteQual;
        private System.Windows.Forms.Button btnChangeQual;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}