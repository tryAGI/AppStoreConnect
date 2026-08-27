
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipAdvancedExperiencesResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        AppClipAdvancedExperienceImages,
        /// <summary>
        /// 
        /// </summary>
        AppClipAdvancedExperienceLocalizations,
        /// <summary>
        /// 
        /// </summary>
        AppClips,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipAdvancedExperiencesResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperiencesResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppClipAdvancedExperiencesResponseIncludedItemDiscriminatorType.AppClipAdvancedExperienceImages => "appClipAdvancedExperienceImages",
                AppClipAdvancedExperiencesResponseIncludedItemDiscriminatorType.AppClipAdvancedExperienceLocalizations => "appClipAdvancedExperienceLocalizations",
                AppClipAdvancedExperiencesResponseIncludedItemDiscriminatorType.AppClips => "appClips",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperiencesResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appClipAdvancedExperienceImages" => AppClipAdvancedExperiencesResponseIncludedItemDiscriminatorType.AppClipAdvancedExperienceImages,
                "appClipAdvancedExperienceLocalizations" => AppClipAdvancedExperiencesResponseIncludedItemDiscriminatorType.AppClipAdvancedExperienceLocalizations,
                "appClips" => AppClipAdvancedExperiencesResponseIncludedItemDiscriminatorType.AppClips,
                _ => null,
            };
        }
    }
}