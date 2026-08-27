
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionsOfferCodesGetToManyRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        CustomCodes,
        /// <summary>
        /// 
        /// </summary>
        OneTimeUseCodes,
        /// <summary>
        /// 
        /// </summary>
        Prices,
        /// <summary>
        /// 
        /// </summary>
        Subscription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionsOfferCodesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsOfferCodesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                SubscriptionsOfferCodesGetToManyRelatedIncludeItem.CustomCodes => "customCodes",
                SubscriptionsOfferCodesGetToManyRelatedIncludeItem.OneTimeUseCodes => "oneTimeUseCodes",
                SubscriptionsOfferCodesGetToManyRelatedIncludeItem.Prices => "prices",
                SubscriptionsOfferCodesGetToManyRelatedIncludeItem.Subscription => "subscription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsOfferCodesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "customCodes" => SubscriptionsOfferCodesGetToManyRelatedIncludeItem.CustomCodes,
                "oneTimeUseCodes" => SubscriptionsOfferCodesGetToManyRelatedIncludeItem.OneTimeUseCodes,
                "prices" => SubscriptionsOfferCodesGetToManyRelatedIncludeItem.Prices,
                "subscription" => SubscriptionsOfferCodesGetToManyRelatedIncludeItem.Subscription,
                _ => null,
            };
        }
    }
}