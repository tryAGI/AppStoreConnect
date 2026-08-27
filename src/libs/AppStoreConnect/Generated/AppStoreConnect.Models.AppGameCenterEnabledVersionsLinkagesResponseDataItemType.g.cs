
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppGameCenterEnabledVersionsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterEnabledVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppGameCenterEnabledVersionsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppGameCenterEnabledVersionsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppGameCenterEnabledVersionsLinkagesResponseDataItemType.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppGameCenterEnabledVersionsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterEnabledVersions" => AppGameCenterEnabledVersionsLinkagesResponseDataItemType.GameCenterEnabledVersions,
                _ => null,
            };
        }
    }
}