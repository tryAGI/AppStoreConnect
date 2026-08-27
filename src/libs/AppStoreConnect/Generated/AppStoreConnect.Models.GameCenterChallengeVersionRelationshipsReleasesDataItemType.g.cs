
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterChallengeVersionRelationshipsReleasesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterChallengeVersionReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengeVersionRelationshipsReleasesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeVersionRelationshipsReleasesDataItemType value)
        {
            return value switch
            {
                GameCenterChallengeVersionRelationshipsReleasesDataItemType.GameCenterChallengeVersionReleases => "gameCenterChallengeVersionReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeVersionRelationshipsReleasesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterChallengeVersionReleases" => GameCenterChallengeVersionRelationshipsReleasesDataItemType.GameCenterChallengeVersionReleases,
                _ => null,
            };
        }
    }
}