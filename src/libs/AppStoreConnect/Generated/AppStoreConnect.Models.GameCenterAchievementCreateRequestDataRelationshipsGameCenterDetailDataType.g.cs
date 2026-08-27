
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementCreateRequestDataRelationshipsGameCenterDetailDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterDetails,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementCreateRequestDataRelationshipsGameCenterDetailDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementCreateRequestDataRelationshipsGameCenterDetailDataType value)
        {
            return value switch
            {
                GameCenterAchievementCreateRequestDataRelationshipsGameCenterDetailDataType.GameCenterDetails => "gameCenterDetails",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementCreateRequestDataRelationshipsGameCenterDetailDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetails" => GameCenterAchievementCreateRequestDataRelationshipsGameCenterDetailDataType.GameCenterDetails,
                _ => null,
            };
        }
    }
}