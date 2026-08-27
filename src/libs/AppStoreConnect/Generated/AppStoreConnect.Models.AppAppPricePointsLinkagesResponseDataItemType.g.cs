
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppAppPricePointsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppPricePoints,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAppPricePointsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAppPricePointsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppAppPricePointsLinkagesResponseDataItemType.AppPricePoints => "appPricePoints",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAppPricePointsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appPricePoints" => AppAppPricePointsLinkagesResponseDataItemType.AppPricePoints,
                _ => null,
            };
        }
    }
}