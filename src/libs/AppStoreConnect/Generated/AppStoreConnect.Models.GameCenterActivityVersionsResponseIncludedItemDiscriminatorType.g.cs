
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivityVersionsResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterActivities,
        /// <summary>
        ///
        /// </summary>
        GameCenterActivityImages,
        /// <summary>
        ///
        /// </summary>
        GameCenterActivityLocalizations,
        /// <summary>
        ///
        /// </summary>
        GameCenterActivityVersionReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivityVersionsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityVersionsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterActivityVersionsResponseIncludedItemDiscriminatorType.GameCenterActivities => "gameCenterActivities",
                GameCenterActivityVersionsResponseIncludedItemDiscriminatorType.GameCenterActivityImages => "gameCenterActivityImages",
                GameCenterActivityVersionsResponseIncludedItemDiscriminatorType.GameCenterActivityLocalizations => "gameCenterActivityLocalizations",
                GameCenterActivityVersionsResponseIncludedItemDiscriminatorType.GameCenterActivityVersionReleases => "gameCenterActivityVersionReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityVersionsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivities" => GameCenterActivityVersionsResponseIncludedItemDiscriminatorType.GameCenterActivities,
                "gameCenterActivityImages" => GameCenterActivityVersionsResponseIncludedItemDiscriminatorType.GameCenterActivityImages,
                "gameCenterActivityLocalizations" => GameCenterActivityVersionsResponseIncludedItemDiscriminatorType.GameCenterActivityLocalizations,
                "gameCenterActivityVersionReleases" => GameCenterActivityVersionsResponseIncludedItemDiscriminatorType.GameCenterActivityVersionReleases,
                _ => null,
            };
        }
    }
}