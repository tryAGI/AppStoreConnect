
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionOfferResponseIncludedItemDiscriminatorType
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
    public static class RetentionOfferResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionOfferResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                RetentionOfferResponseIncludedItemDiscriminatorType.RetentionOfferPrices => "retentionOfferPrices",
                RetentionOfferResponseIncludedItemDiscriminatorType.Subscriptions => "subscriptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionOfferResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "retentionOfferPrices" => RetentionOfferResponseIncludedItemDiscriminatorType.RetentionOfferPrices,
                "subscriptions" => RetentionOfferResponseIncludedItemDiscriminatorType.Subscriptions,
                _ => null,
            };
        }
    }
}