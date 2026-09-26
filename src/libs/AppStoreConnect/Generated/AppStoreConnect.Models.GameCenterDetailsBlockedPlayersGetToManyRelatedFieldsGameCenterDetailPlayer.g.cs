
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsBlockedPlayersGetToManyRelatedFieldsGameCenterDetailPlayer
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
    public static class GameCenterDetailsBlockedPlayersGetToManyRelatedFieldsGameCenterDetailPlayerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsBlockedPlayersGetToManyRelatedFieldsGameCenterDetailPlayer value)
        {
            return value switch
            {
                GameCenterDetailsBlockedPlayersGetToManyRelatedFieldsGameCenterDetailPlayer.Blocked => "blocked",
                GameCenterDetailsBlockedPlayersGetToManyRelatedFieldsGameCenterDetailPlayer.BundleId => "bundleId",
                GameCenterDetailsBlockedPlayersGetToManyRelatedFieldsGameCenterDetailPlayer.Nickname => "nickname",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsBlockedPlayersGetToManyRelatedFieldsGameCenterDetailPlayer? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => GameCenterDetailsBlockedPlayersGetToManyRelatedFieldsGameCenterDetailPlayer.Blocked,
                "bundleId" => GameCenterDetailsBlockedPlayersGetToManyRelatedFieldsGameCenterDetailPlayer.BundleId,
                "nickname" => GameCenterDetailsBlockedPlayersGetToManyRelatedFieldsGameCenterDetailPlayer.Nickname,
                _ => null,
            };
        }
    }
}