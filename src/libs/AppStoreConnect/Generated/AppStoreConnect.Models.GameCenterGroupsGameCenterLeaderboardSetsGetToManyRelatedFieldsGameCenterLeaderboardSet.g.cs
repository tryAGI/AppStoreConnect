
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet
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
    public static class GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet.GroupLeaderboardSet => "groupLeaderboardSet",
                GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet.Localizations => "localizations",
                GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet.ReferenceName => "referenceName",
                GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet.Releases => "releases",
                GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet.VendorIdentifier => "vendorIdentifier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet.GameCenterDetail,
                "gameCenterGroup" => GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet.GameCenterGroup,
                "gameCenterLeaderboards" => GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet.GameCenterLeaderboards,
                "groupLeaderboardSet" => GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet.GroupLeaderboardSet,
                "localizations" => GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet.Localizations,
                "referenceName" => GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet.ReferenceName,
                "releases" => GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet.Releases,
                "vendorIdentifier" => GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardSet.VendorIdentifier,
                _ => null,
            };
        }
    }
}