#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppStoreVersionExperimentTreatmentsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAppStoreVersionExperimentTreatments"></param>
        /// <param name="fieldsAppStoreVersionExperiments"></param>
        /// <param name="fieldsAppStoreVersionExperimentTreatmentLocalizations"></param>
        /// <param name="include"></param>
        /// <param name="limitAppStoreVersionExperimentTreatmentLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppStoreVersionExperimentTreatmentResponse> AppStoreVersionExperimentTreatmentsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperimentTreatment>? fieldsAppStoreVersionExperimentTreatments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperiment>? fieldsAppStoreVersionExperiments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization>? fieldsAppStoreVersionExperimentTreatmentLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentsGetInstanceIncludeItem>? include = default,
            int? limitAppStoreVersionExperimentTreatmentLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAppStoreVersionExperimentTreatments"></param>
        /// <param name="fieldsAppStoreVersionExperiments"></param>
        /// <param name="fieldsAppStoreVersionExperimentTreatmentLocalizations"></param>
        /// <param name="include"></param>
        /// <param name="limitAppStoreVersionExperimentTreatmentLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppStoreVersionExperimentTreatmentResponse>> AppStoreVersionExperimentTreatmentsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperimentTreatment>? fieldsAppStoreVersionExperimentTreatments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperiment>? fieldsAppStoreVersionExperiments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization>? fieldsAppStoreVersionExperimentTreatmentLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentsGetInstanceIncludeItem>? include = default,
            int? limitAppStoreVersionExperimentTreatmentLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}