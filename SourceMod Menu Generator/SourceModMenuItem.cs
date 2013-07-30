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
using System.Text;

namespace SourceMod_Menu_Generator
{
    public class SourceModMenuItem
    {
        public const string DISABLED = "ITEMDRAW_DISABLED";
        public const string RAWLINE = "ITEMDRAW_RAWLINE";
        public const string NOTEXT = "ITEMDRAW_NOTEXT";
        public const string SPACER = "ITEMDRAW_SPACER";

        [Flags]
        public enum ItemDraw
        {
            Default = 0,		                /**< Item should be drawn normally */
            Disabled = (1 << 0),	            /**< Item is drawn but not selectable */
            RawLine = (1 << 1),                /**< Item should be a raw line, without a slot */
            NoText = (1 << 2),                 /**< No text should be drawn */
            Spacer = (1 << 3),                 /**< Item should be drawn as a spacer, if possible */
        }

        public string ItemName { get; set; }
        public string DisplayName { get; set; }
        public ItemDraw DrawRules { get; set; }
    }
}
