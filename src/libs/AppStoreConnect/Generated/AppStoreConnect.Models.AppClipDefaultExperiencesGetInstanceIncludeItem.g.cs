
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipDefaultExperiencesGetInstanceIncludeItem
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
    public static class AppClipDefaultExperiencesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperiencesGetInstanceIncludeItem value)
        {
            return value switch
            {
                AppClipDefaultExperiencesGetInstanceIncludeItem.AppClip => "appClip",
                AppClipDefaultExperiencesGetInstanceIncludeItem.AppClipAppStoreReviewDetail => "appClipAppStoreReviewDetail",
                AppClipDefaultExperiencesGetInstanceIncludeItem.AppClipDefaultExperienceLocalizations => "appClipDefaultExperienceLocalizations",
                AppClipDefaultExperiencesGetInstanceIncludeItem.ReleaseWithAppStoreVersion => "releaseWithAppStoreVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperiencesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appClip" => AppClipDefaultExperiencesGetInstanceIncludeItem.AppClip,
                "appClipAppStoreReviewDetail" => AppClipDefaultExperiencesGetInstanceIncludeItem.AppClipAppStoreReviewDetail,
                "appClipDefaultExperienceLocalizations" => AppClipDefaultExperiencesGetInstanceIncludeItem.AppClipDefaultExperienceLocalizations,
                "releaseWithAppStoreVersion" => AppClipDefaultExperiencesGetInstanceIncludeItem.ReleaseWithAppStoreVersion,
                _ => null,
            };
        }
    }
}