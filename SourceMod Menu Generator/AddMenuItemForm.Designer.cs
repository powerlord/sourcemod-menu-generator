namespace SourceMod_Menu_Generator
{
    partial class AddMenuItemForm
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
            this.displayNameLabel = new System.Windows.Forms.Label();
            this.displayNameTextBox = new System.Windows.Forms.TextBox();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.addEditButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.spacerCheckBox = new System.Windows.Forms.CheckBox();
            this.noTextCheckBox = new System.Windows.Forms.CheckBox();
            this.rawLineCheckBox = new System.Windows.Forms.CheckBox();
            this.disabledCheckBox = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // displayNameLabel
            // 
            this.displayNameLabel.AutoSize = true;
            this.displayNameLabel.Location = new System.Drawing.Point(12, 9);
            this.displayNameLabel.Name = "displayNameLabel";
            this.displayNameLabel.Size = new System.Drawing.Size(72, 13);
            this.displayNameLabel.TabIndex = 0;
            this.displayNameLabel.Text = "Display Name";
            // 
            // displayNameTextBox
            // 
            this.displayNameTextBox.Location = new System.Drawing.Point(12, 25);
            this.displayNameTextBox.Name = "displayNameTextBox";
            this.displayNameTextBox.Size = new System.Drawing.Size(128, 20);
            this.displayNameTextBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.displayNameTextBox, "Text to show clients");
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Location = new System.Drawing.Point(12, 48);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(58, 13);
            this.itemNameLabel.TabIndex = 2;
            this.itemNameLabel.Text = "Item Name";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(12, 64);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(128, 20);
            this.itemNameTextBox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.itemNameTextBox, "Name used for Select and DisplayItem");
            // 
            // addEditButton
            // 
            this.addEditButton.Location = new System.Drawing.Point(12, 206);
            this.addEditButton.Name = "addEditButton";
            this.addEditButton.Size = new System.Drawing.Size(71, 23);
            this.addEditButton.TabIndex = 5;
            this.addEditButton.Text = "Add";
            this.addEditButton.UseVisualStyleBackColor = true;
            this.addEditButton.Click += new System.EventHandler(this.addEditButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(94, 206);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(69, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.spacerCheckBox);
            this.groupBox1.Controls.Add(this.noTextCheckBox);
            this.groupBox1.Controls.Add(this.rawLineCheckBox);
            this.groupBox1.Controls.Add(this.disabledCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 110);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Draw Options";
            // 
            // spacerCheckBox
            // 
            this.spacerCheckBox.AutoSize = true;
            this.spacerCheckBox.Location = new System.Drawing.Point(6, 88);
            this.spacerCheckBox.Name = "spacerCheckBox";
            this.spacerCheckBox.Size = new System.Drawing.Size(60, 17);
            this.spacerCheckBox.TabIndex = 3;
            this.spacerCheckBox.Text = "Spacer";
            this.spacerCheckBox.UseVisualStyleBackColor = true;
            // 
            // noTextCheckBox
            // 
            this.noTextCheckBox.AutoSize = true;
            this.noTextCheckBox.Location = new System.Drawing.Point(6, 65);
            this.noTextCheckBox.Name = "noTextCheckBox";
            this.noTextCheckBox.Size = new System.Drawing.Size(64, 17);
            this.noTextCheckBox.TabIndex = 2;
            this.noTextCheckBox.Text = "No Text";
            this.noTextCheckBox.UseVisualStyleBackColor = true;
            // 
            // rawLineCheckBox
            // 
            this.rawLineCheckBox.AutoSize = true;
            this.rawLineCheckBox.Location = new System.Drawing.Point(6, 42);
            this.rawLineCheckBox.Name = "rawLineCheckBox";
            this.rawLineCheckBox.Size = new System.Drawing.Size(71, 17);
            this.rawLineCheckBox.TabIndex = 1;
            this.rawLineCheckBox.Text = "Raw Line";
            this.rawLineCheckBox.UseVisualStyleBackColor = true;
            // 
            // disabledCheckBox
            // 
            this.disabledCheckBox.AutoSize = true;
            this.disabledCheckBox.Location = new System.Drawing.Point(6, 19);
            this.disabledCheckBox.Name = "disabledCheckBox";
            this.disabledCheckBox.Size = new System.Drawing.Size(67, 17);
            this.disabledCheckBox.TabIndex = 0;
            this.disabledCheckBox.Text = "Disabled";
            this.disabledCheckBox.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddMenuItemForm
            // 
            this.AcceptButton = this.addEditButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(175, 234);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addEditButton);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(this.itemNameLabel);
            this.Controls.Add(this.displayNameTextBox);
            this.Controls.Add(this.displayNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddMenuItemForm";
            this.Text = "Add Menu Item";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label displayNameLabel;
        private System.Windows.Forms.TextBox displayNameTextBox;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.Button addEditButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox spacerCheckBox;
        private System.Windows.Forms.CheckBox noTextCheckBox;
        private System.Windows.Forms.CheckBox rawLineCheckBox;
        private System.Windows.Forms.CheckBox disabledCheckBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}