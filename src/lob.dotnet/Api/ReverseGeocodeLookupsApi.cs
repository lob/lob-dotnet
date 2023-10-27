/*
 * Lob
 *
 * The Lob API is organized around REST. Our API is designed to have predictable, resource-oriented URLs and uses HTTP response codes to indicate any API errors. <p> Looking for our [previous documentation](https://lob.github.io/legacy-docs/)? 
 *
 * The version of the OpenAPI document: 1.3.0
 * Contact: lob-openapi@lob.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using lob.dotnet.Client;
using System.Runtime.Serialization;
using lob.dotnet.Model;

namespace lob.dotnet.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IReverseGeocodeLookupsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// lookup
        /// </summary>
        /// <remarks>
        /// Reverse geocode a valid US location with a live API key.
        /// </remarks>
        /// <exception cref="lob.dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="location"></param>
        /// <param name="size">Determines the number of locations returned. Possible values are between 1 and 50 and any number higher will be rounded down to 50. Default size is a list of 5 reverse geocoded locations. (optional, default to 5)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ReverseGeocode</returns>
        ReverseGeocode lookup(Location location, int? size = default(int?), int operationIndex = 0);

        /// <summary>
        /// lookup
        /// </summary>
        /// <remarks>
        /// Reverse geocode a valid US location with a live API key.
        /// </remarks>
        /// <exception cref="lob.dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="location"></param>
        /// <param name="size">Determines the number of locations returned. Possible values are between 1 and 50 and any number higher will be rounded down to 50. Default size is a list of 5 reverse geocoded locations. (optional, default to 5)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ReverseGeocode</returns>
        ApiResponse<ReverseGeocode> lookupWithHttpInfo(Location location, int? size = default(int?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IReverseGeocodeLookupsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// lookup
        /// </summary>
        /// <remarks>
        /// Reverse geocode a valid US location with a live API key.
        /// </remarks>
        /// <exception cref="lob.dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="location"></param>
        /// <param name="size">Determines the number of locations returned. Possible values are between 1 and 50 and any number higher will be rounded down to 50. Default size is a list of 5 reverse geocoded locations. (optional, default to 5)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ReverseGeocode</returns>
        System.Threading.Tasks.Task<ReverseGeocode> lookupAsync(Location location, int? size = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// lookup
        /// </summary>
        /// <remarks>
        /// Reverse geocode a valid US location with a live API key.
        /// </remarks>
        /// <exception cref="lob.dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="location"></param>
        /// <param name="size">Determines the number of locations returned. Possible values are between 1 and 50 and any number higher will be rounded down to 50. Default size is a list of 5 reverse geocoded locations. (optional, default to 5)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ReverseGeocode)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReverseGeocode>> lookupWithHttpInfoAsync(Location location, int? size = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IReverseGeocodeLookupsApi : IReverseGeocodeLookupsApiSync, IReverseGeocodeLookupsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ReverseGeocodeLookupsApi : IReverseGeocodeLookupsApi
    {
        private lob.dotnet.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReverseGeocodeLookupsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReverseGeocodeLookupsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReverseGeocodeLookupsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReverseGeocodeLookupsApi(string basePath)
        {
            this.Configuration = lob.dotnet.Client.Configuration.MergeConfigurations(
                lob.dotnet.Client.GlobalConfiguration.Instance,
                new lob.dotnet.Client.Configuration { BasePath = basePath }
            );
            this.Client = new lob.dotnet.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new lob.dotnet.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = lob.dotnet.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReverseGeocodeLookupsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ReverseGeocodeLookupsApi(lob.dotnet.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = lob.dotnet.Client.Configuration.MergeConfigurations(
                lob.dotnet.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new lob.dotnet.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new lob.dotnet.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = lob.dotnet.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReverseGeocodeLookupsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ReverseGeocodeLookupsApi(lob.dotnet.Client.ISynchronousClient client, lob.dotnet.Client.IAsynchronousClient asyncClient, lob.dotnet.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = lob.dotnet.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public lob.dotnet.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public lob.dotnet.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public lob.dotnet.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public lob.dotnet.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// lookup Reverse geocode a valid US location with a live API key.
        /// </summary>
        /// <exception cref="lob.dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="location"></param>
        /// <param name="size">Determines the number of locations returned. Possible values are between 1 and 50 and any number higher will be rounded down to 50. Default size is a list of 5 reverse geocoded locations. (optional, default to 5)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ReverseGeocode</returns>
        public ReverseGeocode lookup(Location location, int? size = default(int?), int operationIndex = 0)
        {
            lob.dotnet.Client.ApiResponse<ReverseGeocode> localVarResponse = lookupWithHttpInfo(location, size);
            return localVarResponse.Data;
        }

        /// <summary>
        /// lookup Reverse geocode a valid US location with a live API key.
        /// </summary>
        /// <exception cref="lob.dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="location"></param>
        /// <param name="size">Determines the number of locations returned. Possible values are between 1 and 50 and any number higher will be rounded down to 50. Default size is a list of 5 reverse geocoded locations. (optional, default to 5)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ReverseGeocode</returns>
        public lob.dotnet.Client.ApiResponse<ReverseGeocode> lookupWithHttpInfo(Location location, int? size = default(int?), int operationIndex = 0)
        {
            // verify the required parameter 'location' is set
            if (location == null)
            {
                throw new lob.dotnet.Client.ApiException(400, "Missing required parameter 'location' when calling ReverseGeocodeLookupsApi->lookup");
            }

            lob.dotnet.Client.RequestOptions localVarRequestOptions = new lob.dotnet.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json",
                "application/x-www-form-urlencoded",
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = lob.dotnet.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = lob.dotnet.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (size != null)
            {
                localVarRequestOptions.QueryParameters.Add(lob.dotnet.Client.ClientUtils.ParameterToMultiMap("", "size", size));
            }
            localVarRequestOptions.Data = location;

            localVarRequestOptions.Operation = "ReverseGeocodeLookupsApi.lookup";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + lob.dotnet.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<ReverseGeocode>("/us_reverse_geocode_lookups", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("lookup", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// lookup Reverse geocode a valid US location with a live API key.
        /// </summary>
        /// <exception cref="lob.dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="location"></param>
        /// <param name="size">Determines the number of locations returned. Possible values are between 1 and 50 and any number higher will be rounded down to 50. Default size is a list of 5 reverse geocoded locations. (optional, default to 5)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ReverseGeocode</returns>
        public async System.Threading.Tasks.Task<ReverseGeocode> lookupAsync(Location location, int? size = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            lob.dotnet.Client.ApiResponse<ReverseGeocode> localVarResponse = await lookupWithHttpInfoAsync(location, size, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// lookup Reverse geocode a valid US location with a live API key.
        /// </summary>
        /// <exception cref="lob.dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="location"></param>
        /// <param name="size">Determines the number of locations returned. Possible values are between 1 and 50 and any number higher will be rounded down to 50. Default size is a list of 5 reverse geocoded locations. (optional, default to 5)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ReverseGeocode)</returns>
        public async System.Threading.Tasks.Task<lob.dotnet.Client.ApiResponse<ReverseGeocode>> lookupWithHttpInfoAsync(Location location, int? size = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'location' is set
            if (location == null)
            {
                throw new lob.dotnet.Client.ApiException(400, "Missing required parameter 'location' when calling ReverseGeocodeLookupsApi->lookup");
            }


            lob.dotnet.Client.RequestOptions localVarRequestOptions = new lob.dotnet.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json", 
                "application/x-www-form-urlencoded", 
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = lob.dotnet.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = lob.dotnet.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (size != null)
            {
                localVarRequestOptions.QueryParameters.Add(lob.dotnet.Client.ClientUtils.ParameterToMultiMap("", "size", size));
            }
            localVarRequestOptions.Data = location;

            localVarRequestOptions.Operation = "ReverseGeocodeLookupsApi.lookup";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + lob.dotnet.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<ReverseGeocode>("/us_reverse_geocode_lookups", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("lookup", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
