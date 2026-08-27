
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetRelease
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterDetail,
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSet,
        /// <summary>
        ///
        /// </summary>
        Live,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetRelease value)
        {
            return value switch
            {
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetRelease.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetRelease.GameCenterLeaderboardSet => "gameCenterLeaderboardSet",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetRelease.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetRelease? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetRelease.GameCenterDetail,
                "gameCenterLeaderboardSet" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetRelease.GameCenterLeaderboardSet,
                "live" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetRelease.Live,
                _ => null,
            };
        }
    }
}