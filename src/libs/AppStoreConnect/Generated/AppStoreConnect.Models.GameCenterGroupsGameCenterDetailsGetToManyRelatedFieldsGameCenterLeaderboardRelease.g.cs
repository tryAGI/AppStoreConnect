
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardRelease
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterDetail,
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboard,
        /// <summary>
        ///
        /// </summary>
        Live,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardRelease value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardRelease.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardRelease.GameCenterLeaderboard => "gameCenterLeaderboard",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardRelease.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardRelease? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardRelease.GameCenterDetail,
                "gameCenterLeaderboard" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardRelease.GameCenterLeaderboard,
                "live" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardRelease.Live,
                _ => null,
            };
        }
    }
}