#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppStoreVersionsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterState"></param>
        /// <param name="fieldsAppStoreVersionExperiments"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsAppStoreVersions"></param>
        /// <param name="fieldsAppStoreVersionExperimentTreatments"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitControlVersions"></param>
        /// <param name="limitAppStoreVersionExperimentTreatments"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppStoreVersionExperimentsV2Response> AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem>? filterState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperiment>? fieldsAppStoreVersionExperiments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatment>? fieldsAppStoreVersionExperimentTreatments = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedIncludeItem>? include = default,
            int? limitControlVersions = default,
            int? limitAppStoreVersionExperimentTreatments = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterState"></param>
        /// <param name="fieldsAppStoreVersionExperiments"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsAppStoreVersions"></param>
        /// <param name="fieldsAppStoreVersionExperimentTreatments"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitControlVersions"></param>
        /// <param name="limitAppStoreVersionExperimentTreatments"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppStoreVersionExperimentsV2Response>> AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFilterStateItem>? filterState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperiment>? fieldsAppStoreVersionExperiments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatment>? fieldsAppStoreVersionExperimentTreatments = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedIncludeItem>? include = default,
            int? limitControlVersions = default,
            int? limitAppStoreVersionExperimentTreatments = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}