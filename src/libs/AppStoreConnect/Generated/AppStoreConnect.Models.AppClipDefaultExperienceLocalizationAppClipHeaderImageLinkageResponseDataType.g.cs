
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipDefaultExperienceLocalizationAppClipHeaderImageLinkageResponseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppClipHeaderImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipDefaultExperienceLocalizationAppClipHeaderImageLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperienceLocalizationAppClipHeaderImageLinkageResponseDataType value)
        {
            return value switch
            {
                AppClipDefaultExperienceLocalizationAppClipHeaderImageLinkageResponseDataType.AppClipHeaderImages => "appClipHeaderImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperienceLocalizationAppClipHeaderImageLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "appClipHeaderImages" => AppClipDefaultExperienceLocalizationAppClipHeaderImageLinkageResponseDataType.AppClipHeaderImages,
                _ => null,
            };
        }
    }
}