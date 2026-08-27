
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupGameCenterChallengesLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterChallenges,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterGroupGameCenterChallengesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupGameCenterChallengesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                GameCenterGroupGameCenterChallengesLinkagesResponseDataItemType.GameCenterChallenges => "gameCenterChallenges",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupGameCenterChallengesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallenges" => GameCenterGroupGameCenterChallengesLinkagesResponseDataItemType.GameCenterChallenges,
                _ => null,
            };
        }
    }
}