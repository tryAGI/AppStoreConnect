
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterEnabledVersionRelationshipsCompatibleVersionsDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterEnabledVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterEnabledVersionRelationshipsCompatibleVersionsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterEnabledVersionRelationshipsCompatibleVersionsDataItemType value)
        {
            return value switch
            {
                GameCenterEnabledVersionRelationshipsCompatibleVersionsDataItemType.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterEnabledVersionRelationshipsCompatibleVersionsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterEnabledVersions" => GameCenterEnabledVersionRelationshipsCompatibleVersionsDataItemType.GameCenterEnabledVersions,
                _ => null,
            };
        }
    }
}