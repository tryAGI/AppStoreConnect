
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionOffersPricesGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionPricePoint,
        /// <summary>
        ///
        /// </summary>
        Territory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionOffersPricesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionOffersPricesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                RetentionOffersPricesGetToManyRelatedIncludeItem.SubscriptionPricePoint => "subscriptionPricePoint",
                RetentionOffersPricesGetToManyRelatedIncludeItem.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionOffersPricesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPricePoint" => RetentionOffersPricesGetToManyRelatedIncludeItem.SubscriptionPricePoint,
                "territory" => RetentionOffersPricesGetToManyRelatedIncludeItem.Territory,
                _ => null,
            };
        }
    }
}