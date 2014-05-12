﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EquipmentDetails.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Provides the base class for types that provide detailed information about equipment.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2DotNET.V1.Items.Details.Contracts.ItemTypes.Common
{
    using System.Runtime.Serialization;

    /// <summary>Provides the base class for types that provide detailed information about equipment.</summary>
    public abstract class EquipmentDetails : ItemDetails
    {
        /// <summary>Gets or sets the item's infix upgrade.</summary>
        [DataMember(Name = "infix_upgrade", Order = 10001)]
        public virtual InfixUpgrade InfixUpgrade { get; set; }

        /// <summary>Gets or sets the item's infusion slots.</summary>
        [DataMember(Name = "infusion_slots", Order = 10000)]
        public virtual InfusionSlotCollection InfusionSlots { get; set; }

        /// <summary>Gets or sets the item's secondary suffix item's ID.</summary>
        [DataMember(Name = "secondary_suffix_item_id", Order = 10003)]
        public virtual int? SecondarySuffixItemId { get; set; }

        /// <summary>Gets or sets the item's suffix item's ID.</summary>
        [DataMember(Name = "suffix_item_id", Order = 10002)]
        public virtual int? SuffixItemId { get; set; }
    }
}