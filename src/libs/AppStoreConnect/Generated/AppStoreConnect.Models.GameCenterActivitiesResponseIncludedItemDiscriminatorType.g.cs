
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivitiesResponseIncludedItemDiscriminatorType
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
    public static class GameCenterActivitiesResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivitiesResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterActivitiesResponseIncludedItemDiscriminatorType.GameCenterAchievements => "gameCenterAchievements",
                GameCenterActivitiesResponseIncludedItemDiscriminatorType.GameCenterActivityVersions => "gameCenterActivityVersions",
                GameCenterActivitiesResponseIncludedItemDiscriminatorType.GameCenterDetails => "gameCenterDetails",
                GameCenterActivitiesResponseIncludedItemDiscriminatorType.GameCenterGroups => "gameCenterGroups",
                GameCenterActivitiesResponseIncludedItemDiscriminatorType.GameCenterLeaderboards => "gameCenterLeaderboards",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivitiesResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievements" => GameCenterActivitiesResponseIncludedItemDiscriminatorType.GameCenterAchievements,
                "gameCenterActivityVersions" => GameCenterActivitiesResponseIncludedItemDiscriminatorType.GameCenterActivityVersions,
                "gameCenterDetails" => GameCenterActivitiesResponseIncludedItemDiscriminatorType.GameCenterDetails,
                "gameCenterGroups" => GameCenterActivitiesResponseIncludedItemDiscriminatorType.GameCenterGroups,
                "gameCenterLeaderboards" => GameCenterActivitiesResponseIncludedItemDiscriminatorType.GameCenterLeaderboards,
                _ => null,
            };
        }
    }
}