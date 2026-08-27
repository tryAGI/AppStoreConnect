
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAppVersionCompatibilityVersionsLinkagesRequestDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAppVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAppVersionCompatibilityVersionsLinkagesRequestDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAppVersionCompatibilityVersionsLinkagesRequestDataItemType value)
        {
            return value switch
            {
                GameCenterAppVersionCompatibilityVersionsLinkagesRequestDataItemType.GameCenterAppVersions => "gameCenterAppVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAppVersionCompatibilityVersionsLinkagesRequestDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAppVersions" => GameCenterAppVersionCompatibilityVersionsLinkagesRequestDataItemType.GameCenterAppVersions,
                _ => null,
            };
        }
    }
}