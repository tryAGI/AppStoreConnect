
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGetCollectionFieldsGameCenterLeaderboardSet
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
    public static class GameCenterGroupsGetCollectionFieldsGameCenterLeaderboardSetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGetCollectionFieldsGameCenterLeaderboardSet value)
        {
            return value switch
            {
                GameCenterGroupsGetCollectionFieldsGameCenterLeaderboardSet.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGetCollectionFieldsGameCenterLeaderboardSet.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGetCollectionFieldsGameCenterLeaderboardSet.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterGroupsGetCollectionFieldsGameCenterLeaderboardSet.GroupLeaderboardSet => "groupLeaderboardSet",
                GameCenterGroupsGetCollectionFieldsGameCenterLeaderboardSet.Localizations => "localizations",
                GameCenterGroupsGetCollectionFieldsGameCenterLeaderboardSet.ReferenceName => "referenceName",
                GameCenterGroupsGetCollectionFieldsGameCenterLeaderboardSet.Releases => "releases",
                GameCenterGroupsGetCollectionFieldsGameCenterLeaderboardSet.VendorIdentifier => "vendorIdentifier",
                GameCenterGroupsGetCollectionFieldsGameCenterLeaderboardSet.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGetCollectionFieldsGameCenterLeaderboardSet? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterGroupsGetCollectionFieldsGameCenterLeaderboardSet.GameCenterDetail,
                "gameCenterGroup" => GameCenterGroupsGetCollectionFieldsGameCenterLeaderboardSet.GameCenterGroup,
                "gameCenterLeaderboards" => GameCenterGroupsGetCollectionFieldsGameCenterLeaderboardSet.GameCenterLeaderboards,
                "groupLeaderboardSet" => GameCenterGroupsGetCollectionFieldsGameCenterLeaderboardSet.GroupLeaderboardSet,
                "localizations" => GameCenterGroupsGetCollectionFieldsGameCenterLeaderboardSet.Localizations,
                "referenceName" => GameCenterGroupsGetCollectionFieldsGameCenterLeaderboardSet.ReferenceName,
                "releases" => GameCenterGroupsGetCollectionFieldsGameCenterLeaderboardSet.Releases,
                "vendorIdentifier" => GameCenterGroupsGetCollectionFieldsGameCenterLeaderboardSet.VendorIdentifier,
                "versions" => GameCenterGroupsGetCollectionFieldsGameCenterLeaderboardSet.Versions,
                _ => null,
            };
        }
    }
}