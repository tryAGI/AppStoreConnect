
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionOffersResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        RetentionOfferPrices,
        /// <summary>
        ///
        /// </summary>
        Subscriptions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionOffersResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionOffersResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                RetentionOffersResponseIncludedItemDiscriminatorType.RetentionOfferPrices => "retentionOfferPrices",
                RetentionOffersResponseIncludedItemDiscriminatorType.Subscriptions => "subscriptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionOffersResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "retentionOfferPrices" => RetentionOffersResponseIncludedItemDiscriminatorType.RetentionOfferPrices,
                "subscriptions" => RetentionOffersResponseIncludedItemDiscriminatorType.Subscriptions,
                _ => null,
            };
        }
    }
}