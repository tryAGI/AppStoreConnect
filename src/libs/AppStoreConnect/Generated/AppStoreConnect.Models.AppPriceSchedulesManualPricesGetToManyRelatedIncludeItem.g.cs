
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppPriceSchedulesManualPricesGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        AppPricePoint,
        /// <summary>
        ///
        /// </summary>
        Territory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPriceSchedulesManualPricesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPriceSchedulesManualPricesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppPriceSchedulesManualPricesGetToManyRelatedIncludeItem.AppPricePoint => "appPricePoint",
                AppPriceSchedulesManualPricesGetToManyRelatedIncludeItem.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPriceSchedulesManualPricesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appPricePoint" => AppPriceSchedulesManualPricesGetToManyRelatedIncludeItem.AppPricePoint,
                "territory" => AppPriceSchedulesManualPricesGetToManyRelatedIncludeItem.Territory,
                _ => null,
            };
        }
    }
}