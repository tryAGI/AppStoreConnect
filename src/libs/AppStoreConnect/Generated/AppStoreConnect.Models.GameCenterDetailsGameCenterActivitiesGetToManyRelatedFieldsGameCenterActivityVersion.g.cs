
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion
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
    public static class GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion.Activity => "activity",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion.DefaultImage => "defaultImage",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion.FallbackUrl => "fallbackUrl",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion.Localizations => "localizations",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion.Releases => "releases",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion.State => "state",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion.Activity,
                "defaultImage" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion.DefaultImage,
                "fallbackUrl" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion.FallbackUrl,
                "localizations" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion.Localizations,
                "releases" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion.Releases,
                "state" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion.State,
                "version" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion.Version,
                _ => null,
            };
        }
    }
}