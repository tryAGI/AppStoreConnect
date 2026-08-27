
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum WinBackOfferPricesLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        WinBackOfferPrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WinBackOfferPricesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WinBackOfferPricesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                WinBackOfferPricesLinkagesResponseDataItemType.WinBackOfferPrices => "winBackOfferPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WinBackOfferPricesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "winBackOfferPrices" => WinBackOfferPricesLinkagesResponseDataItemType.WinBackOfferPrices,
                _ => null,
            };
        }
    }
}