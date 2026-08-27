
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailChallengeReleasesLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterChallengeVersionReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailChallengeReleasesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailChallengeReleasesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                GameCenterDetailChallengeReleasesLinkagesResponseDataItemType.GameCenterChallengeVersionReleases => "gameCenterChallengeVersionReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailChallengeReleasesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallengeVersionReleases" => GameCenterDetailChallengeReleasesLinkagesResponseDataItemType.GameCenterChallengeVersionReleases,
                _ => null,
            };
        }
    }
}