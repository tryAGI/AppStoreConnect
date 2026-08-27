#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppStoreVersionExperimentTreatmentsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterLocale"></param>
        /// <param name="fieldsAppStoreVersionExperimentTreatmentLocalizations"></param>
        /// <param name="fieldsAppStoreVersionExperimentTreatments"></param>
        /// <param name="fieldsAppScreenshotSets"></param>
        /// <param name="fieldsAppPreviewSets"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitAppScreenshotSets"></param>
        /// <param name="limitAppPreviewSets"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsResponse> AppStoreVersionExperimentTreatmentsAppStoreVersionExperimentTreatmentLocalizationsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterLocale = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentsAppStoreVersionExperimentTreatmentLocalizationsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization>? fieldsAppStoreVersionExperimentTreatmentLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentsAppStoreVersionExperimentTreatmentLocalizationsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment>? fieldsAppStoreVersionExperimentTreatments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentsAppStoreVersionExperimentTreatmentLocalizationsGetToManyRelatedFieldsAppScreenshotSet>? fieldsAppScreenshotSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentsAppStoreVersionExperimentTreatmentLocalizationsGetToManyRelatedFieldsAppPreviewSet>? fieldsAppPreviewSets = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentsAppStoreVersionExperimentTreatmentLocalizationsGetToManyRelatedIncludeItem>? include = default,
            int? limitAppScreenshotSets = default,
            int? limitAppPreviewSets = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterLocale"></param>
        /// <param name="fieldsAppStoreVersionExperimentTreatmentLocalizations"></param>
        /// <param name="fieldsAppStoreVersionExperimentTreatments"></param>
        /// <param name="fieldsAppScreenshotSets"></param>
        /// <param name="fieldsAppPreviewSets"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitAppScreenshotSets"></param>
        /// <param name="limitAppPreviewSets"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationsResponse>> AppStoreVersionExperimentTreatmentsAppStoreVersionExperimentTreatmentLocalizationsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterLocale = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentsAppStoreVersionExperimentTreatmentLocalizationsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization>? fieldsAppStoreVersionExperimentTreatmentLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentsAppStoreVersionExperimentTreatmentLocalizationsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment>? fieldsAppStoreVersionExperimentTreatments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentsAppStoreVersionExperimentTreatmentLocalizationsGetToManyRelatedFieldsAppScreenshotSet>? fieldsAppScreenshotSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentsAppStoreVersionExperimentTreatmentLocalizationsGetToManyRelatedFieldsAppPreviewSet>? fieldsAppPreviewSets = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentsAppStoreVersionExperimentTreatmentLocalizationsGetToManyRelatedIncludeItem>? include = default,
            int? limitAppScreenshotSets = default,
            int? limitAppPreviewSets = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}