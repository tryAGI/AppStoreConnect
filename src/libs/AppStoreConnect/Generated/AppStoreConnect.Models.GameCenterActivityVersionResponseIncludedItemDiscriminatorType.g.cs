
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterActivityVersionResponseIncludedItemDiscriminatorType
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
    public static class GameCenterActivityVersionResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityVersionResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterActivityVersionResponseIncludedItemDiscriminatorType.GameCenterActivities => "gameCenterActivities",
                GameCenterActivityVersionResponseIncludedItemDiscriminatorType.GameCenterActivityImages => "gameCenterActivityImages",
                GameCenterActivityVersionResponseIncludedItemDiscriminatorType.GameCenterActivityLocalizations => "gameCenterActivityLocalizations",
                GameCenterActivityVersionResponseIncludedItemDiscriminatorType.GameCenterActivityVersionReleases => "gameCenterActivityVersionReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityVersionResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivities" => GameCenterActivityVersionResponseIncludedItemDiscriminatorType.GameCenterActivities,
                "gameCenterActivityImages" => GameCenterActivityVersionResponseIncludedItemDiscriminatorType.GameCenterActivityImages,
                "gameCenterActivityLocalizations" => GameCenterActivityVersionResponseIncludedItemDiscriminatorType.GameCenterActivityLocalizations,
                "gameCenterActivityVersionReleases" => GameCenterActivityVersionResponseIncludedItemDiscriminatorType.GameCenterActivityVersionReleases,
                _ => null,
            };
        }
    }
}