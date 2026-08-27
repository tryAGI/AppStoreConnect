
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionVersionResponseIncludedItemDiscriminatorType
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
    public static class SubscriptionVersionResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionVersionResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                SubscriptionVersionResponseIncludedItemDiscriminatorType.SubscriptionImages => "subscriptionImages",
                SubscriptionVersionResponseIncludedItemDiscriminatorType.SubscriptionLocalizations => "subscriptionLocalizations",
                SubscriptionVersionResponseIncludedItemDiscriminatorType.Subscriptions => "subscriptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionVersionResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionImages" => SubscriptionVersionResponseIncludedItemDiscriminatorType.SubscriptionImages,
                "subscriptionLocalizations" => SubscriptionVersionResponseIncludedItemDiscriminatorType.SubscriptionLocalizations,
                "subscriptions" => SubscriptionVersionResponseIncludedItemDiscriminatorType.Subscriptions,
                _ => null,
            };
        }
    }
}