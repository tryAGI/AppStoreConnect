
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSet
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
    public static class AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSet value)
        {
            return value switch
            {
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSet.GameCenterDetail => "gameCenterDetail",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSet.GameCenterGroup => "gameCenterGroup",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSet.GameCenterLeaderboards => "gameCenterLeaderboards",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSet.GroupLeaderboardSet => "groupLeaderboardSet",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSet.Localizations => "localizations",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSet.ReferenceName => "referenceName",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSet.Releases => "releases",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSet.VendorIdentifier => "vendorIdentifier",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSet.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSet? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSet.GameCenterDetail,
                "gameCenterGroup" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSet.GameCenterGroup,
                "gameCenterLeaderboards" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSet.GameCenterLeaderboards,
                "groupLeaderboardSet" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSet.GroupLeaderboardSet,
                "localizations" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSet.Localizations,
                "referenceName" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSet.ReferenceName,
                "releases" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSet.Releases,
                "vendorIdentifier" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSet.VendorIdentifier,
                "versions" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSet.Versions,
                _ => null,
            };
        }
    }
}