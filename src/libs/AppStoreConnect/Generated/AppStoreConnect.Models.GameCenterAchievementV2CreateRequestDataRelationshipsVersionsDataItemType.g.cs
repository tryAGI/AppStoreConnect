
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementV2CreateRequestDataRelationshipsVersionsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievementVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementV2CreateRequestDataRelationshipsVersionsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementV2CreateRequestDataRelationshipsVersionsDataItemType value)
        {
            return value switch
            {
                GameCenterAchievementV2CreateRequestDataRelationshipsVersionsDataItemType.GameCenterAchievementVersions => "gameCenterAchievementVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementV2CreateRequestDataRelationshipsVersionsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievementVersions" => GameCenterAchievementV2CreateRequestDataRelationshipsVersionsDataItemType.GameCenterAchievementVersions,
                _ => null,
            };
        }
    }
}