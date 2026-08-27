
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardVersion
    {
        /// <summary>
        ///
        /// </summary>
        Leaderboard,
        /// <summary>
        ///
        /// </summary>
        Localizations,
        /// <summary>
        ///
        /// </summary>
        State,
        /// <summary>
        ///
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardVersion value)
        {
            return value switch
            {
                GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardVersion.Leaderboard => "leaderboard",
                GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardVersion.Localizations => "localizations",
                GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardVersion.State => "state",
                GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardVersion? ToEnum(string value)
        {
            return value switch
            {
                "leaderboard" => GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardVersion.Leaderboard,
                "localizations" => GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardVersion.Localizations,
                "state" => GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardVersion.State,
                "version" => GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardVersion.Version,
                _ => null,
            };
        }
    }
}