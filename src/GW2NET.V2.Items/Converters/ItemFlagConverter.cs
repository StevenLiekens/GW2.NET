// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ItemFlagConverter.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2). See the License in the project root folder or the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Converts objects of type <see cref="string" /> to objects of type <see cref="ItemFlags" />.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Diagnostics;

namespace GW2NET.V2.Items.Converters
{
    using System;

    using GW2NET.Common;
    using GW2NET.Items;

    /// <summary>Converts objects of type <see cref="string" /> to objects of type <see cref="ItemFlags" />.</summary>
    public sealed class ItemFlagConverter : IConverter<string, ItemFlags>
    {
        /// <summary>Converts the given object of type <see cref="string" /> to an object of type <see cref="ItemFlags" />.</summary>
        /// <param name="value">The value to convert.</param>
        /// <param name="state"></param>
        /// <returns>The converted value.</returns>
        public ItemFlags Convert(string value, object state)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            ItemFlags result;
            if (Enum.TryParse(value, true, out result))
            {
                return result;
            }

            Debug.Assert(false, "Unknown ItemFlags: " + value);
            return default(ItemFlags);
        }
    }
}
