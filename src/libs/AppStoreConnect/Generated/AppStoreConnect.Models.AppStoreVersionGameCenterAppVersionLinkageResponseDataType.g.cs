
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionGameCenterAppVersionLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAppVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionGameCenterAppVersionLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionGameCenterAppVersionLinkageResponseDataType value)
        {
            return value switch
            {
                AppStoreVersionGameCenterAppVersionLinkageResponseDataType.GameCenterAppVersions => "gameCenterAppVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionGameCenterAppVersionLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAppVersions" => AppStoreVersionGameCenterAppVersionLinkageResponseDataType.GameCenterAppVersions,
                _ => null,
            };
        }
    }
}