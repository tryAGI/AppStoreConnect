
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionSubscriptionLocalizationsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionSubscriptionLocalizationsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionSubscriptionLocalizationsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                SubscriptionSubscriptionLocalizationsLinkagesResponseDataItemType.SubscriptionLocalizations => "subscriptionLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionSubscriptionLocalizationsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionLocalizations" => SubscriptionSubscriptionLocalizationsLinkagesResponseDataItemType.SubscriptionLocalizations,
                _ => null,
            };
        }
    }
}