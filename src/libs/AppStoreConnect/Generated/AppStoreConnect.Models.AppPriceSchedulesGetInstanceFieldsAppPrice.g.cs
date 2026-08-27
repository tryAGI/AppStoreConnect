
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppPriceSchedulesGetInstanceFieldsAppPrice
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
    public static class AppPriceSchedulesGetInstanceFieldsAppPriceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPriceSchedulesGetInstanceFieldsAppPrice value)
        {
            return value switch
            {
                AppPriceSchedulesGetInstanceFieldsAppPrice.AppPricePoint => "appPricePoint",
                AppPriceSchedulesGetInstanceFieldsAppPrice.EndDate => "endDate",
                AppPriceSchedulesGetInstanceFieldsAppPrice.Manual => "manual",
                AppPriceSchedulesGetInstanceFieldsAppPrice.StartDate => "startDate",
                AppPriceSchedulesGetInstanceFieldsAppPrice.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPriceSchedulesGetInstanceFieldsAppPrice? ToEnum(string value)
        {
            return value switch
            {
                "appPricePoint" => AppPriceSchedulesGetInstanceFieldsAppPrice.AppPricePoint,
                "endDate" => AppPriceSchedulesGetInstanceFieldsAppPrice.EndDate,
                "manual" => AppPriceSchedulesGetInstanceFieldsAppPrice.Manual,
                "startDate" => AppPriceSchedulesGetInstanceFieldsAppPrice.StartDate,
                "territory" => AppPriceSchedulesGetInstanceFieldsAppPrice.Territory,
                _ => null,
            };
        }
    }
}