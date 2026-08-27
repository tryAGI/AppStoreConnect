
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipAdvancedExperienceResponseIncludedItemDiscriminatorType
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
    public static class AppClipAdvancedExperienceResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperienceResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppClipAdvancedExperienceResponseIncludedItemDiscriminatorType.AppClipAdvancedExperienceImages => "appClipAdvancedExperienceImages",
                AppClipAdvancedExperienceResponseIncludedItemDiscriminatorType.AppClipAdvancedExperienceLocalizations => "appClipAdvancedExperienceLocalizations",
                AppClipAdvancedExperienceResponseIncludedItemDiscriminatorType.AppClips => "appClips",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperienceResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appClipAdvancedExperienceImages" => AppClipAdvancedExperienceResponseIncludedItemDiscriminatorType.AppClipAdvancedExperienceImages,
                "appClipAdvancedExperienceLocalizations" => AppClipAdvancedExperienceResponseIncludedItemDiscriminatorType.AppClipAdvancedExperienceLocalizations,
                "appClips" => AppClipAdvancedExperienceResponseIncludedItemDiscriminatorType.AppClips,
                _ => null,
            };
        }
    }
}