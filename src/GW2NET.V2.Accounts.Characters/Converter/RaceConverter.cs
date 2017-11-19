// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RaceConverter.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2). See the License in the project root folder or the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Converts the string representation of a race into the appropriate <see cref="Race" /> enumeration.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GW2NET.V2.Accounts.Characters.Converter
{
    using System;
    using System.Diagnostics;
    using GW2NET.Common;

    /// <summary>Converts the string representation of a race into the appropriate <see cref="Race"/> enumeration.</summary>
    public sealed class RaceConverter : IConverter<string, Race>
    {
        /// <inheritdoc />
        public Race Convert(string value, object state)
        {
            Race gender;
            if (Enum.TryParse(value, out gender))
            {
                return gender;
            }

            Debug.Assert(false, "Unknown Race: " + value);
            return Race.Unknown;
        }
    }
}
