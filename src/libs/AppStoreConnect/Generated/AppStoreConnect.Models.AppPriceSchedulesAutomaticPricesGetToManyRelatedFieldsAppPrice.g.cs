
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPrice
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
    public static class AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPriceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPrice value)
        {
            return value switch
            {
                AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPrice.AppPricePoint => "appPricePoint",
                AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPrice.EndDate => "endDate",
                AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPrice.Manual => "manual",
                AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPrice.StartDate => "startDate",
                AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPrice.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPrice? ToEnum(string value)
        {
            return value switch
            {
                "appPricePoint" => AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPrice.AppPricePoint,
                "endDate" => AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPrice.EndDate,
                "manual" => AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPrice.Manual,
                "startDate" => AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPrice.StartDate,
                "territory" => AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPrice.Territory,
                _ => null,
            };
        }
    }
}