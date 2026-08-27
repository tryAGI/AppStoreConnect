
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsAppPriceScheduleGetToOneRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        App,
        /// <summary>
        /// 
        /// </summary>
        AutomaticPrices,
        /// <summary>
        /// 
        /// </summary>
        BaseTerritory,
        /// <summary>
        /// 
        /// </summary>
        ManualPrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsAppPriceScheduleGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppPriceScheduleGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                AppsAppPriceScheduleGetToOneRelatedIncludeItem.App => "app",
                AppsAppPriceScheduleGetToOneRelatedIncludeItem.AutomaticPrices => "automaticPrices",
                AppsAppPriceScheduleGetToOneRelatedIncludeItem.BaseTerritory => "baseTerritory",
                AppsAppPriceScheduleGetToOneRelatedIncludeItem.ManualPrices => "manualPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppPriceScheduleGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsAppPriceScheduleGetToOneRelatedIncludeItem.App,
                "automaticPrices" => AppsAppPriceScheduleGetToOneRelatedIncludeItem.AutomaticPrices,
                "baseTerritory" => AppsAppPriceScheduleGetToOneRelatedIncludeItem.BaseTerritory,
                "manualPrices" => AppsAppPriceScheduleGetToOneRelatedIncludeItem.ManualPrices,
                _ => null,
            };
        }
    }
}