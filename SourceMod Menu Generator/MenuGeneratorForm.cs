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
    public partial class MenuGeneratorForm : Form
    {
        enum MenuStyle
        {
            Default = 0,	/*< The "default" menu style for the mod */
            Valve = 1,		/*< The Valve provided menu style (Used on HL2DM) */
            Radio = 2,		/*< The simpler menu style commonly used on CS:S */
        }

        [Flags]
        public enum MenuAction
        {
            Start = (1 << 0),		/*< A menu has been started (nothing passed) */
            Display = (1 << 1),	    /*< A menu is about to be displayed (param1=client, param2=MenuPanel Handle) */
            Select = (1 << 2),		/*< An item was selected (param1=client, param2=item) */
            Cancel = (1 << 3),		/*< The menu was cancelled (param1=client, param2=reason) */
            End = (1 << 4),		    /*< A menu display has fully ended.
									                param1 is the MenuEnd reason, and if it's MenuEnd_Cancelled, then 
									                param2 is the MenuCancel reason from MenuAction_Cancel.
										                */
            VoteEnd = (1 << 5),	    /*< (VOTE ONLY): A vote sequence has succeeded (param1=chosen item) 
									                This is not called if SetVoteResultCallback has been used on the menu. */
            VoteStart = (1 << 6), 	/*< (VOTE ONLY): A vote sequence has started (nothing passed) */
            VoteCancel = (1 << 7),	/*< (VOTE ONLY): A vote sequence has been cancelled (param1=reason) */
            DrawItem = (1 << 8),	/*< An item is being drawn; return the new style (param1=client, param2=item) */
            DisplayItem = (1 << 9), /*< Item text is being drawn to the display (param1=client, param2=item)
									                To change the text, use RedrawMenuItem().
									                If you do so, return its return value.  Otherwise, return 0.
										                */
        }

        const MenuAction MENU_ACTIONS_DEFAULT = MenuAction.Select | MenuAction.Cancel | MenuAction.End;
        const string START = "MenuAction_Start";
        const string DISPLAY = "MenuAction_Display";
        const string SELECT = "MenuAction_Select";
        const string CANCEL = "MenuAction_Cancel";
        const string END = "MenuAction_End";
        const string VOTEEND = "MenuAction_VoteEnd";
        const string VOTESTART = "MenuAction_VoteStart";
        const string VOTECANCEL = "MenuAction_VoteCancel";
        const string DRAWITEM = "MenuAction_DrawItem";
        const string DISPLAYITEM = "MenuAction_DisplayItem";
        const string HANDLER = "public %s(Handle:menu, MenuAction:action, param1, param2)";
        const string ACTION_SWITCH = "switch (action)";
        const string ACTION_CASE = "case %s:";
        const string EXIT_BACK = "if (param2 == MenuEnd_ExitBack)";
        
        public MenuGeneratorForm()
        {
            InitializeComponent();
        }

        private void MenuGeneratorForm_Load(object sender, EventArgs e)
        {
            typeComboBox.SelectedIndex = 0; // Select "Default" form type
        }

        private void closeHandleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                endCheckBox.Checked = true;
            }
        }

        private void submenuCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                cancelCheckBox.Checked = true;
            }
        }

        private void titleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                displayCheckBox.Checked = true;
            }
        }

        private void cancelCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!((CheckBox)sender).Checked)
            {
                submenuCheckBox.Checked = false;
            }
        }

        private void endCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!((CheckBox)sender).Checked)
            {
                closeHandleCheckBox.Checked = false;
            }
        }

        private void displayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!((CheckBox)sender).Checked)
            {
                titleCheckBox.Checked = false;
            }
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            var addForm = new AddMenuItemForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                menuItemsListBox.Items.Add(addForm.MenuItem);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            SourceModMenuItem menuItem = menuItemsListBox.SelectedItem as SourceModMenuItem;
            if (menuItem != null)
            {
                var editForm = new AddMenuItemForm(menuItem);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    int selectedIndex = menuItemsListBox.Items.IndexOf(menuItem);
                    menuItemsListBox.Items.Remove(menuItem);
                    menuItemsListBox.Items.Insert(selectedIndex, editForm.MenuItem);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            SourceModMenuItem menuItem = menuItemsListBox.SelectedItem as SourceModMenuItem;
            if (menuItem != null)
            {
                if (MessageBox.Show("Delete menu item \"" + menuItem.DisplayName + "\" ?", "Delete Item", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    menuItemsListBox.Items.Remove(menuItem);
                }
            }
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            if (menuItemsListBox.Items.Count > 1)
            {
                object selectedItem = menuItemsListBox.SelectedItem;
                if (selectedItem != null)
                {
                    int position = menuItemsListBox.Items.IndexOf(selectedItem);
                    if (position > 0)
                    {
                        menuItemsListBox.Items.Remove(selectedItem);
                        menuItemsListBox.Items.Insert(position - 1, selectedItem);
                        menuItemsListBox.SelectedItem = selectedItem;
                    }
                }
            }
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            if (menuItemsListBox.Items.Count > 1)
            {
                object selectedItem = menuItemsListBox.SelectedItem;
                if (selectedItem != null)
                {
                    int position = menuItemsListBox.Items.IndexOf(selectedItem);
                    if (position < menuItemsListBox.Items.Count - 1)
                    {
                        menuItemsListBox.Items.Remove(selectedItem);
                        menuItemsListBox.Items.Insert(position + 1, selectedItem);
                        menuItemsListBox.SelectedItem = selectedItem;
                    }
                }
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            bool errors = false;
            if (string.IsNullOrEmpty(menuHandlerTextBox.Text))
            {
                errors = true;
                errorProvider1.SetError(menuHandlerTextBox, "Menu handler can't be empty");
            }
            else if (menuHandlerTextBox.Text.Contains(" "))
            {
                errors = true;
                errorProvider1.SetError(menuHandlerTextBox, "Menu handler can't contain spaces");
            }
            else if (menuHandlerTextBox.Text == "MenuHandler")
            {
                errors = true;
                errorProvider1.SetError(menuHandlerTextBox, "MenuHandler is a reserved name");
            }

            if (errors)
            {
                return;
            }

            var codeBuilder = new StringBuilder();

            // Normally I'd use a List<string>, but we need string.Join
            var actions = new string[10];
            int actionCount = 0;

            if (startCheckBox.Checked)
            {
                actions[actionCount] = START;
                ++actionCount;
            }

            if (displayCheckBox.Checked || titleCheckBox.Checked)
            {
                actions[actionCount] = DISPLAY;
                ++actionCount;
            }

            if (selectCheckBox.Checked)
            {
                actions[actionCount] = SELECT;
                ++actionCount;
            }

            if (cancelCheckBox.Checked || submenuCheckBox.Checked)
            {
                actions[actionCount] = CANCEL;
                ++actionCount;
            }

            if (endCheckBox.Checked || closeHandleCheckBox.Checked)
            {
                actions[actionCount] = END;
                ++actionCount;
            }

            /*
            // Vote not yet implemented
            if (voteEndCheckBox.Checked)
            {
                actions[actionCount] = VOTEEND;
                ++actionCount;
            }

            if (voteStartCheckBox.Checked)
            {
                actions[actionCount] = VOTESTART;
                ++actionCount;
            }

            if (voteCancelCheckBox.Checked)
            {
                actions[actionCount] = VOTECANCEL;
                ++actionCount;
            }
             */

            if (overrideStyleCheckBox.Checked)
            {
                actions[actionCount] = DRAWITEM;
                ++actionCount;
            }

            if (translationCheckBox.Checked)
            {
                actions[actionCount] = DISPLAYITEM;
                ++actionCount;
            }

            String displayStyles;

            if (actionCount == 0)
            {
                displayStyles = "MENU_ACTIONS_DEFAULT";
            }
            else
            {
                displayStyles = string.Join(" | ", actions, 0, actionCount);
            }

            codeBuilder.AppendLine("MyFunction(client)").AppendLine("{");

            codeBuilder.Append("\tnew Handle:menu = CreateMenu");

            switch ((MenuStyle)typeComboBox.SelectedIndex)
            {
                case MenuStyle.Valve:
                    codeBuilder.Append("Ex(GetMenuStyleHandle(MenuStyle_Valve), ");
                    break;

                case MenuStyle.Radio:
                    codeBuilder.Append("Ex(GetMenuStyleHandle(MenuStyle_Radio), ");
                    break;

                default:
                    codeBuilder.Append("(");
                    break;

            }

            codeBuilder.Append(menuHandlerTextBox.Text).Append(", ").Append(displayStyles).AppendLine(");");

            if (!string.IsNullOrEmpty(menuNameTextBox.Text))
            {
                codeBuilder.Append("\tSetMenuTitle(menu, \"").Append(menuNameTextBox.Text).AppendLine("\");");
            }

            if (!paginationCheckBox.Checked)
            {
                codeBuilder.AppendLine("\tSetMenuPagination(menu, MENO_NO_PAGINATION);");
            }

            codeBuilder.AppendLine();

            foreach (SourceModMenuItem item in menuItemsListBox.Items)
            {
                var drawRules = new string[6]; // We only use 4 of the 6
                int stylesCount = 0;

                if ((item.DrawRules & SourceModMenuItem.ItemDraw.Disabled) == SourceModMenuItem.ItemDraw.Disabled)
                {
                    drawRules[stylesCount] = SourceModMenuItem.DISABLED;
                    ++stylesCount;
                }
                
                if ((item.DrawRules & SourceModMenuItem.ItemDraw.RawLine) == SourceModMenuItem.ItemDraw.RawLine)
                {
                    drawRules[stylesCount] = SourceModMenuItem.RAWLINE;
                    ++stylesCount;
                }

                if ((item.DrawRules & SourceModMenuItem.ItemDraw.NoText) == SourceModMenuItem.ItemDraw.NoText)
                {
                    drawRules[stylesCount] = SourceModMenuItem.NOTEXT;
                    ++stylesCount;
                }

                if ((item.DrawRules & SourceModMenuItem.ItemDraw.Spacer) == SourceModMenuItem.ItemDraw.Spacer)
                {
                    drawRules[stylesCount] = SourceModMenuItem.SPACER;
                    ++stylesCount;
                }

                codeBuilder.Append("\tAddMenuItem(menu, \"").Append(item.ItemName).Append("\", \"").Append(item.DisplayName).Append("\"");

                if (stylesCount > 0)
                {
                    string drawStyles = string.Join(" | ", drawRules, 0, stylesCount);
                    codeBuilder.Append(", ").Append(drawStyles);
                }

                codeBuilder.AppendLine(");");
            }

            codeBuilder.AppendLine().AppendLine("\tDisplayMenu(menu, client, MENU_TIME_FOREVER);");

            codeBuilder.AppendLine("}").AppendLine();

            // Start Handler section

            codeBuilder.Append("public ").Append(menuHandlerTextBox.Text).AppendLine("(Handle:menu, MenuAction:action, param1, param2)").AppendLine("{");

            codeBuilder.AppendLine("\tswitch (action)").AppendLine("\t{");

            // MenuAction_Start
            if (startCheckBox.Checked)
            {
                codeBuilder.Append("\t\tcase ").Append(START).AppendLine(":").AppendLine("\t\t{");

                codeBuilder.AppendLine("\t\t\t//param1 and param2 unset").AppendLine();

                codeBuilder.AppendLine("\t\t}").AppendLine();
            }

            // MenuAction_Display
            if (displayCheckBox.Checked || titleCheckBox.Checked)
            {
                codeBuilder.Append("\t\tcase ").Append(DISPLAY).AppendLine(":").AppendLine("\t\t{");

                codeBuilder.AppendLine("\t\t\t//param1 is client, param2 is panel handle").AppendLine();

                if (titleCheckBox.Checked)
                {
                    codeBuilder.AppendLine("\t\t\tnew String:title[255];").AppendLine("\t\t\tFormat(title, sizeof(title), \"%T\", \"menutitle\", param1)");
                    codeBuilder.AppendLine("\t\t\tSetPanelTitle(Handle:param2, title);");
                }

                codeBuilder.AppendLine("\t\t}").AppendLine();
            }

            // MenuAction_Select
            if (selectCheckBox.Checked)
            {
                codeBuilder.Append("\t\tcase ").Append(SELECT).AppendLine(":").AppendLine("\t\t{");

                codeBuilder.AppendLine("\t\t\t//param1 is client, param2 is item").AppendLine();

                codeBuilder.AppendLine("\t\t\tnew String:item[64];").AppendLine("\t\t\tGetMenuItem(menu, param2, item, sizeof(item));").AppendLine();

                bool multiple = false;

                foreach (SourceModMenuItem item in menuItemsListBox.Items)
                {
                    if (item.DrawRules.Equals(SourceModMenuItem.ItemDraw.Default))
                    {
                        codeBuilder.Append("\t\t\t");
                        if (multiple)
                        {
                            codeBuilder.Append("else ");
                        }
                        multiple = true;
                        codeBuilder.Append("if (StrEqual(item, \"").Append(item.ItemName).AppendLine("\"))").AppendLine("\t\t\t{").AppendLine().AppendLine("\t\t\t}");
                        
                    }
                }

                codeBuilder.AppendLine("\t\t}").AppendLine();
            }

            // MenuAction_Cancel
            if (cancelCheckBox.Checked || submenuCheckBox.Checked)
            {
                codeBuilder.Append("\t\tcase ").Append(CANCEL).AppendLine(":").AppendLine("\t\t{");

                codeBuilder.AppendLine("\t\t\t//param1 is client, param2 is cancel reason (see MenuCancel types)");

                if (submenuCheckBox.Checked)
                {
                    codeBuilder.AppendLine("\t\t\tif (param2 == MenuCancel_ExitBack)").AppendLine("\t\t\t{");
                    codeBuilder.AppendLine("\t\t\t\t//Code to return to parent menu").AppendLine().AppendLine("\t\t\t}");
                }
                codeBuilder.AppendLine();

                codeBuilder.AppendLine("\t\t}").AppendLine();
            }

            // MenuAction_End
            if (endCheckBox.Checked || closeHandleCheckBox.Checked)
            {
                codeBuilder.Append("\t\tcase ").Append(END).AppendLine(":").AppendLine("\t\t{");

                codeBuilder.AppendLine("\t\t\t//param1 is MenuEnd reason, if canceled param2 is MenuCancel reason");

                if (closeHandleCheckBox.Checked)
                {
                    codeBuilder.AppendLine("\t\t\tCloseHandle(menu);");
                }

                codeBuilder.AppendLine().AppendLine("\t\t}").AppendLine();
            }

            // MenuAction_VoteEnd
            // MenuAction_VoteStart
            // MenuAction_VoteCancel
                // Sir Not Appearing In This Code

            // MenuAction_DrawItem
            if (overrideStyleCheckBox.Checked)
            {
                codeBuilder.Append("\t\tcase ").Append(DRAWITEM).AppendLine(":").AppendLine("\t\t{");

                codeBuilder.AppendLine("\t\t\t//param1 is client, param2 is item").AppendLine();

                codeBuilder.AppendLine("\t\t\tnew String:item[64];").AppendLine("\t\t\tnew style;").AppendLine("\t\t\tGetMenuItem(menu, param2, item, sizeof(item), style);").AppendLine();

                codeBuilder.AppendLine("\t\t\t// You must return a bitwise joined set of ITEMDRAW constants or ITEMDRAW_DEFAULT");
                codeBuilder.AppendLine("\t\t\treturn ITEMDRAW_DEFAULT;");

                codeBuilder.AppendLine().AppendLine("\t\t}").AppendLine();
            }

            // MenuAction_DisplayItem
            if (translationCheckBox.Checked)
            {
                codeBuilder.Append("\t\tcase ").Append(DISPLAYITEM).AppendLine(":").AppendLine("\t\t{");

                codeBuilder.AppendLine("\t\t\t//param1 is client, param2 is item").AppendLine();

                codeBuilder.AppendLine("\t\t\tnew String:item[64];").AppendLine("\t\t\tGetMenuItem(menu, param2, item, sizeof(item));").AppendLine();

                bool multiple = false;

                foreach (SourceModMenuItem item in menuItemsListBox.Items)
                {
                    if ((item.DrawRules & SourceModMenuItem.ItemDraw.NoText) != SourceModMenuItem.ItemDraw.NoText && (item.DrawRules & SourceModMenuItem.ItemDraw.Spacer) != SourceModMenuItem.ItemDraw.Spacer)
                    {
                        codeBuilder.Append("\t\t\t");
                        if (multiple)
                        {
                            codeBuilder.Append("else ");
                        }
                        multiple = true;
                        codeBuilder.Append("if (StrEqual(item, \"").Append(item.ItemName).AppendLine("\"))").AppendLine("\t\t\t{");
                        codeBuilder.AppendLine("\t\t\t\tnew String:translation[128];").Append("\t\t\t\tFormat(translation, sizeof(translation), \"%T\", \"").Append(item.ItemName).Append("\", param1").AppendLine(");");
                        codeBuilder.AppendLine("\t\t\t\treturn RedrawMenuItem(translation);");
                        codeBuilder.AppendLine("\t\t\t}");

                    }
                }

                codeBuilder.AppendLine("\t\t}").AppendLine();
            }

            codeBuilder.AppendLine("\t}");

            if (translationCheckBox.Checked || overrideStyleCheckBox.Checked)
            {
                codeBuilder.AppendLine("\treturn 0;");
            }

            codeBuilder.AppendLine("}");

            codeTextBox.Text = codeBuilder.ToString();
        }
    }
}
