
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivityVersionsLocalizationsGetToManyRelatedIncludeItem
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
    public static class GameCenterActivityVersionsLocalizationsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityVersionsLocalizationsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterActivityVersionsLocalizationsGetToManyRelatedIncludeItem.Image => "image",
                GameCenterActivityVersionsLocalizationsGetToManyRelatedIncludeItem.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityVersionsLocalizationsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "image" => GameCenterActivityVersionsLocalizationsGetToManyRelatedIncludeItem.Image,
                "version" => GameCenterActivityVersionsLocalizationsGetToManyRelatedIncludeItem.Version,
                _ => null,
            };
        }
    }
}