﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WeaponDetails.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents detailed information about a weapon.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2DotNET.V1.Items.Details.Contracts.ItemTypes.Weapons
{
    using System.Runtime.Serialization;

    using GW2DotNET.V1.Items.Details.Contracts.ItemTypes.Common;

    using Newtonsoft.Json;

    /// <summary>Represents detailed information about a weapon.</summary>
    [JsonConverter(typeof(WeaponDetailsConverter))]
    public abstract class WeaponDetails : EquipmentDetails
    {
        /// <summary>Initializes a new instance of the <see cref="WeaponDetails"/> class.</summary>
        /// <param name="weaponType">The weapon's type.</param>
        protected WeaponDetails(WeaponType weaponType)
        {
            this.Type = weaponType;
        }

        /// <summary>Gets or sets the weapon's damage type.</summary>
        [DataMember(Name = "damage_type", Order = 101)]
        public virtual WeaponDamageType DamageType { get; set; }

        /// <summary>Gets or sets the weapon's defense.</summary>
        [DataMember(Name = "defense", Order = 104)]
        public virtual int Defense { get; set; }

        /// <summary>Gets or sets the weapon's maximum power.</summary>
        [DataMember(Name = "max_power", Order = 103)]
        public virtual int MaximumPower { get; set; }

        /// <summary>Gets or sets the weapon's minimum power.</summary>
        [DataMember(Name = "min_power", Order = 102)]
        public virtual int MinimumPower { get; set; }

        /// <summary>Gets or sets the weapon's type.</summary>
        [DataMember(Name = "type", Order = 100)]
        protected WeaponType Type { get; set; }
    }
}