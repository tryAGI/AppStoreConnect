
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardLocalizationsV2ResponseIncludedItemDiscriminatorType
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
    public static class GameCenterLeaderboardLocalizationsV2ResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardLocalizationsV2ResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterLeaderboardLocalizationsV2ResponseIncludedItemDiscriminatorType.GameCenterLeaderboardImages => "gameCenterLeaderboardImages",
                GameCenterLeaderboardLocalizationsV2ResponseIncludedItemDiscriminatorType.GameCenterLeaderboardVersions => "gameCenterLeaderboardVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardLocalizationsV2ResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardImages" => GameCenterLeaderboardLocalizationsV2ResponseIncludedItemDiscriminatorType.GameCenterLeaderboardImages,
                "gameCenterLeaderboardVersions" => GameCenterLeaderboardLocalizationsV2ResponseIncludedItemDiscriminatorType.GameCenterLeaderboardVersions,
                _ => null,
            };
        }
    }
}