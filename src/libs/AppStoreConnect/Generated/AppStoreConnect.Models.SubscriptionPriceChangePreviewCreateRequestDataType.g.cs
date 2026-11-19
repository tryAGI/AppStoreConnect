
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPriceChangePreviewCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionPriceChangePreviews,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPriceChangePreviewCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPriceChangePreviewCreateRequestDataType value)
        {
            return value switch
            {
                SubscriptionPriceChangePreviewCreateRequestDataType.SubscriptionPriceChangePreviews => "subscriptionPriceChangePreviews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPriceChangePreviewCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPriceChangePreviews" => SubscriptionPriceChangePreviewCreateRequestDataType.SubscriptionPriceChangePreviews,
                _ => null,
            };
        }
    }
}