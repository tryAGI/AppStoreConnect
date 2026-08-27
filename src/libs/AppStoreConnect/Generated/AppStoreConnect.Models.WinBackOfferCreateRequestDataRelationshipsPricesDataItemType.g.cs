
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum WinBackOfferCreateRequestDataRelationshipsPricesDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        WinBackOfferPrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WinBackOfferCreateRequestDataRelationshipsPricesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WinBackOfferCreateRequestDataRelationshipsPricesDataItemType value)
        {
            return value switch
            {
                WinBackOfferCreateRequestDataRelationshipsPricesDataItemType.WinBackOfferPrices => "winBackOfferPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WinBackOfferCreateRequestDataRelationshipsPricesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "winBackOfferPrices" => WinBackOfferCreateRequestDataRelationshipsPricesDataItemType.WinBackOfferPrices,
                _ => null,
            };
        }
    }
}