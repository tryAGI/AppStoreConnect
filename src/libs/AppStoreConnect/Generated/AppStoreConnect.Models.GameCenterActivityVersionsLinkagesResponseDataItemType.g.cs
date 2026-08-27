
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivityVersionsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterActivityVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivityVersionsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityVersionsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                GameCenterActivityVersionsLinkagesResponseDataItemType.GameCenterActivityVersions => "gameCenterActivityVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityVersionsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivityVersions" => GameCenterActivityVersionsLinkagesResponseDataItemType.GameCenterActivityVersions,
                _ => null,
            };
        }
    }
}