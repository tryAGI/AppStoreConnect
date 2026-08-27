
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionGroup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedIncludeItem.SubscriptionGroup => "subscriptionGroup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionGroup" => SubscriptionGroupsSubscriptionGroupLocalizationsGetToManyRelatedIncludeItem.SubscriptionGroup,
                _ => null,
            };
        }
    }
}