
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipAppClipDefaultExperiencesLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppClipDefaultExperiences,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipAppClipDefaultExperiencesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAppClipDefaultExperiencesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppClipAppClipDefaultExperiencesLinkagesResponseDataItemType.AppClipDefaultExperiences => "appClipDefaultExperiences",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAppClipDefaultExperiencesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperiences" => AppClipAppClipDefaultExperiencesLinkagesResponseDataItemType.AppClipDefaultExperiences,
                _ => null,
            };
        }
    }
}