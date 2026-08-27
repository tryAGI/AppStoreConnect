
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupsResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionGroupLocalizations,
        /// <summary>
        ///
        /// </summary>
        SubscriptionGroupVersions,
        /// <summary>
        ///
        /// </summary>
        Subscriptions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGroupsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                SubscriptionGroupsResponseIncludedItemDiscriminatorType.SubscriptionGroupLocalizations => "subscriptionGroupLocalizations",
                SubscriptionGroupsResponseIncludedItemDiscriminatorType.SubscriptionGroupVersions => "subscriptionGroupVersions",
                SubscriptionGroupsResponseIncludedItemDiscriminatorType.Subscriptions => "subscriptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionGroupLocalizations" => SubscriptionGroupsResponseIncludedItemDiscriminatorType.SubscriptionGroupLocalizations,
                "subscriptionGroupVersions" => SubscriptionGroupsResponseIncludedItemDiscriminatorType.SubscriptionGroupVersions,
                "subscriptions" => SubscriptionGroupsResponseIncludedItemDiscriminatorType.Subscriptions,
                _ => null,
            };
        }
    }
}