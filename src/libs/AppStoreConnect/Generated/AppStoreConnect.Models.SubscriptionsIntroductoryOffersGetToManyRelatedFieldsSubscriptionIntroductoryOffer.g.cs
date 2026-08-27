
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer
    {
        /// <summary>
        /// 
        /// </summary>
        Duration,
        /// <summary>
        /// 
        /// </summary>
        EndDate,
        /// <summary>
        /// 
        /// </summary>
        NumberOfPeriods,
        /// <summary>
        /// 
        /// </summary>
        OfferMode,
        /// <summary>
        /// 
        /// </summary>
        StartDate,
        /// <summary>
        /// 
        /// </summary>
        Subscription,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionPricePoint,
        /// <summary>
        /// 
        /// </summary>
        TargetSubscriptionPlanType,
        /// <summary>
        /// 
        /// </summary>
        Territory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOfferExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer value)
        {
            return value switch
            {
                SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer.Duration => "duration",
                SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer.EndDate => "endDate",
                SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer.NumberOfPeriods => "numberOfPeriods",
                SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer.OfferMode => "offerMode",
                SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer.StartDate => "startDate",
                SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer.Subscription => "subscription",
                SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer.SubscriptionPricePoint => "subscriptionPricePoint",
                SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer.TargetSubscriptionPlanType => "targetSubscriptionPlanType",
                SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer? ToEnum(string value)
        {
            return value switch
            {
                "duration" => SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer.Duration,
                "endDate" => SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer.EndDate,
                "numberOfPeriods" => SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer.NumberOfPeriods,
                "offerMode" => SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer.OfferMode,
                "startDate" => SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer.StartDate,
                "subscription" => SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer.Subscription,
                "subscriptionPricePoint" => SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer.SubscriptionPricePoint,
                "targetSubscriptionPlanType" => SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer.TargetSubscriptionPlanType,
                "territory" => SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer.Territory,
                _ => null,
            };
        }
    }
}