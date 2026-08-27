
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardV2AttributesScoreSortType
    {
        /// <summary>
        ///
        /// </summary>
        Asc,
        /// <summary>
        ///
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardV2AttributesScoreSortTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardV2AttributesScoreSortType value)
        {
            return value switch
            {
                GameCenterLeaderboardV2AttributesScoreSortType.Asc => "ASC",
                GameCenterLeaderboardV2AttributesScoreSortType.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardV2AttributesScoreSortType? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => GameCenterLeaderboardV2AttributesScoreSortType.Asc,
                "DESC" => GameCenterLeaderboardV2AttributesScoreSortType.Desc,
                _ => null,
            };
        }
    }
}