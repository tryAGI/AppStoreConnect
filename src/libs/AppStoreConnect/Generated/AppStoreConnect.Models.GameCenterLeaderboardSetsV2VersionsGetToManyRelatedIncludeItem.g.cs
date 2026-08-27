
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardSetsV2VersionsGetToManyRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        LeaderboardSet,
        /// <summary>
        /// 
        /// </summary>
        Localizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetsV2VersionsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetsV2VersionsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterLeaderboardSetsV2VersionsGetToManyRelatedIncludeItem.LeaderboardSet => "leaderboardSet",
                GameCenterLeaderboardSetsV2VersionsGetToManyRelatedIncludeItem.Localizations => "localizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetsV2VersionsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "leaderboardSet" => GameCenterLeaderboardSetsV2VersionsGetToManyRelatedIncludeItem.LeaderboardSet,
                "localizations" => GameCenterLeaderboardSetsV2VersionsGetToManyRelatedIncludeItem.Localizations,
                _ => null,
            };
        }
    }
}