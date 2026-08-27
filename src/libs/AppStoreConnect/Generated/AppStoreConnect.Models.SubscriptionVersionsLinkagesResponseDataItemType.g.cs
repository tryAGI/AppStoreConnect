
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionVersionsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionVersionsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionVersionsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                SubscriptionVersionsLinkagesResponseDataItemType.SubscriptionVersions => "subscriptionVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionVersionsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionVersions" => SubscriptionVersionsLinkagesResponseDataItemType.SubscriptionVersions,
                _ => null,
            };
        }
    }
}