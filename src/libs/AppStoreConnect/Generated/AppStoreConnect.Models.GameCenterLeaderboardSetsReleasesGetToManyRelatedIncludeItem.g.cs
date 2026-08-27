
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetsReleasesGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterDetail,
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetsReleasesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetsReleasesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterLeaderboardSetsReleasesGetToManyRelatedIncludeItem.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardSetsReleasesGetToManyRelatedIncludeItem.GameCenterLeaderboardSet => "gameCenterLeaderboardSet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetsReleasesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterLeaderboardSetsReleasesGetToManyRelatedIncludeItem.GameCenterDetail,
                "gameCenterLeaderboardSet" => GameCenterLeaderboardSetsReleasesGetToManyRelatedIncludeItem.GameCenterLeaderboardSet,
                _ => null,
            };
        }
    }
}