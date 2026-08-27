
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet
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
    public static class GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet.GameCenterGroup => "gameCenterGroup",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet.GroupLeaderboardSet => "groupLeaderboardSet",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet.Localizations => "localizations",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet.ReferenceName => "referenceName",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet.Releases => "releases",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet.VendorIdentifier => "vendorIdentifier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet.GameCenterDetail,
                "gameCenterGroup" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet.GameCenterGroup,
                "gameCenterLeaderboards" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet.GameCenterLeaderboards,
                "groupLeaderboardSet" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet.GroupLeaderboardSet,
                "localizations" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet.Localizations,
                "referenceName" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet.ReferenceName,
                "releases" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet.Releases,
                "vendorIdentifier" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet.VendorIdentifier,
                _ => null,
            };
        }
    }
}