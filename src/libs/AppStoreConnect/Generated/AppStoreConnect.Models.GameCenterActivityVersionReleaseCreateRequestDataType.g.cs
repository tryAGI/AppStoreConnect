
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivityVersionReleaseCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterActivityVersionReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivityVersionReleaseCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityVersionReleaseCreateRequestDataType value)
        {
            return value switch
            {
                GameCenterActivityVersionReleaseCreateRequestDataType.GameCenterActivityVersionReleases => "gameCenterActivityVersionReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityVersionReleaseCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivityVersionReleases" => GameCenterActivityVersionReleaseCreateRequestDataType.GameCenterActivityVersionReleases,
                _ => null,
            };
        }
    }
}