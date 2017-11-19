// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MapDTO.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2). See the License in the project root folder or the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Defines the MapDTO type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GW2NET.V2.Maps.Json
{
    using System.Runtime.Serialization;

    /// <summary>Defines the map data contract.</summary>
    [DataContract]
    public sealed class MapDTO
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [DataMember(Name = "id", Order = 0)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [DataMember(Name = "name", Order = 1)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the minimum level.
        /// </summary>
        [DataMember(Name = "min_level", Order = 2)]
        public int MinimumLevel { get; set; }

        /// <summary>
        /// Gets or sets the maximum level.
        /// </summary>
        [DataMember(Name = "max_level", Order = 3)]
        public int MaximumLevel { get; set; }

        /// <summary>
        /// Gets or sets the map type.
        /// </summary>
        [DataMember(Name = "type", Order = 5)]
        public string TypeName { get; set; }

        /// <summary>
        /// Gets or sets the default floor.
        /// </summary>
        [DataMember(Name = "default_floor", Order = 4)]
        public int DefaultFloor { get; set; }

        /// <summary>
        /// Gets or sets the floors.
        /// </summary>
        [DataMember(Name = "floors", Order = 6)]
        public int[] Floors { get; set; }

        /// <summary>
        /// Gets or sets the region id.
        /// </summary>
        [DataMember(Name = "region_id", Order = 7)]
        public int RegionId { get; set; }

        /// <summary>
        /// Gets or sets the region name.
        /// </summary>
        [DataMember(Name = "region_name", Order = 8)]
        public string RegionName { get; set; }

        /// <summary>
        /// Gets or sets the continent id.
        /// </summary>
        [DataMember(Name = "continent_id", Order = 9)]
        public int ContinentId { get; set; }

        /// <summary>
        /// Gets or sets the continent name.
        /// </summary>
        [DataMember(Name = "continent_name", Order = 10)]
        public string ContinentName { get; set; }

        /// <summary>
        /// Gets or sets the map rectangle.
        /// </summary>
        [DataMember(Name = "map_rect", Order = 11)]
        public double[][] MapRectangle { get; set; }

        /// <summary>
        /// Gets or sets the continent rectangle.
        /// </summary>
        [DataMember(Name = "continent_rect", Order = 12)]
        public double[][] ContinentRectangle { get; set; }
    }
}
