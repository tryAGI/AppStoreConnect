
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailRelationshipsChallengeReleasesDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterChallengeVersionReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailRelationshipsChallengeReleasesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailRelationshipsChallengeReleasesDataItemType value)
        {
            return value switch
            {
                GameCenterDetailRelationshipsChallengeReleasesDataItemType.GameCenterChallengeVersionReleases => "gameCenterChallengeVersionReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailRelationshipsChallengeReleasesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallengeVersionReleases" => GameCenterDetailRelationshipsChallengeReleasesDataItemType.GameCenterChallengeVersionReleases,
                _ => null,
            };
        }
    }
}