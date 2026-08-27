#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterDeviceModel"></param>
        /// <param name="filterOsVersion"></param>
        /// <param name="filterAppPlatform"></param>
        /// <param name="filterDevicePlatform"></param>
        /// <param name="filterBuild"></param>
        /// <param name="filterBuildPreReleaseVersion"></param>
        /// <param name="filterTester"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsBetaFeedbackScreenshotSubmissions"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="fieldsBetaTesters"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsResponse> AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterDeviceModel = default,
            global::System.Collections.Generic.IList<string>? filterOsVersion = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFilterAppPlatformItem>? filterAppPlatform = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFilterDevicePlatformItem>? filterDevicePlatform = default,
            global::System.Collections.Generic.IList<string>? filterBuild = default,
            global::System.Collections.Generic.IList<string>? filterBuildPreReleaseVersion = default,
            global::System.Collections.Generic.IList<string>? filterTester = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission>? fieldsBetaFeedbackScreenshotSubmissions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaTester>? fieldsBetaTesters = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterDeviceModel"></param>
        /// <param name="filterOsVersion"></param>
        /// <param name="filterAppPlatform"></param>
        /// <param name="filterDevicePlatform"></param>
        /// <param name="filterBuild"></param>
        /// <param name="filterBuildPreReleaseVersion"></param>
        /// <param name="filterTester"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsBetaFeedbackScreenshotSubmissions"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="fieldsBetaTesters"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsResponse>> AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterDeviceModel = default,
            global::System.Collections.Generic.IList<string>? filterOsVersion = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFilterAppPlatformItem>? filterAppPlatform = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFilterDevicePlatformItem>? filterDevicePlatform = default,
            global::System.Collections.Generic.IList<string>? filterBuild = default,
            global::System.Collections.Generic.IList<string>? filterBuildPreReleaseVersion = default,
            global::System.Collections.Generic.IList<string>? filterTester = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission>? fieldsBetaFeedbackScreenshotSubmissions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaTester>? fieldsBetaTesters = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}