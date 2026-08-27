
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivityVersionRelationshipsActivityDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterActivities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivityVersionRelationshipsActivityDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityVersionRelationshipsActivityDataType value)
        {
            return value switch
            {
                GameCenterActivityVersionRelationshipsActivityDataType.GameCenterActivities => "gameCenterActivities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityVersionRelationshipsActivityDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivities" => GameCenterActivityVersionRelationshipsActivityDataType.GameCenterActivities,
                _ => null,
            };
        }
    }
}