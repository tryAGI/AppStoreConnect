
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionVersionRelationshipsLocalizationsDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionVersionRelationshipsLocalizationsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionVersionRelationshipsLocalizationsDataItemType value)
        {
            return value switch
            {
                SubscriptionVersionRelationshipsLocalizationsDataItemType.SubscriptionLocalizations => "subscriptionLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionVersionRelationshipsLocalizationsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionLocalizations" => SubscriptionVersionRelationshipsLocalizationsDataItemType.SubscriptionLocalizations,
                _ => null,
            };
        }
    }
}