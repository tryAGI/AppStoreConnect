
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetLocalizationV2ResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSetImages,
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSetVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetLocalizationV2ResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetLocalizationV2ResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterLeaderboardSetLocalizationV2ResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSetImages => "gameCenterLeaderboardSetImages",
                GameCenterLeaderboardSetLocalizationV2ResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSetVersions => "gameCenterLeaderboardSetVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetLocalizationV2ResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSetImages" => GameCenterLeaderboardSetLocalizationV2ResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSetImages,
                "gameCenterLeaderboardSetVersions" => GameCenterLeaderboardSetLocalizationV2ResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSetVersions,
                _ => null,
            };
        }
    }
}