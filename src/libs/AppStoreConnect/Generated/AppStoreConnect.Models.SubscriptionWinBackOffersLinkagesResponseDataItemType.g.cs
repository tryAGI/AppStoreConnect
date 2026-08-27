
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionWinBackOffersLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        WinBackOffers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionWinBackOffersLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionWinBackOffersLinkagesResponseDataItemType value)
        {
            return value switch
            {
                SubscriptionWinBackOffersLinkagesResponseDataItemType.WinBackOffers => "winBackOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionWinBackOffersLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "winBackOffers" => SubscriptionWinBackOffersLinkagesResponseDataItemType.WinBackOffers,
                _ => null,
            };
        }
    }
}