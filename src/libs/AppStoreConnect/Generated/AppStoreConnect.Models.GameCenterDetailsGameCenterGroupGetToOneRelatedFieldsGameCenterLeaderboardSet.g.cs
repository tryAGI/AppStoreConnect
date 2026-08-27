
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboardSet
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
    public static class GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboardSetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboardSet value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboardSet.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboardSet.GameCenterGroup => "gameCenterGroup",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboardSet.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboardSet.GroupLeaderboardSet => "groupLeaderboardSet",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboardSet.Localizations => "localizations",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboardSet.ReferenceName => "referenceName",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboardSet.Releases => "releases",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboardSet.VendorIdentifier => "vendorIdentifier",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboardSet.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboardSet? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboardSet.GameCenterDetail,
                "gameCenterGroup" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboardSet.GameCenterGroup,
                "gameCenterLeaderboards" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboardSet.GameCenterLeaderboards,
                "groupLeaderboardSet" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboardSet.GroupLeaderboardSet,
                "localizations" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboardSet.Localizations,
                "referenceName" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboardSet.ReferenceName,
                "releases" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboardSet.Releases,
                "vendorIdentifier" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboardSet.VendorIdentifier,
                "versions" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboardSet.Versions,
                _ => null,
            };
        }
    }
}