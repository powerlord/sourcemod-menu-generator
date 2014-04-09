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
using System.IO;

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


        enum Admins
        {
            Everyone,
            Reservation,    // a
            Generic,        // b
            Kick,           // c
            Ban,            // d
            Unban,          // e
            Slay,           // f
            ChangeMap,      // g
            Cvar,           // h
            Config,         // i
            Chat,           // j
            Vote,           // k
            Password,       // l
            Rcon,           // m
            Cheats,         // n
            Root,           // z
            Custom1,        // o
            Custom2,        // p
            Custom3,        // q
            Custom4,        // r
            Custom5,        // s
            Custom6,        // t
        }

        readonly string[] admFlags = { "", "ADMFLAG_RESERVATION", "ADMFLAG_GENERIC", "ADMFLAG_KICK", "ADMFLAG_BAN", "ADMFLAG_UNBAN", "ADMFLAG_SLAY", "ADMFLAG_CHANGEMAP", "ADMFLAG_CONVARS",
                                  "ADMFLAG_CONFIG", "ADMFLAG_CHAT", "ADMFLAG_VOTE", "ADMFLAG_PASSWORD", "ADMFLAG_RCON", "ADMFLAG_CHEATS", "ADMFLAG_ROOT", 
                                  "ADMFLAG_CUSTOM1", "ADMFLAG_CUSTOM2", "ADMFLAG_CUSTOM3", "ADMFLAG_CUSTOM4", "ADMFLAG_CUSTOM5", "ADMFLAG_CUSTOM6"};

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
            itemSelectedComboBox.SelectedIndex = 0;
            accessLevelComboBox.SelectedIndex = 0;
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
            //errorProvider1.Clear();

            StringBuilder errorList = new StringBuilder();

            if (string.IsNullOrEmpty(menuHandlerTextBox.Text))
            {
                // errorProvider1.SetError(menuHandlerTextBox, "Menu handler can't be empty");
                errorList.AppendLine("Menu handler can't be empty");

            }
            else if (menuHandlerTextBox.Text.Contains(" "))
            {
                //errorProvider1.SetError(menuHandlerTextBox, "Menu handler can't contain spaces");
                errorList.AppendLine("Menu handler can't contain spaces");
            }
            else if (menuHandlerTextBox.Text == "MenuHandler")
            {
                //errorProvider1.SetError(menuHandlerTextBox, "MenuHandler is a reserved name");
                errorList.AppendLine("MenuHandler is a reserved name");
            }

            if (string.IsNullOrEmpty(methodNameTextBox.Text))
            {
                //errorProvider1.SetError(methodNameTextBox, "Method name can't be empty");
                errorList.AppendLine("Method name can't be empty");
            }
            else if (methodNameTextBox.Text.Contains(" "))
            {
                //errorProvider1.SetError(methodNameTextBox, "Method name can't contain spaces");
                errorList.AppendLine("Method name can't contain spaces");
            }

            if (menuItemsListBox.Items.Count <= 0)
            {
                //errorProvider1.SetError(menuItemsListBox, "At least one menu item is required.");
                errorList.AppendLine("At least one menu item is required.");
            }

            if (parentCheckBox.Checked)
            {
                if (string.IsNullOrEmpty(parentMenuDisplayTextBox.Text))
                {
                    //errorProvider1.SetError(parentMenuDisplayTextBox, "Parent method name can't be empty if exiting back to parent");
                    errorList.AppendLine("Parent Menu method can't be empty");
                }
                else if (parentMenuDisplayTextBox.Text.Contains(" "))
                {
                    //errorProvider1.SetError(parentMenuDisplayTextBox, "Parent method name can't contain spaces");
                    errorList.AppendLine("Parent Menu method can't contain spaces");
                }
            }

            if (errorList.Length > 0)
            {
                MessageBox.Show(errorList.ToString(), "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var codeBuilder = new StringBuilder();

            if (pluginCheckBox.Checked)
            {
                codeBuilder.AppendLine("public Plugin:myinfo =").AppendLine("{").AppendLine("\tname = \"Plugin Name\",");
                codeBuilder.AppendLine("\tauthor = \"Me\",").AppendLine("\tdescription = \"\",").AppendLine("\tversion = \"1.0.0\",");
                codeBuilder.AppendLine("\turl = \"https://forums.alliedmods.net/\"").AppendLine("}").AppendLine();

                codeBuilder.AppendLine("public OnPluginStart()").AppendLine("{");

                codeBuilder.AppendLine("\tLoadTranslations(\"common.phrases\");");
                if (translationCheckBox.Checked || nameTranslationCheckBox.Checked)
                {
                    codeBuilder.AppendLine("\tLoadTranslations(\"myplugin.phrases\");");
                }
                codeBuilder.AppendLine();

                Admins admins = (Admins)accessLevelComboBox.SelectedIndex;
                if (admins == Admins.Everyone)
                {
                    codeBuilder.Append("\tRegConsoleCmd(");
                }
                else
                {
                    codeBuilder.Append("\tRegAdminCmd(");
                }

                codeBuilder.Append("\"").Append(commandTextBox.Text).Append("\", ").Append("Cmd_").Append(commandTextBox.Text);

                if (admins != Admins.Everyone)
                {
                    codeBuilder.Append(", ").Append(admFlags[(int)admins]);
                }

                if (!string.IsNullOrEmpty(commandDescriptionTextBox.Text))
                {
                    codeBuilder.Append(", ").Append("\"").Append(commandDescriptionTextBox.Text).Append("\"");
                }
                codeBuilder.AppendLine(")");

                codeBuilder.AppendLine("}").AppendLine();

                codeBuilder.Append("public Action:Cmd_").Append(commandTextBox.Text).AppendLine("(client, args)");
                codeBuilder.AppendLine("{");
                codeBuilder.AppendLine("\tif (client == 0)");
                codeBuilder.AppendLine("\t{");
                codeBuilder.AppendLine("\t\tReplyToCommand(client, \"%t\", \"Command is in-game only\");");
                codeBuilder.AppendLine("\t\treturn Plugin_Handled;");
                codeBuilder.AppendLine("\t}");
                codeBuilder.Append("\t").Append(methodNameTextBox.Text).AppendLine("(client);");
                codeBuilder.AppendLine("\treturn Plugin_Handled;");
                codeBuilder.AppendLine("}").AppendLine();
            }

            // Normally I'd use a List<string>, but we need string.Join
            var actions = new string[10];

            actions[0] = "MENU_ACTIONS_DEFAULT";
            int actionCount = 1;

            if (nameTranslationCheckBox.Checked)
            {
                actions[actionCount] = DISPLAY;
                ++actionCount;
            }

            if (translationCheckBox.Checked)
            {
                actions[actionCount] = DISPLAYITEM;
                ++actionCount;
            }

            String displayStyles = string.Join(" | ", actions, 0, actionCount);

            codeBuilder.Append(methodNameTextBox.Text).AppendLine("(client)").AppendLine("{");

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
                codeBuilder.AppendLine("\tSetMenuPagination(menu, MENU_NO_PAGINATION);");
            }

            if (!exitCheckBox.Checked)
            {
                codeBuilder.AppendLine("\tSetMenuExitButton(menu, false);");
            }

            if (parentCheckBox.Checked)
            {
                codeBuilder.AppendLine("\tSetMenuExitBackButton(menu, true);");
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

            codeBuilder.AppendLine().Append("\tDisplayMenu(menu, client, ");

            string time = menuTimeTextBox.Text;
            if (time == "0")
            {
                time = "MENU_TIME_FOREVER";
            }

            codeBuilder.Append(time).AppendLine(");");

            codeBuilder.AppendLine("}").AppendLine();

            // Start Handler section

            codeBuilder.Append("public ").Append(menuHandlerTextBox.Text).AppendLine("(Handle:menu, MenuAction:action, param1, param2)").AppendLine("{");

            codeBuilder.AppendLine("\tswitch (action)").AppendLine("\t{");

            // MenuAction_Display
            if (nameTranslationCheckBox.Checked)
            {
                codeBuilder.Append("\t\tcase ").Append(DISPLAY).AppendLine(":").AppendLine("\t\t{");

                codeBuilder.AppendLine("\t\t\t//param1 is client, param2 is panel handle").AppendLine();

                if (nameTranslationCheckBox.Checked)
                {
                    codeBuilder.AppendLine("\t\t\tnew String:title[255];");
                    codeBuilder.Append("\t\t\tFormat(title, sizeof(title), \"%T\", \"").Append(menuNameTextBox.Text).AppendLine("\", param1)");
                    codeBuilder.AppendLine("\t\t\tSetPanelTitle(Handle:param2, title);");
                }

                codeBuilder.AppendLine("\t\t}").AppendLine();
            }

            // MenuAction_Select
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
                    codeBuilder.Append("if (StrEqual(item, \"").Append(item.ItemName).AppendLine("\"))").AppendLine("\t\t\t{").AppendLine("\t\t\t\t//Code for item here").AppendLine();
                    if (itemSelectedComboBox.SelectedIndex == 1)
                    {
                        codeBuilder.AppendLine("\t\t\t\tnew pos = GetMenuSelectionPosition(menu);");
                        codeBuilder.Append("\t\t\t\tDisplayMenuAtItem(CloneHandle(menu), client, pos, ").Append(time).AppendLine(");");
                    }
                    codeBuilder.AppendLine("\t\t\t}");
                }
            }

            codeBuilder.AppendLine("\t\t}").AppendLine();

            // MenuAction_Cancel
            if (parentCheckBox.Checked)
            {
                codeBuilder.Append("\t\tcase ").Append(CANCEL).AppendLine(":").AppendLine("\t\t{");

                codeBuilder.AppendLine("\t\t\t//param1 is client, param2 is cancel reason (see MenuCancel types)");

                codeBuilder.AppendLine("\t\t\tif (param2 == MenuCancel_ExitBack)").AppendLine("\t\t\t{");
                codeBuilder.Append("\t\t\t\t").Append(parentMenuDisplayTextBox.Text).AppendLine("(param1);");
                codeBuilder.AppendLine("\t\t\t}");
                codeBuilder.AppendLine();

                codeBuilder.AppendLine("\t\t}").AppendLine();
            }

            // MenuAction_End
            codeBuilder.Append("\t\tcase ").Append(END).AppendLine(":").AppendLine("\t\t{");

            codeBuilder.AppendLine("\t\t\t//param1 is MenuEnd reason, if canceled param2 is MenuCancel reason");

            codeBuilder.AppendLine("\t\t\tCloseHandle(menu);");

            codeBuilder.AppendLine().AppendLine("\t\t}").AppendLine();

            // MenuAction_DisplayItem
            if (translationCheckBox.Checked)
            {
                codeBuilder.Append("\t\tcase ").Append(DISPLAYITEM).AppendLine(":").AppendLine("\t\t{");

                codeBuilder.AppendLine("\t\t\t//param1 is client, param2 is item").AppendLine();

                codeBuilder.AppendLine("\t\t\tnew String:item[64];").AppendLine("\t\t\tGetMenuItem(menu, param2, item, sizeof(item));").AppendLine();

                multiple = false;

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
                        codeBuilder.AppendLine("\t\t\t\tnew String:translation[128];").Append("\t\t\t\tFormat(translation, sizeof(translation), \"%T\", \"").Append(item.DisplayName).Append("\", param1").AppendLine(");");
                        codeBuilder.AppendLine("\t\t\t\treturn RedrawMenuItem(translation);");
                        codeBuilder.AppendLine("\t\t\t}");

                    }
                }

                codeBuilder.AppendLine("\t\t}").AppendLine();
            }

            codeBuilder.AppendLine("\t}");

            if (translationCheckBox.Checked)
            {
                codeBuilder.AppendLine("\treturn 0;");
            }

            codeBuilder.AppendLine("}");

            codeTextBox.Text = codeBuilder.ToString();
        }

        private void itemTranslationWikiLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://wiki.alliedmods.net/Translations_%28SourceMod_Scripting%29");
        }

        private void accessLevelLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://wiki.alliedmods.net/Adding_Admins_%28SourceMod%29#Levels");
        }

        private void clipboardButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(codeTextBox.Text))
            {
                Clipboard.SetText(codeTextBox.Text);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(codeTextBox.Text))
            {

                DialogResult result = saveFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    using (StreamWriter writer = File.CreateText(saveFileDialog1.FileName))
                    {
                        writer.Write(codeTextBox.Text);
                        writer.Flush();
                        writer.Close();
                    }
                }
            }
        }

        private void powerlordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://forums.alliedmods.net/member.php?u=38996");
        }

        private void pluginCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pluginCheckBox.Checked)
            {
                commandTextBox.Enabled = true;
                commandDescriptionTextBox.Enabled = true;
                accessLevelComboBox.Enabled = true;
            }
            else
            {
                commandTextBox.Enabled = false;
                commandDescriptionTextBox.Enabled = false;
                accessLevelComboBox.Enabled = false;
            }
        }

        private void parentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (parentCheckBox.Checked)
            {
                parentMenuDisplayTextBox.Enabled = true;
            }
            else
            {
                parentMenuDisplayTextBox.Enabled = false;
            }
        }
    }
}
