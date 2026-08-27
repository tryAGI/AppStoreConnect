
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppPricePointV3EqualizationsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppPricePoints,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPricePointV3EqualizationsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPricePointV3EqualizationsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppPricePointV3EqualizationsLinkagesResponseDataItemType.AppPricePoints => "appPricePoints",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPricePointV3EqualizationsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appPricePoints" => AppPricePointV3EqualizationsLinkagesResponseDataItemType.AppPricePoints,
                _ => null,
            };
        }
    }
}