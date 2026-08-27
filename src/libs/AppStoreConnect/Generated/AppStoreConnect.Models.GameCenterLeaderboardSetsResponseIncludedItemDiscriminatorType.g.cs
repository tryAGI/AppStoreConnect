
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardSetsResponseIncludedItemDiscriminatorType
    {
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
        GameCenterLeaderboardSetLocalizations,
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardSetReleases,
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardSets,
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboards,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterLeaderboardSetsResponseIncludedItemDiscriminatorType.GameCenterDetails => "gameCenterDetails",
                GameCenterLeaderboardSetsResponseIncludedItemDiscriminatorType.GameCenterGroups => "gameCenterGroups",
                GameCenterLeaderboardSetsResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSetLocalizations => "gameCenterLeaderboardSetLocalizations",
                GameCenterLeaderboardSetsResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSetReleases => "gameCenterLeaderboardSetReleases",
                GameCenterLeaderboardSetsResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterLeaderboardSetsResponseIncludedItemDiscriminatorType.GameCenterLeaderboards => "gameCenterLeaderboards",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetails" => GameCenterLeaderboardSetsResponseIncludedItemDiscriminatorType.GameCenterDetails,
                "gameCenterGroups" => GameCenterLeaderboardSetsResponseIncludedItemDiscriminatorType.GameCenterGroups,
                "gameCenterLeaderboardSetLocalizations" => GameCenterLeaderboardSetsResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSetLocalizations,
                "gameCenterLeaderboardSetReleases" => GameCenterLeaderboardSetsResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSetReleases,
                "gameCenterLeaderboardSets" => GameCenterLeaderboardSetsResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSets,
                "gameCenterLeaderboards" => GameCenterLeaderboardSetsResponseIncludedItemDiscriminatorType.GameCenterLeaderboards,
                _ => null,
            };
        }
    }
}