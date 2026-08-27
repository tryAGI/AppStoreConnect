
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppRelationshipsSubscriptionGroupsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionGroups,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppRelationshipsSubscriptionGroupsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppRelationshipsSubscriptionGroupsDataItemType value)
        {
            return value switch
            {
                AppRelationshipsSubscriptionGroupsDataItemType.SubscriptionGroups => "subscriptionGroups",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppRelationshipsSubscriptionGroupsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionGroups" => AppRelationshipsSubscriptionGroupsDataItemType.SubscriptionGroups,
                _ => null,
            };
        }
    }
}