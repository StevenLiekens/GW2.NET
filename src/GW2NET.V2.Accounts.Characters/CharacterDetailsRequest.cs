// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CharacterDetailsRequest.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2). See the License in the project root folder or the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents a details request that targets the /v2/characters interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GW2NET.V2.Accounts.Characters
{
    using System.Collections.Generic;
    using System.Globalization;

    using GW2NET.Common;

    /// <summary>Represents a details request that targets the /v2/characters interface.</summary>
    public sealed class CharacterDetailsRequest : DetailsRequest, ILocalizable
    {
        /// <summary>Gets the resource path.</summary>
        public override string Resource
        {
            get
            {
                return "/v2/characters";
            }
        }

        /// <summary>Gets or sets the locale.</summary>
        public CultureInfo Culture { get; set; }

        protected override IEnumerable<KeyValuePair<string, string>> GetParameters(string id)
        {
            var culture = this.Culture;
            if (culture != null)
            {
                yield return new KeyValuePair<string, string>("lang", culture.TwoLetterISOLanguageName);
            }
        }
    }
}
