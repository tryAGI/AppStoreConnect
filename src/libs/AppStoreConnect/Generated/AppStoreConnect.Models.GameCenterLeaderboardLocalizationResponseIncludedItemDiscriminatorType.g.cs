
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardLocalizationResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardImages,
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboards,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardLocalizationResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardLocalizationResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterLeaderboardLocalizationResponseIncludedItemDiscriminatorType.GameCenterLeaderboardImages => "gameCenterLeaderboardImages",
                GameCenterLeaderboardLocalizationResponseIncludedItemDiscriminatorType.GameCenterLeaderboards => "gameCenterLeaderboards",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardLocalizationResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardImages" => GameCenterLeaderboardLocalizationResponseIncludedItemDiscriminatorType.GameCenterLeaderboardImages,
                "gameCenterLeaderboards" => GameCenterLeaderboardLocalizationResponseIncludedItemDiscriminatorType.GameCenterLeaderboards,
                _ => null,
            };
        }
    }
}