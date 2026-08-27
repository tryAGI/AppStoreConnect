
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppPriceSchedulesGetInstanceIncludeItem
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
    public static class AppPriceSchedulesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPriceSchedulesGetInstanceIncludeItem value)
        {
            return value switch
            {
                AppPriceSchedulesGetInstanceIncludeItem.App => "app",
                AppPriceSchedulesGetInstanceIncludeItem.AutomaticPrices => "automaticPrices",
                AppPriceSchedulesGetInstanceIncludeItem.BaseTerritory => "baseTerritory",
                AppPriceSchedulesGetInstanceIncludeItem.ManualPrices => "manualPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPriceSchedulesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppPriceSchedulesGetInstanceIncludeItem.App,
                "automaticPrices" => AppPriceSchedulesGetInstanceIncludeItem.AutomaticPrices,
                "baseTerritory" => AppPriceSchedulesGetInstanceIncludeItem.BaseTerritory,
                "manualPrices" => AppPriceSchedulesGetInstanceIncludeItem.ManualPrices,
                _ => null,
            };
        }
    }
}