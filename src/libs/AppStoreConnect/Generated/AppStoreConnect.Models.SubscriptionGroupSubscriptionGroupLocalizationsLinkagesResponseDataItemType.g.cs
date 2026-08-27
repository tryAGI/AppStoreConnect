
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupSubscriptionGroupLocalizationsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionGroupLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGroupSubscriptionGroupLocalizationsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupSubscriptionGroupLocalizationsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                SubscriptionGroupSubscriptionGroupLocalizationsLinkagesResponseDataItemType.SubscriptionGroupLocalizations => "subscriptionGroupLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupSubscriptionGroupLocalizationsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionGroupLocalizations" => SubscriptionGroupSubscriptionGroupLocalizationsLinkagesResponseDataItemType.SubscriptionGroupLocalizations,
                _ => null,
            };
        }
    }
}