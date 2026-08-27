
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease
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
    public static class GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSetReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease.GameCenterLeaderboardSet => "gameCenterLeaderboardSet",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease.GameCenterDetail,
                "gameCenterLeaderboardSet" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease.GameCenterLeaderboardSet,
                "live" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease.Live,
                _ => null,
            };
        }
    }
}