
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppPriceV2InlineCreateType
    {
        /// <summary>
        ///
        /// </summary>
        AppPrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPriceV2InlineCreateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPriceV2InlineCreateType value)
        {
            return value switch
            {
                AppPriceV2InlineCreateType.AppPrices => "appPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPriceV2InlineCreateType? ToEnum(string value)
        {
            return value switch
            {
                "appPrices" => AppPriceV2InlineCreateType.AppPrices,
                _ => null,
            };
        }
    }
}