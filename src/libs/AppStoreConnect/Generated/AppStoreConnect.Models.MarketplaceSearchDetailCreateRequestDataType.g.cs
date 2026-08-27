
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum MarketplaceSearchDetailCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        MarketplaceSearchDetails,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MarketplaceSearchDetailCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MarketplaceSearchDetailCreateRequestDataType value)
        {
            return value switch
            {
                MarketplaceSearchDetailCreateRequestDataType.MarketplaceSearchDetails => "marketplaceSearchDetails",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MarketplaceSearchDetailCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "marketplaceSearchDetails" => MarketplaceSearchDetailCreateRequestDataType.MarketplaceSearchDetails,
                _ => null,
            };
        }
    }
}