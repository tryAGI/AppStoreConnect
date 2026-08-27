
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet
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
    public static class GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet value)
        {
            return value switch
            {
                GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet.ReferenceName => "referenceName",
                GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet.VendorIdentifier => "vendorIdentifier",
                GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet.GameCenterDetail,
                "gameCenterGroup" => GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet.GameCenterGroup,
                "gameCenterLeaderboards" => GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet.GameCenterLeaderboards,
                "referenceName" => GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet.ReferenceName,
                "vendorIdentifier" => GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet.VendorIdentifier,
                "versions" => GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardSet.Versions,
                _ => null,
            };
        }
    }
}