
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSet
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
    public static class GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSet value)
        {
            return value switch
            {
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSet.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSet.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSet.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSet.GroupLeaderboardSet => "groupLeaderboardSet",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSet.Localizations => "localizations",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSet.ReferenceName => "referenceName",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSet.Releases => "releases",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSet.VendorIdentifier => "vendorIdentifier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSet? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSet.GameCenterDetail,
                "gameCenterGroup" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSet.GameCenterGroup,
                "gameCenterLeaderboards" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSet.GameCenterLeaderboards,
                "groupLeaderboardSet" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSet.GroupLeaderboardSet,
                "localizations" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSet.Localizations,
                "referenceName" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSet.ReferenceName,
                "releases" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSet.Releases,
                "vendorIdentifier" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardSet.VendorIdentifier,
                _ => null,
            };
        }
    }
}