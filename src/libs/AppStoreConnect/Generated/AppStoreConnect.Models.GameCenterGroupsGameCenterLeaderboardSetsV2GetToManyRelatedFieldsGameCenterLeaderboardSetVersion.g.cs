
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersion
    {
        /// <summary>
        ///
        /// </summary>
        LeaderboardSet,
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
    public static class GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersion value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersion.LeaderboardSet => "leaderboardSet",
                GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersion.Localizations => "localizations",
                GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersion.State => "state",
                GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersion? ToEnum(string value)
        {
            return value switch
            {
                "leaderboardSet" => GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersion.LeaderboardSet,
                "localizations" => GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersion.Localizations,
                "state" => GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersion.State,
                "version" => GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersion.Version,
                _ => null,
            };
        }
    }
}