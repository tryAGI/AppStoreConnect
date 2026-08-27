
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppMarketplaceSearchDetailLinkageResponseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        MarketplaceSearchDetails,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppMarketplaceSearchDetailLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppMarketplaceSearchDetailLinkageResponseDataType value)
        {
            return value switch
            {
                AppMarketplaceSearchDetailLinkageResponseDataType.MarketplaceSearchDetails => "marketplaceSearchDetails",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppMarketplaceSearchDetailLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "marketplaceSearchDetails" => AppMarketplaceSearchDetailLinkageResponseDataType.MarketplaceSearchDetails,
                _ => null,
            };
        }
    }
}