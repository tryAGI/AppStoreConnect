
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupsSubscriptionsGetToManyRelatedSortItem
    {
        /// <summary>
        ///
        /// </summary>
        Minusname,
        /// <summary>
        ///
        /// </summary>
        Name,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGroupsSubscriptionsGetToManyRelatedSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupsSubscriptionsGetToManyRelatedSortItem value)
        {
            return value switch
            {
                SubscriptionGroupsSubscriptionsGetToManyRelatedSortItem.Minusname => "-name",
                SubscriptionGroupsSubscriptionsGetToManyRelatedSortItem.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupsSubscriptionsGetToManyRelatedSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-name" => SubscriptionGroupsSubscriptionsGetToManyRelatedSortItem.Minusname,
                "name" => SubscriptionGroupsSubscriptionsGetToManyRelatedSortItem.Name,
                _ => null,
            };
        }
    }
}