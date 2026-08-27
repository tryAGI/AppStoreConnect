
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipsAppClipDefaultExperiencesGetToManyRelatedIncludeItem
    {
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
    public static class AppClipsAppClipDefaultExperiencesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipsAppClipDefaultExperiencesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppClipsAppClipDefaultExperiencesGetToManyRelatedIncludeItem.AppClip => "appClip",
                AppClipsAppClipDefaultExperiencesGetToManyRelatedIncludeItem.AppClipAppStoreReviewDetail => "appClipAppStoreReviewDetail",
                AppClipsAppClipDefaultExperiencesGetToManyRelatedIncludeItem.AppClipDefaultExperienceLocalizations => "appClipDefaultExperienceLocalizations",
                AppClipsAppClipDefaultExperiencesGetToManyRelatedIncludeItem.ReleaseWithAppStoreVersion => "releaseWithAppStoreVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipsAppClipDefaultExperiencesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appClip" => AppClipsAppClipDefaultExperiencesGetToManyRelatedIncludeItem.AppClip,
                "appClipAppStoreReviewDetail" => AppClipsAppClipDefaultExperiencesGetToManyRelatedIncludeItem.AppClipAppStoreReviewDetail,
                "appClipDefaultExperienceLocalizations" => AppClipsAppClipDefaultExperiencesGetToManyRelatedIncludeItem.AppClipDefaultExperienceLocalizations,
                "releaseWithAppStoreVersion" => AppClipsAppClipDefaultExperiencesGetToManyRelatedIncludeItem.ReleaseWithAppStoreVersion,
                _ => null,
            };
        }
    }
}