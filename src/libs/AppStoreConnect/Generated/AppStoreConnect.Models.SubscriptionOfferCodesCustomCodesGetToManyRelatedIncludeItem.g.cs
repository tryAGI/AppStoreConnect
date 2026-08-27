
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionOfferCodesCustomCodesGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        OfferCode,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionOfferCodesCustomCodesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodesCustomCodesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                SubscriptionOfferCodesCustomCodesGetToManyRelatedIncludeItem.OfferCode => "offerCode",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodesCustomCodesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "offerCode" => SubscriptionOfferCodesCustomCodesGetToManyRelatedIncludeItem.OfferCode,
                _ => null,
            };
        }
    }
}