
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSet
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
        ReferenceName,
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
    public static class GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSet value)
        {
            return value switch
            {
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSet.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSet.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSet.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSet.ReferenceName => "referenceName",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSet.VendorIdentifier => "vendorIdentifier",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSet.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSet? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSet.GameCenterDetail,
                "gameCenterGroup" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSet.GameCenterGroup,
                "gameCenterLeaderboards" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSet.GameCenterLeaderboards,
                "referenceName" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSet.ReferenceName,
                "vendorIdentifier" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSet.VendorIdentifier,
                "versions" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardSet.Versions,
                _ => null,
            };
        }
    }
}