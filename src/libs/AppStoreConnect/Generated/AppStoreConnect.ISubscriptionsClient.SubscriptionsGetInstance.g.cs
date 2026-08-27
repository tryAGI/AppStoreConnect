#nullable enable

namespace AppStoreConnect
{
    public partial interface ISubscriptionsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsSubscriptions"></param>
        /// <param name="fieldsSubscriptionLocalizations"></param>
        /// <param name="fieldsSubscriptionAppStoreReviewScreenshots"></param>
        /// <param name="fieldsSubscriptionGroups"></param>
        /// <param name="fieldsSubscriptionIntroductoryOffers"></param>
        /// <param name="fieldsSubscriptionPromotionalOffers"></param>
        /// <param name="fieldsSubscriptionOfferCodes"></param>
        /// <param name="fieldsSubscriptionPrices"></param>
        /// <param name="fieldsPromotedPurchases"></param>
        /// <param name="fieldsSubscriptionAvailabilities"></param>
        /// <param name="fieldsWinBackOffers"></param>
        /// <param name="fieldsSubscriptionImages"></param>
        /// <param name="fieldsSubscriptionPlanAvailabilities"></param>
        /// <param name="fieldsSubscriptionVersions"></param>
        /// <param name="include"></param>
        /// <param name="limitImages"></param>
        /// <param name="limitIntroductoryOffers"></param>
        /// <param name="limitOfferCodes"></param>
        /// <param name="limitPlanAvailabilities"></param>
        /// <param name="limitPrices"></param>
        /// <param name="limitPromotionalOffers"></param>
        /// <param name="limitSubscriptionLocalizations"></param>
        /// <param name="limitVersions"></param>
        /// <param name="limitWinBackOffers"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.SubscriptionResponse> SubscriptionsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscription>? fieldsSubscriptions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionLocalization>? fieldsSubscriptionLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot>? fieldsSubscriptionAppStoreReviewScreenshots = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionGroup>? fieldsSubscriptionGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer>? fieldsSubscriptionIntroductoryOffers = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer>? fieldsSubscriptionPromotionalOffers = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionOfferCode>? fieldsSubscriptionOfferCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPrice>? fieldsSubscriptionPrices = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsPromotedPurchase>? fieldsPromotedPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionAvailabilitie>? fieldsSubscriptionAvailabilities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsWinBackOffer>? fieldsWinBackOffers = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionImage>? fieldsSubscriptionImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPlanAvailabilitie>? fieldsSubscriptionPlanAvailabilities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionVersion>? fieldsSubscriptionVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceIncludeItem>? include = default,
            int? limitImages = default,
            int? limitIntroductoryOffers = default,
            int? limitOfferCodes = default,
            int? limitPlanAvailabilities = default,
            int? limitPrices = default,
            int? limitPromotionalOffers = default,
            int? limitSubscriptionLocalizations = default,
            int? limitVersions = default,
            int? limitWinBackOffers = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsSubscriptions"></param>
        /// <param name="fieldsSubscriptionLocalizations"></param>
        /// <param name="fieldsSubscriptionAppStoreReviewScreenshots"></param>
        /// <param name="fieldsSubscriptionGroups"></param>
        /// <param name="fieldsSubscriptionIntroductoryOffers"></param>
        /// <param name="fieldsSubscriptionPromotionalOffers"></param>
        /// <param name="fieldsSubscriptionOfferCodes"></param>
        /// <param name="fieldsSubscriptionPrices"></param>
        /// <param name="fieldsPromotedPurchases"></param>
        /// <param name="fieldsSubscriptionAvailabilities"></param>
        /// <param name="fieldsWinBackOffers"></param>
        /// <param name="fieldsSubscriptionImages"></param>
        /// <param name="fieldsSubscriptionPlanAvailabilities"></param>
        /// <param name="fieldsSubscriptionVersions"></param>
        /// <param name="include"></param>
        /// <param name="limitImages"></param>
        /// <param name="limitIntroductoryOffers"></param>
        /// <param name="limitOfferCodes"></param>
        /// <param name="limitPlanAvailabilities"></param>
        /// <param name="limitPrices"></param>
        /// <param name="limitPromotionalOffers"></param>
        /// <param name="limitSubscriptionLocalizations"></param>
        /// <param name="limitVersions"></param>
        /// <param name="limitWinBackOffers"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.SubscriptionResponse>> SubscriptionsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscription>? fieldsSubscriptions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionLocalization>? fieldsSubscriptionLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot>? fieldsSubscriptionAppStoreReviewScreenshots = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionGroup>? fieldsSubscriptionGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer>? fieldsSubscriptionIntroductoryOffers = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer>? fieldsSubscriptionPromotionalOffers = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionOfferCode>? fieldsSubscriptionOfferCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPrice>? fieldsSubscriptionPrices = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsPromotedPurchase>? fieldsPromotedPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionAvailabilitie>? fieldsSubscriptionAvailabilities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsWinBackOffer>? fieldsWinBackOffers = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionImage>? fieldsSubscriptionImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPlanAvailabilitie>? fieldsSubscriptionPlanAvailabilities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionVersion>? fieldsSubscriptionVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceIncludeItem>? include = default,
            int? limitImages = default,
            int? limitIntroductoryOffers = default,
            int? limitOfferCodes = default,
            int? limitPlanAvailabilities = default,
            int? limitPrices = default,
            int? limitPromotionalOffers = default,
            int? limitSubscriptionLocalizations = default,
            int? limitVersions = default,
            int? limitWinBackOffers = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}