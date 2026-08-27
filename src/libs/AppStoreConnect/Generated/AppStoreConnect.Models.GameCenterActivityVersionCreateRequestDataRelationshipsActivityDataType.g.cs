
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivityVersionCreateRequestDataRelationshipsActivityDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterActivities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivityVersionCreateRequestDataRelationshipsActivityDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityVersionCreateRequestDataRelationshipsActivityDataType value)
        {
            return value switch
            {
                GameCenterActivityVersionCreateRequestDataRelationshipsActivityDataType.GameCenterActivities => "gameCenterActivities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityVersionCreateRequestDataRelationshipsActivityDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivities" => GameCenterActivityVersionCreateRequestDataRelationshipsActivityDataType.GameCenterActivities,
                _ => null,
            };
        }
    }
}