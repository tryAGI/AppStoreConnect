
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterScoreModerationUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterScoreModerations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterScoreModerationUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterScoreModerationUpdateRequestDataType value)
        {
            return value switch
            {
                GameCenterScoreModerationUpdateRequestDataType.GameCenterScoreModerations => "gameCenterScoreModerations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterScoreModerationUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterScoreModerations" => GameCenterScoreModerationUpdateRequestDataType.GameCenterScoreModerations,
                _ => null,
            };
        }
    }
}