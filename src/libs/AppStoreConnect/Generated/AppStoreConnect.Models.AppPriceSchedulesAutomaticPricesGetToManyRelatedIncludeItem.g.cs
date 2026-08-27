
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppPriceSchedulesAutomaticPricesGetToManyRelatedIncludeItem
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
    public static class AppPriceSchedulesAutomaticPricesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPriceSchedulesAutomaticPricesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppPriceSchedulesAutomaticPricesGetToManyRelatedIncludeItem.AppPricePoint => "appPricePoint",
                AppPriceSchedulesAutomaticPricesGetToManyRelatedIncludeItem.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPriceSchedulesAutomaticPricesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appPricePoint" => AppPriceSchedulesAutomaticPricesGetToManyRelatedIncludeItem.AppPricePoint,
                "territory" => AppPriceSchedulesAutomaticPricesGetToManyRelatedIncludeItem.Territory,
                _ => null,
            };
        }
    }
}