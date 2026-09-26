
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterDetailPlayer
    {
        /// <summary>
        ///
        /// </summary>
        Blocked,
        /// <summary>
        ///
        /// </summary>
        BundleId,
        /// <summary>
        ///
        /// </summary>
        Nickname,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterDetailPlayerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterDetailPlayer value)
        {
            return value switch
            {
                GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterDetailPlayer.Blocked => "blocked",
                GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterDetailPlayer.BundleId => "bundleId",
                GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterDetailPlayer.Nickname => "nickname",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterDetailPlayer? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterDetailPlayer.Blocked,
                "bundleId" => GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterDetailPlayer.BundleId,
                "nickname" => GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterDetailPlayer.Nickname,
                _ => null,
            };
        }
    }
}