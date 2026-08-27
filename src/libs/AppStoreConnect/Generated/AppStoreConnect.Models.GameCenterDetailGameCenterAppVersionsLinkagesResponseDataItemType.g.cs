
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailGameCenterAppVersionsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAppVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailGameCenterAppVersionsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailGameCenterAppVersionsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                GameCenterDetailGameCenterAppVersionsLinkagesResponseDataItemType.GameCenterAppVersions => "gameCenterAppVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailGameCenterAppVersionsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAppVersions" => GameCenterDetailGameCenterAppVersionsLinkagesResponseDataItemType.GameCenterAppVersions,
                _ => null,
            };
        }
    }
}