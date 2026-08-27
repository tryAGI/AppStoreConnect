
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppPriceSchedulesGetInstanceFieldsAppPriceSchedule
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
    public static class AppPriceSchedulesGetInstanceFieldsAppPriceScheduleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPriceSchedulesGetInstanceFieldsAppPriceSchedule value)
        {
            return value switch
            {
                AppPriceSchedulesGetInstanceFieldsAppPriceSchedule.App => "app",
                AppPriceSchedulesGetInstanceFieldsAppPriceSchedule.AutomaticPrices => "automaticPrices",
                AppPriceSchedulesGetInstanceFieldsAppPriceSchedule.BaseTerritory => "baseTerritory",
                AppPriceSchedulesGetInstanceFieldsAppPriceSchedule.ManualPrices => "manualPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPriceSchedulesGetInstanceFieldsAppPriceSchedule? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppPriceSchedulesGetInstanceFieldsAppPriceSchedule.App,
                "automaticPrices" => AppPriceSchedulesGetInstanceFieldsAppPriceSchedule.AutomaticPrices,
                "baseTerritory" => AppPriceSchedulesGetInstanceFieldsAppPriceSchedule.BaseTerritory,
                "manualPrices" => AppPriceSchedulesGetInstanceFieldsAppPriceSchedule.ManualPrices,
                _ => null,
            };
        }
    }
}