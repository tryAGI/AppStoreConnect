
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppPriceScheduleRelationshipsManualPricesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppPrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPriceScheduleRelationshipsManualPricesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPriceScheduleRelationshipsManualPricesDataItemType value)
        {
            return value switch
            {
                AppPriceScheduleRelationshipsManualPricesDataItemType.AppPrices => "appPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPriceScheduleRelationshipsManualPricesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appPrices" => AppPriceScheduleRelationshipsManualPricesDataItemType.AppPrices,
                _ => null,
            };
        }
    }
}