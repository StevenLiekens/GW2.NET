// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IObjectiveNameRepository.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2). See the License in the project root folder or the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Provides the interface for repositories that provide localized objective details.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2NET.WorldVersusWorld
{
    using GW2NET.Common;

    /// <summary>Provides the interface for repositories that provide localized objective details.</summary>
    public interface IObjectiveRepository : IRepository<string, Objective>, ILocalizable
    {
    }
}
