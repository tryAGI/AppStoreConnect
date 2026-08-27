
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivityUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterActivities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivityUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityUpdateRequestDataType value)
        {
            return value switch
            {
                GameCenterActivityUpdateRequestDataType.GameCenterActivities => "gameCenterActivities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivities" => GameCenterActivityUpdateRequestDataType.GameCenterActivities,
                _ => null,
            };
        }
    }
}