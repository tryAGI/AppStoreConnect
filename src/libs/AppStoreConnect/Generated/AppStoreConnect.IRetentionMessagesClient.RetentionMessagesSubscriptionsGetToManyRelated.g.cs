#nullable enable

namespace AppStoreConnect
{
    public partial interface IRetentionMessagesClient
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
        /// <param name="fieldsRetentionOffers"></param>
        /// <param name="fieldsRetentionMessages"></param>
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
        /// <param name="limitRetentionOffers"></param>
        /// <param name="limitRetentionMessageOffers"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.SubscriptionsResponse> RetentionMessagesSubscriptionsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterProductId = default,
            global::System.Collections.Generic.IList<string>? filterName = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFilterStateItem>? filterState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription>? fieldsSubscriptions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization>? fieldsSubscriptionLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionAppStoreReviewScreenshot>? fieldsSubscriptionAppStoreReviewScreenshots = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionGroup>? fieldsSubscriptionGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer>? fieldsSubscriptionIntroductoryOffers = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer>? fieldsSubscriptionPromotionalOffers = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode>? fieldsSubscriptionOfferCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPrice>? fieldsSubscriptionPrices = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsPromotedPurchase>? fieldsPromotedPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionAvailabilitie>? fieldsSubscriptionAvailabilities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsWinBackOffer>? fieldsWinBackOffers = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionImage>? fieldsSubscriptionImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPlanAvailabilitie>? fieldsSubscriptionPlanAvailabilities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionVersion>? fieldsSubscriptionVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsRetentionOffer>? fieldsRetentionOffers = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsRetentionMessage>? fieldsRetentionMessages = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedIncludeItem>? include = default,
            int? limitSubscriptionLocalizations = default,
            int? limitIntroductoryOffers = default,
            int? limitPromotionalOffers = default,
            int? limitOfferCodes = default,
            int? limitPrices = default,
            int? limitWinBackOffers = default,
            int? limitImages = default,
            int? limitPlanAvailabilities = default,
            int? limitVersions = default,
            int? limitRetentionOffers = default,
            int? limitRetentionMessageOffers = default,
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
        /// <param name="fieldsRetentionOffers"></param>
        /// <param name="fieldsRetentionMessages"></param>
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
        /// <param name="limitRetentionOffers"></param>
        /// <param name="limitRetentionMessageOffers"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.SubscriptionsResponse>> RetentionMessagesSubscriptionsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterProductId = default,
            global::System.Collections.Generic.IList<string>? filterName = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFilterStateItem>? filterState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription>? fieldsSubscriptions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionLocalization>? fieldsSubscriptionLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionAppStoreReviewScreenshot>? fieldsSubscriptionAppStoreReviewScreenshots = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionGroup>? fieldsSubscriptionGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer>? fieldsSubscriptionIntroductoryOffers = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer>? fieldsSubscriptionPromotionalOffers = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode>? fieldsSubscriptionOfferCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPrice>? fieldsSubscriptionPrices = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsPromotedPurchase>? fieldsPromotedPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionAvailabilitie>? fieldsSubscriptionAvailabilities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsWinBackOffer>? fieldsWinBackOffers = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionImage>? fieldsSubscriptionImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPlanAvailabilitie>? fieldsSubscriptionPlanAvailabilities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionVersion>? fieldsSubscriptionVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsRetentionOffer>? fieldsRetentionOffers = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedFieldsRetentionMessage>? fieldsRetentionMessages = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesSubscriptionsGetToManyRelatedIncludeItem>? include = default,
            int? limitSubscriptionLocalizations = default,
            int? limitIntroductoryOffers = default,
            int? limitPromotionalOffers = default,
            int? limitOfferCodes = default,
            int? limitPrices = default,
            int? limitWinBackOffers = default,
            int? limitImages = default,
            int? limitPlanAvailabilities = default,
            int? limitVersions = default,
            int? limitRetentionOffers = default,
            int? limitRetentionMessageOffers = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}