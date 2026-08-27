
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionRelationshipsVersionsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionRelationshipsVersionsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionRelationshipsVersionsDataItemType value)
        {
            return value switch
            {
                SubscriptionRelationshipsVersionsDataItemType.SubscriptionVersions => "subscriptionVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionRelationshipsVersionsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionVersions" => SubscriptionRelationshipsVersionsDataItemType.SubscriptionVersions,
                _ => null,
            };
        }
    }
}