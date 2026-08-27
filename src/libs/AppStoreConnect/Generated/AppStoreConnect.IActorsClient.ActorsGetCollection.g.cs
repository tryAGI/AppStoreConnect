#nullable enable

namespace AppStoreConnect
{
    public partial interface IActorsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterId"></param>
        /// <param name="fieldsActors"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.ActorsResponse> ActorsGetCollectionAsync(
            global::System.Collections.Generic.IList<string> filterId,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ActorsGetCollectionFieldsActor>? fieldsActors = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterId"></param>
        /// <param name="fieldsActors"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.ActorsResponse>> ActorsGetCollectionAsResponseAsync(
            global::System.Collections.Generic.IList<string> filterId,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ActorsGetCollectionFieldsActor>? fieldsActors = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}