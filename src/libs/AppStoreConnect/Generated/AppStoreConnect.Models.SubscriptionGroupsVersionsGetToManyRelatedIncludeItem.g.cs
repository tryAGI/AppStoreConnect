
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupsVersionsGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Localizations,
        /// <summary>
        ///
        /// </summary>
        SubscriptionGroup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGroupsVersionsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupsVersionsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                SubscriptionGroupsVersionsGetToManyRelatedIncludeItem.Localizations => "localizations",
                SubscriptionGroupsVersionsGetToManyRelatedIncludeItem.SubscriptionGroup => "subscriptionGroup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupsVersionsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "localizations" => SubscriptionGroupsVersionsGetToManyRelatedIncludeItem.Localizations,
                "subscriptionGroup" => SubscriptionGroupsVersionsGetToManyRelatedIncludeItem.SubscriptionGroup,
                _ => null,
            };
        }
    }
}