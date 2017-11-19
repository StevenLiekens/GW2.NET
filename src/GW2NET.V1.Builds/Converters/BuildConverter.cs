// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BuildConverter.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2). See the License in the project root folder or the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Converts objects of type <see cref="BuildDTO" /> to objects of type <see cref="Build" />.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GW2NET.V1.Builds.Converters
{
    using System;
    using GW2NET.Builds;
    using GW2NET.Common;
    using GW2NET.V1.Builds.Json;

    /// <summary>Converts objects of type <see cref="BuildDTO"/> to objects of type <see cref="Build"/>.</summary>
    public sealed class BuildConverter : IConverter<BuildDTO, Build>
    {
        /// <inheritdoc />
        public Build Convert(BuildDTO value, object state)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            if (state == null)
            {
                throw new ArgumentNullException("state", "Precondition: state is IResponse<BuildDTO>");
            }

            var response = state as IResponse;
            if (response == null)
            {
                throw new ArgumentException("Precondition: state is IResponse", "state");
            }

            return new Build
            {
                BuildId = value.BuildId,
                Timestamp = response.Date
            };
        }
    }
}
