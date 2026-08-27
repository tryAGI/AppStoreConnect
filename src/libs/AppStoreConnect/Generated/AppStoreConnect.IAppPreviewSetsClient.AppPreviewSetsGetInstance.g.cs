#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppPreviewSetsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAppPreviewSets"></param>
        /// <param name="fieldsAppStoreVersionLocalizations"></param>
        /// <param name="fieldsAppCustomProductPageLocalizations"></param>
        /// <param name="fieldsAppStoreVersionExperimentTreatmentLocalizations"></param>
        /// <param name="fieldsAppPreviews"></param>
        /// <param name="include"></param>
        /// <param name="limitAppPreviews"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppPreviewSetResponse> AppPreviewSetsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppPreviewSet>? fieldsAppPreviewSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalization>? fieldsAppStoreVersionLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppCustomProductPageLocalization>? fieldsAppCustomProductPageLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization>? fieldsAppStoreVersionExperimentTreatmentLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppPreview>? fieldsAppPreviews = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreviewSetsGetInstanceIncludeItem>? include = default,
            int? limitAppPreviews = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAppPreviewSets"></param>
        /// <param name="fieldsAppStoreVersionLocalizations"></param>
        /// <param name="fieldsAppCustomProductPageLocalizations"></param>
        /// <param name="fieldsAppStoreVersionExperimentTreatmentLocalizations"></param>
        /// <param name="fieldsAppPreviews"></param>
        /// <param name="include"></param>
        /// <param name="limitAppPreviews"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppPreviewSetResponse>> AppPreviewSetsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppPreviewSet>? fieldsAppPreviewSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalization>? fieldsAppStoreVersionLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppCustomProductPageLocalization>? fieldsAppCustomProductPageLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization>? fieldsAppStoreVersionExperimentTreatmentLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppPreview>? fieldsAppPreviews = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreviewSetsGetInstanceIncludeItem>? include = default,
            int? limitAppPreviews = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}