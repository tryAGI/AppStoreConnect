
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppPricePointsV3GetInstanceIncludeItem
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
    public static class AppPricePointsV3GetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPricePointsV3GetInstanceIncludeItem value)
        {
            return value switch
            {
                AppPricePointsV3GetInstanceIncludeItem.App => "app",
                AppPricePointsV3GetInstanceIncludeItem.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPricePointsV3GetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppPricePointsV3GetInstanceIncludeItem.App,
                "territory" => AppPricePointsV3GetInstanceIncludeItem.Territory,
                _ => null,
            };
        }
    }
}