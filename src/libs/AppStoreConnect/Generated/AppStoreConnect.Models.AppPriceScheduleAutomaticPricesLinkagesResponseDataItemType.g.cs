
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppPriceScheduleAutomaticPricesLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppPrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPriceScheduleAutomaticPricesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPriceScheduleAutomaticPricesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppPriceScheduleAutomaticPricesLinkagesResponseDataItemType.AppPrices => "appPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPriceScheduleAutomaticPricesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appPrices" => AppPriceScheduleAutomaticPricesLinkagesResponseDataItemType.AppPrices,
                _ => null,
            };
        }
    }
}