
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPriceChangePreviewType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionPriceChangePreviews,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPriceChangePreviewTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPriceChangePreviewType value)
        {
            return value switch
            {
                SubscriptionPriceChangePreviewType.SubscriptionPriceChangePreviews => "subscriptionPriceChangePreviews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPriceChangePreviewType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPriceChangePreviews" => SubscriptionPriceChangePreviewType.SubscriptionPriceChangePreviews,
                _ => null,
            };
        }
    }
}