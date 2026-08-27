
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAppPriceScheduleGetToOneRelatedFieldsAppPrice
    {
        /// <summary>
        ///
        /// </summary>
        AppPricePoint,
        /// <summary>
        ///
        /// </summary>
        EndDate,
        /// <summary>
        ///
        /// </summary>
        Manual,
        /// <summary>
        ///
        /// </summary>
        StartDate,
        /// <summary>
        ///
        /// </summary>
        Territory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsAppPriceScheduleGetToOneRelatedFieldsAppPriceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppPriceScheduleGetToOneRelatedFieldsAppPrice value)
        {
            return value switch
            {
                AppsAppPriceScheduleGetToOneRelatedFieldsAppPrice.AppPricePoint => "appPricePoint",
                AppsAppPriceScheduleGetToOneRelatedFieldsAppPrice.EndDate => "endDate",
                AppsAppPriceScheduleGetToOneRelatedFieldsAppPrice.Manual => "manual",
                AppsAppPriceScheduleGetToOneRelatedFieldsAppPrice.StartDate => "startDate",
                AppsAppPriceScheduleGetToOneRelatedFieldsAppPrice.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppPriceScheduleGetToOneRelatedFieldsAppPrice? ToEnum(string value)
        {
            return value switch
            {
                "appPricePoint" => AppsAppPriceScheduleGetToOneRelatedFieldsAppPrice.AppPricePoint,
                "endDate" => AppsAppPriceScheduleGetToOneRelatedFieldsAppPrice.EndDate,
                "manual" => AppsAppPriceScheduleGetToOneRelatedFieldsAppPrice.Manual,
                "startDate" => AppsAppPriceScheduleGetToOneRelatedFieldsAppPrice.StartDate,
                "territory" => AppsAppPriceScheduleGetToOneRelatedFieldsAppPrice.Territory,
                _ => null,
            };
        }
    }
}