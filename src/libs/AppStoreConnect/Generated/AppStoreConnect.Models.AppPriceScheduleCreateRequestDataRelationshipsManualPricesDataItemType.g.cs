
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppPriceScheduleCreateRequestDataRelationshipsManualPricesDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppPrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPriceScheduleCreateRequestDataRelationshipsManualPricesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPriceScheduleCreateRequestDataRelationshipsManualPricesDataItemType value)
        {
            return value switch
            {
                AppPriceScheduleCreateRequestDataRelationshipsManualPricesDataItemType.AppPrices => "appPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPriceScheduleCreateRequestDataRelationshipsManualPricesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appPrices" => AppPriceScheduleCreateRequestDataRelationshipsManualPricesDataItemType.AppPrices,
                _ => null,
            };
        }
    }
}