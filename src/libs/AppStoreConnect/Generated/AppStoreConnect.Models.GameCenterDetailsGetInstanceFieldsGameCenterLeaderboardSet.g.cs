
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSet
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
    public static class GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSet value)
        {
            return value switch
            {
                GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSet.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSet.GameCenterGroup => "gameCenterGroup",
                GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSet.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSet.GroupLeaderboardSet => "groupLeaderboardSet",
                GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSet.Localizations => "localizations",
                GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSet.ReferenceName => "referenceName",
                GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSet.Releases => "releases",
                GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSet.VendorIdentifier => "vendorIdentifier",
                GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSet.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSet? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSet.GameCenterDetail,
                "gameCenterGroup" => GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSet.GameCenterGroup,
                "gameCenterLeaderboards" => GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSet.GameCenterLeaderboards,
                "groupLeaderboardSet" => GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSet.GroupLeaderboardSet,
                "localizations" => GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSet.Localizations,
                "referenceName" => GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSet.ReferenceName,
                "releases" => GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSet.Releases,
                "vendorIdentifier" => GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSet.VendorIdentifier,
                "versions" => GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSet.Versions,
                _ => null,
            };
        }
    }
}