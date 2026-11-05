#nullable enable

namespace AppStoreConnect
{
    public partial interface IRetentionMessagesClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsRetentionMessageVersions"></param>
        /// <param name="fieldsRetentionMessages"></param>
        /// <param name="fieldsRetentionMessageLocalizations"></param>
        /// <param name="fieldsAppAssetLibraryPlacements"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.RetentionMessageVersionsResponse> RetentionMessagesVersionsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessageVersion>? fieldsRetentionMessageVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessage>? fieldsRetentionMessages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessageLocalization>? fieldsRetentionMessageLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesVersionsGetToManyRelatedFieldsAppAssetLibraryPlacement>? fieldsAppAssetLibraryPlacements = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesVersionsGetToManyRelatedIncludeItem>? include = default,
            int? limitLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsRetentionMessageVersions"></param>
        /// <param name="fieldsRetentionMessages"></param>
        /// <param name="fieldsRetentionMessageLocalizations"></param>
        /// <param name="fieldsAppAssetLibraryPlacements"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.RetentionMessageVersionsResponse>> RetentionMessagesVersionsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessageVersion>? fieldsRetentionMessageVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessage>? fieldsRetentionMessages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessageLocalization>? fieldsRetentionMessageLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesVersionsGetToManyRelatedFieldsAppAssetLibraryPlacement>? fieldsAppAssetLibraryPlacements = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesVersionsGetToManyRelatedIncludeItem>? include = default,
            int? limitLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}