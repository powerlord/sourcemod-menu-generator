/// This file is part of SourceMod Menu Generator
///
/// SourceMod Menu Generator is free software: you can redistribute it and/or modify
/// it under the terms of the GNU General Public License as published by
/// the Free Software Foundation, either version 3 of the License, or
/// (at your option) any later version.
///
/// SourceMod Menu Generator is distributed in the hope that it will be useful,
/// but WITHOUT ANY WARRANTY; without even the implied warranty of
/// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
/// GNU General Public License for more details.
///
/// You should have received a copy of the GNU General Public License
/// along with SourceMod Menu Generator.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SourceMod_Menu_Generator
{
    public partial class AddMenuItemForm : Form
    {
        public enum FormMode
        {
            Add,
            Edit,
        }

        private FormMode mode = FormMode.Add;
        private SourceModMenuItem item = null;

        public FormMode Mode {
            get
            {
                return mode;
            }
        }

        public SourceModMenuItem MenuItem
        {
            get
            {
                return item;
            }
        }
        
        public AddMenuItemForm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        public AddMenuItemForm(SourceModMenuItem item) : this()
        {
            this.item = item;

            itemNameTextBox.Text = item.ItemName;
            displayNameTextBox.Text = item.DisplayName;

            if ((item.DrawRules & SourceModMenuItem.ItemDraw.Disabled) == SourceModMenuItem.ItemDraw.Disabled)
            {
                disabledCheckBox.Checked = true;
            }

            if ((item.DrawRules & SourceModMenuItem.ItemDraw.RawLine) == SourceModMenuItem.ItemDraw.RawLine)
            {
                rawLineCheckBox.Checked = true;
            }

            if ((item.DrawRules & SourceModMenuItem.ItemDraw.NoText) == SourceModMenuItem.ItemDraw.NoText)
            {
                noTextCheckBox.Checked = true;
            }

            if ((item.DrawRules & SourceModMenuItem.ItemDraw.Spacer) == SourceModMenuItem.ItemDraw.Spacer)
            {
                spacerCheckBox.Checked = true;
            }

            this.Text = "Edit Menu Item";
            addEditButton.Text = "Edit";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void addEditButton_Click(object sender, EventArgs e)
        {
            if (item == null)
            {
                item = new SourceModMenuItem();
            }

            bool errors = false;

            errorProvider1.Clear();

            if (string.IsNullOrEmpty(displayNameTextBox.Text))
            {
                errorProvider1.SetError(displayNameTextBox, "Display Name must be set");
                errors = true;
            }

            if (string.IsNullOrEmpty(itemNameTextBox.Text))
            {
                errorProvider1.SetError(itemNameTextBox, "Item Name must be set");
                errors = true;
            }

            if (errors)
            {
                return;
            }

            item.ItemName = itemNameTextBox.Text;
            item.DisplayName = displayNameTextBox.Text;

            item.DrawRules = SourceModMenuItem.ItemDraw.Default;

            if (disabledCheckBox.Checked)
            {
                item.DrawRules |= SourceModMenuItem.ItemDraw.Disabled;
            }

            if (rawLineCheckBox.Checked)
            {
                item.DrawRules |= SourceModMenuItem.ItemDraw.RawLine;
            }

            if (noTextCheckBox.Checked)
            {
                item.DrawRules |= SourceModMenuItem.ItemDraw.NoText;
            }

            if (spacerCheckBox.Checked)
            {
                item.DrawRules |= SourceModMenuItem.ItemDraw.Spacer;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
