﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ServiceClient.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Provides a RestSharp-specific implementation of the <see cref="IServiceClient" /> interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2DotNET.RestSharp
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    using GW2DotNET.Common;
    using GW2DotNET.Common.Serializers;

    using global::RestSharp;

    /// <summary>Provides a RestSharp-specific implementation of the <see cref="IServiceClient" /> interface.</summary>
    public class ServiceClient : IServiceClient
    {
        /// <summary>Infrastructure. Holds a reference to the inner <see cref="IRestClient" />.</summary>
        private readonly IRestClient restClient;

        /// <summary>Initializes a new instance of the <see cref="ServiceClient"/> class.</summary>
        /// <param name="baseUri">The base URI.</param>
        public ServiceClient(Uri baseUri)
        {
            Contract.Requires(baseUri != null);
            Contract.Requires(baseUri.IsAbsoluteUri, "Parameter 'baseUri' must be an absolute URI.");
            this.restClient = new RestClient(baseUri.ToString());
        }

        /// <summary>Initializes a new instance of the <see cref="ServiceClient"/> class.</summary>
        /// <param name="restClient">The <see cref="IRestClient"/>.</param>
        public ServiceClient(IRestClient restClient)
        {
            Contract.Requires(restClient != null);
            this.restClient = restClient;
        }

        /// <summary>Sends a request and returns the response.</summary>
        /// <param name="request">The service request.</param>
        /// <param name="serializer">The serialization engine.</param>
        /// <typeparam name="TResult">The type of the response content.</typeparam>
        /// <returns>An instance of the specified type.</returns>
        public IResponse<TResult> Send<TResult>(IRequest request, ISerializer<TResult> serializer)
        {
            var restRequest = new RestRequest(request.Resource);

            // Translate the request to form data
            foreach (var parameter in request.GetParameters())
            {
                restRequest.AddParameter(parameter.Key, parameter.Value);
            }

            // Handle the request
            var restResponse = GetRestResponse(this.restClient, restRequest);
            return PostProcess(restResponse, serializer);
        }

        /// <summary>Sends a request and returns the response.</summary>
        /// <param name="request">The service request.</param>
        /// <param name="serializer">The serialization engine.</param>
        /// <typeparam name="TResult">The type of the response content.</typeparam>
        /// <returns>An instance of the specified type.</returns>
        public Task<IResponse<TResult>> SendAsync<TResult>(IRequest request, ISerializer<TResult> serializer)
        {
            return this.SendAsync(request, serializer, CancellationToken.None);
        }

        /// <summary>Sends a request and returns the response.</summary>
        /// <param name="request">The service request.</param>
        /// <param name="serializer">The serialization engine.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> that provides cancellation support.</param>
        /// <typeparam name="TResult">The type of the response content.</typeparam>
        /// <returns>An instance of the specified type.</returns>
        public Task<IResponse<TResult>> SendAsync<TResult>(IRequest request, ISerializer<TResult> serializer, CancellationToken cancellationToken)
        {
            var restRequest = new RestRequest(request.Resource);

            // Translate the request to form data
            foreach (var parameter in request.GetParameters())
            {
                restRequest.AddParameter(parameter.Key, parameter.Value);
            }

            // Handle the request
            return GetRestResponseAsync(this.restClient, restRequest, cancellationToken).ContinueWith<IResponse<TResult>>(
                task =>
                    {
                        var restResponse = task.Result;
                        return PostProcess(restResponse, serializer);
                    }, 
                cancellationToken);
        }

        /// <summary>Infrastructure. Deserializes the response stream.</summary>
        /// <param name="serializer">The serialization engine.</param>
        /// <param name="response">The response.</param>
        /// <typeparam name="TResult">The type of the response content.</typeparam>
        /// <returns>An instance of the specified type.</returns>
        private static TResult DeserializeResponse<TResult>(ISerializer<TResult> serializer, IRestResponse response)
        {
            // Deserialize the response content
            return serializer.Deserialize(new MemoryStream(response.RawBytes));
        }

        /// <summary>Infrastructure. Sends a web request and gets the response.</summary>
        /// <param name="restClient">The <see cref="IRestClient"/>.</param>
        /// <param name="request">The <see cref="IRestRequest"/>.</param>
        /// <returns>The <see cref="IRestResponse"/>.</returns>
        /// <exception cref="ServiceException">The exception that is thrown when an API error occurs.</exception>
        private static IRestResponse GetRestResponse(IRestClient restClient, IRestRequest request)
        {
            var response = restClient.Execute(request);

            if (response.StatusCode.IsSuccessStatusCode())
            {
                return response;
            }

            // Simply rethrow in case of transport errors (e.g. timeout)
            if (response.ResponseStatus == ResponseStatus.Error)
            {
                throw response.ErrorException;
            }

            // Wrap protocol exceptions in a ServiceException, then throw
            var errorResult = new JsonSerializer<ErrorResult>().Deserialize(new MemoryStream(response.RawBytes));
            throw new ServiceException(errorResult.Text);
        }

        /// <summary>Infrastructure. Sends a web request and gets the response.</summary>
        /// <param name="restClient">The <see cref="IRestClient"/>.</param>
        /// <param name="request">The <see cref="IRestRequest"/>.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> that provides cancellation support.</param>
        /// <returns>The <see cref="IRestResponse"/>.</returns>
        /// <exception cref="ServiceException">The exception that is thrown when an API error occurs.</exception>
        private static Task<IRestResponse> GetRestResponseAsync(IRestClient restClient, IRestRequest request, CancellationToken cancellationToken)
        {
            return restClient.ExecuteTaskAsync(request, cancellationToken).ContinueWith(
                task =>
                    {
                        var response = task.Result;

                        if (response.StatusCode.IsSuccessStatusCode())
                        {
                            return response;
                        }

                        // Simply rethrow in case of transport errors (e.g. timeout)
                        if (response.ResponseStatus == ResponseStatus.Error)
                        {
                            throw response.ErrorException;
                        }

                        // Wrap protocol exceptions in a ServiceException, then throw
                        var errorResult = new JsonSerializer<ErrorResult>().Deserialize(new MemoryStream(response.RawBytes));
                        throw new ServiceException(errorResult.Text);
                    }, 
                cancellationToken);
        }

        /// <summary>Infrastructure. Post-processes a response object.</summary>
        /// <param name="response">The raw response.</param>
        /// <param name="serializer">The response content serializer.</param>
        /// <typeparam name="T">The type of the response content.</typeparam>
        /// <returns>A processed response object.</returns>
        private static IResponse<T> PostProcess<T>(IRestResponse response, ISerializer<T> serializer)
        {
            Contract.Requires(response != null);
            Contract.Requires(serializer != null);
            Contract.Ensures(Contract.Result<IResponse<T>>() != null);

            // Create a new generic response object
            var value = new Response<T>();

            // Set the deserialized response content
            value.Content = DeserializeResponse(serializer, response);

            // Set the 'Date' header
            var date = response.Headers.SingleOrDefault(parameter => parameter.Name.Equals("Date", StringComparison.Ordinal));
            if (date != null)
            {
                value.LastModified = DateTime.Parse((string)date.Value);
            }

            // Set the 'Content-Language' header
            var culture = response.Headers.SingleOrDefault(parameter => parameter.Name.Equals("Content-Language", StringComparison.Ordinal));
            if (culture != null)
            {
                value.Culture = CultureInfo.GetCultureInfo((string)culture.Value);
            }

            // Set the 'X'-tension headers
            foreach (var parameter in response.Headers.Where(parameter => parameter.Name.StartsWith("X-", StringComparison.Ordinal)))
            {
                value.ExtensionData[parameter.Name] = (string)parameter.Value;
            }

            // Return the response object
            return value;
        }
    }
}