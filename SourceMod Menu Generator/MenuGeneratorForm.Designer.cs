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
            this.paginationCheckBox = new System.Windows.Forms.CheckBox();
            this.translationCheckBox = new System.Windows.Forms.CheckBox();
            this.downButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addItemButton = new System.Windows.Forms.Button();
            this.menuItemsListBox = new System.Windows.Forms.ListBox();
            this.codeGroupBox = new System.Windows.Forms.GroupBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.generateButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.parentCheckBox = new System.Windows.Forms.CheckBox();
            this.exitCheckBox = new System.Windows.Forms.CheckBox();
            this.menuTimeGroupBox = new System.Windows.Forms.GroupBox();
            this.menuTimeExampleLabel = new System.Windows.Forms.Label();
            this.parentMenuDisplayTextBox = new System.Windows.Forms.TextBox();
            this.parentMenuLabel = new System.Windows.Forms.Label();
            this.itemSelectedComboBox = new System.Windows.Forms.ComboBox();
            this.menuNameGroupBox = new System.Windows.Forms.GroupBox();
            this.menuNameTextBox = new System.Windows.Forms.TextBox();
            this.nameTranslationCheckBox = new System.Windows.Forms.CheckBox();
            this.ItemSelectedLabel = new System.Windows.Forms.Label();
            this.menuHandlerTextBox = new System.Windows.Forms.TextBox();
            this.menuHandlerLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.itemTranslationWikiLinkLabel = new System.Windows.Forms.LinkLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pluginCheckBox = new System.Windows.Forms.CheckBox();
            this.methodNameGroupBox = new System.Windows.Forms.GroupBox();
            this.methodNameTextBox = new System.Windows.Forms.TextBox();
            this.methodNameExampleLabel = new System.Windows.Forms.Label();
            this.accessGroupBox = new System.Windows.Forms.GroupBox();
            this.accessLevelLinkLabel = new System.Windows.Forms.LinkLabel();
            this.accessLevelComboBox = new System.Windows.Forms.ComboBox();
            this.commandDescriptionGroupBox = new System.Windows.Forms.GroupBox();
            this.commandDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.commandDescriptionExampleLabel = new System.Windows.Forms.Label();
            this.commandGroupBox2 = new System.Windows.Forms.GroupBox();
            this.commandTextBox = new System.Windows.Forms.TextBox();
            this.commandExampleLabel = new System.Windows.Forms.Label();
            this.powerlordLinkLabel = new System.Windows.Forms.LinkLabel();
            this.clipboardButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuTimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.codeGroupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuTimeGroupBox.SuspendLayout();
            this.menuNameGroupBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.methodNameGroupBox.SuspendLayout();
            this.accessGroupBox.SuspendLayout();
            this.commandDescriptionGroupBox.SuspendLayout();
            this.commandGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuTimeNumericUpDown)).BeginInit();
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
            this.typeComboBox.Location = new System.Drawing.Point(72, 120);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(162, 21);
            this.typeComboBox.TabIndex = 1;
            // 
            // menuStyleLabel
            // 
            this.menuStyleLabel.AutoSize = true;
            this.menuStyleLabel.Location = new System.Drawing.Point(6, 123);
            this.menuStyleLabel.Name = "menuStyleLabel";
            this.menuStyleLabel.Size = new System.Drawing.Size(60, 13);
            this.menuStyleLabel.TabIndex = 0;
            this.menuStyleLabel.Text = "Menu Style";
            // 
            // paginationCheckBox
            // 
            this.paginationCheckBox.AutoSize = true;
            this.paginationCheckBox.Checked = true;
            this.paginationCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.paginationCheckBox.Location = new System.Drawing.Point(6, 147);
            this.paginationCheckBox.Name = "paginationCheckBox";
            this.paginationCheckBox.Size = new System.Drawing.Size(104, 17);
            this.paginationCheckBox.TabIndex = 10;
            this.paginationCheckBox.Text = "Paginated Menu";
            this.paginationCheckBox.UseVisualStyleBackColor = true;
            // 
            // translationCheckBox
            // 
            this.translationCheckBox.AutoSize = true;
            this.translationCheckBox.Checked = true;
            this.translationCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.translationCheckBox.Location = new System.Drawing.Point(4, 294);
            this.translationCheckBox.Name = "translationCheckBox";
            this.translationCheckBox.Size = new System.Drawing.Size(101, 17);
            this.translationCheckBox.TabIndex = 12;
            this.translationCheckBox.Text = "Item Translation";
            this.translationCheckBox.UseVisualStyleBackColor = true;
            // 
            // downButton
            // 
            this.downButton.Location = new System.Drawing.Point(85, 265);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(73, 23);
            this.downButton.TabIndex = 5;
            this.downButton.Text = "Move Down";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // upButton
            // 
            this.upButton.Location = new System.Drawing.Point(6, 265);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(73, 23);
            this.upButton.TabIndex = 4;
            this.upButton.Text = "Move Up";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(163, 236);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(71, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(85, 236);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(73, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(6, 236);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(73, 23);
            this.addItemButton.TabIndex = 1;
            this.addItemButton.Text = "Add";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // menuItemsListBox
            // 
            this.menuItemsListBox.DisplayMember = "DisplayName";
            this.menuItemsListBox.FormattingEnabled = true;
            this.menuItemsListBox.Location = new System.Drawing.Point(6, 6);
            this.menuItemsListBox.Name = "menuItemsListBox";
            this.menuItemsListBox.Size = new System.Drawing.Size(230, 225);
            this.menuItemsListBox.TabIndex = 0;
            // 
            // codeGroupBox
            // 
            this.codeGroupBox.Controls.Add(this.codeTextBox);
            this.codeGroupBox.Location = new System.Drawing.Point(268, 12);
            this.codeGroupBox.Name = "codeGroupBox";
            this.codeGroupBox.Size = new System.Drawing.Size(747, 497);
            this.codeGroupBox.TabIndex = 3;
            this.codeGroupBox.TabStop = false;
            this.codeGroupBox.Text = "Generated code";
            // 
            // codeTextBox
            // 
            this.codeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.codeTextBox.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeTextBox.Location = new System.Drawing.Point(7, 19);
            this.codeTextBox.Multiline = true;
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.ReadOnly = true;
            this.codeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.codeTextBox.Size = new System.Drawing.Size(734, 472);
            this.codeTextBox.TabIndex = 0;
            this.codeTextBox.WordWrap = false;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(13, 517);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(249, 62);
            this.generateButton.TabIndex = 4;
            this.generateButton.Text = "Generate Code";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(250, 498);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.parentCheckBox);
            this.tabPage1.Controls.Add(this.exitCheckBox);
            this.tabPage1.Controls.Add(this.menuTimeGroupBox);
            this.tabPage1.Controls.Add(this.parentMenuDisplayTextBox);
            this.tabPage1.Controls.Add(this.parentMenuLabel);
            this.tabPage1.Controls.Add(this.itemSelectedComboBox);
            this.tabPage1.Controls.Add(this.menuNameGroupBox);
            this.tabPage1.Controls.Add(this.ItemSelectedLabel);
            this.tabPage1.Controls.Add(this.menuHandlerTextBox);
            this.tabPage1.Controls.Add(this.paginationCheckBox);
            this.tabPage1.Controls.Add(this.menuStyleLabel);
            this.tabPage1.Controls.Add(this.typeComboBox);
            this.tabPage1.Controls.Add(this.menuHandlerLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(242, 472);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Menu Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // parentCheckBox
            // 
            this.parentCheckBox.AutoSize = true;
            this.parentCheckBox.Location = new System.Drawing.Point(6, 246);
            this.parentCheckBox.Name = "parentCheckBox";
            this.parentCheckBox.Size = new System.Drawing.Size(139, 17);
            this.parentCheckBox.TabIndex = 16;
            this.parentCheckBox.Text = "Menu Has Parent Menu";
            this.parentCheckBox.UseVisualStyleBackColor = true;
            this.parentCheckBox.CheckedChanged += new System.EventHandler(this.parentCheckBox_CheckedChanged);
            // 
            // exitCheckBox
            // 
            this.exitCheckBox.AutoSize = true;
            this.exitCheckBox.Checked = true;
            this.exitCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.exitCheckBox.Location = new System.Drawing.Point(6, 170);
            this.exitCheckBox.Name = "exitCheckBox";
            this.exitCheckBox.Size = new System.Drawing.Size(127, 17);
            this.exitCheckBox.TabIndex = 2;
            this.exitCheckBox.Text = "Menu has Exit Button";
            this.exitCheckBox.UseVisualStyleBackColor = true;
            // 
            // menuTimeGroupBox
            // 
            this.menuTimeGroupBox.Controls.Add(this.menuTimeNumericUpDown);
            this.menuTimeGroupBox.Controls.Add(this.menuTimeExampleLabel);
            this.menuTimeGroupBox.Location = new System.Drawing.Point(6, 193);
            this.menuTimeGroupBox.Name = "menuTimeGroupBox";
            this.menuTimeGroupBox.Size = new System.Drawing.Size(230, 47);
            this.menuTimeGroupBox.TabIndex = 15;
            this.menuTimeGroupBox.TabStop = false;
            this.menuTimeGroupBox.Text = "Display Time";
            // 
            // menuTimeExampleLabel
            // 
            this.menuTimeExampleLabel.AutoSize = true;
            this.menuTimeExampleLabel.Location = new System.Drawing.Point(66, 23);
            this.menuTimeExampleLabel.Name = "menuTimeExampleLabel";
            this.menuTimeExampleLabel.Size = new System.Drawing.Size(136, 13);
            this.menuTimeExampleLabel.TabIndex = 1;
            this.menuTimeExampleLabel.Text = "In seconds, 0 = until closed";
            // 
            // parentMenuDisplayTextBox
            // 
            this.parentMenuDisplayTextBox.Enabled = false;
            this.parentMenuDisplayTextBox.Location = new System.Drawing.Point(32, 282);
            this.parentMenuDisplayTextBox.Name = "parentMenuDisplayTextBox";
            this.parentMenuDisplayTextBox.Size = new System.Drawing.Size(204, 20);
            this.parentMenuDisplayTextBox.TabIndex = 14;
            // 
            // parentMenuLabel
            // 
            this.parentMenuLabel.AutoSize = true;
            this.parentMenuLabel.Location = new System.Drawing.Point(29, 266);
            this.parentMenuLabel.Name = "parentMenuLabel";
            this.parentMenuLabel.Size = new System.Drawing.Size(144, 13);
            this.parentMenuLabel.TabIndex = 13;
            this.parentMenuLabel.Text = "Parent Menu Display Method";
            // 
            // itemSelectedComboBox
            // 
            this.itemSelectedComboBox.FormattingEnabled = true;
            this.itemSelectedComboBox.Items.AddRange(new object[] {
            "Close menu (default)",
            "Redisplay menu"});
            this.itemSelectedComboBox.Location = new System.Drawing.Point(7, 322);
            this.itemSelectedComboBox.Name = "itemSelectedComboBox";
            this.itemSelectedComboBox.Size = new System.Drawing.Size(227, 21);
            this.itemSelectedComboBox.TabIndex = 12;
            // 
            // menuNameGroupBox
            // 
            this.menuNameGroupBox.Controls.Add(this.menuNameTextBox);
            this.menuNameGroupBox.Controls.Add(this.nameTranslationCheckBox);
            this.menuNameGroupBox.Location = new System.Drawing.Point(6, 6);
            this.menuNameGroupBox.Name = "menuNameGroupBox";
            this.menuNameGroupBox.Size = new System.Drawing.Size(230, 69);
            this.menuNameGroupBox.TabIndex = 11;
            this.menuNameGroupBox.TabStop = false;
            this.menuNameGroupBox.Text = "Menu name";
            // 
            // menuNameTextBox
            // 
            this.menuNameTextBox.Location = new System.Drawing.Point(6, 19);
            this.menuNameTextBox.Name = "menuNameTextBox";
            this.menuNameTextBox.Size = new System.Drawing.Size(216, 20);
            this.menuNameTextBox.TabIndex = 1;
            this.menuNameTextBox.Text = "MyMenu";
            // 
            // nameTranslationCheckBox
            // 
            this.nameTranslationCheckBox.AutoSize = true;
            this.nameTranslationCheckBox.Location = new System.Drawing.Point(6, 45);
            this.nameTranslationCheckBox.Name = "nameTranslationCheckBox";
            this.nameTranslationCheckBox.Size = new System.Drawing.Size(159, 17);
            this.nameTranslationCheckBox.TabIndex = 9;
            this.nameTranslationCheckBox.Text = "Menu Name has Translation";
            this.nameTranslationCheckBox.UseVisualStyleBackColor = true;
            // 
            // ItemSelectedLabel
            // 
            this.ItemSelectedLabel.AutoSize = true;
            this.ItemSelectedLabel.Location = new System.Drawing.Point(6, 305);
            this.ItemSelectedLabel.Name = "ItemSelectedLabel";
            this.ItemSelectedLabel.Size = new System.Drawing.Size(127, 13);
            this.ItemSelectedLabel.TabIndex = 10;
            this.ItemSelectedLabel.Text = "When items are selected:";
            // 
            // menuHandlerTextBox
            // 
            this.menuHandlerTextBox.Location = new System.Drawing.Point(9, 94);
            this.menuHandlerTextBox.Name = "menuHandlerTextBox";
            this.menuHandlerTextBox.Size = new System.Drawing.Size(225, 20);
            this.menuHandlerTextBox.TabIndex = 3;
            this.menuHandlerTextBox.Text = "mh_MyHandler";
            // 
            // menuHandlerLabel
            // 
            this.menuHandlerLabel.AutoSize = true;
            this.menuHandlerLabel.Location = new System.Drawing.Point(6, 78);
            this.menuHandlerLabel.Name = "menuHandlerLabel";
            this.menuHandlerLabel.Size = new System.Drawing.Size(101, 13);
            this.menuHandlerLabel.TabIndex = 2;
            this.menuHandlerLabel.Text = "Menu handler name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.itemTranslationWikiLinkLabel);
            this.tabPage2.Controls.Add(this.downButton);
            this.tabPage2.Controls.Add(this.menuItemsListBox);
            this.tabPage2.Controls.Add(this.upButton);
            this.tabPage2.Controls.Add(this.addItemButton);
            this.tabPage2.Controls.Add(this.translationCheckBox);
            this.tabPage2.Controls.Add(this.deleteButton);
            this.tabPage2.Controls.Add(this.editButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(242, 472);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Menu Items";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // itemTranslationWikiLinkLabel
            // 
            this.itemTranslationWikiLinkLabel.AutoSize = true;
            this.itemTranslationWikiLinkLabel.Location = new System.Drawing.Point(111, 294);
            this.itemTranslationWikiLinkLabel.Name = "itemTranslationWikiLinkLabel";
            this.itemTranslationWikiLinkLabel.Size = new System.Drawing.Size(81, 13);
            this.itemTranslationWikiLinkLabel.TabIndex = 13;
            this.itemTranslationWikiLinkLabel.TabStop = true;
            this.itemTranslationWikiLinkLabel.Text = "Wiki Reference";
            this.itemTranslationWikiLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.itemTranslationWikiLinkLabel_LinkClicked);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pluginCheckBox);
            this.tabPage3.Controls.Add(this.methodNameGroupBox);
            this.tabPage3.Controls.Add(this.accessGroupBox);
            this.tabPage3.Controls.Add(this.commandDescriptionGroupBox);
            this.tabPage3.Controls.Add(this.commandGroupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(242, 472);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cmd Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pluginCheckBox
            // 
            this.pluginCheckBox.AutoSize = true;
            this.pluginCheckBox.Checked = true;
            this.pluginCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pluginCheckBox.Location = new System.Drawing.Point(3, 72);
            this.pluginCheckBox.Name = "pluginCheckBox";
            this.pluginCheckBox.Size = new System.Drawing.Size(103, 17);
            this.pluginCheckBox.TabIndex = 4;
            this.pluginCheckBox.Text = "Add Plugin Shell";
            this.pluginCheckBox.UseVisualStyleBackColor = true;
            this.pluginCheckBox.CheckedChanged += new System.EventHandler(this.pluginCheckBox_CheckedChanged);
            // 
            // methodNameGroupBox
            // 
            this.methodNameGroupBox.Controls.Add(this.methodNameTextBox);
            this.methodNameGroupBox.Controls.Add(this.methodNameExampleLabel);
            this.methodNameGroupBox.Location = new System.Drawing.Point(3, 3);
            this.methodNameGroupBox.Name = "methodNameGroupBox";
            this.methodNameGroupBox.Size = new System.Drawing.Size(236, 63);
            this.methodNameGroupBox.TabIndex = 3;
            this.methodNameGroupBox.TabStop = false;
            this.methodNameGroupBox.Text = "Method Name";
            // 
            // methodNameTextBox
            // 
            this.methodNameTextBox.Location = new System.Drawing.Point(6, 37);
            this.methodNameTextBox.Name = "methodNameTextBox";
            this.methodNameTextBox.Size = new System.Drawing.Size(223, 20);
            this.methodNameTextBox.TabIndex = 1;
            this.methodNameTextBox.Text = "ShowMenu";
            // 
            // methodNameExampleLabel
            // 
            this.methodNameExampleLabel.AutoSize = true;
            this.methodNameExampleLabel.Location = new System.Drawing.Point(6, 20);
            this.methodNameExampleLabel.Name = "methodNameExampleLabel";
            this.methodNameExampleLabel.Size = new System.Drawing.Size(107, 13);
            this.methodNameExampleLabel.TabIndex = 0;
            this.methodNameExampleLabel.Text = "Example: ShowMenu";
            // 
            // accessGroupBox
            // 
            this.accessGroupBox.Controls.Add(this.accessLevelLinkLabel);
            this.accessGroupBox.Controls.Add(this.accessLevelComboBox);
            this.accessGroupBox.Location = new System.Drawing.Point(3, 235);
            this.accessGroupBox.Name = "accessGroupBox";
            this.accessGroupBox.Size = new System.Drawing.Size(236, 60);
            this.accessGroupBox.TabIndex = 2;
            this.accessGroupBox.TabStop = false;
            this.accessGroupBox.Text = "Access Level";
            // 
            // accessLevelLinkLabel
            // 
            this.accessLevelLinkLabel.AutoSize = true;
            this.accessLevelLinkLabel.Location = new System.Drawing.Point(149, 16);
            this.accessLevelLinkLabel.Name = "accessLevelLinkLabel";
            this.accessLevelLinkLabel.Size = new System.Drawing.Size(81, 13);
            this.accessLevelLinkLabel.TabIndex = 1;
            this.accessLevelLinkLabel.TabStop = true;
            this.accessLevelLinkLabel.Text = "Wiki Reference";
            this.accessLevelLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.accessLevelLinkLabel_LinkClicked);
            // 
            // accessLevelComboBox
            // 
            this.accessLevelComboBox.FormattingEnabled = true;
            this.accessLevelComboBox.Items.AddRange(new object[] {
            "Everyone (default)",
            "a - Admin_Reservation",
            "b - Admin_Generic",
            "c - Admin_Kick",
            "d - Admin_Ban",
            "e - Admin_Unban",
            "f - Admin_Slay",
            "g - Admin_Changemap",
            "h - Admin_Convars",
            "i - Admin_Config",
            "j - Admin_Chat",
            "k - Admin_Vote",
            "l - Admin_Password",
            "m - Admin_RCON",
            "n - Admin_Cheats",
            "z - Admin_Root",
            "o - Admin_Custom1",
            "p - Admin_Custom2",
            "q - Admin_Custom3",
            "r - Admin_Custom4",
            "s - Admin_Custom5",
            "t - Admin_Custom6"});
            this.accessLevelComboBox.Location = new System.Drawing.Point(8, 32);
            this.accessLevelComboBox.Name = "accessLevelComboBox";
            this.accessLevelComboBox.Size = new System.Drawing.Size(223, 21);
            this.accessLevelComboBox.TabIndex = 0;
            // 
            // commandDescriptionGroupBox
            // 
            this.commandDescriptionGroupBox.Controls.Add(this.commandDescriptionTextBox);
            this.commandDescriptionGroupBox.Controls.Add(this.commandDescriptionExampleLabel);
            this.commandDescriptionGroupBox.Location = new System.Drawing.Point(4, 160);
            this.commandDescriptionGroupBox.Name = "commandDescriptionGroupBox";
            this.commandDescriptionGroupBox.Size = new System.Drawing.Size(235, 69);
            this.commandDescriptionGroupBox.TabIndex = 1;
            this.commandDescriptionGroupBox.TabStop = false;
            this.commandDescriptionGroupBox.Text = "Command Description";
            // 
            // commandDescriptionTextBox
            // 
            this.commandDescriptionTextBox.Location = new System.Drawing.Point(7, 37);
            this.commandDescriptionTextBox.Name = "commandDescriptionTextBox";
            this.commandDescriptionTextBox.Size = new System.Drawing.Size(222, 20);
            this.commandDescriptionTextBox.TabIndex = 1;
            // 
            // commandDescriptionExampleLabel
            // 
            this.commandDescriptionExampleLabel.AutoSize = true;
            this.commandDescriptionExampleLabel.Location = new System.Drawing.Point(4, 21);
            this.commandDescriptionExampleLabel.Name = "commandDescriptionExampleLabel";
            this.commandDescriptionExampleLabel.Size = new System.Drawing.Size(126, 13);
            this.commandDescriptionExampleLabel.TabIndex = 0;
            this.commandDescriptionExampleLabel.Text = "Example: Brings up menu";
            // 
            // commandGroupBox2
            // 
            this.commandGroupBox2.Controls.Add(this.commandTextBox);
            this.commandGroupBox2.Controls.Add(this.commandExampleLabel);
            this.commandGroupBox2.Location = new System.Drawing.Point(4, 95);
            this.commandGroupBox2.Name = "commandGroupBox2";
            this.commandGroupBox2.Size = new System.Drawing.Size(235, 59);
            this.commandGroupBox2.TabIndex = 0;
            this.commandGroupBox2.TabStop = false;
            this.commandGroupBox2.Text = "Command";
            // 
            // commandTextBox
            // 
            this.commandTextBox.Location = new System.Drawing.Point(6, 32);
            this.commandTextBox.Name = "commandTextBox";
            this.commandTextBox.Size = new System.Drawing.Size(223, 20);
            this.commandTextBox.TabIndex = 1;
            this.commandTextBox.Text = "mymenu";
            // 
            // commandExampleLabel
            // 
            this.commandExampleLabel.AutoSize = true;
            this.commandExampleLabel.Location = new System.Drawing.Point(4, 16);
            this.commandExampleLabel.Name = "commandExampleLabel";
            this.commandExampleLabel.Size = new System.Drawing.Size(139, 13);
            this.commandExampleLabel.TabIndex = 0;
            this.commandExampleLabel.Text = "Examples: sm_menu, bacon";
            // 
            // powerlordLinkLabel
            // 
            this.powerlordLinkLabel.AutoSize = true;
            this.powerlordLinkLabel.Location = new System.Drawing.Point(266, 542);
            this.powerlordLinkLabel.Name = "powerlordLinkLabel";
            this.powerlordLinkLabel.Size = new System.Drawing.Size(235, 13);
            this.powerlordLinkLabel.TabIndex = 6;
            this.powerlordLinkLabel.TabStop = true;
            this.powerlordLinkLabel.Text = "SourceMod Menu Generator made by Powerlord";
            this.powerlordLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.powerlordLinkLabel_LinkClicked);
            // 
            // clipboardButton
            // 
            this.clipboardButton.Location = new System.Drawing.Point(507, 517);
            this.clipboardButton.Name = "clipboardButton";
            this.clipboardButton.Size = new System.Drawing.Size(249, 62);
            this.clipboardButton.TabIndex = 7;
            this.clipboardButton.Text = "Copy text to clipboard";
            this.clipboardButton.UseVisualStyleBackColor = true;
            this.clipboardButton.Click += new System.EventHandler(this.clipboardButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(762, 517);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(249, 62);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save .sp to file";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "SourcePawn Files (*.sp)|*.sp";
            // 
            // menuTimeNumericUpDown
            // 
            this.menuTimeNumericUpDown.Location = new System.Drawing.Point(6, 21);
            this.menuTimeNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.menuTimeNumericUpDown.Name = "menuTimeNumericUpDown";
            this.menuTimeNumericUpDown.Size = new System.Drawing.Size(54, 20);
            this.menuTimeNumericUpDown.TabIndex = 17;
            // 
            // MenuGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 584);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.clipboardButton);
            this.Controls.Add(this.powerlordLinkLabel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.codeGroupBox);
            this.Name = "MenuGeneratorForm";
            this.Text = "SourceMod Menu Generator";
            this.Load += new System.EventHandler(this.MenuGeneratorForm_Load);
            this.codeGroupBox.ResumeLayout(false);
            this.codeGroupBox.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.menuTimeGroupBox.ResumeLayout(false);
            this.menuTimeGroupBox.PerformLayout();
            this.menuNameGroupBox.ResumeLayout(false);
            this.menuNameGroupBox.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.methodNameGroupBox.ResumeLayout(false);
            this.methodNameGroupBox.PerformLayout();
            this.accessGroupBox.ResumeLayout(false);
            this.accessGroupBox.PerformLayout();
            this.commandDescriptionGroupBox.ResumeLayout(false);
            this.commandDescriptionGroupBox.PerformLayout();
            this.commandGroupBox2.ResumeLayout(false);
            this.commandGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuTimeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label menuStyleLabel;
        private System.Windows.Forms.CheckBox paginationCheckBox;
        private System.Windows.Forms.CheckBox translationCheckBox;
        private System.Windows.Forms.ListBox menuItemsListBox;
        private System.Windows.Forms.GroupBox codeGroupBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label ItemSelectedLabel;
        private System.Windows.Forms.TextBox menuHandlerTextBox;
        private System.Windows.Forms.Label menuHandlerLabel;
        private System.Windows.Forms.CheckBox nameTranslationCheckBox;
        private System.Windows.Forms.TextBox menuNameTextBox;
        private System.Windows.Forms.ComboBox itemSelectedComboBox;
        private System.Windows.Forms.GroupBox menuNameGroupBox;
        private System.Windows.Forms.LinkLabel itemTranslationWikiLinkLabel;
        private System.Windows.Forms.GroupBox commandGroupBox2;
        private System.Windows.Forms.TextBox commandTextBox;
        private System.Windows.Forms.Label commandExampleLabel;
        private System.Windows.Forms.GroupBox commandDescriptionGroupBox;
        private System.Windows.Forms.TextBox commandDescriptionTextBox;
        private System.Windows.Forms.Label commandDescriptionExampleLabel;
        private System.Windows.Forms.GroupBox accessGroupBox;
        private System.Windows.Forms.LinkLabel accessLevelLinkLabel;
        private System.Windows.Forms.ComboBox accessLevelComboBox;
        private System.Windows.Forms.Label parentMenuLabel;
        private System.Windows.Forms.GroupBox methodNameGroupBox;
        private System.Windows.Forms.Label methodNameExampleLabel;
        private System.Windows.Forms.TextBox methodNameTextBox;
        private System.Windows.Forms.TextBox parentMenuDisplayTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clipboardButton;
        private System.Windows.Forms.LinkLabel powerlordLinkLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox menuTimeGroupBox;
        private System.Windows.Forms.Label menuTimeExampleLabel;
        private System.Windows.Forms.CheckBox pluginCheckBox;
        private System.Windows.Forms.CheckBox exitCheckBox;
        private System.Windows.Forms.CheckBox parentCheckBox;
        private System.Windows.Forms.NumericUpDown menuTimeNumericUpDown;

    }
}

