#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppClipAdvancedExperienceImagesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAppClipAdvancedExperienceImages"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppClipAdvancedExperienceImageResponse> AppClipAdvancedExperienceImagesGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipAdvancedExperienceImagesGetInstanceFieldsAppClipAdvancedExperienceImage>? fieldsAppClipAdvancedExperienceImages = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAppClipAdvancedExperienceImages"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppClipAdvancedExperienceImageResponse>> AppClipAdvancedExperienceImagesGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipAdvancedExperienceImagesGetInstanceFieldsAppClipAdvancedExperienceImage>? fieldsAppClipAdvancedExperienceImages = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}