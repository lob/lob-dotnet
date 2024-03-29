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
    public interface ICardOrdersApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// create
        /// </summary>
        /// <remarks>
        /// Creates a new card order given information
        /// </remarks>
        /// <exception cref="lob.dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cardId">The ID of the card to which the card orders belong.</param>
        /// <param name="cardOrderEditable"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CardOrder</returns>
        CardOrder create(string cardId, CardOrderEditable cardOrderEditable, int operationIndex = 0);

        /// <summary>
        /// create
        /// </summary>
        /// <remarks>
        /// Creates a new card order given information
        /// </remarks>
        /// <exception cref="lob.dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cardId">The ID of the card to which the card orders belong.</param>
        /// <param name="cardOrderEditable"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CardOrder</returns>
        ApiResponse<CardOrder> createWithHttpInfo(string cardId, CardOrderEditable cardOrderEditable, int operationIndex = 0);
        /// <summary>
        /// get
        /// </summary>
        /// <remarks>
        /// Retrieves the card orders associated with the given card id.
        /// </remarks>
        /// <exception cref="lob.dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cardId">The ID of the card to which the card orders belong.</param>
        /// <param name="limit">How many results to return. (optional, default to 10)</param>
        /// <param name="offset">An integer that designates the offset at which to begin returning results. Defaults to 0. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CardOrderList</returns>
        CardOrderList get(string cardId, int? limit = default(int?), int? offset = default(int?), int operationIndex = 0);

        /// <summary>
        /// get
        /// </summary>
        /// <remarks>
        /// Retrieves the card orders associated with the given card id.
        /// </remarks>
        /// <exception cref="lob.dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cardId">The ID of the card to which the card orders belong.</param>
        /// <param name="limit">How many results to return. (optional, default to 10)</param>
        /// <param name="offset">An integer that designates the offset at which to begin returning results. Defaults to 0. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CardOrderList</returns>
        ApiResponse<CardOrderList> getWithHttpInfo(string cardId, int? limit = default(int?), int? offset = default(int?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICardOrdersApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// create
        /// </summary>
        /// <remarks>
        /// Creates a new card order given information
        /// </remarks>
        /// <exception cref="lob.dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cardId">The ID of the card to which the card orders belong.</param>
        /// <param name="cardOrderEditable"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CardOrder</returns>
        System.Threading.Tasks.Task<CardOrder> createAsync(string cardId, CardOrderEditable cardOrderEditable, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// create
        /// </summary>
        /// <remarks>
        /// Creates a new card order given information
        /// </remarks>
        /// <exception cref="lob.dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cardId">The ID of the card to which the card orders belong.</param>
        /// <param name="cardOrderEditable"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CardOrder)</returns>
        System.Threading.Tasks.Task<ApiResponse<CardOrder>> createWithHttpInfoAsync(string cardId, CardOrderEditable cardOrderEditable, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// get
        /// </summary>
        /// <remarks>
        /// Retrieves the card orders associated with the given card id.
        /// </remarks>
        /// <exception cref="lob.dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cardId">The ID of the card to which the card orders belong.</param>
        /// <param name="limit">How many results to return. (optional, default to 10)</param>
        /// <param name="offset">An integer that designates the offset at which to begin returning results. Defaults to 0. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CardOrderList</returns>
        System.Threading.Tasks.Task<CardOrderList> getAsync(string cardId, int? limit = default(int?), int? offset = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get
        /// </summary>
        /// <remarks>
        /// Retrieves the card orders associated with the given card id.
        /// </remarks>
        /// <exception cref="lob.dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cardId">The ID of the card to which the card orders belong.</param>
        /// <param name="limit">How many results to return. (optional, default to 10)</param>
        /// <param name="offset">An integer that designates the offset at which to begin returning results. Defaults to 0. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CardOrderList)</returns>
        System.Threading.Tasks.Task<ApiResponse<CardOrderList>> getWithHttpInfoAsync(string cardId, int? limit = default(int?), int? offset = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICardOrdersApi : ICardOrdersApiSync, ICardOrdersApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CardOrdersApi : ICardOrdersApi
    {
        private lob.dotnet.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CardOrdersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CardOrdersApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardOrdersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CardOrdersApi(string basePath)
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
        /// Initializes a new instance of the <see cref="CardOrdersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CardOrdersApi(lob.dotnet.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="CardOrdersApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public CardOrdersApi(lob.dotnet.Client.ISynchronousClient client, lob.dotnet.Client.IAsynchronousClient asyncClient, lob.dotnet.Client.IReadableConfiguration configuration)
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
        /// create Creates a new card order given information
        /// </summary>
        /// <exception cref="lob.dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cardId">The ID of the card to which the card orders belong.</param>
        /// <param name="cardOrderEditable"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CardOrder</returns>
        public CardOrder create(string cardId, CardOrderEditable cardOrderEditable, int operationIndex = 0)
        {
            lob.dotnet.Client.ApiResponse<CardOrder> localVarResponse = createWithHttpInfo(cardId, cardOrderEditable);
            return localVarResponse.Data;
        }

        /// <summary>
        /// create Creates a new card order given information
        /// </summary>
        /// <exception cref="lob.dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cardId">The ID of the card to which the card orders belong.</param>
        /// <param name="cardOrderEditable"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CardOrder</returns>
        public lob.dotnet.Client.ApiResponse<CardOrder> createWithHttpInfo(string cardId, CardOrderEditable cardOrderEditable, int operationIndex = 0)
        {
            // verify the required parameter 'cardId' is set
            if (cardId == null)
            {
                throw new lob.dotnet.Client.ApiException(400, "Missing required parameter 'cardId' when calling CardOrdersApi->create");
            }

            // verify the required parameter 'cardOrderEditable' is set
            if (cardOrderEditable == null)
            {
                throw new lob.dotnet.Client.ApiException(400, "Missing required parameter 'cardOrderEditable' when calling CardOrdersApi->create");
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

            localVarRequestOptions.PathParameters.Add("card_id", lob.dotnet.Client.ClientUtils.ParameterToString(cardId)); // path parameter
            localVarRequestOptions.Data = cardOrderEditable;

            localVarRequestOptions.Operation = "CardOrdersApi.create";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + lob.dotnet.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<CardOrder>("/cards/{card_id}/orders", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("create", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// create Creates a new card order given information
        /// </summary>
        /// <exception cref="lob.dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cardId">The ID of the card to which the card orders belong.</param>
        /// <param name="cardOrderEditable"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CardOrder</returns>
        public async System.Threading.Tasks.Task<CardOrder> createAsync(string cardId, CardOrderEditable cardOrderEditable, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            lob.dotnet.Client.ApiResponse<CardOrder> localVarResponse = await createWithHttpInfoAsync(cardId, cardOrderEditable, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// create Creates a new card order given information
        /// </summary>
        /// <exception cref="lob.dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cardId">The ID of the card to which the card orders belong.</param>
        /// <param name="cardOrderEditable"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CardOrder)</returns>
        public async System.Threading.Tasks.Task<lob.dotnet.Client.ApiResponse<CardOrder>> createWithHttpInfoAsync(string cardId, CardOrderEditable cardOrderEditable, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'cardId' is set
            if (cardId == null)
            {
                throw new lob.dotnet.Client.ApiException(400, "Missing required parameter 'cardId' when calling CardOrdersApi->create");
            }

            // verify the required parameter 'cardOrderEditable' is set
            if (cardOrderEditable == null)
            {
                throw new lob.dotnet.Client.ApiException(400, "Missing required parameter 'cardOrderEditable' when calling CardOrdersApi->create");
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

            localVarRequestOptions.PathParameters.Add("card_id", lob.dotnet.Client.ClientUtils.ParameterToString(cardId)); // path parameter
            localVarRequestOptions.Data = cardOrderEditable;

            localVarRequestOptions.Operation = "CardOrdersApi.create";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + lob.dotnet.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<CardOrder>("/cards/{card_id}/orders", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("create", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// get Retrieves the card orders associated with the given card id.
        /// </summary>
        /// <exception cref="lob.dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cardId">The ID of the card to which the card orders belong.</param>
        /// <param name="limit">How many results to return. (optional, default to 10)</param>
        /// <param name="offset">An integer that designates the offset at which to begin returning results. Defaults to 0. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CardOrderList</returns>
        public CardOrderList get(string cardId, int? limit = default(int?), int? offset = default(int?), int operationIndex = 0)
        {
            lob.dotnet.Client.ApiResponse<CardOrderList> localVarResponse = getWithHttpInfo(cardId, limit, offset);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get Retrieves the card orders associated with the given card id.
        /// </summary>
        /// <exception cref="lob.dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cardId">The ID of the card to which the card orders belong.</param>
        /// <param name="limit">How many results to return. (optional, default to 10)</param>
        /// <param name="offset">An integer that designates the offset at which to begin returning results. Defaults to 0. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CardOrderList</returns>
        public lob.dotnet.Client.ApiResponse<CardOrderList> getWithHttpInfo(string cardId, int? limit = default(int?), int? offset = default(int?), int operationIndex = 0)
        {
            // verify the required parameter 'cardId' is set
            if (cardId == null)
            {
                throw new lob.dotnet.Client.ApiException(400, "Missing required parameter 'cardId' when calling CardOrdersApi->get");
            }

            lob.dotnet.Client.RequestOptions localVarRequestOptions = new lob.dotnet.Client.RequestOptions();

            string[] _contentTypes = new string[] {
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

            localVarRequestOptions.PathParameters.Add("card_id", lob.dotnet.Client.ClientUtils.ParameterToString(cardId)); // path parameter
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(lob.dotnet.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (offset != null)
            {
                localVarRequestOptions.QueryParameters.Add(lob.dotnet.Client.ClientUtils.ParameterToMultiMap("", "offset", offset));
            }

            localVarRequestOptions.Operation = "CardOrdersApi.get";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + lob.dotnet.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<CardOrderList>("/cards/{card_id}/orders", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("get", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// get Retrieves the card orders associated with the given card id.
        /// </summary>
        /// <exception cref="lob.dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cardId">The ID of the card to which the card orders belong.</param>
        /// <param name="limit">How many results to return. (optional, default to 10)</param>
        /// <param name="offset">An integer that designates the offset at which to begin returning results. Defaults to 0. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CardOrderList</returns>
        public async System.Threading.Tasks.Task<CardOrderList> getAsync(string cardId, int? limit = default(int?), int? offset = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            lob.dotnet.Client.ApiResponse<CardOrderList> localVarResponse = await getWithHttpInfoAsync(cardId, limit, offset, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get Retrieves the card orders associated with the given card id.
        /// </summary>
        /// <exception cref="lob.dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cardId">The ID of the card to which the card orders belong.</param>
        /// <param name="limit">How many results to return. (optional, default to 10)</param>
        /// <param name="offset">An integer that designates the offset at which to begin returning results. Defaults to 0. (optional, default to 0)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CardOrderList)</returns>
        public async System.Threading.Tasks.Task<lob.dotnet.Client.ApiResponse<CardOrderList>> getWithHttpInfoAsync(string cardId, int? limit = default(int?), int? offset = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'cardId' is set
            if (cardId == null)
            {
                throw new lob.dotnet.Client.ApiException(400, "Missing required parameter 'cardId' when calling CardOrdersApi->get");
            }


            lob.dotnet.Client.RequestOptions localVarRequestOptions = new lob.dotnet.Client.RequestOptions();

            string[] _contentTypes = new string[] {
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

            localVarRequestOptions.PathParameters.Add("card_id", lob.dotnet.Client.ClientUtils.ParameterToString(cardId)); // path parameter
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(lob.dotnet.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (offset != null)
            {
                localVarRequestOptions.QueryParameters.Add(lob.dotnet.Client.ClientUtils.ParameterToMultiMap("", "offset", offset));
            }

            localVarRequestOptions.Operation = "CardOrdersApi.get";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + lob.dotnet.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<CardOrderList>("/cards/{card_id}/orders", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("get", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
