
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppSubscriptionGroupsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionGroups,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppSubscriptionGroupsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppSubscriptionGroupsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppSubscriptionGroupsLinkagesResponseDataItemType.SubscriptionGroups => "subscriptionGroups",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppSubscriptionGroupsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionGroups" => AppSubscriptionGroupsLinkagesResponseDataItemType.SubscriptionGroups,
                _ => null,
            };
        }
    }
}