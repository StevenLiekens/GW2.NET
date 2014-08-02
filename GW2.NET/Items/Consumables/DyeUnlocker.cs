﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DyeUnlocker.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents a dye.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2DotNET.Items
{
    using GW2DotNET.Colors;

    /// <summary>Represents a dye.</summary>
    public class DyeUnlocker : Unlocker
    {
        /// <summary>Gets or sets the color.</summary>
        public virtual ColorPalette Color { get; set; }

        /// <summary>Gets or sets the color identifier.</summary>
        public virtual int ColorId { get; set; }
    }
}