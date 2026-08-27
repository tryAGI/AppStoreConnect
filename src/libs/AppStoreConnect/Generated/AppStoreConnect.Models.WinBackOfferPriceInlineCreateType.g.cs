
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum WinBackOfferPriceInlineCreateType
    {
        /// <summary>
        /// 
        /// </summary>
        WinBackOfferPrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WinBackOfferPriceInlineCreateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WinBackOfferPriceInlineCreateType value)
        {
            return value switch
            {
                WinBackOfferPriceInlineCreateType.WinBackOfferPrices => "winBackOfferPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WinBackOfferPriceInlineCreateType? ToEnum(string value)
        {
            return value switch
            {
                "winBackOfferPrices" => WinBackOfferPriceInlineCreateType.WinBackOfferPrices,
                _ => null,
            };
        }
    }
}