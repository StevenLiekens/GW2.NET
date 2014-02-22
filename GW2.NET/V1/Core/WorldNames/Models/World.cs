﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="World.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace GW2DotNET.V1.Core.WorldNames.Models
{
    /// <summary>
    /// Represents a world and its localized name.
    /// </summary>
    public class World : JsonObject
    {
        /// <summary>
        /// Gets or sets the world's ID.
        /// </summary>
        [JsonProperty("id", Order = 0)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the world's name.
        /// </summary>
        [JsonProperty("name", Order = 1)]
        public string Name { get; set; }
    }
}