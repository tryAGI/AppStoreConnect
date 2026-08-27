
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedIncludeItem
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
    public static class AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedIncludeItem.AppClip => "appClip",
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedIncludeItem.AppClipAppStoreReviewDetail => "appClipAppStoreReviewDetail",
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedIncludeItem.AppClipDefaultExperienceLocalizations => "appClipDefaultExperienceLocalizations",
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedIncludeItem.ReleaseWithAppStoreVersion => "releaseWithAppStoreVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appClip" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedIncludeItem.AppClip,
                "appClipAppStoreReviewDetail" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedIncludeItem.AppClipAppStoreReviewDetail,
                "appClipDefaultExperienceLocalizations" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedIncludeItem.AppClipDefaultExperienceLocalizations,
                "releaseWithAppStoreVersion" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedIncludeItem.ReleaseWithAppStoreVersion,
                _ => null,
            };
        }
    }
}