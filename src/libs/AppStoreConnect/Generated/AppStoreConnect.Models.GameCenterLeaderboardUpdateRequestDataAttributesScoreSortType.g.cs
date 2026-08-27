
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardUpdateRequestDataAttributesScoreSortType
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
    public static class GameCenterLeaderboardUpdateRequestDataAttributesScoreSortTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardUpdateRequestDataAttributesScoreSortType value)
        {
            return value switch
            {
                GameCenterLeaderboardUpdateRequestDataAttributesScoreSortType.Asc => "ASC",
                GameCenterLeaderboardUpdateRequestDataAttributesScoreSortType.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardUpdateRequestDataAttributesScoreSortType? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => GameCenterLeaderboardUpdateRequestDataAttributesScoreSortType.Asc,
                "DESC" => GameCenterLeaderboardUpdateRequestDataAttributesScoreSortType.Desc,
                _ => null,
            };
        }
    }
}