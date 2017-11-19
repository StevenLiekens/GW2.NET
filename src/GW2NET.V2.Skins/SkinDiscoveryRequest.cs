// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SkinDiscoveryRequest.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2). See the License in the project root folder or the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents a discovery request that targets the /v2/skins interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GW2NET.V2.Skins
{
    using GW2NET.Common;

    /// <summary>Represents a discovery request that targets the /v2/skins interface.</summary>
    public sealed class SkinDiscoveryRequest : DiscoveryRequest
    {
        /// <summary>Gets the resource path.</summary>
        public override string Resource
        {
            get
            {
                return "/v2/skins";
            }
        }
    }
}
