
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivityVersionReleaseCreateRequestDataRelationshipsVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterActivityVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivityVersionReleaseCreateRequestDataRelationshipsVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityVersionReleaseCreateRequestDataRelationshipsVersionDataType value)
        {
            return value switch
            {
                GameCenterActivityVersionReleaseCreateRequestDataRelationshipsVersionDataType.GameCenterActivityVersions => "gameCenterActivityVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityVersionReleaseCreateRequestDataRelationshipsVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivityVersions" => GameCenterActivityVersionReleaseCreateRequestDataRelationshipsVersionDataType.GameCenterActivityVersions,
                _ => null,
            };
        }
    }
}