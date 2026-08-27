
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivityImageCreateRequestDataRelationshipsLocalizationDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterActivityLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivityImageCreateRequestDataRelationshipsLocalizationDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityImageCreateRequestDataRelationshipsLocalizationDataType value)
        {
            return value switch
            {
                GameCenterActivityImageCreateRequestDataRelationshipsLocalizationDataType.GameCenterActivityLocalizations => "gameCenterActivityLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityImageCreateRequestDataRelationshipsLocalizationDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivityLocalizations" => GameCenterActivityImageCreateRequestDataRelationshipsLocalizationDataType.GameCenterActivityLocalizations,
                _ => null,
            };
        }
    }
}