#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppCustomProductPageLocalizationsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterScreenshotDisplayType"></param>
        /// <param name="filterAppStoreVersionLocalization"></param>
        /// <param name="filterAppStoreVersionExperimentTreatmentLocalization"></param>
        /// <param name="fieldsAppScreenshotSets"></param>
        /// <param name="fieldsAppStoreVersionLocalizations"></param>
        /// <param name="fieldsAppCustomProductPageLocalizations"></param>
        /// <param name="fieldsAppStoreVersionExperimentTreatmentLocalizations"></param>
        /// <param name="fieldsAppScreenshots"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitAppScreenshots"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppScreenshotSetsResponse> AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFilterScreenshotDisplayTypeItem>? filterScreenshotDisplayType = default,
            global::System.Collections.Generic.IList<string>? filterAppStoreVersionLocalization = default,
            global::System.Collections.Generic.IList<string>? filterAppStoreVersionExperimentTreatmentLocalization = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet>? fieldsAppScreenshotSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization>? fieldsAppStoreVersionLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppCustomProductPageLocalization>? fieldsAppCustomProductPageLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization>? fieldsAppStoreVersionExperimentTreatmentLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot>? fieldsAppScreenshots = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem>? include = default,
            int? limitAppScreenshots = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterScreenshotDisplayType"></param>
        /// <param name="filterAppStoreVersionLocalization"></param>
        /// <param name="filterAppStoreVersionExperimentTreatmentLocalization"></param>
        /// <param name="fieldsAppScreenshotSets"></param>
        /// <param name="fieldsAppStoreVersionLocalizations"></param>
        /// <param name="fieldsAppCustomProductPageLocalizations"></param>
        /// <param name="fieldsAppStoreVersionExperimentTreatmentLocalizations"></param>
        /// <param name="fieldsAppScreenshots"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitAppScreenshots"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppScreenshotSetsResponse>> AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFilterScreenshotDisplayTypeItem>? filterScreenshotDisplayType = default,
            global::System.Collections.Generic.IList<string>? filterAppStoreVersionLocalization = default,
            global::System.Collections.Generic.IList<string>? filterAppStoreVersionExperimentTreatmentLocalization = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet>? fieldsAppScreenshotSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization>? fieldsAppStoreVersionLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppCustomProductPageLocalization>? fieldsAppCustomProductPageLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization>? fieldsAppStoreVersionExperimentTreatmentLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshot>? fieldsAppScreenshots = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem>? include = default,
            int? limitAppScreenshots = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}