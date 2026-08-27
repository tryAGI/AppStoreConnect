
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsActivityReleasesGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailsActivityReleasesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsActivityReleasesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterDetailsActivityReleasesGetToManyRelatedIncludeItem.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsActivityReleasesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "version" => GameCenterDetailsActivityReleasesGetToManyRelatedIncludeItem.Version,
                _ => null,
            };
        }
    }
}