
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupGameCenterDetailsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterDetails,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterGroupGameCenterDetailsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupGameCenterDetailsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                GameCenterGroupGameCenterDetailsLinkagesResponseDataItemType.GameCenterDetails => "gameCenterDetails",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupGameCenterDetailsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetails" => GameCenterGroupGameCenterDetailsLinkagesResponseDataItemType.GameCenterDetails,
                _ => null,
            };
        }
    }
}