
#nullable enable

namespace AppStoreConnect
{
    public partial class BuildBetaDetailsClient
    {


        private static readonly global::AppStoreConnect.EndPointSecurityRequirement s_BuildBetaDetailsBuildGetToOneRelatedSecurityRequirement0 =
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
        private static readonly global::AppStoreConnect.EndPointSecurityRequirement[] s_BuildBetaDetailsBuildGetToOneRelatedSecurityRequirements =
            new global::AppStoreConnect.EndPointSecurityRequirement[]
            {                s_BuildBetaDetailsBuildGetToOneRelatedSecurityRequirement0,
            };
        partial void PrepareBuildBetaDetailsBuildGetToOneRelatedArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuild>? fieldsBuilds,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsPreReleaseVersion>? fieldsPreReleaseVersions,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTester>? fieldsBetaTesters,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup>? fieldsBetaGroups,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaBuildLocalization>? fieldsBetaBuildLocalizations,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration>? fieldsAppEncryptionDeclarations,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaAppReviewSubmission>? fieldsBetaAppReviewSubmissions,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsApp>? fieldsApps,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBetaDetail>? fieldsBuildBetaDetails,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildIcon>? fieldsBuildIcons,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle>? fieldsBuildBundles,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload>? fieldsBuildUploads,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedIncludeItem>? include,
            ref int? limitIndividualTesters,
            ref int? limitBetaGroups,
            ref int? limitBetaBuildLocalizations,
            ref int? limitIcons,
            ref int? limitBuildBundles,
            ref string id);
        partial void PrepareBuildBetaDetailsBuildGetToOneRelatedRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuild>? fieldsBuilds,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsPreReleaseVersion>? fieldsPreReleaseVersions,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTester>? fieldsBetaTesters,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup>? fieldsBetaGroups,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaBuildLocalization>? fieldsBetaBuildLocalizations,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration>? fieldsAppEncryptionDeclarations,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaAppReviewSubmission>? fieldsBetaAppReviewSubmissions,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsApp>? fieldsApps,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBetaDetail>? fieldsBuildBetaDetails,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildIcon>? fieldsBuildIcons,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle>? fieldsBuildBundles,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload>? fieldsBuildUploads,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedIncludeItem>? include,
            int? limitIndividualTesters,
            int? limitBetaGroups,
            int? limitBetaBuildLocalizations,
            int? limitIcons,
            int? limitBuildBundles,
            string id);
        partial void ProcessBuildBetaDetailsBuildGetToOneRelatedResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessBuildBetaDetailsBuildGetToOneRelatedResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsBuilds"></param>
        /// <param name="fieldsPreReleaseVersions"></param>
        /// <param name="fieldsBetaTesters"></param>
        /// <param name="fieldsBetaGroups"></param>
        /// <param name="fieldsBetaBuildLocalizations"></param>
        /// <param name="fieldsAppEncryptionDeclarations"></param>
        /// <param name="fieldsBetaAppReviewSubmissions"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsBuildBetaDetails"></param>
        /// <param name="fieldsAppStoreVersions"></param>
        /// <param name="fieldsBuildIcons"></param>
        /// <param name="fieldsBuildBundles"></param>
        /// <param name="fieldsBuildUploads"></param>
        /// <param name="include"></param>
        /// <param name="limitIndividualTesters"></param>
        /// <param name="limitBetaGroups"></param>
        /// <param name="limitBetaBuildLocalizations"></param>
        /// <param name="limitIcons"></param>
        /// <param name="limitBuildBundles"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::AppStoreConnect.BuildResponse> BuildBetaDetailsBuildGetToOneRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsPreReleaseVersion>? fieldsPreReleaseVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTester>? fieldsBetaTesters = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup>? fieldsBetaGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaBuildLocalization>? fieldsBetaBuildLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration>? fieldsAppEncryptionDeclarations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaAppReviewSubmission>? fieldsBetaAppReviewSubmissions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBetaDetail>? fieldsBuildBetaDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildIcon>? fieldsBuildIcons = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle>? fieldsBuildBundles = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload>? fieldsBuildUploads = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedIncludeItem>? include = default,
            int? limitIndividualTesters = default,
            int? limitBetaGroups = default,
            int? limitBetaBuildLocalizations = default,
            int? limitIcons = default,
            int? limitBuildBundles = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await BuildBetaDetailsBuildGetToOneRelatedAsResponseAsync(
                id: id,
                fieldsBuilds: fieldsBuilds,
                fieldsPreReleaseVersions: fieldsPreReleaseVersions,
                fieldsBetaTesters: fieldsBetaTesters,
                fieldsBetaGroups: fieldsBetaGroups,
                fieldsBetaBuildLocalizations: fieldsBetaBuildLocalizations,
                fieldsAppEncryptionDeclarations: fieldsAppEncryptionDeclarations,
                fieldsBetaAppReviewSubmissions: fieldsBetaAppReviewSubmissions,
                fieldsApps: fieldsApps,
                fieldsBuildBetaDetails: fieldsBuildBetaDetails,
                fieldsAppStoreVersions: fieldsAppStoreVersions,
                fieldsBuildIcons: fieldsBuildIcons,
                fieldsBuildBundles: fieldsBuildBundles,
                fieldsBuildUploads: fieldsBuildUploads,
                include: include,
                limitIndividualTesters: limitIndividualTesters,
                limitBetaGroups: limitBetaGroups,
                limitBetaBuildLocalizations: limitBetaBuildLocalizations,
                limitIcons: limitIcons,
                limitBuildBundles: limitBuildBundles,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsBuilds"></param>
        /// <param name="fieldsPreReleaseVersions"></param>
        /// <param name="fieldsBetaTesters"></param>
        /// <param name="fieldsBetaGroups"></param>
        /// <param name="fieldsBetaBuildLocalizations"></param>
        /// <param name="fieldsAppEncryptionDeclarations"></param>
        /// <param name="fieldsBetaAppReviewSubmissions"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsBuildBetaDetails"></param>
        /// <param name="fieldsAppStoreVersions"></param>
        /// <param name="fieldsBuildIcons"></param>
        /// <param name="fieldsBuildBundles"></param>
        /// <param name="fieldsBuildUploads"></param>
        /// <param name="include"></param>
        /// <param name="limitIndividualTesters"></param>
        /// <param name="limitBetaGroups"></param>
        /// <param name="limitBetaBuildLocalizations"></param>
        /// <param name="limitIcons"></param>
        /// <param name="limitBuildBundles"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.BuildResponse>> BuildBetaDetailsBuildGetToOneRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsPreReleaseVersion>? fieldsPreReleaseVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTester>? fieldsBetaTesters = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup>? fieldsBetaGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaBuildLocalization>? fieldsBetaBuildLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration>? fieldsAppEncryptionDeclarations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaAppReviewSubmission>? fieldsBetaAppReviewSubmissions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBetaDetail>? fieldsBuildBetaDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildIcon>? fieldsBuildIcons = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle>? fieldsBuildBundles = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload>? fieldsBuildUploads = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedIncludeItem>? include = default,
            int? limitIndividualTesters = default,
            int? limitBetaGroups = default,
            int? limitBetaBuildLocalizations = default,
            int? limitIcons = default,
            int? limitBuildBundles = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareBuildBetaDetailsBuildGetToOneRelatedArguments(
                httpClient: HttpClient,
                fieldsBuilds: fieldsBuilds,
                fieldsPreReleaseVersions: fieldsPreReleaseVersions,
                fieldsBetaTesters: fieldsBetaTesters,
                fieldsBetaGroups: fieldsBetaGroups,
                fieldsBetaBuildLocalizations: fieldsBetaBuildLocalizations,
                fieldsAppEncryptionDeclarations: fieldsAppEncryptionDeclarations,
                fieldsBetaAppReviewSubmissions: fieldsBetaAppReviewSubmissions,
                fieldsApps: fieldsApps,
                fieldsBuildBetaDetails: fieldsBuildBetaDetails,
                fieldsAppStoreVersions: fieldsAppStoreVersions,
                fieldsBuildIcons: fieldsBuildIcons,
                fieldsBuildBundles: fieldsBuildBundles,
                fieldsBuildUploads: fieldsBuildUploads,
                include: include,
                limitIndividualTesters: ref limitIndividualTesters,
                limitBetaGroups: ref limitBetaGroups,
                limitBetaBuildLocalizations: ref limitBetaBuildLocalizations,
                limitIcons: ref limitIcons,
                limitBuildBundles: ref limitBuildBundles,
                id: ref id);


            var __authorizations = global::AppStoreConnect.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_BuildBetaDetailsBuildGetToOneRelatedSecurityRequirements,
                operationName: "BuildBetaDetailsBuildGetToOneRelatedAsync");

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
                                path: $"/v1/buildBetaDetails/{id}/build",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("fields[builds]", fieldsBuilds, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[preReleaseVersions]", fieldsPreReleaseVersions, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[betaTesters]", fieldsBetaTesters, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[betaGroups]", fieldsBetaGroups, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[betaBuildLocalizations]", fieldsBetaBuildLocalizations, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[appEncryptionDeclarations]", fieldsAppEncryptionDeclarations, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[betaAppReviewSubmissions]", fieldsBetaAppReviewSubmissions, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[apps]", fieldsApps, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[buildBetaDetails]", fieldsBuildBetaDetails, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[appStoreVersions]", fieldsAppStoreVersions, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[buildIcons]", fieldsBuildIcons, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[buildBundles]", fieldsBuildBundles, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("fields[buildUploads]", fieldsBuildUploads, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("include", include, selector: static x => x.ToValueString(), delimiter: ",", explode: false)
                                .AddOptionalParameter("limit[individualTesters]", limitIndividualTesters?.ToString())
                                .AddOptionalParameter("limit[betaGroups]", limitBetaGroups?.ToString())
                                .AddOptionalParameter("limit[betaBuildLocalizations]", limitBetaBuildLocalizations?.ToString())
                                .AddOptionalParameter("limit[icons]", limitIcons?.ToString())
                                .AddOptionalParameter("limit[buildBundles]", limitBuildBundles?.ToString())
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
                PrepareBuildBetaDetailsBuildGetToOneRelatedRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    fieldsBuilds: fieldsBuilds,
                    fieldsPreReleaseVersions: fieldsPreReleaseVersions,
                    fieldsBetaTesters: fieldsBetaTesters,
                    fieldsBetaGroups: fieldsBetaGroups,
                    fieldsBetaBuildLocalizations: fieldsBetaBuildLocalizations,
                    fieldsAppEncryptionDeclarations: fieldsAppEncryptionDeclarations,
                    fieldsBetaAppReviewSubmissions: fieldsBetaAppReviewSubmissions,
                    fieldsApps: fieldsApps,
                    fieldsBuildBetaDetails: fieldsBuildBetaDetails,
                    fieldsAppStoreVersions: fieldsAppStoreVersions,
                    fieldsBuildIcons: fieldsBuildIcons,
                    fieldsBuildBundles: fieldsBuildBundles,
                    fieldsBuildUploads: fieldsBuildUploads,
                    include: include,
                    limitIndividualTesters: limitIndividualTesters,
                    limitBetaGroups: limitBetaGroups,
                    limitBetaBuildLocalizations: limitBetaBuildLocalizations,
                    limitIcons: limitIcons,
                    limitBuildBundles: limitBuildBundles,
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
                                operationId: "BuildBetaDetailsBuildGetToOneRelated",
                                methodName: "BuildBetaDetailsBuildGetToOneRelatedAsync",
                                pathTemplate: "$\"/v1/buildBetaDetails/{id}/build\"",
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
                                operationId: "BuildBetaDetailsBuildGetToOneRelated",
                                methodName: "BuildBetaDetailsBuildGetToOneRelatedAsync",
                                pathTemplate: "$\"/v1/buildBetaDetails/{id}/build\"",
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
                                operationId: "BuildBetaDetailsBuildGetToOneRelated",
                                methodName: "BuildBetaDetailsBuildGetToOneRelatedAsync",
                                pathTemplate: "$\"/v1/buildBetaDetails/{id}/build\"",
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
                ProcessBuildBetaDetailsBuildGetToOneRelatedResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::AppStoreConnect.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::AppStoreConnect.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "BuildBetaDetailsBuildGetToOneRelated",
                                methodName: "BuildBetaDetailsBuildGetToOneRelatedAsync",
                                pathTemplate: "$\"/v1/buildBetaDetails/{id}/build\"",
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
                                operationId: "BuildBetaDetailsBuildGetToOneRelated",
                                methodName: "BuildBetaDetailsBuildGetToOneRelatedAsync",
                                pathTemplate: "$\"/v1/buildBetaDetails/{id}/build\"",
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
                                ProcessBuildBetaDetailsBuildGetToOneRelatedResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::AppStoreConnect.BuildResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.BuildResponse>(
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

                                    var __value = await global::AppStoreConnect.BuildResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.BuildResponse>(
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