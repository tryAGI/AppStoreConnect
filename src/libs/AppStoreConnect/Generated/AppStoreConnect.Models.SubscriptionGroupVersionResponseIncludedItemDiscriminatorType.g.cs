
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionGroupVersionResponseIncludedItemDiscriminatorType
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
    public static class SubscriptionGroupVersionResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupVersionResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                SubscriptionGroupVersionResponseIncludedItemDiscriminatorType.SubscriptionGroupLocalizations => "subscriptionGroupLocalizations",
                SubscriptionGroupVersionResponseIncludedItemDiscriminatorType.SubscriptionGroups => "subscriptionGroups",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupVersionResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionGroupLocalizations" => SubscriptionGroupVersionResponseIncludedItemDiscriminatorType.SubscriptionGroupLocalizations,
                "subscriptionGroups" => SubscriptionGroupVersionResponseIncludedItemDiscriminatorType.SubscriptionGroups,
                _ => null,
            };
        }
    }
}