
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionVersionsResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionImages,
        /// <summary>
        ///
        /// </summary>
        SubscriptionLocalizations,
        /// <summary>
        ///
        /// </summary>
        Subscriptions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionVersionsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionVersionsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                SubscriptionVersionsResponseIncludedItemDiscriminatorType.SubscriptionImages => "subscriptionImages",
                SubscriptionVersionsResponseIncludedItemDiscriminatorType.SubscriptionLocalizations => "subscriptionLocalizations",
                SubscriptionVersionsResponseIncludedItemDiscriminatorType.Subscriptions => "subscriptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionVersionsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionImages" => SubscriptionVersionsResponseIncludedItemDiscriminatorType.SubscriptionImages,
                "subscriptionLocalizations" => SubscriptionVersionsResponseIncludedItemDiscriminatorType.SubscriptionLocalizations,
                "subscriptions" => SubscriptionVersionsResponseIncludedItemDiscriminatorType.Subscriptions,
                _ => null,
            };
        }
    }
}