
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionGroupVersionLocalizationsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionGroupLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGroupVersionLocalizationsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupVersionLocalizationsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                SubscriptionGroupVersionLocalizationsLinkagesResponseDataItemType.SubscriptionGroupLocalizations => "subscriptionGroupLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupVersionLocalizationsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionGroupLocalizations" => SubscriptionGroupVersionLocalizationsLinkagesResponseDataItemType.SubscriptionGroupLocalizations,
                _ => null,
            };
        }
    }
}