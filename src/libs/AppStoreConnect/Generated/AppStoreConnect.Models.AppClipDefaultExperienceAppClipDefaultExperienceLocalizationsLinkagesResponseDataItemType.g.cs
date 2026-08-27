
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipDefaultExperienceAppClipDefaultExperienceLocalizationsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppClipDefaultExperienceLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipDefaultExperienceAppClipDefaultExperienceLocalizationsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperienceAppClipDefaultExperienceLocalizationsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppClipDefaultExperienceAppClipDefaultExperienceLocalizationsLinkagesResponseDataItemType.AppClipDefaultExperienceLocalizations => "appClipDefaultExperienceLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperienceAppClipDefaultExperienceLocalizationsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperienceLocalizations" => AppClipDefaultExperienceAppClipDefaultExperienceLocalizationsLinkagesResponseDataItemType.AppClipDefaultExperienceLocalizations,
                _ => null,
            };
        }
    }
}