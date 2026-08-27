
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSet
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
        ReferenceName,
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
    public static class GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSet value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSet.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSet.GameCenterGroup => "gameCenterGroup",
                GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSet.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSet.ReferenceName => "referenceName",
                GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSet.VendorIdentifier => "vendorIdentifier",
                GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSet.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSet? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSet.GameCenterDetail,
                "gameCenterGroup" => GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSet.GameCenterGroup,
                "gameCenterLeaderboards" => GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSet.GameCenterLeaderboards,
                "referenceName" => GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSet.ReferenceName,
                "vendorIdentifier" => GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSet.VendorIdentifier,
                "versions" => GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSet.Versions,
                _ => null,
            };
        }
    }
}