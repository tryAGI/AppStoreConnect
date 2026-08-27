
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAppPriceScheduleGetToOneRelatedFieldsAppPriceSchedule
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
    public static class AppsAppPriceScheduleGetToOneRelatedFieldsAppPriceScheduleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppPriceScheduleGetToOneRelatedFieldsAppPriceSchedule value)
        {
            return value switch
            {
                AppsAppPriceScheduleGetToOneRelatedFieldsAppPriceSchedule.App => "app",
                AppsAppPriceScheduleGetToOneRelatedFieldsAppPriceSchedule.AutomaticPrices => "automaticPrices",
                AppsAppPriceScheduleGetToOneRelatedFieldsAppPriceSchedule.BaseTerritory => "baseTerritory",
                AppsAppPriceScheduleGetToOneRelatedFieldsAppPriceSchedule.ManualPrices => "manualPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppPriceScheduleGetToOneRelatedFieldsAppPriceSchedule? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsAppPriceScheduleGetToOneRelatedFieldsAppPriceSchedule.App,
                "automaticPrices" => AppsAppPriceScheduleGetToOneRelatedFieldsAppPriceSchedule.AutomaticPrices,
                "baseTerritory" => AppsAppPriceScheduleGetToOneRelatedFieldsAppPriceSchedule.BaseTerritory,
                "manualPrices" => AppsAppPriceScheduleGetToOneRelatedFieldsAppPriceSchedule.ManualPrices,
                _ => null,
            };
        }
    }
}