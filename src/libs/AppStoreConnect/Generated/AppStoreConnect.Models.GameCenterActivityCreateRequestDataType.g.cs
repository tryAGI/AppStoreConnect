
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivityCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterActivities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivityCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityCreateRequestDataType value)
        {
            return value switch
            {
                GameCenterActivityCreateRequestDataType.GameCenterActivities => "gameCenterActivities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivities" => GameCenterActivityCreateRequestDataType.GameCenterActivities,
                _ => null,
            };
        }
    }
}