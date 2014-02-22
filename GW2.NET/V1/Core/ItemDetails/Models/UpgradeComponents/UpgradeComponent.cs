﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UpgradeComponent.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using GW2DotNET.V1.Core.Converters;
using GW2DotNET.V1.Core.ItemDetails.Models.Common;
using Newtonsoft.Json;

namespace GW2DotNET.V1.Core.ItemDetails.Models.UpgradeComponents
{
    /// <summary>
    /// Represents an upgrade component.
    /// </summary>
    [JsonConverter(typeof(DefaultConverter))]
    public class UpgradeComponent : Item
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpgradeComponent"/> class.
        /// </summary>
        public UpgradeComponent()
            : base(ItemType.UpgradeComponent)
        {
        }

        /// <summary>
        /// Gets or sets the upgrade component's details.
        /// </summary>
        [JsonProperty("upgrade_component", Order = 100)]
        public UpgradeComponentItemDetails UpgradeComponentItemDetails { get; set; }
    }
}