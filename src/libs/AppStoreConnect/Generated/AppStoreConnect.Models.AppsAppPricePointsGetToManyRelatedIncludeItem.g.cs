
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsAppPricePointsGetToManyRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        App,
        /// <summary>
        /// 
        /// </summary>
        Territory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsAppPricePointsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppPricePointsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppsAppPricePointsGetToManyRelatedIncludeItem.App => "app",
                AppsAppPricePointsGetToManyRelatedIncludeItem.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppPricePointsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsAppPricePointsGetToManyRelatedIncludeItem.App,
                "territory" => AppsAppPricePointsGetToManyRelatedIncludeItem.Territory,
                _ => null,
            };
        }
    }
}