
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion
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
    public static class GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion.Activity => "activity",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion.DefaultImage => "defaultImage",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion.FallbackUrl => "fallbackUrl",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion.Localizations => "localizations",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion.Releases => "releases",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion.State => "state",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion.Activity,
                "defaultImage" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion.DefaultImage,
                "fallbackUrl" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion.FallbackUrl,
                "localizations" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion.Localizations,
                "releases" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion.Releases,
                "state" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion.State,
                "version" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion.Version,
                _ => null,
            };
        }
    }
}