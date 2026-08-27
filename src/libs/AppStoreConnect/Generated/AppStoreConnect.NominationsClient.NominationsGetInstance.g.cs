
#nullable enable

namespace AppStoreConnect
{
    public partial class NominationsClient
    {


        private static readonly global::AppStoreConnect.EndPointSecurityRequirement s_NominationsGetInstanceSecurityRequirement0 =
            new global::AppStoreConnect.EndPointSecurityRequirement
            {
                Authorizations = new global::AppStoreConnect.EndPointAuthorizationRequirement[]
                {                    new global::AppStoreConnect.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::AppStoreConnect.EndPointSecurityRequirement[] s_NominationsGetInstanceSecurityRequirements =
            new global::AppStoreConnect.EndPointSecurityRequirement[]
            {                s_NominationsGetInstanceSecurityRequirement0,
            };
        partial void PrepareNominationsGetInstanceArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsNomination>? fieldsNominations,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsApp>? fieldsApps,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsActor>? fieldsActors,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsAppEvent>? fieldsAppEvents,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsTerritorie>? fieldsTerritories,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceIncludeItem>? include,
            ref int? limitInAppEvents,
            ref int? limitRelatedApps,
            ref int? limitSupportedTerritories,
            ref string id);
        partial void PrepareNominationsGetInstanceRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsNomination>? fieldsNominations,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsApp>? fieldsApps,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsActor>? fieldsActors,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsAppEvent>? fieldsAppEvents,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsTerritorie>? fieldsTerritories,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceIncludeItem>? include,
            int? limitInAppEvents,
            int? limitRelatedApps,
            int? limitSupportedTerritories,
            string id);
        partial void ProcessNominationsGetInstanceResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessNominationsGetInstanceResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsNominations"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsActors"></param>
        /// <param name="fieldsAppEvents"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="include"></param>
        /// <param name="limitInAppEvents"></param>
        /// <param name="limitRelatedApps"></param>
        /// <param name="limitSupportedTerritories"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::AppStoreConnect.NominationResponse> NominationsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsNomination>? fieldsNominations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsActor>? fieldsActors = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsAppEvent>? fieldsAppEvents = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsTerritorie>? fieldsTerritories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceIncludeItem>? include = default,
            int? limitInAppEvents = default,
            int? limitRelatedApps = default,
            int? limitSupportedTerritories = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await NominationsGetInstanceAsResponseAsync(
                id: id,
                fieldsNominations: fieldsNominations,
                fieldsApps: fieldsApps,
                fieldsActors: fieldsActors,
                fieldsAppEvents: fieldsAppEvents,
                fieldsTerritories: fieldsTerritories,
                include: include,
                limitInAppEvents: limitInAppEvents,
                limitRelatedApps: limitRelatedApps,
                limitSupportedTerritories: limitSupportedTerritories,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsNominations"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsActors"></param>
        /// <param name="fieldsAppEvents"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="include"></param>
        /// <param name="limitInAppEvents"></param>
        /// <param name="limitRelatedApps"></param>
        /// <param name="limitSupportedTerritories"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.NominationResponse>> NominationsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsNomination>? fieldsNominations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsActor>? fieldsActors = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsAppEvent>? fieldsAppEvents = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsTerritorie>? fieldsTerritories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceIncludeItem>? include = default,
            int? limitInAppEvents = default,
            int? limitRelatedApps = default,
            int? limitSupportedTerritories = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareNominationsGetInstanceArguments(
                httpClient: HttpClient,
                fieldsNominations: fieldsNominations,
                fieldsApps: fieldsApps,
                fieldsActors: fieldsActors,
                fieldsAppEvents: fieldsAppEvents,
                fieldsTerritories: fieldsTerritories,
                include: include,
                limitInAppEvents: ref limitInAppEvents,
                limitRelatedApps: ref limitRelatedApps,
                limitSupportedTerritories: ref limitSupportedTerritories,
                id: ref id);


            var __authorizations = global::AppStoreConnect.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_NominationsGetInstanceSecurityRequirements,
                operationName: "NominationsGetInstanceAsync");

            using var __timeoutCancellationTokenSource = global::AppStoreConnect.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::AppStoreConnect.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::AppStoreConnect.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::AppStoreConnect.PathBuilder(
                                path: $"/v1/nominations/{id}",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("fields[nominations]", fieldsNominations, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[apps]", fieldsApps, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[actors]", fieldsActors, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[appEvents]", fieldsAppEvents, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[territories]", fieldsTerritories, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("include", include, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("limit[inAppEvents]", limitInAppEvents?.ToString())
                                .AddOptionalParameter("limit[relatedApps]", limitRelatedApps?.ToString())
                                .AddOptionalParameter("limit[supportedTerritories]", limitSupportedTerritories?.ToString())
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::AppStoreConnect.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
                global::AppStoreConnect.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareNominationsGetInstanceRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    fieldsNominations: fieldsNominations,
                    fieldsApps: fieldsApps,
                    fieldsActors: fieldsActors,
                    fieldsAppEvents: fieldsAppEvents,
                    fieldsTerritories: fieldsTerritories,
                    include: include,
                    limitInAppEvents: limitInAppEvents,
                    limitRelatedApps: limitRelatedApps,
                    limitSupportedTerritories: limitSupportedTerritories,
                    id: id!);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::AppStoreConnect.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::AppStoreConnect.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "NominationsGetInstance",
                                methodName: "NominationsGetInstanceAsync",
                                pathTemplate: "$\"/v1/nominations/{id}\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::AppStoreConnect.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::AppStoreConnect.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::AppStoreConnect.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "NominationsGetInstance",
                                methodName: "NominationsGetInstanceAsync",
                                pathTemplate: "$\"/v1/nominations/{id}\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::AppStoreConnect.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::AppStoreConnect.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::AppStoreConnect.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::AppStoreConnect.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::AppStoreConnect.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "NominationsGetInstance",
                                methodName: "NominationsGetInstanceAsync",
                                pathTemplate: "$\"/v1/nominations/{id}\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::AppStoreConnect.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessNominationsGetInstanceResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::AppStoreConnect.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::AppStoreConnect.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "NominationsGetInstance",
                                methodName: "NominationsGetInstanceAsync",
                                pathTemplate: "$\"/v1/nominations/{id}\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::AppStoreConnect.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::AppStoreConnect.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "NominationsGetInstance",
                                methodName: "NominationsGetInstanceAsync",
                                pathTemplate: "$\"/v1/nominations/{id}\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Parameter error(s)
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::AppStoreConnect.ErrorResponse? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::AppStoreConnect.ErrorResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::AppStoreConnect.ErrorResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::AppStoreConnect.ApiException<global::AppStoreConnect.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    responseBody: __content_400,
                                    responseObject: __value_400,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Unauthorized error(s)
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                global::AppStoreConnect.ErrorResponse? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = global::AppStoreConnect.ErrorResponse.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = global::AppStoreConnect.ErrorResponse.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }


                                throw global::AppStoreConnect.ApiException<global::AppStoreConnect.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_401,
                                    responseBody: __content_401,
                                    responseObject: __value_401,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Forbidden error
                            if ((int)__response.StatusCode == 403)
                            {
                                string? __content_403 = null;
                                global::System.Exception? __exception_403 = null;
                                global::AppStoreConnect.ErrorResponse? __value_403 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_403 = global::AppStoreConnect.ErrorResponse.FromJson(__content_403, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_403 = global::AppStoreConnect.ErrorResponse.FromJson(__content_403, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }


                                throw global::AppStoreConnect.ApiException<global::AppStoreConnect.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_403,
                                    responseBody: __content_403,
                                    responseObject: __value_403,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Not found error
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                global::AppStoreConnect.ErrorResponse? __value_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = global::AppStoreConnect.ErrorResponse.FromJson(__content_404, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_404 = global::AppStoreConnect.ErrorResponse.FromJson(__content_404, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }


                                throw global::AppStoreConnect.ApiException<global::AppStoreConnect.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_404,
                                    responseBody: __content_404,
                                    responseObject: __value_404,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Rate limit exceeded error
                            if ((int)__response.StatusCode == 429)
                            {
                                string? __content_429 = null;
                                global::System.Exception? __exception_429 = null;
                                global::AppStoreConnect.ErrorResponse? __value_429 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_429 = global::AppStoreConnect.ErrorResponse.FromJson(__content_429, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_429 = global::AppStoreConnect.ErrorResponse.FromJson(__content_429, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_429 = __ex;
                                }


                                throw global::AppStoreConnect.ApiException<global::AppStoreConnect.ErrorResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_429,
                                    responseBody: __content_429,
                                    responseObject: __value_429,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessNominationsGetInstanceResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::AppStoreConnect.NominationResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.NominationResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::AppStoreConnect.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::AppStoreConnect.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::AppStoreConnect.NominationResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.NominationResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::AppStoreConnect.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::AppStoreConnect.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}