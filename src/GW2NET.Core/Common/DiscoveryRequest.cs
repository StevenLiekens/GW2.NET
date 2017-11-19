// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DiscoveryRequest.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2). See the License in the project root folder or the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Provides the base class for discovery requests.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2NET.Common
{
    using System.Collections.Generic;

    /// <summary>Provides the base class for discovery requests.</summary>
    public abstract class DiscoveryRequest : IRequest
    {
        /// <summary>Gets the resource path.</summary>
        public abstract string Resource { get; }

        /// <summary>Gets the request parameters.</summary>
        /// <returns>A collection of parameters.</returns>
        public virtual IEnumerable<KeyValuePair<string, string>> GetParameters()
        {
            yield break;
        }
    }
}
