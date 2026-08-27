
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionRelationshipsWinBackOffersDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        WinBackOffers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionRelationshipsWinBackOffersDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionRelationshipsWinBackOffersDataItemType value)
        {
            return value switch
            {
                SubscriptionRelationshipsWinBackOffersDataItemType.WinBackOffers => "winBackOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionRelationshipsWinBackOffersDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "winBackOffers" => SubscriptionRelationshipsWinBackOffersDataItemType.WinBackOffers,
                _ => null,
            };
        }
    }
}