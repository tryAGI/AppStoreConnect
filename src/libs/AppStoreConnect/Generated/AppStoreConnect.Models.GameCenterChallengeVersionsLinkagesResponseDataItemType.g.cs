
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterChallengeVersionsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterChallengeVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengeVersionsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeVersionsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                GameCenterChallengeVersionsLinkagesResponseDataItemType.GameCenterChallengeVersions => "gameCenterChallengeVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeVersionsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallengeVersions" => GameCenterChallengeVersionsLinkagesResponseDataItemType.GameCenterChallengeVersions,
                _ => null,
            };
        }
    }
}