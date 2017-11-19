// <copyright file="DetailsDTO.cs" company="GW2.NET Coding Team">
// This product is licensed under the GNU General Public License version 2 (GPLv2). See the License in the project root folder or the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>

namespace GW2NET.V2.Skins.Json
{
    using System.Runtime.Serialization;

    /// <summary>Defines the <see cref="DetailsDTO"/> type.</summary>
    /// <content> Contains data contract properties for all skins.</content>
    [DataContract]
    public sealed partial class DetailsDTO
    {
        /// <summary>Gets or sets the type.</summary>
        [DataMember(Name = "type", Order = 0)]
        public string Type { get; set; }
    }

    /// <summary>Defines the <see cref="DetailsDTO"/> type.</summary>
    /// <content> Contains data contract properties for all armors.</content>
    public sealed partial class DetailsDTO
    {
        /// <summary>Gets or sets the weight class.</summary>
        [DataMember(Name = "weight_class", Order = 1)]
        public string WeightClass { get; set; }
    }

    /// <summary>Defines the <see cref="DetailsDTO"/> type.</summary>
    /// <content> Contains data contract properties for all weapons.</content>
    public sealed partial class DetailsDTO
    {
        /// <summary>Gets or sets the damage class.</summary>
        [DataMember(Name = "damage_type", Order = 1)]
        public string DamageClass { get; set; }
    }
}
