
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterActivitiesGetInstanceFieldsGameCenterActivityVersion
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
    public static class GameCenterActivitiesGetInstanceFieldsGameCenterActivityVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivitiesGetInstanceFieldsGameCenterActivityVersion value)
        {
            return value switch
            {
                GameCenterActivitiesGetInstanceFieldsGameCenterActivityVersion.Activity => "activity",
                GameCenterActivitiesGetInstanceFieldsGameCenterActivityVersion.DefaultImage => "defaultImage",
                GameCenterActivitiesGetInstanceFieldsGameCenterActivityVersion.FallbackUrl => "fallbackUrl",
                GameCenterActivitiesGetInstanceFieldsGameCenterActivityVersion.Localizations => "localizations",
                GameCenterActivitiesGetInstanceFieldsGameCenterActivityVersion.Releases => "releases",
                GameCenterActivitiesGetInstanceFieldsGameCenterActivityVersion.State => "state",
                GameCenterActivitiesGetInstanceFieldsGameCenterActivityVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivitiesGetInstanceFieldsGameCenterActivityVersion? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterActivitiesGetInstanceFieldsGameCenterActivityVersion.Activity,
                "defaultImage" => GameCenterActivitiesGetInstanceFieldsGameCenterActivityVersion.DefaultImage,
                "fallbackUrl" => GameCenterActivitiesGetInstanceFieldsGameCenterActivityVersion.FallbackUrl,
                "localizations" => GameCenterActivitiesGetInstanceFieldsGameCenterActivityVersion.Localizations,
                "releases" => GameCenterActivitiesGetInstanceFieldsGameCenterActivityVersion.Releases,
                "state" => GameCenterActivitiesGetInstanceFieldsGameCenterActivityVersion.State,
                "version" => GameCenterActivitiesGetInstanceFieldsGameCenterActivityVersion.Version,
                _ => null,
            };
        }
    }
}