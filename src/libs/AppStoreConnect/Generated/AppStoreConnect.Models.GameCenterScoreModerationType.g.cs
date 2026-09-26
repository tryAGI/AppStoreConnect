
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterScoreModerationType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterScoreModerations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterScoreModerationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterScoreModerationType value)
        {
            return value switch
            {
                GameCenterScoreModerationType.GameCenterScoreModerations => "gameCenterScoreModerations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterScoreModerationType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterScoreModerations" => GameCenterScoreModerationType.GameCenterScoreModerations,
                _ => null,
            };
        }
    }
}