
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipAdvancedExperienceRelationshipsHeaderImageDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppClipAdvancedExperienceImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipAdvancedExperienceRelationshipsHeaderImageDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperienceRelationshipsHeaderImageDataType value)
        {
            return value switch
            {
                AppClipAdvancedExperienceRelationshipsHeaderImageDataType.AppClipAdvancedExperienceImages => "appClipAdvancedExperienceImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperienceRelationshipsHeaderImageDataType? ToEnum(string value)
        {
            return value switch
            {
                "appClipAdvancedExperienceImages" => AppClipAdvancedExperienceRelationshipsHeaderImageDataType.AppClipAdvancedExperienceImages,
                _ => null,
            };
        }
    }
}