
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupResponseIncludedItemDiscriminatorType
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
    public static class SubscriptionGroupResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                SubscriptionGroupResponseIncludedItemDiscriminatorType.SubscriptionGroupLocalizations => "subscriptionGroupLocalizations",
                SubscriptionGroupResponseIncludedItemDiscriminatorType.SubscriptionGroupVersions => "subscriptionGroupVersions",
                SubscriptionGroupResponseIncludedItemDiscriminatorType.Subscriptions => "subscriptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionGroupLocalizations" => SubscriptionGroupResponseIncludedItemDiscriminatorType.SubscriptionGroupLocalizations,
                "subscriptionGroupVersions" => SubscriptionGroupResponseIncludedItemDiscriminatorType.SubscriptionGroupVersions,
                "subscriptions" => SubscriptionGroupResponseIncludedItemDiscriminatorType.Subscriptions,
                _ => null,
            };
        }
    }
}