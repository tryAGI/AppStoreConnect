
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        AppClipDefaultExperience,
        /// <summary>
        /// 
        /// </summary>
        AppClipHeaderImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedIncludeItem.AppClipDefaultExperience => "appClipDefaultExperience",
                AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedIncludeItem.AppClipHeaderImage => "appClipHeaderImage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperience" => AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedIncludeItem.AppClipDefaultExperience,
                "appClipHeaderImage" => AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedIncludeItem.AppClipHeaderImage,
                _ => null,
            };
        }
    }
}