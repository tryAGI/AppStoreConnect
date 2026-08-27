
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSet
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
    public static class GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSet value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSet.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSet.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSet.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSet.GroupLeaderboardSet => "groupLeaderboardSet",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSet.Localizations => "localizations",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSet.ReferenceName => "referenceName",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSet.Releases => "releases",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSet.VendorIdentifier => "vendorIdentifier",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSet.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSet? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSet.GameCenterDetail,
                "gameCenterGroup" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSet.GameCenterGroup,
                "gameCenterLeaderboards" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSet.GameCenterLeaderboards,
                "groupLeaderboardSet" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSet.GroupLeaderboardSet,
                "localizations" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSet.Localizations,
                "referenceName" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSet.ReferenceName,
                "releases" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSet.Releases,
                "vendorIdentifier" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSet.VendorIdentifier,
                "versions" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSet.Versions,
                _ => null,
            };
        }
    }
}