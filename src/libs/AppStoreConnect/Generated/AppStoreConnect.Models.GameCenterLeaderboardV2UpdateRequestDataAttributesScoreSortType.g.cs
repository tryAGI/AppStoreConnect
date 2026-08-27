
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardV2UpdateRequestDataAttributesScoreSortType
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
    public static class GameCenterLeaderboardV2UpdateRequestDataAttributesScoreSortTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardV2UpdateRequestDataAttributesScoreSortType value)
        {
            return value switch
            {
                GameCenterLeaderboardV2UpdateRequestDataAttributesScoreSortType.Asc => "ASC",
                GameCenterLeaderboardV2UpdateRequestDataAttributesScoreSortType.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardV2UpdateRequestDataAttributesScoreSortType? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => GameCenterLeaderboardV2UpdateRequestDataAttributesScoreSortType.Asc,
                "DESC" => GameCenterLeaderboardV2UpdateRequestDataAttributesScoreSortType.Desc,
                _ => null,
            };
        }
    }
}