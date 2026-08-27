#nullable enable

namespace AppStoreConnect
{
    public partial interface ISubscriptionGroupsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterProductId"></param>
        /// <param name="filterName"></param>
        /// <param name="filterState"></param>
        /// <param name="sort"></param>
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
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitSubscriptionLocalizations"></param>
        /// <param name="limitIntroductoryOffers"></param>
        /// <param name="limitPromotionalOffers"></param>
        /// <param name="limitOfferCodes"></param>
        /// <param name="limitPrices"></param>
        /// <param name="limitWinBackOffers"></param>
        /// <param name="limitImages"></param>
        /// <param name="limitPlanAvailabilities"></param>
        /// <param name="limitVersions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.SubscriptionsResponse> SubscriptionGroupsSubscriptionsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterProductId = default,
            global::System.Collections.Generic.IList<string>? filterName = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFilterStateItem>? filterState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription>? fieldsSubscriptions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization>? fieldsSubscriptionLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionAppStoreReviewScreenshot>? fieldsSubscriptionAppStoreReviewScreenshots = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionGroup>? fieldsSubscriptionGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer>? fieldsSubscriptionIntroductoryOffers = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer>? fieldsSubscriptionPromotionalOffers = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode>? fieldsSubscriptionOfferCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPrice>? fieldsSubscriptionPrices = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsPromotedPurchase>? fieldsPromotedPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionAvailabilitie>? fieldsSubscriptionAvailabilities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer>? fieldsWinBackOffers = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionImage>? fieldsSubscriptionImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPlanAvailabilitie>? fieldsSubscriptionPlanAvailabilities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionVersion>? fieldsSubscriptionVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem>? include = default,
            int? limitSubscriptionLocalizations = default,
            int? limitIntroductoryOffers = default,
            int? limitPromotionalOffers = default,
            int? limitOfferCodes = default,
            int? limitPrices = default,
            int? limitWinBackOffers = default,
            int? limitImages = default,
            int? limitPlanAvailabilities = default,
            int? limitVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterProductId"></param>
        /// <param name="filterName"></param>
        /// <param name="filterState"></param>
        /// <param name="sort"></param>
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
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitSubscriptionLocalizations"></param>
        /// <param name="limitIntroductoryOffers"></param>
        /// <param name="limitPromotionalOffers"></param>
        /// <param name="limitOfferCodes"></param>
        /// <param name="limitPrices"></param>
        /// <param name="limitWinBackOffers"></param>
        /// <param name="limitImages"></param>
        /// <param name="limitPlanAvailabilities"></param>
        /// <param name="limitVersions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.SubscriptionsResponse>> SubscriptionGroupsSubscriptionsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterProductId = default,
            global::System.Collections.Generic.IList<string>? filterName = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFilterStateItem>? filterState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription>? fieldsSubscriptions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization>? fieldsSubscriptionLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionAppStoreReviewScreenshot>? fieldsSubscriptionAppStoreReviewScreenshots = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionGroup>? fieldsSubscriptionGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer>? fieldsSubscriptionIntroductoryOffers = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer>? fieldsSubscriptionPromotionalOffers = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode>? fieldsSubscriptionOfferCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPrice>? fieldsSubscriptionPrices = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsPromotedPurchase>? fieldsPromotedPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionAvailabilitie>? fieldsSubscriptionAvailabilities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsWinBackOffer>? fieldsWinBackOffers = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionImage>? fieldsSubscriptionImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPlanAvailabilitie>? fieldsSubscriptionPlanAvailabilities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionVersion>? fieldsSubscriptionVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem>? include = default,
            int? limitSubscriptionLocalizations = default,
            int? limitIntroductoryOffers = default,
            int? limitPromotionalOffers = default,
            int? limitOfferCodes = default,
            int? limitPrices = default,
            int? limitWinBackOffers = default,
            int? limitImages = default,
            int? limitPlanAvailabilities = default,
            int? limitVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}