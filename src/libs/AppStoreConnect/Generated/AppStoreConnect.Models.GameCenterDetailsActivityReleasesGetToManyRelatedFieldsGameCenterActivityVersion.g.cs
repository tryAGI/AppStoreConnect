
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersion
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
    public static class GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersion value)
        {
            return value switch
            {
                GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersion.Activity => "activity",
                GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersion.DefaultImage => "defaultImage",
                GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersion.FallbackUrl => "fallbackUrl",
                GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersion.Localizations => "localizations",
                GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersion.Releases => "releases",
                GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersion.State => "state",
                GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersion? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersion.Activity,
                "defaultImage" => GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersion.DefaultImage,
                "fallbackUrl" => GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersion.FallbackUrl,
                "localizations" => GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersion.Localizations,
                "releases" => GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersion.Releases,
                "state" => GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersion.State,
                "version" => GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersion.Version,
                _ => null,
            };
        }
    }
}