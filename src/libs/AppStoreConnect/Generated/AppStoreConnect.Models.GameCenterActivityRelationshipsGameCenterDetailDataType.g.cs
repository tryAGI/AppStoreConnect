
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivityRelationshipsGameCenterDetailDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterDetails,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivityRelationshipsGameCenterDetailDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityRelationshipsGameCenterDetailDataType value)
        {
            return value switch
            {
                GameCenterActivityRelationshipsGameCenterDetailDataType.GameCenterDetails => "gameCenterDetails",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityRelationshipsGameCenterDetailDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetails" => GameCenterActivityRelationshipsGameCenterDetailDataType.GameCenterDetails,
                _ => null,
            };
        }
    }
}