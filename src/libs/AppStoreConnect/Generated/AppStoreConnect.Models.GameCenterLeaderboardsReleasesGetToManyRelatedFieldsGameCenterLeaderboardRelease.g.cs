
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardsReleasesGetToManyRelatedFieldsGameCenterLeaderboardRelease
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
    public static class GameCenterLeaderboardsReleasesGetToManyRelatedFieldsGameCenterLeaderboardReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardsReleasesGetToManyRelatedFieldsGameCenterLeaderboardRelease value)
        {
            return value switch
            {
                GameCenterLeaderboardsReleasesGetToManyRelatedFieldsGameCenterLeaderboardRelease.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardsReleasesGetToManyRelatedFieldsGameCenterLeaderboardRelease.GameCenterLeaderboard => "gameCenterLeaderboard",
                GameCenterLeaderboardsReleasesGetToManyRelatedFieldsGameCenterLeaderboardRelease.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardsReleasesGetToManyRelatedFieldsGameCenterLeaderboardRelease? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterLeaderboardsReleasesGetToManyRelatedFieldsGameCenterLeaderboardRelease.GameCenterDetail,
                "gameCenterLeaderboard" => GameCenterLeaderboardsReleasesGetToManyRelatedFieldsGameCenterLeaderboardRelease.GameCenterLeaderboard,
                "live" => GameCenterLeaderboardsReleasesGetToManyRelatedFieldsGameCenterLeaderboardRelease.Live,
                _ => null,
            };
        }
    }
}