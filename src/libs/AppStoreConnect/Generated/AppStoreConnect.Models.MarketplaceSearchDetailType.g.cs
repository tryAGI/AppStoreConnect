
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum MarketplaceSearchDetailType
    {
        /// <summary>
        /// 
        /// </summary>
        MarketplaceSearchDetails,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MarketplaceSearchDetailTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MarketplaceSearchDetailType value)
        {
            return value switch
            {
                MarketplaceSearchDetailType.MarketplaceSearchDetails => "marketplaceSearchDetails",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MarketplaceSearchDetailType? ToEnum(string value)
        {
            return value switch
            {
                "marketplaceSearchDetails" => MarketplaceSearchDetailType.MarketplaceSearchDetails,
                _ => null,
            };
        }
    }
}