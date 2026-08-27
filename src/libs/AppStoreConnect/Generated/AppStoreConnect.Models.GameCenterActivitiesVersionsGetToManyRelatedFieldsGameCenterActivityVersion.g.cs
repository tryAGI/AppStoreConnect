
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityVersion
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
    public static class GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityVersion value)
        {
            return value switch
            {
                GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityVersion.Activity => "activity",
                GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityVersion.DefaultImage => "defaultImage",
                GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityVersion.FallbackUrl => "fallbackUrl",
                GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityVersion.Localizations => "localizations",
                GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityVersion.Releases => "releases",
                GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityVersion.State => "state",
                GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityVersion? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityVersion.Activity,
                "defaultImage" => GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityVersion.DefaultImage,
                "fallbackUrl" => GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityVersion.FallbackUrl,
                "localizations" => GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityVersion.Localizations,
                "releases" => GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityVersion.Releases,
                "state" => GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityVersion.State,
                "version" => GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityVersion.Version,
                _ => null,
            };
        }
    }
}