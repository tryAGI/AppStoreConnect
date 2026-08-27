
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityVersion
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
    public static class GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityVersion value)
        {
            return value switch
            {
                GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityVersion.Activity => "activity",
                GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityVersion.DefaultImage => "defaultImage",
                GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityVersion.FallbackUrl => "fallbackUrl",
                GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityVersion.Localizations => "localizations",
                GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityVersion.Releases => "releases",
                GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityVersion.State => "state",
                GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityVersion? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityVersion.Activity,
                "defaultImage" => GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityVersion.DefaultImage,
                "fallbackUrl" => GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityVersion.FallbackUrl,
                "localizations" => GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityVersion.Localizations,
                "releases" => GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityVersion.Releases,
                "state" => GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityVersion.State,
                "version" => GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityVersion.Version,
                _ => null,
            };
        }
    }
}