
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboardSetMemberLocalization
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboard,
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardSet,
        /// <summary>
        /// 
        /// </summary>
        Locale,
        /// <summary>
        /// 
        /// </summary>
        Name,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboardSetMemberLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboardSetMemberLocalization value)
        {
            return value switch
            {
                GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboardSetMemberLocalization.GameCenterLeaderboard => "gameCenterLeaderboard",
                GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboardSetMemberLocalization.GameCenterLeaderboardSet => "gameCenterLeaderboardSet",
                GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboardSetMemberLocalization.Locale => "locale",
                GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboardSetMemberLocalization.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboardSetMemberLocalization? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboard" => GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboardSetMemberLocalization.GameCenterLeaderboard,
                "gameCenterLeaderboardSet" => GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboardSetMemberLocalization.GameCenterLeaderboardSet,
                "locale" => GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboardSetMemberLocalization.Locale,
                "name" => GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboardSetMemberLocalization.Name,
                _ => null,
            };
        }
    }
}