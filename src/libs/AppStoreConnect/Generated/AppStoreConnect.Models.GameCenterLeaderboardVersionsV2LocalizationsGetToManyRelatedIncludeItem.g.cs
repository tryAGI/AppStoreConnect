
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedIncludeItem.Image => "image",
                GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedIncludeItem.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "image" => GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedIncludeItem.Image,
                "version" => GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedIncludeItem.Version,
                _ => null,
            };
        }
    }
}