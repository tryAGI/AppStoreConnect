
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterEnabledVersionCompatibleVersionsLinkagesRequestDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterEnabledVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterEnabledVersionCompatibleVersionsLinkagesRequestDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterEnabledVersionCompatibleVersionsLinkagesRequestDataItemType value)
        {
            return value switch
            {
                GameCenterEnabledVersionCompatibleVersionsLinkagesRequestDataItemType.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterEnabledVersionCompatibleVersionsLinkagesRequestDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterEnabledVersions" => GameCenterEnabledVersionCompatibleVersionsLinkagesRequestDataItemType.GameCenterEnabledVersions,
                _ => null,
            };
        }
    }
}