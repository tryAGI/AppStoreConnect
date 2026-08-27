
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        OfferCode,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedIncludeItem.OfferCode => "offerCode",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "offerCode" => SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedIncludeItem.OfferCode,
                _ => null,
            };
        }
    }
}