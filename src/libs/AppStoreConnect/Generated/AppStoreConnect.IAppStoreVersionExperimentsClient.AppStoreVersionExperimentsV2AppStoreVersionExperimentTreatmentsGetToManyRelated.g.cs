#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppStoreVersionExperimentsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAppStoreVersionExperimentTreatments"></param>
        /// <param name="fieldsAppStoreVersionExperiments"></param>
        /// <param name="fieldsAppStoreVersionExperimentTreatmentLocalizations"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitAppStoreVersionExperimentTreatmentLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppStoreVersionExperimentTreatmentsResponse> AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment>? fieldsAppStoreVersionExperimentTreatments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment>? fieldsAppStoreVersionExperiments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization>? fieldsAppStoreVersionExperimentTreatmentLocalizations = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedIncludeItem>? include = default,
            int? limitAppStoreVersionExperimentTreatmentLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAppStoreVersionExperimentTreatments"></param>
        /// <param name="fieldsAppStoreVersionExperiments"></param>
        /// <param name="fieldsAppStoreVersionExperimentTreatmentLocalizations"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitAppStoreVersionExperimentTreatmentLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppStoreVersionExperimentTreatmentsResponse>> AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment>? fieldsAppStoreVersionExperimentTreatments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment>? fieldsAppStoreVersionExperiments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization>? fieldsAppStoreVersionExperimentTreatmentLocalizations = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedIncludeItem>? include = default,
            int? limitAppStoreVersionExperimentTreatmentLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}