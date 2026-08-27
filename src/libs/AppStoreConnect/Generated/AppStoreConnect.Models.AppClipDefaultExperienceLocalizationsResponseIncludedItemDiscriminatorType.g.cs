
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipDefaultExperienceLocalizationsResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        AppClipDefaultExperiences,
        /// <summary>
        /// 
        /// </summary>
        AppClipHeaderImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipDefaultExperienceLocalizationsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperienceLocalizationsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppClipDefaultExperienceLocalizationsResponseIncludedItemDiscriminatorType.AppClipDefaultExperiences => "appClipDefaultExperiences",
                AppClipDefaultExperienceLocalizationsResponseIncludedItemDiscriminatorType.AppClipHeaderImages => "appClipHeaderImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperienceLocalizationsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperiences" => AppClipDefaultExperienceLocalizationsResponseIncludedItemDiscriminatorType.AppClipDefaultExperiences,
                "appClipHeaderImages" => AppClipDefaultExperienceLocalizationsResponseIncludedItemDiscriminatorType.AppClipHeaderImages,
                _ => null,
            };
        }
    }
}