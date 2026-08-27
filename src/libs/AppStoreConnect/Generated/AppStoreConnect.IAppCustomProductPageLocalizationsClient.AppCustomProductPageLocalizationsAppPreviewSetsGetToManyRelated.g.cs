#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppCustomProductPageLocalizationsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterPreviewType"></param>
        /// <param name="filterAppStoreVersionLocalization"></param>
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
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppPreviewSetsResponse> AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem>? filterPreviewType = default,
            global::System.Collections.Generic.IList<string>? filterAppStoreVersionLocalization = default,
            global::System.Collections.Generic.IList<string>? filterAppStoreVersionExperimentTreatmentLocalization = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet>? fieldsAppPreviewSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization>? fieldsAppStoreVersionLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppCustomProductPageLocalization>? fieldsAppCustomProductPageLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization>? fieldsAppStoreVersionExperimentTreatmentLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview>? fieldsAppPreviews = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedIncludeItem>? include = default,
            int? limitAppPreviews = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterPreviewType"></param>
        /// <param name="filterAppStoreVersionLocalization"></param>
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
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppPreviewSetsResponse>> AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFilterPreviewTypeItem>? filterPreviewType = default,
            global::System.Collections.Generic.IList<string>? filterAppStoreVersionLocalization = default,
            global::System.Collections.Generic.IList<string>? filterAppStoreVersionExperimentTreatmentLocalization = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet>? fieldsAppPreviewSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization>? fieldsAppStoreVersionLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppCustomProductPageLocalization>? fieldsAppCustomProductPageLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization>? fieldsAppStoreVersionExperimentTreatmentLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreview>? fieldsAppPreviews = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedIncludeItem>? include = default,
            int? limitAppPreviews = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}