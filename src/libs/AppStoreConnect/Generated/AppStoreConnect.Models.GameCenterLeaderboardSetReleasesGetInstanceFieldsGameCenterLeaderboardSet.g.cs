
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterLeaderboardSet
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
    public static class GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterLeaderboardSetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterLeaderboardSet value)
        {
            return value switch
            {
                GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterLeaderboardSet.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterLeaderboardSet.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterLeaderboardSet.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterLeaderboardSet.GroupLeaderboardSet => "groupLeaderboardSet",
                GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterLeaderboardSet.Localizations => "localizations",
                GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterLeaderboardSet.ReferenceName => "referenceName",
                GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterLeaderboardSet.Releases => "releases",
                GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterLeaderboardSet.VendorIdentifier => "vendorIdentifier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterLeaderboardSet? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterLeaderboardSet.GameCenterDetail,
                "gameCenterGroup" => GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterLeaderboardSet.GameCenterGroup,
                "gameCenterLeaderboards" => GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterLeaderboardSet.GameCenterLeaderboards,
                "groupLeaderboardSet" => GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterLeaderboardSet.GroupLeaderboardSet,
                "localizations" => GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterLeaderboardSet.Localizations,
                "referenceName" => GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterLeaderboardSet.ReferenceName,
                "releases" => GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterLeaderboardSet.Releases,
                "vendorIdentifier" => GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterLeaderboardSet.VendorIdentifier,
                _ => null,
            };
        }
    }
}