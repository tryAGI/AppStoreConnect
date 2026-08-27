
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardCreateRequestDataAttributesScoreSortType
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
    public static class GameCenterLeaderboardCreateRequestDataAttributesScoreSortTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardCreateRequestDataAttributesScoreSortType value)
        {
            return value switch
            {
                GameCenterLeaderboardCreateRequestDataAttributesScoreSortType.Asc => "ASC",
                GameCenterLeaderboardCreateRequestDataAttributesScoreSortType.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardCreateRequestDataAttributesScoreSortType? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => GameCenterLeaderboardCreateRequestDataAttributesScoreSortType.Asc,
                "DESC" => GameCenterLeaderboardCreateRequestDataAttributesScoreSortType.Desc,
                _ => null,
            };
        }
    }
}