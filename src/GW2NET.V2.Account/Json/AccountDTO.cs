// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AccountDTO.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2). See the License in the project root folder or the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents the response from the /v2/account api endpoint.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GW2NET.V2.Accounts.Json
{
    using System;

    /// <summary>Represents the response from the /v2/account api endpoint.</summary>
    public sealed class AccountDTO
    {
        /// <summary>Gets or sets the accounts id.</summary>
        public Guid Id { get; set; }

        /// <summary>Gets or sets the name.</summary>
        public string Name { get; set; }

        /// <summary>Gets or sets the world the account is assigned to.</summary>
        public int World { get; set; }

        /// <summary>Gets or sets the guild ids the character is in.</summary>
        public Guid[] Guilds { get; set; }
    }
}
