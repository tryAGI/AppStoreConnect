
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityVersion
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
        FallbackUrl,
        /// <summary>
        ///
        /// </summary>
        Localizations,
        /// <summary>
        ///
        /// </summary>
        Releases,
        /// <summary>
        ///
        /// </summary>
        State,
        /// <summary>
        ///
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityVersion value)
        {
            return value switch
            {
                GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityVersion.Activity => "activity",
                GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityVersion.DefaultImage => "defaultImage",
                GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityVersion.FallbackUrl => "fallbackUrl",
                GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityVersion.Localizations => "localizations",
                GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityVersion.Releases => "releases",
                GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityVersion.State => "state",
                GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityVersion? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityVersion.Activity,
                "defaultImage" => GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityVersion.DefaultImage,
                "fallbackUrl" => GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityVersion.FallbackUrl,
                "localizations" => GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityVersion.Localizations,
                "releases" => GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityVersion.Releases,
                "state" => GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityVersion.State,
                "version" => GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityVersion.Version,
                _ => null,
            };
        }
    }
}