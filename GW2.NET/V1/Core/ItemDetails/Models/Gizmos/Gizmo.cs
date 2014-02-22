﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Gizmo.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using GW2DotNET.V1.Core.Converters;
using GW2DotNET.V1.Core.ItemDetails.Models.Common;
using Newtonsoft.Json;

namespace GW2DotNET.V1.Core.ItemDetails.Models.Gizmos
{
    /// <summary>
    /// Represents a gizmo.
    /// </summary>
    [JsonConverter(typeof(DefaultConverter))]
    public class Gizmo : Item
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Gizmo"/> class.
        /// </summary>
        public Gizmo()
            : base(ItemType.Gizmo)
        {
        }

        /// <summary>
        /// Gets or sets the gizmo's details.
        /// </summary>
        [JsonProperty("gizmo", Order = 100)]
        public GizmoItemDetails GizmoItemDetails { get; set; }
    }
}