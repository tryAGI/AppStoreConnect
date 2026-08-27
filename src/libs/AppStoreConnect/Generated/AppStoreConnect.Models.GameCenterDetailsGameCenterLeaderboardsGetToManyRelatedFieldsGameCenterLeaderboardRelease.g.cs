
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease
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
    public static class GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease.GameCenterLeaderboard => "gameCenterLeaderboard",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease.GameCenterDetail,
                "gameCenterLeaderboard" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease.GameCenterLeaderboard,
                "live" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardRelease.Live,
                _ => null,
            };
        }
    }
}