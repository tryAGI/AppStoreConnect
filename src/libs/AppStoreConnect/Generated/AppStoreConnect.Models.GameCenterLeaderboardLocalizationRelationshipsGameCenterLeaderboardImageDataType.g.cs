
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardImageDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardImageDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardImageDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardImageDataType.GameCenterLeaderboardImages => "gameCenterLeaderboardImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardImageDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardImages" => GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardImageDataType.GameCenterLeaderboardImages,
                _ => null,
            };
        }
    }
}