
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperience
    {
        /// <summary>
        ///
        /// </summary>
        Action,
        /// <summary>
        ///
        /// </summary>
        AppClip,
        /// <summary>
        ///
        /// </summary>
        AppClipAppStoreReviewDetail,
        /// <summary>
        ///
        /// </summary>
        AppClipDefaultExperienceLocalizations,
        /// <summary>
        ///
        /// </summary>
        ReleaseWithAppStoreVersion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperienceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperience value)
        {
            return value switch
            {
                AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperience.Action => "action",
                AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperience.AppClip => "appClip",
                AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperience.AppClipAppStoreReviewDetail => "appClipAppStoreReviewDetail",
                AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperience.AppClipDefaultExperienceLocalizations => "appClipDefaultExperienceLocalizations",
                AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperience.ReleaseWithAppStoreVersion => "releaseWithAppStoreVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperience? ToEnum(string value)
        {
            return value switch
            {
                "action" => AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperience.Action,
                "appClip" => AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperience.AppClip,
                "appClipAppStoreReviewDetail" => AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperience.AppClipAppStoreReviewDetail,
                "appClipDefaultExperienceLocalizations" => AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperience.AppClipDefaultExperienceLocalizations,
                "releaseWithAppStoreVersion" => AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperience.ReleaseWithAppStoreVersion,
                _ => null,
            };
        }
    }
}