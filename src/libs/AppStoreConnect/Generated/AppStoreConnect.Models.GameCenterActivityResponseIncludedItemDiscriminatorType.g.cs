
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterActivityResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterAchievements,
        /// <summary>
        /// 
        /// </summary>
        GameCenterActivityVersions,
        /// <summary>
        /// 
        /// </summary>
        GameCenterDetails,
        /// <summary>
        /// 
        /// </summary>
        GameCenterGroups,
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboards,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivityResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterActivityResponseIncludedItemDiscriminatorType.GameCenterAchievements => "gameCenterAchievements",
                GameCenterActivityResponseIncludedItemDiscriminatorType.GameCenterActivityVersions => "gameCenterActivityVersions",
                GameCenterActivityResponseIncludedItemDiscriminatorType.GameCenterDetails => "gameCenterDetails",
                GameCenterActivityResponseIncludedItemDiscriminatorType.GameCenterGroups => "gameCenterGroups",
                GameCenterActivityResponseIncludedItemDiscriminatorType.GameCenterLeaderboards => "gameCenterLeaderboards",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievements" => GameCenterActivityResponseIncludedItemDiscriminatorType.GameCenterAchievements,
                "gameCenterActivityVersions" => GameCenterActivityResponseIncludedItemDiscriminatorType.GameCenterActivityVersions,
                "gameCenterDetails" => GameCenterActivityResponseIncludedItemDiscriminatorType.GameCenterDetails,
                "gameCenterGroups" => GameCenterActivityResponseIncludedItemDiscriminatorType.GameCenterGroups,
                "gameCenterLeaderboards" => GameCenterActivityResponseIncludedItemDiscriminatorType.GameCenterLeaderboards,
                _ => null,
            };
        }
    }
}