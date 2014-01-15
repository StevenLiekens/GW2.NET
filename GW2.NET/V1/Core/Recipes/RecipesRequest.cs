﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RecipesRequest.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GW2DotNET.V1.Core.Recipes
{
    /// <summary>
    /// Represents a request for a list of all discovered recipes.
    /// </summary>
    /// <remarks>
    /// See <a href="http://wiki.guildwars2.com/wiki/API:1/recipes"/> for more information.
    /// </remarks>
    public class RecipesRequest : ApiRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecipesRequest"/> class.
        /// </summary>
        public RecipesRequest()
            : base(new Uri(Resources.Recipes, UriKind.Relative))
        {
        }

        /// <summary>
        /// Sends this request to the specified <see cref="ApiClient"/> and retrieves a response whose content is of type <see cref="RecipesResponse"/>.
        /// </summary>
        /// <param name="handler">The <see cref="ApiClient"/> that sends the request over a network and returns an instance of type <see cref="ApiResponse{TContent}"/>.</param>
        /// <returns>Returns an instance of type <see cref="RecipesResponse"/>.</returns>
        public IApiResponse<RecipesResponse> GetResponse(IApiClient handler)
        {
            return base.GetResponse<RecipesResponse>(handler);
        }

        /// <summary>
        /// Asynchronously sends this request to the specified <see cref="ApiClient"/> and retrieves a response whose content is of type <see cref="RecipesResponse"/>.
        /// </summary>
        /// <param name="handler">The <see cref="ApiClient"/> that sends the request over a network and returns an instance of type <see cref="ApiResponse{TContent}"/>.</param>
        /// <returns>Returns an instance of type <see cref="RecipesResponse"/>.</returns>
        public Task<IApiResponse<RecipesResponse>> GetResponseAsync(IApiClient handler)
        {
            return base.GetResponseAsync<RecipesResponse>(handler);
        }
    }
}