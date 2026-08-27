
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardLocalizationV2RelationshipsImageDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardLocalizationV2RelationshipsImageDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardLocalizationV2RelationshipsImageDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardLocalizationV2RelationshipsImageDataType.GameCenterLeaderboardImages => "gameCenterLeaderboardImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardLocalizationV2RelationshipsImageDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardImages" => GameCenterLeaderboardLocalizationV2RelationshipsImageDataType.GameCenterLeaderboardImages,
                _ => null,
            };
        }
    }
}