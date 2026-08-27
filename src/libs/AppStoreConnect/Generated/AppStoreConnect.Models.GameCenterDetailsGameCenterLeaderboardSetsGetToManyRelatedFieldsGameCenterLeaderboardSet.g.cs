
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet
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
    public static class GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet.GameCenterGroup => "gameCenterGroup",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet.GroupLeaderboardSet => "groupLeaderboardSet",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet.Localizations => "localizations",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet.ReferenceName => "referenceName",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet.Releases => "releases",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet.VendorIdentifier => "vendorIdentifier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet.GameCenterDetail,
                "gameCenterGroup" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet.GameCenterGroup,
                "gameCenterLeaderboards" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet.GameCenterLeaderboards,
                "groupLeaderboardSet" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet.GroupLeaderboardSet,
                "localizations" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet.Localizations,
                "referenceName" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet.ReferenceName,
                "releases" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet.Releases,
                "vendorIdentifier" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet.VendorIdentifier,
                _ => null,
            };
        }
    }
}