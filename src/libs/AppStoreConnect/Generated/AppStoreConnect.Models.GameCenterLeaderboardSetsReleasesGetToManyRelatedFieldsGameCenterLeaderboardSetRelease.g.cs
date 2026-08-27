
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetRelease
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
    public static class GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetRelease value)
        {
            return value switch
            {
                GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetRelease.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetRelease.GameCenterLeaderboardSet => "gameCenterLeaderboardSet",
                GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetRelease.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetRelease? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetRelease.GameCenterDetail,
                "gameCenterLeaderboardSet" => GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetRelease.GameCenterLeaderboardSet,
                "live" => GameCenterLeaderboardSetsReleasesGetToManyRelatedFieldsGameCenterLeaderboardSetRelease.Live,
                _ => null,
            };
        }
    }
}