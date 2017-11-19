// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MapRequest.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2). See the License in the project root folder or the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents a request for details regarding maps in the game.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2NET.V1.Maps
{
    using System.Collections.Generic;
    using System.Globalization;

    using GW2NET.Common;

    /// <summary>Represents a request for details regarding maps in the game.</summary>
    public sealed class MapRequest : IRequest, ILocalizable
    {
        /// <summary>Gets or sets the locale.</summary>
        public CultureInfo Culture { get; set; }

        /// <summary>Gets or sets the map identifier.</summary>
        public int? MapId { get; set; }

        /// <summary>Gets the resource path.</summary>
        public string Resource
        {
            get
            {
                return "v1/maps.json";
            }
        }

        /// <summary>Gets the request parameters.</summary>
        /// <returns>A collection of parameters.</returns>
        public IEnumerable<KeyValuePair<string, string>> GetParameters()
        {
            // Get the 'map_id' parameter
            if (this.MapId.HasValue)
            {
                yield return new KeyValuePair<string, string>("map_id", this.MapId.Value.ToString(NumberFormatInfo.InvariantInfo));
            }

            // Get the 'lang' parameter
            if (this.Culture != null)
            {
                yield return new KeyValuePair<string, string>("lang", this.Culture.TwoLetterISOLanguageName);
            }
        }
    }
}
