
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersion
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
    public static class GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersion value)
        {
            return value switch
            {
                GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersion.Activity => "activity",
                GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersion.DefaultImage => "defaultImage",
                GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersion.FallbackUrl => "fallbackUrl",
                GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersion.Localizations => "localizations",
                GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersion.Releases => "releases",
                GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersion.State => "state",
                GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersion? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersion.Activity,
                "defaultImage" => GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersion.DefaultImage,
                "fallbackUrl" => GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersion.FallbackUrl,
                "localizations" => GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersion.Localizations,
                "releases" => GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersion.Releases,
                "state" => GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersion.State,
                "version" => GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersion.Version,
                _ => null,
            };
        }
    }
}