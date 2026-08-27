
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPrice
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
    public static class AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPriceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPrice value)
        {
            return value switch
            {
                AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPrice.AppPricePoint => "appPricePoint",
                AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPrice.EndDate => "endDate",
                AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPrice.Manual => "manual",
                AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPrice.StartDate => "startDate",
                AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPrice.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPrice? ToEnum(string value)
        {
            return value switch
            {
                "appPricePoint" => AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPrice.AppPricePoint,
                "endDate" => AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPrice.EndDate,
                "manual" => AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPrice.Manual,
                "startDate" => AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPrice.StartDate,
                "territory" => AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPrice.Territory,
                _ => null,
            };
        }
    }
}