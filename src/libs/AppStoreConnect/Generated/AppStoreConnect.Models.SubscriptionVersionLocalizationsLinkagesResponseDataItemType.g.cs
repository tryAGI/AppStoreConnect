
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionVersionLocalizationsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionVersionLocalizationsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionVersionLocalizationsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                SubscriptionVersionLocalizationsLinkagesResponseDataItemType.SubscriptionLocalizations => "subscriptionLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionVersionLocalizationsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionLocalizations" => SubscriptionVersionLocalizationsLinkagesResponseDataItemType.SubscriptionLocalizations,
                _ => null,
            };
        }
    }
}