
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionGroupLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemType value)
        {
            return value switch
            {
                SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemType.SubscriptionGroupLocalizations => "subscriptionGroupLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionGroupLocalizations" => SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemType.SubscriptionGroupLocalizations,
                _ => null,
            };
        }
    }
}