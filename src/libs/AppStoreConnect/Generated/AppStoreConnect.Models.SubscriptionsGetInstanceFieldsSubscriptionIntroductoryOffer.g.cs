
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer
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
    public static class SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOfferExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer value)
        {
            return value switch
            {
                SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer.Duration => "duration",
                SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer.EndDate => "endDate",
                SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer.NumberOfPeriods => "numberOfPeriods",
                SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer.OfferMode => "offerMode",
                SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer.StartDate => "startDate",
                SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer.Subscription => "subscription",
                SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer.SubscriptionPricePoint => "subscriptionPricePoint",
                SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer.TargetSubscriptionPlanType => "targetSubscriptionPlanType",
                SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer? ToEnum(string value)
        {
            return value switch
            {
                "duration" => SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer.Duration,
                "endDate" => SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer.EndDate,
                "numberOfPeriods" => SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer.NumberOfPeriods,
                "offerMode" => SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer.OfferMode,
                "startDate" => SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer.StartDate,
                "subscription" => SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer.Subscription,
                "subscriptionPricePoint" => SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer.SubscriptionPricePoint,
                "targetSubscriptionPlanType" => SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer.TargetSubscriptionPlanType,
                "territory" => SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer.Territory,
                _ => null,
            };
        }
    }
}