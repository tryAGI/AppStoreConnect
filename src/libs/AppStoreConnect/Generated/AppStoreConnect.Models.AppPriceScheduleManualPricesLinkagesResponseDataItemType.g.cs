
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppPriceScheduleManualPricesLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppPrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPriceScheduleManualPricesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPriceScheduleManualPricesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppPriceScheduleManualPricesLinkagesResponseDataItemType.AppPrices => "appPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPriceScheduleManualPricesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appPrices" => AppPriceScheduleManualPricesLinkagesResponseDataItemType.AppPrices,
                _ => null,
            };
        }
    }
}