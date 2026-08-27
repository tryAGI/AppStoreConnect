
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionRelationshipsSubscriptionLocalizationsDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionRelationshipsSubscriptionLocalizationsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionRelationshipsSubscriptionLocalizationsDataItemType value)
        {
            return value switch
            {
                SubscriptionRelationshipsSubscriptionLocalizationsDataItemType.SubscriptionLocalizations => "subscriptionLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionRelationshipsSubscriptionLocalizationsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionLocalizations" => SubscriptionRelationshipsSubscriptionLocalizationsDataItemType.SubscriptionLocalizations,
                _ => null,
            };
        }
    }
}