
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipDefaultExperiencesResponseIncludedItemDiscriminatorType
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
    public static class AppClipDefaultExperiencesResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperiencesResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppClipDefaultExperiencesResponseIncludedItemDiscriminatorType.AppClipAppStoreReviewDetails => "appClipAppStoreReviewDetails",
                AppClipDefaultExperiencesResponseIncludedItemDiscriminatorType.AppClipDefaultExperienceLocalizations => "appClipDefaultExperienceLocalizations",
                AppClipDefaultExperiencesResponseIncludedItemDiscriminatorType.AppClips => "appClips",
                AppClipDefaultExperiencesResponseIncludedItemDiscriminatorType.AppStoreVersions => "appStoreVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperiencesResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appClipAppStoreReviewDetails" => AppClipDefaultExperiencesResponseIncludedItemDiscriminatorType.AppClipAppStoreReviewDetails,
                "appClipDefaultExperienceLocalizations" => AppClipDefaultExperiencesResponseIncludedItemDiscriminatorType.AppClipDefaultExperienceLocalizations,
                "appClips" => AppClipDefaultExperiencesResponseIncludedItemDiscriminatorType.AppClips,
                "appStoreVersions" => AppClipDefaultExperiencesResponseIncludedItemDiscriminatorType.AppStoreVersions,
                _ => null,
            };
        }
    }
}