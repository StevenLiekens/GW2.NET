// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FileDTO.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2). See the License in the project root folder or the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Defines the FileDTO type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GW2NET.V2.Files.Json
{
    using System.Runtime.Serialization;

    /// <summary>Represents the file data from the GW2 api.</summary>
    [DataContract]
    public sealed class FileDTO
    {
        /// <summary>Gets or sets the id.</summary>
        [DataMember(Name = "id", Order = 0)]
        public string Id { get; set; }

        /// <summary>Gets or sets the icon url.</summary>
        [DataMember(Name = "icon", Order = 1)]
        public string Icon { get; set; }
    }
}
