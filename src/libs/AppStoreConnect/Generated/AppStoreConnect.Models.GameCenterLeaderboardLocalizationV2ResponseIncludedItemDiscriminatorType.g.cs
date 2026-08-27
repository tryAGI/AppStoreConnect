
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardLocalizationV2ResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardImages,
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardLocalizationV2ResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardLocalizationV2ResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterLeaderboardLocalizationV2ResponseIncludedItemDiscriminatorType.GameCenterLeaderboardImages => "gameCenterLeaderboardImages",
                GameCenterLeaderboardLocalizationV2ResponseIncludedItemDiscriminatorType.GameCenterLeaderboardVersions => "gameCenterLeaderboardVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardLocalizationV2ResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardImages" => GameCenterLeaderboardLocalizationV2ResponseIncludedItemDiscriminatorType.GameCenterLeaderboardImages,
                "gameCenterLeaderboardVersions" => GameCenterLeaderboardLocalizationV2ResponseIncludedItemDiscriminatorType.GameCenterLeaderboardVersions,
                _ => null,
            };
        }
    }
}