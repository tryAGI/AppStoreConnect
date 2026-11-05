
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionOffersPricesGetToManyRelatedFieldsRetentionOfferPrice
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
    public static class RetentionOffersPricesGetToManyRelatedFieldsRetentionOfferPriceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionOffersPricesGetToManyRelatedFieldsRetentionOfferPrice value)
        {
            return value switch
            {
                RetentionOffersPricesGetToManyRelatedFieldsRetentionOfferPrice.SubscriptionPricePoint => "subscriptionPricePoint",
                RetentionOffersPricesGetToManyRelatedFieldsRetentionOfferPrice.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionOffersPricesGetToManyRelatedFieldsRetentionOfferPrice? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPricePoint" => RetentionOffersPricesGetToManyRelatedFieldsRetentionOfferPrice.SubscriptionPricePoint,
                "territory" => RetentionOffersPricesGetToManyRelatedFieldsRetentionOfferPrice.Territory,
                _ => null,
            };
        }
    }
}