
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterDetail,
        /// <summary>
        /// 
        /// </summary>
        GameCenterGroup,
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboards,
        /// <summary>
        /// 
        /// </summary>
        GroupLeaderboardSet,
        /// <summary>
        /// 
        /// </summary>
        Localizations,
        /// <summary>
        /// 
        /// </summary>
        Releases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedIncludeItem.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedIncludeItem.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedIncludeItem.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedIncludeItem.GroupLeaderboardSet => "groupLeaderboardSet",
                GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedIncludeItem.Localizations => "localizations",
                GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedIncludeItem.Releases => "releases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedIncludeItem.GameCenterDetail,
                "gameCenterGroup" => GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedIncludeItem.GameCenterGroup,
                "gameCenterLeaderboards" => GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedIncludeItem.GameCenterLeaderboards,
                "groupLeaderboardSet" => GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedIncludeItem.GroupLeaderboardSet,
                "localizations" => GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedIncludeItem.Localizations,
                "releases" => GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedIncludeItem.Releases,
                _ => null,
            };
        }
    }
}