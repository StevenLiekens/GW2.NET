﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConverterForContentUnlocker.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Converts objects of type <see cref="ConsumableDataContract" /> to objects of type <see cref="ContentUnlocker" />.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2NET.V1.Items
{
    using System.Diagnostics.Contracts;

    using GW2NET.Common;
    using GW2NET.Items;

    /// <summary>Converts objects of type <see cref="ConsumableDataContract"/> to objects of type <see cref="ContentUnlocker"/>.</summary>
    internal sealed class ConverterForContentUnlocker : IConverter<ConsumableDataContract, ContentUnlocker>
    {
        /// <summary>Converts the given object of type <see cref="ConsumableDataContract"/> to an object of type <see cref="ContentUnlocker"/>.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value.</returns>
        public ContentUnlocker Convert(ConsumableDataContract value)
        {
            Contract.Assume(value != null);
            return new ContentUnlocker();
        }
    }
}