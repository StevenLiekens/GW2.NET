// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FileDTO.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2). See the License in the project root folder or the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Defines the FileDTO type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GW2NET.V1.Files.Json
{
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.Serialization;

    [DataContract]
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented", Justification = "http://wiki.guildwars2.com/wiki/API:1/files")]
    public sealed class FileDTO
    {
        [DataMember(Name = "file_id", Order = 0)]
        public int FileId { get; set; }

        [DataMember(Name = "signature", Order = 1)]
        public string Signature { get; set; }
    }
}
