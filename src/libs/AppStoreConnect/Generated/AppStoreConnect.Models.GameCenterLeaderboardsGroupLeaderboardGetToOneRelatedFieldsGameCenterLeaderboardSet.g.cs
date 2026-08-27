
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSet
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
    public static class GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSet value)
        {
            return value switch
            {
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSet.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSet.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSet.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSet.GroupLeaderboardSet => "groupLeaderboardSet",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSet.Localizations => "localizations",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSet.ReferenceName => "referenceName",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSet.Releases => "releases",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSet.VendorIdentifier => "vendorIdentifier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSet? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSet.GameCenterDetail,
                "gameCenterGroup" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSet.GameCenterGroup,
                "gameCenterLeaderboards" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSet.GameCenterLeaderboards,
                "groupLeaderboardSet" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSet.GroupLeaderboardSet,
                "localizations" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSet.Localizations,
                "referenceName" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSet.ReferenceName,
                "releases" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSet.Releases,
                "vendorIdentifier" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardSet.VendorIdentifier,
                _ => null,
            };
        }
    }
}