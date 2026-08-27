
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterAchievementVersion
    {
        /// <summary>
        /// 
        /// </summary>
        Achievement,
        /// <summary>
        /// 
        /// </summary>
        Localizations,
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
    public static class ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterAchievementVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterAchievementVersion value)
        {
            return value switch
            {
                ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterAchievementVersion.Achievement => "achievement",
                ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterAchievementVersion.Localizations => "localizations",
                ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterAchievementVersion.State => "state",
                ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterAchievementVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterAchievementVersion? ToEnum(string value)
        {
            return value switch
            {
                "achievement" => ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterAchievementVersion.Achievement,
                "localizations" => ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterAchievementVersion.Localizations,
                "state" => ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterAchievementVersion.State,
                "version" => ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterAchievementVersion.Version,
                _ => null,
            };
        }
    }
}