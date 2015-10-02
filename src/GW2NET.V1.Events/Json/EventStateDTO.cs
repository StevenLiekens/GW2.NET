﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EventStateDTO.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Defines the EventStateDTO type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace GW2NET.V1.Events.Json
{
    [DataContract]
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented", Justification = "http://wiki.guildwars2.com/wiki/API:1/events")]
    public sealed class EventStateDTO
    {
        [DataMember(Name = "world_id", Order = 0)]
        public int WorldId { get; set; }

        [DataMember(Name = "map_id", Order = 1)]
        public int MapId { get; set; }

        [DataMember(Name = "event_id", Order = 2)]
        public string EventId { get; set; }

        [DataMember(Name = "state", Order = 3)]
        public string State { get; set; }
    }
}