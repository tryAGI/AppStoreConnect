
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Player,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedIncludeItem.Player => "player",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "player" => GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedIncludeItem.Player,
                _ => null,
            };
        }
    }
}