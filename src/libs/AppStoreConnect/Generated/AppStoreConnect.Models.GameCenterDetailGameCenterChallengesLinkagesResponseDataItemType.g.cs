
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailGameCenterChallengesLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterChallenges,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailGameCenterChallengesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailGameCenterChallengesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                GameCenterDetailGameCenterChallengesLinkagesResponseDataItemType.GameCenterChallenges => "gameCenterChallenges",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailGameCenterChallengesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallenges" => GameCenterDetailGameCenterChallengesLinkagesResponseDataItemType.GameCenterChallenges,
                _ => null,
            };
        }
    }
}