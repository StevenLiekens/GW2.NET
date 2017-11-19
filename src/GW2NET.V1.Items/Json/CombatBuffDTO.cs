// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CombatBuffDTO.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2). See the License in the project root folder or the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Defines the CombatBuffDTO type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GW2NET.V1.Items.Json
{
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.Serialization;

    [DataContract]
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented", Justification = "http://wiki.guildwars2.com/wiki/API:1/item_details")]
    public sealed class CombatBuffDTO
    {
        [DataMember(Name = "skill_id", Order = 0)]
        public string SkillId { get; set; }

        [DataMember(Name = "description", Order = 1)]
        public string Description { get; set; }
    }
}
