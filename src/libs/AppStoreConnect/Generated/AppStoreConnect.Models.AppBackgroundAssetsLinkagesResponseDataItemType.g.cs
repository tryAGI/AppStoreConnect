
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppBackgroundAssetsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        BackgroundAssets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppBackgroundAssetsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppBackgroundAssetsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppBackgroundAssetsLinkagesResponseDataItemType.BackgroundAssets => "backgroundAssets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppBackgroundAssetsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssets" => AppBackgroundAssetsLinkagesResponseDataItemType.BackgroundAssets,
                _ => null,
            };
        }
    }
}