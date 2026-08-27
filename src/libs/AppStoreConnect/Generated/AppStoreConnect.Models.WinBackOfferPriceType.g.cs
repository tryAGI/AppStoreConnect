
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum WinBackOfferPriceType
    {
        /// <summary>
        /// 
        /// </summary>
        WinBackOfferPrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WinBackOfferPriceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WinBackOfferPriceType value)
        {
            return value switch
            {
                WinBackOfferPriceType.WinBackOfferPrices => "winBackOfferPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WinBackOfferPriceType? ToEnum(string value)
        {
            return value switch
            {
                "winBackOfferPrices" => WinBackOfferPriceType.WinBackOfferPrices,
                _ => null,
            };
        }
    }
}