
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardV2GameCenterScoreModerationsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterScoreModerations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardV2GameCenterScoreModerationsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardV2GameCenterScoreModerationsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                GameCenterLeaderboardV2GameCenterScoreModerationsLinkagesResponseDataItemType.GameCenterScoreModerations => "gameCenterScoreModerations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardV2GameCenterScoreModerationsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterScoreModerations" => GameCenterLeaderboardV2GameCenterScoreModerationsLinkagesResponseDataItemType.GameCenterScoreModerations,
                _ => null,
            };
        }
    }
}