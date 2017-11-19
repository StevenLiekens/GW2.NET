// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FloorDTO.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2). See the License in the project root folder or the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Defines the FloorDTO type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GW2NET.V1.Floors.Json
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.Serialization;

    [DataContract]
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented", Justification = "http://wiki.guildwars2.com/wiki/API:1/map_floor")]
    public sealed class FloorDTO
    {
        [DataMember(Name = "texture_dims", Order = 0)]
        public double[] TextureDimensions { get; set; }

        [DataMember(Name = "clamped_view", Order = 1)]
        public double[][] ClampedView { get; set; }

        [DataMember(Name = "regions", Order = 2)]
        public IDictionary<string, RegionDTO> Regions { get; set; }
    }
}
