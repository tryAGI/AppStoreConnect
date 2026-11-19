
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPriceChangePreviewCreateRequestDataRelationshipsSubscriptionDataType
    {
        /// <summary>
        ///
        /// </summary>
        Subscriptions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPriceChangePreviewCreateRequestDataRelationshipsSubscriptionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPriceChangePreviewCreateRequestDataRelationshipsSubscriptionDataType value)
        {
            return value switch
            {
                SubscriptionPriceChangePreviewCreateRequestDataRelationshipsSubscriptionDataType.Subscriptions => "subscriptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPriceChangePreviewCreateRequestDataRelationshipsSubscriptionDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptions" => SubscriptionPriceChangePreviewCreateRequestDataRelationshipsSubscriptionDataType.Subscriptions,
                _ => null,
            };
        }
    }
}