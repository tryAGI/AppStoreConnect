
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupVersionsResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionGroupLocalizations,
        /// <summary>
        ///
        /// </summary>
        SubscriptionGroups,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGroupVersionsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupVersionsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                SubscriptionGroupVersionsResponseIncludedItemDiscriminatorType.SubscriptionGroupLocalizations => "subscriptionGroupLocalizations",
                SubscriptionGroupVersionsResponseIncludedItemDiscriminatorType.SubscriptionGroups => "subscriptionGroups",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupVersionsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionGroupLocalizations" => SubscriptionGroupVersionsResponseIncludedItemDiscriminatorType.SubscriptionGroupLocalizations,
                "subscriptionGroups" => SubscriptionGroupVersionsResponseIncludedItemDiscriminatorType.SubscriptionGroups,
                _ => null,
            };
        }
    }
}