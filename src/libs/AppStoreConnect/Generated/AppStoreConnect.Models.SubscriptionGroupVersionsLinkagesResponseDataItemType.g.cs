
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionGroupVersionsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionGroupVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGroupVersionsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupVersionsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                SubscriptionGroupVersionsLinkagesResponseDataItemType.SubscriptionGroupVersions => "subscriptionGroupVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupVersionsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionGroupVersions" => SubscriptionGroupVersionsLinkagesResponseDataItemType.SubscriptionGroupVersions,
                _ => null,
            };
        }
    }
}