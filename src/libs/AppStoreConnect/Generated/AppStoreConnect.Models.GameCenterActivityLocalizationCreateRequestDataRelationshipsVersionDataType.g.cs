
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivityLocalizationCreateRequestDataRelationshipsVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterActivityVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivityLocalizationCreateRequestDataRelationshipsVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityLocalizationCreateRequestDataRelationshipsVersionDataType value)
        {
            return value switch
            {
                GameCenterActivityLocalizationCreateRequestDataRelationshipsVersionDataType.GameCenterActivityVersions => "gameCenterActivityVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityLocalizationCreateRequestDataRelationshipsVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivityVersions" => GameCenterActivityLocalizationCreateRequestDataRelationshipsVersionDataType.GameCenterActivityVersions,
                _ => null,
            };
        }
    }
}