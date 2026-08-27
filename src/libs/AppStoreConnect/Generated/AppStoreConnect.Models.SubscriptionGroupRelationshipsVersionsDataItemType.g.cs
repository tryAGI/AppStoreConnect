
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupRelationshipsVersionsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionGroupVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGroupRelationshipsVersionsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupRelationshipsVersionsDataItemType value)
        {
            return value switch
            {
                SubscriptionGroupRelationshipsVersionsDataItemType.SubscriptionGroupVersions => "subscriptionGroupVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupRelationshipsVersionsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionGroupVersions" => SubscriptionGroupRelationshipsVersionsDataItemType.SubscriptionGroupVersions,
                _ => null,
            };
        }
    }
}