﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MatchDiscoveryServiceContract.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   The match discovery service contract.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2DotNET.V1.WorldVersusWorld
{
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Threading;
    using System.Threading.Tasks;

    using GW2DotNET.Entities.WorldVersusWorld;

    /// <summary>The match discovery service contract.</summary>
    [ContractClassFor(typeof(IMatchDiscoveryService))]
    internal abstract class MatchDiscoveryServiceContract : IMatchDiscoveryService
    {
        /// <summary>Gets a collection of currently running World versus World matches.</summary>
        /// <returns>A collection of currently running World versus World matches.</returns>
        /// <remarks>See <a href="http://wiki.guildwars2.com/wiki/API:1/wvw/matches">wiki</a> for more information.</remarks>
        public IDictionary<string, Matchup> GetMatches()
        {
            Contract.Ensures(Contract.Result<IDictionary<string, Matchup>>() != null);
            throw new System.NotImplementedException();
        }

        /// <summary>Gets a collection of currently running World versus World matches.</summary>
        /// <returns>A collection of currently running World versus World matches.</returns>
        /// <remarks>See <a href="http://wiki.guildwars2.com/wiki/API:1/wvw/matches">wiki</a> for more information.</remarks>
        public Task<IDictionary<string, Matchup>> GetMatchesAsync()
        {
            Contract.Ensures(Contract.Result<Task<IDictionary<string, Matchup>>>() != null);
            Contract.Ensures(Contract.Result<Task<IDictionary<string, Matchup>>>().Result != null);
            throw new System.NotImplementedException();
        }

        /// <summary>Gets a collection of currently running World versus World matches.</summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> that provides cancellation support.</param>
        /// <returns>A collection of currently running World versus World matches.</returns>
        /// <remarks>See <a href="http://wiki.guildwars2.com/wiki/API:1/wvw/matches">wiki</a> for more information.</remarks>
        public Task<IDictionary<string, Matchup>> GetMatchesAsync(CancellationToken cancellationToken)
        {
            Contract.Ensures(Contract.Result<Task<IDictionary<string, Matchup>>>() != null);
            Contract.Ensures(Contract.Result<Task<IDictionary<string, Matchup>>>().Result != null);
            throw new System.NotImplementedException();
        }
    }
}