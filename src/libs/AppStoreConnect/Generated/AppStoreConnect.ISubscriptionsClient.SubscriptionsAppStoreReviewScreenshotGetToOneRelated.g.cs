#nullable enable

namespace AppStoreConnect
{
    public partial interface ISubscriptionsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsSubscriptionAppStoreReviewScreenshots"></param>
        /// <param name="fieldsSubscriptions"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotResponse> SubscriptionsAppStoreReviewScreenshotGetToOneRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionAppStoreReviewScreenshot>? fieldsSubscriptionAppStoreReviewScreenshots = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription>? fieldsSubscriptions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsAppStoreReviewScreenshotGetToOneRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsSubscriptionAppStoreReviewScreenshots"></param>
        /// <param name="fieldsSubscriptions"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotResponse>> SubscriptionsAppStoreReviewScreenshotGetToOneRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionAppStoreReviewScreenshot>? fieldsSubscriptionAppStoreReviewScreenshots = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription>? fieldsSubscriptions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsAppStoreReviewScreenshotGetToOneRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}