#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppStoreVersionExperimentsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAppStoreVersionExperiments"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsAppStoreVersions"></param>
        /// <param name="fieldsAppStoreVersionExperimentTreatments"></param>
        /// <param name="include"></param>
        /// <param name="limitAppStoreVersionExperimentTreatments"></param>
        /// <param name="limitControlVersions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppStoreVersionExperimentV2Response> AppStoreVersionExperimentsV2GetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperiment>? fieldsAppStoreVersionExperiments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentsV2GetInstanceFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperimentTreatment>? fieldsAppStoreVersionExperimentTreatments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentsV2GetInstanceIncludeItem>? include = default,
            int? limitAppStoreVersionExperimentTreatments = default,
            int? limitControlVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAppStoreVersionExperiments"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsAppStoreVersions"></param>
        /// <param name="fieldsAppStoreVersionExperimentTreatments"></param>
        /// <param name="include"></param>
        /// <param name="limitAppStoreVersionExperimentTreatments"></param>
        /// <param name="limitControlVersions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppStoreVersionExperimentV2Response>> AppStoreVersionExperimentsV2GetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperiment>? fieldsAppStoreVersionExperiments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentsV2GetInstanceFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperimentTreatment>? fieldsAppStoreVersionExperimentTreatments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentsV2GetInstanceIncludeItem>? include = default,
            int? limitAppStoreVersionExperimentTreatments = default,
            int? limitControlVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}