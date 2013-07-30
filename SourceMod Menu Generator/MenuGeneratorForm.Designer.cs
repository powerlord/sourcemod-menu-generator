namespace SourceMod_Menu_Generator
{
    partial class MenuGeneratorForm
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
            this.components = new System.ComponentModel.Container();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.menuStyleLabel = new System.Windows.Forms.Label();
            this.menuSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.overrideStyleCheckBox = new System.Windows.Forms.CheckBox();
            this.selectCheckBox = new System.Windows.Forms.CheckBox();
            this.displayCheckBox = new System.Windows.Forms.CheckBox();
            this.startCheckBox = new System.Windows.Forms.CheckBox();
            this.closeHandleCheckBox = new System.Windows.Forms.CheckBox();
            this.endCheckBox = new System.Windows.Forms.CheckBox();
            this.titleCheckBox = new System.Windows.Forms.CheckBox();
            this.paginationCheckBox = new System.Windows.Forms.CheckBox();
            this.cancelCheckBox = new System.Windows.Forms.CheckBox();
            this.translationCheckBox = new System.Windows.Forms.CheckBox();
            this.submenuCheckBox = new System.Windows.Forms.CheckBox();
            this.menuInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.menuHandlerTextBox = new System.Windows.Forms.TextBox();
            this.menuHandlerLabel = new System.Windows.Forms.Label();
            this.menuNameTextBox = new System.Windows.Forms.TextBox();
            this.menuNameLabel = new System.Windows.Forms.Label();
            this.menuItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.downButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addItemButton = new System.Windows.Forms.Button();
            this.menuItemsListBox = new System.Windows.Forms.ListBox();
            this.codeGroupBox = new System.Windows.Forms.GroupBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.generateButton = new System.Windows.Forms.Button();
            this.menuSettingsGroupBox.SuspendLayout();
            this.menuInfoGroupBox.SuspendLayout();
            this.menuItemsGroupBox.SuspendLayout();
            this.codeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Default",
            "Valve",
            "Radio"});
            this.typeComboBox.Location = new System.Drawing.Point(72, 19);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(199, 21);
            this.typeComboBox.TabIndex = 1;
            // 
            // menuStyleLabel
            // 
            this.menuStyleLabel.AutoSize = true;
            this.menuStyleLabel.Location = new System.Drawing.Point(6, 22);
            this.menuStyleLabel.Name = "menuStyleLabel";
            this.menuStyleLabel.Size = new System.Drawing.Size(60, 13);
            this.menuStyleLabel.TabIndex = 0;
            this.menuStyleLabel.Text = "Menu Style";
            // 
            // menuSettingsGroupBox
            // 
            this.menuSettingsGroupBox.Controls.Add(this.overrideStyleCheckBox);
            this.menuSettingsGroupBox.Controls.Add(this.selectCheckBox);
            this.menuSettingsGroupBox.Controls.Add(this.displayCheckBox);
            this.menuSettingsGroupBox.Controls.Add(this.startCheckBox);
            this.menuSettingsGroupBox.Controls.Add(this.closeHandleCheckBox);
            this.menuSettingsGroupBox.Controls.Add(this.endCheckBox);
            this.menuSettingsGroupBox.Controls.Add(this.titleCheckBox);
            this.menuSettingsGroupBox.Controls.Add(this.paginationCheckBox);
            this.menuSettingsGroupBox.Controls.Add(this.cancelCheckBox);
            this.menuSettingsGroupBox.Controls.Add(this.translationCheckBox);
            this.menuSettingsGroupBox.Controls.Add(this.submenuCheckBox);
            this.menuSettingsGroupBox.Controls.Add(this.typeComboBox);
            this.menuSettingsGroupBox.Controls.Add(this.menuStyleLabel);
            this.menuSettingsGroupBox.Location = new System.Drawing.Point(12, 115);
            this.menuSettingsGroupBox.Name = "menuSettingsGroupBox";
            this.menuSettingsGroupBox.Size = new System.Drawing.Size(277, 185);
            this.menuSettingsGroupBox.TabIndex = 1;
            this.menuSettingsGroupBox.TabStop = false;
            this.menuSettingsGroupBox.Text = "Menu Settings";
            // 
            // overrideStyleCheckBox
            // 
            this.overrideStyleCheckBox.AutoSize = true;
            this.overrideStyleCheckBox.Location = new System.Drawing.Point(137, 138);
            this.overrideStyleCheckBox.Name = "overrideStyleCheckBox";
            this.overrideStyleCheckBox.Size = new System.Drawing.Size(125, 17);
            this.overrideStyleCheckBox.TabIndex = 11;
            this.overrideStyleCheckBox.Text = "Override Draw Styles";
            this.overrideStyleCheckBox.UseVisualStyleBackColor = true;
            // 
            // selectCheckBox
            // 
            this.selectCheckBox.AutoSize = true;
            this.selectCheckBox.Checked = true;
            this.selectCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.selectCheckBox.Location = new System.Drawing.Point(6, 46);
            this.selectCheckBox.Name = "selectCheckBox";
            this.selectCheckBox.Size = new System.Drawing.Size(107, 17);
            this.selectCheckBox.TabIndex = 2;
            this.selectCheckBox.Text = "Implement Select";
            this.selectCheckBox.UseVisualStyleBackColor = true;
            // 
            // displayCheckBox
            // 
            this.displayCheckBox.AutoSize = true;
            this.displayCheckBox.Location = new System.Drawing.Point(6, 115);
            this.displayCheckBox.Name = "displayCheckBox";
            this.displayCheckBox.Size = new System.Drawing.Size(111, 17);
            this.displayCheckBox.TabIndex = 8;
            this.displayCheckBox.Text = "Implement Display";
            this.displayCheckBox.UseVisualStyleBackColor = true;
            this.displayCheckBox.CheckedChanged += new System.EventHandler(this.displayCheckBox_CheckedChanged);
            // 
            // startCheckBox
            // 
            this.startCheckBox.AutoSize = true;
            this.startCheckBox.Location = new System.Drawing.Point(137, 46);
            this.startCheckBox.Name = "startCheckBox";
            this.startCheckBox.Size = new System.Drawing.Size(99, 17);
            this.startCheckBox.TabIndex = 3;
            this.startCheckBox.Text = "Implement Start";
            this.startCheckBox.UseVisualStyleBackColor = true;
            // 
            // closeHandleCheckBox
            // 
            this.closeHandleCheckBox.AutoSize = true;
            this.closeHandleCheckBox.Checked = true;
            this.closeHandleCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.closeHandleCheckBox.Location = new System.Drawing.Point(151, 92);
            this.closeHandleCheckBox.Name = "closeHandleCheckBox";
            this.closeHandleCheckBox.Size = new System.Drawing.Size(123, 17);
            this.closeHandleCheckBox.TabIndex = 7;
            this.closeHandleCheckBox.Text = "CloseHandle on End";
            this.closeHandleCheckBox.UseVisualStyleBackColor = true;
            this.closeHandleCheckBox.CheckedChanged += new System.EventHandler(this.closeHandleCheckBox_CheckedChanged);
            // 
            // endCheckBox
            // 
            this.endCheckBox.AutoSize = true;
            this.endCheckBox.Checked = true;
            this.endCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.endCheckBox.Location = new System.Drawing.Point(137, 69);
            this.endCheckBox.Name = "endCheckBox";
            this.endCheckBox.Size = new System.Drawing.Size(96, 17);
            this.endCheckBox.TabIndex = 6;
            this.endCheckBox.Text = "Implement End";
            this.endCheckBox.UseVisualStyleBackColor = true;
            this.endCheckBox.CheckedChanged += new System.EventHandler(this.endCheckBox_CheckedChanged);
            // 
            // titleCheckBox
            // 
            this.titleCheckBox.AutoSize = true;
            this.titleCheckBox.Location = new System.Drawing.Point(25, 138);
            this.titleCheckBox.Name = "titleCheckBox";
            this.titleCheckBox.Size = new System.Drawing.Size(101, 17);
            this.titleCheckBox.TabIndex = 9;
            this.titleCheckBox.Text = "Title Translation";
            this.titleCheckBox.UseVisualStyleBackColor = true;
            this.titleCheckBox.CheckedChanged += new System.EventHandler(this.titleCheckBox_CheckedChanged);
            // 
            // paginationCheckBox
            // 
            this.paginationCheckBox.AutoSize = true;
            this.paginationCheckBox.Checked = true;
            this.paginationCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.paginationCheckBox.Location = new System.Drawing.Point(137, 115);
            this.paginationCheckBox.Name = "paginationCheckBox";
            this.paginationCheckBox.Size = new System.Drawing.Size(104, 17);
            this.paginationCheckBox.TabIndex = 10;
            this.paginationCheckBox.Text = "Paginated Menu";
            this.paginationCheckBox.UseVisualStyleBackColor = true;
            // 
            // cancelCheckBox
            // 
            this.cancelCheckBox.AutoSize = true;
            this.cancelCheckBox.Location = new System.Drawing.Point(6, 69);
            this.cancelCheckBox.Name = "cancelCheckBox";
            this.cancelCheckBox.Size = new System.Drawing.Size(110, 17);
            this.cancelCheckBox.TabIndex = 4;
            this.cancelCheckBox.Text = "Implement Cancel";
            this.cancelCheckBox.UseVisualStyleBackColor = true;
            this.cancelCheckBox.CheckedChanged += new System.EventHandler(this.cancelCheckBox_CheckedChanged);
            // 
            // translationCheckBox
            // 
            this.translationCheckBox.AutoSize = true;
            this.translationCheckBox.Checked = true;
            this.translationCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.translationCheckBox.Location = new System.Drawing.Point(6, 161);
            this.translationCheckBox.Name = "translationCheckBox";
            this.translationCheckBox.Size = new System.Drawing.Size(101, 17);
            this.translationCheckBox.TabIndex = 12;
            this.translationCheckBox.Text = "Item Translation";
            this.translationCheckBox.UseVisualStyleBackColor = true;
            // 
            // submenuCheckBox
            // 
            this.submenuCheckBox.AutoSize = true;
            this.submenuCheckBox.Location = new System.Drawing.Point(23, 92);
            this.submenuCheckBox.Name = "submenuCheckBox";
            this.submenuCheckBox.Size = new System.Drawing.Size(86, 17);
            this.submenuCheckBox.TabIndex = 5;
            this.submenuCheckBox.Text = "Is Sub Menu";
            this.submenuCheckBox.UseVisualStyleBackColor = true;
            this.submenuCheckBox.CheckedChanged += new System.EventHandler(this.submenuCheckBox_CheckedChanged);
            // 
            // menuInfoGroupBox
            // 
            this.menuInfoGroupBox.Controls.Add(this.menuHandlerTextBox);
            this.menuInfoGroupBox.Controls.Add(this.menuHandlerLabel);
            this.menuInfoGroupBox.Controls.Add(this.menuNameTextBox);
            this.menuInfoGroupBox.Controls.Add(this.menuNameLabel);
            this.menuInfoGroupBox.Location = new System.Drawing.Point(12, 12);
            this.menuInfoGroupBox.Name = "menuInfoGroupBox";
            this.menuInfoGroupBox.Size = new System.Drawing.Size(274, 97);
            this.menuInfoGroupBox.TabIndex = 0;
            this.menuInfoGroupBox.TabStop = false;
            this.menuInfoGroupBox.Text = "Menu Information";
            // 
            // menuHandlerTextBox
            // 
            this.menuHandlerTextBox.Location = new System.Drawing.Point(6, 71);
            this.menuHandlerTextBox.Name = "menuHandlerTextBox";
            this.menuHandlerTextBox.Size = new System.Drawing.Size(246, 20);
            this.menuHandlerTextBox.TabIndex = 3;
            // 
            // menuHandlerLabel
            // 
            this.menuHandlerLabel.AutoSize = true;
            this.menuHandlerLabel.Location = new System.Drawing.Point(6, 55);
            this.menuHandlerLabel.Name = "menuHandlerLabel";
            this.menuHandlerLabel.Size = new System.Drawing.Size(74, 13);
            this.menuHandlerLabel.TabIndex = 2;
            this.menuHandlerLabel.Text = "Menu Handler";
            // 
            // menuNameTextBox
            // 
            this.menuNameTextBox.Location = new System.Drawing.Point(6, 32);
            this.menuNameTextBox.Name = "menuNameTextBox";
            this.menuNameTextBox.Size = new System.Drawing.Size(246, 20);
            this.menuNameTextBox.TabIndex = 1;
            // 
            // menuNameLabel
            // 
            this.menuNameLabel.AutoSize = true;
            this.menuNameLabel.Location = new System.Drawing.Point(6, 16);
            this.menuNameLabel.Name = "menuNameLabel";
            this.menuNameLabel.Size = new System.Drawing.Size(102, 13);
            this.menuNameLabel.TabIndex = 0;
            this.menuNameLabel.Text = "Menu Display Name";
            // 
            // menuItemsGroupBox
            // 
            this.menuItemsGroupBox.Controls.Add(this.downButton);
            this.menuItemsGroupBox.Controls.Add(this.upButton);
            this.menuItemsGroupBox.Controls.Add(this.deleteButton);
            this.menuItemsGroupBox.Controls.Add(this.editButton);
            this.menuItemsGroupBox.Controls.Add(this.addItemButton);
            this.menuItemsGroupBox.Controls.Add(this.menuItemsListBox);
            this.menuItemsGroupBox.Location = new System.Drawing.Point(13, 307);
            this.menuItemsGroupBox.Name = "menuItemsGroupBox";
            this.menuItemsGroupBox.Size = new System.Drawing.Size(276, 203);
            this.menuItemsGroupBox.TabIndex = 2;
            this.menuItemsGroupBox.TabStop = false;
            this.menuItemsGroupBox.Text = "Menu Items";
            // 
            // downButton
            // 
            this.downButton.Location = new System.Drawing.Point(103, 174);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(75, 23);
            this.downButton.TabIndex = 5;
            this.downButton.Text = "Move Down";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // upButton
            // 
            this.upButton.Location = new System.Drawing.Point(8, 174);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(75, 23);
            this.upButton.TabIndex = 4;
            this.upButton.Text = "Move Up";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(195, 146);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(103, 146);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(8, 146);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(75, 23);
            this.addItemButton.TabIndex = 1;
            this.addItemButton.Text = "Add";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // menuItemsListBox
            // 
            this.menuItemsListBox.DisplayMember = "DisplayName";
            this.menuItemsListBox.FormattingEnabled = true;
            this.menuItemsListBox.Location = new System.Drawing.Point(6, 19);
            this.menuItemsListBox.Name = "menuItemsListBox";
            this.menuItemsListBox.Size = new System.Drawing.Size(264, 121);
            this.menuItemsListBox.TabIndex = 0;
            // 
            // codeGroupBox
            // 
            this.codeGroupBox.Controls.Add(this.codeTextBox);
            this.codeGroupBox.Location = new System.Drawing.Point(295, 13);
            this.codeGroupBox.Name = "codeGroupBox";
            this.codeGroupBox.Size = new System.Drawing.Size(747, 497);
            this.codeGroupBox.TabIndex = 3;
            this.codeGroupBox.TabStop = false;
            this.codeGroupBox.Text = "Final Code";
            // 
            // codeTextBox
            // 
            this.codeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.codeTextBox.Location = new System.Drawing.Point(7, 19);
            this.codeTextBox.Multiline = true;
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.ReadOnly = true;
            this.codeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.codeTextBox.Size = new System.Drawing.Size(734, 472);
            this.codeTextBox.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(13, 517);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(1023, 62);
            this.generateButton.TabIndex = 4;
            this.generateButton.Text = "GENERATE CODE";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // MenuGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 591);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.codeGroupBox);
            this.Controls.Add(this.menuItemsGroupBox);
            this.Controls.Add(this.menuInfoGroupBox);
            this.Controls.Add(this.menuSettingsGroupBox);
            this.Name = "MenuGeneratorForm";
            this.Text = "SourceMod Menu Generator";
            this.Load += new System.EventHandler(this.MenuGeneratorForm_Load);
            this.menuSettingsGroupBox.ResumeLayout(false);
            this.menuSettingsGroupBox.PerformLayout();
            this.menuInfoGroupBox.ResumeLayout(false);
            this.menuInfoGroupBox.PerformLayout();
            this.menuItemsGroupBox.ResumeLayout(false);
            this.codeGroupBox.ResumeLayout(false);
            this.codeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label menuStyleLabel;
        private System.Windows.Forms.GroupBox menuSettingsGroupBox;
        private System.Windows.Forms.CheckBox paginationCheckBox;
        private System.Windows.Forms.CheckBox cancelCheckBox;
        private System.Windows.Forms.CheckBox translationCheckBox;
        private System.Windows.Forms.CheckBox submenuCheckBox;
        private System.Windows.Forms.CheckBox selectCheckBox;
        private System.Windows.Forms.CheckBox displayCheckBox;
        private System.Windows.Forms.CheckBox startCheckBox;
        private System.Windows.Forms.CheckBox closeHandleCheckBox;
        private System.Windows.Forms.CheckBox endCheckBox;
        private System.Windows.Forms.CheckBox titleCheckBox;
        private System.Windows.Forms.CheckBox overrideStyleCheckBox;
        private System.Windows.Forms.GroupBox menuInfoGroupBox;
        private System.Windows.Forms.Label menuNameLabel;
        private System.Windows.Forms.TextBox menuHandlerTextBox;
        private System.Windows.Forms.Label menuHandlerLabel;
        private System.Windows.Forms.TextBox menuNameTextBox;
        private System.Windows.Forms.GroupBox menuItemsGroupBox;
        private System.Windows.Forms.ListBox menuItemsListBox;
        private System.Windows.Forms.GroupBox codeGroupBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button generateButton;

    }
}

