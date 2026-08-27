
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipDefaultExperienceResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        AppClipAppStoreReviewDetails,
        /// <summary>
        ///
        /// </summary>
        AppClipDefaultExperienceLocalizations,
        /// <summary>
        ///
        /// </summary>
        AppClips,
        /// <summary>
        ///
        /// </summary>
        AppStoreVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipDefaultExperienceResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperienceResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppClipDefaultExperienceResponseIncludedItemDiscriminatorType.AppClipAppStoreReviewDetails => "appClipAppStoreReviewDetails",
                AppClipDefaultExperienceResponseIncludedItemDiscriminatorType.AppClipDefaultExperienceLocalizations => "appClipDefaultExperienceLocalizations",
                AppClipDefaultExperienceResponseIncludedItemDiscriminatorType.AppClips => "appClips",
                AppClipDefaultExperienceResponseIncludedItemDiscriminatorType.AppStoreVersions => "appStoreVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperienceResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appClipAppStoreReviewDetails" => AppClipDefaultExperienceResponseIncludedItemDiscriminatorType.AppClipAppStoreReviewDetails,
                "appClipDefaultExperienceLocalizations" => AppClipDefaultExperienceResponseIncludedItemDiscriminatorType.AppClipDefaultExperienceLocalizations,
                "appClips" => AppClipDefaultExperienceResponseIncludedItemDiscriminatorType.AppClips,
                "appStoreVersions" => AppClipDefaultExperienceResponseIncludedItemDiscriminatorType.AppStoreVersions,
                _ => null,
            };
        }
    }
}