#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppStoreVersionLocalizationsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterPreviewType"></param>
        /// <param name="filterAppCustomProductPageLocalization"></param>
        /// <param name="filterAppStoreVersionExperimentTreatmentLocalization"></param>
        /// <param name="fieldsAppPreviewSets"></param>
        /// <param name="fieldsAppStoreVersionLocalizations"></param>
        /// <param name="fieldsAppCustomProductPageLocalizations"></param>
        /// <param name="fieldsAppStoreVersionExperimentTreatmentLocalizations"></param>
        /// <param name="fieldsAppPreviews"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitAppPreviews"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppPreviewSetsResponse> AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem>? filterPreviewType = default,
            global::System.Collections.Generic.IList<string>? filterAppCustomProductPageLocalization = default,
            global::System.Collections.Generic.IList<string>? filterAppStoreVersionExperimentTreatmentLocalization = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet>? fieldsAppPreviewSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization>? fieldsAppStoreVersionLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppCustomProductPageLocalization>? fieldsAppCustomProductPageLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization>? fieldsAppStoreVersionExperimentTreatmentLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview>? fieldsAppPreviews = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedIncludeItem>? include = default,
            int? limitAppPreviews = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterPreviewType"></param>
        /// <param name="filterAppCustomProductPageLocalization"></param>
        /// <param name="filterAppStoreVersionExperimentTreatmentLocalization"></param>
        /// <param name="fieldsAppPreviewSets"></param>
        /// <param name="fieldsAppStoreVersionLocalizations"></param>
        /// <param name="fieldsAppCustomProductPageLocalizations"></param>
        /// <param name="fieldsAppStoreVersionExperimentTreatmentLocalizations"></param>
        /// <param name="fieldsAppPreviews"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitAppPreviews"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppPreviewSetsResponse>> AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem>? filterPreviewType = default,
            global::System.Collections.Generic.IList<string>? filterAppCustomProductPageLocalization = default,
            global::System.Collections.Generic.IList<string>? filterAppStoreVersionExperimentTreatmentLocalization = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet>? fieldsAppPreviewSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization>? fieldsAppStoreVersionLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppCustomProductPageLocalization>? fieldsAppCustomProductPageLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization>? fieldsAppStoreVersionExperimentTreatmentLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview>? fieldsAppPreviews = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedIncludeItem>? include = default,
            int? limitAppPreviews = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}