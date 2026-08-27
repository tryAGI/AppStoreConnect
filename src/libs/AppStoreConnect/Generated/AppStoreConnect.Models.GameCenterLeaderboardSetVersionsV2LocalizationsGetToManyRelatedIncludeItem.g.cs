
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedIncludeItem
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
    public static class GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedIncludeItem.Image => "image",
                GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedIncludeItem.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "image" => GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedIncludeItem.Image,
                "version" => GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedIncludeItem.Version,
                _ => null,
            };
        }
    }
}