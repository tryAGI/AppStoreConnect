
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSet
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
    public static class GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSet value)
        {
            return value switch
            {
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSet.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSet.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSet.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSet.GroupLeaderboardSet => "groupLeaderboardSet",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSet.Localizations => "localizations",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSet.ReferenceName => "referenceName",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSet.Releases => "releases",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSet.VendorIdentifier => "vendorIdentifier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSet? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSet.GameCenterDetail,
                "gameCenterGroup" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSet.GameCenterGroup,
                "gameCenterLeaderboards" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSet.GameCenterLeaderboards,
                "groupLeaderboardSet" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSet.GroupLeaderboardSet,
                "localizations" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSet.Localizations,
                "referenceName" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSet.ReferenceName,
                "releases" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSet.Releases,
                "vendorIdentifier" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSet.VendorIdentifier,
                _ => null,
            };
        }
    }
}