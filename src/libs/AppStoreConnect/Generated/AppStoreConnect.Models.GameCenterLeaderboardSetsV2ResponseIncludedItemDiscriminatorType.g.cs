
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardSetsV2ResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterDetails,
        /// <summary>
        /// 
        /// </summary>
        GameCenterGroups,
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardSetVersions,
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboards,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetsV2ResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetsV2ResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterLeaderboardSetsV2ResponseIncludedItemDiscriminatorType.GameCenterDetails => "gameCenterDetails",
                GameCenterLeaderboardSetsV2ResponseIncludedItemDiscriminatorType.GameCenterGroups => "gameCenterGroups",
                GameCenterLeaderboardSetsV2ResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSetVersions => "gameCenterLeaderboardSetVersions",
                GameCenterLeaderboardSetsV2ResponseIncludedItemDiscriminatorType.GameCenterLeaderboards => "gameCenterLeaderboards",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetsV2ResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetails" => GameCenterLeaderboardSetsV2ResponseIncludedItemDiscriminatorType.GameCenterDetails,
                "gameCenterGroups" => GameCenterLeaderboardSetsV2ResponseIncludedItemDiscriminatorType.GameCenterGroups,
                "gameCenterLeaderboardSetVersions" => GameCenterLeaderboardSetsV2ResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSetVersions,
                "gameCenterLeaderboards" => GameCenterLeaderboardSetsV2ResponseIncludedItemDiscriminatorType.GameCenterLeaderboards,
                _ => null,
            };
        }
    }
}