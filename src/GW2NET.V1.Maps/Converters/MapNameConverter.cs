// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MapNameConverter.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2). See the License in the project root folder or the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Converts objects of type <see cref="MapNameDTO" /> to objects of type <see cref="MapName" />.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GW2NET.V1.Maps.Converters
{
    using System;

    using GW2NET.Common;
    using GW2NET.Maps;
    using GW2NET.V1.Maps.Json;

    /// <summary>Converts objects of type <see cref="MapNameDTO"/> to objects of type <see cref="MapName"/>.</summary>
    public sealed class MapNameConverter : IConverter<MapNameDTO, MapName>
    {
        /// <inheritdoc />
        public MapName Convert(MapNameDTO value, object state)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            var mapName = new MapName
            {
                Name = value.Name
            };
            int id;
            if (int.TryParse(value.Id, out id))
            {
                mapName.MapId = id;
            }

            return mapName;
        }
    }
}
