
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardSetLocalizationsV2ResponseIncludedItemDiscriminatorType
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
    public static class GameCenterLeaderboardSetLocalizationsV2ResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetLocalizationsV2ResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterLeaderboardSetLocalizationsV2ResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSetImages => "gameCenterLeaderboardSetImages",
                GameCenterLeaderboardSetLocalizationsV2ResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSetVersions => "gameCenterLeaderboardSetVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetLocalizationsV2ResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSetImages" => GameCenterLeaderboardSetLocalizationsV2ResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSetImages,
                "gameCenterLeaderboardSetVersions" => GameCenterLeaderboardSetLocalizationsV2ResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSetVersions,
                _ => null,
            };
        }
    }
}