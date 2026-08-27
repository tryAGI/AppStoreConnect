
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppPricePointsV3EqualizationsGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        App,
        /// <summary>
        ///
        /// </summary>
        Territory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPricePointsV3EqualizationsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPricePointsV3EqualizationsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppPricePointsV3EqualizationsGetToManyRelatedIncludeItem.App => "app",
                AppPricePointsV3EqualizationsGetToManyRelatedIncludeItem.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPricePointsV3EqualizationsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppPricePointsV3EqualizationsGetToManyRelatedIncludeItem.App,
                "territory" => AppPricePointsV3EqualizationsGetToManyRelatedIncludeItem.Territory,
                _ => null,
            };
        }
    }
}