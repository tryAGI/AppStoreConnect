
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppPriceScheduleRelationshipsAutomaticPricesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppPrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPriceScheduleRelationshipsAutomaticPricesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPriceScheduleRelationshipsAutomaticPricesDataItemType value)
        {
            return value switch
            {
                AppPriceScheduleRelationshipsAutomaticPricesDataItemType.AppPrices => "appPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPriceScheduleRelationshipsAutomaticPricesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appPrices" => AppPriceScheduleRelationshipsAutomaticPricesDataItemType.AppPrices,
                _ => null,
            };
        }
    }
}