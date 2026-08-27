#nullable enable

namespace AppStoreConnect
{
    public partial interface INominationsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsNominations"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsActors"></param>
        /// <param name="fieldsAppEvents"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="include"></param>
        /// <param name="limitInAppEvents"></param>
        /// <param name="limitRelatedApps"></param>
        /// <param name="limitSupportedTerritories"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.NominationResponse> NominationsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsNomination>? fieldsNominations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsActor>? fieldsActors = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsAppEvent>? fieldsAppEvents = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsTerritorie>? fieldsTerritories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceIncludeItem>? include = default,
            int? limitInAppEvents = default,
            int? limitRelatedApps = default,
            int? limitSupportedTerritories = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsNominations"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsActors"></param>
        /// <param name="fieldsAppEvents"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="include"></param>
        /// <param name="limitInAppEvents"></param>
        /// <param name="limitRelatedApps"></param>
        /// <param name="limitSupportedTerritories"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.NominationResponse>> NominationsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsNomination>? fieldsNominations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsActor>? fieldsActors = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsAppEvent>? fieldsAppEvents = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsTerritorie>? fieldsTerritories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceIncludeItem>? include = default,
            int? limitInAppEvents = default,
            int? limitRelatedApps = default,
            int? limitSupportedTerritories = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}