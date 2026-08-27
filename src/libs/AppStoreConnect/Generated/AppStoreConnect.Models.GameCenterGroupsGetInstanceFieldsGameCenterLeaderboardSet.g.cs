
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterGroupsGetInstanceFieldsGameCenterLeaderboardSet
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
        ReferenceName,
        /// <summary>
        /// 
        /// </summary>
        Releases,
        /// <summary>
        /// 
        /// </summary>
        VendorIdentifier,
        /// <summary>
        /// 
        /// </summary>
        Versions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterGroupsGetInstanceFieldsGameCenterLeaderboardSetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGetInstanceFieldsGameCenterLeaderboardSet value)
        {
            return value switch
            {
                GameCenterGroupsGetInstanceFieldsGameCenterLeaderboardSet.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGetInstanceFieldsGameCenterLeaderboardSet.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGetInstanceFieldsGameCenterLeaderboardSet.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterGroupsGetInstanceFieldsGameCenterLeaderboardSet.GroupLeaderboardSet => "groupLeaderboardSet",
                GameCenterGroupsGetInstanceFieldsGameCenterLeaderboardSet.Localizations => "localizations",
                GameCenterGroupsGetInstanceFieldsGameCenterLeaderboardSet.ReferenceName => "referenceName",
                GameCenterGroupsGetInstanceFieldsGameCenterLeaderboardSet.Releases => "releases",
                GameCenterGroupsGetInstanceFieldsGameCenterLeaderboardSet.VendorIdentifier => "vendorIdentifier",
                GameCenterGroupsGetInstanceFieldsGameCenterLeaderboardSet.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGetInstanceFieldsGameCenterLeaderboardSet? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterGroupsGetInstanceFieldsGameCenterLeaderboardSet.GameCenterDetail,
                "gameCenterGroup" => GameCenterGroupsGetInstanceFieldsGameCenterLeaderboardSet.GameCenterGroup,
                "gameCenterLeaderboards" => GameCenterGroupsGetInstanceFieldsGameCenterLeaderboardSet.GameCenterLeaderboards,
                "groupLeaderboardSet" => GameCenterGroupsGetInstanceFieldsGameCenterLeaderboardSet.GroupLeaderboardSet,
                "localizations" => GameCenterGroupsGetInstanceFieldsGameCenterLeaderboardSet.Localizations,
                "referenceName" => GameCenterGroupsGetInstanceFieldsGameCenterLeaderboardSet.ReferenceName,
                "releases" => GameCenterGroupsGetInstanceFieldsGameCenterLeaderboardSet.Releases,
                "vendorIdentifier" => GameCenterGroupsGetInstanceFieldsGameCenterLeaderboardSet.VendorIdentifier,
                "versions" => GameCenterGroupsGetInstanceFieldsGameCenterLeaderboardSet.Versions,
                _ => null,
            };
        }
    }
}