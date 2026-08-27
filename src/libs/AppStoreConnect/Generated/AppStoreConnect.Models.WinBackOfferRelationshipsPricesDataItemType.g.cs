
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum WinBackOfferRelationshipsPricesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        WinBackOfferPrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WinBackOfferRelationshipsPricesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WinBackOfferRelationshipsPricesDataItemType value)
        {
            return value switch
            {
                WinBackOfferRelationshipsPricesDataItemType.WinBackOfferPrices => "winBackOfferPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WinBackOfferRelationshipsPricesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "winBackOfferPrices" => WinBackOfferRelationshipsPricesDataItemType.WinBackOfferPrices,
                _ => null,
            };
        }
    }
}