
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivityVersionsGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Activity,
        /// <summary>
        ///
        /// </summary>
        DefaultImage,
        /// <summary>
        ///
        /// </summary>
        Localizations,
        /// <summary>
        ///
        /// </summary>
        Releases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivityVersionsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityVersionsGetInstanceIncludeItem value)
        {
            return value switch
            {
                GameCenterActivityVersionsGetInstanceIncludeItem.Activity => "activity",
                GameCenterActivityVersionsGetInstanceIncludeItem.DefaultImage => "defaultImage",
                GameCenterActivityVersionsGetInstanceIncludeItem.Localizations => "localizations",
                GameCenterActivityVersionsGetInstanceIncludeItem.Releases => "releases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityVersionsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterActivityVersionsGetInstanceIncludeItem.Activity,
                "defaultImage" => GameCenterActivityVersionsGetInstanceIncludeItem.DefaultImage,
                "localizations" => GameCenterActivityVersionsGetInstanceIncludeItem.Localizations,
                "releases" => GameCenterActivityVersionsGetInstanceIncludeItem.Releases,
                _ => null,
            };
        }
    }
}