
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardV2CreateRequestDataAttributesScoreSortType
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
    public static class GameCenterLeaderboardV2CreateRequestDataAttributesScoreSortTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardV2CreateRequestDataAttributesScoreSortType value)
        {
            return value switch
            {
                GameCenterLeaderboardV2CreateRequestDataAttributesScoreSortType.Asc => "ASC",
                GameCenterLeaderboardV2CreateRequestDataAttributesScoreSortType.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardV2CreateRequestDataAttributesScoreSortType? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => GameCenterLeaderboardV2CreateRequestDataAttributesScoreSortType.Asc,
                "DESC" => GameCenterLeaderboardV2CreateRequestDataAttributesScoreSortType.Desc,
                _ => null,
            };
        }
    }
}