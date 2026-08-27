
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSetRelease
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterDetail,
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardSet,
        /// <summary>
        /// 
        /// </summary>
        Live,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSetReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSetRelease value)
        {
            return value switch
            {
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSetRelease.GameCenterDetail => "gameCenterDetail",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSetRelease.GameCenterLeaderboardSet => "gameCenterLeaderboardSet",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSetRelease.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSetRelease? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSetRelease.GameCenterDetail,
                "gameCenterLeaderboardSet" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSetRelease.GameCenterLeaderboardSet,
                "live" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardSetRelease.Live,
                _ => null,
            };
        }
    }
}