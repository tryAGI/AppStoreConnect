
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease
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
    public static class GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease.GameCenterLeaderboard => "gameCenterLeaderboard",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease.GameCenterDetail,
                "gameCenterLeaderboard" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease.GameCenterLeaderboard,
                "live" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease.Live,
                _ => null,
            };
        }
    }
}