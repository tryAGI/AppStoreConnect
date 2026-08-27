
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease
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
    public static class GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease.GameCenterLeaderboardSet => "gameCenterLeaderboardSet",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease.GameCenterDetail,
                "gameCenterLeaderboardSet" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease.GameCenterLeaderboardSet,
                "live" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease.Live,
                _ => null,
            };
        }
    }
}