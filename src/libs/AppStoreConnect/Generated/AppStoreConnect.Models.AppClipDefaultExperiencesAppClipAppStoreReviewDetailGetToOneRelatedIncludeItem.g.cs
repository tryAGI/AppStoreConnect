
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        AppClipDefaultExperience,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedIncludeItem.AppClipDefaultExperience => "appClipDefaultExperience",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperience" => AppClipDefaultExperiencesAppClipAppStoreReviewDetailGetToOneRelatedIncludeItem.AppClipDefaultExperience,
                _ => null,
            };
        }
    }
}