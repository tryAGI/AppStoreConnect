
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetLocalizationResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSetImages,
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetLocalizationResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetLocalizationResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterLeaderboardSetLocalizationResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSetImages => "gameCenterLeaderboardSetImages",
                GameCenterLeaderboardSetLocalizationResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetLocalizationResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSetImages" => GameCenterLeaderboardSetLocalizationResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSetImages,
                "gameCenterLeaderboardSets" => GameCenterLeaderboardSetLocalizationResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSets,
                _ => null,
            };
        }
    }
}