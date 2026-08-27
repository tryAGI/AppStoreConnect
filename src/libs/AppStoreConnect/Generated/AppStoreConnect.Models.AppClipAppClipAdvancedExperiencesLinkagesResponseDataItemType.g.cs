
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipAppClipAdvancedExperiencesLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppClipAdvancedExperiences,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipAppClipAdvancedExperiencesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAppClipAdvancedExperiencesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppClipAppClipAdvancedExperiencesLinkagesResponseDataItemType.AppClipAdvancedExperiences => "appClipAdvancedExperiences",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAppClipAdvancedExperiencesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appClipAdvancedExperiences" => AppClipAppClipAdvancedExperiencesLinkagesResponseDataItemType.AppClipAdvancedExperiences,
                _ => null,
            };
        }
    }
}