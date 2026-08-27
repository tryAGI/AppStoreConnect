
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum MarketplaceSearchDetailUpdateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        MarketplaceSearchDetails,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MarketplaceSearchDetailUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MarketplaceSearchDetailUpdateRequestDataType value)
        {
            return value switch
            {
                MarketplaceSearchDetailUpdateRequestDataType.MarketplaceSearchDetails => "marketplaceSearchDetails",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MarketplaceSearchDetailUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "marketplaceSearchDetails" => MarketplaceSearchDetailUpdateRequestDataType.MarketplaceSearchDetails,
                _ => null,
            };
        }
    }
}