
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSet
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSet value)
        {
            return value switch
            {
                GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSet.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSet.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSet.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSet.GroupLeaderboardSet => "groupLeaderboardSet",
                GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSet.Localizations => "localizations",
                GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSet.ReferenceName => "referenceName",
                GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSet.Releases => "releases",
                GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSet.VendorIdentifier => "vendorIdentifier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSet? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSet.GameCenterDetail,
                "gameCenterGroup" => GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSet.GameCenterGroup,
                "gameCenterLeaderboards" => GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSet.GameCenterLeaderboards,
                "groupLeaderboardSet" => GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSet.GroupLeaderboardSet,
                "localizations" => GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSet.Localizations,
                "referenceName" => GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSet.ReferenceName,
                "releases" => GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSet.Releases,
                "vendorIdentifier" => GameCenterLeaderboardSetsGetInstanceFieldsGameCenterLeaderboardSet.VendorIdentifier,
                _ => null,
            };
        }
    }
}