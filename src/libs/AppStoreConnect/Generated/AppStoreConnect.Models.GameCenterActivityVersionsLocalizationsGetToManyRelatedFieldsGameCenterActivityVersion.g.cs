
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityVersion
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
    public static class GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityVersion value)
        {
            return value switch
            {
                GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityVersion.Activity => "activity",
                GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityVersion.DefaultImage => "defaultImage",
                GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityVersion.FallbackUrl => "fallbackUrl",
                GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityVersion.Localizations => "localizations",
                GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityVersion.Releases => "releases",
                GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityVersion.State => "state",
                GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityVersion? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityVersion.Activity,
                "defaultImage" => GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityVersion.DefaultImage,
                "fallbackUrl" => GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityVersion.FallbackUrl,
                "localizations" => GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityVersion.Localizations,
                "releases" => GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityVersion.Releases,
                "state" => GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityVersion.State,
                "version" => GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityVersion.Version,
                _ => null,
            };
        }
    }
}