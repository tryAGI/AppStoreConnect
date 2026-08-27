
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipDefaultExperienceLocalizationRelationshipsAppClipHeaderImageDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppClipHeaderImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipDefaultExperienceLocalizationRelationshipsAppClipHeaderImageDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperienceLocalizationRelationshipsAppClipHeaderImageDataType value)
        {
            return value switch
            {
                AppClipDefaultExperienceLocalizationRelationshipsAppClipHeaderImageDataType.AppClipHeaderImages => "appClipHeaderImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperienceLocalizationRelationshipsAppClipHeaderImageDataType? ToEnum(string value)
        {
            return value switch
            {
                "appClipHeaderImages" => AppClipDefaultExperienceLocalizationRelationshipsAppClipHeaderImageDataType.AppClipHeaderImages,
                _ => null,
            };
        }
    }
}